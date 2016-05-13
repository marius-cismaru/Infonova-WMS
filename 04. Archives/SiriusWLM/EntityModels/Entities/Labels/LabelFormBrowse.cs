using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sirius.EntityModels.Labels
{
    public partial class LabelFormBrowse : CustomControls.EntityFormBrowse
    {
        private EntityModelSirius Model;

        public LabelFormBrowse()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
            VisibleExtraPanels = ExtraPanels.None;
        }

        protected override void RefreshEntitiesMaster()
        {
            LabelCollection.PopulateGridViewNormal(gridViewMaster);
            base.RefreshEntitiesMaster();
        }

        protected override void ShowForm()
        {
            SetFormName(LabelCollection.EntityNamePlural);
            gridViewMaster.SetCustomColumns(LabelCollection.GridViewColumnsNormal);
            base.ShowForm();
        }

        protected override bool CheckIfAllowAddMaster()
        {
            return base.CheckIfAllowAddMaster();
        }

        protected override bool AddMaster()
        {
            return LabelCollection.Add();
        }

        protected override bool CheckIfAllowEditMaster()
        {
            return base.CheckIfAllowEditMaster();
        }

        protected override bool EditMaster()
        {
            return LabelCollection.Edit(EntityMasterSelectedId);
        }

        protected override bool CheckIfAllowDeleteMaster()
        {
            return LabelCollection.CheckIfExistsById(EntityMasterSelectedId);
        }

        protected override bool DeleteMaster()
        {
            return LabelCollection.Delete(EntityMasterSelectedId);
        }
    }
}
