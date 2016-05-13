using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using System.Text;

namespace Sirius.SiriusOnline
{
    public partial class DeliveryDestinationsBrowse : System.Web.UI.Page
    {
        public new SiteMaster Master
        {
            get { return ((SiteMaster)(base.Master)); }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var destinations = Master.Model.ClientDestinations.Where(o => o.Client.Id == Master.LoggedClientUser.Client.Id).OrderBy(o => o.Name).ToList();

                TableRow row;
                TableCell cell;

                foreach (var obj in destinations)
                {
                    row = new TableRow();

                    cell = new TableCell { Text = obj.Name };
                    row.Cells.Add(cell);
                    cell = new TableCell { Text = obj.Country.Name };
                    row.Cells.Add(cell);
                    cell = new TableCell { Text = obj.Company };
                    row.Cells.Add(cell);
                    cell = new TableCell { Text = obj.Address };
                    row.Cells.Add(cell);
                    cell = new TableCell { Text = obj.Deliveries.Count.ToString() };
                    row.Cells.Add(cell);
                    cell = new TableCell();
                    Button button = new Button();
                    button.Text = "Editare";
                    button.PostBackUrl = "~/DeliveryDestinationEdit.aspx?id=" + obj.Id.ToString();
                    cell.Controls.Add(button);
                    row.Cells.Add(cell);

                    TableDestinations.Rows.Add(row);
                }
            }
        }
    }
}