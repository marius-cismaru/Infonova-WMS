using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sirius.EntityModels.ConfigurationVersions
{
    public partial class ConfigurationVersionFormBrowse : CustomControls.EntityFormBrowse
    {
        private EntityModelSirius Model;

        public ConfigurationVersionFormBrowse()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
            VisibleExtraPanels = ExtraPanels.None;
        }

        protected override void RefreshEntitiesMaster()
        {
            ConfigurationVersionCollection.PopulateGridViewNormal(gridViewMaster);
            base.RefreshEntitiesMaster();
        }

        protected override void ShowForm()
        {
            SetFormName(ConfigurationVersionCollection.EntityNamePlural);
            gridViewMaster.SetCustomColumns(ConfigurationVersionCollection.GridViewColumnsNormal);
            base.ShowForm();
        }

        protected override bool CheckIfAllowAddMaster()
        {
            return false;
        }

        protected override bool AddMaster()
        {
            return base.AddMaster();
        }

        protected override bool CheckIfAllowEditMaster()
        {
            return false;
        }

        protected override bool EditMaster()
        {
            return base.EditMaster();
        }

        protected override bool CheckIfAllowDeleteMaster()
        {
            return false;
        }

        protected override bool DeleteMaster()
        {
            return base.DeleteMaster();
        }
    }
}
