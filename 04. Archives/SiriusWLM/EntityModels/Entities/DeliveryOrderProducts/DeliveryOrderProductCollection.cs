using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Sirius.EntityModels.DeliveryOrderProducts
{
    public class DeliveryOrderProductCollection
    {
        public static string EntityNameSingular = "Articol Comanda Livrare";
        public static string EntityNamePlural = "Articole Comanda Livrare";

        public static CustomControls.GridViewColumn[] GridViewColumnsNormal = 
		{
			new CustomControls.GridViewColumn("Articol", 220, "L", true),
			new CustomControls.GridViewColumn("UM", 50, "C"),
			new CustomControls.GridViewColumn("Cantitate", 80, "R"),
			new CustomControls.GridViewColumn("Greutate neta [Kg]", 80, "R")
		};

        public static IOrderedQueryable<DeliveryOrderProduct> GetCollection(EntityModelSirius model, DeliveryOrderProductFilterCriteria criteria)
        {
            var o = from p in model.DeliveryOrderProducts
                    select p;
            if (criteria != null)
            {
                if (criteria.DeliveryId > 0)
                {
                    o = o.Where(p => p.Delivery.Id == criteria.DeliveryId);
                }
            }
            var collection = from p in o
                orderby p.Id
                select p;
            return collection;
        }

        public static void PopulateGridViewNormal(DeliveryOrderProductFilterCriteria criteria, CustomControls.EntityGridView gridView)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                List<string[]> items = new List<string[]>();
                foreach (var obj in GetCollection(model, criteria))
                {
                    items.Add(new string[] { obj.Id.ToString(), obj.Product.ToString(), obj.Product.MeasuringUnit.ToString(), obj.Quantity.ToString("0.00", CultureInfo.InvariantCulture), obj.WeightNet.ToString("0.00", CultureInfo.InvariantCulture) });
                }
                gridView.SetItems(items);  
            }
        }

        public static void PopulateGridViewNormal(List<DeliveryOrderProduct> deliveryOrderProductList, CustomControls.EntityGridView gridView)
        {
            List<string[]> items = new List<string[]>();
            foreach (var obj in deliveryOrderProductList)
            {
                items.Add(new string[] { obj.Id.ToString(), obj.Product.ToString(), obj.Product.MeasuringUnit.ToString(), obj.Quantity.ToString("0.00", CultureInfo.InvariantCulture), obj.WeightNet.ToString("0.00", CultureInfo.InvariantCulture) });
            }
            gridView.SetItems(items);
        }

        public static void PopulateSelectBox(DeliveryOrderProductFilterCriteria criteria, CustomControls.EntitySelectBox selectBox, int selectedId, bool showOptionAll)
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

        public static void PopulateSelectBox(List<DeliveryOrderProduct> deliveryOrderProductList, CustomControls.EntitySelectBox selectBox, Product productSelected)
        {
            List<CustomControls.EntityItem> items = new List<CustomControls.EntityItem>();
            foreach (var obj in deliveryOrderProductList)
            {
                items.Add(new CustomControls.EntityItem(obj.Product.Id, obj.Product.ToString()));
            }
            selectBox.SetItems(items, (productSelected != null ? productSelected.Id : 0), false);
        }

        public static void PopulateListBox(DeliveryOrderProductFilterCriteria criteria, CustomControls.EntityListBox listBox, List<int> selectedIds)
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

        public static bool Add(EntityModelSirius model, DeliveryOrderProduct productNew)
        {
            bool result = false;
            using (DeliveryOrderProductFormEdit form = new DeliveryOrderProductFormEdit())
            {
                form.Model = model;
                form.Entity = productNew;
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static DeliveryOrderProduct GetById(EntityModelSirius model, int id, bool createNewIfNotExists)
        {
            DeliveryOrderProduct result;
            result = model.DeliveryOrderProducts.FirstOrDefault(o => o.Id == id);
            if ((result == null) && (createNewIfNotExists))
            {
                result = new DeliveryOrderProduct();
            }
            return result;
        }
    }
}
