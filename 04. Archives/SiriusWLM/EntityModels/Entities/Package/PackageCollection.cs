using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Sirius.EntityModels.Packages
{
    public class PackageCollection
    {
        public static string EntityNameSingular = "Pachet";
        public static string EntityNamePlural = "Pachete";

        public static CustomControls.GridViewColumn[] GridViewColumnsNormal = 
		{
			new CustomControls.GridViewColumn("Existent?", 40, "C"),
			new CustomControls.GridViewColumn("Client", 80, "L"),
			new CustomControls.GridViewColumn("Depozit", 60, "L"),
			new CustomControls.GridViewColumn("Produs", 160, "L", true),
			new CustomControls.GridViewColumn("Cod", 60, "C"),
			new CustomControls.GridViewColumn("Container", 60, "C"),
			new CustomControls.GridViewColumn("Cantitate", 60, "R"),
			new CustomControls.GridViewColumn("Greutate neta [Kg]", 70, "R"),
			new CustomControls.GridViewColumn("Greutate bruta [Kg]", 70, "R"),
			new CustomControls.GridViewColumn("Data productie", 60, "C"),
			new CustomControls.GridViewColumn("Receptie", 70, "L"),
			new CustomControls.GridViewColumn("Livrare", 70, "L"),
		};

        public static CustomControls.GridViewColumn[] GridViewColumnsWithPosition = 
		{
			new CustomControls.GridViewColumn("Ordine", 60, "C"),
			new CustomControls.GridViewColumn("Produs", 160, "L", true),
			new CustomControls.GridViewColumn("Obs. receptie", 120, "L"),
			new CustomControls.GridViewColumn("Cod pachet", 60, "C"),
			new CustomControls.GridViewColumn("Container", 60, "C"),
			new CustomControls.GridViewColumn("Cantitate", 70, "R"),
			new CustomControls.GridViewColumn("Greutate neta [Kg]", 70, "R"),
			new CustomControls.GridViewColumn("Greutate bruta [Kg]", 70, "R")
		};

        public static CustomControls.GridViewColumn[] GridViewColumnsWithReception = 
		{
			new CustomControls.GridViewColumn("Receptie", 100, "L"),
			new CustomControls.GridViewColumn("Client", 100, "L"),
			new CustomControls.GridViewColumn("Articol", 100, "L", true),
			new CustomControls.GridViewColumn("Cantitate", 60, "R"),
			new CustomControls.GridViewColumn("Cod", 60, "L"),
			new CustomControls.GridViewColumn("Container", 60, "L"),
			new CustomControls.GridViewColumn("Lot client", 50, "C"),
			new CustomControls.GridViewColumn("Data productie", 80, "C")
		};

        public static CustomControls.GridViewColumn[] GridViewColumnsWithProductAndReception = 
		{
			new CustomControls.GridViewColumn("Articol", 120, "L", true),
			new CustomControls.GridViewColumn("Receptie", 100, "L"),
			new CustomControls.GridViewColumn("Cod", 60, "L"),
			new CustomControls.GridViewColumn("Container", 60, "L"),
			new CustomControls.GridViewColumn("Cantitate", 60, "R"),
			new CustomControls.GridViewColumn("Greutate neta [Kg]", 70, "R"),
			new CustomControls.GridViewColumn("Greutate bruta [Kg]", 70, "R"),
			new CustomControls.GridViewColumn("Data productie", 80, "C")
		};

        public static CustomControls.GridViewColumn[] GridViewColumnsWithProductAndDelivery = 
		{
			new CustomControls.GridViewColumn("Articol", 120, "L", true),
			new CustomControls.GridViewColumn("Livrare", 100, "L"),
			new CustomControls.GridViewColumn("Cod", 60, "L"),
			new CustomControls.GridViewColumn("Container", 60, "L"),
			new CustomControls.GridViewColumn("Cantitate", 60, "R"),
			new CustomControls.GridViewColumn("Greutate neta [Kg]", 70, "R"),
			new CustomControls.GridViewColumn("Greutate bruta [Kg]", 70, "R"),
			new CustomControls.GridViewColumn("Data productie", 80, "C")
		};

        public static IOrderedQueryable<Package> GetCollection(EntityModelSirius model, PackageFilterCriteria criteria)
        {
            var o = from p in model.Packages
                    select p;
            if (criteria != null)
            {
                if (criteria.OptionIsExisting != PackageFilterCriteria.OptionsIsExisting.All)
                {
                    if (criteria.OptionIsExisting == PackageFilterCriteria.OptionsIsExisting.Yes)
                    {
                        o = o.Where(p => (p.Delivery == null));
                    }
                    else
                    {
                        o = o.Where(p => (p.Delivery != null));
                    }
                }
                if (criteria.CompanyId > 0)
                {
                    o = o.Where(p => p.Reception.Client.Company.Id == criteria.CompanyId);
                }
                if (criteria.ClientId > 0)
                {
                    o = o.Where(p => p.Reception.Client.Id == criteria.ClientId);
                }
                if (criteria.WarehouseId > 0)
                {
                    o = o.Where(p => p.WarehouseContainer.WarehouseRow.WarehouseRoom.Warehouse.Id == criteria.WarehouseId);
                }
                if (criteria.ProductId > 0)
                {
                    o = o.Where(p => p.Product.Id == criteria.ProductId);
                }
                if (criteria.Code != string.Empty)
                {
                    o = o.Where(p => p.Code.Contains(criteria.Code));
                }
                if (criteria.WarehouseContainerName != string.Empty)
                {
                    o = o.Where(p => p.WarehouseContainer.Name.Contains(criteria.WarehouseContainerName));
                }
                if (criteria.ReceptionNumber > 0)
                {
                    o = o.Where(p => p.Reception.Number == criteria.ReceptionNumber);
                }
                if (criteria.DeliveryNumber > 0)
                {
                    o = o.Where(p => p.Delivery != null && p.Delivery.Number == criteria.DeliveryNumber);
                }
            }
            var collection = from p in o
                orderby p.Reception.Client.NameShort, p.Reception.Warehouse.Name, p.Code
                select p;
            return collection;
        }

        public static void PopulateGridViewNormal(PackageFilterCriteria criteria, CustomControls.EntityGridView gridView)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                List<string[]> items = new List<string[]>();
                foreach (var obj in GetCollection(model, criteria).ToList())
                {
                    items.Add(new string[] { obj.Id.ToString(), obj.Delivery == null ? "Da" : "Nu", obj.Reception.Client.ToString(), obj.Reception.Warehouse.ToString(), obj.Product.ToString(), obj.Code.ToString(), obj.WarehouseContainer.ToString(), obj.Quantity.ToString() + " " + obj.Product.MeasuringUnit.ToString(), obj.WeightNet.ToString("0.00", CultureInfo.InvariantCulture), obj.WeightGross.ToString("0.00", CultureInfo.InvariantCulture), obj.DateProduction.ToString("yyyy-MM-dd"), obj.Reception.ToString(), obj.Delivery != null ? obj.Delivery.ToString() : string.Empty });
                }
                gridView.SetItems(items);
            }
        }

        public static void PopulateGridViewWithReception(List<Package> packageList, CustomControls.EntityGridView gridView)
        {
            List<string[]> items = new List<string[]>();
            foreach (var obj in packageList)
            {
                items.Add(new string[] { obj.Id.ToString(), obj.Reception.ToString(), obj.Reception.Client.ToString(), obj.Product.ToString(), obj.Quantity.ToString() + " " + obj.Product.MeasuringUnit.ToString(), obj.Code.ToString(), obj.WarehouseContainer.ToString(), obj.Batch, obj.DateProduction.ToString("yyyy-MM-dd") });
            }
            gridView.SetItems(items);
        }

        public static void PopulateGridViewWithProductAndReception(int deliveryId, CustomControls.EntityGridView gridView)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                List<string[]> items = new List<string[]>();
                foreach (var obj in model.Packages.Where(o=>o.Delivery != null && o.Delivery.Id == deliveryId))
                {
                    items.Add(new string[] { obj.Id.ToString(), obj.Product.ToString(), obj.Reception.ToString(), obj.Code.ToString(), obj.WarehouseContainer.ToString(), obj.Quantity.ToString() + " " + obj.Product.MeasuringUnit.ToString(), obj.WeightNet.ToString("0.00", CultureInfo.InvariantCulture), obj.WeightGross.ToString("0.00", CultureInfo.InvariantCulture), obj.DateProduction.ToString("yyyy-MM-dd") });
                }
                gridView.SetItems(items);
            }
        }

        public static void PopulateGridViewWithProductAndDelivery(int receptionId, CustomControls.EntityGridView gridView)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                List<string[]> items = new List<string[]>();
                foreach (var obj in model.Packages.Where(o => o.Reception.Id == receptionId).OrderBy(o => o.Code))
                {
                    items.Add(new string[] { obj.Id.ToString(), obj.Product.ToString(), obj.Delivery != null ? obj.Delivery.ToString() : string.Empty, obj.Code.ToString(), obj.WarehouseContainer.ToString(), obj.Quantity.ToString() + " " + obj.Product.MeasuringUnit.ToString(), obj.WeightNet.ToString("0.00", CultureInfo.InvariantCulture), obj.WeightGross.ToString("0.00", CultureInfo.InvariantCulture), obj.DateProduction.ToString("yyyy-MM-dd") });
                }
                gridView.SetItems(items);
            }
        }

        public static void PopulateGridViewWithPosition(List<Package> packageList, CustomControls.EntityGridView gridView)
        {
            Package obj;
            List<string[]> items = new List<string[]>();
            for (int i = packageList.Count; i > 0; i--)
            {
                obj = packageList[i - 1];
                items.Add(new string[] { obj.Id.ToString(), i.ToString("00"), obj.Product.ToString(), obj.Reception.Comment, obj.Code, obj.WarehouseContainer.CodeToString, obj.Quantity.ToString("0.00", CultureInfo.InvariantCulture), obj.WeightNet.ToString("0.00", CultureInfo.InvariantCulture), obj.WeightGross.ToString("0.00", CultureInfo.InvariantCulture) });
            }
            gridView.SetItems(items);
        }

        public static void PopulateCheckedListBox(EntityModelSirius model, List<Package> packageSelectList, List<Package> packagePickList, CustomControls.EntityCheckedListBox checkedListBox)
        {
            List<CustomControls.EntityItem> items = new List<CustomControls.EntityItem>();
            foreach (var obj in packageSelectList)
            {
                items.Add(new CustomControls.EntityItem(obj.Id, obj.WarehouseContainer.Name + " - " + obj.Code + " - " + obj.Quantity.ToString("0.00", CultureInfo.InvariantCulture) + " " + obj.Product.MeasuringUnit.ToString()));
            }
            checkedListBox.SetItems(items, new List<int>());
            Package package;
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                package = packageSelectList.FirstOrDefault(o => o.Id == ((CustomControls.EntityItem)checkedListBox.Items[i]).Id);
                if (package != null)
                {
                    checkedListBox.SetItemChecked(i, packagePickList.Contains(package));
                }
            }
        }

        public static bool AddVirtual(EntityModelSirius model, Package packageNew, List<ReceptionOrderProduct> receptionOrderProductList, List<Package> packageList, WarehouseContainer warehouseContainerNext)
        {
            bool result = false;
            using (PackageFormAddVirtual form = new PackageFormAddVirtual())
            {
                form.Model = model;
                form.Entity = packageNew;
                form.ReceptionOrderProductList = receptionOrderProductList;
                form.PackageList = packageList;
                form.WarehouseContainerNext = warehouseContainerNext;
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool AddReal(int receptionId, int packagePreviousId)
        {
            bool result = false;
            using (PackageFormAddReal form = new PackageFormAddReal())
            {
                form.ReceptionId = receptionId;
                form.PackagePreviousId = packagePreviousId;
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool EditReal(int selectedId)
        {
            bool result = false;
            using (PackageFormEditReal form = new PackageFormEditReal { EntityId = selectedId })
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Browse()
        {
            bool result = false;
            using (PackageFormBrowse form = new PackageFormBrowse())
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static Package GetById(EntityModelSirius model, int id, bool createNewIfNotExists)
        {
            Package result;
            result = model.Packages.FirstOrDefault(o => o.Id == id);
            if ((result == null) && (createNewIfNotExists))
            {
                result = new Package();
            }
            return result;
        }

        public static string GetNewCode()
        {
            int code = 1;
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                var packageCode = model.PackageCodeGenerators.FirstOrDefault();
                if (packageCode == null)
                {
                    PackageCodeGenerator obj = new PackageCodeGenerator();
                    obj.Code = 1;
                    model.PackageCodeGenerators.AddObject(obj);
                }
                else
                {
                    code = packageCode.Code;
                    code++;
                    packageCode.Code = code;
                }
                model.SaveChanges();
            }

            return CommonLibs.StringsLib.ConvertBase10ToBase32(code, 4);
        }

        public static string GenerateNewCode(string clientSymbol1, int inputReceptionNumber, int outputOrderProductPosition, int packagePosition)
        {
            return ((clientSymbol1 + inputReceptionNumber.ToString("000") + CommonLibs.StringsLib.GetLetterByIndex(outputOrderProductPosition) + packagePosition.ToString("00")).ToUpper());
        }

        public static bool CheckIfExistsByCode(string code)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                code = code.Trim().ToUpper();
                return (model.Packages.FirstOrDefault(o => o.Code == code) != null);
            }
        }

        public static bool CheckIfExistsByCodeExceptSelf(string code, int selfId)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                code = code.Trim().ToUpper();
                return (model.Packages.FirstOrDefault(o => (o.Code == code) && (o.Id != selfId)) != null);
            }
        }
    }
}
