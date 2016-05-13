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
    public partial class ReportDeliveryNoticeFormReport : CustomControls.EntityFormReport
    {
        private EntityModelSirius Model;
        public ReportDeliveryNoticeFilterCriteria Criteria;

        public ReportDeliveryNoticeFormReport()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
            VisibleExtraPanels = ExtraPanels.None;
            Criteria = new ReportDeliveryNoticeFilterCriteria();
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
            webBrowser.DocumentText = ReportDeliveryNotice.ToHTML(Model, Criteria);
            base.RefreshReport();
        }

        protected override void ShowForm()
        {
            SetFormName(ReportDeliveryNotice.Name);
            RefreshReport();
            base.ShowForm();
        }

        protected override bool CheckIfAllowSendEmailClient()
        {
            return true;
        }

        protected override bool SendEmailClient()
        {
            bool result = false;
            var delivery = Deliveries.DeliveryCollection.GetById(Model, Criteria.DeliveryId, false);
            if (delivery != null)
            {
                var company = delivery.Client.Company;
                var client = delivery.Client;
                result = CommonLibs.EmailLib.Send(company.EmailSendServer, company.EmailSendPort, company.EmailSendEncryption, company.EmailSendAddress, company.EmailSendName, company.EmailSendUsername, company.EmailSendPassword, client.EmailAddressList, null, company.EmailReceiveAddressList, "facturare@radanimpex.ro,gestionari@radanimpex.ro,laurentiu.popescu@radanimpex.ro", ReportDeliveryNotice.Name + " nr. " + delivery.ToString(), ReportDeliveryNotice.ToHTML(Model, Criteria), null);
            }
            return result;
        }
    }
}
