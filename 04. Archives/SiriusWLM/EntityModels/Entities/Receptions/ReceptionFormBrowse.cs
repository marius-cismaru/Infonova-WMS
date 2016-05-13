using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Sirius.EntityModels.Receptions
{
    public partial class ReceptionFormBrowse : CustomControls.EntityFormBrowse
    {
        private EntityModelSirius Model;
        private ReceptionFilterCriteria Criteria;

        //Context Menu Master Reports
        private ToolStripMenuItem menuItemMasterReportsReceptionNote;

        public ReceptionFormBrowse()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
            VisibleExtraPanels = ExtraPanels.Filter | ExtraPanels.Detail | ExtraPanels.DetailDescription;
            labelDetailDescription.Text = "Lista articole";
            Criteria = new ReceptionFilterCriteria
            {
                CompanyId = Configuration.Main.LoggedCompanyId
            };
            //Context Menu Master Reports
            menuItemMasterReportsReceptionNote = new ToolStripMenuItem("Nota de receptie");
            contextMenuStripMasterReports.Items.Add(menuItemMasterReportsReceptionNote);
        }

        protected override void LoadFieldsFromFilter()
        {
            Clients.ClientCollection.PopulateSelectBox(new Clients.ClientFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId }, selectBoxFilterClient, Criteria.ClientId, true);
            Warehouses.WarehouseCollection.PopulateSelectBox(new Warehouses.WarehouseFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId }, selectBoxFilterWarehouse, Criteria.WarehouseId, true);
            textBoxFilterNumber.Text = Criteria.Number > 0 ? Criteria.Number.ToString() : string.Empty;
            dateTimePickerFilterDateCreationBegin.Value = Criteria.DateCreationBegin ?? CommonLibs.DatesLib.GetFirstDayOfMonth();
            dateTimePickerFilterDateCreationBegin.Checked = Criteria.DateCreationBegin.HasValue;
            dateTimePickerFilterDateCreationEnd.Value = Criteria.DateCreationEnd ?? DateTime.Now;
            dateTimePickerFilterDateCreationEnd.Checked = Criteria.DateCreationEnd.HasValue;

            base.LoadFieldsFromFilter();
        }

        protected override void SaveFieldsToFilter()
        {
            Criteria.ClientId = selectBoxFilterClient.GetSelectedId();
            Criteria.WarehouseId = selectBoxFilterWarehouse.GetSelectedId();
            int number;
            int.TryParse(textBoxFilterNumber.Text, System.Globalization.NumberStyles.Integer, CultureInfo.InvariantCulture, out number);
            Criteria.Number = number > 0 ? number : 0;
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
            ReceptionCollection.PopulateGridViewNormal(Criteria, gridViewMaster);
            base.RefreshEntitiesMaster();
        }

        protected override void RefreshEntitiesDetail()
        {
            Reception reception = ReceptionCollection.GetById(Model, gridViewMaster.GetSelectedId(), false);
            if (reception != null)
            {
                ReceptionProducts.ReceptionProductCollection.PopulateGridViewNormal(new ReceptionProducts.ReceptionProductFilterCriteria { ReceptionId = reception.Id }, gridViewDetail);
            }
            else
            {
                gridViewDetail.Rows.Clear();
            }
            base.RefreshEntitiesDetail();
        }

        protected override void ShowForm()
        {
            SetFormName(ReceptionCollection.EntityNamePlural);
            gridViewMaster.SetCustomColumns(ReceptionCollection.GridViewColumnsNormal);
            gridViewDetail.SetCustomColumns(ReceptionProducts.ReceptionProductCollection.GridViewColumnsNormal);
            base.ShowForm();
        }

        protected override bool CheckIfAllowAddMaster()
        {
            return base.CheckIfAllowAddMaster();
        }

        protected override bool AddMaster()
        {
            return ReceptionCollection.Add();
        }

        protected override bool CheckIfAllowEditMaster()
        {
            return base.CheckIfAllowEditMaster();
        }

        protected override bool EditMaster()
        {
            return ReceptionCollection.Edit(EntityMasterSelectedId);
        }

        protected override bool CheckIfAllowDeleteMaster()
        {
            return base.CheckIfAllowDeleteMaster();
        }

        protected override bool DeleteMaster()
        {
            return base.DeleteMaster();
        }

        protected override void ClickContextMenuMasterReports(ToolStripMenuItem menuItemClicked)
        {
            if (menuItemClicked == menuItemMasterReportsReceptionNote)
            {
                Reports.ReportReceptionNote.ShowDialog(new Reports.ReportReceptionNoteFilterCriteria { ReceptionId = gridViewMaster.GetSelectedId() });
            }
        }
    }
}
