using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sirius.EntityModels.MeasuringUnits
{
    public partial class MeasuringUnitFormEdit : CustomControls.EntityFormEdit
    {
        private EntityModelSirius Model;
        private new MeasuringUnit Entity {
            get { return base.Entity as MeasuringUnit; }
            set { base.Entity = value; }
        }

        public MeasuringUnitFormEdit()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
            Entity = MeasuringUnitCollection.GetById(Model, EntityId);
        }

        public override void FormEdit_Shown(object sender, EventArgs e)
        {
            SetFormName(MeasuringUnitCollection.EntityNameSingular);
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
                Model.MeasuringUnits.AddObject(Entity);
            }
            Model.SaveChanges();
            return true;
        }
    }
}
