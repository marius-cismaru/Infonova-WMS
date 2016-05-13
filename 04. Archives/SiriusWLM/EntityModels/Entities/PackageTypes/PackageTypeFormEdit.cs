using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Sirius.EntityModels.PackageTypes
{
    public partial class PackageTypeFormEdit : CustomControls.EntityFormEdit
    {
        private EntityModelSirius Model;
        private new PackageType Entity {
            get { return base.Entity as PackageType; }
            set { base.Entity = value; }
        }

        public PackageTypeFormEdit()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
        }

        public override void FormEdit_Shown(object sender, EventArgs e)
        {
            Entity = PackageTypeCollection.GetById(Model, EntityId, true);
            SetFormName(PackageTypeCollection.EntityNameSingular);
            base.FormEdit_Shown(sender, e);
        }

        public override void LoadFieldsFromEntity()
        {
            textBoxName.Text = Entity.Name;
            textBoxWarehouseContainerOccupancy.Text = Entity.WarehouseContainerOccupancy.ToString();
            textBoxWeightNetMaxSupported.Text = Entity.WeightNetMaxSupported.ToString();
        }

        public override bool SaveFieldsToEntity()
        {
            bool validation = true;
            string validationText = string.Empty;
            textBoxName.Text = textBoxName.Text.Trim();
            validation &= textBoxName.Text != string.Empty;
            if (textBoxName.Text == string.Empty)
            {
                validationText += Environment.NewLine + "- Denumire: trebuie introdusa o valoare";
            }
            double occupancy = 0;
            validation &= double.TryParse(textBoxWarehouseContainerOccupancy.Text, System.Globalization.NumberStyles.Number, CultureInfo.InvariantCulture, out occupancy);
            validation &= occupancy > 0;
            if (occupancy <= 0)
            {
                validationText += Environment.NewLine + "- Grad de ocupare container: trebuie introdusa o valoare valida si pozitiva";
            }
            double weightNetMaxSupported = 0;
            validation &= double.TryParse(textBoxWeightNetMaxSupported.Text, System.Globalization.NumberStyles.Number, CultureInfo.InvariantCulture, out weightNetMaxSupported);
            validation &= weightNetMaxSupported > 0;
            if (weightNetMaxSupported <= 0)
            {
                validationText += Environment.NewLine + "- Greutate neta maxima suportata: trebuie introdusa o valoare valida si pozitiva";
            }
            if (validation)
            {
                Entity.Name = textBoxName.Text.Trim();
                Entity.WarehouseContainerOccupancy = occupancy;
                Entity.WeightNetMaxSupported = weightNetMaxSupported;
                if (EntityId == 0)
                {
                    Model.PackageTypes.AddObject(Entity);
                }
                Model.SaveChanges();
            }
            else
            {
                MessageBox.Show("Introducere eronata date:" + validationText, "ATENTIE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return validation;
        }
    }
}
