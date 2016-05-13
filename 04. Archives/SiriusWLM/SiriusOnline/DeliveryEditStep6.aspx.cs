using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace Sirius.SiriusOnline
{
    public partial class DeliveryEditStep6 : System.Web.UI.Page
    {
        EntityModels.HelperDelivery DeliveryFromSession;

        public new SiteMaster Master
        {
            get { return ((SiteMaster)(base.Master)); }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            DeliveryFromSession = Master.GetDeliveryFromSession();
            //If current wizard step not 6, jump to current step
            if (DeliveryFromSession.StepCurrent != 6)
            {
                Response.Redirect("~/DeliveryEditStep" + DeliveryFromSession.StepCurrent.ToString() + ".aspx");
            }

            if (!IsPostBack)
            {
                TextBoxComment.Text = DeliveryFromSession.Comment;
                TextBoxConveyance.Text = DeliveryFromSession.Conveyance;
                TextBoxRepresentativeID.Text = DeliveryFromSession.RepresentativeID;
                TextBoxRepresentativeName.Text = DeliveryFromSession.RepresentativeName;
                TextBoxSeal.Text = DeliveryFromSession.Seal;
            }
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Master.ClearDeliverySession();
            Response.Redirect("~/Default.aspx");
        }

        protected void ButtonPrevious_Click(object sender, EventArgs e)
        {
            DeliveryFromSession.StepCurrent = 5;
            Master.SaveDeliveryToSession(DeliveryFromSession);

            Response.Redirect("~/DeliveryEditStep5.aspx");
        }

        protected void ButtonNext_Click(object sender, EventArgs e)
        {

            DeliveryFromSession.Comment = TextBoxComment.Text.Trim();
            DeliveryFromSession.Conveyance = TextBoxConveyance.Text.Trim();
            DeliveryFromSession.RepresentativeID = TextBoxRepresentativeID.Text.Trim();
            DeliveryFromSession.RepresentativeName = TextBoxRepresentativeName.Text.Trim();

            Master.SaveDeliveryToSession(DeliveryFromSession);

            //Add delivery;
            var warehouse = Master.Model.Warehouses.FirstOrDefault(o => o.Id == DeliveryFromSession.Warehouse_Id);
            var user = Master.Model.Users.FirstOrDefault(o => o.Id == DeliveryFromSession.User_Id);
            var clientDestination = Master.Model.ClientDestinations.FirstOrDefault(o => o.Id == DeliveryFromSession.ClientDestination_Id);

            var delivery = new EntityModels.Delivery();
            delivery.Client = Master.LoggedClientUser.Client;
            delivery.ClientDestination = clientDestination;
            delivery.Warehouse = warehouse;
            delivery.User = user;

            var deliveryNumber = Master.Model.Deliveries.Max(o => o.Number) + 1;

            delivery.Comment = DeliveryFromSession.Comment;
            delivery.Conveyance = DeliveryFromSession.Conveyance;
            delivery.DateCreation = DeliveryFromSession.DateCreation;
            delivery.OrderDate = DeliveryFromSession.OrderDate;
            delivery.OrderNumber = DeliveryFromSession.OrderNumber;
            delivery.OrderType = DeliveryFromSession.OrderType;
            delivery.RepresentativeID = DeliveryFromSession.RepresentativeID;
            delivery.RepresentativeName = DeliveryFromSession.RepresentativeName;
            delivery.Seal = DeliveryFromSession.Seal;

            //Add order products and packages
            EntityModels.DeliveryOrderProduct productNew;
            EntityModels.Package packageNew;

            foreach (var orderProduct in DeliveryFromSession.DeliveryOrderProducts)
            {
                var productFromBD = Master.Model.Products.FirstOrDefault(o => o.Id == orderProduct.Product_Id);

                if (productFromBD != null)
                {
                    productNew = new EntityModels.DeliveryOrderProduct();
                    productNew.Delivery = delivery;
                    productNew.Product = productFromBD;
                    productNew.Quantity = orderProduct.Quantity;
                    productNew.WeightNet = orderProduct.WeightNet;
                    Master.Model.DeliveryOrderProducts.AddObject(productNew);
                }

                foreach (var package in orderProduct.Packages)
                {
                    var packageFromDB = Master.Model.Packages.FirstOrDefault(o => o.Id == package.Package_Id);
                    if (packageFromDB != null)
                    {
                        packageFromDB.Delivery = delivery;
                        if (package.PackageChild != null)
                        {
                            var weightTare = packageFromDB.WeightGross - packageFromDB.WeightNet;
                            packageFromDB.Quantity = package.Quantity;
                            packageFromDB.WeightNet = packageFromDB.Quantity * packageFromDB.Product.ConversionFactorKg;
                            packageFromDB.WeightGross = packageFromDB.WeightNet + weightTare;

                            packageNew = new EntityModels.Package();
                            packageNew.Batch = packageFromDB.Batch;
                            packageNew.Code = package.PackageChild.Code;
                            packageNew.ContainerInitial = package.PackageChild.WarehouseContainer;
                            packageNew.DateExpiration = packageFromDB.DateExpiration;
                            packageNew.DateProduction = packageFromDB.DateProduction;
                            packageNew.PackageParent = packageFromDB;
                            packageNew.PackageType = packageFromDB.PackageType;
                            packageNew.Product = packageFromDB.Product;
                            packageNew.Quantity = package.PackageChild.Quantity;
                            packageNew.Reception = packageFromDB.Reception;
                            packageNew.WarehouseContainer = packageFromDB.WarehouseContainer;
                            packageNew.WeightGross = package.PackageChild.WeightGross;
                            packageNew.WeightNet = package.PackageChild.WeightNet;
                            Master.Model.Packages.AddObject(packageNew);
                        }
                    }
                }
            }

            try
            {
                Master.Model.Deliveries.AddObject(delivery);
                Master.Model.SaveChanges();
                Master.ClearDeliverySession();
            }
            catch
            {
            }

            try
            {
                var company = Master.LoggedClientUser.Client.Company;
                string description = Master.LoggedClientUser.Client.NameShort + " - Adaugare livrare noua nr. " + delivery.ToString();
                var error = CommonLibs.EmailLib.Send(company.EmailSendServer, company.EmailSendPort, company.EmailSendEncryption, company.EmailSendAddress, "RADAN Raportari Logistica", company.EmailSendUsername, company.EmailSendPassword, Master.LoggedClientUser.Client.EmailAddressList + "," + company.EmailReceiveAddressList, null, null, null, description, description, null);
            }
            catch
            {
            }

            Response.Redirect("~/Default.aspx");
        }
    }
}