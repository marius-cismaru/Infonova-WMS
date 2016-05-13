using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Sirius.EntityModels.WarehouseContainers
{
    public class WarehouseContainerCollection
    {
        public static string EntityNameSingular = "Container";
        public static string EntityNamePlural = "Containere";

        public static CustomControls.GridViewColumn[] GridViewColumnsNormal = 
		{
			new CustomControls.GridViewColumn("Depozit", 100, "L"),
            new CustomControls.GridViewColumn("Camera", 60, "C"),
            new CustomControls.GridViewColumn("Rand", 50, "C"),
			new CustomControls.GridViewColumn("Disponibil?", 70, "C"),
			new CustomControls.GridViewColumn("Stocare limitata?", 70, "C"),
			new CustomControls.GridViewColumn("Cod", 60, "C"),
            new CustomControls.GridViewColumn("Pachete existente", 100, "L", true)
		};

        public static List<WarehouseContainer> GetCollection(EntityModelSirius model, WarehouseContainerFilterCriteria criteria)
        {
            var collection = (from p in model.WarehouseContainers
                     orderby p.WarehouseRow.WarehouseRoom.Warehouse.Name, p.IsAvailable, p.Name
                     select p).ToList();
            if (criteria != null)
            {
                if (criteria.CompanyId > 0)
                {
                    collection = collection.Where(p => p.WarehouseRow.WarehouseRoom.Warehouse.Company.Id == criteria.CompanyId).ToList();
                }
                if (criteria.WarehouseId > 0)
                {
                    collection = collection.Where(p => p.WarehouseRow.WarehouseRoom.Warehouse.Id == criteria.WarehouseId).ToList();
                }
                if (criteria.OptionIsAvailable != WarehouseContainerFilterCriteria.OptionsIsAvailable.All)
                {
                    bool isAvailable = criteria.OptionIsAvailable == WarehouseContainerFilterCriteria.OptionsIsAvailable.Yes ? true : false;
                    collection = collection.Where(p => p.IsAvailable == isAvailable).ToList();
                }
                if (criteria.Name != string.Empty)
                {
                    collection = collection.Where(p => p.Name.Contains(criteria.Name)).ToList();
                }
                if (criteria.Room > 0)
                {
                    collection = collection.Where(p => p.WarehouseRow.WarehouseRoom.Code == criteria.Room).ToList();
                }
                if (criteria.Row > 0)
                {
                    collection = collection.Where(p => p.WarehouseRow.Code == criteria.Row).ToList();
                }
                if (criteria.Interval > 0)
                {
                    collection = collection.Where(p => p.Interval == criteria.Interval).ToList();
                }
                if (criteria.Slot > 0)
                {
                    collection = collection.Where(p => p.Slot == criteria.Slot).ToList();
                }
                if (criteria.Floor > 0)
                {
                    collection = collection.Where(p => p.Floor == criteria.Floor).ToList();
                }
                if (criteria.OptionIsLimited != WarehouseContainerFilterCriteria.OptionsIsLimited.All)
                {
                    bool isLimited = criteria.OptionIsLimited == WarehouseContainerFilterCriteria.OptionsIsLimited.Yes ? true : false;
                    collection = collection.Where(p => p.WarehouseRow.IsLimited == isLimited).ToList();
                }
            }
            return collection;
        }

        public static void PopulateGridViewNormal(WarehouseContainerFilterCriteria criteria, CustomControls.EntityGridView gridView)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                List<string[]> items = new List<string[]>();
                foreach (var obj in GetCollection(model, criteria))
                {
                    items.Add(new string[] { obj.Id.ToString(), obj.WarehouseRow.WarehouseRoom.Warehouse.ToString(), obj.WarehouseRow.WarehouseRoom.Code.ToString(), obj.WarehouseRow.Code.ToString(), (obj.IsAvailable ? "Da" : "Nu"), (obj.WarehouseRow.IsLimited ? "Da" : "Nu"), obj.Name, obj.PackageExistingList });
                }
                gridView.SetItems(items);   
            }
        }

        public static void PopulateSelectBox(WarehouseContainerFilterCriteria criteria, CustomControls.EntitySelectBox selectBox, int selectedId, bool showOptionAll)
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

        public static void PopulateSelectBoxWithUnlimited(WarehouseContainerFilterCriteria criteria, CustomControls.EntitySelectBox selectBox, int selectedId, CustomControls.EntityItem extraItem)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                criteria.OptionIsAvailable = WarehouseContainerFilterCriteria.OptionsIsAvailable.Yes;
                criteria.OptionIsLimited = WarehouseContainerFilterCriteria.OptionsIsLimited.No;
                var containerNotLimitedList = GetCollection(model, criteria).ToList();
                List<CustomControls.EntityItem> items = new List<CustomControls.EntityItem>();
                
                if(extraItem != null)
                {
                    items.Add(extraItem);
                }
                foreach (var obj in containerNotLimitedList)
                {
                    items.Add(new CustomControls.EntityItem(obj.Id, obj.ToString() + " (nelimitat)"));
                }
                selectBox.SetItems(items, selectedId, false);
            }
        }

        public static void PopulateListBox(WarehouseContainerFilterCriteria criteria, CustomControls.EntityListBox listBox, List<int> selectedIds)
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

        public static void PopulateListBoxPackageRelation(List<WarehouseContainer> warehouseContainerList, List<Package> packageList, CustomControls.EntityListBox listBox)
        {
            listBox.Items.Clear();
            string packageCode;
            Package package;
            for (int i = warehouseContainerList.Count; i > 0; i--)
            {
                package = packageList.FirstOrDefault(o => o.WarehouseContainer == warehouseContainerList[i - 1]);
                packageCode = package != null ? package.Code : string.Empty;
                listBox.Items.Add(i.ToString("00") + " - " + warehouseContainerList[i - 1].CodeToString + (packageCode != string.Empty ? (" [" + packageCode + "]") : string.Empty));
            }
        }

        public static void PopulateListBoxPackageAssociation(List<WarehouseContainer> warehouseContainerList, List<Package> packageList, CustomControls.EntityListBox listBox)
        {
            listBox.Items.Clear();
            string packageCode;
            Package package;
            int packageIndex;
            for (int i = warehouseContainerList.Count; i > 0; i--)
            {
                packageIndex = i - 1;
                package = packageList.Count > packageIndex ? packageList[packageIndex] : null;
                packageCode = package != null ? package.Code : string.Empty;
                listBox.Items.Add(i.ToString("00") + " - " + warehouseContainerList[i - 1].CodeToString + (packageCode != string.Empty ? (" [" + packageCode + "]") : string.Empty));
            }
        }

        public static bool Browse()
        {
            bool result = false;
            using (WarehouseContainerFormBrowse form = new WarehouseContainerFormBrowse())
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Add()
        {
            bool result = false;
            using (WarehouseContainerFormAdd form = new WarehouseContainerFormAdd())
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Edit(int selectedId)
        {
            bool result = false;
            using (WarehouseContainerFormEdit form = new WarehouseContainerFormEdit { EntityId = selectedId })
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static List<int> Select(int warehouseId, int maxCountAllowed)
        {
            List<int> result = new List<int>();
            using (WarehouseContainerFormSelect form = new WarehouseContainerFormSelect())
            {
                form.WarehouseId = warehouseId;
                form.MaxCountAllowed = maxCountAllowed;
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (var id in form.SelectedWarehouseContainerIdList)
                    {
                        result.Add(id);
                    }
                }
            }
            return result;
        }

        public static WarehouseContainer GetById(EntityModelSirius model, int id, bool createNewIfNotExists)
        {
            WarehouseContainer result;
            result = model.WarehouseContainers.FirstOrDefault(o => o.Id == id);
            if ((result == null) && (createNewIfNotExists))
            {
                result = new WarehouseContainer();
            }
            return result;
        }

        public static WarehouseContainer GetByName(EntityModelSirius model, string name)
        {
            WarehouseContainer result;
            result = model.WarehouseContainers.Where(o => ((o.Name == name.ToUpper()) && (o.WarehouseRow.WarehouseRoom.Warehouse.Company.Id == Configuration.Main.LoggedCompanyId))).FirstOrDefault();
            return result;
        }

        public static WarehouseContainer GetByLocation(EntityModelSirius model, int warehouseId, int room, int row, int interval, int slot, int floor)
        {
            WarehouseContainer result;
            result = model.WarehouseContainers.FirstOrDefault(o => ((o.WarehouseRow.WarehouseRoom.Warehouse.Id == warehouseId) && (o.WarehouseRow.WarehouseRoom.Code == room) && (o.WarehouseRow.Code == row) && (o.Interval == interval) && (o.Slot == slot) && (o.Floor == floor)));
            return result;
        }

        public static bool CheckIfAvailableById(int id)
        {
            bool result = true;
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                var container = GetById(model, id, false);
                if (container != null)
                {
                    result &= container.IsAvailable;
                    result &= (!container.WarehouseRow.IsLimited) || ((container.Packages.Count == 0) || (container.Packages.All(o => o.Delivery != null)));
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }

        public static bool CheckIfAvailableByIdExceptSelfPackage(int id, int packageId)
        {
            bool result = true;
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                var container = GetById(model, id, false);
                if (container != null)
                {
                    var package = Packages.PackageCollection.GetById(model, packageId, true);

                    result &= container.IsAvailable;
                    result &= (container.Packages.Contains(package)) || (!container.WarehouseRow.IsLimited) || ((container.Packages.Count == 0) || (container.Packages.All(o => o.Delivery != null)));
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }
    }
}
