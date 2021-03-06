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

namespace Sirius.SiriusAdmin
{
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
            Text = Settings.GetProgramNameFull() + " - Autentificare";
            labelName.Text = Configuration.Main.AssemblyNameLong;
            labelDescription.Text = Settings.ProgramDescription + " v" + Settings.GetVersion();
		}

		public delegate void UpdateProgressDelegate(string message, Color color, bool canLogin);

		private void UpdateProgress(string message, Color color, bool canLogin)
		{
			richTextBoxProgress.AppendText(message);
			richTextBoxProgress.SelectionStart = richTextBoxProgress.Text.Length - message.Length;
			richTextBoxProgress.SelectionLength = message.Length;
			richTextBoxProgress.SelectionColor = color;
			richTextBoxProgress.Select(richTextBoxProgress.Text.Length, 0);
			//textBoxUsername.Enabled = canLogin;
			//textBoxPassword.Enabled = canLogin;
			//buttonAuthenticate.Enabled = canLogin;

			textBoxUsername.Focus();
			AcceptButton = buttonAuthenticate;
		}

		private bool ProgressStep1_CheckIfExistsConfigFile()
		{
			bool success = false;
			Invoke(new UpdateProgressDelegate(UpdateProgress), "Existenta fisier configurare? .... ", Color.Black, false);
			Thread.Sleep(100);
			if (Configuration.Main.CheckIfConfigFileExists())
			{
				success = true;
				Invoke(new UpdateProgressDelegate(UpdateProgress), "OK\n", Color.Green, false);
			}
			else
			{
				Invoke(new UpdateProgressDelegate(UpdateProgress), "EROARE\n", Color.Red, false);
			}
			return success;
		}

		private bool ProgressStep2_ReadConfigFile()
		{
			bool success = false;
			Invoke(new UpdateProgressDelegate(UpdateProgress), "Citire configuratie .......... ", Color.Black, false);
			Thread.Sleep(100);
			if (Configuration.Main.ReadConfigFromFile())
			{
				success = true;
				Invoke(new UpdateProgressDelegate(UpdateProgress), "OK\n", Color.Green, false);
			}
			else
			{
				Invoke(new UpdateProgressDelegate(UpdateProgress), "EROARE\n", Color.Red, false);
			}
			return success;
		}

		private bool ProgressStep3_CheckSQLConnection()
		{
			bool success = false;
			Invoke(new UpdateProgressDelegate(UpdateProgress), "Conectare la Baza de Date ........... ", Color.Black, false);
			Thread.Sleep(100);
			if (Configuration.Main.CheckIfSQLConnectionOK())
			{
				success = true;
				Invoke(new UpdateProgressDelegate(UpdateProgress), "OK\n", Color.Green, false);
			}
			else
			{
				Invoke(new UpdateProgressDelegate(UpdateProgress), "EROARE\n", Color.Red, false);
			}
			return success;
		}

        private bool ProgressStep4_CheckDatabaseVersion()
        {
            bool success = false;
            Invoke(new UpdateProgressDelegate(UpdateProgress), "Verificare versiune Baze de date ........... ", Color.Black, false);
            Thread.Sleep(100);
            string message = string.Empty;
            try
            {
                message = EntityModels.ConfigurationVersions.ConfigurationVersionCollection.CheckIfSameAsProgram();
            }
            catch (Exception ex)
            {
                message = ex.ToString();
            }
            if (message == string.Empty)
            {
                success = true;
                Invoke(new UpdateProgressDelegate(UpdateProgress), "OK\n", Color.Green, false);
            }
            else
            {
                Invoke(new UpdateProgressDelegate(UpdateProgress), "EROARE\n", Color.Red, false);
            }
            return success;
        }

		private void InitializeAll()
		{	
			bool success = true;

            success &= ProgressStep1_CheckIfExistsConfigFile();
            success &= ProgressStep2_ReadConfigFile();
            success &= ProgressStep3_CheckSQLConnection();
            success &= ProgressStep4_CheckDatabaseVersion();

			if (success)
			{
				Invoke(new UpdateProgressDelegate(UpdateProgress), "\nInitializare incheiata cu succes!", Color.Green, true);
			}
			else
			{
				Invoke(new UpdateProgressDelegate(UpdateProgress), "\nEroare la initializare!", Color.Red, false);
			}
		}

		private void FormLogin_Shown(object sender, EventArgs e)
		{
			threadInitialize.IsBackground = true;
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
		}

		private void buttonAuthenticate_Click(object sender, EventArgs e)
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

            if ((textBoxUsername.Text == "admin") && (textBoxPassword.Text == "admin"))
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Nume utilizator sau parola eronata!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		}
	}
}