using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Sirius.EntityModels.Transfers
{
    public class TransferCollection
    {
        public static string EntityNameSingular = "Transfer";
        public static string EntityNamePlural = "Transfer-uri";

        public static CustomControls.GridViewColumn[] GridViewColumnsNormal = 
		{
			new CustomControls.GridViewColumn("Data creare", 80, "C"),
			new CustomControls.GridViewColumn("Client", 100, "L"),
			new CustomControls.GridViewColumn("Depozit", 80, "L"),
			new CustomControls.GridViewColumn("Produs", 120, "L", true),
			new CustomControls.GridViewColumn("Cantitate", 60, "R"),
			new CustomControls.GridViewColumn("Pachet", 60, "C"),
			new CustomControls.GridViewColumn("Container sursa", 80, "C"),
            new CustomControls.GridViewColumn("Container destinatie", 80, "C")
		};

        public static IOrderedQueryable<Transfer> GetCollection(EntityModelSirius model, TransferFilterCriteria criteria)
        {
            var o = from p in model.Transfers
                    select p;
            if (criteria != null)
            {
                if (criteria.CompanyId > 0)
                {
                    o = o.Where(p => p.Package.Reception.Client.Company.Id == criteria.CompanyId);
                }
                if (criteria.ClientId > 0)
                {
                    o = o.Where(p => p.Package.Reception.Client.Id == criteria.ClientId);
                }
                if (criteria.WarehouseId > 0)
                {
                    o = o.Where(p => p.Package.Reception.Warehouse.Id == criteria.WarehouseId);
                }
                if (criteria.ProductId > 0)
                {
                    o = o.Where(p => p.Package.Product.Id == criteria.ProductId);
                }
                if (criteria.PackageCode != string.Empty)
                {
                    o = o.Where(p => p.Package.Code.Contains(criteria.PackageCode));
                }
                if (criteria.WarehouseContainerNameSource != string.Empty)
                {
                    o = o.Where(p => p.WarehouseContainerSource.Name.Contains(criteria.WarehouseContainerNameSource));
                }
                if (criteria.WarehouseContainerNameDestination != string.Empty)
                {
                    o = o.Where(p => p.WarehouseContainerDestination.Name.Contains(criteria.WarehouseContainerNameDestination));
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
                orderby p.Package.Reception.Client.NameShort, p.Package.Reception.Warehouse.Name, p.Package.Product.Code, p.Package.Code, p.DateCreation 
                select p;
            return collection;
        }

        public static void PopulateGridViewNormal(TransferFilterCriteria criteria, CustomControls.EntityGridView gridView)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                List<string[]> items = new List<string[]>();
                foreach (var obj in GetCollection(model, criteria))
                {
                    items.Add(new string[] { obj.Id.ToString(), obj.DateCreation.ToString("yyyy-MM-dd"), obj.Package.Reception.Client.ToString(), obj.Package.Reception.Warehouse.ToString(), obj.Package.Product.ToString(), obj.Package.Quantity.ToString("0.00", CultureInfo.InvariantCulture), obj.Package.ToString(), obj.WarehouseContainerSource.Name, obj.WarehouseContainerDestination.Name });
                }
                gridView.SetItems(items);
            }
        }

        public static void PopulateGridViewNormal(List<Transfer> transferList, CustomControls.EntityGridView gridView)
        {
            List<string[]> items = new List<string[]>();
            foreach (var obj in transferList)
            {
                items.Add(new string[] { obj.Id.ToString(), obj.DateCreation.ToString("yyyy-MM-dd"), obj.Package.Reception.Client.ToString(), obj.Package.Reception.Warehouse.ToString(), obj.Package.Product.ToString(), obj.Package.Quantity.ToString("0.00", CultureInfo.InvariantCulture), obj.Package.ToString(), obj.WarehouseContainerSource.Name, obj.WarehouseContainerDestination.Name });
            }
            gridView.SetItems(items);
        }

        public static void PopulateSelectBox(TransferFilterCriteria criteria, CustomControls.EntitySelectBox selectBox, int selectedId, bool showOptionAll)
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

        public static void PopulateListBox(TransferFilterCriteria criteria, CustomControls.EntityListBox listBox, List<int> selectedIds)
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
            using (TransferFormBrowse form = new TransferFormBrowse())
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Add()
        {
            bool result = false;
            using (TransferFormAdd form = new TransferFormAdd())
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static Transfer GetById(EntityModelSirius model, int id, bool createNewIfNotExists)
        {
            Transfer result;
            result = model.Transfers.FirstOrDefault(o => o.Id == id);
            if ((result == null) && (createNewIfNotExists))
            {
                result = new Transfer();
            }
            return result;
        }
    }
}
