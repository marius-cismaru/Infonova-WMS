using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace Sirius.SiriusOnline
{
    public partial class DeliveryEditStep3 : System.Web.UI.Page
    {
        EntityModels.HelperDelivery DeliveryFromSession;

        public new SiteMaster Master
        {
            get { return ((SiteMaster)(base.Master)); }
        }

        private void RefreshControls()
        {
            ListBoxOrderProducts.Items.Clear();
            foreach (var orderProduct in DeliveryFromSession.DeliveryOrderProducts)
            {
                ListBoxOrderProducts.Items.Add(new ListItem { Text = orderProduct.ToString(), Value = orderProduct.Product_Id.ToString() });
            }

            DropDownListProduct.Items.Clear();
            var productIdsAlreadySelected = DeliveryFromSession.DeliveryOrderProducts.Select(q => q.Product_Id);
            var productList = (from o in Master.Model.Packages
                               where (o.Reception.Client.Id == Master.LoggedClientUser.Client.Id) && (o.Reception.Warehouse.Id == DeliveryFromSession.Warehouse_Id) && (o.Delivery == null) && (!productIdsAlreadySelected.Contains(o.Product.Id))
                               group o by o.Product into p
                               orderby p.Key.Name
                               select new
                               {
                                   ProductRef = p.Key,
                                   Quantity = p.Sum(o => o.Quantity),
                                   WeightNet = p.Sum(o => o.WeightNet),
                                   WeightGross = p.Sum(o => o.WeightGross),
                                   PackageCount = p.Count()
                               }).ToList();
            DropDownListProduct.Items.AddRange(productList.Select(o => new ListItem { Text = (o.ProductRef.Name + " (" + o.ProductRef.Code + ") - Disponibil: " + o.Quantity.ToString("0.00", CultureInfo.InvariantCulture) + " " + o.ProductRef.MeasuringUnit.Name + " - Pachete: " + o.PackageCount.ToString()), Value = o.ProductRef.IdToString }).ToArray());

            TextBoxTotalWeightNet.Text = DeliveryFromSession.DeliveryOrderProducts.Sum(o => o.WeightNet).ToString("0.00", CultureInfo.InvariantCulture);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            DeliveryFromSession = Master.GetDeliveryFromSession();
            //If current wizard step not 3, jump to current step
            if (DeliveryFromSession.StepCurrent != 3)
            {
                Response.Redirect("~/DeliveryEditStep" + DeliveryFromSession.StepCurrent.ToString() + ".aspx");
            }

            if (!IsPostBack)
            {
                RefreshControls();
            }
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Master.ClearDeliverySession();
            Response.Redirect("~/Default.aspx");
        }

        protected void ButtonPrevious_Click(object sender, EventArgs e)
        {
            DeliveryFromSession.StepCurrent = 2;
            Master.SaveDeliveryToSession(DeliveryFromSession);

            Response.Redirect("~/DeliveryEditStep2.aspx");
        }

        protected void ButtonNext_Click(object sender, EventArgs e)
        {
            if (DeliveryFromSession.DeliveryOrderProducts.Count == 0)
            {
                LiteralMessage.Text = ToolMessage.Render(ToolMessage.Kinds.ERROR, "Trebuie introdus cel putin un articol");
            }
            else
            {
                DeliveryFromSession.StepCurrent = 4;

                Master.SaveDeliveryToSession(DeliveryFromSession);

                Response.Redirect("~/DeliveryEditStep4.aspx");
            }
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            double quantity = 0;
            if (!double.TryParse(TextBoxQuantity.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out quantity))
            {
                LiteralMessage.Text = ToolMessage.Render(ToolMessage.Kinds.ERROR, "Cantitate incorecta. Se foloseste punct (.) pentru zecimale");
            }
            else
            {
                if (quantity <= 0)
                {
                    LiteralMessage.Text = ToolMessage.Render(ToolMessage.Kinds.ERROR, "Nu se accepta cantitate negativa sau zero");
                }
                else
                {
                    LiteralMessage.Text = string.Empty;

                    int id = 0;
                    int.TryParse(DropDownListProduct.SelectedValue, out id);
                    var product = Master.Model.Products.FirstOrDefault(o => o.Id == id);
                    if (product != null)
                    {
                        var quantityStock = Master.Model.Packages.Where(o => ((o.Product.Id == id) && (o.Delivery == null) && (o.WarehouseContainer.WarehouseRow.WarehouseRoom.Warehouse.Id == DeliveryFromSession.Warehouse_Id))).Sum(o => o.Quantity);
                        if (quantity > quantityStock)
                        {
                            LiteralMessage.Text = ToolMessage.Render(ToolMessage.Kinds.ERROR, "Nu exista aceasta cantitate in depozitul selectat");
                        }
                        else
                        {
                            DeliveryFromSession.DeliveryOrderProducts.Add(new EntityModels.HelperDeliveryOrderProduct { Product_Id = id, Quantity = quantity, WeightNet = quantity * product.ConversionFactorKg, ProductCode = product.Code, ProductName = product.Name, ProductMU = product.MeasuringUnit.Name });

                            RefreshControls();
                        }
                    }
                }
            }
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(ListBoxOrderProducts.SelectedValue, out id);
            var orderProduct = DeliveryFromSession.DeliveryOrderProducts.FirstOrDefault(o=>o.Product_Id == id);
            if (orderProduct != null)
            {
                DeliveryFromSession.DeliveryOrderProducts.Remove(orderProduct);
                RefreshControls();
            }
            LiteralMessage.Text = string.Empty;
        }
    }
}