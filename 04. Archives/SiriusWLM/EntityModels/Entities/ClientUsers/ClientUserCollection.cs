using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sirius.EntityModels.ClientUsers
{
    public class ClientUserCollection
    {
        public static string EntityNameSingular = "Utilizator client";
        public static string EntityNamePlural = "Utilizatori client";

        public static CustomControls.GridViewColumn[] GridViewColumnsNormal = 
		{
			new CustomControls.GridViewColumn("Activ?", 40, "C"),
			new CustomControls.GridViewColumn("Client", 100, "L"),
			new CustomControls.GridViewColumn("Nume", 100, "L"),
			new CustomControls.GridViewColumn("Username", 150, "L", true),
			new CustomControls.GridViewColumn("Data Creare", 70, "C")
		};

        public static IOrderedQueryable<ClientUser> GetCollection(EntityModelSirius model, ClientUserFilterCriteria criteria)
        {
            var o = from p in model.ClientUsers
                    select p;
            if (criteria != null)
            {
                if (criteria.CompanyId > 0)
                {
                    o = o.Where(p => p.Client.Company.Id == criteria.CompanyId);
                }
                if (criteria.ClientId > 0)
                {
                    o = o.Where(p => p.Client.Id == criteria.ClientId);
                }
                if (criteria.Name != string.Empty)
                {
                    o = o.Where(p => p.Name.Contains(criteria.Name));
                }
            }
            var collection = from p in o
                orderby p.Client.NameShort, p.Name
                select p;
            return collection;
        }

        public static void PopulateGridViewNormal(ClientUserFilterCriteria criteria, CustomControls.EntityGridView gridView)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                List<string[]> items = new List<string[]>();
                foreach (var obj in GetCollection(model, criteria))
                {
                    items.Add(new string[] { obj.Id.ToString(), (obj.IsActive ? "Da" : "Nu"), obj.Client.NameShort, obj.Name, obj.Username, obj.DateCreation.ToString("yyyy-MM-dd") });
                }
                gridView.SetItems(items);   
            }
        }

        public static void PopulateSelectBox(ClientUserFilterCriteria criteria, CustomControls.EntitySelectBox selectBox, int selectedId, bool showOptionAll)
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

        public static void PopulateListBox(ClientUserFilterCriteria criteria, CustomControls.EntityListBox listBox, List<int> selectedIds)
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
            using (ClientUserFormBrowse form = new ClientUserFormBrowse())
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Add()
        {
            bool result = false;
            using (ClientUserFormEdit form = new ClientUserFormEdit { EntityId = 0 })
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Edit(int selectedId)
        {
            bool result = false;
            using (ClientUserFormEdit form = new ClientUserFormEdit { EntityId = selectedId })
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static ClientUser GetById(EntityModelSirius model, int id, bool createNewIfNotExists)
        {
            ClientUser result;
            result = model.ClientUsers.FirstOrDefault(o => o.Id == id);
            if ((result == null) && (createNewIfNotExists))
            {
                result = new ClientUser();
                //result.Client = model.Clients.FirstOrDefault(o => o.Company.Id == Configuration.Main.LoggedCompanyId);
            }
            return result;
        }
    }
}
