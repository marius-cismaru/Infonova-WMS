using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Sirius.EntityModels.DeliveryOrderProducts
{
    public partial class DeliveryOrderProductFormEdit : CustomControls.EntityFormEdit
    {
        public EntityModelSirius Model;
        public new DeliveryOrderProduct Entity 
        {
            get { return base.Entity as DeliveryOrderProduct; }
            set { base.Entity = value; }
        }
        private Product ProductSelected;

        public DeliveryOrderProductFormEdit()
        {
            InitializeComponent();
            //Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
            //Entity = DeliveryOrderProductCollection.GetById(Model, EntityId);
        }

        public override void FormEdit_Shown(object sender, EventArgs e)
        {
            SetFormName(DeliveryOrderProductCollection.EntityNameSingular);
            base.FormEdit_Shown(sender, e);
        }

        public override void LoadFieldsFromEntity()
        {
            if (Entity != null)
            {
                textBoxClient.Text = Entity.Delivery.Client.ToString();
                textBoxWarehouse.Text = Entity.Delivery.Warehouse.ToString();
                textBoxReception.Text = Entity.Delivery.ToString();
                Products.ProductCollection.PopulateSelectBoxWithExisting(Entity.Delivery.Client.Id, selectBoxProduct, Entity.Product != null ? Entity.Product.Id : 0);
            }
        }

        public override bool SaveFieldsToEntity()
        {
            bool validationOK = true;
            string validationText = string.Empty;
            double quantity = 0;

            validationOK &= double.TryParse(textBoxQuantity.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out quantity);
            validationOK &= quantity > 0;
            validationText += quantity <= 0 ? (Environment.NewLine + " - Cantitate: negativa, zero sau incorecta") : string.Empty;
            validationOK &= ProductSelected != null;
            validationText += ProductSelected == null ? (Environment.NewLine + " - Articol: inexistent") : string.Empty;

            if (validationOK)
            {
                Entity.Product = ProductSelected;
                Entity.Quantity = quantity;
                Entity.WeightNet = Math.Round(quantity * Entity.Product.ConversionFactorKg, 2);

                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Eroare introducere date:" + validationText, "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return validationOK;
        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            double quantity = 0;
            double.TryParse(textBoxQuantity.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out quantity);
            textBoxWeightNet.Text = (quantity * ProductSelected.ConversionFactorKg).ToString("0.00", CultureInfo.InvariantCulture);
        }

        private void selectBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductSelected = Products.ProductCollection.GetById(Model, selectBoxProduct.GetSelectedId(), false);
            labelQuantity.Text = "Cantitate" + (ProductSelected != null ? (" [" + ProductSelected.MeasuringUnit.Name + "]") : "");
            textBoxQuantity_TextChanged(sender, e);
        }

        private void buttonReceptionsBrowse_Click(object sender, EventArgs e)
        {
            Receptions.ReceptionCollection.Browse();
        }
    }
}
