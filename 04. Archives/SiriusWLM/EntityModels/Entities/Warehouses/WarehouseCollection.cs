using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sirius.EntityModels.Warehouses
{
    public class WarehouseCollection
    {
        public static string EntityNameSingular = "Depozit";
        public static string EntityNamePlural = "Depozite";

        public static CustomControls.GridViewColumn[] GridViewColumnsNormal = 
		{
			new CustomControls.GridViewColumn("Nume", 150, "L", true),
			new CustomControls.GridViewColumn("Descriere", 150, "L"),
			new CustomControls.GridViewColumn("Tara", 100, "L"),
			new CustomControls.GridViewColumn("Adresa", 200, "L"),
		};

        public static IOrderedQueryable<Warehouse> GetCollection(EntityModelSirius model, WarehouseFilterCriteria criteria)
        {
            var o = from p in model.Warehouses
                    select p;
            if (criteria != null)
            {
                if (criteria.CompanyId > 0)
                {
                    o = o.Where(p => p.Company.Id == criteria.CompanyId);
                }
            }
            var collection = from p in o
                orderby p.Name
                select p;
            return collection;
        }

        public static void PopulateGridViewNormal(WarehouseFilterCriteria criteria, CustomControls.EntityGridView gridView)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                List<string[]> items = new List<string[]>();
                foreach (var obj in GetCollection(model, criteria))
                {
                    items.Add(new string[] { obj.Id.ToString(), obj.Name, obj.Description, obj.Country.Name, obj.Address });
                }
                gridView.SetItems(items);   
            }
        }

        public static void PopulateSelectBox(WarehouseFilterCriteria criteria, CustomControls.EntitySelectBox selectBox, int selectedId, bool showOptionAll)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                List<CustomControls.EntityItem> items = new List<CustomControls.EntityItem>();
                foreach (var obj in GetCollection(model, criteria))
                {
                    items.Add(new CustomControls.EntityItem(obj.Id, obj.ToString()));
                }
                selectBox.SetItems(items, selectedId, showOptionAll);
            }
        }

        public static void PopulateListBox(WarehouseFilterCriteria criteria, CustomControls.EntityListBox listBox, List<int> selectedIds)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                List<CustomControls.EntityItem> items = new List<CustomControls.EntityItem>();
                foreach (var obj in GetCollection(model, criteria))
                {
                    items.Add(new CustomControls.EntityItem(obj.Id, obj.ToString()));
                }
                listBox.SetItems(items, selectedIds);
            }
        }

        public static bool Browse()
        {
            bool result = false;
            using (WarehouseFormBrowse form = new WarehouseFormBrowse())
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Add()
        {
            bool result = false;
            using (WarehouseFormEdit form = new WarehouseFormEdit { EntityId = 0 })
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Edit(int selectedId)
        {
            bool result = false;
            using (WarehouseFormEdit form = new WarehouseFormEdit { EntityId = selectedId })
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static Warehouse GetById(EntityModelSirius model, int id, bool createNewIfNotExists)
        {
            Warehouse result;
            result = model.Warehouses.FirstOrDefault(o => o.Id == id);
            if ((result == null) && (createNewIfNotExists))
            {
                result = new Warehouse();
                /*
                result.Company = model.Companies.FirstOrDefault(o => o.Id == Configuration.Main.LoggedCompanyId);
                result.Country = model.Countries.FirstOrDefault();
                if (result.Country == null)
                {
                    Countries.CountryCollection.Add();
                }
                */ 
            }
            return result;
        }
    }
}
