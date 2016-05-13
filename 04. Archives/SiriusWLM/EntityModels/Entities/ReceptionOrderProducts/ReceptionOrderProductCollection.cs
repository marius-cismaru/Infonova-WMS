using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Sirius.EntityModels.ReceptionOrderProducts
{
    public class ReceptionOrderProductCollection
    {
        public static string EntityNameSingular = "Articol Comanda Receptie";
        public static string EntityNamePlural = "Articole Comanda Receptie";

        public static CustomControls.GridViewColumn[] GridViewColumnsNormal = 
		{
			new CustomControls.GridViewColumn("Articol", 220, "L", true),
			new CustomControls.GridViewColumn("UM", 50, "C"),
			new CustomControls.GridViewColumn("Cantitate", 80, "R"),
			new CustomControls.GridViewColumn("Greutate neta [Kg]", 80, "R"),
			new CustomControls.GridViewColumn("Greutate bruta [Kg]", 80, "R")
		};

        public static IOrderedQueryable<ReceptionOrderProduct> GetCollection(EntityModelSirius model, ReceptionOrderProductFilterCriteria criteria)
        {
            var o = from p in model.ReceptionOrderProducts
                    select p;
            if (criteria != null)
            {
                if (criteria.ReceptionId > 0)
                {
                    o = o.Where(p => p.Reception.Id == criteria.ReceptionId);
                }
            }
            var collection = from p in o
                orderby p.Id
                select p;
            return collection;
        }

        public static void PopulateGridViewNormal(ReceptionOrderProductFilterCriteria criteria, CustomControls.EntityGridView gridView)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                List<string[]> items = new List<string[]>();
                foreach (var obj in GetCollection(model, criteria))
                {
                    items.Add(new string[] { obj.Id.ToString(), obj.Product.ToString(), obj.Product.MeasuringUnit.ToString(), obj.Quantity.ToString("0.00", CultureInfo.InvariantCulture), obj.WeightNet.ToString("0.00", CultureInfo.InvariantCulture), obj.WeightGross.ToString("0.00", CultureInfo.InvariantCulture) });
                }
                gridView.SetItems(items);  
            }
        }

        public static void PopulateGridViewNormal(List<ReceptionOrderProduct> receptionOrderProductList, CustomControls.EntityGridView gridView)
        {
            List<string[]> items = new List<string[]>();
            foreach (var obj in receptionOrderProductList)
            {
                items.Add(new string[] { obj.Id.ToString(), obj.Product.ToString(), obj.Product.MeasuringUnit.ToString(), obj.Quantity.ToString("0.00", CultureInfo.InvariantCulture), obj.WeightNet.ToString("0.00", CultureInfo.InvariantCulture), obj.WeightGross.ToString("0.00", CultureInfo.InvariantCulture) });
            }
            gridView.SetItems(items);
        }

        public static void PopulateSelectBox(ReceptionOrderProductFilterCriteria criteria, CustomControls.EntitySelectBox selectBox, int selectedId, bool showOptionAll)
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

        public static void PopulateSelectBox(List<ReceptionOrderProduct> receptionOrderProductList, CustomControls.EntitySelectBox selectBox, int productSelectedId)
        {
            List<CustomControls.EntityItem> items = new List<CustomControls.EntityItem>();
            foreach (var obj in receptionOrderProductList)
            {
                items.Add(new CustomControls.EntityItem(obj.Product.Id, obj.Product.ToString()));
            }
            selectBox.SetItems(items, productSelectedId, false);
        }

        public static void PopulateListBox(ReceptionOrderProductFilterCriteria criteria, CustomControls.EntityListBox listBox, List<int> selectedIds)
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

        public static bool Add(EntityModelSirius model, ReceptionOrderProduct productNew)
        {
            bool result = false;
            using (ReceptionOrderProductFormEdit form = new ReceptionOrderProductFormEdit())
            {
                form.Model = model;
                form.Entity = productNew;
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Edit(EntityModelSirius model, ReceptionOrderProduct product)
        {
            bool result = false;
            using (ReceptionOrderProductFormEdit form = new ReceptionOrderProductFormEdit())
            {
                form.Model = model;
                form.Entity = product;
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static ReceptionOrderProduct GetById(EntityModelSirius model, int id, bool createNewIfNotExists)
        {
            ReceptionOrderProduct result;
            result = model.ReceptionOrderProducts.FirstOrDefault(o => o.Id == id);
            if ((result == null) && (createNewIfNotExists))
            {
                result = new ReceptionOrderProduct();
            }
            return result;
        }
    }
}
