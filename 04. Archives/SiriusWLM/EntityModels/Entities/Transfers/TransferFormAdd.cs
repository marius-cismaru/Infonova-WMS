using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Sirius.EntityModels.Transfers
{
    public partial class TransferFormAdd : CustomControls.EntityFormAdd
    {
        private EntityModelSirius Model;
        private Warehouse WarehouseSelected;
        private WarehouseRoom WarehouseRoomSelected;
        private WarehouseRow WarehouseRowSelected;
        private List<WarehouseContainer> WarehouseContainerList;
        private List<Package> PackageList;
        private List<Transfer> TransferList;
        private List<WarehouseContainers.WarehouseContainerLocation> WarehouseContainerLocationList;

        public TransferFormAdd()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
            WarehouseSelected = null;
            WarehouseContainerList = new List<WarehouseContainer>();
            PackageList = new List<Package>();
            TransferList = new List<Transfer>();
            WarehouseContainerLocationList = new List<WarehouseContainers.WarehouseContainerLocation>();
        }

        protected override bool PreviousPageWizard()
        {
            bool allowPrevious = true;

            if (tabControlWizard.SelectedTab == tabPageStep2)
            {
            }

            return allowPrevious;
        }

        protected override bool NextPageWizard()
        {
            bool allowNext = true;

            if (tabControlWizard.SelectedTab == tabPageStep1)
            {
                WarehouseSelected = Warehouses.WarehouseCollection.GetById(Model, selectBoxWarehouse.GetSelectedId(), false);
                if (WarehouseSelected != null)
                {
                    labelHeaderWarehouse.Text = "Depozit: " + WarehouseSelected.ToString();
                }
                else
                {
                    MessageBox.Show("Trebuie sa existe cel putin un depozit configurat. Apasa butonul Gestionare din dreptul lui pentru a adauga depozite noi", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    allowNext = false;
                }
            }

            if (tabControlWizard.SelectedTab == tabPageStep2)
            {
                allowNext = PackageList.Count > 0;
                if (!allowNext)
                {
                    MessageBox.Show("Trebuie selectat cel putin un pachet.", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (tabControlWizard.SelectedTab == tabPageStep3)
            {
                allowNext = WarehouseContainerList.Count >= PackageList.Count;
                if (!allowNext)
                {
                    MessageBox.Show("Trebuie selectate cel putin " + PackageList.Count.ToString() + " containere destinatie.", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return allowNext;
        }

        protected override void ChangedPageWizard()
        {
            if (tabControlWizard.SelectedTab == tabPageStep1)
            {
                selectBoxWarehouse.Enabled = (PackageList.Count == 0);
            }

            if (tabControlWizard.SelectedTab == tabPageStep2)
            {
            }

            if (tabControlWizard.SelectedTab == tabPageStep3)
            {
                WarehouseRooms.WarehouseRoomCollection.PopulateSelectBoxWithAvailable(new WarehouseRooms.WarehouseRoomFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId, WarehouseId = WarehouseSelected.Id }, selectBoxWarehouseRoom, (WarehouseRoomSelected != null ? WarehouseRoomSelected.Id : 0), false);
            }

            if (tabControlWizard.SelectedTab == tabPageStep4)
            {
                foreach (var obj in TransferList)
                {
                    Model.Detach(obj);
                }
                TransferList.Clear();
                Package package;
                for(int i=0; i<PackageList.Count;i++)
                {
                    package = PackageList[i];
                    TransferList.Add(new Transfer
                    {
                        Package = package,
                        User = Users.UserCollection.GetById(Model, Configuration.Main.LoggedUserId),
                        WarehouseContainerSource = package.WarehouseContainer,
                        WarehouseContainerDestination = WarehouseContainerList[i]
                    });
                }
                Transfers.TransferCollection.PopulateGridViewNormal(TransferList, gridViewTransfers);
            }
        }

        protected override void ShowForm()
        {
            SetFormName(Transfers.TransferCollection.EntityNameSingular);

            //Step1
            labelHeaderWarehouse.Text = "Depozit: -";
            Warehouses.WarehouseCollection.PopulateSelectBox(new Warehouses.WarehouseFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId }, selectBoxWarehouse, 0, false);

            //Step2
            gridViewPackages.SetCustomColumns(Packages.PackageCollection.GridViewColumnsWithPosition);

            //Step4
            gridViewTransfers.SetCustomColumns(Transfers.TransferCollection.GridViewColumnsNormal);
        }

        private void selectBoxWarehouseRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            WarehouseRoomSelected = WarehouseRooms.WarehouseRoomCollection.GetById(Model, selectBoxWarehouseRoom.GetSelectedId(), false);
            if (WarehouseRoomSelected != null)
            {
                WarehouseRows.WarehouseRowCollection.PopulateSelectBoxWithAvailable(new WarehouseRows.WarehouseRowFilterCriteria { WarehouseRoomId = WarehouseRoomSelected.Id, OptionIsLimited = WarehouseRows.WarehouseRowFilterCriteria.OptionsIsLimited.All }, selectBoxWarehouseRow, (WarehouseRowSelected != null ? WarehouseRowSelected.Id : 0), false);
            }
        }

        protected override bool FinishWizard()
        {
            bool result = false;

            if (MessageBox.Show("Esti sigur ca doresti sa finalizezi transferurile?", "INTREBARE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                foreach (var obj in TransferList)
                {
                    obj.Package.WarehouseContainer = obj.WarehouseContainerDestination;
                    Model.Transfers.AddObject(obj);
                }

                Model.SaveChanges();

                //Reports.ReportReceptionNote.ShowDialog(new Reports.ReportReceptionNoteFilterCriteria { ReceptionId = Entity.Id });

                MessageBox.Show("Transferuri salvate", "SUCCES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = true;
            }

            return result;
        }

        private void selectBoxWarehouseRow_SelectedIndexChanged(object sender, EventArgs e)
        {
            WarehouseRowSelected = WarehouseRows.WarehouseRowCollection.GetById(Model, selectBoxWarehouseRow.GetSelectedId(), false);
            if (WarehouseRowSelected != null)
            {
                pictureBoxWarehouseContainers.Refresh();
            }
        }

        private void pictureBoxWarehouseContainers_Paint(object sender, PaintEventArgs e)
        {
            WarehouseContainerLocationList = WarehouseRows.WarehouseRowCollection.RenderOnGraphics(Model, e.Graphics, WarehouseRowSelected, WarehouseContainerList, PackageList);
            WarehouseContainers.WarehouseContainerCollection.PopulateListBoxPackageAssociation(WarehouseContainerList, PackageList, listBoxWarehouseContainers);
        }

        private void pictureBoxWarehouseContainers_MouseUp(object sender, MouseEventArgs e)
        {
            int i = 0;
            WarehouseContainer container = null;
            while ((container == null) && (i < WarehouseContainerLocationList.Count))
            {
                if(WarehouseContainerLocationList[i].Location.Contains(e.Location)) container = WarehouseContainerLocationList[i].Container;
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

        private void buttonWarehouseContainersReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sigur doriti sa goliti lista cu containere?", "ATENTIE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                WarehouseContainerList.Clear();
                WarehouseContainers.WarehouseContainerCollection.PopulateListBoxPackageRelation(WarehouseContainerList, PackageList, listBoxWarehouseContainers);
                pictureBoxWarehouseContainers.Refresh();
            }
        }

        private void buttonWarehouseBrowse_Click(object sender, EventArgs e)
        {
            Warehouses.WarehouseCollection.Browse();
            Model.Refresh(System.Data.Objects.RefreshMode.StoreWins, Model.Warehouses);
            Warehouses.WarehouseCollection.PopulateSelectBox(new Warehouses.WarehouseFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId }, selectBoxWarehouse, WarehouseSelected != null ? WarehouseSelected.Id : 0, false);
        }

        private void buttonPackagesAdd_Click(object sender, EventArgs e)
        {
            using (Packages.PackageFormSelect formSelect = new Packages.PackageFormSelect())
            {
                formSelect.WarehouseId = WarehouseSelected.Id;
                formSelect.ClientId = 0;
                formSelect.ProductIdsList = new List<int>();
                var packageSelected = Packages.PackageCollection.GetById(Model, gridViewPackages.GetSelectedId(), false);
                formSelect.ProductSelectedId = packageSelected != null ? packageSelected.Product.Id : 0;
                formSelect.PackageAlreadySelectedIdsList = new List<int>();
                foreach (var obj in PackageList)
                {
                    formSelect.PackageAlreadySelectedIdsList.Add(obj.Id);
                }

                if (formSelect.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (var obj in formSelect.PackageNewlySelectedIdsList)
                    {
                        PackageList.Add(Packages.PackageCollection.GetById(Model, obj, true));
                    }
                    Packages.PackageCollection.PopulateGridViewWithPosition(PackageList, gridViewPackages);
                }
            }
        }

        private void buttonPackagesDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esti sigur ca doresti sa stergi pachetul selectat?", "INTREBARE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (PackageList.RemoveAll(o => o.Id == gridViewPackages.GetSelectedId()) > 0)
                {
                    Packages.PackageCollection.PopulateGridViewWithPosition(PackageList, gridViewPackages);
                }
            }
        }
    }
}
