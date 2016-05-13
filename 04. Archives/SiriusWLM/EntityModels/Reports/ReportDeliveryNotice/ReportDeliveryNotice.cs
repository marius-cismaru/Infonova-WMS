using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Sirius.EntityModels.Reports
{
    public class ReportDeliveryNotice
    {
        public static string Name = "Aviz de insotire a marfii";
        public static string Title = "Aviz de insotire<br/>a marfii";

        public static string ToHTML(EntityModelSirius model, ReportDeliveryNoticeFilterCriteria criteria)
        {
            StringBuilder result = new StringBuilder();

            EntityModels.Delivery delivery = EntityModels.Deliveries.DeliveryCollection.GetById(model, criteria.DeliveryId, false);
            if (delivery != null)
            {
                result.AppendLine("<html><head>");
                result.AppendLine("<title>" + Name + "</title>");
                result.AppendLine("<style type=\"text/css\">");
                result.AppendLine("body { font-family: Arial, Helvetica, sans-serif; font-size: 12px; }");
                result.AppendLine("table { font-size: 1em; }");
                result.AppendLine("</style>");
                result.AppendLine("</head><body>");
                result.AppendLine("<table width=\"100%\" cellspacing=\"0\" cellpadding=\"0\">");
                result.AppendLine("<tr>");

                result.AppendLine("<td width=\"30%\" valign=\"top\" style=\"font-size: 0.8em\">");
                result.AppendLine("<b>FURNIZOR</b><br/>");
                result.AppendLine(delivery.Client.Company.NameLong + "<br/>");
                result.AppendLine("Nr. Reg. Com.: " + delivery.Client.Company.NumberRegistry + "<br/>");
                result.AppendLine("CIF: " + delivery.Client.Company.NumberFiscal + "<br/>");
                result.AppendLine("Capital Social: " + delivery.Client.Company.CapitalAmount + "<br/>");
                result.AppendLine("Sediul: " + delivery.Client.Company.Country.Name + ", " + delivery.Client.Company.Address + "<br/>");
                result.AppendLine("Telefon: " + delivery.Client.Company.Phone + "<br/>");
                result.AppendLine("Fax: " + delivery.Client.Company.Fax + "<br/>");
                result.AppendLine("Banca: " + delivery.Client.Company.Bank + "<br/>");
                result.AppendLine("IBAN RON: " + delivery.Client.Company.BankAccountRON + "<br/>");
                result.AppendLine("IBAN EUR: " + delivery.Client.Company.BankAccountEUR + "<br/>");
                result.AppendLine("</td>");

                result.AppendLine("<td width=\"*\" align=\"center\">");
                result.AppendLine("<img src=\"data:image/png;base64,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\" alt=\"logo_radan.png\" />");
                result.AppendLine("<h3>" + Title + "</h3>");
                result.AppendLine("<b>Nr.: " + delivery.Number.ToString() + "</b><br/>");
                result.AppendLine("<b>Data: " + delivery.DateCreation.ToString("dd.MM.yyyy") + "</b><br/>");
                result.AppendLine("<b>" + delivery.OrderToString + "</b><br/>");
                result.AppendLine("</td>");

                result.AppendLine("<td width=\"30%\" valign=\"top\" style=\"font-size: 0.8em\">");
                result.AppendLine("<b>CLIENT</b><br/>");
                result.AppendLine(delivery.Client.NameLong + "<br/>");
                result.AppendLine("Nr. Reg. Com.: " + delivery.Client.NumberRegistry + "<br/>");
                result.AppendLine("CIF: " + delivery.Client.NumberFiscal + "<br/>");
                result.AppendLine("Sediul: " + delivery.Client.Country.Name + ", " + delivery.Client.Address + "<br/><br/>");
                result.AppendLine("Destinatie: " + delivery.ClientDestination.Country.Name + ", " + delivery.ClientDestination.Address + "<br/>");
                if (delivery.ClientDestination.Company != null)
                {
                    result.AppendLine(delivery.ClientDestination.Company.ToUpper() + "<br/>");
                }
                result.AppendLine("</td>");

                result.AppendLine("</tr></table>");

                result.AppendLine("<br/><br/><b>NU SE FACTUREAZA</b><br/>");

                result.AppendLine("<br/><br/>");
                result.AppendLine("<table border=\"1\" width=\"100%\" cellspacing=\"0\" cellpadding=\"4\">");
                result.AppendLine("<thead><tr>");
                result.AppendLine("<th>Nr.</th>");
                result.AppendLine("<th>Cod<br/>articol</th>");
                result.AppendLine("<th>Denumire<br/>articol</th>");
                result.AppendLine("<th>UM</th>");
                result.AppendLine("<th>Cantitate</th>");
                result.AppendLine("<th>Greutate<br/>[Kg]</th>");
                result.AppendLine("<th>Nr. paleti</th>");
                result.AppendLine("</tr></thead><tbody>");

                int index = 1;
                var productsList = DeliveryProducts.DeliveryProductCollection.GetCollection(model, new DeliveryProducts.DeliveryProductFilterCriteria { DeliveryId = delivery.Id });
                foreach (var obj in productsList)
                {
                    result.AppendLine("<tr>");
                    result.AppendLine("<td>" + index.ToString() + "</td>");
                    result.AppendLine("<td>" + obj.Product.Code + "</td>");
                    result.AppendLine("<td>" + obj.Product.Name + "</td>");
                    result.AppendLine("<td align=\"center\">" + obj.Product.MeasuringUnit.Name + "</td>");
                    result.AppendLine("<td align=\"right\">" + obj.QuantityDelivery.ToString("0.00", CultureInfo.InvariantCulture) + "</td>");
                    result.AppendLine("<td align=\"right\">" + model.Packages.Where(o => (o.Delivery.Id == delivery.Id) && (o.Product.Id == obj.Product.Id)).Sum(o => o.WeightNet).ToString("0.00", CultureInfo.InvariantCulture) + "</td>");
                    result.AppendLine("<td align=\"right\">" + obj.PackageCount.ToString() + "</td>");
                    result.AppendLine("</tr>");
                    index++;

                    //Adaugare informatii receptie si nr de paleti
                    /*
                    var packagesReceptionList = from o in model.Packages
                                                where (o.Delivery != null) && (o.Delivery.Id == delivery.Id) && (o.Product.Id == obj.Product.Id)
                                                group o by o.Reception into p
                                                select new
                                                {
                                                    ReceptionRef = p.Key,
                                                    PackageCount = p.Count()
                                                };
                    foreach (var reception in packagesReceptionList)
                    {
                        result.AppendLine("<tr>");
                        result.AppendLine("<td colspan=\"7\" align=\"right\" style=\"font-size: 0.9em;\"><i>Receptie " + reception.ReceptionRef.ToString() + "</i></td>");
                        result.AppendLine("<td align=\"right\" style=\"font-size: 0.9em;\"><i>" + reception.PackageCount.ToString() + "</i></td>");
                        result.AppendLine("</tr>");
                    }
                    */
                }

                result.AppendLine("<tr>");
                result.AppendLine("<td colspan=\"5\"><b>TOTAL</b></td>");
                result.AppendLine("<td align=\"right\"><b>" + model.Packages.Where(o => (o.Delivery.Id == delivery.Id)).Sum(o => o.WeightNet).ToString("0.00", CultureInfo.InvariantCulture) + "</b></td>");
                result.AppendLine("<td align=\"right\"><b>" + model.Packages.Where(o => (o.Delivery.Id == delivery.Id)).Count().ToString() + "</b></td>");
                result.AppendLine("</tr>");

                result.AppendLine("</tbody></table>");

                result.AppendLine("<h4>Sigiliu: " + delivery.Seal.ToUpper() + "</h4>");

                result.AppendLine("<table border=\"1\" width=\"100%\" cellspacing=\"0\" cellpadding=\"10\">");

                result.AppendLine("<tr><td width=\"35%\" valign=\"top\">");
                result.AppendLine("<b>Semnatura si stampila furnizorului</b><br/>");
                result.AppendLine("<b>Nume:</b> " + delivery.User.Name.ToUpper() + "<br/>");
                result.AppendLine("<b>CNP:</b> " + delivery.User.NumberPersonal + "<br/>");
                result.AppendLine("<b>CI:</b> " + delivery.User.NumberID + "<br/>");
                result.AppendLine("</td>");

                result.AppendLine("<td width=\"45%\" valign=\"top\">");
                result.AppendLine("<b>Date privind expeditia</b><br/>");
                result.AppendLine("<b>Nume delegat:</b> " + delivery.RepresentativeName.ToUpper() + "<br/>");
                result.AppendLine("<b>CI:</b> " + delivery.RepresentativeID + "<br/>");
                result.AppendLine("<b>Transport:</b> " + delivery.Conveyance + "<br/>");
                result.AppendLine("<b>Expeditia s-a facut in prezenta noastra la data " + delivery.DateCreation.ToString("dd.MM.yyyy") + ", ora " + delivery.DateCreation.ToString("HH:mm") + "</b><br/>");
                result.AppendLine("</td>");

                result.AppendLine("<td width=\"*\" align=\"center\" valign=\"top\">");
                result.AppendLine("<b><u>Semnaturile</u></b><br/>");
                result.AppendLine("</td>");

                result.AppendLine("</tr></table>");

                result.AppendLine("<br/><br/>");
                result.AppendLine(delivery.Comment.Trim() != string.Empty ? ("<h4>Observatii:  " + delivery.Comment.Trim() + "</h4>") : string.Empty);
                result.AppendLine("</body></html>");
            }

            return result.ToString();
        }

        public static void ShowDialog(ReportDeliveryNoticeFilterCriteria criteria)
        {
            using (ReportDeliveryNoticeFormReport form = new ReportDeliveryNoticeFormReport())
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
