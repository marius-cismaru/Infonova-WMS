using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sirius.EntityModels.WarehouseRows
{
    public partial class WarehouseRowFormEdit : CustomControls.EntityFormEdit
    {
        private EntityModelSirius Model;
        private new WarehouseRow Entity
        {
            get { return base.Entity as WarehouseRow; }
            set { base.Entity = value; }
        }

        public WarehouseRowFormEdit()
            : base()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
        }

        public override void FormEdit_Shown(object sender, EventArgs e)
        {
            Entity = WarehouseRowCollection.GetById(Model, EntityId, true);
            SetFormName(WarehouseRowCollection.EntityNameSingular);
            base.FormEdit_Shown(sender, e);
        }

        public override void LoadFieldsFromEntity()
        {
            Warehouses.WarehouseCollection.PopulateSelectBox(new Warehouses.WarehouseFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId }, selectBoxWarehouse, (Entity.WarehouseRoom != null ? (Entity.WarehouseRoom.Warehouse != null ? Entity.WarehouseRoom.Warehouse.Id : 0) : 0), false);

            textBoxCode.Text = Entity.Code.ToString();
            checkBoxIsInverted.Checked = Entity.IsInverted;
            checkBoxIsLimited.Checked = Entity.IsLimited;
        }

        public override bool SaveFieldsToEntity()
        {
            bool result = true;
            int code;
            int.TryParse(textBoxCode.Text, out code);
            int warehouseRoomId = selectBoxWarehouseRoom.GetSelectedId();

            if (!WarehouseRowCollection.CheckIfExistsByCodeExceptSelf(warehouseRoomId, code, Entity.Id))
            {
                Entity.Code = code;
                Entity.IsInverted = checkBoxIsInverted.Checked;
                Entity.IsLimited = checkBoxIsLimited.Checked;

                if (EntityId == 0)
                {
                    Entity.WarehouseRoom = WarehouseRooms.WarehouseRoomCollection.GetById(Model, warehouseRoomId, true);
                    Model.WarehouseRows.AddObject(Entity);
                }
                Model.SaveChanges();
            }
            else
            {
                MessageBox.Show("Acest cod mai exista deja", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }

            return result;
        }

        private void selectBoxWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            WarehouseRooms.WarehouseRoomCollection.PopulateSelectBox(new WarehouseRooms.WarehouseRoomFilterCriteria { WarehouseId = selectBoxWarehouse.GetSelectedId() }, selectBoxWarehouseRoom, (Entity.WarehouseRoom != null ? Entity.WarehouseRoom.Id : 0), false);
        }
    }
}
