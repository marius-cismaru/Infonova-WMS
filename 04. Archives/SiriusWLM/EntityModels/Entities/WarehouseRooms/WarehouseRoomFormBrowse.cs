using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sirius.EntityModels.WarehouseRooms
{
    public partial class WarehouseRoomFormBrowse : CustomControls.EntityFormBrowse
    {
        private EntityModelSirius Model;
        private WarehouseRoomFilterCriteria Criteria;

        public WarehouseRoomFormBrowse()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
            VisibleExtraPanels = ExtraPanels.Filter;
            Criteria = new WarehouseRoomFilterCriteria
            {
                CompanyId = Configuration.Main.LoggedCompanyId
            };
        }

        protected override void LoadFieldsFromFilter()
        {
            Warehouses.WarehouseCollection.PopulateSelectBox(new Warehouses.WarehouseFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId }, selectBoxFilterWarehouses, Criteria.WarehouseId, true);
            base.LoadFieldsFromFilter();
        }

        protected override void SaveFieldsToFilter()
        {
            Criteria.WarehouseId = selectBoxFilterWarehouses.GetSelectedId();
            base.SaveFieldsToFilter();
        }

        protected override void RefreshEntitiesMaster()
        {
            SaveFieldsToFilter();
            WarehouseRoomCollection.PopulateGridViewNormal(Criteria, gridViewMaster);
            base.RefreshEntitiesMaster();
        }

        protected override void ShowForm()
        {
            SetFormName(WarehouseRoomCollection.EntityNamePlural);
            gridViewMaster.SetCustomColumns(WarehouseRoomCollection.GridViewColumnsNormal);
            base.ShowForm();
        }

        protected override bool CheckIfAllowAddMaster()
        {
            return base.CheckIfAllowAddMaster();
        }

        protected override bool AddMaster()
        {
            return WarehouseRoomCollection.Add();
        }

        protected override bool CheckIfAllowEditMaster()
        {
            return base.CheckIfAllowEditMaster();
        }

        protected override bool EditMaster()
        {
            return WarehouseRoomCollection.Edit(EntityMasterSelectedId);
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
