using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Sirius.EntityModels.Reports
{
    public class ReportStockProducts
    {
        public static string Name = "Stoc pe articole la data";
        public static string Title = Name;

        public static string ToHTML(EntityModelSirius model, ReportStockProductsFilterCriteria criteria)
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("<h1>" + Name + "</h1>");
            result.AppendLine("<h3>" + criteria.ToString(model) + "</h3>");
            result.AppendLine("Data executare raport: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "<br/><br/><br/>");
            result.AppendLine("<table border=\"1\" width=\"100%\" cellspacing=\"0\" cellpadding=\"4\">");
            result.AppendLine("<thead><tr>");
            result.AppendLine("<th>Nr.</th>");
            result.AppendLine("<th>Client</th>");
            result.AppendLine("<th>Cod<br/>articol</th>");
            result.AppendLine("<th>Denumire<br/>articol</th>");
            result.AppendLine("<th>UM</th>");
            result.AppendLine("<th>Cantitate</th>");
            result.AppendLine("<th>Greutate neta<br/>[Kg]</th>");
            result.AppendLine("<th>Greutate bruta<br/>[Kg]</th>");
            result.AppendLine("<th>Nr.<br/>paleti</th>");
            result.AppendLine("</tr></thead><tbody>");

            DateTime criteriaDateExecutionForReception = CommonLibs.DatesLib.CreateSameDateWithNewTime(criteria.DateExecution, 23, 59, 59);
            DateTime criteriaDateExecutionForDelivery = CommonLibs.DatesLib.CreateSameDateWithNewTime(criteria.DateExecution, 23, 59, 59);

            int index = 1;
            var packageList = (from o in model.Packages
                               where ((criteria.CompanyId == 0) || (o.Reception.Client.Company.Id == criteria.CompanyId)) && ((criteria.ClientId == 0) || (o.Reception.Client.Id == criteria.ClientId)) && ((criteria.WarehouseId == 0) || (o.Reception.Warehouse.Id == criteria.WarehouseId)) && (o.Reception.DateCreation <= criteriaDateExecutionForReception) && ((o.Delivery == null) || (o.Delivery.DateCreation > criteriaDateExecutionForDelivery))
                               group o by o.Product into p
                               orderby p.Key.Client.NameShort, p.Key.Name
                               select new
                               {
                                   ClientRef = p.Key.Client,
                                   ProductRef = p.Key,
                                   Quantity = p.Sum(o => o.Quantity),
                                   WeightNet = p.Sum(o => o.WeightNet),
                                   WeightGross = p.Sum(o => o.WeightGross),
                                   PackageCount = p.Count()
                               }).ToList();

            foreach (var obj in packageList)
            {
                result.AppendLine("<tr>");
                result.AppendLine("<td align=\"center\">" + index.ToString() + "</td>");
                result.AppendLine("<td>" + obj.ClientRef.ToString() + "</td>");
                result.AppendLine("<td align=\"center\">" + obj.ProductRef.Code + "</td>");
                result.AppendLine("<td>" + obj.ProductRef.Name + "</td>");
                result.AppendLine("<td align=\"center\">" + obj.ProductRef.MeasuringUnit.ToString() + "</td>");
                result.AppendLine("<td align=\"right\">" + obj.Quantity.ToString("0.00", CultureInfo.InvariantCulture) + "</td>");
                result.AppendLine("<td align=\"right\">" + obj.WeightNet.ToString("0.00", CultureInfo.InvariantCulture) + "</td>");
                result.AppendLine("<td align=\"right\">" + obj.WeightGross.ToString("0.00", CultureInfo.InvariantCulture) + "</td>");
                result.AppendLine("<td align=\"right\">" + obj.PackageCount.ToString() + "</td>");
                result.AppendLine("</tr>");
                index++;
            }

            result.AppendLine("</tbody><tfoot>");
            result.AppendLine("<tr>");
            result.AppendLine("<td colspan=\"6\"><b>TOTAL</b></td>");
            result.AppendLine("<td align=\"right\"><b>" + packageList.Sum(o => o.WeightNet).ToString("0.00", CultureInfo.InvariantCulture) + "</b></td>");
            result.AppendLine("<td align=\"right\"><b>" + packageList.Sum(o => o.WeightGross).ToString("0.00", CultureInfo.InvariantCulture) + "</b></td>");
            result.AppendLine("<td align=\"right\"><b>" + packageList.Sum(o => o.PackageCount).ToString() + "</b></td>");
            result.AppendLine("</tr>");
            result.AppendLine("</tfoot></table>");

            return result.ToString();
        }

        public static void ShowDialog(ReportStockProductsFilterCriteria criteria)
        {
            using (ReportStockProductsFormReport form = new ReportStockProductsFormReport())
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
