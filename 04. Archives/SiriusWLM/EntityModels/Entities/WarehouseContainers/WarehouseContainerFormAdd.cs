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
    public partial class WarehouseContainerFormAdd : CustomControls.EntityFormAdd
    {
        private EntityModelSirius Model;
        WarehouseRow WarehouseRowSelected;
        int IntervalCount = 1;
        int SlotCount = 3;
        int FloorCount = 6;

        public WarehouseContainerFormAdd()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
        }

        protected override void ChangedPageWizard()
        {
            if (tabControlWizard.SelectedTab == tabPageStep1)
            {
            }
            if (tabControlWizard.SelectedTab == tabPageStep2)
            {
                WarehouseRowSelected = WarehouseRows.WarehouseRowCollection.GetById(Model, selectBoxWarehouseRow.GetSelectedId(), true);
                textBoxLocation.Text = "Rand: " + WarehouseRowSelected.ToString() + ", camera: " + WarehouseRowSelected.WarehouseRoom.ToString() + ", depozit: " + WarehouseRowSelected.WarehouseRoom.Warehouse.ToString();
            }
        }

        protected override void ShowForm()
        {
            Warehouses.WarehouseCollection.PopulateSelectBox(new Warehouses.WarehouseFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId }, selectBoxWarehouse, 0, false);
            SetFormName(WarehouseContainers.WarehouseContainerCollection.EntityNamePlural);
            textBoxIntervalCount.Text = IntervalCount.ToString();
            textBoxSlotCount.Text = SlotCount.ToString();
            textBoxFloorCount.Text = FloorCount.ToString();
        }

        protected override bool FinishWizard()
        {
            bool result = false;

            bool Validated = true;
            Validated &= int.TryParse(textBoxIntervalCount.Text, out IntervalCount);
            Validated &= int.TryParse(textBoxSlotCount.Text, out SlotCount);
            Validated &= int.TryParse(textBoxFloorCount.Text, out FloorCount);
            if (Validated)
            {
                int countAdded = 0;
                WarehouseContainer container;
                for (int indexInterval = 1; indexInterval <= IntervalCount; indexInterval++)
                {
                    for (int indexSlot = 1; indexSlot <= SlotCount; indexSlot++)
                    {
                        for (int indexFloor = 1; indexFloor <= FloorCount; indexFloor++)
                        {
                            if (WarehouseContainerCollection.GetByLocation(Model, WarehouseRowSelected.WarehouseRoom.Warehouse.Id, WarehouseRowSelected.WarehouseRoom.Code, WarehouseRowSelected.Code, indexInterval, indexSlot, indexFloor) == null)
                            {
                                container = new WarehouseContainer();
                                container.WarehouseRow = WarehouseRowSelected;
                                container.IsAvailable = checkBoxIsAvailable.Checked;
                                container.Interval = indexInterval;
                                container.Slot = indexSlot;
                                container.Floor = indexFloor;
                                container.Name = container.CodeToString;
                                Model.WarehouseContainers.AddObject(container);
                                countAdded++;
                            }
                        }
                    }
                }

                Model.SaveChanges();
                MessageBox.Show("Au fost adaugate " + countAdded.ToString() + " containere noi", "INFORMARE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = true;
            }
            else
            {
                MessageBox.Show("Cel putin o valoare introdusa este incorecta (nu este numar)", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }

        private void buttonWarehouseBrowse_Click(object sender, EventArgs e)
        {
            Warehouses.WarehouseCollection.Browse();
        }

        private void selectBoxWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            WarehouseRooms.WarehouseRoomCollection.PopulateSelectBox(new WarehouseRooms.WarehouseRoomFilterCriteria { WarehouseId = selectBoxWarehouse.GetSelectedId() }, selectBoxWarehouseRoom, 0, false);
        }

        private void selectBoxWarehouseRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            WarehouseRows.WarehouseRowCollection.PopulateSelectBox(new WarehouseRows.WarehouseRowFilterCriteria { WarehouseRoomId = selectBoxWarehouseRoom.GetSelectedId() }, selectBoxWarehouseRow, 0, false);
        }
    }
}
