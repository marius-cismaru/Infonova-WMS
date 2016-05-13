using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sirius.EntityModels.Products
{
    public partial class ProductFormBrowse : CustomControls.EntityFormBrowse
    {
        private EntityModelSirius Model;
        private ProductFilterCriteria Criteria;

        public ProductFormBrowse()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
            VisibleExtraPanels = ExtraPanels.Filter;
            Criteria = new ProductFilterCriteria
            {
                CompanyId = Configuration.Main.LoggedCompanyId
            };
        }

        protected override void LoadFieldsFromFilter()
        {
            Clients.ClientCollection.PopulateSelectBox(new Clients.ClientFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId }, selectBoxFilterClients, Criteria.ClientId, true);
            textBoxFilterCode.Text = Criteria.Code;
            textBoxFilterName.Text = Criteria.Name;
            base.LoadFieldsFromFilter();
        }

        protected override void SaveFieldsToFilter()
        {
            Criteria.ClientId = selectBoxFilterClients.GetSelectedId();
            Criteria.Code = textBoxFilterCode.Text;
            Criteria.Name = textBoxFilterName.Text;
            base.SaveFieldsToFilter();
        }

        protected override void RefreshEntitiesMaster()
        {
            SaveFieldsToFilter();
            ProductCollection.PopulateGridViewNormal(Criteria, gridViewMaster);
            base.RefreshEntitiesMaster();
        }

        protected override void ShowForm()
        {
            SetFormName(ProductCollection.EntityNamePlural);
            gridViewMaster.SetCustomColumns(ProductCollection.GridViewColumnsNormal);
            base.ShowForm();
        }

        protected override bool CheckIfAllowAddMaster()
        {
            return base.CheckIfAllowAddMaster();
        }

        protected override bool AddMaster()
        {
            return ProductCollection.Add();
        }

        protected override bool CheckIfAllowEditMaster()
        {
            return base.CheckIfAllowEditMaster();
        }

        protected override bool EditMaster()
        {
            return ProductCollection.Edit(EntityMasterSelectedId);
        }

        protected override bool CheckIfAllowDeleteMaster()
        {
            return ProductCollection.CheckIfAllowDelete(EntityMasterSelectedId);
        }

        protected override bool DeleteMaster()
        {
            return ProductCollection.Delete(EntityMasterSelectedId);
        }
    }
}
