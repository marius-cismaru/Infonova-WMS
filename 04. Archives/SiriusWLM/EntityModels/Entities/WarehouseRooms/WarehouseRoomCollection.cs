using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sirius.EntityModels.WarehouseRooms
{
    public class WarehouseRoomCollection
    {
        public static string EntityNameSingular = "Camera";
        public static string EntityNamePlural = "Camere";

        public static CustomControls.GridViewColumn[] GridViewColumnsNormal = 
		{
			new CustomControls.GridViewColumn("Depozit", 100, "L"),
            new CustomControls.GridViewColumn("Cod camera", 60, "C"),
            new CustomControls.GridViewColumn("Descriere", 100, "L"),
			new CustomControls.GridViewColumn("Randuri", 200, "L", true)
		};

        public static IOrderedQueryable<WarehouseRoom> GetCollection(WarehouseRoomFilterCriteria criteria)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                return GetCollection(model, criteria);
            }
        }

        public static IOrderedQueryable<WarehouseRoom> GetCollection(EntityModelSirius model, WarehouseRoomFilterCriteria criteria)
        {
            var o = from p in model.WarehouseRooms
                    select p;
            if (criteria != null)
            {
                if (criteria.CompanyId > 0)
                {
                    o = o.Where(p => p.Warehouse.Company.Id == criteria.CompanyId);
                }
                if (criteria.WarehouseId > 0)
                {
                    o = o.Where(p => p.Warehouse.Id == criteria.WarehouseId);
                }
                if (criteria.Code > 0)
                {
                    o = o.Where(p => p.Code == criteria.Code);
                }
            }
            var collection = from p in o
                orderby p.Warehouse.Name, p.Code
                select p;
            return collection;
        }

        public static void PopulateGridViewNormal(WarehouseRoomFilterCriteria criteria, CustomControls.EntityGridView gridView)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                List<string[]> items = new List<string[]>();
                foreach (var obj in GetCollection(model, criteria))
                {
                    items.Add(new string[] { obj.Id.ToString(), obj.Warehouse.ToString(), obj.Code.ToString(), obj.Description, obj.RowList });
                }
                gridView.SetItems(items);   
            }
        }

        public static void PopulateSelectBox(WarehouseRoomFilterCriteria criteria, CustomControls.EntitySelectBox selectBox, int selectedId, bool showOptionAll)
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

        public static void PopulateSelectBoxWithAvailable(WarehouseRoomFilterCriteria criteria, CustomControls.EntitySelectBox selectBox, int selectedId, bool showOptionAll)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                List<CustomControls.EntityItem> items = new List<CustomControls.EntityItem>();
                foreach (var obj in GetCollection(model, criteria))
                {
                    items.Add(new CustomControls.EntityItem(obj.Id, obj.ToString() + " (disponibile: " + obj.WarehouseContainersCountVacant.ToString() + ")"));
                }
                selectBox.SetItems(items, selectedId, showOptionAll);
            }
        }

        public static void PopulateListBox(WarehouseRoomFilterCriteria criteria, CustomControls.EntityListBox listBox, List<int> selectedIds)
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
            using (WarehouseRoomFormBrowse form = new WarehouseRoomFormBrowse())
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Add()
        {
            bool result = false;
            using (WarehouseRoomFormEdit form = new WarehouseRoomFormEdit { EntityId = 0 })
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Edit(int selectedId)
        {
            bool result = false;
            using (WarehouseRoomFormEdit form = new WarehouseRoomFormEdit { EntityId = selectedId })
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static WarehouseRoom GetById(EntityModelSirius model, int id, bool createNewIfNotExists)
        {
            WarehouseRoom result;
            result = model.WarehouseRooms.FirstOrDefault(o => o.Id == id);
            if ((result == null) && (createNewIfNotExists))
            {
                result = new WarehouseRoom();
            }
            return result;
        }

        public static WarehouseRoom GetByCode(EntityModelSirius model, int warehouseId, int code)
        {
            return model.WarehouseRooms.FirstOrDefault(o => (o.Warehouse.Id == warehouseId) && (o.Code == code));
        }

        public static bool CheckIfExistsByCode(EntityModelSirius model, int warehouseId, int code)
        {
            return (GetByCode(model, warehouseId, code) != null);
        }

        public static bool CheckIfExistsByCodeExceptSelf(int warehouseId, int code, int selfId)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                return (model.WarehouseRooms.FirstOrDefault(o => (o.Id != selfId) && (o.Warehouse.Id == warehouseId) && (o.Code == code)) != null);
            }
        }
    }
}
