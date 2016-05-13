using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace Sirius.SiriusOnline
{
    public partial class DeliveryEditStep2 : System.Web.UI.Page
    {
        EntityModels.HelperDelivery DeliveryFromSession;

        public new SiteMaster Master
        {
            get { return ((SiteMaster)(base.Master)); }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            DeliveryFromSession = Master.GetDeliveryFromSession();
            //If current wizard step not 2, jump to current step
            if (DeliveryFromSession.StepCurrent != 2)
            {
                Response.Redirect("~/DeliveryEditStep" + DeliveryFromSession.StepCurrent.ToString() + ".aspx");
            }

            if (!IsPostBack)
            {
                DropDownListOrderType.Items.AddRange(Enum.GetValues(typeof(EntityModels.Delivery.OptionsOrderType)).Cast<EntityModels.Delivery.OptionsOrderType>().ToList().Select(o => new ListItem { Text = CommonLibs.EnumsLib.GetDescription(o), Value = ((int)o).ToString() }).ToArray());
                if (DeliveryFromSession.OrderType != 0) DropDownListOrderType.SelectedValue = DeliveryFromSession.OrderType.ToString();

                TextBoxOrderDate.Text = DeliveryFromSession.OrderDate.ToString("dd.MM.yyyy");
            }
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Master.ClearDeliverySession();
            Response.Redirect("~/Default.aspx");
        }

        protected void ButtonPrevious_Click(object sender, EventArgs e)
        {
            DeliveryFromSession.StepCurrent = 1;
            Master.SaveDeliveryToSession(DeliveryFromSession);

            Response.Redirect("~/DeliveryEditStep1.aspx");
        }

        protected void ButtonNext_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;

            if (!DateTime.TryParseExact(TextBoxOrderDate.Text.Trim(), "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                LiteralMessage.Text = ToolMessage.Render(ToolMessage.Kinds.ERROR, "Data comanda incorecta");
            }
            else
            {
                int id = 1;
                int.TryParse(DropDownListOrderType.SelectedValue, out id);
                DeliveryFromSession.OrderType = id;
                DeliveryFromSession.OrderNumber = TextBoxOrderNumber.Text.Trim();
                DeliveryFromSession.OrderDate = date;
                DeliveryFromSession.StepCurrent = 3;

                Master.SaveDeliveryToSession(DeliveryFromSession);

                Response.Redirect("~/DeliveryEditStep3.aspx");
            }
        }
    }
}