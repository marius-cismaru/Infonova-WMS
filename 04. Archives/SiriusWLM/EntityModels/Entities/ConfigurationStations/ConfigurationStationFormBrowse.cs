using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sirius.EntityModels.ConfigurationStations
{
    public partial class ConfigurationStationFormBrowse : CustomControls.EntityFormBrowse
    {
        private EntityModelSirius Model;

        public ConfigurationStationFormBrowse()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
            VisibleExtraPanels = ExtraPanels.None;
        }

        protected override void RefreshEntitiesMaster()
        {
            ConfigurationStationCollection.PopulateGridViewNormal(gridViewMaster);
            base.RefreshEntitiesMaster();
        }

        protected override void ShowForm()
        {
            SetFormName(ConfigurationStationCollection.EntityNamePlural);
            gridViewMaster.SetCustomColumns(ConfigurationStationCollection.GridViewColumnsNormal);
            base.ShowForm();
        }

        protected override bool CheckIfAllowAddMaster()
        {
            return !ConfigurationStations.ConfigurationStationCollection.CheckIfExistsByStationName(CommonLibs.ActiveDirectoryLib.GetWindowsStationName());
        }

        protected override bool AddMaster()
        {
            return ConfigurationStationCollection.Add();
        }

        protected override bool CheckIfAllowEditMaster()
        {
            return base.CheckIfAllowEditMaster();
        }

        protected override bool EditMaster()
        {
            return ConfigurationStationCollection.Edit(EntityMasterSelectedId);
        }

        protected override bool CheckIfAllowDeleteMaster()
        {
            return ConfigurationStationCollection.CheckIfExistsById(EntityMasterSelectedId);
        }

        protected override bool DeleteMaster()
        {
            return ConfigurationStationCollection.Delete(EntityMasterSelectedId);
        }
    }
}
