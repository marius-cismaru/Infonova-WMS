using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Infonova.ManagementWeb2
{
    public partial class Articles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<table border=\"1\">");
            sb.AppendLine("<thead>");
            sb.AppendLine("<tr>");
            sb.AppendLine("<td>Cod</td>");
            sb.AppendLine("<td>Denumire completa</td>");
            sb.AppendLine("<td>Denumire furnizor</td>");
            sb.AppendLine("<td>Denumire ce va aparea pe factura</td>");
            sb.AppendLine("<td>E calibrat?</td>");
            sb.AppendLine("<td>Factor unitate - greutate</td>");
            sb.AppendLine("<td>Sub grup</td>");
            sb.AppendLine("</tr>");
            sb.AppendLine("</thead><tbody>");
            foreach (var item in Master.Model.Articles.OrderBy(o => o.Code))
            {
                sb.AppendLine("<tr>");
                sb.AppendLine("<td align=\"center\">" + item.Code + "</td>");
                sb.AppendLine("<td align=\"left\">" + item.NameFull + "</td>");
                sb.AppendLine("<td align=\"left\">" + item.NameFromSupplier + "</td>");
                sb.AppendLine("<td align=\"left\">" + item.NameInvoice + "</td>");
                sb.AppendLine("<td align=\"center\">" + (item.IsCalibrated ? "Da" : "Nu") + "</td>");
                sb.AppendLine("<td align=\"right\">" + item.UnitWeightFactor.ToString() + "</td>");
                sb.AppendLine("<td align=\"left\">" + item.ArticleSubGroup.ArticleGroup.ArticleCategory.Name + " - " + item.ArticleSubGroup.ArticleGroup.Name + " - " + item.ArticleSubGroup.Name + "</td>");
                sb.AppendLine("</tr>");
            }
            sb.AppendLine("</tbody></table>");

            literalTable.Text = sb.ToString();

            if (!IsPostBack)
            {
                dropDownListSubGroup.Items.AddRange(Master.Model.ArticleSubGroups.Select(o => new ListItem { Text = (o.ArticleGroup.ArticleCategory.Name + " - " + o.ArticleGroup.Name + " - " + o.Name), Value = o.Id.ToString() }).ToArray());
            }
        }

        protected void buttonSave_Click(object sender, EventArgs e)
        {
            double value = 1;
            if (textBoxCode.Text.Trim() == "" || textBoxNameFull.Text.Trim() == "" || !double.TryParse(textBoxUnitWeightFactor.Text, out value))
            {
                literalMessage.Text = ToolMessage.Render(ToolMessage.Kinds.ERROR, "Trebuie introdus Cod, Denumira completa si Factor unitate - greutate corect (cu . la zecimale)");
            }
            else
            {
                Master.Model.Articles.Add(new Infonova.Data.Models.Infonova.Article
                {
                    Code = textBoxCode.Text.Trim(),
                    ArticleSubGroupId = int.Parse(dropDownListSubGroup.SelectedValue),
                    IsCalibrated = checkBoxIsCalibrated.Checked,
                    IsForbiddenUnityPurchase = false,
                    IsForbiddenUnitySale = false,
                    NameFromSupplier = textBoxNameFromSupplier.Text,
                    NameFull = textBoxNameFull.Text,
                    NameInvoice = textBoxNameInvoice.Text,
                    UnitWeightFactor = double.Parse(textBoxUnitWeightFactor.Text, System.Globalization.NumberStyles.Number, CultureInfo.InvariantCulture)
                });
                Master.Model.SaveChanges();
                literalMessage.Text = ToolMessage.Render(ToolMessage.Kinds.SUCCESS, "Un nou articol a fost adaugat");
            }
        }
    }
}