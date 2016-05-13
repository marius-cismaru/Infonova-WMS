using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sirius.EntityModels.Warehouses
{
    public partial class WarehouseFormEdit : CustomControls.EntityFormEdit
    {
        private EntityModelSirius Model;
        private new Warehouse Entity
        {
            get { return base.Entity as Warehouse; }
            set { base.Entity = value; }
        }

        public WarehouseFormEdit()
            : base()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
        }

        public override void FormEdit_Shown(object sender, EventArgs e)
        {
            Entity = WarehouseCollection.GetById(Model, EntityId, true);
            SetFormName(WarehouseCollection.EntityNameSingular);
            base.FormEdit_Shown(sender, e);
        }

        public override void LoadFieldsFromEntity()
        {
            textBoxCompany.Text = Configuration.Main.LoggedCompanyNameShort;
            textBoxName.Text = Entity.Name;
            textBoxDescription.Text = Entity.Description;
            textBoxAddress.Text = Entity.Address;
            Countries.CountryCollection.PopulateSelectBox(selectBoxCountry, Entity.Country != null ? Entity.Country.Id : 0, false);
        }

        public override bool SaveFieldsToEntity()
        {
            Entity.Name = textBoxName.Text;
            Entity.Description = textBoxDescription.Text;
            Entity.Address = textBoxAddress.Text;
            Entity.Country = Countries.CountryCollection.GetById(Model, selectBoxCountry.GetSelectedId());

            if (EntityId == 0)
            {
                Model.Warehouses.AddObject(Entity);
            }
            Model.SaveChanges();
            return true;
        }
    }
}
