using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sirius.EntityModels.ReceptionProducts
{
    public partial class ReceptionProductFormEdit : CustomControls.EntityFormEdit
    {
        public EntityModelSirius Model;
        public new ReceptionProduct Entity
        {
            get { return base.Entity as ReceptionProduct; }
            set { base.Entity = value; }
        }

        public ReceptionProductFormEdit()
            : base()
        {
            InitializeComponent();
        }

        public override void FormEdit_Shown(object sender, EventArgs e)
        {
            SetFormName(ReceptionProductCollection.EntityNameSingular);
            base.FormEdit_Shown(sender, e);
        }

        public override void LoadFieldsFromEntity()
        {
            textBoxReception.Text = Entity.Reception.ToString();
            textBoxProduct.Text = Entity.Product.ToString();
            textBoxBatch.Text = Entity.Batch;
            checkBoxIsQualityOK.Checked = Entity.IsQualityOK;
            textBoxOrigin.Text = Entity.Origin;
            textBoxTemperature.Text = Entity.Temperature.ToString();
            textBoxObservation.Text = Entity.Observation;
        }

        public override bool SaveFieldsToEntity()
        {
            bool validationOK = true;
            string validationText = string.Empty;

            decimal temperature = -1000000;
            validationOK &= decimal.TryParse(textBoxTemperature.Text, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out temperature);
            validationText += temperature == -1000000 ? (Environment.NewLine + " - Temperatura: invalida") : string.Empty;
            if (validationOK)
            {
                Entity.Temperature = temperature;
                Entity.Batch = textBoxBatch.Text;
                Entity.IsQualityOK = checkBoxIsQualityOK.Checked;
                Entity.Origin = textBoxOrigin.Text.Trim();
                Entity.Observation = textBoxObservation.Text.Trim();
            }
            else
            {
                MessageBox.Show("Eroare introducere date:" + validationText, "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return validationOK;
        }
    }
}
