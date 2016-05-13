using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sirius.CommonLibs;

namespace Sirius.EntityModels.Clients
{
    public partial class ClientFormEdit : CustomControls.EntityFormEdit
    {
        private EntityModelSirius Model;
        private new Client Entity {
            get { return base.Entity as Client; }
            set { base.Entity = value; }
        }

        public ClientFormEdit()
            : base()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
        }

        private void RefreshProducts()
        {
            Products.ProductCollection.PopulateGridViewNormal(new Products.ProductFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId, ClientId = Entity.Id }, gridViewProducts);
        }

        private void RefreshDestinations()
        {
            ClientDestinations.ClientDestinationCollection.PopulateGridViewNormal(new ClientDestinations.ClientDestinationFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId, ClientId = Entity.Id }, gridViewDestinations);
        }

        public override void FormEdit_Shown(object sender, EventArgs e)
        {
            Entity = ClientCollection.GetById(Model, EntityId, true);
            SetFormName(ClientCollection.EntityNameSingular);
            gridViewProducts.SetCustomColumns(Products.ProductCollection.GridViewColumnsNormal);
            gridViewDestinations.SetCustomColumns(ClientDestinations.ClientDestinationCollection.GridViewColumnsNormal);
            if (EntityId == 0)
            {
                tabControlMain.TabPages.Remove(tabPageProducts);
                tabControlMain.TabPages.Remove(tabPageDestinations);
                tabControlMain.TabPages.Remove(tabPageEmailSendReports);
            }
            base.FormEdit_Shown(sender, e);
        }

        public override void LoadFieldsFromEntity()
        {
            textBoxCompany.Text = Configuration.Main.LoggedCompanyNameShort;
            textBoxNameLong.Text = Entity.NameLong;
            textBoxNameShort.Text = Entity.NameShort;
            textBoxNameSymbol3.Text = Entity.NameSymbol3;
            textBoxNameSymbol1.Text = Entity.NameSymbol1;
            textBoxNumberRegistry.Text = Entity.NumberRegistry;
            textBoxNumberFiscal.Text = Entity.NumberFiscal;
            textBoxAddress.Text = Entity.Address;
            textBoxEmailAddressList.Text = Entity.EmailAddressList;
            Countries.CountryCollection.PopulateSelectBox(selectBoxCountry, Entity.Country != null ? Entity.Country.Id : 0, false);
            RefreshProducts();
            RefreshDestinations();
            checkBoxEmailSendReportStock.Checked = Entity.IsEmailSendReportStock;
        }

        public override bool SaveFieldsToEntity()
        {
            Entity.NameLong = textBoxNameLong.Text.Trim();
            Entity.NameShort = textBoxNameShort.Text.Trim();
            Entity.NameSymbol3 = textBoxNameSymbol3.Text.Trim().ToUpper().Left(3);
            Entity.NameSymbol1 = textBoxNameSymbol1.Text.Trim().ToUpper().Left(1);
            Entity.NumberRegistry = textBoxNumberRegistry.Text;
            Entity.NumberFiscal = textBoxNumberFiscal.Text;
            Entity.Address = textBoxAddress.Text;
            Entity.EmailAddressList = textBoxEmailAddressList.Text.Trim().ToLower();
            Entity.Country = Countries.CountryCollection.GetById(Model, selectBoxCountry.GetSelectedId());
            Entity.IsEmailSendReportStock = checkBoxEmailSendReportStock.Checked;

            if (EntityId == 0)
            {
                Entity.Company = Companies.CompanyCollection.GetById(Model, Configuration.Main.LoggedCompanyId, false);
                Model.Clients.AddObject(Entity);
            }
            Model.SaveChanges();
            return true;
        }

        private void buttonProductsBrowse_Click(object sender, EventArgs e)
        {
            Products.ProductCollection.Browse();
            RefreshProducts();
        }

        private void buttonDestinationsBrowse_Click(object sender, EventArgs e)
        {
            ClientDestinations.ClientDestinationCollection.Browse();
            RefreshDestinations();
        }
    }
}
