using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sirius.EntityModels.WarehouseContainers
{
    public partial class WarehouseContainerFormBrowse : CustomControls.EntityFormBrowse
    {
        private EntityModelSirius Model;
        private WarehouseContainerFilterCriteria Criteria;

        public WarehouseContainerFormBrowse()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
            VisibleExtraPanels = ExtraPanels.Filter;
            Criteria = new WarehouseContainerFilterCriteria
            {
                CompanyId = Configuration.Main.LoggedCompanyId
            };
        }

        protected override void LoadFieldsFromFilter()
        {
            Warehouses.WarehouseCollection.PopulateSelectBox(new Warehouses.WarehouseFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId }, selectBoxFilterWarehouses, Criteria.WarehouseId, true);
            CommonLibs.EnumsLib.PopulateSelectBox<WarehouseContainerFilterCriteria.OptionsIsAvailable>(selectBoxFilterIsAvailable, Criteria.OptionIsAvailable);
            textBoxFilterName.Text = Criteria.Name;
            textBoxFilterRoom.Text = Criteria.Room > 0 ? Criteria.Room.ToString() : "";
            textBoxFilterRow.Text = Criteria.Row > 0 ? Criteria.Row.ToString() : "";
            textBoxFilterInterval.Text = Criteria.Interval > 0 ? Criteria.Interval.ToString() : "";
            textBoxFilterSlot.Text = Criteria.Slot > 0 ? Criteria.Slot.ToString() : "";
            textBoxFilterFloor.Text = Criteria.Floor > 0 ? Criteria.Floor.ToString() : "";

            base.LoadFieldsFromFilter();
        }

        protected override void SaveFieldsToFilter()
        {
            Criteria.WarehouseId = selectBoxFilterWarehouses.GetSelectedId();
            Criteria.OptionIsAvailable = CommonLibs.EnumsLib.GetSelectBoxSelectedEnum<WarehouseContainerFilterCriteria.OptionsIsAvailable>(selectBoxFilterIsAvailable);
            Criteria.Name = textBoxFilterName.Text;
            int intValue;
            int.TryParse(textBoxFilterRoom.Text, out intValue);
            Criteria.Room = intValue;
            int.TryParse(textBoxFilterRow.Text, out intValue);
            Criteria.Row = intValue;
            int.TryParse(textBoxFilterInterval.Text, out intValue);
            Criteria.Interval = intValue;
            int.TryParse(textBoxFilterSlot.Text, out intValue);
            Criteria.Slot = intValue;
            int.TryParse(textBoxFilterFloor.Text, out intValue);
            Criteria.Floor = intValue;

            base.SaveFieldsToFilter();
        }

        protected override void RefreshEntitiesMaster()
        {
            SaveFieldsToFilter();
            WarehouseContainerCollection.PopulateGridViewNormal(Criteria, gridViewMaster);
            base.RefreshEntitiesMaster();
        }

        protected override void ShowForm()
        {
            SetFormName(WarehouseContainerCollection.EntityNamePlural);
            gridViewMaster.SetCustomColumns(WarehouseContainerCollection.GridViewColumnsNormal);
            base.ShowForm();
        }

        protected override bool CheckIfAllowAddMaster()
        {
            return base.CheckIfAllowAddMaster();
        }

        protected override bool AddMaster()
        {
            return WarehouseContainerCollection.Add();
        }

        protected override bool CheckIfAllowEditMaster()
        {
            return base.CheckIfAllowEditMaster();
        }

        protected override bool EditMaster()
        {
            return WarehouseContainerCollection.Edit(EntityMasterSelectedId);
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
