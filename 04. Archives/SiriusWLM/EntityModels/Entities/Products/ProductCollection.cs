using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Sirius.EntityModels.Products
{
    public class ProductCollection
    {
        public static string EntityNameSingular = "Articol";
        public static string EntityNamePlural = "Articole";

        public static CustomControls.GridViewColumn[] GridViewColumnsNormal = 
		{
			new CustomControls.GridViewColumn("Client", 150, "L"),
			new CustomControls.GridViewColumn("Cod", 100, "L"),
			new CustomControls.GridViewColumn("Denumire", 150, "L", true),
			new CustomControls.GridViewColumn("Cod intern", 100, "L"),
			new CustomControls.GridViewColumn("UM", 70, "C"),
			new CustomControls.GridViewColumn("Factor conversie Kg", 100, "R")
		};

        public static IOrderedQueryable<Product> GetCollection(EntityModelSirius model, ProductFilterCriteria criteria)
        {
            var o = from p in model.Products
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
                if (criteria.Code != string.Empty)
                {
                    o = o.Where(p => p.Code.Contains(criteria.Code));
                }
                if (criteria.Name != string.Empty)
                {
                    o = o.Where(p => p.Name.Contains(criteria.Name));
                }
            }
            var collection = from p in o
                orderby p.Client.NameShort, p.Name, p.Code
                select p;
            return collection;
        }

        public static void PopulateGridViewNormal(ProductFilterCriteria criteria, CustomControls.EntityGridView gridView)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                List<string[]> items = new List<string[]>();
                foreach (var obj in GetCollection(model, criteria))
                {
                    items.Add(new string[] { obj.Id.ToString(), obj.Client.NameShort, obj.Code, obj.Name, obj.IdToString, obj.MeasuringUnit.ToString(), obj.ConversionFactorKg.ToString("0.00", CultureInfo.InvariantCulture) });
                }
                gridView.SetItems(items);   
            }
        }

        public static void PopulateSelectBox(ProductFilterCriteria criteria, CustomControls.EntitySelectBox selectBox, int selectedId, bool showOptionAll)
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

        public static void PopulateSelectBox(int clientId, List<int> productIdsList, CustomControls.EntitySelectBox selectBox, int selectedId, bool showOptionAll)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                List<CustomControls.EntityItem> items = new List<CustomControls.EntityItem>();
                var collection = from p in model.Products
                                 where ((clientId == 0) || ((p.Client.Id == clientId) && (productIdsList.Contains(p.Id))))
                           orderby p.Client.NameShort, p.Code
                           select p;
                foreach (var obj in collection)
                {
                    items.Add(new CustomControls.EntityItem(obj.Id, obj.ToString()));
                }
                selectBox.SetItems(items, selectedId, showOptionAll);
            }
        }

        public static void PopulateSelectBoxWithExisting(int clientId, CustomControls.EntitySelectBox selectBox, int selectedId)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                List<CustomControls.EntityItem> items = new List<CustomControls.EntityItem>();
                var collection = from o in model.Products
                                 where o.Client.Id == clientId && o.Packages.Any(p => p.Delivery == null)
                                 orderby o.Name
                                 select o;
                foreach (var obj in collection)
                {
                    items.Add(new CustomControls.EntityItem(obj.Id, obj.ToString()));
                }
                selectBox.SetItems(items, selectedId, false);
            }
        }

        public static void PopulateListBox(ProductFilterCriteria criteria, CustomControls.EntityListBox listBox, List<int> selectedIds)
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
            using (ProductFormBrowse form = new ProductFormBrowse())
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Add()
        {
            bool result = false;
            using (ProductFormEdit form = new ProductFormEdit { EntityId = 0 })
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Edit(int selectedId)
        {
            bool result = false;
            using (ProductFormEdit form = new ProductFormEdit { EntityId = selectedId })
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool CheckIfAllowDelete(int selectedId)
        {
            bool result = true;

            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                //Check if at least one package exists with the product
                var package = model.Packages.FirstOrDefault(o => o.Product.Id == selectedId);
                result = package == null;
            }

            return result;
        }

        public static bool Delete(int selectedId)
        {
            bool result = false;
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                var product = GetById(model, selectedId, false);
                if (product != null)
                {
                    model.Products.DeleteObject(product);
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

        public static Product GetById(EntityModelSirius model, int id, bool createNewIfNotExists)
        {
            Product result;
            result = model.Products.FirstOrDefault(o => o.Id == id);
            if ((result == null) && (createNewIfNotExists))
            {
                result = new Product();
                /*
                result.MeasuringUnit = model.MeasuringUnits.FirstOrDefault();
                if (result.MeasuringUnit == null)
                {
                    MeasuringUnits.MeasuringUnitCollection.Add();
                }
                result.Client = null;
                */
            }
            return result;
        }

        public static bool CheckIfExistsByClientAndCode(int clientId, string code)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                code = code.Trim();
                return (model.Products.FirstOrDefault(o => (o.Client.Id == clientId) && (o.Code == code)) != null);
            }
        }

        public static bool CheckIfExistsByClientAndCodeExceptSelf(int clientId, string code, int selfId)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                code = code.Trim();
                return (model.Products.FirstOrDefault(o => (o.Client.Id == clientId) && (o.Code == code) && (o.Id != selfId)) != null);
            }
        }
    }
}
