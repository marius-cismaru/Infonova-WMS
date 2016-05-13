using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sirius.EntityModels.Receptions
{
    public class ReceptionCollection
    {
        public static string EntityNameSingular = "Receptie";
        public static string EntityNamePlural = "Receptii";

        public static CustomControls.GridViewColumn[] GridViewColumnsNormal = 
		{
			new CustomControls.GridViewColumn("Client", 100, "L"),
			new CustomControls.GridViewColumn("Depozit", 80, "L"),
			new CustomControls.GridViewColumn("Numar", 60, "C"),
			new CustomControls.GridViewColumn("Data creare", 80, "C"),
			new CustomControls.GridViewColumn("Nr. pachete", 60, "C"),
            new CustomControls.GridViewColumn("Lot-uri client", 120, "L"),
            new CustomControls.GridViewColumn("Observatii", 120, "L", true)
		};

        public static IOrderedQueryable<Reception> GetCollection(EntityModelSirius model, ReceptionFilterCriteria criteria)
        {
            var o = from p in model.Receptions
                    select p;
            if (criteria != null)
            {
                if (criteria.CompanyId > 0)
                {
                    o = o.Where(p => p.Client.Company.Id == criteria.CompanyId);
                }
                if (criteria.ClientId > 0)
                {
                    o = o.Where(p => p.Client.Id == criteria.ClientId);
                }
                if (criteria.WarehouseId > 0)
                {
                    o = o.Where(p => p.Warehouse.Id == criteria.WarehouseId);
                }
                if (criteria.Number > 0)
                {
                    o = o.Where(p => p.Number == criteria.Number);
                }
                if (criteria.DateCreationBegin != null)
                {
                    o = o.Where(p => p.DateCreation >= criteria.DateCreationBegin);
                }
                if (criteria.DateCreationEnd != null)
                {
                    o = o.Where(p => p.DateCreation <= criteria.DateCreationEnd);
                }
            }
            var collection = from p in o
                orderby p.Client.NameShort, p.Number descending
                select p;
            return collection;
        }

        public static void PopulateGridViewNormal(ReceptionFilterCriteria criteria, CustomControls.EntityGridView gridView)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                List<string[]> items = new List<string[]>();
                foreach (var obj in GetCollection(model, criteria))
                {
                    items.Add(new string[] { obj.Id.ToString(), obj.Client.ToString(), obj.Warehouse.ToString(), obj.Number.ToString(), obj.DateCreation.ToString("yyyy-MM-dd"), obj.Packages.Count.ToString(), string.Join(", ", obj.ReceptionProducts.Select(o => o.Batch)), obj.Comment });
                }
                gridView.SetItems(items);   
            }
        }

        public static void PopulateSelectBox(ReceptionFilterCriteria criteria, CustomControls.EntitySelectBox selectBox, int selectedId, bool showOptionAll)
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

        public static void PopulateListBox(ReceptionFilterCriteria criteria, CustomControls.EntityListBox listBox, List<int> selectedIds)
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
            using (ReceptionFormBrowse form = new ReceptionFormBrowse())
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Add()
        {
            bool result = false;
            using (ReceptionFormAddVirtual form = new ReceptionFormAddVirtual())
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Edit(int selectedId)
        {
            bool result = false;
            using (ReceptionFormEdit form = new ReceptionFormEdit { EntityId = selectedId })
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static Reception GetById(EntityModelSirius model, int id, bool createNewIfNotExists)
        {
            Reception result;
            result = model.Receptions.FirstOrDefault(o => o.Id == id);
            if ((result == null) && (createNewIfNotExists))
            {
                result = new Reception();
            }
            return result;
        }

        public static bool CheckIfExistsByNumber(int companyId, int clientId, int number)
        {
            bool result = false;
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                result = (model.Receptions.FirstOrDefault(o => ((o.Client.Company.Id == companyId) && (o.Client.Id == clientId) && (o.Number == number))) != null);
            }
            return result;
        }

        public static bool CheckIfExistsByNumberExceptSelf(int companyId, int clientId, int number, int idSelf)
        {
            bool result = false;
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                result = (model.Receptions.FirstOrDefault(o => ((o.Client.Company.Id == companyId) && (o.Client.Id == clientId) && (o.Number == number) && (o.Id != idSelf))) != null);
            }
            return result;
        }

        public static int GetMaxNumber(int companyId, int clientId)
        {
            int result = 0;
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                if (model.Receptions.Count() > 0)
                {
                    var receptionList = model.Receptions.Where(o => ((o.Client.Company.Id == companyId) && (o.Client.Id == clientId)));
                    if (receptionList.Count() > 0)
                    {
                        result = receptionList.Max(o => o.Number);
                    }
                }
            }
            return result;
        }
    }
}
