using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Sirius.EntityModels.Deliveries
{
    public partial class DeliveryFormBrowse : CustomControls.EntityFormBrowse
    {
        private EntityModelSirius Model;
        private DeliveryFilterCriteria Criteria;

        //Context Menu Master Reports
        private ToolStripMenuItem menuItemMasterReportsDeliveryNotice;
        private ToolStripMenuItem menuItemMasterReportsDeliveryPickingList;

        public DeliveryFormBrowse()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
            VisibleExtraPanels = ExtraPanels.Filter | ExtraPanels.Detail | ExtraPanels.DetailDescription;
            labelDetailDescription.Text = DeliveryProducts.DeliveryProductCollection.EntityNamePlural;
            Criteria = new DeliveryFilterCriteria
            {
                CompanyId = Configuration.Main.LoggedCompanyId
            };
            //Context Menu Master Reports
            menuItemMasterReportsDeliveryNotice = new ToolStripMenuItem("Aviz de insotire a marfii");
            contextMenuStripMasterReports.Items.Add(menuItemMasterReportsDeliveryNotice);
            menuItemMasterReportsDeliveryPickingList = new ToolStripMenuItem("Lista culegere pachete");
            contextMenuStripMasterReports.Items.Add(menuItemMasterReportsDeliveryPickingList);
        }

        protected override void LoadFieldsFromFilter()
        {
            Clients.ClientCollection.PopulateSelectBox(new Clients.ClientFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId }, selectBoxFilterClients, Criteria.ClientId, true);
            Warehouses.WarehouseCollection.PopulateSelectBox(new Warehouses.WarehouseFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId }, selectBoxFilterWarehouses, Criteria.WarehouseId, true);
            textBoxFilterNumber.Text = Criteria.Number > 0 ? Criteria.Number.ToString() : string.Empty;
            dateTimePickerFilterDateCreationBegin.Value = Criteria.DateCreationBegin ?? CommonLibs.DatesLib.GetFirstDayOfMonth();
            dateTimePickerFilterDateCreationBegin.Checked = Criteria.DateCreationBegin != null;
            dateTimePickerFilterDateCreationEnd.Value = Criteria.DateCreationEnd ?? DateTime.Now;
            dateTimePickerFilterDateCreationEnd.Checked = Criteria.DateCreationEnd != null;
            textBoxFilterOutputOrderNumber.Text = Criteria.OrderNumber;

            base.LoadFieldsFromFilter();
        }

        protected override void SaveFieldsToFilter()
        {
            Criteria.ClientId = selectBoxFilterClients.GetSelectedId();
            Criteria.WarehouseId = selectBoxFilterWarehouses.GetSelectedId();
            int number;
            int.TryParse(textBoxFilterNumber.Text, System.Globalization.NumberStyles.Integer, CultureInfo.InvariantCulture, out number);
            Criteria.Number = number;
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
            Criteria.OrderNumber = textBoxFilterOutputOrderNumber.Text;

            base.SaveFieldsToFilter();
        }

        protected override void RefreshEntitiesMaster()
        {
            SaveFieldsToFilter();
            DeliveryCollection.PopulateGridViewNormal(Criteria, gridViewMaster);
            base.RefreshEntitiesMaster();
        }

        protected override void RefreshEntitiesDetail()
        {
            Delivery delivery = DeliveryCollection.GetById(Model, EntityMasterSelectedId, false);
            if (delivery != null)
            {
                DeliveryProducts.DeliveryProductCollection.PopulateGridViewNormal(new DeliveryProducts.DeliveryProductFilterCriteria { DeliveryId = delivery.Id }, gridViewDetail);
            }
            else
            {
                gridViewDetail.Rows.Clear();
            }
            base.RefreshEntitiesDetail();
        }

        protected override void ShowForm()
        {
            SetFormName(DeliveryCollection.EntityNamePlural);
            gridViewMaster.SetCustomColumns(DeliveryCollection.GridViewColumnsNormal);
            gridViewDetail.SetCustomColumns(DeliveryProducts.DeliveryProductCollection.GridViewColumnsNormal);
            base.ShowForm();
        }

        protected override bool CheckIfAllowAddMaster()
        {
            return base.CheckIfAllowAddMaster();
        }

        protected override bool AddMaster()
        {
            return DeliveryCollection.Add();
        }

        protected override bool CheckIfAllowEditMaster()
        {
            return base.CheckIfAllowEditMaster();
        }

        protected override bool EditMaster()
        {
            return DeliveryCollection.Edit(EntityMasterSelectedId);
        }

        protected override bool CheckIfAllowDeleteMaster()
        {
            return true;
        }

        protected override bool DeleteMaster()
        {
            return Deliveries.DeliveryCollection.Delete(EntityMasterSelectedId);
        }

        protected override void ClickContextMenuMasterReports(ToolStripMenuItem menuItemClicked)
        {
            if (menuItemClicked == menuItemMasterReportsDeliveryNotice)
            {
                Reports.ReportDeliveryNotice.ShowDialog(new Reports.ReportDeliveryNoticeFilterCriteria { DeliveryId = gridViewMaster.GetSelectedId() });
            }
            if (menuItemClicked == menuItemMasterReportsDeliveryPickingList)
            {
                Delivery delivery = Deliveries.DeliveryCollection.GetById(Model, EntityMasterSelectedId, false);
                if (delivery != null)
                {
                    Reports.ReportDeliveryPickingList.ShowDialog(new Reports.ReportDeliveryPickingListFilterCriteria { Delivery = delivery, PackageList = delivery.Packages.ToList() });
                }           
            }
        }
    }
}
