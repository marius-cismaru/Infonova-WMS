using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Sirius.EntityModels.Reports
{
    public class ReportReceptions
    {
        public static string Name = "Receptii";
        public static string Title = Name;

        public static string ToHTML(EntityModelSirius model, ReportReceptionsFilterCriteria criteria)
        {
            StringBuilder result = new StringBuilder();

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

            var receptionAllList = (from o in model.Receptions
                                   from p in model.Packages
                                   where p.Reception.Id == o.Id && ((criteria.CompanyId == 0) || (p.Reception.Client.Company.Id == criteria.CompanyId)) && ((criteria.ClientId == 0) || (p.Reception.Client.Id == criteria.ClientId)) && ((criteria.WarehouseId == 0) || (p.Reception.Warehouse.Id == criteria.WarehouseId)) && ((criteria.ProductId == 0) || (p.Product.Id == criteria.ProductId)) && (p.Reception.DateCreation >= criteriaDateExecutionBegin) && (p.Reception.DateCreation <= criteriaDateExecutionEnd) && ((criteria.ReceptionNumber == 0) || (p.Reception.Number == criteria.ReceptionNumber)) && ((criteria.DeliveryNumber == 0) || ((p.Delivery != null) &&(p.Delivery.Number == criteria.DeliveryNumber)))
                                   orderby o.Client.NameShort, o.Number
                                   select o).Distinct().ToList();
            var receptionAllIdList = receptionAllList.Select(o => o.Id).ToList();

            var packageAllList = (from o in model.Packages
                                  where receptionAllIdList.Contains(o.Reception.Id)
                                  orderby o.Reception.Client.NameShort, o.Reception.Number, o.Product.Name, o.Code
                                  select o).ToList();
            if (packageAllList.Count() > 0)
            {
                var receptionList = (from o in packageAllList
                                    group o by new { o.Reception.Client, o.Reception.Warehouse, o.Reception } into p
                                    select new
                                    {
                                        Id = p.Key.Reception.Id,
                                        Number = p.Key.Reception.Number,
                                        DateCreation = p.Key.Reception.DateCreation,
                                        Client = p.Key.Client.NameShort,
                                        Warehouse = p.Key.Warehouse.Name,
                                        PackageCount = p.Count(),
                                        WeightNet = p.Sum(o => o.WeightNet),
                                        WeightGross = p.Sum(o => o.WeightGross)
                                    }).ToList();
                int indexReception = 1;
                foreach (var objReception in receptionList)
                {
                    result.AppendLine("<tr style=\"background-color: #FFFFCC;\">");
                    result.AppendLine("<td align=\"center\">" + indexReception.ToString() + "</td>");
                    result.AppendLine("<td colspan=\"5\"><b>Receptie nr. " + objReception.Number.ToString() + " / " + objReception.DateCreation.ToString("dd.MM.yyyy") + ", Client " + objReception.Client + ", Depozit " + objReception.Warehouse + " - " + objReception.PackageCount.ToString() + " pachete</b></td>");
                    result.AppendLine("<td align=\"right\"><b>" + objReception.WeightNet.ToString("0.00", CultureInfo.InvariantCulture) + "</b></td>");
                    result.AppendLine("<td align=\"right\"><b>" + objReception.WeightGross.ToString("0.00", CultureInfo.InvariantCulture) + "</b></td>");
                    result.AppendLine("</tr>");

                    var receptionProductList = (from o in packageAllList
                                               where o.Reception.Id == objReception.Id
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
                    foreach (var objProduct in receptionProductList)
                    {
                        result.AppendLine("<tr>");
                        result.AppendLine("<td colspan=\"2\">&nbsp;</td>");
                        result.AppendLine("<td colspan=\"3\"><b>" + objProduct.Code + " - " + objProduct.Name + " [" + objProduct.MU + "] - " + objProduct.PackageCount.ToString() + " pachete</b></td>");
                        result.AppendLine("<td align=\"right\"><b>" + objProduct.Quantity.ToString("0.00", CultureInfo.InvariantCulture) + "</b></td>");
                        result.AppendLine("<td align=\"right\"><b>" + objProduct.WeightNet.ToString("0.00", CultureInfo.InvariantCulture) + "</b></td>");
                        result.AppendLine("<td align=\"right\"><b>" + objProduct.WeightGross.ToString("0.00", CultureInfo.InvariantCulture) + "</b></td>");
                        result.AppendLine("</tr>");

                        var receptionProductPackageList = (from o in packageAllList
                                                         where o.Reception.Id == objReception.Id && o.Product.Id == objProduct.Id
                                                         select o).ToList();
                        if (receptionProductPackageList.Count() > 0)
                        {
                            foreach (var objPackage in receptionProductPackageList)
                            {
                                result.AppendLine("<tr>");;
                                result.AppendLine("<td colspan=\"3\" style=\"font-size: 0.7em; text-align: right;\">" + (objPackage.Delivery != null ? ("Livrare: " + objPackage.Delivery.ToString()) : "&nbsp;") + "</td>");
                                result.AppendLine("<td align=\"center\">" + objPackage.Code + "</td>");
                                result.AppendLine("<td align=\"center\">" + objPackage.WarehouseContainer.CodeToString + "</td>");
                                result.AppendLine("<td align=\"right\">" + objPackage.Quantity.ToString("0.00", CultureInfo.InvariantCulture) + "</td>");
                                result.AppendLine("<td align=\"right\">" + objPackage.WeightNet.ToString("0.00", CultureInfo.InvariantCulture) + "</td>");
                                result.AppendLine("<td align=\"right\">" + objPackage.WeightGross.ToString("0.00", CultureInfo.InvariantCulture) + "</td>");
                                result.AppendLine("</tr>");
                            }
                        }
                    }
                    indexReception++;
                }

                result.AppendLine("</tbody><tfoot>");

                result.AppendLine("<tr>");
                result.AppendLine("<td colspan=\"6\"><b>TOTAL: " + (indexReception - 1).ToString() + " Receptii - " + packageAllList.Count().ToString() + " pachete</b></td>");
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
            result.AppendLine("</body></html>");

            return result.ToString();
        }

        public static void ShowDialog(ReportReceptionsFilterCriteria criteria)
        {
            using (ReportReceptionsFormReport form = new ReportReceptionsFormReport())
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
