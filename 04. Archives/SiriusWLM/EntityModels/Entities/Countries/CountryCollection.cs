﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sirius.EntityModels.Countries
{
    public class CountryCollection
    {
        public static string EntityNameSingular = "Tara";
        public static string EntityNamePlural = "Tari";

        public static CustomControls.GridViewColumn[] GridViewColumnsNormal = 
		{
			new CustomControls.GridViewColumn("Denumire", 200, "L", true)
		};

        public static IOrderedQueryable<Country> GetCollection(EntityModelSirius model)
        {
            var o = from p in model.Countries
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
            using (CountryFormBrowse form = new CountryFormBrowse())
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Add()
        {
            bool result = false;
            using (CountryFormEdit form = new CountryFormEdit { EntityId = 0 })
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Edit(int entityId)
        {
            bool result = false;
            using (CountryFormEdit form = new CountryFormEdit { EntityId = entityId })
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static Country GetById(EntityModelSirius model, int id)
        {
            Country result;
            result = model.Countries.FirstOrDefault(o => o.Id == id);
            if (result == null)
            {
                result = new Country();
            }
            return result;
        }
    }
}
