using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Sirius.EntityModels.Reports
{
    public class ReportReceptionNote
    {
        public static string Name = "Nota de receptie";
        public static string Title = Name;

        public static string ToHTML(EntityModelSirius model, ReportReceptionNoteFilterCriteria criteria)
        {
            StringBuilder result = new StringBuilder();

            EntityModels.Reception reception = EntityModels.Receptions.ReceptionCollection.GetById(model, criteria.ReceptionId, false);
            if (reception != null)
            {
                result.AppendLine("<html><head>");
                result.AppendLine("<title>" + Name + "</title>");
                result.AppendLine("<style type=\"text/css\">");
                result.AppendLine("body { font-family: Arial, Helvetica, sans-serif; font-size: 14px; }");
                result.AppendLine("table { font-size: 1em; }");
                result.AppendLine("h1 { font-size: 2em; }");
                result.AppendLine("h2 { font-size: 1.7em; }");
                result.AppendLine("h3 { font-size: 1.2em; margin-bottom: 6px;}");
                result.AppendLine("</style>");
                result.AppendLine("</head><body>");
                result.AppendLine("<h1>" + reception.Client.Company.NameLong + "</h1>");
                result.AppendLine("<h2>Nota de Receptie si constatare diferente</h2>");
                result.AppendLine("<table border=\"0\" cellspacing=\"0\" cellpadding=\"4\">");
                result.AppendLine("<tr><td align=\"left\"><b>Receptie:</b></td><td>" + reception.ToString() + "</td></tr>");
                result.AppendLine("<tr><td align=\"left\"><b>Client:</b></td><td>" + reception.Client.NameLong + "</td></tr>");
                result.AppendLine("<tr><td align=\"left\"><b>Document client:</b></td><td>" + reception.OrderToString + "</td></tr>");
                result.AppendLine("<tr><td align=\"left\"><b>Depozit:</b></td><td>" + reception.Warehouse.ToString() + "</td></tr>");
                result.AppendLine("</table>");
                result.AppendLine("<h3>Produse receptionate</h3>");
                result.AppendLine("<table border=\"1\" width=\"100%\" cellspacing=\"0\" cellpadding=\"6\">");
                result.AppendLine("<thead><tr>");
                result.AppendLine("<th>Nr.</th>");
                result.AppendLine("<th>Cod<br/>articol</th>");
                result.AppendLine("<th>Denumire<br/>articol</th>");
                result.AppendLine("<th>UM</th>");
                result.AppendLine("<th>Cantitate<br/>document<br/>client</th>");
                result.AppendLine("<th>Cantitate<br/>receptionata</th>");
                result.AppendLine("<th>Cantitate<br/>diferenta</th>");
                result.AppendLine("<th>Calitate</th>");
                result.AppendLine("<th>Origine</th>");
                result.AppendLine("<th>Temperatura<br/>[°C]</th>");
                result.AppendLine("<th>Nr. paleti</th>");
                result.AppendLine("<th>Observatii</th>");
                result.AppendLine("</tr></thead><tbody>");

                var products = from p in model.ReceptionProducts
                               where p.Reception.Id == reception.Id
                               select p;
                int index = 1;
                foreach (var obj in products)
                {
                    result.AppendLine("<tr>");
                    result.AppendLine("<td align=\"center\">" + index.ToString() + "</td>");
                    result.AppendLine("<td align=\"center\">" + obj.Product.Code + "</td>");
                    result.AppendLine("<td align=\"left\">" + obj.Product.Name + "</td>");
                    result.AppendLine("<td align=\"center\">" + obj.Product.MeasuringUnit.Name + "</td>");
                    result.AppendLine("<td align=\"right\">" + obj.QuantityOrder.ToString("0.00", CultureInfo.InvariantCulture) + "</td>");
                    result.AppendLine("<td align=\"right\">" + obj.QuantityReception.ToString("0.00", CultureInfo.InvariantCulture) + "</td>");
                    result.AppendLine("<td align=\"right\">" + (obj.QuantityDifference).ToString("0.00", CultureInfo.InvariantCulture) + "</td>");
                    result.AppendLine("<td align=\"center\">" + (obj.IsQualityOK ? "CORESP." : "NECORESP.") + "</td>");
                    result.AppendLine("<td align=\"left\">" + obj.Origin + "</td>");
                    result.AppendLine("<td align=\"right\">" + obj.Temperature.ToString() + "</td>");
                    result.AppendLine("<td align=\"center\">" + obj.PackageCount.ToString() + "</td>");
                    result.AppendLine("<td align=\"left\">" + (obj.Observation.Trim() != string.Empty ? obj.Observation : "&nbsp;") + "</td>");
                    result.AppendLine("</tr>");
                    index++;
                }
                result.AppendLine("</tbody></table>");
                result.AppendLine("<br/>");
                result.AppendLine("<h3>Comisia de receptie</h3>");
                result.AppendLine("<table border=\"1\" width=\"100%\" cellspacing=\"0\" cellpadding=\"6\">");
                result.AppendLine("<tbody>");
                result.AppendLine("<tr valign=\"top\">");
                result.AppendLine("<td width=\"35%\" align=\"left\">");
                result.AppendLine("<b>Reprezentant " + reception.Client.Company.ToString().ToUpper() + "</b><br/>" + reception.User.Name.ToUpper() + "<br/>CI: " + reception.User.NumberID.ToUpper());
                result.AppendLine("</td>");
                result.AppendLine("<td width=\"35%\" align=\"left\">");
                result.AppendLine("<b>Reprezentant " + reception.Client.ToString().ToUpper() + "</b><br/>" + reception.RepresentativeName.ToUpper() + "<br/>CI: " + reception.RepresentativeID.ToUpper() + "<br/>Transport: " + reception.Conveyance + "<br/>&nbsp;");
                result.AppendLine("</td>");
                result.AppendLine("<td width=\"*\" align=\"center\" valign=\"top\">");
                result.AppendLine("<b><u>Semnaturile</u></b><br/>");
                result.AppendLine("</td>");
                result.AppendLine("</tr>");
                result.AppendLine("</tbody></table>");
                result.AppendLine("</body></html>");
            }

            return result.ToString();
        }

        public static void ShowDialog(ReportReceptionNoteFilterCriteria criteria)
        {
            using (ReportReceptionNoteFormReport form = new ReportReceptionNoteFormReport())
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
