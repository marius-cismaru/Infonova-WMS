using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sirius.EntityModels.Companies
{
    public class CompanyCollection
    {
        public static string EntityNameSingular = "Companie";
        public static string EntityNamePlural = "Companii";

        public static CustomControls.GridViewColumn[] GridViewColumnsNormal = 
		{
			new CustomControls.GridViewColumn("Tara", 100, "L"),
			new CustomControls.GridViewColumn("Nume scurt", 200, "L"),
			new CustomControls.GridViewColumn("Nume lung", 200, "L", true),
			new CustomControls.GridViewColumn("Clienti", 300, "L")
		};

        public static IOrderedQueryable<Company> GetCollection(CompanyFilterCriteria criteria)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                return GetCollection(model, criteria);
            }
        }

        public static IOrderedQueryable<Company> GetCollection(EntityModelSirius model, CompanyFilterCriteria criteria)
        {
            var o = from p in model.Companies
                    select p;
            if (criteria != null)
            {
                if (criteria.RestrictionAssignUserId > 0)
                {
                    o = o.Where(p=>p.Users.Any(q => q.Id == criteria.RestrictionAssignUserId));
                }
                if (criteria.RestrictionNotAssignUserId > 0)
                {
                    o = o.Where(p => p.Users.All(q => q.Id != criteria.RestrictionNotAssignUserId));
                }
            }
            var collection = from p in o
                orderby p.NameShort
                select p;
            return collection;
        }

        public static void PopulateGridViewNormal(CompanyFilterCriteria criteria, CustomControls.EntityGridView gridView)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                List<string[]> items = new List<string[]>();
                foreach (var obj in GetCollection(model, criteria))
                {
                    items.Add(new string[] { obj.Id.ToString(), obj.Country.Name, obj.NameShort, obj.NameLong, obj.ClientList });
                }
                gridView.SetItems(items);   
            }
        }

        public static void PopulateSelectBox( CompanyFilterCriteria criteria, CustomControls.EntitySelectBox selectBox, int selectedId, bool showOptionAll)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                List<CustomControls.EntityItem> items = new List<CustomControls.EntityItem>();
                foreach (var obj in GetCollection(model, criteria))
                {
                    items.Add(new CustomControls.EntityItem(obj.Id, obj.ToString()));
                }
                selectBox.SetItems(items, selectedId, showOptionAll);
            }
        }

        public static void PopulateListBox(CompanyFilterCriteria criteria, CustomControls.EntityListBox listBox, List<int> selectedIds)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                List<CustomControls.EntityItem> items = new List<CustomControls.EntityItem>();
                foreach (var obj in GetCollection(model, criteria))
                {
                    items.Add(new CustomControls.EntityItem(obj.Id, obj.ToString()));
                }
                listBox.SetItems(items, selectedIds);
            }
        }

        public static bool Browse()
        {
            bool result = false;
            using (CompanyFormBrowse form = new CompanyFormBrowse())
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Add()
        {
            bool result = false;
            using (CompanyFormEdit form = new CompanyFormEdit { EntityId = 0 })
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Edit(int selectedId)
        {
            bool result = false;
            using (CompanyFormEdit form = new CompanyFormEdit { EntityId = selectedId })
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static Company GetById(EntityModelSirius model, int id, bool createNewIfNotExists)
        {
            Company result;
            result = model.Companies.FirstOrDefault(o => o.Id == id);
            if ((result == null) && (createNewIfNotExists))
            {
                result = new Company();
                /*
                result.Country = model.Countries.FirstOrDefault();
                if (result.Country == null)
                {
                    Countries.CountryCollection.Add();
                }
                */ 
            }
            return result;
        }

        public static Company GetFirstByUserId(EntityModelSirius model, int userId)
        {
            Company result = null;
            User user = Users.UserCollection.GetById(model, userId);
            if (user != null)
            {
                result = user.Companies.FirstOrDefault();
            }
            return result;
        }
    }
}
