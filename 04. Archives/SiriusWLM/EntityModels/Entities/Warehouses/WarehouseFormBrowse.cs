using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sirius.EntityModels.Warehouses
{
    public partial class WarehouseFormBrowse : CustomControls.EntityFormBrowse
    {
        private EntityModelSirius Model;

        public WarehouseFormBrowse()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
            VisibleExtraPanels = ExtraPanels.None;
        }

        protected override void RefreshEntitiesMaster()
        {
            WarehouseCollection.PopulateGridViewNormal(new WarehouseFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId }, gridViewMaster);
            base.RefreshEntitiesMaster();
        }

        protected override void ShowForm()
        {
            SetFormName(WarehouseCollection.EntityNamePlural);
            gridViewMaster.SetCustomColumns(WarehouseCollection.GridViewColumnsNormal);
            base.ShowForm();
        }

        protected override bool CheckIfAllowAddMaster()
        {
            return base.CheckIfAllowAddMaster();
        }

        protected override bool AddMaster()
        {
            return WarehouseCollection.Add();
        }

        protected override bool CheckIfAllowEditMaster()
        {
            return base.CheckIfAllowEditMaster();
        }

        protected override bool EditMaster()
        {
            return WarehouseCollection.Edit(EntityMasterSelectedId);
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
