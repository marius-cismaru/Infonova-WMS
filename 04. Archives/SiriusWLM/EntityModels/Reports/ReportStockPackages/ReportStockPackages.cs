using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Sirius.EntityModels.Reports
{
    public class ReportStockPackages
    {
        public static string Name = "Stoc pe pachete la data";
        public static string Title = Name;

        public static string ToHTML(EntityModelSirius model, ReportStockPackagesFilterCriteria criteria, bool showCSS)
        {
            StringBuilder result = new StringBuilder();

            string NameWithDate = Name + " " + criteria.DateExecution.ToString("dd.MM.yyyy");

            result.AppendLine("<html><head>");
            result.AppendLine("<title>" + NameWithDate + "</title>");
            if (showCSS)
            {
                result.AppendLine("<style type=\"text/css\">");
                result.AppendLine("body { font-family: Arial, Helvetica, sans-serif; font-size: 10px; }");
                result.AppendLine("table { font-size: 1.2em; }");
                result.AppendLine("h1 { font-size: 2.2em; }");
                result.AppendLine("h2 { font-size: 1.7em; }");
                result.AppendLine("</style>");
            }
            result.AppendLine("</head><body>");
            result.AppendLine("<h1>" + NameWithDate + "</h1>");
            result.AppendLine("<h2>" + criteria.ToString(model) + "</h2>");
            result.AppendLine("Data executare raport: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "<br/><br/><br/>");
            result.AppendLine("<table border=\"1\" width=\"100%\" cellspacing=\"0\" cellpadding=\"2\">");
            result.AppendLine("<thead><tr>");
            result.AppendLine("<th>Client</th>");
            result.AppendLine("<th>Depozit</th>");
            result.AppendLine("<th>Cod<br/>articol</th>");
            result.AppendLine("<th>Denumire<br/>articol</th>");
            result.AppendLine("<th>UM</th>");
            result.AppendLine("<th>Nr.<br/>pachete</th>");
            result.AppendLine("<th>Cantitate</th>");
            result.AppendLine("<th>Greutate neta<br/>[Kg]</th>");
            result.AppendLine("<th>Greutate bruta<br/>[Kg]</th>");
            result.AppendLine("<th>Container</th>");
            result.AppendLine("<th>Cod<br/>pachet</th>");
            result.AppendLine("</tr></thead><tbody>");

            DateTime criteriaDateExecutionForReception = CommonLibs.DatesLib.CreateSameDateWithNewTime(criteria.DateExecution, 23, 59, 59);
            DateTime criteriaDateExecutionForDelivery = CommonLibs.DatesLib.CreateSameDateWithNewTime(criteria.DateExecution, 23, 59, 59);

            var packageAllList = (from o in model.Packages
                                  where ((criteria.CompanyId == 0) || (o.Reception.Client.Company.Id == criteria.CompanyId)) && ((criteria.ClientId == 0) || (o.Reception.Client.Id == criteria.ClientId)) && ((criteria.WarehouseId == 0) || (o.Reception.Warehouse.Id == criteria.WarehouseId)) && ((criteria.ProductId == 0) || (o.Product.Id == criteria.ProductId)) && (o.Reception.DateCreation <= criteriaDateExecutionForReception) && ((o.Delivery == null) || (o.Delivery.DateCreation > criteriaDateExecutionForDelivery)) && ((criteria.ReceptionNumber == 0) || (o.Reception.Number == criteria.ReceptionNumber))
                                  orderby o.Reception.Client.Company.NameShort, o.Reception.Client.NameShort, o.Reception.Warehouse, o.Product.Name, o.Code
                                  select o).ToList();
            if (packageAllList.Count() > 0)
            {
                var productList = (from o in packageAllList
                                   group o by new { o.Reception.Client, o.Reception.Warehouse, o.Product } into p
                                   select new
                                   {
                                       Id = p.Key.Product.Id,
                                       Client = p.Key.Client.NameShort,
                                       Warehouse = p.Key.Warehouse.Name,
                                       Code = p.Key.Product.Code,
                                       Name = p.Key.Product.Name,
                                       UM = p.Key.Product.MeasuringUnit.Name,
                                       PackageCount = p.Count(),
                                       Quantity = p.Sum(o => o.Quantity),
                                       WeightNet = p.Sum(o => o.WeightNet),
                                       WeightGross = p.Sum(o => o.WeightGross)
                                   }).ToList();
                foreach (var objProduct in productList)
                {
                    result.AppendLine("<tr>");
                    result.AppendLine("<td><b>" + objProduct.Client + "</b></td>");
                    result.AppendLine("<td><b>" + objProduct.Warehouse + "</b></td>");
                    result.AppendLine("<td align=\"center\"><b>" + objProduct.Code + "</b></td>");
                    result.AppendLine("<td><b>" + objProduct.Name + "</b></td>");
                    result.AppendLine("<td align=\"center\"><b>" + objProduct.UM + "</b></td>");
                    result.AppendLine("<td align=\"center\"><b>" + objProduct.PackageCount.ToString() + "</b></td>");
                    result.AppendLine("<td align=\"right\"><b>" + objProduct.Quantity.ToString("0.00", CultureInfo.InvariantCulture) + "</b></td>");
                    result.AppendLine("<td align=\"right\"><b>" + objProduct.WeightNet.ToString("0.00", CultureInfo.InvariantCulture) + "</b></td>");
                    result.AppendLine("<td align=\"right\"><b>" + objProduct.WeightGross.ToString("0.00", CultureInfo.InvariantCulture) + "</b></td>");
                    result.AppendLine("<td colspan=\"2\">&nbsp;</td>");
                    result.AppendLine("</tr>");

                    var packageListProduct = (from w in packageAllList
                                              where w.Product.Id == objProduct.Id
                                              select w).ToList();
                    if (packageListProduct.Count() > 0)
                    {
                        foreach (var objPackage in packageListProduct)
                        {
                            result.AppendLine("<tr>");
                            result.AppendLine("<td colspan=\"6\" style=\"font-size: 0.7em; text-align: right;\">Receptie: " + objPackage.Reception.ToString() + (objPackage.Delivery != null ? (", Livrare: " + objPackage.Delivery.ToString()) : string.Empty) + "</td>");
                            result.AppendLine("<td align=\"right\">" + objPackage.Quantity.ToString("0.00", CultureInfo.InvariantCulture) + "</td>");
                            result.AppendLine("<td align=\"right\">" + objPackage.WeightNet.ToString("0.00", CultureInfo.InvariantCulture) + "</td>");
                            result.AppendLine("<td align=\"right\">" + objPackage.WeightGross.ToString("0.00", CultureInfo.InvariantCulture) + "</td>");
                            result.AppendLine("<td align=\"center\">" + objPackage.WarehouseContainer.CodeToString + "</td>");
                            result.AppendLine("<td align=\"center\">" + objPackage.Code + "</td>");
                            result.AppendLine("</tr>");
                        }
                    }
                }

                result.AppendLine("</tbody><tfoot>");

                result.AppendLine("<tr>");
                result.AppendLine("<td colspan=\"5\">TOTAL</td>");
                result.AppendLine("<td align=\"center\"><b>" + packageAllList.Count().ToString() + "</b></td>");
                result.AppendLine("<td align=\"right\"><b>&nbsp;</b></td>");
                result.AppendLine("<td align=\"right\"><b>" + packageAllList.Sum(o => o.WeightNet).ToString("0.00", CultureInfo.InvariantCulture) + "</b></td>");
                result.AppendLine("<td align=\"right\"><b>" + packageAllList.Sum(o => o.WeightGross).ToString("0.00", CultureInfo.InvariantCulture) + "</b></td>");
                result.AppendLine("<td colspan=\"2\">&nbsp;</td>");
                result.AppendLine("</tr>");
                result.AppendLine("</tfoot>");
            }
            else
            {
                result.AppendLine("<tr>");
                result.AppendLine("<td colspan=\"11\">Nu exista inregistari</td>");
                result.AppendLine("</tr>");
            }

            result.AppendLine("</table>");
            result.AppendLine("</body></html>");

            return result.ToString();
        }

        public static void ShowDialog(ReportStockPackagesFilterCriteria criteria)
        {
            using (ReportStockPackagesFormReport form = new ReportStockPackagesFormReport())
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
