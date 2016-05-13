using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sirius.EntityModels.MeasuringUnits
{
    public partial class MeasuringUnitFormBrowse : CustomControls.EntityFormBrowse
    {
        private EntityModelSirius Model;

        public MeasuringUnitFormBrowse()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
            VisibleExtraPanels = ExtraPanels.None;
        }

        protected override void RefreshEntitiesMaster()
        {
            MeasuringUnitCollection.PopulateGridViewNormal(gridViewMaster);
            base.RefreshEntitiesMaster();
        }

        protected override void ShowForm()
        {
            SetFormName(MeasuringUnitCollection.EntityNamePlural);
            gridViewMaster.SetCustomColumns(MeasuringUnitCollection.GridViewColumnsNormal);
            base.ShowForm();
        }

        protected override bool CheckIfAllowAddMaster()
        {
            return base.CheckIfAllowAddMaster();
        }

        protected override bool AddMaster()
        {
            return MeasuringUnitCollection.Add();
        }

        protected override bool CheckIfAllowEditMaster()
        {
            return base.CheckIfAllowEditMaster();
        }

        protected override bool EditMaster()
        {
            return MeasuringUnitCollection.Edit(EntityMasterSelectedId);
        }

        protected override bool CheckIfAllowDeleteMaster()
        {
            return base.CheckIfAllowDeleteMaster();
        }

        protected override bool DeleteMaster()
        {
            return base.DeleteMaster();
        }
    }
}
