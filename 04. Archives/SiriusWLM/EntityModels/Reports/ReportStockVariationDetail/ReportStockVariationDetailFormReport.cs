using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Sirius.EntityModels.Reports
{
    public partial class ReportStockVariationDetailFormReport : CustomControls.EntityFormReport
    {
        private EntityModelSirius Model;
        public ReportStockVariationDetailFilterCriteria Criteria;

        public ReportStockVariationDetailFormReport()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
            VisibleExtraPanels = ExtraPanels.Filter;
        }

        protected override void LoadFieldsFromFilter()
        {
            Clients.ClientCollection.PopulateSelectBox(new Clients.ClientFilterCriteria { CompanyId = Criteria.CompanyId }, selectBoxFilterClient, Criteria.ClientId, true);
            Warehouses.WarehouseCollection.PopulateSelectBox(new Warehouses.WarehouseFilterCriteria { CompanyId = Criteria.CompanyId }, selectBoxFilterWarehouse, Criteria.WarehouseId, true);
            dateTimePickerFilterDateExecutionBegin.Value = Criteria.DateExecutionBegin ?? CommonLibs.DatesLib.GetFirstDayOfMonth();
            dateTimePickerFilterDateExecutionBegin.Checked = Criteria.DateExecutionBegin.HasValue;
            dateTimePickerFilterDateExecutionEnd.Value = Criteria.DateExecutionEnd ?? DateTime.Now;
            dateTimePickerFilterDateExecutionEnd.Checked = Criteria.DateExecutionEnd.HasValue;

            base.LoadFieldsFromFilter();
        }

        protected override void SaveFieldsToFilter()
        {
            Criteria.ClientId = selectBoxFilterClient.GetSelectedId();
            Criteria.WarehouseId = selectBoxFilterWarehouse.GetSelectedId();
            Criteria.ProductId = selectBoxFilterProduct.GetSelectedId();
            Criteria.DateExecutionBegin = null;
            if (dateTimePickerFilterDateExecutionBegin.Checked)
            {
                Criteria.DateExecutionBegin = dateTimePickerFilterDateExecutionBegin.Value;
            }
            Criteria.DateExecutionEnd = null;
            if (dateTimePickerFilterDateExecutionEnd.Checked)
            {
                Criteria.DateExecutionEnd = dateTimePickerFilterDateExecutionEnd.Value;
            }

            base.SaveFieldsToFilter();
        }

        protected override void RefreshReport()
        {
            SaveFieldsToFilter();
            webBrowser.DocumentText = ReportStockVariationDetail.ToHTML(Model, Criteria, true, true);
            base.RefreshReport();
        }

        protected override void ShowForm()
        {
            base.ShowForm();
            SetFormName(ReportStockVariationDetail.Name);
            RefreshReport();
        }

        private void selectBoxFilterClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            Criteria.ClientId = selectBoxFilterClient.GetSelectedId();
            Products.ProductCollection.PopulateSelectBox(new Products.ProductFilterCriteria { ClientId = Criteria.ClientId }, selectBoxFilterProduct, Criteria.ProductId, true);
        }
    }
}
