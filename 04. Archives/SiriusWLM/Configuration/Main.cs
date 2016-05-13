using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
using Sirius.CommonLibs;

namespace Sirius.Configuration
{
    public static class Main
    {
        //Predefined values
        public static string AssemblyNameLong = "Sirius";
        public static string AssemblyNameShort = "Sirius";
        public static string AssemblyDescription = "Sirius Management";
        public static string AssemblyAuthor = "Marius Cismaru";

        public static int DatabaseVersionMajor = 1;
        public static int DatabaseVersionMinor = 0;

        public static string ConfigFileName = AssemblyNameShort + ".config";

        //From config file
        public static string SQLConnectionString
        {
            get { return CreateSQLConnectionString(); }
        }

        //Logged values
        public static int LoggedUserId = 0;
        public static string LoggedUserUsername;
        public static string LoggedUserName;
        public static int LoggedCompanyId = 0;
        public static string LoggedCompanyNameLong;
        public static string LoggedCompanyNameShort;

        //Functions
        public static string GetDatabaseVersion()
        {
            return (DatabaseVersionMajor.ToString() + "." + DatabaseVersionMinor.ToString());
        }

        public static bool CheckIfConfigFileExists()
        {
            return System.IO.File.Exists(ConfigFileName);
        }

        public static bool WriteConfigToFile()
        {
            bool result = false;

            Type ConfigType = typeof(Configuration.ConfigFile);
            try
            {
                FieldInfo[] fields = ConfigType.GetFields(BindingFlags.Static | BindingFlags.Public);
                string str = "";

                foreach (FieldInfo field in fields)
                {
                    str += (field.Name + "=" + field.GetValue(null).ToString() + "###");
                }
                string password = CommonLibs.StringsLib.GetRandomString(8);
                str = CommonLibs.EncryptionLib.Encrypt(str, password);
                str = password + str;
                File.WriteAllText(ConfigFileName, str);

                result = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString(), "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public static bool ReadConfigFromFile()
        {
            bool result = false;

            Type ConfigType = typeof(Configuration.ConfigFile);
            try
            {
                FieldInfo[] fields = ConfigType.GetFields(BindingFlags.Static | BindingFlags.Public);
                string str = File.ReadAllText(ConfigFileName);
                string password = str.Left(8);
                str = str.Right(str.Length - 8);
                str = EncryptionLib.Decrypt(str, password);
                string[] list = str.Split(new string[] { "###" }, StringSplitOptions.None);

                foreach (FieldInfo field in fields)
                {
                    foreach (string strField in list)
                    {
                        string[] strListTemp = strField.Split('=');
                        if (field.Name == strListTemp[0])
                        {
                            field.SetValue(null, strListTemp[1]);
                        }
                    }
                };
                result = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString(), "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }

        public static string CreateSQLConnectionString(string server, string username, string password, string database)
        {
            return ("metadata=res://*/EntityModelSirius.csdl|res://*/EntityModelSirius.ssdl|res://*/EntityModelSirius.msl;provider=System.Data.SqlClient;provider connection string=\"Data Source=" + server + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password + ";MultipleActiveResultSets=True\"");
        }

        public static string CreateSQLConnectionString()
        {
            return CreateSQLConnectionString(ConfigFile.SQLServer, ConfigFile.SQLUsername, ConfigFile.SQLPassword, ConfigFile.SQLDatabase);
        }

        public static bool CheckIfSQLConnectionOK(string connectionString)
        {
            bool result = false;

            System.Data.EntityClient.EntityConnectionStringBuilder connEntity = new System.Data.EntityClient.EntityConnectionStringBuilder();
            connEntity.ConnectionString = connectionString;
            string providerConnectionString = connEntity.ProviderConnectionString;

            System.Data.SqlClient.SqlConnectionStringBuilder connStringBuilder = new System.Data.SqlClient.SqlConnectionStringBuilder();
            connStringBuilder.ConnectionString = providerConnectionString;
            connStringBuilder.ConnectTimeout = 15;
            string connStr = connStringBuilder.ConnectionString;

            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    result = true;
                }
                catch
                {
                    result = false;
                }
            }

            return result;
        }

        public static bool CheckIfSQLConnectionOK()
        {
            return CheckIfSQLConnectionOK(SQLConnectionString);
        }
    }
}
