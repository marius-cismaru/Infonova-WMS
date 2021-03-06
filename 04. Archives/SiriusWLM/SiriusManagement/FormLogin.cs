using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Security.Principal;
using System.Linq;

namespace Sirius.SiriusManagement
{
	public partial class FormLogin : Form
	{
        EntityModels.EntityModelSirius Model;
        private int timeWaitBetweenInitSteps = 200; //milisecunde

		public FormLogin()
		{
			InitializeComponent();
            Text = Settings.GetProgramNameFull() + " - Autentificare";
            labelProgramName.Text = Configuration.Main.AssemblyNameLong;
            labelProgramDescription.Text = Settings.ProgramDescription + " v" + Settings.GetProgramVersion();
            labelVersion.Text = "Versiune: " + Settings.GetProgramVersion() + " (" + Settings.ProgramUpdateDate + ")";
            buttonAuthenticate.Image = global::Sirius.CustomControls.Properties.Resources.icon_16_lock_open;
            buttonExit.Image = global::Sirius.CustomControls.Properties.Resources.icon_16_door_in;
		}

        private void PopulateSelectBoxCompanies(int userId)
        {
            EntityModels.Companies.CompanyCollection.PopulateSelectBox(new EntityModels.Companies.CompanyFilterCriteria { RestrictionAssignUserId = userId }, selectBoxCompany, 0, false);
            if (selectBoxCompany.Items.Count == 0)
            {
                selectBoxCompany.Items.Add("- Niciuna -");
                selectBoxCompany.SelectedIndex = 0;
            }
            else
            {
                buttonCompanySelect.Enabled = true;
            }
        }

		public delegate void UpdateProgressDelegate(string message, Color color, int percentage, bool canLogin);

		private void UpdateProgress(string message, Color color, int percentage, bool canLogin)
		{
			richTextBoxProgress.AppendText(message);
			richTextBoxProgress.SelectionStart = richTextBoxProgress.Text.Length - message.Length;
			richTextBoxProgress.SelectionLength = message.Length;
			richTextBoxProgress.SelectionColor = color;
			richTextBoxProgress.Select(richTextBoxProgress.Text.Length, 0);
            progressBarInit.Value = percentage;
			if (canLogin)
			{
                string updateErrorMessage = EntityModels.ConfigurationVersions.ConfigurationVersionCollection.CheckIfSameAsProgram();
                if (updateErrorMessage == string.Empty)
                //Versiunea modelului baza de date e ok
                {
                    textBoxUsername.Focus();
                    Model = new EntityModels.EntityModelSirius(Configuration.Main.SQLConnectionString);
                    //Check if windows user
                    //string windowsUserName = CommonLibs.ActiveDirectoryLib.GetWindowsCurrentThreadUser();
                    //string windowsUserDomain = CommonLibs.ActiveDirectoryLib.GetWindowsCurrentThreadDomain();
                    string windowsUserName = "paul";
                    string windowsUserDomain = "HELVETICA";
                    var windowsUser = EntityModels.Users.UserCollection.GetActiveByNameAndDomain(Model, windowsUserName, windowsUserDomain);
                    if (windowsUser != null)
                    {
                        Configuration.Main.LoggedUserId = windowsUser.Id;
                        Configuration.Main.LoggedUserUsername = windowsUser.Username;
                        Configuration.Main.LoggedUserName = windowsUser.Name;
                        textBoxUsername.Text = windowsUserName + " (" + windowsUserDomain + ")";
                        selectBoxCompany.Enabled = true;
                        PopulateSelectBoxCompanies(windowsUser.Id);
                    }
                    else
                    {
                        buttonAuthenticate.Enabled = true;
                        textBoxUsername.Enabled = true;
                        textBoxPassword.Enabled = true;
                        textBoxUsername.Focus();
                    }
                }
                else
                {
                    MessageBox.Show(updateErrorMessage, "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
			}
		}

		private bool ProgressStep1_CheckIfExistsConfigFile()
		{
			bool success = false;
			Invoke(new UpdateProgressDelegate(UpdateProgress), "Existenta fisier configurare .......... ", Color.Black, 0, false);
			Thread.Sleep(100);
			if (Configuration.Main.CheckIfConfigFileExists())
			{
				success = true;
				Invoke(new UpdateProgressDelegate(UpdateProgress), "OK\n", Color.Green, 33, false);
			}
			else
			{
				Invoke(new UpdateProgressDelegate(UpdateProgress), "EROARE\n", Color.Red, 0, false);
			}
            Thread.Sleep(timeWaitBetweenInitSteps);
			return success;
		}

		private bool ProgressStep2_ReadConfigFile()
		{
			bool success = false;
			Invoke(new UpdateProgressDelegate(UpdateProgress), "Citire configuratie ................... ", Color.Black, 20, false);
			Thread.Sleep(100);
			if (Configuration.Main.ReadConfigFromFile())
			{
				success = true;
				Invoke(new UpdateProgressDelegate(UpdateProgress), "OK\n", Color.Green, 66, false);
			}
			else
			{
				Invoke(new UpdateProgressDelegate(UpdateProgress), "EROARE\n", Color.Red, 33, false);
			}
            Thread.Sleep(timeWaitBetweenInitSteps);
			return success;
		}

		private bool ProgressStep3_CheckSQLConnection()
		{
			bool success = false;
			Invoke(new UpdateProgressDelegate(UpdateProgress), "Conectare la Baza de Date ............. ", Color.Black, 80, false);
			Thread.Sleep(100);
			if (Configuration.Main.CheckIfSQLConnectionOK())
			{
				success = true;
				Invoke(new UpdateProgressDelegate(UpdateProgress), "OK\n", Color.Green, 100, false);
			}
			else
			{
				Invoke(new UpdateProgressDelegate(UpdateProgress), "EROARE\n", Color.Red, 66, false);
			}
            Thread.Sleep(timeWaitBetweenInitSteps);
			return success;
		}

		private void InitializeAll()
		{	
			bool success = false;

			if (ProgressStep1_CheckIfExistsConfigFile())
			{
                if (ProgressStep2_ReadConfigFile())
                {
                    if (ProgressStep3_CheckSQLConnection())
                    {
                        success = true;
                    }
                }
			}
			if (success)
			{
				Invoke(new UpdateProgressDelegate(UpdateProgress), "\nInitializare incheiata cu succes!", Color.Green, 100, true);
			}
			else
			{
				Invoke(new UpdateProgressDelegate(UpdateProgress), "\nEroare la initializare!", Color.Red, 0, false);
			}
		}

		private void FormLogin_Shown(object sender, EventArgs e)
		{
			threadInitialize.Start();
		}

		private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
		{
			if(!threadInitialize.Join(100)) 
			{
				threadInitialize.Abort();
			}
		}

		private void FormLogin_Load(object sender, EventArgs e)
		{
			threadInitialize = new Thread(new ThreadStart(InitializeAll));
            threadInitialize.IsBackground = true;
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			/*bool authentic = false;
			try
			{
				DirectoryEntry entry = new DirectoryEntry("LDAP://" + "srvimo1011",
						textBoxUsername.Text, textBoxPassword.Text);
				object nativeObject = entry.NativeObject;
				authentic = true;
			}
			catch (DirectoryServicesCOMException) { }
			ToolMessage.Show(ToolMessage.Types.INFO, authentic.ToString() + " " + System.Environment.GetEnvironmentVariable("logonserver") + " " + WindowsIdentity.GetCurrent().Name);
			*/

			/*try
			{
				ObjectEmployee employee = new ObjectEmployee();
				employee.Authenticate(textBoxUsername.Text, textBoxPassword.Text);
				ToolConfiguration.EmployeeAuthenticatedId = employee.Id;
				DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				ToolMessage.Show(ToolMessage.Types.WARNING, ex.Message);
				textBoxPassword.Focus();
				textBoxPassword.SelectAll();
			}*/
            //DialogResult = System.Windows.Forms.DialogResult.OK;
		}

        private void buttonCompanySelect_Click(object sender, EventArgs e)
        {
            int companyId = selectBoxCompany.GetSelectedId();
            EntityModels.Company company = EntityModels.Companies.CompanyCollection.GetById(Model, companyId, false);
            if (company != null)
            {
                Configuration.Main.LoggedCompanyId = companyId;
                Configuration.Main.LoggedCompanyNameLong = company.NameLong;
                Configuration.Main.LoggedCompanyNameShort = company.NameShort;
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void buttonReinitialize_Click(object sender, EventArgs e)
        {
            try
            {
                threadInitialize.Abort();
                richTextBoxProgress.ResetText();
                threadInitialize = new Thread(new ThreadStart(InitializeAll));
                threadInitialize.IsBackground = true;
                threadInitialize.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la procesul de initializare" + Environment.NewLine + Environment.NewLine + ex.ToString(), "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
	}
}