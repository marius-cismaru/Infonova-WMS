using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Infonova.ManagementWeb2
{
    public partial class ArticleCategories : System.Web.UI.Page
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
            sb.AppendLine("<td>Denumire</td>");
            sb.AppendLine("<td>Descriere</td>");
            sb.AppendLine("<td>Grupa TVA</td>");
            sb.AppendLine("</tr>");
            sb.AppendLine("</thead><tbody>");
            foreach (var item in Master.Model.ArticleCategories.OrderBy(o => o.Code))
            {
                sb.AppendLine("<tr>");
                sb.AppendLine("<td align=\"center\">" + item.Code + "</td>");
                sb.AppendLine("<td align=\"left\">" + item.Name + "</td>");
                sb.AppendLine("<td align=\"left\">" + item.Description + "</td>");
                sb.AppendLine("<td align=\"center\">" + item.VAT.NameFriendly + "</td>");
                sb.AppendLine("</tr>");
            }
            sb.AppendLine("</tbody></table>");

            literalTable.Text = sb.ToString();

            if (!IsPostBack)
            {
                dropDownListVAT.Items.AddRange(Master.Model.VATs.Select(o => new ListItem { Text = o.NameFriendly, Value = o.Id.ToString() }).ToArray());
            }
        }

        protected void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxCode.Text.Trim() == "" || textBoxName.Text.Trim() == "")
            {
                literalMessage.Text = ToolMessage.Render(ToolMessage.Kinds.ERROR, "Trebuie introdus Cod si Denumire");
            }
            else
            {
                Master.Model.ArticleCategories.Add(new Infonova.Data.Models.Infonova.ArticleCategory
                {
                    Code = textBoxCode.Text.Trim(),
                    Description = textBoxDescription.Text,
                    Name = textBoxName.Text.Trim(),
                    VATId = int.Parse(dropDownListVAT.SelectedValue)
                });
                Master.Model.SaveChanges();
                literalMessage.Text = ToolMessage.Render(ToolMessage.Kinds.SUCCESS, "O noua categorie a fost adaugate");
            }
        }
    }
}