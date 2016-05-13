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
    public partial class ReportWarehouseRowOverviewFormReport : CustomControls.EntityFormReport
    {
        private EntityModelSirius Model;
        public ReportWarehouseRowOverviewFilterCriteria Criteria;

        public ReportWarehouseRowOverviewFormReport()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
            VisibleExtraPanels = ExtraPanels.None;
            Criteria = new ReportWarehouseRowOverviewFilterCriteria();
        }

        protected override void LoadFieldsFromFilter()
        {
            base.LoadFieldsFromFilter();
        }

        protected override void SaveFieldsToFilter()
        {
            base.SaveFieldsToFilter();
        }

        protected override void RefreshReport()
        {
            SaveFieldsToFilter();
            webBrowser.DocumentText = ReportWarehouseRowOverview.ToHTML(Model, Criteria);
            base.RefreshReport();
        }

        protected override void ShowForm()
        {
            SetFormName(ReportWarehouseRowOverview.Name);
            RefreshReport();
            base.ShowForm();
        }
    }
}
