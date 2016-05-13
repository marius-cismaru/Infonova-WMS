using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Sirius.EntityModels.Reports
{
    public class ReportDeliveryPickingList
    {
        public static string Name = "Lista culegere paleti livrare";
        public static string Title = Name;

        public static string ToHTML(ReportDeliveryPickingListFilterCriteria criteria)
        {
            StringBuilder result = new StringBuilder();

            if (criteria.Delivery != null)
            {
                result.AppendLine("<html><head>");
                result.AppendLine("<title>" + Name + "</title>");
                result.AppendLine("<style type=\"text/css\">");
                result.AppendLine("body { font-family: Arial, Helvetica, sans-serif; font-size: 12px; }");
                result.AppendLine("table { font-size: 1em; }");
                result.AppendLine("</style>");
                result.AppendLine("</head><body>");
                result.AppendLine("<h1>" + Name + "</h1>");
                result.AppendLine("<h3>" + criteria.ToString() + "</h3>");
                //result.AppendLine("Data executare raport: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "<br/><br/><br/>");
                //result.AppendLine("<h2>Paleti</h2>");
                result.AppendLine("<table border=\"1\" width=\"100%\" cellspacing=\"0\" cellpadding=\"2\">");
                result.AppendLine("<thead><tr>");
                result.AppendLine("<th>Nr.</th>");
                result.AppendLine("<th>Cod<br/>pachet</th>");
                result.AppendLine("<th>Container</th>");
                result.AppendLine("<th>Cantitate</th>");
                result.AppendLine("<th>Greutate neta<br/>[Kg]</th>");
                result.AppendLine("<th>Greutate bruta<br/>[Kg]</th>");
                result.AppendLine("</tr></thead><tbody>");

                var products = from o in criteria.PackageList
                               group o by o.Product into p
                               orderby p.Key.Code
                               select new
                               {
                                   Product = p.Key,
                                   WeightNet = p.Sum(q => q.WeightNet),
                                   WeightGross = p.Sum(q => q.WeightGross)
                               };
                
                int index = 1;
                if (products.Count() > 0)
                {
                    foreach (var prod in products)
                    {
                        result.AppendLine("<tr>");
                        result.AppendLine("<td colspan=\"4\"><b>" + prod.Product.ToString() + "</b></td>");
                        result.AppendLine("<td align=\"right\"><b>" + prod.WeightNet.ToString("0.00", CultureInfo.InvariantCulture) + "</b></td>");
                        result.AppendLine("<td align=\"right\"><b>" + prod.WeightGross.ToString("0.00", CultureInfo.InvariantCulture) + "</b></td>");
                        result.AppendLine("</tr>");

                        var packages = from p in criteria.PackageList
                                       where p.Product.Id == prod.Product.Id
                                       orderby p.WarehouseContainer.Name
                                       select p;
                        if (packages.Count() > 0)
                        {

                            foreach (var obj in packages)
                            {
                                result.AppendLine("<tr>");
                                result.AppendLine("<td align=\"center\">" + index.ToString() + "</td>");
                                result.AppendLine("<td align=\"center\">" + obj.Code + "</td>");
                                result.AppendLine("<td align=\"center\">" + obj.WarehouseContainer.Name + "</td>");
                                result.AppendLine("<td align=\"right\">" + obj.Quantity.ToString("0.00", CultureInfo.InvariantCulture) + "</td>");
                                result.AppendLine("<td align=\"right\">" + obj.WeightNet.ToString("0.00", CultureInfo.InvariantCulture) + "</td>");
                                result.AppendLine("<td align=\"right\">" + obj.WeightGross.ToString("0.00", CultureInfo.InvariantCulture) + "</td>");
                                result.AppendLine("</tr>");
                                index++;
                            }
                        }
                        else
                        {
                            result.AppendLine("<tr><td colspan=\"6\"><b>Nu exista pachete selectate</b></td></tr>");
                        }
                    }
                }
                result.AppendLine("<tfoot><tr>");
                result.AppendLine("<td colspan=\"4\"><b>TOTAL</b></td>");
                result.AppendLine("<td align=\"right\"><b>" + criteria.PackageList.Sum(o => o.WeightNet).ToString("0.00", CultureInfo.InvariantCulture) + "</b></td>");
                result.AppendLine("<td align=\"right\"><b>" + criteria.PackageList.Sum(o => o.WeightGross).ToString("0.00", CultureInfo.InvariantCulture) + "</b></td>");
                result.AppendLine("</tr></tfoot>");
                result.AppendLine("</tbody></table>");

                result.AppendLine("</body></html>");
            }

            return result.ToString();
        }

        public static void ShowDialog(ReportDeliveryPickingListFilterCriteria criteria)
        {
            using (ReportDeliveryPickingListFormReport form = new ReportDeliveryPickingListFormReport())
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
