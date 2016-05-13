using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Sirius.EntityModels.WarehouseRows
{
    public partial class WarehouseRowOverview : UserControl
    {
        private EntityModelSirius Model;
        private Warehouse WarehouseSelected;
        private WarehouseRoom WarehouseRoomSelected;
        private WarehouseRow WarehouseRowSelected;

        private List<WarehouseContainer> WarehouseContainerList;
        private List<Package> PackageList;
        private List<WarehouseContainers.WarehouseContainerLocation> WarehouseContainerLocationList;

        private Graphics canvas;

        public WarehouseRowOverview()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
            WarehouseContainerLocationList = new List<WarehouseContainers.WarehouseContainerLocation>();
            WarehouseContainerList = new List<WarehouseContainer>();
            PackageList = new List<Package>();
        }

        private void pictureBoxMain_Paint(object sender, PaintEventArgs e)
        {
            WarehouseContainerLocationList = WarehouseRows.WarehouseRowCollection.RenderOnGraphics(Model, e.Graphics, WarehouseRowSelected, WarehouseContainerList, PackageList);
            canvas = e.Graphics;
        }

        private void selectBoxWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            WarehouseSelected = Warehouses.WarehouseCollection.GetById(Model, selectBoxWarehouse.GetSelectedId(), false);
            if (WarehouseSelected != null)
            {
                WarehouseRooms.WarehouseRoomCollection.PopulateSelectBoxWithAvailable(new WarehouseRooms.WarehouseRoomFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId, WarehouseId = WarehouseSelected.Id }, selectBoxWarehouseRoom, WarehouseRoomSelected != null ? WarehouseRoomSelected.Id : 0, false);
            }
        }

        private void selectBoxWarehouseRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            WarehouseRoomSelected = WarehouseRooms.WarehouseRoomCollection.GetById(Model, selectBoxWarehouseRoom.GetSelectedId(), false);
            if (WarehouseRoomSelected != null)
            {
                WarehouseRows.WarehouseRowCollection.PopulateSelectBoxWithAvailable(new WarehouseRows.WarehouseRowFilterCriteria { WarehouseRoomId = WarehouseRoomSelected.Id }, selectBoxWarehouseRow, WarehouseRowSelected != null ? WarehouseRowSelected.Id : 0, false);
            }
        }

        private void selectBoxWarehouseRow_SelectedIndexChanged(object sender, EventArgs e)
        {
            WarehouseRowSelected = WarehouseRows.WarehouseRowCollection.GetById(Model, selectBoxWarehouseRow.GetSelectedId(), false);
            pictureBoxMain.Refresh();
        }

        private void WarehouseRowOverview_Load(object sender, EventArgs e)
        {
            Warehouses.WarehouseCollection.PopulateSelectBox(new Warehouses.WarehouseFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId }, selectBoxWarehouse, WarehouseSelected != null ? WarehouseSelected.Id : 0, false);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            Model.Refresh(System.Data.Objects.RefreshMode.StoreWins, Model.Warehouses);
            Model.Refresh(System.Data.Objects.RefreshMode.StoreWins, Model.WarehouseRooms);
            Model.Refresh(System.Data.Objects.RefreshMode.StoreWins, Model.WarehouseRows);
            Model.Refresh(System.Data.Objects.RefreshMode.StoreWins, Model.WarehouseContainers);
            Model.Refresh(System.Data.Objects.RefreshMode.StoreWins, Model.Packages);
            selectBoxWarehouseRow_SelectedIndexChanged(sender, e);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                System.Drawing.Printing.PrintDocument myPrintDocument = new System.Drawing.Printing.PrintDocument();
                PrintDialog myPrinDialog = new PrintDialog();
                myPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(myPrintDocument_PrintPage);
                myPrintDocument.DefaultPageSettings.Landscape = true;
                myPrinDialog.Document = myPrintDocument;

                if (myPrinDialog.ShowDialog() == DialogResult.OK)
                {
                    myPrintDocument.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A fost o eroare la printare: " + ex.ToString(), "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void myPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                Graphics graphics = Graphics.FromImage(bitmap as Image);
                graphics.CopyFromScreen(0, 0 + 80, 40, 80, new Size(bitmap.Width, bitmap.Height - 120));
                e.Graphics.DrawImage(bitmap, 0, 0, 1000, 620);
                bitmap.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("A fost o eroare la printare: " + ex.ToString(), "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
