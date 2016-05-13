using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Sirius.EntityModels.WarehouseRows
{
    public class WarehouseRowCollection
    {
        public static string EntityNameSingular = "Rand";
        public static string EntityNamePlural = "Randuri";

        public static CustomControls.GridViewColumn[] GridViewColumnsNormal = 
		{
			new CustomControls.GridViewColumn("Depozit", 100, "L"),
            new CustomControls.GridViewColumn("Camera", 60, "C"),
            new CustomControls.GridViewColumn("Cod rand", 50, "C"),
			new CustomControls.GridViewColumn("Inversat?", 60, "C"),
			new CustomControls.GridViewColumn("Containere cu stocare limitata?", 70, "C"),
			new CustomControls.GridViewColumn("Nr. containere total", 70, "C"),
			new CustomControls.GridViewColumn("Nr pachete existente per client", 200, "L", true),
		};

        public static IOrderedQueryable<WarehouseRow> GetCollection(EntityModelSirius model, WarehouseRowFilterCriteria criteria)
        {
            var o = from p in model.WarehouseRows
                    select p;
            if (criteria != null)
            {
                if (criteria.CompanyId > 0)
                {
                    o = o.Where(p => p.WarehouseRoom.Warehouse.Company.Id == criteria.CompanyId);
                }
                if (criteria.WarehouseId > 0)
                {
                    o = o.Where(p => p.WarehouseRoom.Warehouse.Id == criteria.WarehouseId);
                }
                if (criteria.WarehouseRoomId > 0)
                {
                    o = o.Where(p => p.WarehouseRoom.Id == criteria.WarehouseRoomId);
                }
                if (criteria.OptionIsLimited != WarehouseRowFilterCriteria.OptionsIsLimited.All)
                {
                    bool isLimited = criteria.OptionIsLimited == WarehouseRowFilterCriteria.OptionsIsLimited.Yes ? true : false;
                    o = o.Where(p => p.IsLimited == isLimited);
                }
            }
            var collection = from p in o
                orderby p.WarehouseRoom.Warehouse.Name, p.WarehouseRoom.Code, p.Code
                select p;
            return collection;
        }

        public static void PopulateGridViewNormal(WarehouseRowFilterCriteria criteria, CustomControls.EntityGridView gridView)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                List<string[]> items = new List<string[]>();
                foreach (var obj in GetCollection(model, criteria))
                {
                    items.Add(new string[] { obj.Id.ToString(), obj.WarehouseRoom.Warehouse.ToString(), obj.WarehouseRoom.Code.ToString(), obj.Code.ToString(), (obj.IsInverted ? "Da" : "Nu"), (obj.IsLimited ? "Da" : "Nu"), obj.WarehouseContainers.Count.ToString(), obj.PackagesPerClientToString });
                }
                gridView.SetItems(items);   
            }
        }

        public static void PopulateSelectBox(WarehouseRowFilterCriteria criteria, CustomControls.EntitySelectBox selectBox, int selectedId, bool showOptionAll)
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

        public static void PopulateSelectBoxWithAvailable(WarehouseRowFilterCriteria criteria, CustomControls.EntitySelectBox selectBox, int selectedId, bool showOptionAll)
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

        public static void PopulateListBox(WarehouseRowFilterCriteria criteria, CustomControls.EntityListBox listBox, List<int> selectedIds)
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
            using (WarehouseRowFormBrowse form = new WarehouseRowFormBrowse())
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Add()
        {
            bool result = false;
            using (WarehouseRowFormEdit form = new WarehouseRowFormEdit())
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Edit(int selectedId)
        {
            bool result = false;
            using (WarehouseRowFormEdit form = new WarehouseRowFormEdit { EntityId = selectedId })
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static WarehouseRow GetById(EntityModelSirius model, int id, bool createNewIfNotExists)
        {
            WarehouseRow result;
            result = model.WarehouseRows.FirstOrDefault(o => o.Id == id);
            if ((result == null) && (createNewIfNotExists))
            {
                result = new WarehouseRow();
            }
            return result;
        }

        public static WarehouseRow GetByCode(EntityModelSirius model, int code)
        {
            WarehouseRow result;
            result = model.WarehouseRows.FirstOrDefault(o => o.Code == code);
            return result;
        }

        public static List<WarehouseContainers.WarehouseContainerLocation> RenderOnGraphics(EntityModelSirius model, Graphics graphics, WarehouseRow row, List<WarehouseContainer> containerSelectedList, List<Package> packageNewList)
        {
            //packageNewList este lista de pahete introduse deja

            List<WarehouseContainers.WarehouseContainerLocation> result = new List<WarehouseContainers.WarehouseContainerLocation>();

            graphics.FillRectangle(Brushes.White, graphics.ClipBounds);

            if (row != null)
            {
                //Config
                int padding = 10;
                int marginLeft = 20;
                int marginTop = 25;
                int marginBottom = 40;
                int cellHeight = 0, cellWidth = 0;

                var containerList = model.WarehouseContainers.Where(o => o.WarehouseRow.Id == row.Id);
                if (containerList.Count() > 0)
                {
                    int maxInterval = 0, maxSlot = 0, maxFloor = 0;

                    //Calculul maximului de interval, slot si floor
                    foreach (var obj in containerList)
                    {
                        if (obj.Interval > maxInterval) maxInterval = obj.Interval;
                        if (obj.Slot > maxSlot) maxSlot = obj.Slot;
                        if (obj.Floor > maxFloor) maxFloor = obj.Floor;
                    }

                    cellWidth = (((int)graphics.ClipBounds.Width) - (2 * padding + marginLeft)) / (maxInterval * maxSlot);
                    cellHeight = (((int)graphics.ClipBounds.Height) - (2 * padding + marginTop + marginBottom)) / maxFloor;

                    //Calculul coordonatelor containerelor
                    foreach (var obj in containerList)
                    {
                        result.Add(new WarehouseContainers.WarehouseContainerLocation
                        {
                            Container = obj,
                            IsSelected = containerSelectedList.Contains(obj),
                            IsEmpty = (obj.Packages.Where(o => o.Delivery == null).Count() == 0),
                            HasNewPackage = packageNewList.FirstOrDefault(o => o.WarehouseContainer == obj) != null,
                            //Location = new System.Drawing.Rectangle(padding + marginLeft + (((obj.Interval - 1) * maxSlot) + (obj.Slot - 1)) * cellWidth, padding + marginTop + (maxFloor - obj.Floor) * cellHeight, cellWidth, cellHeight)
                            Location = new System.Drawing.Rectangle(padding + marginLeft + (((row.IsInverted ? (maxInterval - obj.Interval) : (obj.Interval - 1)) * maxSlot) + (obj.Slot - 1)) * cellWidth, padding + marginTop + (maxFloor - obj.Floor) * cellHeight, cellWidth, cellHeight)
                        });
                    }

                    //Render containers
                    foreach (var obj in result)
                    {
                        obj.RenderOnGraphics(graphics);
                    }

                    //Draw floor numbers
                    float fontSizeFloor = cellHeight / 7;
                    Font fontFloot = new Font("Arial", fontSizeFloor, FontStyle.Regular);
                    for (int i = 0; i < maxFloor; i++)
                    {
                        graphics.DrawString((maxFloor - i).ToString(), fontFloot, Brushes.Black, padding + (marginLeft - fontSizeFloor) / 2, padding + marginTop + ((cellHeight - fontSizeFloor) / 2) + i * cellHeight);
                    }

                    //Draw slot numbers
                    float fontSizeSlot = cellWidth / 5;
                    Font fontSlot = new Font("Arial", fontSizeSlot, FontStyle.Regular);
                    for (int i = 0; i < maxSlot; i++)
                    {
                        for (int j = 0; j < maxInterval; j++)
                        {
                            graphics.DrawString((i + 1).ToString(), fontSlot, Brushes.Black, padding + marginLeft + ((j * maxSlot) + i) * cellWidth + ((cellWidth - fontSizeSlot) / 2), padding + ((marginTop - fontSizeSlot) / 2));
                        }
                    }

                    //Draw intervals (lines + numbers)
                    float fontSizeInterval = fontSizeSlot * (float)2;
                    Font fontInterval = new Font("Arial", fontSizeInterval, FontStyle.Regular);
                    Pen penInterval = new Pen(Color.Black, 4);
                    int intervalNumber;
                    for (int i = 0; i < maxInterval; i++)
                    {
                        graphics.DrawLine(penInterval, i * maxSlot * cellWidth + padding + marginLeft, padding, i * maxSlot * cellWidth + padding + marginLeft, (int)graphics.ClipBounds.Height - padding);
                        intervalNumber = row.IsInverted ? (maxInterval - i) : (i + 1);
                        graphics.DrawString(intervalNumber.ToString(), fontInterval, Brushes.Black, padding + marginLeft + (i * maxSlot * cellWidth) + (((maxSlot * cellWidth) - fontSizeInterval) / 2), graphics.ClipBounds.Height - padding - marginBottom + ((marginBottom - fontSizeInterval) / 2));
                    }
                    graphics.DrawLine(penInterval, maxInterval * maxSlot * cellWidth + padding + marginLeft, padding, maxInterval * maxSlot * cellWidth + padding + marginLeft, (int)graphics.ClipBounds.Height - padding);
                }
            }
            return result;
        }

        public static WarehouseRow GetByCode(EntityModelSirius model, int warehouseRoomId, int code)
        {
            return model.WarehouseRows.FirstOrDefault(o => (o.WarehouseRoom.Id == warehouseRoomId) && (o.Code == code));
        }

        public static bool CheckIfExistsByCode(EntityModelSirius model, int warehouseRoomId, int code)
        {
            return (GetByCode(model, warehouseRoomId, code) != null);
        }

        public static bool CheckIfExistsByCodeExceptSelf(int warehouseRoomId, int code, int selfId)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                return (model.WarehouseRows.FirstOrDefault(o => (o.Id != selfId) && (o.WarehouseRoom.Id == warehouseRoomId) && (o.Code == code)) != null);
            }
        }
    }
}
