using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sirius.EntityModels.WarehouseContainers
{
    public partial class WarehouseContainerFormEdit : CustomControls.EntityFormEdit
    {
        private EntityModelSirius Model;
        private new WarehouseContainer Entity
        {
            get { return base.Entity as WarehouseContainer; }
            set { base.Entity = value; }
        }

        public WarehouseContainerFormEdit()
            : base()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
        }

        public override void FormEdit_Shown(object sender, EventArgs e)
        {
            Entity = WarehouseContainerCollection.GetById(Model, EntityId, true);
            SetFormName(WarehouseContainerCollection.EntityNameSingular);
            base.FormEdit_Shown(sender, e);
        }

        public override void LoadFieldsFromEntity()
        {
            textBoxWarehouse.Text = Entity.WarehouseRow.WarehouseRoom.Warehouse.ToString();
            textBoxLocation.Text = Entity.LocationToString;
            textBoxName.Text = Entity.Name;
            checkBoxIsAvailable.Checked = Entity.IsAvailable;
        }

        public override bool SaveFieldsToEntity()
        {
            Entity.Name = textBoxName.Text.Trim();
            Entity.IsAvailable = checkBoxIsAvailable.Checked;

            if (EntityId == 0)
            {
                Model.WarehouseContainers.AddObject(Entity);
            }
            Model.SaveChanges();
            return true;
        }
    }
}
