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
    public partial class ReportDeliveryPickingListFormReport : CustomControls.EntityFormReport
    {
        //private EntityModelSirius Model;
        public ReportDeliveryPickingListFilterCriteria Criteria;

        public ReportDeliveryPickingListFormReport()
        {
            InitializeComponent();
            //Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
            VisibleExtraPanels = ExtraPanels.None;
            Criteria = new ReportDeliveryPickingListFilterCriteria();
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
            webBrowser.DocumentText = ReportDeliveryPickingList.ToHTML(Criteria);
            base.RefreshReport();
        }

        protected override void ShowForm()
        {
            base.ShowForm();
            SetFormName(ReportDeliveryPickingList.Name);
            RefreshReport();
        }

        protected override bool CheckIfAllowSendEmailClient()
        {
            return true;
        }

        protected override bool SendEmailClient()
        {
            bool result = false;
            var delivery = Criteria.Delivery;
            if (delivery != null)
            {
                var company = delivery.Client.Company;
                var client = delivery.Client;
                result = CommonLibs.EmailLib.Send(company.EmailSendServer, company.EmailSendPort, company.EmailSendEncryption, company.EmailSendAddress, company.EmailSendName, company.EmailSendUsername, company.EmailSendPassword, client.EmailAddressList, null, company.EmailReceiveAddressList, "facturare@radanimpex.ro,gestionari@radanimpex.ro,laurentiu.popescu@radanimpex.ro", ReportDeliveryPickingList.Name + " nr. " + delivery.ToString(), ReportDeliveryPickingList.ToHTML(Criteria), null);
            }
            return result;
        }
    }
}
