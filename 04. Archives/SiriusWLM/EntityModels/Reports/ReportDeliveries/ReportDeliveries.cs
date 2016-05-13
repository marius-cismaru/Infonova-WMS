using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Sirius.EntityModels.Reports
{
    public class ReportDeliveries
    {
        public static string Name = "Livrari";
        public static string Title = Name;

        public static string ToHTML(EntityModelSirius model, ReportDeliveriesFilterCriteria criteria, bool isHTMLFullPage)
        {
            StringBuilder result = new StringBuilder();

            if (isHTMLFullPage)
            {
                result.AppendLine("<html><head>");
                result.AppendLine("<title>" + Name + "</title>");
                result.AppendLine("<style type=\"text/css\">");
                result.AppendLine("body { font-family: Arial, Helvetica, sans-serif; font-size: 10px; }");
                result.AppendLine("table { font-size: 1.2em; }");
                result.AppendLine("h1 { font-size: 3em; }");
                result.AppendLine("h2 { font-size: 2em; }");
                result.AppendLine("h3 { font-size: 1.5em; }");
                result.AppendLine("</style>");
                result.AppendLine("</head><body>");
            }
            result.AppendLine("<h1>" + Configuration.Main.LoggedCompanyNameLong + "</h1>");
            result.AppendLine("<h2>" + Name + "</h2>");
            result.AppendLine("<h3>" + criteria.ToString(model) + "</h3>");
            result.AppendLine("Data executare raport: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "<br/><br/><br/>");
            result.AppendLine("<table border=\"1\" width=\"100%\" cellspacing=\"0\" cellpadding=\"2\">");
            result.AppendLine("<thead><tr>");
            result.AppendLine("<th>Nr.<br/>crt.</th>");
            result.AppendLine("<th>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</th>");
            result.AppendLine("<th>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</th>");
            result.AppendLine("<th>Cod<br/>pachet</th>");
            result.AppendLine("<th>Container</th>");
            result.AppendLine("<th>Cantitate</th>");
            result.AppendLine("<th>Greutate neta<br/>[Kg]</th>");
            result.AppendLine("<th>Greutate bruta<br/>[Kg]</th>");
            result.AppendLine("</tr></thead><tbody>");

            DateTime criteriaDateExecutionBegin = criteria.DateExecutionBegin.HasValue ? CommonLibs.DatesLib.CreateSameDateWithNewTime(criteria.DateExecutionBegin.Value, 0, 0, 0) : new DateTime(2000, 1, 1, 0, 0, 0);
            DateTime criteriaDateExecutionEnd = criteria.DateExecutionEnd.HasValue ? CommonLibs.DatesLib.CreateSameDateWithNewTime(criteria.DateExecutionEnd.Value, 23, 59, 59) : new DateTime(2100, 1, 1, 23, 59, 59);

            var deliveryAllList = (from d in model.Deliveries
                                   from p in model.Packages
                                   where p.Delivery != null && p.Delivery.Id == d.Id && ((criteria.CompanyId == 0) || (p.Reception.Client.Company.Id == criteria.CompanyId)) && ((criteria.ClientId == 0) || (p.Reception.Client.Id == criteria.ClientId)) && ((criteria.WarehouseId == 0) || (p.Reception.Warehouse.Id == criteria.WarehouseId)) && ((criteria.ProductId == 0) || (p.Product.Id == criteria.ProductId)) && (p.Delivery.DateCreation >= criteriaDateExecutionBegin) && (p.Delivery.DateCreation <= criteriaDateExecutionEnd) && ((criteria.ReceptionNumber == 0) || (p.Reception.Number == criteria.ReceptionNumber)) && ((criteria.DeliveryNumber == 0) || (p.Delivery.Number == criteria.DeliveryNumber))
                                   orderby d.Number
                                   select d).Distinct().ToList();
            var deliveryAllIdList = deliveryAllList.Select(o => o.Id).ToList();

            var packageAllList = (from o in model.Packages
                                  where o.Delivery != null && deliveryAllIdList.Contains(o.Delivery.Id)
                                  orderby o.Delivery.Number, o.Product.Name, o.Code
                                  select o).ToList();
            if (packageAllList.Count() > 0)
            {
                var deliveryList = (from o in packageAllList
                                    group o by new { o.Reception.Client, o.Reception.Warehouse, o.Delivery } into p
                                    select new
                                    {
                                        Id = p.Key.Delivery.Id,
                                        Number = p.Key.Delivery.Number,
                                        DateCreation = p.Key.Delivery.DateCreation,
                                        Client = p.Key.Client.NameShort,
                                        Warehouse = p.Key.Warehouse.Name,
                                        PackageCount = p.Count(),
                                        WeightNet = p.Sum(o => o.WeightNet),
                                        WeightGross = p.Sum(o => o.WeightGross)
                                    }).ToList();
                int indexDelivery = 1;
                foreach (var objDelivery in deliveryList)
                {
                    result.AppendLine("<tr style=\"background-color: #FFFFCC;\">");
                    result.AppendLine("<td align=\"center\">" + indexDelivery.ToString() + "</td>");
                    result.Append("<td colspan=\"5\"><b>Livrare nr. " + objDelivery.Number.ToString() + " / " + objDelivery.DateCreation.ToString("dd.MM.yyyy") + ", Client " + objDelivery.Client + ", Depozit " + objDelivery.Warehouse + " - " + objDelivery.PackageCount.ToString() + " pachete</b>");
                    result.AppendLine("</td>");
                    result.AppendLine("<td align=\"right\"><b>" + objDelivery.WeightNet.ToString("0.00", CultureInfo.InvariantCulture) + "</b></td>");
                    result.AppendLine("<td align=\"right\"><b>" + objDelivery.WeightGross.ToString("0.00", CultureInfo.InvariantCulture) + "</b></td>");
                    result.AppendLine("</tr>");

                    var deliveryProductList = (from o in packageAllList
                                               where o.Delivery.Id == objDelivery.Id
                                               group o by o.Product into p
                                               select new
                                               {
                                                   Id = p.Key.Id,
                                                   Code = p.Key.Code,
                                                   Name = p.Key.Name,
                                                   MU = p.Key.MeasuringUnit.Name,
                                                   PackageCount = p.Count(),
                                                   Quantity = p.Sum(o => o.Quantity),
                                                   WeightNet = p.Sum(o => o.WeightNet),
                                                   WeightGross = p.Sum(o => o.WeightGross)
                                               }).ToList();
                    foreach (var objProduct in deliveryProductList)
                    {
                        result.AppendLine("<tr>");
                        result.AppendLine("<td colspan=\"2\">&nbsp;</td>");
                        result.AppendLine("<td colspan=\"3\"><b>" + objProduct.Code + " - " + objProduct.Name + " [" + objProduct.MU + "] - " + objProduct.PackageCount.ToString() + " pachete</b></td>");
                        result.AppendLine("<td align=\"right\"><b>" + objProduct.Quantity.ToString("0.00", CultureInfo.InvariantCulture) + "</b></td>");
                        result.AppendLine("<td align=\"right\"><b>" + objProduct.WeightNet.ToString("0.00", CultureInfo.InvariantCulture) + "</b></td>");
                        result.AppendLine("<td align=\"right\"><b>" + objProduct.WeightGross.ToString("0.00", CultureInfo.InvariantCulture) + "</b></td>");
                        result.AppendLine("</tr>");

                        var deliveryProductPackageList = (from o in packageAllList
                                                         where o.Delivery.Id == objDelivery.Id && o.Product.Id == objProduct.Id
                                                         select o).ToList();
                        if (deliveryProductPackageList.Count() > 0)
                        {
                            foreach (var objPackage in deliveryProductPackageList)
                            {
                                result.AppendLine("<tr>");
                                result.AppendLine("<td  colspan=\"3\" style=\"font-size: 0.7em; text-align: right;\">Receptie: " + objPackage.Reception.ToString() + "</td>");
                                result.AppendLine("<td align=\"center\">" + objPackage.Code + "</td>");
                                result.AppendLine("<td align=\"center\">" + objPackage.WarehouseContainer.CodeToString + "</td>");
                                result.AppendLine("<td align=\"right\">" + objPackage.Quantity.ToString("0.00", CultureInfo.InvariantCulture) + "</td>");
                                result.AppendLine("<td align=\"right\">" + objPackage.WeightNet.ToString("0.00", CultureInfo.InvariantCulture) + "</td>");
                                result.AppendLine("<td align=\"right\">" + objPackage.WeightGross.ToString("0.00", CultureInfo.InvariantCulture) + "</td>");
                                result.AppendLine("</tr>");
                            }
                        }
                    }
                    indexDelivery++;
                }

                result.AppendLine("</tbody><tfoot>");

                result.AppendLine("<tr>");
                result.AppendLine("<td colspan=\"6\"><b>TOTAL: " + (indexDelivery - 1).ToString() + " Livrari - " + packageAllList.Count().ToString() + " pachete</b></td>");
                result.AppendLine("<td align=\"right\"><b>" + packageAllList.Sum(o => o.WeightNet).ToString("0.00", CultureInfo.InvariantCulture) + "</b></td>");
                result.AppendLine("<td align=\"right\"><b>" + packageAllList.Sum(o => o.WeightGross).ToString("0.00", CultureInfo.InvariantCulture) + "</b></td>");
                result.AppendLine("</tr>");
                result.AppendLine("</tfoot>");
            }
            else
            {
                result.AppendLine("<tr>");
                result.AppendLine("<td colspan=\"8\">Nu exista inregistari</td>");
                result.AppendLine("</tr>");
            }

            result.AppendLine("</table>");

            if (isHTMLFullPage)
            {
                result.AppendLine("</body></html>");
            }

            return result.ToString();
        }

        public static void ShowDialog(ReportDeliveriesFilterCriteria criteria)
        {
            using (ReportDeliveriesFormReport form = new ReportDeliveriesFormReport())
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
