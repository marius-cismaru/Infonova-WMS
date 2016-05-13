using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sirius.EntityModels.Countries
{
    public partial class CountryFormEdit : CustomControls.EntityFormEdit
    {
        private EntityModelSirius Model;
        private new Country Entity {
            get { return base.Entity as Country; }
            set { base.Entity = value; }
        }

        public CountryFormEdit()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
            Entity = CountryCollection.GetById(Model, EntityId);
        }

        public override void FormEdit_Shown(object sender, EventArgs e)
        {
            SetFormName(CountryCollection.EntityNameSingular);
            base.FormEdit_Shown(sender, e);
        }

        public override void LoadFieldsFromEntity()
        {
            textBoxName.Text = Entity.Name;
        }

        public override bool SaveFieldsToEntity()
        {
            Entity.Name = textBoxName.Text;
            if (EntityId == 0)
            {
                Model.Countries.AddObject(Entity);
            }
            Model.SaveChanges();
            return true;
        }
    }
}
