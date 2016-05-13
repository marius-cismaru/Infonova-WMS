using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sirius.EntityModels.Deliveries
{
    public class DeliveryCollection
    {
        public static string EntityNameSingular = "Livrare";
        public static string EntityNamePlural = "Livrari";

        public static CustomControls.GridViewColumn[] GridViewColumnsNormal = 
		{
			new CustomControls.GridViewColumn("Client", 100, "L"),
			new CustomControls.GridViewColumn("Depozit", 80, "L"),
			new CustomControls.GridViewColumn("Numar", 60, "C"),
			new CustomControls.GridViewColumn("Data creare", 80, "C"),
			new CustomControls.GridViewColumn("Comanda client", 180, "L", true),
			new CustomControls.GridViewColumn("Nr. pachete", 60, "C")
		};

        public static CustomControls.GridViewColumn[] GridViewColumnsAddDedicated = 
		{
			new CustomControls.GridViewColumn("Produs", 160, "L", true),
			new CustomControls.GridViewColumn("Nr. pachete", 80, "C"),
			new CustomControls.GridViewColumn("Cantitate comandata", 80, "R"),
			new CustomControls.GridViewColumn("Cantitate livrata", 80, "R"),
			new CustomControls.GridViewColumn("Cantitate diferenta", 80, "R")
		};

        public static IOrderedQueryable<Delivery> GetCollection(EntityModelSirius model, DeliveryFilterCriteria criteria)
        {
            var o = from p in model.Deliveries
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
                if (criteria.OrderNumber != string.Empty)
                {
                    o = o.Where(p => p.OrderNumber.Contains(criteria.OrderNumber));
                }
            }
            var collection = from p in o
                orderby p.DateCreation descending, p.Number descending
                select p;
            return collection;
        }

        public static void PopulateGridViewNormal(DeliveryFilterCriteria criteria, CustomControls.EntityGridView gridView)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                List<string[]> items = new List<string[]>();
                foreach (var obj in GetCollection(model, criteria))
                {
                    items.Add(new string[] { obj.Id.ToString(), obj.Client.ToString(), obj.Warehouse.ToString(), obj.Number.ToString(), obj.DateCreation.ToString("yyyy-MM-dd"), obj.OrderToString, obj.Packages.Count.ToString() });
                }
                gridView.SetItems(items);   
            }
        }

        public static void PopulateSelectBox(DeliveryFilterCriteria criteria, CustomControls.EntitySelectBox selectBox, int selectedId, bool showOptionAll)
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

        public static void PopulateListBox(DeliveryFilterCriteria criteria, CustomControls.EntityListBox listBox, List<int> selectedIds)
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
            using (DeliveryFormBrowse form = new DeliveryFormBrowse())
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Add()
        {
            bool result = false;
            using (DeliveryFormAdd form = new DeliveryFormAdd())
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Edit(int selectedId)
        {
            bool result = false;
            using (DeliveryFormEdit form = new DeliveryFormEdit { EntityId = selectedId })
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
                var delivery = GetById(model, selectedId, false);
                if (delivery != null)
                {
                    var packages = (from o in model.Packages
                                    where ((o.Delivery != null) && (o.Delivery.Id == selectedId))
                                    select o).ToList();
                    foreach (var obj in packages)
                    {
                        if (obj.PackagesChildren.Count > 0)
                        {
                            var weightTare = obj.WeightGross - obj.WeightNet;
                            obj.Quantity += obj.PackagesChildren.Sum(o => o.Quantity);
                            obj.WeightNet = obj.Quantity * obj.Product.ConversionFactorKg;
                            obj.WeightGross = obj.WeightNet + weightTare;
                        }

                        foreach (var objPackageChild in obj.PackagesChildren.ToList())
                        {
                            foreach (var objPackageTransfer in objPackageChild.Transfers.ToList())
                            {
                                objPackageChild.Transfers.Remove(objPackageTransfer);
                            }

                            model.Packages.DeleteObject(objPackageChild);
                        }

                        obj.Delivery = null;
                    }

                    var orderProducts = (from o in model.DeliveryOrderProducts
                                         where o.Delivery.Id == selectedId
                                         select o).ToList();
                    foreach (var obj in orderProducts)
                    {
                        model.DeliveryOrderProducts.DeleteObject(obj);
                    }

                    model.Deliveries.DeleteObject(delivery);

                    try
                    {
                        model.SaveChanges();
                        result = true;
                    }
                    catch
                    {
                    }
                }
            }
            return result;
        }

        public static Delivery GetById(EntityModelSirius model, int id, bool createNewIfNotExists)
        {
            Delivery result;
            result = model.Deliveries.FirstOrDefault(o => o.Id == id);
            if ((result == null) && (createNewIfNotExists))
            {
                result = new Delivery();
            }
            return result;
        }

        public static bool CheckIfExistsByNumber(int companyId, int number)
        {
            bool result = false;
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                result = (model.Deliveries.FirstOrDefault(o => (o.Client.Company.Id == companyId) && (o.Number == number)) != null);
            }
            return result;
        }

        public static bool CheckIfExistsByNumberExceptSelf(int companyId, int number, int idSelf)
        {
            bool result = false;
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                result = (model.Deliveries.FirstOrDefault(o => (o.Client.Company.Id == companyId) && (o.Number == number) && (o.Id != idSelf)) != null);
            }
            return result;
        }
    }
}
