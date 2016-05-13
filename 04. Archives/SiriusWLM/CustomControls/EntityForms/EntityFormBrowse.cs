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
    public partial class EntityFormBrowse : Form
    {
        [Flags]
        public enum ExtraPanels
        {
            None = 0,
            Detail = 1 << 0,
            Filter = 1 << 1,
            MasterFooter = 1 << 2,
            DetailDescription = 1 << 3,
            DetailHeader = 1 << 4,
            DetailFooter = 1 << 5,
            AllMain = Detail | Filter
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
            splitContainerMasterDetail.Panel2Collapsed = !((_visibleExtraPanels & ExtraPanels.Detail) == ExtraPanels.Detail);
            panelMasterFooter.Visible = (_visibleExtraPanels & ExtraPanels.MasterFooter) == ExtraPanels.MasterFooter;
            panelDetailDescription.Visible = (_visibleExtraPanels & ExtraPanels.DetailDescription) == ExtraPanels.DetailDescription;
            panelDetailHeader.Visible = (_visibleExtraPanels & ExtraPanels.DetailHeader) == ExtraPanels.DetailHeader;
            panelDetailFooter.Visible = (_visibleExtraPanels & ExtraPanels.DetailFooter) == ExtraPanels.DetailFooter;
        }

        public int EntityMasterSelectedId { get; set; }
        public int EntityDetailSelectedId { get; set; }


        public EntityFormBrowse()
        {
            InitializeComponent();
        }

        public void SetFormName(string entityName)
        {
            Text = "Gestionare " + entityName;
        }

        protected virtual void ShowForm()
        {
            buttonMasterAdd.Enabled = CheckIfAllowAddMaster();
            LoadFieldsFromFilter();
            RefreshEntitiesMaster();
        }

        protected virtual void LoadFieldsFromFilter()
        {
        }

        protected virtual void SaveFieldsToFilter()
        {
        }

        protected virtual void RefreshEntitiesMaster()
        {
            bool enableButtons = gridViewMaster.Rows.Count > 0;
            buttonMasterEdit.Enabled = enableButtons;
            buttonMasterDelete.Enabled = enableButtons;
            buttonMasterView.Enabled = enableButtons;
            buttonMasterExport.Enabled = enableButtons;
            buttonMasterReports.Enabled = enableButtons && (contextMenuStripMasterReports.Items.Count > 0);
            RefreshEntitiesDetail();
        }

        protected virtual void RefreshEntitiesDetail()
        {
        }

        protected virtual bool CheckIfAllowAddMaster()
        {
            return true;
        }

        protected virtual bool AddMaster()
        {
            return true;
        }

        protected virtual bool CheckIfAllowEditMaster()
        {
            return true;
        }

        protected virtual bool EditMaster()
        {
            return true;
        }

        protected virtual bool CheckIfAllowDeleteMaster()
        {
            return false;
        }

        protected virtual bool DeleteMaster()
        {
            return true;
        }

        protected virtual void ClickContextMenuMasterReports(ToolStripMenuItem menuItemClicked)
        {
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void FormBrowse_Shown(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void buttonMasterRefresh_Click(object sender, EventArgs e)
        {
            RefreshEntitiesMaster();
        }

        private void buttonMasterFilter_Click(object sender, EventArgs e)
        {
            buttonMasterRefresh_Click(sender, e);
        }

        private void gridViewMaster_SelectionChanged(object sender, EventArgs e)
        {
            EntityMasterSelectedId = gridViewMaster.GetSelectedId();
            RefreshEntitiesDetail();
        }

        private void gridViewDetail_SelectionChanged(object sender, EventArgs e)
        {
            EntityDetailSelectedId = gridViewDetail.GetSelectedId();
        }

        private void buttonMasterDelete_Click(object sender, EventArgs e)
        {
            if (!CheckIfAllowDeleteMaster())
            {
                MessageBox.Show("Stergerea elementului selectat nu este permisa!", "ATENTIE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Sigur doriti stergerea elementului selectat?", "INTREBARE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (!DeleteMaster())
                    {
                        MessageBox.Show("Nu s-a putut sterge elementul selectat datorita unei erori in baza de date. Incercati din nou.", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    RefreshEntitiesMaster();
                }
            }
        }

        private void buttonMasterAdd_Click(object sender, EventArgs e)
        {
            if (!CheckIfAllowAddMaster())
            {
                MessageBox.Show("Adaugarea unui element nou nu este permisa!", "ATENTIE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (AddMaster())
                {
                    RefreshEntitiesMaster();
                }
            }
        }

        private void buttonMasterEdit_Click(object sender, EventArgs e)
        {
            if (!CheckIfAllowEditMaster())
            {
                MessageBox.Show("Editarea elementului selectat nu este permisa!", "ATENTIE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (EditMaster())
                {
                    RefreshEntitiesMaster();
                }
            }
        }

        private void contextMenuStripMasterReports_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (gridViewMaster.Rows.Count > 0)
            {
                ClickContextMenuMasterReports(e.ClickedItem as ToolStripMenuItem);
            }
        }
    }
}
