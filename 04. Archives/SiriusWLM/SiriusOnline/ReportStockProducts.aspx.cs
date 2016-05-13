using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace Sirius.SiriusOnline
{
    public partial class ReportStockProducts : System.Web.UI.Page
    {
        public new SiteMaster Master
        {
            get { return ((SiteMaster)(base.Master)); }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBoxDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
            }
        }

        protected void ButtonExecute_Click(object sender, EventArgs e)
        {
            DateTime dateExecution = DateTime.Now;
            if (DateTime.TryParseExact(TextBoxDate.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateExecution))
            {
                LiteralReport.Text = EntityModels.Reports.ReportStockProducts.ToHTML(Master.Model, new EntityModels.Reports.ReportStockProductsFilterCriteria { ClientId = Master.LoggedClientUser.Client.Id, DateExecution = dateExecution });
            }
            else
            {
                LiteralMessage.Text = ToolMessage.Render(ToolMessage.Kinds.ERROR, "Incorrect date");
            }
        }
    }
}