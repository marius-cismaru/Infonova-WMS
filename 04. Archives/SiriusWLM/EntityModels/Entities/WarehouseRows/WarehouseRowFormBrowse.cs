using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sirius.EntityModels.WarehouseRows
{
    public partial class WarehouseRowFormBrowse : CustomControls.EntityFormBrowse
    {
        private EntityModelSirius Model;
        private WarehouseRowFilterCriteria Criteria;

        public WarehouseRowFormBrowse()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
            VisibleExtraPanels = ExtraPanels.Filter;
            Criteria = new WarehouseRowFilterCriteria
            {
                CompanyId = Configuration.Main.LoggedCompanyId
            };
        }

        protected override void LoadFieldsFromFilter()
        {
            Warehouses.WarehouseCollection.PopulateSelectBox(new Warehouses.WarehouseFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId }, selectBoxFilterWarehouse, Criteria.WarehouseId, true);
            CommonLibs.EnumsLib.PopulateSelectBox<WarehouseRowFilterCriteria.OptionsIsLimited>(selectBoxFilterIsLimited, Criteria.OptionIsLimited);

            base.LoadFieldsFromFilter();
        }

        protected override void SaveFieldsToFilter()
        {
            Criteria.WarehouseId = selectBoxFilterWarehouse.GetSelectedId();
            Criteria.WarehouseRoomId = selectBoxFilterWarehouseRoom.GetSelectedId();
            Criteria.OptionIsLimited =  CommonLibs.EnumsLib.GetSelectBoxSelectedEnum<WarehouseRowFilterCriteria.OptionsIsLimited>(selectBoxFilterIsLimited);

            base.SaveFieldsToFilter();
        }

        protected override void RefreshEntitiesMaster()
        {
            SaveFieldsToFilter();
            WarehouseRowCollection.PopulateGridViewNormal(Criteria, gridViewMaster);
            base.RefreshEntitiesMaster();
        }

        protected override void ShowForm()
        {
            SetFormName(WarehouseRowCollection.EntityNamePlural);
            gridViewMaster.SetCustomColumns(WarehouseRowCollection.GridViewColumnsNormal);
            base.ShowForm();
        }

        protected override bool CheckIfAllowAddMaster()
        {
            return base.CheckIfAllowAddMaster();
        }

        protected override bool AddMaster()
        {
            return WarehouseRowCollection.Add();
        }

        protected override bool CheckIfAllowEditMaster()
        {
            return base.CheckIfAllowEditMaster();
        }

        protected override bool EditMaster()
        {
            return WarehouseRowCollection.Edit(EntityMasterSelectedId);
        }

        protected override bool CheckIfAllowDeleteMaster()
        {
            return base.CheckIfAllowDeleteMaster();
        }

        protected override bool DeleteMaster()
        {
            return base.DeleteMaster();
        }

        private void selectBoxFilterWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            WarehouseRooms.WarehouseRoomCollection.PopulateSelectBox(new WarehouseRooms.WarehouseRoomFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId, WarehouseId = selectBoxFilterWarehouse.GetSelectedId() }, selectBoxFilterWarehouseRoom, 0, true);
        }
    }
}
