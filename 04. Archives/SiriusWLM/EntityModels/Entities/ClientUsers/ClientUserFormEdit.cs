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
    public partial class ClientUserFormEdit : CustomControls.EntityFormEdit
    {
        private EntityModelSirius Model;
        private new ClientUser Entity {
            get { return base.Entity as ClientUser; }
            set { base.Entity = value; }
        }
        private Client ClientSelected;

        public ClientUserFormEdit()
            : base()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
        }

        public override void FormEdit_Shown(object sender, EventArgs e)
        {
            Entity = ClientUserCollection.GetById(Model, EntityId, true);
            SetFormName(ClientUserCollection.EntityNameSingular);
            base.FormEdit_Shown(sender, e);
        }

        public override void LoadFieldsFromEntity()
        {
            ClientSelected = EntityId != 0 ? Entity.Client : null;
            Clients.ClientCollection.PopulateSelectBox(new Clients.ClientFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId }, selectBoxClient, (ClientSelected != null ? ClientSelected.Id : 0), false);
            if (EntityId != 0)
            {
                selectBoxClient.Enabled = false;
            }
            textBoxUsername.Text = Entity.Username;
            textBoxName.Text = Entity.Name;
            textBoxPassword.Text = Entity.Password;
            checkBoxIsActive.Checked = Entity.IsActive;
        }

        public override bool SaveFieldsToEntity()
        {
            Entity.Name = textBoxName.Text;
            Entity.Username = textBoxUsername.Text;
            Entity.Password = textBoxPassword.Text;
            Entity.IsActive = checkBoxIsActive.Checked;
            if (EntityId == 0)
            {
                Entity.Client = ClientSelected;
                Model.ClientUsers.AddObject(Entity);
            }
            Model.SaveChanges();
            return true;
        }

        private void selectBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClientSelected = Clients.ClientCollection.GetById(Model, selectBoxClient.GetSelectedId(), false);
        }
    }
}
