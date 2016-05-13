using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sirius.EntityModels.Labels
{
    public partial class LabelFormEdit : CustomControls.EntityFormEdit
    {
        private EntityModelSirius Model;
        private new Label Entity {
            get { return base.Entity as Label; }
            set { base.Entity = value; }
        }

        public LabelFormEdit()
            : base()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
        }

        public override void FormEdit_Shown(object sender, EventArgs e)
        {
            Entity = LabelCollection.GetById(Model, EntityId, true);
            SetFormName(LabelCollection.EntityNameSingular);
            base.FormEdit_Shown(sender, e);
        }

        public override void LoadFieldsFromEntity()
        {
            CommonLibs.EnumsLib.PopulateSelectBox<Label.OptionsScope>(selectBoxScope, Entity.OptionScope);
            checkBoxIsDefault.Checked = Entity.IsDefault;
            textBoxDescription.Text = Entity.Description;
            richTextBoxZPLCode.Text = Entity.ZPLCode;
            textBoxDateCreation.Text = Entity.DateCreation.ToString("dd.MM.yyyy HH:mm:ss");
            textBoxDateModification.Text = Entity.DateModification.ToString("dd.MM.yyyy HH:mm:ss");
        }

        public override bool SaveFieldsToEntity()
        {
            Entity.OptionScope = CommonLibs.EnumsLib.GetSelectBoxSelectedEnum<Label.OptionsScope>(selectBoxScope);
            Entity.IsDefault = checkBoxIsDefault.Checked;
            Entity.Description = textBoxDescription.Text.Trim();
            Entity.ZPLCode = richTextBoxZPLCode.Text;
            if (EntityId == 0)
            {
                Entity.DateCreation = DateTime.Now;
                Model.Labels.AddObject(Entity);
            }
            Entity.DateModification = DateTime.Now;
            if (Entity.IsDefault)
            {
                Model.Labels.Where(o => (o.Scope == Entity.Scope) && (o.Id != Entity.Id)).ToList().ForEach(o => o.IsDefault = false);
            }
            else
            {
                var collection = Model.Labels.Where(o => (o.Scope == Entity.Scope) && (o.IsDefault == true) && (o.Id != Entity.Id));
                if (collection.Count() != 1)
                {
                    var label = Model.Labels.Where(o => (o.Scope == Entity.Scope) && (o.Id != Entity.Id)).OrderByDescending(o => o.DateModification).FirstOrDefault();
                    if (label == null)
                    {
                        Entity.IsDefault = true;
                    }
                    else
                    {
                        Model.Labels.Where(o => (o.Scope == Entity.Scope) && (o.Id != Entity.Id)).ToList().ForEach(o => o.IsDefault = false);
                        label.IsDefault = true;
                    }
                }
            }
            Model.SaveChanges();
            return true;
        }
    }
}
