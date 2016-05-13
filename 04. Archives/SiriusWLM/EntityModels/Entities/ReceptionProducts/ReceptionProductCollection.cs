using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Sirius.EntityModels.ReceptionProducts
{
    public class ReceptionProductCollection
    {
        public static string EntityNameSingular = "Articol Receptie";
        public static string EntityNamePlural = "Articole Receptie";

        public static CustomControls.GridViewColumn[] GridViewColumnsNormal = 
		{
			new CustomControls.GridViewColumn("Articol", 220, "L", true),
			new CustomControls.GridViewColumn("UM", 50, "C"),
			new CustomControls.GridViewColumn("Cantitate comanda", 80, "R"),
			new CustomControls.GridViewColumn("Cantitate receptionata", 80, "R"),
			new CustomControls.GridViewColumn("Cantitate diferenta", 80, "R"),
			new CustomControls.GridViewColumn("Calitate OK?", 60, "C"),
			new CustomControls.GridViewColumn("Origine", 60, "L"),
			new CustomControls.GridViewColumn("Temperatura [°C]", 70, "C"),
			new CustomControls.GridViewColumn("Nr. pachete", 60, "C"),
			new CustomControls.GridViewColumn("Observatii", 100, "L")
		};

        public static IOrderedQueryable<ReceptionProduct> GetCollection(EntityModelSirius model, ReceptionProductFilterCriteria criteria)
        {
            var o = from p in model.ReceptionProducts
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

        public static void PopulateGridViewNormal(ReceptionProductFilterCriteria criteria, CustomControls.EntityGridView gridView)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                List<string[]> items = new List<string[]>();
                foreach (var obj in GetCollection(model, criteria))
                {
                    items.Add(new string[] { obj.Id.ToString(), obj.Product.ToString(), obj.Product.MeasuringUnit.ToString(), obj.QuantityOrder.ToString("0.00", CultureInfo.InvariantCulture), obj.QuantityReception.ToString("0.00", CultureInfo.InvariantCulture), (obj.QuantityDifference).ToString("0.00", CultureInfo.InvariantCulture), (obj.IsQualityOK ? "Da" : "Nu"), obj.Origin, obj.Temperature.ToString(), obj.PackageCount.ToString(), obj.Observation });
                }
                gridView.SetItems(items);   
            }
        }

        public static void PopulateGridViewNormal(EntityModelSirius model, List<ReceptionProduct> receptionProductList, CustomControls.EntityGridView gridView)
        {
            List<string[]> items = new List<string[]>();
            foreach (var obj in receptionProductList)
            {
                items.Add(new string[] { obj.Id.ToString(), obj.Product.ToString(), obj.Product.MeasuringUnit.ToString(), obj.QuantityOrder.ToString("0.00", CultureInfo.InvariantCulture), obj.QuantityReception.ToString("0.00", CultureInfo.InvariantCulture), (obj.QuantityDifference).ToString("0.00", CultureInfo.InvariantCulture), (obj.IsQualityOK ? "Da" : "Nu"), obj.Origin, obj.Temperature.ToString(), obj.PackageCount.ToString(), obj.Observation });
            }
            gridView.SetItems(items);
        }

        public static void PopulateGridViewNormal(List<ReceptionOrderProduct> receptionOrderProductList, List<ReceptionProduct> receptionProductList, List<Package> packageList, CustomControls.EntityGridView gridView)
        {
            double quantityReception = 0;
            int count;
            int index = receptionProductList.Count > 0 ? receptionProductList.Max(o => o.Id) : 1;
            Reception reception = receptionOrderProductList.First().Reception;
            ReceptionProduct productExisting;
            foreach (var obj in receptionOrderProductList)
            {
                var collection = from o in packageList
                                 where o.Product.Id == obj.Product.Id
                                 select o;
                count = collection.Count();
                quantityReception = collection.Sum(o => o.Quantity);
                productExisting = receptionProductList.FirstOrDefault(o => o.Product.Id == obj.Product.Id);
                if (productExisting == null)
                {
                    receptionProductList.Add(new ReceptionProduct
                    {
                        Id = index++,
                        PackageCount = count,
                        Product = obj.Product,
                        Reception = reception,
                        QuantityOrder = obj.Quantity,
                        QuantityReception = quantityReception,
                    });
                }
                else
                {
                    productExisting.PackageCount = count;
                    productExisting.QuantityOrder = obj.Quantity;
                    productExisting.QuantityReception = quantityReception;
                }
            }
            /*foreach (var product in ReceptionProductList)
            {
                if (!ReceptionOrderProductList.Exists(o => o.Product.Id == product.Product.Id))
                {
                    ReceptionProductList.Remove(product);
                }
            }*/
            receptionProductList.RemoveAll(o => !receptionOrderProductList.Any(p => p.Product.Id == o.Product.Id));

            List<string[]> items = new List<string[]>();
            foreach (var obj in receptionProductList)
            {
                items.Add(new string[] { obj.Id.ToString(), obj.Product.ToString(), obj.Product.MeasuringUnit.ToString(), obj.QuantityOrder.ToString("0.00", CultureInfo.InvariantCulture), obj.QuantityReception.ToString("0.00", CultureInfo.InvariantCulture), (obj.QuantityDifference).ToString("0.00", CultureInfo.InvariantCulture), (obj.IsQualityOK ? "Da" : "Nu"), obj.Origin, obj.Temperature.ToString(), obj.PackageCount.ToString(), obj.Observation });
            }
            gridView.SetItems(items);
        }

        public static bool Edit(ReceptionProduct product)
        {
            bool result = false;
            using (ReceptionProductFormEdit form = new ReceptionProductFormEdit())
            {
                form.Entity = product;
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static ReceptionProduct GetById(EntityModelSirius model, int id, bool createNewIfNotExists)
        {
            ReceptionProduct result;
            result = model.ReceptionProducts.FirstOrDefault(o => o.Id == id);
            if ((result == null) && (createNewIfNotExists))
            {
                result = new ReceptionProduct();
            }
            return result;
        }

        public static bool UpdateFromPackagesReal(int receptionId)
        {
            bool result = false;
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                Reception reception = Receptions.ReceptionCollection.GetById(model, receptionId, false);
                if (reception != null)
                {
                    ReceptionOrderProduct receptionOrderProduct;
                    ReceptionProduct receptionProduct;
                    var productList = from o in model.Packages
                                      where o.Reception.Id == receptionId
                                      group o by o.Product into p
                                      select new
                                      {
                                          ProductRef = p.Key,
                                          PackageCount = p.Count(),
                                          Quantity = p.Sum(o => o.Quantity)
                                      };
                    foreach (var obj in productList.ToList())
                    {
                        receptionOrderProduct = model.ReceptionOrderProducts.FirstOrDefault(o => (o.Reception.Id == receptionId) && (o.Product.Id == obj.ProductRef.Id));
                        if (receptionOrderProduct != null)
                        {
                            receptionProduct = model.ReceptionProducts.FirstOrDefault(o => (o.Reception.Id == receptionId) && (o.Product.Id == obj.ProductRef.Id));
                            if (receptionProduct == null)
                            {
                                //Not existing - create new
                                receptionProduct = new ReceptionProduct();
                                receptionProduct.Product = obj.ProductRef;
                                receptionProduct.Reception = reception;
                            }

                            //Update with quantities
                            receptionProduct.QuantityOrder = receptionOrderProduct.Quantity;
                            receptionProduct.QuantityReception = obj.Quantity;
                            receptionProduct.PackageCount = obj.PackageCount;

                            if (receptionProduct.Id == 0)
                            {
                                model.ReceptionProducts.AddObject(receptionProduct);
                            }
                            model.SaveChanges();
                            result = true;
                        }
                    }
                }
            }
            return result;
        }
    }
}
