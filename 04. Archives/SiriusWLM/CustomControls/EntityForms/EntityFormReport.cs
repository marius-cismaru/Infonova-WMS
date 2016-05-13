using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sirius.CustomControls
{
    public partial class EntityFormReport : Form
    {
        [Flags]
        public enum ExtraPanels
        {
            None = 0,
            Filter = 1 << 0,
        }

        private ExtraPanels _visibleExtraPanels;

        public ExtraPanels VisibleExtraPanels
        {
            get
            {
                return _visibleExtraPanels;
            }
            set
            {
                _visibleExtraPanels = value;
                SetVisibleExtraPanels();
            }
        }

        private void SetVisibleExtraPanels()
        {
            splitContainerFilter.Panel1Collapsed = !((_visibleExtraPanels & ExtraPanels.Filter) == ExtraPanels.Filter);
        }

        public EntityFormReport()
        {
            InitializeComponent();
        }

        public void SetFormName(string name)
        {
            Text = "Raport - " + name;
        }

        protected virtual void ShowForm()
        {
            buttonSendEmailClient.Enabled = CheckIfAllowSendEmailClient();
            LoadFieldsFromFilter();
        }

        protected virtual void LoadFieldsFromFilter()
        {
        }

        protected virtual void SaveFieldsToFilter()
        {
        }

        protected virtual void RefreshReport()
        {
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void FormReport_Shown(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshReport();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            buttonRefresh_Click(sender, e);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            webBrowser.ShowPrintDialog();
        }

        private void buttonPrintPreview_Click(object sender, EventArgs e)
        {
            webBrowser.ShowPrintPreviewDialog();
        }

        private void buttonPageConfiguration_Click(object sender, EventArgs e)
        {
            webBrowser.ShowPageSetupDialog();
        }

        protected virtual bool CheckIfAllowSendEmailClient()
        {
            return false;
        }

        protected virtual bool SendEmailClient()
        {
            return true;
        }

        private void buttonSendEmailClient_Click(object sender, EventArgs e)
        {
            if (!CheckIfAllowSendEmailClient())
            {
                MessageBox.Show("Trimiterea pe email catre client nu este permisa!", "ATENTIE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (SendEmailClient())
                {
                    MessageBox.Show("Mesajul a fost trimis pe email catre client", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Eroare la trimiterea mesajului pe email catre client. Verificati:" + Environment.NewLine + "- conexiunea la retea" + Environment.NewLine + "- configuratia server-ului email trimitere" + Environment.NewLine + "- configuratia adreselor email client" + Environment.NewLine + Environment.NewLine + "Anuntati administratorul IT", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
