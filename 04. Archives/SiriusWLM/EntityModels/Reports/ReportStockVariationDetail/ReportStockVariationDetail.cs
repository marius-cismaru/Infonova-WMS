using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Sirius.EntityModels.Reports
{
    public class ReportStockVariationDetail
    {
        public static string Name = "Variatie stoc in detaliu";
        public static string Title = Name;

        public static string ToHTML(EntityModelSirius model, ReportStockVariationDetailFilterCriteria criteria, bool showHTMLHeader, bool showHTMLFooter)
        {
            StringBuilder result = new StringBuilder();

            if (showHTMLHeader)
            {
                result.AppendLine("<html><head>");
                result.AppendLine("<title>" + Name + "</title>");
                result.AppendLine("<style type=\"text/css\">");
                result.AppendLine("body { font-family: Arial, Helvetica, sans-serif; font-size: 10px; }");
                result.AppendLine("table { font-size: 1.2em; }");
                result.AppendLine("h1 { font-size: 3em; }");
                result.AppendLine("h2 { font-size: 2em; }");
                result.AppendLine("h3 { font-size: 1.5em; }");
                result.AppendLine("td.in, th.in { background-color: #EEFFEE; }");
                result.AppendLine("td.out, th.out { background-color: #FFEEEE; }");
                result.AppendLine("td.current, th.current { background-color: #FFFFEE; }");
                result.AppendLine("</style>");
                result.AppendLine("</head><body>");
            }
            //result.AppendLine("<h1>" + Configuration.Main.LoggedCompanyNameLong + "</h1>");
            result.AppendLine("<h1>" + Name + "</h1>");
            result.AppendLine("<h3>" + criteria.ToString(model) + "</h3>");
            //result.AppendLine("Data executare raport: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "<br/><br/>");

            result.AppendLine("<table border=\"1\" width=\"100%\" cellspacing=\"0\" cellpadding=\"2\">");
            result.AppendLine("<thead>");
            result.AppendLine("<tr>");
            result.AppendLine("<th rowspan=\"2\">Data</th>");
            result.AppendLine("<th class=\"in\" colspan=\"3\">Intrari</th>");
            result.AppendLine("<th class=\"out\" colspan=\"3\">Iesiri</th>");
            result.AppendLine("<th class=\"current\" colspan=\"3\">Stoc</th>");
            result.AppendLine("<th rowspan=\"2\">Receptii / Livrari</th>");
            result.AppendLine("</tr>");
            result.AppendLine("<tr>");
            result.AppendLine("<th class=\"in\">Pachete<br/>[buc]</th>");
            result.AppendLine("<th class=\"in\">Greutate neta<br/>[t]</th>");
            result.AppendLine("<th class=\"in\">Greutate bruta<br/>[t]</th>");
            result.AppendLine("<th class=\"out\">Pachete<br/>[buc]</th>");
            result.AppendLine("<th class=\"out\">Greutate neta<br/>[t]</th>");
            result.AppendLine("<th class=\"out\">Greutate bruta<br/>[t]</th>");
            result.AppendLine("<th class=\"current\">Pachete<br/>[buc]</th>");
            result.AppendLine("<th class=\"current\">Greutate neta<br/>[t]</th>");
            result.AppendLine("<th class=\"current\">Greutate bruta<br/>[t]</th>");
            result.AppendLine("</thead><tbody>");

            DateTime criteriaDateExecutionBegin = criteria.DateExecutionBegin.HasValue ? CommonLibs.DatesLib.CreateSameDateWithNewTime(criteria.DateExecutionBegin.Value, 0, 0, 0) : new DateTime(2000, 1, 1, 0, 0, 0);
            DateTime criteriaDateExecutionEnd = criteria.DateExecutionEnd.HasValue ? CommonLibs.DatesLib.CreateSameDateWithNewTime(criteria.DateExecutionEnd.Value, 23, 59, 59) : new DateTime(2100, 1, 1, 23, 59, 59);

            List<ReportStockVariationDetailAction> actionListFinal = new List<ReportStockVariationDetailAction>();

            var receptionList = (from p in model.Packages
                                 from o in model.Receptions
                                 where p.Reception.Id == o.Id && ((criteria.CompanyId == 0) || (p.Reception.Client.Company.Id == criteria.CompanyId)) && ((criteria.ClientId == 0) || (p.Reception.Client.Id == criteria.ClientId)) && ((criteria.WarehouseId == 0) || (p.Reception.Warehouse.Id == criteria.WarehouseId)) && ((criteria.ProductId == 0) || (p.Product.Id == criteria.ProductId)) && (p.Reception.DateCreation >= criteriaDateExecutionBegin) && (p.Reception.DateCreation <= criteriaDateExecutionEnd)
                                 group p by p.Reception into q
                                 select new ReportStockVariationDetailAction
                                 {
                                     DateExecution = q.Key.DateCreation,
                                     PackageCountVariationIn = q.Count(),
                                     WeightNetVariationIn = q.Sum(m => m.WeightNet),
                                     WeightGrossVariationIn = q.Sum(m => m.WeightGross),
                                     ReceptionDeliveryClientSymbol = q.Key.Client.NameSymbol1,
                                     ReceptionDeliveryNumber = q.Key.Number
                                 }).ToList();

            var deliveryList = (from p in model.Packages
                                from o in model.Deliveries
                                where p.Delivery.Id == o.Id && ((criteria.CompanyId == 0) || (p.Reception.Client.Company.Id == criteria.CompanyId)) && ((criteria.ClientId == 0) || (p.Reception.Client.Id == criteria.ClientId)) && ((criteria.WarehouseId == 0) || (p.Reception.Warehouse.Id == criteria.WarehouseId)) && ((criteria.ProductId == 0) || (p.Product.Id == criteria.ProductId)) && (p.Delivery.DateCreation >= criteriaDateExecutionBegin) && (p.Delivery.DateCreation <= criteriaDateExecutionEnd)
                                group p by p.Delivery into q
                                select new ReportStockVariationDetailAction
                                {
                                    DateExecution = q.Key.DateCreation,
                                    PackageCountVariationOut = q.Count(),
                                    WeightNetVariationOut = q.Sum(m => m.WeightNet),
                                    WeightGrossVariationOut = q.Sum(m => m.WeightGross),
                                    ReceptionDeliveryClientSymbol = q.Key.Client.NameSymbol1,
                                    ReceptionDeliveryNumber = q.Key.Number
                                }).ToList();
            /*var tmp = from o in receptionList.Concat(deliveryList)
                      group o by new { o.DateExecution.Year, o.DateExecution.Month, o.DateExecution.Day } into p
                      select new ReportStockVariationDetailAction
                      {
                          DateExecution = new DateTime(p.Key.Year, p.Key.Month, p.Key.Day),
                          PackageCountVariationIn = p.Sum(o => o.PackageCountVariationIn),
                          PackageCountVariationOut = p.Sum(o => o.PackageCountVariationOut),
                          WeightGrossVariationIn = p.Sum(o => o.WeightGrossVariationIn),
                          WeightGrossVariationOut = p.Sum(o => o.WeightGrossVariationOut),
                          WeightNetVariationIn = p.Sum(o => o.WeightNetVariationIn),
                          WeightNetVariationOut = p.Sum(o => o.WeightNetVariationOut)
                      };
            */

            var actionListTemp = receptionList.Concat(deliveryList).OrderBy(o => o.DateExecution).ToList();
            int Year = 0, Month = 0, Day = 0;
            int indexAction = 0;

            var actionStatusInitial = ReportStockVariationDetailAction.GetInitialStockStatus(criteria);
            actionListFinal.Add(actionStatusInitial);

            ReportStockVariationDetailAction action = null;
            if (actionListTemp.Count > 0)
            {
                foreach (var obj in actionListTemp)
                {
                    if ((obj.DateExecution.Year != Year) || (obj.DateExecution.Month != Month) || (obj.DateExecution.Day != Day))
                    {
                        if (action != null)
                        {
                            actionListFinal.Add(action);
                            indexAction++;
                        }
                        action = new ReportStockVariationDetailAction();
                        action.DateExecution = obj.DateExecution;
                        action.PackageCountCurrent = actionListFinal[indexAction].PackageCountCurrent;
                        action.WeightGrossCurrent = actionListFinal[indexAction].WeightGrossCurrent;
                        action.WeightNetCurrent = actionListFinal[indexAction].WeightNetCurrent;
                        Year = obj.DateExecution.Year;
                        Month = obj.DateExecution.Month;
                        Day = obj.DateExecution.Day;
                    }

                    action.PackageCountVariationIn += obj.PackageCountVariationIn;
                    action.PackageCountVariationOut += obj.PackageCountVariationOut;
                    action.WeightGrossVariationIn += obj.WeightGrossVariationIn;
                    action.WeightGrossVariationOut += obj.WeightGrossVariationOut;
                    action.WeightNetVariationIn += obj.WeightNetVariationIn;
                    action.WeightNetVariationOut += obj.WeightNetVariationOut;

                    action.PackageCountCurrent += obj.PackageCountVariationIn - obj.PackageCountVariationOut;
                    action.WeightGrossCurrent += obj.WeightGrossVariationIn - obj.WeightGrossVariationOut;
                    action.WeightNetCurrent += obj.WeightNetVariationIn - obj.WeightNetVariationOut;

                    if (obj.PackageCountVariationIn > 0)
                    {
                        action.Receptions.Add(obj.ReceptionDeliveryClientSymbol + obj.ReceptionDeliveryNumber.ToString());
                    }
                    else
                    {
                        action.Deliveries.Add(obj.ReceptionDeliveryClientSymbol + obj.ReceptionDeliveryNumber);
                    }
                }
                actionListFinal.Add(action);
            }

            if (actionListFinal.Count() > 0)
            {
                foreach (var obj in actionListFinal)
                {
                    result.AppendLine("<tr>");
                    result.AppendLine("<td align=\"center\">" + obj.DateExecution.ToString("dd.MM.yyyy") + "</td>");
                    result.AppendLine("<td class=\"in\" align=\"center\">" + (obj.PackageCountVariationIn > 0 ? obj.PackageCountVariationIn.ToString() : "&nbsp;") + "</td>");
                    result.AppendLine("<td class=\"in\" align=\"right\">" + (obj.WeightNetVariationIn > 0 ? (obj.WeightNetVariationIn / 1000.0).ToString("0.0", CultureInfo.InvariantCulture) : "&nbsp;") + "</td>");
                    result.AppendLine("<td class=\"in\" align=\"right\">" + (obj.WeightGrossVariationIn > 0 ? (obj.WeightGrossVariationIn / 1000.0).ToString("0.0", CultureInfo.InvariantCulture) : "&nbsp;") + "</td>");
                    result.AppendLine("<td class=\"out\" align=\"center\">" + (obj.PackageCountVariationOut > 0 ? obj.PackageCountVariationOut.ToString() : "&nbsp;") + "</td>");
                    result.AppendLine("<td class=\"out\" align=\"right\">" + (obj.WeightNetVariationOut > 0 ? (obj.WeightNetVariationOut / 1000.0).ToString("0.0", CultureInfo.InvariantCulture) : "&nbsp;") + "</td>");
                    result.AppendLine("<td class=\"out\" align=\"right\">" + (obj.WeightGrossVariationOut > 0 ? (obj.WeightGrossVariationOut / 1000.0).ToString("0.0", CultureInfo.InvariantCulture) : "&nbsp;") + "</td>");
                    result.AppendLine("<td class=\"current\" align=\"center\">" + obj.PackageCountCurrent.ToString() + "</td>");
                    result.AppendLine("<td class=\"current\" align=\"right\">" + (obj.WeightNetCurrent / 1000.0).ToString("0.0", CultureInfo.InvariantCulture) + "</td>");
                    result.AppendLine("<td class=\"current\" align=\"right\">" + (obj.WeightGrossCurrent / 1000.0).ToString("0.0", CultureInfo.InvariantCulture) + "</td>");
                    result.AppendLine("<td align=\"right\">" + (obj.ReceptionsDeliveriesToString != string.Empty ? obj.ReceptionsDeliveriesToString : "&nbsp;") + "</td>");
                    result.AppendLine("</tr>");
                }

                result.AppendLine("</tbody><tfoot>");

                result.AppendLine("<tr>");
                result.AppendLine("<td align=\"left\"><b>TOTAL</b></td>");
                result.AppendLine("<td class=\"in\" align=\"center\"><b>" + actionListFinal.Sum(o => o.PackageCountVariationIn).ToString() + "</b></td>");
                result.AppendLine("<td class=\"in\" align=\"right\"><b>" + (actionListFinal.Sum(o => o.WeightNetVariationIn) / 1000.0).ToString("0.0", CultureInfo.InvariantCulture) + "</b></td>");
                result.AppendLine("<td class=\"in\" align=\"right\"><b>" + (actionListFinal.Sum(o => o.WeightGrossVariationIn) / 1000.0).ToString("0.0", CultureInfo.InvariantCulture) + "</b></td>");
                result.AppendLine("<td class=\"out\" align=\"center\"><b>" + actionListFinal.Sum(o => o.PackageCountVariationOut).ToString() + "</b></td>");
                result.AppendLine("<td class=\"out\" align=\"right\"><b>" + (actionListFinal.Sum(o => o.WeightNetVariationOut) / 1000.0).ToString("0.0", CultureInfo.InvariantCulture) + "</b></td>");
                result.AppendLine("<td class=\"out\" align=\"right\"><b>" + (actionListFinal.Sum(o => o.WeightGrossVariationOut) / 1000.0).ToString("0.0", CultureInfo.InvariantCulture) + "</b></td>");
                result.AppendLine("<td class=\"current\" align=\"center\">&nbsp;</td>");
                result.AppendLine("<td class=\"current\" align=\"right\">&nbsp;</td>");
                result.AppendLine("<td class=\"current\" align=\"right\">&nbsp;</td>");
                result.AppendLine("<td align=\"right\">&nbsp;</td>");
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
            if (showHTMLFooter)
            {
                result.AppendLine("</body></html>");
            }

            return result.ToString();
        }

        public static void ShowDialog(ReportStockVariationDetailFilterCriteria criteria)
        {
            using (ReportStockVariationDetailFormReport form = new ReportStockVariationDetailFormReport())
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
