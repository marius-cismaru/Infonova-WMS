using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sirius.EntityModels.Users
{
    public class UserCollection
    {
        public static string EntityNameSingular = "Utilizator";
        public static string EntityNamePlural = "Utilizatori";

        public static CustomControls.GridViewColumn[] GridViewColumnsNormal = 
		{
			new CustomControls.GridViewColumn("Activ?", 40, "C"),
			new CustomControls.GridViewColumn("Nume", 150, "L", true),
			new CustomControls.GridViewColumn("Username", 100, "L"),
			new CustomControls.GridViewColumn("Apartine Domeniu?", 40, "C"),
			new CustomControls.GridViewColumn("Domeniu", 100, "L"),
			new CustomControls.GridViewColumn("Data Creare", 70, "C"),
			new CustomControls.GridViewColumn("Alocare companii", 200, "L")
		};

        public static IOrderedQueryable<User> GetCollection(EntityModelSirius model)
        {
            var o = from p in model.Users
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
                    items.Add(new string[] { obj.Id.ToString(), (obj.IsActive ? "Da" : "Nu"), obj.Name, obj.Username, (obj.BelongsToDomain ? "Da" : "Nu"), obj.DomainName, obj.DateCreation.ToShortDateString(), obj.CompanyList });
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
            using (UserFormBrowse form = new UserFormBrowse())
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Add()
        {
            bool result = false;
            using (UserFormEdit form = new UserFormEdit { EntityId = 0 })
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Edit(int selectedId)
        {
            bool result = false;
            using (UserFormEdit form = new UserFormEdit { EntityId = selectedId })
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static User GetById(EntityModelSirius model, int id)
        {
            User result;
            result = model.Users.FirstOrDefault(o => o.Id == id);
            if (result == null)
            {
                result = new User();
            }
            return result;
        }

        public static User GetActiveByNameAndDomain(EntityModelSirius model, string username, string domainName)
        {
            User result;
            result = model.Users.FirstOrDefault(o => (o.Username == username && o.IsActive == true && o.BelongsToDomain == true && o.DomainName == domainName));
            return result;
        }
    }
}
