using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sirius.EntityModels.PackageTypes
{
    public class PackageTypeCollection
    {
        public static string EntityNameSingular = "Tip de Impachetare";
        public static string EntityNamePlural = "Tipuri de Impachetare";

        public static CustomControls.GridViewColumn[] GridViewColumnsNormal = 
		{
			new CustomControls.GridViewColumn("Denumire", 200, "L", true),
			new CustomControls.GridViewColumn("Factor de ocupare container", 80, "R"),
			new CustomControls.GridViewColumn("Greutate neta maxima suportata", 100, "R")
		};

        public static IOrderedQueryable<PackageType> GetCollection(EntityModelSirius model)
        {
            var o = from p in model.PackageTypes
                    orderby p.Name
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
                    items.Add(new string[] { obj.Id.ToString(), obj.Name, obj.WarehouseContainerOccupancy.ToString(), obj.WeightNetMaxSupported.ToString() });
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
            using (PackageTypeFormBrowse form = new PackageTypeFormBrowse())
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Add()
        {
            bool result = false;
            using (PackageTypeFormEdit form = new PackageTypeFormEdit { EntityId = 0 })
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Edit(int selectedId)
        {
            bool result = false;
            using (PackageTypeFormEdit form = new PackageTypeFormEdit { EntityId = selectedId })
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static PackageType GetById(EntityModelSirius model, int id, bool createNewIfNotExists)
        {
            PackageType result;
            result = model.PackageTypes.FirstOrDefault(o => o.Id == id);
            if ((result == null) && (createNewIfNotExists))
            {
                result = new PackageType();
            }
            return result;
        }
    }
}
