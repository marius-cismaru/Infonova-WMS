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
    public partial class ReportStockPackagesFormReport : CustomControls.EntityFormReport
    {
        private EntityModelSirius Model;
        public ReportStockPackagesFilterCriteria Criteria;

        public ReportStockPackagesFormReport()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
            VisibleExtraPanels = ExtraPanels.Filter;
            Criteria = new ReportStockPackagesFilterCriteria
            {
                CompanyId = Configuration.Main.LoggedCompanyId
            };
        }

        protected override void LoadFieldsFromFilter()
        {
            Clients.ClientCollection.PopulateSelectBox(new Clients.ClientFilterCriteria { CompanyId = Criteria.CompanyId }, selectBoxFilterClient, Criteria.ClientId, true);
            Warehouses.WarehouseCollection.PopulateSelectBox(new Warehouses.WarehouseFilterCriteria { CompanyId = Criteria.CompanyId }, selectBoxFilterWarehouse, Criteria.WarehouseId, true);
            dateTimePickerFilterDateExecution.Value = Criteria.DateExecution;
            textBoxFilterReceptionNumber.Text = Criteria.ReceptionNumber > 0 ? Criteria.ReceptionNumber.ToString() : string.Empty;
            base.LoadFieldsFromFilter();
        }

        protected override void SaveFieldsToFilter()
        {
            Criteria.ClientId = selectBoxFilterClient.GetSelectedId();
            Criteria.WarehouseId = selectBoxFilterWarehouse.GetSelectedId();
            Criteria.ProductId = selectBoxFilterProduct.GetSelectedId();
            Criteria.DateExecution = dateTimePickerFilterDateExecution.Value;
            int receptionNumber;
            int.TryParse(textBoxFilterReceptionNumber.Text, System.Globalization.NumberStyles.Integer, CultureInfo.InvariantCulture, out receptionNumber);
            Criteria.ReceptionNumber = receptionNumber > 0 ? receptionNumber : 0;
            base.SaveFieldsToFilter();
        }

        protected override void RefreshReport()
        {
            SaveFieldsToFilter();
            webBrowser.DocumentText = ReportStockPackages.ToHTML(Model, Criteria, true);
            base.RefreshReport();
        }

        protected override void ShowForm()
        {
            base.ShowForm();
            SetFormName(ReportStockPackages.Name);
            RefreshReport();
        }

        private void selectBoxFilterClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            Criteria.ClientId = selectBoxFilterClient.GetSelectedId();
            Products.ProductCollection.PopulateSelectBox(new Products.ProductFilterCriteria { ClientId = Criteria.ClientId }, selectBoxFilterProduct, Criteria.ProductId, true);
        }
    }
}
