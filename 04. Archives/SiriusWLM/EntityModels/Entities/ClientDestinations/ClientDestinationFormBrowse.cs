using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sirius.EntityModels.ClientDestinations
{
    public partial class ClientDestinationFormBrowse : CustomControls.EntityFormBrowse
    {
        private EntityModelSirius Model;
        private ClientDestinationFilterCriteria Criteria;

        public ClientDestinationFormBrowse()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
            VisibleExtraPanels = ExtraPanels.Filter;
            Criteria = new ClientDestinationFilterCriteria
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
            ClientDestinationCollection.PopulateGridViewNormal(Criteria, gridViewMaster);
            base.RefreshEntitiesMaster();
        }

        protected override void ShowForm()
        {
            SetFormName(ClientDestinationCollection.EntityNamePlural);
            gridViewMaster.SetCustomColumns(ClientDestinationCollection.GridViewColumnsNormal);
            base.ShowForm();
        }

        protected override bool CheckIfAllowAddMaster()
        {
            return base.CheckIfAllowAddMaster();
        }

        protected override bool AddMaster()
        {
            return ClientDestinationCollection.Add();
        }

        protected override bool CheckIfAllowEditMaster()
        {
            return base.CheckIfAllowEditMaster();
        }

        protected override bool EditMaster()
        {
            return ClientDestinationCollection.Edit(EntityMasterSelectedId);
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
