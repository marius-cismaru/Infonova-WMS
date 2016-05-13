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
    public partial class EntityFormEdit : Form
    {
        public int EntityId { get; set; }
        protected object Entity { get; set; }

        public EntityFormEdit()
        {
            InitializeComponent();
        }

        protected virtual void SetFormName(string entityName)
        {
            Text = (EntityId == 0 ? ("Adaugare " + entityName) : ("Editare " + entityName + " " + Entity.ToString()));
        }

        public virtual void LoadFieldsFromEntity()
        {
        }

        public virtual bool SaveFieldsToEntity()
        {
            return true;
        }

        public virtual string ValidateAllFields()
        {
            return "";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string errors = ValidateAllFields();
            if (errors != "")
            {
                MessageBox.Show("Introducere eronata a datelor\nLista erori editare " + errors, "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (SaveFieldsToEntity())
                {
                    DialogResult = DialogResult.OK;
                }
            }
        }

        public virtual void FormEdit_Shown(object sender, EventArgs e)
        {
            LoadFieldsFromEntity();
        }
    }
}
