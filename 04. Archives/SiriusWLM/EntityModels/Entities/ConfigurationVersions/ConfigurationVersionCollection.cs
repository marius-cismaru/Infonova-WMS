using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Sirius.EntityModels.ConfigurationVersions
{
    public class ConfigurationVersionCollection
    {
        public static string EntityNameSingular = "Configuratie versiune SQL";
        public static string EntityNamePlural = "Configuratie versiune SQL";

        public static CustomControls.GridViewColumn[] GridViewColumnsNormal = 
		{
			new CustomControls.GridViewColumn("Versiune interfata SQL program", 140, "C"),
			new CustomControls.GridViewColumn("Versiune server SQL", 140, "C"),
			new CustomControls.GridViewColumn("Observatii", 80, "L", true)
		};

        public static IOrderedQueryable<ConfigurationVersion> GetCollection(EntityModelSirius model)
        {
            var o = from p in model.ConfigurationVersions
                    select p;
            var collection = from p in o
                orderby p.Id descending
                select p;
            return collection;
        }

        public static void PopulateGridViewNormal(CustomControls.EntityGridView gridView)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                List<string[]> items = new List<string[]>();
                var collection = GetCollection(model);
                if (collection.Count() > 0)
                {
                    var obj = collection.First();
                    items.Add(new string[] { obj.Id.ToString(), Configuration.Main.GetDatabaseVersion(), obj.ToString(), string.Empty });
                }
                gridView.SetItems(items);  
            }
        }

        public static bool Browse()
        {
            bool result = false;
            using (ConfigurationVersionFormBrowse form = new ConfigurationVersionFormBrowse())
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static ConfigurationVersion GetById(EntityModelSirius model, int id, bool createNewIfNotExists)
        {
            ConfigurationVersion result;
            result = model.ConfigurationVersions.FirstOrDefault(o => o.Id == id);
            if ((result == null) && (createNewIfNotExists))
            {
                result = new ConfigurationVersion();
            }
            return result;
        }

        public static string CheckIfSameAsProgram()
        {
            string result = string.Empty;

            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                var databaseVersionList = GetCollection(model);
                if (databaseVersionList.Count() > 0)
                {
                    var databaseVersion = databaseVersionList.FirstOrDefault();
                    if (databaseVersion != null)
                    {
                        if ((databaseVersion.Major != Configuration.Main.DatabaseVersionMajor) || (databaseVersion.Minor != Configuration.Main.DatabaseVersionMinor))
                        {
                            result = "Versiunea interfetei bazei de date din program (" + Configuration.Main.GetDatabaseVersion() + ") este diferita fata de versiunea server-ului de baze de date (" + databaseVersion.ToString() + ")." + Environment.NewLine + "Trebuie sa faci un update al programului prin iesire si apoi intrare in cont (Logoff si apoi Logon) sau restartarea calculatorului.";
                        }
                    }
                }
            }

            return result;
        }
    }
}
