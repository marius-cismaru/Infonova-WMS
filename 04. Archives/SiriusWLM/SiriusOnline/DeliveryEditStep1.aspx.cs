using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace Sirius.SiriusOnline
{
    public partial class DeliveryEditStep1 : System.Web.UI.Page
    {
        EntityModels.HelperDelivery DeliveryFromSession;

        public new SiteMaster Master
        {
            get { return ((SiteMaster)(base.Master)); }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            DeliveryFromSession = Master.GetDeliveryFromSession();
            //If current wizard step not 1, jump to current step
            if (DeliveryFromSession.StepCurrent != 1)
            {
                Response.Redirect("~/DeliveryEditStep" + DeliveryFromSession.StepCurrent.ToString() + ".aspx");
            }

            if (!IsPostBack)
            {
                DropDownListWarehouse.Items.AddRange(Master.Model.Warehouses.ToList().Select(o => new ListItem { Text = (o.Name + " (" + o.Description + ")"), Value = o.Id.ToString() }).ToArray());
                if (DeliveryFromSession.Warehouse_Id != 0) DropDownListWarehouse.SelectedValue = DeliveryFromSession.Warehouse_Id.ToString();

                DropDownListClientDestination.Items.AddRange(Master.LoggedClientUser.Client.ClientDestinations.OrderBy(o => o.Name).ToList().Select(o => new ListItem { Text = (o.Name + " (" + o.Company + ")"), Value = o.Id.ToString() }).ToArray());
                if (DeliveryFromSession.ClientDestination_Id != 0) DropDownListClientDestination.SelectedValue = DeliveryFromSession.ClientDestination_Id.ToString();
            }
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Master.ClearDeliverySession();
            Response.Redirect("~/Default.aspx");
        }

        protected void ButtonNext_Click(object sender, EventArgs e)
        {
            int id = 1;
            int.TryParse(DropDownListWarehouse.SelectedValue, out id);
            DeliveryFromSession.Warehouse_Id = id;

            int.TryParse(DropDownListClientDestination.SelectedValue, out id);
            DeliveryFromSession.ClientDestination_Id = id;
            DeliveryFromSession.StepCurrent = 2;

            Master.SaveDeliveryToSession(DeliveryFromSession);

            Response.Redirect("~/DeliveryEditStep2.aspx");
        }
    }
}