using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sirius.EntityModels.ClientUsers
{
    public partial class ClientUserFormBrowse : CustomControls.EntityFormBrowse
    {
        private EntityModelSirius Model;
        private ClientUserFilterCriteria Criteria;

        public ClientUserFormBrowse()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
            VisibleExtraPanels = ExtraPanels.Filter;
            Criteria = new ClientUserFilterCriteria
            {
                CompanyId = Configuration.Main.LoggedCompanyId
            };
        }

        protected override void LoadFieldsFromFilter()
        {
            Clients.ClientCollection.PopulateSelectBox(new Clients.ClientFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId }, selectBoxFilterClients, Criteria.ClientId, true);
            textBoxFilterName.Text = Criteria.Name;
            base.LoadFieldsFromFilter();
        }

        protected override void SaveFieldsToFilter()
        {
            Criteria.ClientId = selectBoxFilterClients.GetSelectedId();
            Criteria.Name = textBoxFilterName.Text;
            base.SaveFieldsToFilter();
        }

        protected override void RefreshEntitiesMaster()
        {
            SaveFieldsToFilter();
            ClientUserCollection.PopulateGridViewNormal(Criteria, gridViewMaster);
            base.RefreshEntitiesMaster();
        }

        protected override void ShowForm()
        {
            SetFormName(ClientUserCollection.EntityNamePlural);
            gridViewMaster.SetCustomColumns(ClientUserCollection.GridViewColumnsNormal);
            base.ShowForm();
        }

        protected override bool CheckIfAllowAddMaster()
        {
            return base.CheckIfAllowAddMaster();
        }

        protected override bool AddMaster()
        {
            return ClientUserCollection.Add();
        }

        protected override bool CheckIfAllowEditMaster()
        {
            return base.CheckIfAllowEditMaster();
        }

        protected override bool EditMaster()
        {
            return ClientUserCollection.Edit(EntityMasterSelectedId);
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
