using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sirius.EntityModels.Clients
{
    public class ClientCollection
    {
        public static string EntityNameSingular = "Client";
        public static string EntityNamePlural = "Clienti";

        public static CustomControls.GridViewColumn[] GridViewColumnsNormal = 
		{
			new CustomControls.GridViewColumn("Tara", 100, "L"),
			new CustomControls.GridViewColumn("Nume scurt", 200, "L"),
			new CustomControls.GridViewColumn("Nume lung", 200, "L", true),
			new CustomControls.GridViewColumn("Prescurtare 3 litere", 70, "C"),
			new CustomControls.GridViewColumn("Prescurtare 1 litera", 70, "C")
		};

        public static IOrderedQueryable<Client> GetCollection(EntityModelSirius model, ClientFilterCriteria criteria)
        {
            var o = from p in model.Clients
                    select p;
            if (criteria != null)
            {
                if (criteria.CompanyId > 0)
                {
                    o = o.Where(p => p.Company.Id == criteria.CompanyId);
                }
                if (criteria.ClientId > 0)
                {
                    o = o.Where(p => p.Id == criteria.ClientId);
                }
            }
            var collection = from p in o
                orderby p.NameShort
                select p;
            return collection;
        }

        public static void PopulateGridViewNormal(ClientFilterCriteria criteria, CustomControls.EntityGridView gridView)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                List<string[]> items = new List<string[]>();
                foreach (var obj in GetCollection(model, criteria))
                {
                    items.Add(new string[] { obj.Id.ToString(), obj.Country.Name, obj.NameShort, obj.NameLong, obj.NameSymbol3, obj.NameSymbol1 });
                }
                gridView.SetItems(items); 
            }
        }

        public static void PopulateSelectBox(ClientFilterCriteria criteria, CustomControls.EntitySelectBox selectBox, int selectedId, bool showOptionAll)
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

        public static void PopulateListBox(ClientFilterCriteria criteria, CustomControls.EntityListBox listBox, List<int> selectedIds)
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
            using (ClientFormBrowse form = new ClientFormBrowse())
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Add()
        {
            bool result = false;
            using (ClientFormEdit form = new ClientFormEdit { EntityId = 0 })
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Edit(int selectedId)
        {
            bool result = false;
            using (ClientFormEdit form = new ClientFormEdit { EntityId = selectedId })
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static Client GetById(EntityModelSirius model, int id, bool createNewIfNotExists)
        {
            Client result;
            result = model.Clients.FirstOrDefault(o => o.Id == id);
            if ((result == null) && (createNewIfNotExists))
            {
                result = new Client();
                /*
                result.Company = model.Companies.FirstOrDefault(o => o.Id == Configuration.Main.LoggedCompanyId);
                result.Country = model.Countries.FirstOrDefault();
                if (result.Country == null)
                {
                    Countries.CountryCollection.Add();
                }
                */
            }
            return result;
        }
    }
}
