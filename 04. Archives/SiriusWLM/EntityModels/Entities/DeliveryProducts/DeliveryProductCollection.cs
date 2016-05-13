using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Sirius.EntityModels.DeliveryProducts
{
    public class DeliveryProductCollection
    {
        public static string EntityNameSingular = "Articol Livrare";
        public static string EntityNamePlural = "Articole Livrare";

        public static CustomControls.GridViewColumn[] GridViewColumnsNormal = 
		{
			new CustomControls.GridViewColumn("Articol", 220, "L", true),
			new CustomControls.GridViewColumn("UM", 50, "C"),
			new CustomControls.GridViewColumn("Cantitate comanda", 80, "R"),
			new CustomControls.GridViewColumn("Cantitate livrare", 80, "R"),
			new CustomControls.GridViewColumn("Cantitate diferenta", 80, "R"),
			new CustomControls.GridViewColumn("Nr. pachete", 60, "C")
		};

        public static IOrderedQueryable<DeliveryProduct> GetCollection(EntityModelSirius model, DeliveryProductFilterCriteria criteria)
        {
            var coll1 = from p in model.Packages
                        where p.Delivery != null && p.Delivery.Id == criteria.DeliveryId
                        group p by p.Product into q
                        select new DeliveryProduct
                        {
                            Id = 0,
                            Product = q.Key,
                            QuantityOrder = model.DeliveryOrderProducts.FirstOrDefault(o => o.Delivery.Id == criteria.DeliveryId && o.Product.Id == q.Key.Id) != null ? model.DeliveryOrderProducts.FirstOrDefault(o => o.Delivery.Id == criteria.DeliveryId && o.Product.Id == q.Key.Id).Quantity : 0,
                            QuantityDelivery = q.Sum(s => s.Quantity),
                            PackageCount = q.Count()
                        };

            var collection = from o in coll1
                         orderby o.Product.Name
                         select o;
            return collection;
        }

        public static void PopulateGridViewNormal(DeliveryProductFilterCriteria criteria, CustomControls.EntityGridView gridView)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                List<string[]> items = new List<string[]>();
                foreach (var obj in GetCollection(model, criteria))
                {
                    items.Add(new string[] { obj.Id.ToString(), obj.Product.ToString(), obj.Product.MeasuringUnit.ToString(), obj.QuantityOrder.ToString("0.00", CultureInfo.InvariantCulture), obj.QuantityDelivery.ToString("0.00", CultureInfo.InvariantCulture), obj.QuantityDifference.ToString("0.00", CultureInfo.InvariantCulture), obj.PackageCount.ToString() });
                }
                gridView.SetItems(items);
            }
        }

        public static void PopulateGridViewNormal(EntityModelSirius model, List<DeliveryOrderProduct> deliveryOrderProductList, List<Package> packageList, CustomControls.EntityGridView gridView)
        {
            double quantityDelivery = 0, quantityDiff = 0;
            int count;
            List<string[]> items = new List<string[]>();
            foreach (var obj in deliveryOrderProductList)
            {
                var collection = from o in packageList
                                 where o.Product.Id == obj.Product.Id
                                 select o;
                count = collection.Count();
                quantityDelivery = collection.Sum(o => o.Quantity);
                quantityDiff = obj.Quantity - quantityDelivery;
                items.Add(new string[] { "0", obj.Product.ToString(), obj.Product.MeasuringUnit.ToString(), obj.Quantity.ToString("0.00", CultureInfo.InvariantCulture), quantityDelivery.ToString("0.00", CultureInfo.InvariantCulture), quantityDiff.ToString("0.00", CultureInfo.InvariantCulture), count.ToString() });
            }
            gridView.SetItems(items);
        }
    }
}
