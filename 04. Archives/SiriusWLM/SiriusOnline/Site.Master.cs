using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Sirius.SiriusOnline
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        public EntityModels.EntityModelSirius Model { get; set; }
        public bool IsLoggedClientUser { get; set; }
        public EntityModels.ClientUser LoggedClientUser { get; set; }

        private void AuthenticateClientUser()
        {
            IsLoggedClientUser = false;
            LoggedClientUser = null;

            FormsAuthenticationTicket tkt;
            string cookiestr;
            HttpCookie ck;
            ck = Request.Cookies[FormsAuthentication.FormsCookieName];
            if (ck != null)
            {
                cookiestr = ck.Value;
                tkt = FormsAuthentication.Decrypt(cookiestr);
                int userid;
                if (int.TryParse(tkt.UserData, out userid))
                {
                    if (userid > 0)
                    {
                        LoggedClientUser = Model.ClientUsers.FirstOrDefault(o => o.Id == userid);
                        if (LoggedClientUser != null)
                        {
                            IsLoggedClientUser = true;
                        }
                    }
                }
            }
        }

        public EntityModels.HelperDelivery GetDeliveryFromSession()
        {
            var delivery = HttpContext.Current.Session["Delivery"] as EntityModels.HelperDelivery;
            if (delivery == null)
            {
                delivery = new EntityModels.HelperDelivery();
                delivery.Client_Id = LoggedClientUser.Client.Id;
                HttpContext.Current.Session["Delivery"] = delivery;
            }
            return delivery;
        }

        public void SaveDeliveryToSession(EntityModels.HelperDelivery delivery)
        {
            HttpContext.Current.Session["Delivery"] = delivery;
        }

        public void ClearDeliverySession()
        {
            HttpContext.Current.Session["Delivery"] = null;
        }

        private void PopulateNavigationMenu()
        {
            MenuItem itemParent, itemChild;

            itemParent = new MenuItem();
            itemParent.Text = "Home";
            itemParent.NavigateUrl = "~/Default.aspx";
            NavigationMenu.Items.Add(itemParent);

            itemParent = new MenuItem();
            itemParent.Text = "Reports";
            itemChild = new MenuItem();
            itemChild.Text = "Stock Products";
            itemChild.NavigateUrl = "~/ReportStockProducts.aspx";
            itemParent.ChildItems.Add(itemChild);
            itemChild = new MenuItem();
            itemChild.Text = "Stock Packages";
            itemChild.NavigateUrl = "~/ReportStockPackages.aspx";
            itemParent.ChildItems.Add(itemChild);
            NavigationMenu.Items.Add(itemParent);

            if (LoggedClientUser.Client.IsAllowOnlineDeliveries)
            {
                itemParent = new MenuItem();
                itemParent.Text = "Deliveries";
                itemChild = new MenuItem();
                itemChild.Text = "Destinations";
                itemChild.NavigateUrl = "~/DeliveryDestinationsBrowse.aspx";
                itemParent.ChildItems.Add(itemChild);
                itemChild = new MenuItem();
                itemChild.Text = "Browse deliveries";
                itemChild.NavigateUrl = "~/DeliveriesBrowse.aspx";
                itemParent.ChildItems.Add(itemChild);
                itemChild = new MenuItem();
                itemChild.Text = "Add new delivery";
                itemChild.NavigateUrl = "~/DeliveryEditStep1.aspx";
                itemParent.ChildItems.Add(itemChild);
                NavigationMenu.Items.Add(itemParent);
            }

            itemParent = new MenuItem();
            itemParent.Text = "Admin";
            itemChild = new MenuItem();
            itemChild.Text = "Change password";
            itemChild.NavigateUrl = "~/AdminChangePassword.aspx";
            itemParent.ChildItems.Add(itemChild);
            NavigationMenu.Items.Add(itemParent);

            itemParent = new MenuItem();
            itemParent.Text = "About";
            itemParent.NavigateUrl = "~/About.aspx";
            NavigationMenu.Items.Add(itemParent);
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Model = new EntityModels.EntityModelSirius(Global.SQLConnectionString);
            AuthenticateClientUser();
            if (IsLoggedClientUser)
            {
                PopulateNavigationMenu();
            }
            else
            {
                NavigationMenu.Visible = false;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}
