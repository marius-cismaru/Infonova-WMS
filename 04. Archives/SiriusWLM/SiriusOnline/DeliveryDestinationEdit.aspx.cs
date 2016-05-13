using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace Sirius.SiriusOnline
{
    public partial class DeliveryDestinationEdit : System.Web.UI.Page
    {
        int destinationId = 0;

        public new SiteMaster Master
        {
            get { return ((SiteMaster)(base.Master)); }
        }

        private int GetIdFromQuery()
        {
            int result = 0;
            if (Request.QueryString["id"] != null)
            {
                int.TryParse(Request.QueryString["id"], out result);
            }
            return result;
        }

        private bool CheckIfClientOwnsDestination()
        {
            return ((destinationId == 0) || (Master.LoggedClientUser.Client.ClientDestinations.Any(o => o.Id == destinationId)));
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            destinationId = GetIdFromQuery();

            if (!CheckIfClientOwnsDestination()) Response.Redirect("~/DeliveryDestinationsBrowse.aspx");

            if (!IsPostBack)
            {
                var destination = Master.Model.ClientDestinations.FirstOrDefault(o => o.Id == destinationId);
                if (destination == null)
                {
                    destination = new EntityModels.ClientDestination();
                    LiteralTitle.Text = "Adaugare";
                }
                else
                {
                    LiteralTitle.Text = "Editare";
                }

                LiteralTitle.Text += " destinatie livrare";

                TextBoxName.Text = destination.Name;
                TextBoxAddress.Text = destination.Address;
                TextBoxCompany.Text = destination.Company;
                DropDownListCountry.Items.AddRange(Master.Model.Countries.ToList().Select(o => new ListItem { Text = o.Name, Value = o.Id.ToString() }).ToArray());
                if (destination.Country != null) DropDownListCountry.SelectedValue = destination.Country.Id.ToString();
            }
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxName.Text.Trim()))
            {
                LiteralMessage.Text = ToolMessage.Render(ToolMessage.Kinds.ERROR, "Denumirea destinatiei trebuie completata");
            }
            else
            {
                var destination = Master.Model.ClientDestinations.FirstOrDefault(o => o.Id == destinationId);
                if (destination == null)
                {
                    destination = new EntityModels.ClientDestination();
                    destination.Client = Master.LoggedClientUser.Client;
                }

                int countryId = Master.Model.Countries.FirstOrDefault().Id;
                int.TryParse(DropDownListCountry.SelectedValue, out countryId);
                destination.Country = Master.Model.Countries.FirstOrDefault(o => o.Id == countryId);

                destination.Name = TextBoxName.Text.Trim();
                destination.Address = TextBoxAddress.Text.Trim();
                destination.Company = TextBoxCompany.Text.Trim();
                Master.Model.SaveChanges();
                Response.Redirect("~/DeliveryDestinationsBrowse.aspx");
            }
        }
    }
}