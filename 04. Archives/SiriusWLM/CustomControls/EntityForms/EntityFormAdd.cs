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
    public partial class EntityFormAdd : Form
    {
        protected object Entity { get; set; }

        public EntityFormAdd()
        {
            InitializeComponent();
        }

        protected virtual void ShowForm()
        {
        }

        protected virtual void SetFormName(string entityName)
        {
            Text = "Adaugare " + entityName;
        }

        protected void SetHeaderDescription()
        {
            labelHeaderDescription.Text = tabControlWizard.SelectedTab.Text;
        }

        protected virtual bool FinishWizard()
        {
            return true;
        }

        protected virtual bool CancelWizard()
        {
            return true;
        }

        protected virtual bool PreviousPageWizard()
        {
            return true;
        }

        protected virtual bool NextPageWizard()
        {
            return true;
        }

        protected virtual void ChangedPageWizard()
        {
        }

        protected virtual void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tabControlWizard_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetHeaderDescription();
            buttonPrevious.Enabled = !(tabControlWizard.SelectedIndex == 0);
            buttonNext.Enabled = !(tabControlWizard.SelectedIndex == (tabControlWizard.TabPages.Count - 1));
            buttonFinish.Enabled = !buttonNext.Enabled;
            ChangedPageWizard();
        }

        private void FormAdd_Shown(object sender, EventArgs e)
        {
            ShowForm();
            tabControlWizard.SelectedIndex = 0;
            tabControlWizard_SelectedIndexChanged(null, null);
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (PreviousPageWizard())
            {
                if (tabControlWizard.SelectedIndex > 0)
                {
                    tabControlWizard.SelectedIndex--;
                }
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (NextPageWizard())
            {
                if (tabControlWizard.SelectedIndex < (tabControlWizard.TabCount - 1))
                {
                    tabControlWizard.SelectedIndex++;
                }
            }
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            if (FinishWizard())
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }

        private void EntityFormAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != System.Windows.Forms.DialogResult.OK)
            {
                if (MessageBox.Show("Esti sigur ca doresti sa parasesti activitatea?", "INTREBARE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (CancelWizard())
                    {
                        DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    }
                    else
                    {
                        DialogResult = System.Windows.Forms.DialogResult.None;
                    }
                }
                else
                {
                    DialogResult = System.Windows.Forms.DialogResult.None;
                }
            }
        }
    }
}
