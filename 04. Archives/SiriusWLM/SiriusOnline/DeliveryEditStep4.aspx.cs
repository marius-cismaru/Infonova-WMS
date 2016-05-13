using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace Sirius.SiriusOnline
{
    public partial class DeliveryEditStep4 : System.Web.UI.Page
    {
        EntityModels.HelperDelivery DeliveryFromSession;

        public new SiteMaster Master
        {
            get { return ((SiteMaster)(base.Master)); }
        }

        private string GetNewCode(string code, int receptionNumber)
        {
            string letter = code.Substring(code.Length - 3, 1).ToUpperInvariant();
            var packagesInReception = Master.Model.Packages.Where(o => ((o.Reception.Number == receptionNumber) && (o.Reception.Client.Id == Master.LoggedClientUser.Client.Id))).OrderByDescending(o => o.Code).Select(o => o.Code).ToList();
            string codeNew = string.Empty;
            foreach (var packageCode in packagesInReception)
            {
                if (packageCode.Substring(packageCode.Length - 3, 1).ToUpperInvariant() == letter)
                {
                    codeNew = packageCode;
                    break;
                }
            }

            int intValue = 99;
            int.TryParse(codeNew.Substring(codeNew.Length - 2,2), out intValue);
            intValue++;

            return codeNew.Substring(0, codeNew.Length - 2) + intValue.ToString("00");
        }

        private void PickPackages()
        {
            foreach (var product in DeliveryFromSession.DeliveryOrderProducts)
            {
                product.Packages.Clear();

                if (DeliveryFromSession.OptionPickingMethod != EntityModels.HelperDelivery.OptionsPickingMethod.Manual)
                {
                    var packages = Master.Model.Packages.Where(o => ((o.Product.Id == product.Product_Id) && (o.Delivery == null) && (o.WarehouseContainer.WarehouseRow.WarehouseRoom.Warehouse.Id == DeliveryFromSession.Warehouse_Id))).OrderBy(o => o.Code).ToList();
                    double quantityRemaining = product.Quantity;
                    int index = -1;
                    foreach (var package in packages)
                    {
                        if (quantityRemaining > 0)
                        {
                            product.Packages.Add(new EntityModels.HelperDeliveryPackage { Batch = package.Batch, Code = package.Code, Package_Id = package.Id, PackageType = package.PackageType.Name, ProductMU = product.ProductMU, Quantity = package.Quantity, ReceptionDate = package.Reception.DateCreation, ReceptionNumber = package.Reception.Number, WarehouseContainer = package.WarehouseContainer.CodeToString, WeightGross = package.WeightGross, WeightNet = package.WeightNet, ProductConversionFactorKg = package.Product.ConversionFactorKg });
                            quantityRemaining -= package.Quantity;
                            index++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if ((quantityRemaining < 0) && (DeliveryFromSession.OptionQuantityPolicy != EntityModels.HelperDelivery.OptionsQuantityPolicy.AllowOverDelivery))
                    {
                        if (DeliveryFromSession.OptionQuantityPolicy == EntityModels.HelperDelivery.OptionsQuantityPolicy.EnforceUnderDelivery)
                        {
                            //Delete last
                            product.Packages.RemoveAt(index);
                        }

                        if (DeliveryFromSession.OptionQuantityPolicy == EntityModels.HelperDelivery.OptionsQuantityPolicy.EnforceExact)
                        {
                            //Split last in 2 packages
                            var packageLast = product.Packages[index];
                            var quantityNew = -quantityRemaining;
                            var weightTare = packageLast.WeightGross - packageLast.WeightNet;

                            string codeNew = GetNewCode(packageLast.Code, packageLast.ReceptionNumber);

                            var packageNew = new EntityModels.HelperDeliveryPackage { Batch = packageLast.Batch, Code = codeNew, Package_Id = -1, PackageType = packageLast.PackageType, ProductMU = packageLast.ProductMU, Quantity = quantityNew, ReceptionDate = packageLast.ReceptionDate, ReceptionNumber = packageLast.ReceptionNumber, WarehouseContainer = packageLast.WarehouseContainer, WeightNet = quantityNew * packageLast.ProductConversionFactorKg, WeightGross = quantityNew * packageLast.ProductConversionFactorKg + weightTare, ProductConversionFactorKg = packageLast.ProductConversionFactorKg };

                            //product.Packages.Add(packageNew);

                            //Add it as child
                            packageLast.PackageChild = packageNew;

                            packageLast.Quantity -= quantityNew;
                            packageLast.WeightNet = packageLast.Quantity * packageLast.ProductConversionFactorKg;
                            packageLast.WeightGross = packageLast.WeightNet + weightTare;
                        }
                    }
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            DeliveryFromSession = Master.GetDeliveryFromSession();
            //If current wizard step not 4, jump to current step
            if (DeliveryFromSession.StepCurrent != 4)
            {
                Response.Redirect("~/DeliveryEditStep" + DeliveryFromSession.StepCurrent.ToString() + ".aspx");
            }

            if (!IsPostBack)
            {
                DropDownListPickingMethod.Items.AddRange(Enum.GetValues(typeof(EntityModels.HelperDelivery.OptionsPickingMethod)).Cast<EntityModels.HelperDelivery.OptionsPickingMethod>().ToList().Select(o => new ListItem { Text = CommonLibs.EnumsLib.GetDescription(o), Value = ((int)o).ToString() }).ToArray());
                if (DeliveryFromSession.PickingMethod != 0) DropDownListPickingMethod.SelectedValue = DeliveryFromSession.PickingMethod.ToString();

                DropDownListQuantityPolicy.Items.AddRange(Enum.GetValues(typeof(EntityModels.HelperDelivery.OptionsQuantityPolicy)).Cast<EntityModels.HelperDelivery.OptionsQuantityPolicy>().ToList().Select(o => new ListItem { Text = CommonLibs.EnumsLib.GetDescription(o), Value = ((int)o).ToString() }).ToArray());
                if (DeliveryFromSession.QuantityPolicy != 0) DropDownListQuantityPolicy.SelectedValue = DeliveryFromSession.QuantityPolicy.ToString();
            }
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Master.ClearDeliverySession();
            Response.Redirect("~/Default.aspx");
        }

        protected void ButtonPrevious_Click(object sender, EventArgs e)
        {
            DeliveryFromSession.StepCurrent = 3;
            Master.SaveDeliveryToSession(DeliveryFromSession);

            Response.Redirect("~/DeliveryEditStep3.aspx");
        }

        protected void ButtonNext_Click(object sender, EventArgs e)
        {
            int id = 1;
            int.TryParse(DropDownListPickingMethod.SelectedValue, out id);
            DeliveryFromSession.PickingMethod = id;
            id = 1;
            int.TryParse(DropDownListQuantityPolicy.SelectedValue, out id);
            DeliveryFromSession.QuantityPolicy = id;

            PickPackages();

            DeliveryFromSession.StepCurrent = 5;

            Master.SaveDeliveryToSession(DeliveryFromSession);

            Response.Redirect("~/DeliveryEditStep5.aspx");
        }
    }
}