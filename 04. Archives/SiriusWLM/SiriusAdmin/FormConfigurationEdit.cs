using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Sirius.SiriusAdmin
{
    public partial class FormConfigurationEdit: CustomControls.EntityFormEdit
    {
        public FormConfigurationEdit()
            : base()
        {
            InitializeComponent();
        }

        public override void FormEdit_Shown(object sender, EventArgs e)
        {
            SetFormName("Configurare");
            base.FormEdit_Shown(sender, e);
        }

        public override void LoadFieldsFromEntity()
        {
            textBoxSQLServer.Text = Configuration.ConfigFile.SQLServer;
            textBoxSQLUsername.Text = Configuration.ConfigFile.SQLUsername;
            textBoxSQLPassword.Text = Configuration.ConfigFile.SQLPassword;
            textBoxSQLDatabase.Text = Configuration.ConfigFile.SQLDatabase;
        }

        public override bool SaveFieldsToEntity()
        {
            bool result = false;

            string server = textBoxSQLServer.Text.Trim();
            string username = textBoxSQLUsername.Text.Trim();
            string password = textBoxSQLPassword.Text;
            string database = textBoxSQLDatabase.Text.Trim();

            if ((Configuration.Main.CheckIfSQLConnectionOK(Configuration.Main.CreateSQLConnectionString(server, username, password, database))) || (MessageBox.Show("Conexiune SQL nereusita. Se continua asa?", "ATENTIE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes))
            {
                Configuration.ConfigFile.SQLServer = server;
                Configuration.ConfigFile.SQLUsername = username;
                Configuration.ConfigFile.SQLPassword = password;
                Configuration.ConfigFile.SQLDatabase = database;

                result = Configuration.Main.WriteConfigToFile();
            }

            return result;
        }

        private void buttonSQLTest_Click(object sender, EventArgs e)
        {
            string server = textBoxSQLServer.Text.Trim();
            string username = textBoxSQLUsername.Text.Trim();
            string password = textBoxSQLPassword.Text;
            string database = textBoxSQLDatabase.Text.Trim();

            if (!Configuration.Main.CheckIfSQLConnectionOK(Configuration.Main.CreateSQLConnectionString(server, username, password, database)))
            {
                MessageBox.Show("Conexiune SQL nereusita.", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Conexiune SQL reusita.", "SUCCES", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
