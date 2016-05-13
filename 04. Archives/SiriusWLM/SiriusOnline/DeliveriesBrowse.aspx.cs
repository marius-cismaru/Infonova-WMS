using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace Sirius.SiriusOnline
{
    public partial class DeliveriesBrowse : System.Web.UI.Page
    {
        public new SiteMaster Master
        {
            get { return ((SiteMaster)(base.Master)); }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBoxDateFrom.Text = DateTime.Now.AddDays(-7).ToString("dd.MM.yyyy");
                TextBoxDateTo.Text = DateTime.Now.ToString("dd.MM.yyyy");
            }
        }

        protected void ButtonShow_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = DateTime.Now.AddMonths(-1);
            DateTime dateTo = DateTime.Now;

            if (DateTime.TryParseExact(TextBoxDateFrom.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateFrom))
            {
                if (DateTime.TryParseExact(TextBoxDateTo.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTo))
                {
                    LiteralReport.Text = EntityModels.Reports.ReportDeliveries.ToHTML(Master.Model, new EntityModels.Reports.ReportDeliveriesFilterCriteria { ClientId = Master.LoggedClientUser.Client.Id, DateExecutionBegin = dateFrom, DateExecutionEnd = dateTo }, false);
                }
                else
                {
                    LiteralMessage.Text = ToolMessage.Render(ToolMessage.Kinds.ERROR, "Incorrect date to");
                }
            }
            else
            {
                LiteralMessage.Text = ToolMessage.Render(ToolMessage.Kinds.ERROR, "Incorrect date from");
            }
        }
    }
}