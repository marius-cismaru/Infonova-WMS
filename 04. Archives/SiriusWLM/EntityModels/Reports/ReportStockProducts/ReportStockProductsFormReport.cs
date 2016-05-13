using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sirius.EntityModels.Reports
{
    public partial class ReportStockProductsFormReport : CustomControls.EntityFormReport
    {
        private EntityModelSirius Model;
        public ReportStockProductsFilterCriteria Criteria;

        public ReportStockProductsFormReport()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
            VisibleExtraPanels = ExtraPanels.Filter;
            Criteria = new ReportStockProductsFilterCriteria
            {
                CompanyId = Configuration.Main.LoggedCompanyId
            };
        }

        protected override void LoadFieldsFromFilter()
        {
            Clients.ClientCollection.PopulateSelectBox(new Clients.ClientFilterCriteria { CompanyId = Criteria.CompanyId }, selectBoxFilterClient, Criteria.ClientId, true);
            Warehouses.WarehouseCollection.PopulateSelectBox(new Warehouses.WarehouseFilterCriteria { CompanyId = Criteria.CompanyId }, selectBoxFilterWarehouse, Criteria.WarehouseId, true);
            dateTimePickerFilterDateExecution.Value = Criteria.DateExecution;
            base.LoadFieldsFromFilter();
        }

        protected override void SaveFieldsToFilter()
        {
            Criteria.ClientId = selectBoxFilterClient.GetSelectedId();
            Criteria.WarehouseId = selectBoxFilterWarehouse.GetSelectedId();
            Criteria.DateExecution = dateTimePickerFilterDateExecution.Value;
            base.SaveFieldsToFilter();
        }

        protected override void RefreshReport()
        {
            SaveFieldsToFilter();
            webBrowser.DocumentText = ReportStockProducts.ToHTML(Model, Criteria);
            base.RefreshReport();
        }

        protected override void ShowForm()
        {
            base.ShowForm();
            SetFormName(ReportStockProducts.Name);
            RefreshReport();
        }
    }
}
