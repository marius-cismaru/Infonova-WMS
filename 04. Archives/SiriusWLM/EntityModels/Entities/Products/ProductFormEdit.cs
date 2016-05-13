using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Sirius.EntityModels.Products
{
    public partial class ProductFormEdit : CustomControls.EntityFormEdit
    {
        private EntityModelSirius Model;
        private new Product Entity
        {
            get { return base.Entity as Product; }
            set { base.Entity = value; }
        }
        private Client ClientSelected;
        private MeasuringUnit MeasuringUnitSelected;

        public ProductFormEdit()
            : base()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
        }

        public override void FormEdit_Shown(object sender, EventArgs e)
        {
            Entity = ProductCollection.GetById(Model, EntityId, true);
            SetFormName(ProductCollection.EntityNameSingular);
            if (EntityId != 0)
            {
                selectBoxClient.Enabled = false;
                buttonClientBrowse.Enabled = false;
            }
            base.FormEdit_Shown(sender, e);
        }

        public override void LoadFieldsFromEntity()
        {
            ClientSelected = Entity.Client;
            MeasuringUnitSelected = Entity.MeasuringUnit;

            Clients.ClientCollection.PopulateSelectBox(new Clients.ClientFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId }, selectBoxClient, (ClientSelected != null ? ClientSelected.Id : 0), false);
            textBoxId.Text = Entity.IdToString;
            textBoxCode.Text = Entity.Code;
            textBoxName.Text = Entity.Name;
            textBoxConversionFactorKg.Text = Entity.ConversionFactorKg.ToString("0.00", CultureInfo.InvariantCulture);
            MeasuringUnits.MeasuringUnitCollection.PopulateSelectBox(selectBoxMeasuringUnit, (MeasuringUnitSelected != null ? MeasuringUnitSelected.Id : 0), false);
        }

        public override bool SaveFieldsToEntity()
        {
            bool validationOK = true;
            string validationText = string.Empty;

            validationOK &= textBoxName.Text.Trim() != string.Empty;
            validationText += textBoxName.Text.Trim() == string.Empty ? (Environment.NewLine + " - Denumire: vida") : string.Empty;
            validationOK &= textBoxCode.Text.Trim() != string.Empty;
            validationText += textBoxCode.Text.Trim() == string.Empty ? (Environment.NewLine +  " - Cod: vid") : string.Empty;
            bool duplicateCode = Products.ProductCollection.CheckIfExistsByClientAndCodeExceptSelf(ClientSelected.Id, textBoxCode.Text.Trim(), Entity.Id);
            validationOK &= !duplicateCode;
            validationText += duplicateCode ? (Environment.NewLine + " - Cod: mai exista deja") : string.Empty;
            double conversionFactor = 0;
            validationOK &= double.TryParse(textBoxConversionFactorKg.Text, out conversionFactor);
            validationText += conversionFactor <= 0 ? (Environment.NewLine + " - Factor de conversie: negativ sau zero") : string.Empty;

            if (validationOK)
            {
                Entity.Code = textBoxCode.Text.Trim();
                Entity.Name = textBoxName.Text.Trim();
                Entity.ConversionFactorKg = conversionFactor;
                Entity.MeasuringUnit = MeasuringUnitSelected;

                if (EntityId == 0)
                {
                    Entity.Client = ClientSelected;
                    Model.Products.AddObject(Entity);
                }
                Model.SaveChanges();
            }
            else
            {
                MessageBox.Show("Introducere date invalide:" + validationText, "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return validationOK;
        }

        private void buttonClientBrowse_Click(object sender, EventArgs e)
        {
            Clients.ClientCollection.Browse();
            Clients.ClientCollection.PopulateSelectBox(new Clients.ClientFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId }, selectBoxClient, (ClientSelected != null ? ClientSelected.Id : 0), false);
        }

        private void selectBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClientSelected = Clients.ClientCollection.GetById(Model, selectBoxClient.GetSelectedId(), false);
        }

        private void selectBoxMeasuringUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            MeasuringUnitSelected = MeasuringUnits.MeasuringUnitCollection.GetById(Model, selectBoxMeasuringUnit.GetSelectedId());
        }
    }
}
