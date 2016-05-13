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
    public partial class ClientDestinationFormEdit : CustomControls.EntityFormEdit
    {
        private EntityModelSirius Model;
        private new ClientDestination Entity {
            get { return base.Entity as ClientDestination; }
            set { base.Entity = value; }
        }

        public ClientDestinationFormEdit()
            : base()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
        }

        public override void FormEdit_Shown(object sender, EventArgs e)
        {
            Entity = ClientDestinationCollection.GetById(Model, EntityId, true);
            SetFormName(ClientDestinationCollection.EntityNameSingular);

            base.FormEdit_Shown(sender, e);
        }

        public override void LoadFieldsFromEntity()
        {
            Clients.ClientCollection.PopulateSelectBox(new Clients.ClientFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId }, selectBoxClient, (Entity.Id != 0 ? Entity.Client.Id : 0), false);
            Countries.CountryCollection.PopulateSelectBox(selectBoxCountry, (Entity.Id != 0 ? Entity.Country.Id : 0), false);
            if (EntityId != 0)
            {
                selectBoxClient.Enabled = false;
            }
            textBoxName.Text = Entity.Name;
            textBoxCompany.Text = Entity.Company;
            textBoxAddress.Text = Entity.Address;
        }

        public override bool SaveFieldsToEntity()
        {
            Entity.Name = textBoxName.Text.Trim();
            Entity.Company = textBoxCompany.Text.Trim();
            Entity.Address = textBoxAddress.Text.Trim();
            if (EntityId == 0)
            {
                Entity.Client = Clients.ClientCollection.GetById(Model, selectBoxClient.GetSelectedId(), true);
                Model.ClientDestinations.AddObject(Entity);
            }
            Entity.Country = Countries.CountryCollection.GetById(Model, selectBoxCountry.GetSelectedId());
            Model.SaveChanges();
            return true;
        }
    }
}
