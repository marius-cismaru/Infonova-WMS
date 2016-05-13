using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sirius.EntityModels.MeasuringUnits
{
    public class MeasuringUnitCollection
    {
        public static string EntityNameSingular = "UM";
        public static string EntityNamePlural = "UM";

        public static CustomControls.GridViewColumn[] GridViewColumnsNormal = 
		{
			new CustomControls.GridViewColumn("Denumire", 200, "L", true)
		};

        public static IOrderedQueryable<MeasuringUnit> GetCollection(EntityModelSirius model)
        {
            var o = from p in model.MeasuringUnits
                    orderby p.Name descending
                    select p;
            return o;
        }

        public static void PopulateGridViewNormal(CustomControls.EntityGridView gridView)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                List<string[]> items = new List<string[]>();
                foreach (var obj in GetCollection(model))
                {
                    items.Add(new string[] { obj.Id.ToString(), obj.Name });
                }
                gridView.SetItems(items);
            }
        }

        public static void PopulateSelectBox(CustomControls.EntitySelectBox selectBox, int selectedId, bool showOptionAll)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                List<CustomControls.EntityItem> items = new List<CustomControls.EntityItem>();
                foreach (var obj in GetCollection(model))
                {
                    items.Add(new CustomControls.EntityItem(obj.Id, obj.ToString()));
                }
                selectBox.SetItems(items, selectedId, showOptionAll);
            }
        }

        public static bool Browse()
        {
            bool result = false;
            using (MeasuringUnitFormBrowse form = new MeasuringUnitFormBrowse())
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Add()
        {
            bool result = false;
            using (MeasuringUnitFormEdit form = new MeasuringUnitFormEdit { EntityId = 0 })
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Edit(int selectedId)
        {
            bool result = false;
            using (MeasuringUnitFormEdit form = new MeasuringUnitFormEdit { EntityId = selectedId })
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static MeasuringUnit GetById(EntityModelSirius model, int id)
        {
            MeasuringUnit result;
            result = model.MeasuringUnits.FirstOrDefault(o => o.Id == id);
            if (result == null)
            {
                result = new MeasuringUnit();
            }
            return result;
        }
    }
}
