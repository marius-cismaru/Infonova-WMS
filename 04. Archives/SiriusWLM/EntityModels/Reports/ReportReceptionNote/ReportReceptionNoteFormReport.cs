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
    public partial class ReportReceptionNoteFormReport : CustomControls.EntityFormReport
    {
        private EntityModelSirius Model;
        public ReportReceptionNoteFilterCriteria Criteria;

        public ReportReceptionNoteFormReport()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
            VisibleExtraPanels = ExtraPanels.None;
            Criteria = new ReportReceptionNoteFilterCriteria();
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
            webBrowser.DocumentText = ReportReceptionNote.ToHTML(Model, Criteria);
            base.RefreshReport();
        }

        protected override void ShowForm()
        {
            SetFormName(ReportReceptionNote.Name);
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
            var reception = Receptions.ReceptionCollection.GetById(Model, Criteria.ReceptionId, false);
            if (reception != null)
            {
                var company = reception.Client.Company;
                var client = reception.Client;
                result = CommonLibs.EmailLib.Send(company.EmailSendServer, company.EmailSendPort, company.EmailSendEncryption, company.EmailSendAddress, company.EmailSendName, company.EmailSendUsername, company.EmailSendPassword, client.EmailAddressList, null, company.EmailReceiveAddressList, "facturare@radanimpex.ro,gestionari@radanimpex.ro,laurentiu.popescu@radanimpex.ro", ReportReceptionNote.Name + " nr. " + reception.ToString(), ReportReceptionNote.ToHTML(Model, Criteria), null);
            }
            return result;
        }
    }
}
