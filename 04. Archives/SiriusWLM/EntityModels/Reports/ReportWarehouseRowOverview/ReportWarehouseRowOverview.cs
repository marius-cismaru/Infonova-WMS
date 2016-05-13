using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sirius.EntityModels.Reports
{
    public class ReportWarehouseRowOverview
    {
        public static string Title = "Situatie depozitare rand";
        public static string Name = Title;

        public static string ToHTML(EntityModelSirius model, ReportWarehouseRowOverviewFilterCriteria criteria)
        {
            StringBuilder result = new StringBuilder();

            EntityModels.WarehouseRow row = EntityModels.WarehouseRows.WarehouseRowCollection.GetById(model, criteria.WarehouseRowId, false);
            if (row != null)
            {
                result.AppendLine("<html><head>");
                result.AppendLine("<title>" + Title + "</title>");
                result.AppendLine("<style type=\"text/css\">");
                result.AppendLine("body { font-family: Arial, Helvetica, sans-serif; font-size: 12px; }");
                result.AppendLine("table { font-size: 1em; }");
                result.AppendLine("</style>");
                result.AppendLine("</head><body>");
                result.AppendLine("<h2>" + Name + "</h2>");
                result.AppendLine("<table width=\"100%\" cellspacing=\"4\" cellpadding=\"0\">");
                result.AppendLine("<tr><td>Rand:</td><td>" + row.ToString() + "</td></tr>");
                result.AppendLine("<tr><td>Camera:</td><td>" + row.WarehouseRoom.ToString() + "</td></tr>");
                result.AppendLine("<tr><td>Depozit:</td><td>" + row.WarehouseRoom.Warehouse.ToString() + "</td></tr>");
                result.AppendLine("<tr><td>Container-e totale:</td><td>" + row.WarehouseContainers.Count.ToString() + "</td></tr>");
                result.AppendLine("<tr><td>Container-e disponibile:</td><td>" + row.WarehouseContainersCountVacant.ToString() + "</td></tr>");
                result.AppendLine("<tr><td>Pachete per clienti:</td><td>" + row.PackagesPerClientToString.ToString() + "</td></tr>");
                result.AppendLine("</table><br/><br/>");
                result.AppendLine("<table width=\"100%\" cellspacing=\"0\" cellpadding=\"0\">");
                result.AppendLine("<tr>");

                //Config
                int cellPadding = 10;
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

                    /*cellWidth = (((int)graphics.ClipBounds.Width) - (2 * padding + marginLeft)) / (maxInterval * maxSlot);
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
                     * */
                }
            }

            return result.ToString();
        }

        public static void ShowDialog(ReportWarehouseRowOverviewFilterCriteria criteria)
        {
            using (ReportWarehouseRowOverviewFormReport form = new ReportWarehouseRowOverviewFormReport())
            {
                if (criteria != null)
                {
                    form.Criteria = criteria;
                }
                form.ShowDialog();
            }
        }
    }
}
