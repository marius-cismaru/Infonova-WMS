using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sirius.EntityModels.Users
{
    public partial class UserFormEdit : CustomControls.EntityFormEdit
    {
        private EntityModelSirius Model;
        private new User Entity {
            get { return base.Entity as User; }
            set { base.Entity = value; }
        }

        public UserFormEdit()
            : base()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
        }

        public override void FormEdit_Shown(object sender, EventArgs e)
        {
            Entity = UserCollection.GetById(Model, EntityId);
            SetFormName(UserCollection.EntityNameSingular);
            if (EntityId == 0)
            {
                tabControlMain.TabPages.Remove(tabPageCompanies);
            }
            base.FormEdit_Shown(sender, e);
        }

        public override void LoadFieldsFromEntity()
        {
            textBoxName.Text = Entity.Name;
            textBoxNumberPersonal.Text = Entity.NumberPersonal;
            textBoxNumberID.Text = Entity.NumberID;
            dateTimePickerDateBirth.Value = Entity.DateBirth;
            dateTimePickerDateEmployment.Value = DateTime.Now;
            if (Entity.DateEmployment.HasValue)
            {
                dateTimePickerDateEmployment.Checked = true;
                dateTimePickerDateEmployment.Value = Entity.DateEmployment.Value;
            }
            dateTimePickerDateResignation.Value = DateTime.Now;
            if (Entity.DateResignation.HasValue)
            {
                dateTimePickerDateResignation.Checked = true;
                dateTimePickerDateResignation.Value = Entity.DateResignation.Value;
            }

            textBoxUsername.Text = Entity.Username;
            textBoxPassword.Text = Entity.Password;
            checkBoxBelongsToDomain.Checked = Entity.BelongsToDomain;
            textBoxDomainName.Text = Entity.DomainName;
            checkBoxIsActive.Checked = Entity.IsActive;
            RefreshCompaniesAssign();
        }

        public override bool SaveFieldsToEntity()
        {
            Entity.Name = textBoxName.Text;
            Entity.NumberPersonal = textBoxNumberPersonal.Text;
            Entity.NumberID = textBoxNumberID.Text.ToUpper();
            Entity.DateBirth = dateTimePickerDateBirth.Value;
            if (dateTimePickerDateEmployment.Checked)
            {
                Entity.DateEmployment = dateTimePickerDateEmployment.Value;
            }
            else
            {
                Entity.DateEmployment = null;
            }
            if (dateTimePickerDateResignation.Checked)
            {
                Entity.DateResignation = dateTimePickerDateResignation.Value;
            }
            else
            {
                Entity.DateResignation = null;
            }

            Entity.Username = textBoxUsername.Text.Trim().ToLower();
            Entity.Password = textBoxPassword.Text;
            Entity.BelongsToDomain = checkBoxBelongsToDomain.Checked;
            Entity.DomainName = textBoxDomainName.Text.Trim().ToUpper();
            Entity.IsActive = checkBoxIsActive.Checked;

            if (EntityId == 0)
            {
                Model.Users.AddObject(Entity);
            }
            Model.SaveChanges();
            return true;
        }

        private void RefreshCompaniesAssign()
        {
            Companies.CompanyCollection.PopulateListBox(new Companies.CompanyFilterCriteria { RestrictionAssignUserId = EntityId }, entityListBoxCompanies, null);
            Companies.CompanyCollection.PopulateSelectBox(new Companies.CompanyFilterCriteria { RestrictionNotAssignUserId = EntityId }, entitySelectBoxCompany, 0, false);
        }

        private void buttonCompanyAssign_Click(object sender, EventArgs e)
        {
            if (entitySelectBoxCompany.Items.Count > 0)
            {
                Company company = Companies.CompanyCollection.GetById(Model, entitySelectBoxCompany.GetSelectedId(), false);
                Entity.Companies.Add(company);
                Model.SaveChanges();
                RefreshCompaniesAssign();
            }
        }

        private void buttonCompanyRemove_Click(object sender, EventArgs e)
        {
            var ids = entityListBoxCompanies.GetSelectedIds();
            if (ids.Count > 0)
            {
                Company company;
                foreach (var id in ids)
                {
                    company = Companies.CompanyCollection.GetById(Model, id, false);
                    Entity.Companies.Remove(company);
                }
                Model.SaveChanges();
                RefreshCompaniesAssign();
            }
        }
    }
}
