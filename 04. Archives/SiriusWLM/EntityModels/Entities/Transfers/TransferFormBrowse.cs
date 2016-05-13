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
    public partial class TransferFormBrowse : CustomControls.EntityFormBrowse
    {
        private EntityModelSirius Model;
        private TransferFilterCriteria Criteria;

        //Context Menu Master Reports
        //private ToolStripMenuItem menuItemMasterReportsReceptionNote;

        public TransferFormBrowse()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
            VisibleExtraPanels = ExtraPanels.Filter;
            Criteria = new TransferFilterCriteria
            {
                CompanyId = Configuration.Main.LoggedCompanyId
            };
            //Context Menu Master Reports
            //menuItemMasterReportsReceptionNote = new ToolStripMenuItem("Nota de receptie");
            //contextMenuStripMasterReports.Items.Add(menuItemMasterReportsReceptionNote);
        }

        protected override void LoadFieldsFromFilter()
        {
            Clients.ClientCollection.PopulateSelectBox(new Clients.ClientFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId }, selectBoxFilterClient, Criteria.ClientId, true);
            Warehouses.WarehouseCollection.PopulateSelectBox(new Warehouses.WarehouseFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId }, selectBoxFilterWarehouse, Criteria.WarehouseId, true);
            textBoxFilterPackageCode.Text = Criteria.PackageCode;
            textBoxFilterWarehouseContainerNameSource.Text = Criteria.WarehouseContainerNameSource;
            textBoxFilterWarehouseContainerNameDestination.Text = Criteria.WarehouseContainerNameDestination;
            dateTimePickerFilterDateCreationBegin.Value = Criteria.DateCreationBegin ?? CommonLibs.DatesLib.GetFirstDayOfMonth();
            dateTimePickerFilterDateCreationBegin.Checked = Criteria.DateCreationBegin != null;
            dateTimePickerFilterDateCreationEnd.Value = Criteria.DateCreationEnd ?? DateTime.Now;
            dateTimePickerFilterDateCreationEnd.Checked = Criteria.DateCreationEnd != null;

            base.LoadFieldsFromFilter();
        }

        protected override void SaveFieldsToFilter()
        {
            Criteria.ClientId = selectBoxFilterClient.GetSelectedId();
            Criteria.WarehouseId = selectBoxFilterWarehouse.GetSelectedId();
            Criteria.ProductId = selectBoxFilterProduct.GetSelectedId();
            Criteria.PackageCode = textBoxFilterPackageCode.Text.Trim();
            Criteria.WarehouseContainerNameSource = textBoxFilterWarehouseContainerNameSource.Text.Trim();
            Criteria.WarehouseContainerNameDestination = textBoxFilterWarehouseContainerNameDestination.Text.Trim();
            Criteria.DateCreationBegin = null;
            if (dateTimePickerFilterDateCreationBegin.Checked)
            {
                Criteria.DateCreationBegin = dateTimePickerFilterDateCreationBegin.Value;
            }
            Criteria.DateCreationEnd = null;
            if (dateTimePickerFilterDateCreationEnd.Checked)
            {
                Criteria.DateCreationEnd = dateTimePickerFilterDateCreationEnd.Value;
            }

            base.SaveFieldsToFilter();
        }

        protected override void RefreshEntitiesMaster()
        {
            SaveFieldsToFilter();
            TransferCollection.PopulateGridViewNormal(Criteria, gridViewMaster);
            base.RefreshEntitiesMaster();
        }

        protected override void ShowForm()
        {
            SetFormName(TransferCollection.EntityNamePlural);
            gridViewMaster.SetCustomColumns(TransferCollection.GridViewColumnsNormal);
            base.ShowForm();
        }

        protected override bool CheckIfAllowAddMaster()
        {
            return base.CheckIfAllowAddMaster();
        }

        protected override bool AddMaster()
        {
            return TransferCollection.Add();
        }

        protected override bool CheckIfAllowEditMaster()
        {
            return false;
        }

        protected override bool EditMaster()
        {
            return base.EditMaster();
        }

        protected override bool CheckIfAllowDeleteMaster()
        {
            return true;
        }

        protected override bool DeleteMaster()
        {
            return base.DeleteMaster();
        }

        protected override void ClickContextMenuMasterReports(ToolStripMenuItem menuItemClicked)
        {
            /*if (menuItemClicked == menuItemMasterReportsReceptionNote)
            {
                Reports.ReportReceptionNote.ShowDialog(new Reports.ReportReceptionNoteFilterCriteria { ReceptionId = gridViewMaster.GetSelectedId() });
            }*/
        }

        private void selectBoxFilterClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            Criteria.ClientId = selectBoxFilterClient.GetSelectedId();
            Products.ProductCollection.PopulateSelectBox(new Products.ProductFilterCriteria { ClientId = Criteria.ClientId }, selectBoxFilterProduct, Criteria.ProductId, true);
        }
    }
}
