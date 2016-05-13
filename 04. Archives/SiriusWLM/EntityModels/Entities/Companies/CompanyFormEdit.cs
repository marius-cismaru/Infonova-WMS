using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sirius.EntityModels.Companies
{
    public partial class CompanyFormEdit : CustomControls.EntityFormEdit
    {
        private EntityModelSirius Model;
        private new Company Entity {
            get { return base.Entity as Company; }
            set { base.Entity = value; }
        }

        public CompanyFormEdit()
            : base()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
        }

        public override void FormEdit_Shown(object sender, EventArgs e)
        {
            Entity = CompanyCollection.GetById(Model, EntityId, true);
            SetFormName(CompanyCollection.EntityNameSingular);
            base.FormEdit_Shown(sender, e);
        }

        public override void LoadFieldsFromEntity()
        {
            Countries.CountryCollection.PopulateSelectBox(selectBoxCountry, Entity.Country != null ? Entity.Country.Id : 0, false);
            textBoxNameLong.Text = Entity.NameLong;
            textBoxNameShort.Text = Entity.NameShort;
            textBoxNumberRegistry.Text = Entity.NumberRegistry;
            textBoxNumberFiscal.Text = Entity.NumberFiscal;
            textBoxCapitalAmount.Text = Entity.CapitalAmount;
            textBoxPhone.Text = Entity.Phone;
            textBoxFax.Text = Entity.Fax;
            textBoxAddress.Text = Entity.Address;
            textBoxBank.Text = Entity.Bank;
            textBoxBankAccountEUR.Text = Entity.BankAccountEUR;
            textBoxBankAccountRON.Text = Entity.BankAccountRON;

            //Email
            textBoxEmailSendAddress.Text = Entity.EmailSendAddress;
            textBoxEmailSendEncryption.Text = Entity.EmailSendEncryption;
            textBoxEmailSendName.Text = Entity.EmailSendName;
            textBoxEmailSendPassword.Text = Entity.EmailSendPassword;
            textBoxEmailSendPort.Text = Entity.EmailSendPort;
            textBoxEmailSendServer.Text = Entity.EmailSendServer;
            textBoxEmailSendUsername.Text = Entity.EmailSendUsername;
            textBoxEmailReceiveAddressList.Text = Entity.EmailReceiveAddressList;
        }

        public override bool SaveFieldsToEntity()
        {
            Entity.Country = Countries.CountryCollection.GetById(Model, selectBoxCountry.GetSelectedId());
            Entity.NameLong = textBoxNameLong.Text.Trim().ToUpper();
            Entity.NameShort = textBoxNameShort.Text;
            Entity.NumberRegistry = textBoxNumberRegistry.Text.Trim().ToUpper();
            Entity.NumberFiscal = textBoxNumberFiscal.Text.Trim().ToUpper();
            Entity.CapitalAmount = textBoxCapitalAmount.Text;
            Entity.Phone = textBoxPhone.Text;
            Entity.Fax = textBoxFax.Text;
            Entity.Address = textBoxAddress.Text;
            Entity.Bank = textBoxBank.Text.Trim();
            Entity.BankAccountEUR = textBoxBankAccountEUR.Text.Trim().ToUpper();
            Entity.BankAccountRON = textBoxBankAccountRON.Text.Trim().ToUpper();

            //Email
            Entity.EmailReceiveAddressList = textBoxEmailReceiveAddressList.Text.Trim();
            Entity.EmailSendAddress = textBoxEmailSendAddress.Text.Trim();
            Entity.EmailSendEncryption = textBoxEmailSendEncryption.Text.Trim().ToUpper();
            Entity.EmailSendName = textBoxEmailSendName.Text.Trim();
            Entity.EmailSendPassword = textBoxEmailSendPassword.Text;
            Entity.EmailSendPort = textBoxEmailSendPort.Text.Trim();
            Entity.EmailSendServer = textBoxEmailSendServer.Text.Trim();
            Entity.EmailSendUsername = textBoxEmailSendUsername.Text.Trim();

            if (EntityId == 0)
            {
                Model.Companies.AddObject(Entity);
            }
            Model.SaveChanges();
            return true;
        }

        private void buttonCountryBrowse_Click(object sender, EventArgs e)
        {
            Countries.CountryCollection.Browse();
            Countries.CountryCollection.PopulateSelectBox(selectBoxCountry, Entity.Country != null ? Entity.Country.Id : 0, false);
        }
    }
}
