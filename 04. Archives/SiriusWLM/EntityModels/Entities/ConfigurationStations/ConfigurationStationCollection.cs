using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Sirius.EntityModels.ConfigurationStations
{
    public class ConfigurationStationCollection
    {
        public static string EntityNameSingular = "Configuratie statie de lucru";
        public static string EntityNamePlural = "Configuratii statii de lucru";

        public static CustomControls.GridViewColumn[] GridViewColumnsNormal = 
		{
			new CustomControls.GridViewColumn("Statie", 100, "C"),
			new CustomControls.GridViewColumn("Descriere", 200, "L", true)
		};

        public static IOrderedQueryable<ConfigurationStation> GetCollection(EntityModelSirius model)
        {
            var o = from p in model.ConfigurationStations
                    select p;
            var collection = from p in o
                orderby p.StationName
                select p;
            return collection;
        }

        public static void PopulateGridViewNormal(CustomControls.EntityGridView gridView)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                List<string[]> items = new List<string[]>();
                foreach (var obj in GetCollection(model))
                {
                    items.Add(new string[] { obj.Id.ToString(), obj.StationName, obj.ToString() });
                }
                gridView.SetItems(items);  
            }
        }

        public static bool Browse()
        {
            bool result = false;
            using (ConfigurationStationFormBrowse form = new ConfigurationStationFormBrowse())
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Add()
        {
            bool result = false;
            using (ConfigurationStationFormEdit form = new ConfigurationStationFormEdit())
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Edit(int selectedId)
        {
            bool result = false;
            using (ConfigurationStationFormEdit form = new ConfigurationStationFormEdit { EntityId = selectedId })
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Delete(int selectedId)
        {
            bool result = false;
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                var obj = GetById(model, selectedId, false);
                if (obj != null)
                {
                    model.ConfigurationStations.DeleteObject(obj);
                    model.SaveChanges();
                    result = true;
                }
            }
            return result;
        }

        public static ConfigurationStation GetById(EntityModelSirius model, int id, bool createNewIfNotExists)
        {
            ConfigurationStation result;
            result = model.ConfigurationStations.FirstOrDefault(o => o.Id == id);
            if ((result == null) && (createNewIfNotExists))
            {
                result = new ConfigurationStation();
            }
            return result;
        }

        public static ConfigurationStation GetByStationName(EntityModelSirius model, string stationName, bool createNewIfNotExists)
        {
            ConfigurationStation result;
            result = model.ConfigurationStations.FirstOrDefault(o => o.StationName == stationName.ToUpper());
            if ((result == null) && (createNewIfNotExists))
            {
                result = new ConfigurationStation();
            }
            return result;
        }

        public static ConfigurationStation GetForThisStation(EntityModelSirius model)
        {
            string thisStationName = CommonLibs.ActiveDirectoryLib.GetWindowsStationName().ToUpper();
            return model.ConfigurationStations.FirstOrDefault(o => o.StationName == thisStationName);
        }

        public static bool CheckIfExistsById(int id)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                return (model.ConfigurationStations.FirstOrDefault(o => o.Id == id) != null);
            }
        }

        public static bool CheckIfExistsByStationName(string stationName)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                return (model.ConfigurationStations.FirstOrDefault(o => o.StationName == stationName.ToUpper()) != null);
            }
        }

        public static bool CheckIfExistsByStationNameExceptSelf(string stationName, int selfId)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                return (model.ConfigurationStations.FirstOrDefault(o => (o.Id != selfId) && (o.StationName == stationName.ToUpper())) != null);
            }
        }

    }
}
