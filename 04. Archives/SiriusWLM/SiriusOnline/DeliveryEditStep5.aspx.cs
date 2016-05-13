using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace Sirius.SiriusOnline
{
    public partial class DeliveryEditStep5 : System.Web.UI.Page
    {
        EntityModels.HelperDelivery DeliveryFromSession;

        public new SiteMaster Master
        {
            get { return ((SiteMaster)(base.Master)); }
        }

        private EntityModels.HelperDeliveryOrderProduct GetSelectedOrderProduct()
        {
            int id = 0;
            int.TryParse(ListBoxOrderProducts.SelectedValue, out id);
            return DeliveryFromSession.DeliveryOrderProducts.FirstOrDefault(o => o.Product_Id == id);
        }

        private EntityModels.HelperDeliveryPackage GetSelectedPackageFromSelected(EntityModels.HelperDeliveryOrderProduct product)
        {
            int id = 0;
            int.TryParse(ListBoxPackagesSelected.SelectedValue, out id);
            return product.Packages.FirstOrDefault(o => o.Package_Id == id);
        }

        private int GetSelectedPackageIdFromAvailable()
        {
            int id = 0;
            int.TryParse(DropDownListPackagesAvailable.SelectedValue, out id);
            return id;
        }

        private void RefreshOrderProducts()
        {
            TextBoxPickingDescription.Text = DeliveryFromSession.OptionPickingMethodDescription + ", " + DeliveryFromSession.OptionQuantityPolicyDescription;

            var selectedValue = ListBoxOrderProducts.SelectedValue;

            ListBoxOrderProducts.Items.Clear();
            foreach (var orderProduct in DeliveryFromSession.DeliveryOrderProducts)
            {
                ListBoxOrderProducts.Items.Add(new ListItem { Text = orderProduct.ToStringForPicking(), Value = orderProduct.Product_Id.ToString() });
            }

            if (ListBoxOrderProducts.Items.Count > 0)
            {
                if (ListBoxOrderProducts.Items.FindByValue(selectedValue) != null)
                {
                    ListBoxOrderProducts.SelectedValue = selectedValue;
                }
            }

            var packages = DeliveryFromSession.DeliveryOrderProducts.SelectMany(o => o.Packages).ToList();

            TextBoxTotalWeight.Text = "Greutate neta: " + packages.Sum(o => o.WeightNet).ToString("0.00", CultureInfo.InvariantCulture) + ", greutate bruta: " + packages.Sum(o => o.WeightGross).ToString("0.00", CultureInfo.InvariantCulture) + ", pachete: " + packages.Count.ToString();

            //ListBoxOrderProducts_SelectedIndexChanged(null, null);
        }

        private void RefreshPackagesSelected()
        {
            var product = GetSelectedOrderProduct();
            ListBoxPackagesSelected.Items.Clear();
            if (product != null)
            {
                var selectedValue = ListBoxPackagesSelected.SelectedValue;

                ListBoxPackagesSelected.Items.AddRange(product.Packages.OrderBy(o => o.Code).ToList().Select(o => new ListItem { Text = o.ToString(), Value = o.Package_Id.ToString() }).ToArray());

                if (ListBoxPackagesSelected.Items.Count > 0)
                {
                    if (ListBoxPackagesSelected.Items.FindByValue(selectedValue) != null)
                    {
                        ListBoxPackagesSelected.SelectedValue = selectedValue;
                    }
                }
            }
        }

        private void RefreshPackagesAvailable()
        {
            var product = GetSelectedOrderProduct();
            DropDownListPackagesAvailable.Items.Clear();
            if (product != null)
            {
                var selectedValue = ListBoxPackagesSelected.SelectedValue;

                var packageIdsSelected = product.Packages.Select(o => o.Package_Id).ToList();
                var packages = Master.Model.Packages.Where(o => ((o.Product.Id == product.Product_Id) && (o.Delivery == null) && (o.WarehouseContainer.WarehouseRow.WarehouseRoom.Warehouse.Id == DeliveryFromSession.Warehouse_Id) && (!packageIdsSelected.Contains(o.Id)))).OrderBy(o => o.Code).ToList();

                DropDownListPackagesAvailable.Items.AddRange(packages.Select(o => new ListItem { Text = o.ToStringForPicking(), Value = o.Id.ToString() }).ToArray());

                if (DropDownListPackagesAvailable.Items.Count > 0)
                {
                    if (DropDownListPackagesAvailable.Items.FindByValue(selectedValue) != null)
                    {
                        DropDownListPackagesAvailable.SelectedValue = selectedValue;
                    }
                }
            }
        }

        private void RefreshPackages()
        {
            RefreshPackagesSelected();
            RefreshPackagesAvailable();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            DeliveryFromSession = Master.GetDeliveryFromSession();
            //If current wizard step not 5, jump to current step
            if (DeliveryFromSession.StepCurrent != 5)
            {
                Response.Redirect("~/DeliveryEditStep" + DeliveryFromSession.StepCurrent.ToString() + ".aspx");
            }

            if (!IsPostBack)
            {
                RefreshOrderProducts();
                ListBoxOrderProducts.SelectedIndex = 0;
                RefreshPackages();
            }
        }

        protected void ListBoxOrderProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshPackages();
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Master.ClearDeliverySession();
            Response.Redirect("~/Default.aspx");
        }

        protected void ButtonPrevious_Click(object sender, EventArgs e)
        {
            DeliveryFromSession.StepCurrent = 4;
            Master.SaveDeliveryToSession(DeliveryFromSession);

            Response.Redirect("~/DeliveryEditStep4.aspx");
        }

        protected void ButtonNext_Click(object sender, EventArgs e)
        {
            if (DeliveryFromSession.DeliveryOrderProducts.SelectMany(o => o.Packages).Count() == 0)
            {
                LiteralMessage.Text = ToolMessage.Render(ToolMessage.Kinds.ERROR, "Trebuie introdus cel putin un pachet");
            }
            else
            {
                DeliveryFromSession.StepCurrent = 6;

                Master.SaveDeliveryToSession(DeliveryFromSession);

                Response.Redirect("~/DeliveryEditStep6.aspx");
            }
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            var productSelected = GetSelectedOrderProduct();
            if (productSelected != null)
            {
                var packageId = GetSelectedPackageIdFromAvailable();
                var package = Master.Model.Packages.FirstOrDefault(o => o.Id == packageId);
                if(package!=null)
                {
                    productSelected.Packages.Add(new EntityModels.HelperDeliveryPackage { Batch = package.Batch, Code = package.Code, Package_Id = package.Id, PackageType = package.PackageType.Name, ProductMU = productSelected.ProductMU, Quantity = package.Quantity, ReceptionDate = package.Reception.DateCreation, ReceptionNumber = package.Reception.Number, WarehouseContainer = package.WarehouseContainer.CodeToString, WeightGross = package.WeightGross, WeightNet = package.WeightNet, ProductConversionFactorKg = package.Product.ConversionFactorKg });

                    RefreshOrderProducts();
                    RefreshPackages();
                }
            }

            LiteralMessage.Text = string.Empty;
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            var productSelected = GetSelectedOrderProduct();
            if (productSelected != null)
            {
                var packageSelected = GetSelectedPackageFromSelected(productSelected);
                if (packageSelected != null)
                {
                    productSelected.Packages.Remove(packageSelected);
                    RefreshOrderProducts();
                    RefreshPackages();
                }
            }

            LiteralMessage.Text = string.Empty;
        }
    }
}