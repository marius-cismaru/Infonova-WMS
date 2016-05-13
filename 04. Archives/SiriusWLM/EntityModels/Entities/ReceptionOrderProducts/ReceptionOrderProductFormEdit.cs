using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Sirius.EntityModels.ReceptionOrderProducts
{
    public partial class ReceptionOrderProductFormEdit : CustomControls.EntityFormEdit
    {
        public EntityModelSirius Model;
        public new ReceptionOrderProduct Entity
        {
            get { return base.Entity as ReceptionOrderProduct; }
            set { base.Entity = value; }
        }

        private Product ProductSelected;

        public ReceptionOrderProductFormEdit()
        {
            InitializeComponent();
            //Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
            //Entity = DeliveryOrderProductCollection.GetById(Model, EntityId);
        }

        public override void FormEdit_Shown(object sender, EventArgs e)
        {
            SetFormName(ReceptionOrderProductCollection.EntityNameSingular);
            base.FormEdit_Shown(sender, e);
        }

        public override void LoadFieldsFromEntity()
        {
            if (Entity != null)
            {
                textBoxClient.Text = Entity.Reception.Client.ToString();
                textBoxWarehouse.Text = Entity.Reception.Warehouse.ToString();
                textBoxReception.Text = Entity.Reception.ToString();
                Products.ProductCollection.PopulateSelectBox(new Products.ProductFilterCriteria { ClientId = Entity.Reception.Client.Id }, selectBoxProduct, Entity.Product != null ? Entity.Product.Id : 0, false);
                textBoxQuantity.Text = Entity.Quantity > 0 ? Entity.Quantity.ToString("0.00", CultureInfo.InvariantCulture) : string.Empty;
                textBoxWeightGross.Text = Entity.WeightGross > 0 ? Entity.WeightGross.ToString("0.00", CultureInfo.InvariantCulture) : string.Empty;
            }
        }

        public override bool SaveFieldsToEntity()
        {
            bool validationOK = true;
            string validationText = string.Empty;
            double quantity = 0, weightGross = 0;

            validationOK &= double.TryParse(textBoxQuantity.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out quantity);
            validationOK &= quantity > 0;
            validationText += quantity <= 0 ? (Environment.NewLine + " - Cantitate: negativa, zero sau incorecta") : string.Empty;
            double.TryParse(textBoxWeightGross.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out weightGross);
            validationOK &= weightGross >= 0;
            validationText += weightGross < 0 ? (Environment.NewLine + " - Greutate bruta: negativa sau incorecta") : string.Empty;
            validationOK &= ProductSelected != null;
            validationText += ProductSelected == null ? (Environment.NewLine + " - Articol: inexistent") : string.Empty;

            if (validationOK)
            {
                Entity.Product = ProductSelected;
                Entity.Quantity = quantity;
                Entity.WeightNet = Math.Round(quantity * Entity.Product.ConversionFactorKg, 2);
                Entity.WeightGross = weightGross;
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
            if (ProductSelected != null)
            {
                labelQuantity.Text = "Cantitate" + (ProductSelected != null ? (" [" + ProductSelected.MeasuringUnit.Name + "]") : "");
                textBoxQuantity_TextChanged(sender, e);
            }
        }

        private void buttonProductBrowse_Click(object sender, EventArgs e)
        {
            Products.ProductCollection.Browse();
            Model.Refresh(System.Data.Objects.RefreshMode.StoreWins, Model.Products);
            Products.ProductCollection.PopulateSelectBox(new Products.ProductFilterCriteria { ClientId = Entity.Reception.Client.Id }, selectBoxProduct, ProductSelected != null ? ProductSelected.Id : 0, false);
        }
    }
}
