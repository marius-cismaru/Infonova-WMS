using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sirius.EntityModels.WarehouseRooms
{
    public partial class WarehouseRoomFormEdit : CustomControls.EntityFormEdit
    {
        private EntityModelSirius Model;
        private new WarehouseRoom Entity
        {
            get { return base.Entity as WarehouseRoom; }
            set { base.Entity = value; }
        }

        public WarehouseRoomFormEdit()
            : base()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
        }

        public override void FormEdit_Shown(object sender, EventArgs e)
        {
            Entity = WarehouseRoomCollection.GetById(Model, EntityId, true);
            SetFormName(WarehouseRoomCollection.EntityNameSingular);
            base.FormEdit_Shown(sender, e);
        }

        public override void LoadFieldsFromEntity()
        {
            Warehouses.WarehouseCollection.PopulateSelectBox(new Warehouses.WarehouseFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId }, selectBoxWarehouse, (Entity.Warehouse != null ? Entity.Warehouse.Id : 0), false);
            textBoxCode.Text = Entity.Code.ToString();
            textBoxDescription.Text = Entity.Description;
        }

        public override bool SaveFieldsToEntity()
        {
            bool result = true;
            int code;
            int.TryParse(textBoxCode.Text, out code);
            int warehouseId = selectBoxWarehouse.GetSelectedId();
            if (!WarehouseRoomCollection.CheckIfExistsByCodeExceptSelf(warehouseId, code, Entity.Id))
            {
                Entity.Code = code;
                Entity.Description = textBoxDescription.Text;

                if (EntityId == 0)
                {

                    Entity.Warehouse = Warehouses.WarehouseCollection.GetById(Model, warehouseId, true);
                    Model.WarehouseRooms.AddObject(Entity);
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
    }
}
