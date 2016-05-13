using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Sirius.EntityModels.WarehouseContainers
{
    public partial class WarehouseContainerFormSelect : Form
    {
        public int WarehouseId;
        public List<int> SelectedWarehouseContainerIdList;
        public int MaxCountAllowed;
        public WarehouseRows.WarehouseRowFilterCriteria.OptionsIsLimited IsLimited;

        private List<WarehouseContainer> WarehouseContainerList;
        private List<WarehouseContainers.WarehouseContainerLocation> WarehouseContainerLocationList;
        private List<Package> PackageList;
        private WarehouseRoom WarehouseRoomSelected;
        private WarehouseRow WarehouseRowSelected;

        private EntityModelSirius Model;

        public WarehouseContainerFormSelect()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
            SelectedWarehouseContainerIdList = new List<int>();
            WarehouseContainerList = new List<WarehouseContainer>();
            WarehouseContainerLocationList = new List<WarehouseContainerLocation>();
            PackageList = new List<Package>();
            WarehouseId = 0;
            MaxCountAllowed = 0;
            IsLimited = WarehouseRows.WarehouseRowFilterCriteria.OptionsIsLimited.All;
        }

        private void FormSelect_Shown(object sender, EventArgs e)
        {
            Text = "Selectare containere";
            labelDescription.Text += MaxCountAllowed > 0 ? (" (Se accepta maxim " + MaxCountAllowed.ToString() + ")") : string.Empty;
            var warehouse = Warehouses.WarehouseCollection.GetById(Model, WarehouseId, false);
            if (warehouse == null)
            {
                MessageBox.Show("Nu este definit depozitul", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            textBoxWarehouse.Text = warehouse.ToString();
            WarehouseRooms.WarehouseRoomCollection.PopulateSelectBoxWithAvailable(new WarehouseRooms.WarehouseRoomFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId, WarehouseId = WarehouseId }, selectBoxWarehouseRoom, (WarehouseRoomSelected != null ? WarehouseRoomSelected.Id : 0), false);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            foreach (var obj in WarehouseContainerList)
            {
                SelectedWarehouseContainerIdList.Add(obj.Id);
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void selectBoxWarehouseRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            WarehouseRoomSelected = WarehouseRooms.WarehouseRoomCollection.GetById(Model, selectBoxWarehouseRoom.GetSelectedId(), false);
            if (WarehouseRoomSelected != null)
            {
                WarehouseRows.WarehouseRowCollection.PopulateSelectBoxWithAvailable(new WarehouseRows.WarehouseRowFilterCriteria { WarehouseRoomId = WarehouseRoomSelected.Id, OptionIsLimited = WarehouseRows.WarehouseRowFilterCriteria.OptionsIsLimited.Yes }, selectBoxWarehouseRow, (WarehouseRowSelected != null ? WarehouseRowSelected.Id : 0), false);
            }
        }

        private void selectBoxWarehouseRow_SelectedIndexChanged(object sender, EventArgs e)
        {
            WarehouseRowSelected = WarehouseRows.WarehouseRowCollection.GetById(Model, selectBoxWarehouseRow.GetSelectedId(), false);
            if (WarehouseRowSelected != null)
            {
                pictureBoxWarehouseContainers.Refresh();
            }
        }

        private void buttonWarehouseContainersReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sigur doriti sa goliti lista cu containere?", "ATENTIE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                WarehouseContainerList.Clear();
                WarehouseContainers.WarehouseContainerCollection.PopulateListBoxPackageRelation(WarehouseContainerList, PackageList, listBoxWarehouseContainers);
                pictureBoxWarehouseContainers.Refresh();
            }
        }

        private void pictureBoxWarehouseContainers_MouseUp(object sender, MouseEventArgs e)
        {
            int i = 0;
            WarehouseContainer container = null;
            while ((container == null) && (i < WarehouseContainerLocationList.Count))
            {
                if (WarehouseContainerLocationList[i].Location.Contains(e.Location)) container = WarehouseContainerLocationList[i].Container;
                i++;
            }
            if (container != null)
            {
                if (container.IsAvailable)
                {
                    if (container.WarehouseRow.IsLimited)
                    {
                        if ((container.Packages.Count == 0) || (container.Packages.All(o => o.Delivery != null)))
                        {
                            if (WarehouseContainerList.Contains(container))
                            {
                                WarehouseContainerList.Remove(container);
                            }
                            else
                            {
                                WarehouseContainerList.Add(container);
                            }
                        }
                    }
                    else
                    {
                        WarehouseContainerList.Add(container);
                    }
                    pictureBoxWarehouseContainers.Refresh();
                }
            }
        }

        private void pictureBoxWarehouseContainers_Paint(object sender, PaintEventArgs e)
        {
            List<Package> packageList = new List<Package>();
            WarehouseContainerLocationList = WarehouseRows.WarehouseRowCollection.RenderOnGraphics(Model, e.Graphics, WarehouseRowSelected, WarehouseContainerList, PackageList);
            WarehouseContainers.WarehouseContainerCollection.PopulateListBoxPackageRelation(WarehouseContainerList, PackageList, listBoxWarehouseContainers);
        }
    }
}
