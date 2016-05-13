using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using OfficeOpenXml;
using System.Data;
using System.IO;

namespace Sirius.EntityModels.Reports
{
    public class ReportStockProductsByClient
    {
        public class ReportStockProductsByClientResult
        {
            public string HTMLContent { get; set; }
            public string ExcelFileName { get; set; }
        }

        public static string Name = "Stoc pe articole la data";
        public static string Title = Name;

        public static ReportStockProductsByClientResult ToHTMLAndExcelFile(EntityModelSirius model, ReportStockProductsByClientFilterCriteria criteria)
        {
            StringBuilder html = new StringBuilder();

            string description = criteria.ToString(model);

            html.AppendLine("<h1>" + Name + "</h1>");
            html.AppendLine("<h3>" + description + "</h3>");
            html.AppendLine("Data executare raport: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "<br/><br/><br/>");
            html.AppendLine("<table border=\"1\" width=\"100%\" cellspacing=\"0\" cellpadding=\"4\">");
            html.AppendLine("<thead><tr>");
            html.AppendLine("<th>Nr.</th>");
            html.AppendLine("<th>Cod<br/>articol</th>");
            html.AppendLine("<th>Denumire<br/>articol</th>");
            html.AppendLine("<th>UM</th>");
            html.AppendLine("<th>Cantitate</th>");
            html.AppendLine("<th>Greutate neta<br/>[Kg]</th>");
            html.AppendLine("<th>Greutate bruta<br/>[Kg]</th>");
            html.AppendLine("<th>Nr.<br/>paleti</th>");
            html.AppendLine("</tr></thead><tbody>");

            var dataTable = new DataTable();

            dataTable.Columns.Add("Nr.", typeof(int));
            dataTable.Columns.Add("Cod articol", typeof(string));
            dataTable.Columns.Add("Denumire articol", typeof(string));
            dataTable.Columns.Add("UM", typeof(string));
            dataTable.Columns.Add("Cantitate", typeof(double));
            dataTable.Columns.Add("Greutate neta [Kg]", typeof(double));
            dataTable.Columns.Add("Greutate bruta [Kg]", typeof(double));
            dataTable.Columns.Add("Nr. paleti", typeof(int));

            DataRow dataTableRow;

            DateTime criteriaDateExecutionForReception = CommonLibs.DatesLib.CreateSameDateWithNewTime(criteria.DateExecution, 23, 59, 59);
            DateTime criteriaDateExecutionForDelivery = CommonLibs.DatesLib.CreateSameDateWithNewTime(criteria.DateExecution, 23, 59, 59);

            int index = 1;
            var packageList = (from o in model.Packages
                               where (o.Reception.Client.Id == criteria.ClientId) && (o.Reception.DateCreation <= criteriaDateExecutionForReception) && ((o.Delivery == null) || (o.Delivery.DateCreation > criteriaDateExecutionForDelivery))
                               group o by o.Product into p
                               orderby p.Key.Name
                               select new
                               {
                                   ProductRef = p.Key,
                                   Quantity = p.Sum(o => o.Quantity),
                                   WeightNet = p.Sum(o => o.WeightNet),
                                   WeightGross = p.Sum(o => o.WeightGross),
                                   PackageCount = p.Count()
                               }).ToList();

            foreach (var obj in packageList)
            {
                html.AppendLine("<tr>");
                html.AppendLine("<td align=\"center\">" + index.ToString() + "</td>");
                html.AppendLine("<td align=\"center\">" + obj.ProductRef.Code + "</td>");
                html.AppendLine("<td>" + obj.ProductRef.Name + "</td>");
                html.AppendLine("<td align=\"center\">" + obj.ProductRef.MeasuringUnit.ToString() + "</td>");
                html.AppendLine("<td align=\"right\">" + obj.Quantity.ToString("0.00", CultureInfo.InvariantCulture) + "</td>");
                html.AppendLine("<td align=\"right\">" + obj.WeightNet.ToString("0.00", CultureInfo.InvariantCulture) + "</td>");
                html.AppendLine("<td align=\"right\">" + obj.WeightGross.ToString("0.00", CultureInfo.InvariantCulture) + "</td>");
                html.AppendLine("<td align=\"right\">" + obj.PackageCount.ToString() + "</td>");
                html.AppendLine("</tr>");

                //Add data table for excel
                dataTableRow = dataTable.NewRow();
                //Add columns to rows
                dataTableRow[0] = index;
                dataTableRow[1] = obj.ProductRef.Code;
                dataTableRow[2] = obj.ProductRef.Name;
                dataTableRow[3] = obj.ProductRef.MeasuringUnit.ToString();
                dataTableRow[4] = obj.Quantity.ToString("0.00", CultureInfo.InvariantCulture);
                dataTableRow[5] = obj.WeightNet.ToString("0.00", CultureInfo.InvariantCulture);
                dataTableRow[6] = obj.WeightGross.ToString("0.00", CultureInfo.InvariantCulture);
                dataTableRow[7] = obj.PackageCount.ToString();

                //Add row to table
                dataTable.Rows.Add(dataTableRow);

                index++;
            }

            html.AppendLine("</tbody><tfoot>");
            html.AppendLine("<tr>");
            html.AppendLine("<td colspan=\"6\"><b>TOTAL</b></td>");
            html.AppendLine("<td align=\"right\"><b>" + packageList.Sum(o => o.WeightNet).ToString("0.00", CultureInfo.InvariantCulture) + "</b></td>");
            html.AppendLine("<td align=\"right\"><b>" + packageList.Sum(o => o.WeightGross).ToString("0.00", CultureInfo.InvariantCulture) + "</b></td>");
            html.AppendLine("<td align=\"right\"><b>" + packageList.Sum(o => o.PackageCount).ToString() + "</b></td>");
            html.AppendLine("</tr>");
            html.AppendLine("</tfoot></table>");

            //Save to excel
            var tempPath = System.IO.Path.GetTempPath();
            var excelFileName = tempPath + "Stoc_" + description + ".xlsx";

            try
            {
                using (FileStream stream = new FileStream(excelFileName, FileMode.Create))
                {
                    using (ExcelPackage pck = new ExcelPackage(stream))
                    {
                        ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Stoc");
                        ws.Cells["A1"].LoadFromDataTable(dataTable, true);
                        pck.Save();
                    }
                }
            }
            catch
            {
            }

            return new ReportStockProductsByClientResult { HTMLContent = html.ToString(), ExcelFileName = excelFileName };
        }
    }
}
