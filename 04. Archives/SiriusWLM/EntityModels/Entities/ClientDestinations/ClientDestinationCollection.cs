using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sirius.EntityModels.ClientDestinations
{
    public class ClientDestinationCollection
    {
        public static string EntityNameSingular = "Destinatie livrare client";
        public static string EntityNamePlural = "Destinatii livrari client";

        public static CustomControls.GridViewColumn[] GridViewColumnsNormal = 
		{
			new CustomControls.GridViewColumn("Client", 100, "L"),
			new CustomControls.GridViewColumn("Denumire", 100, "L"),
			new CustomControls.GridViewColumn("Tara", 80, "C"),
			new CustomControls.GridViewColumn("Companie", 100, "L"),
			new CustomControls.GridViewColumn("Adresa", 150, "L", true)
		};

        public static List<ClientDestination> GetCollection(EntityModelSirius model, ClientDestinationFilterCriteria criteria)
        {
            var o = (from p in model.ClientDestinations
                     select p).ToList();
            if (criteria != null)
            {
                if (criteria.CompanyId > 0)
                {
                    o = o.Where(p => p.Client.Company.Id == criteria.CompanyId).ToList();
                }
                if (criteria.ClientId > 0)
                {
                    o = o.Where(p => p.Client.Id == criteria.ClientId).ToList();
                }
                if (criteria.Name != string.Empty)
                {
                    o = o.Where(p => p.Name.Contains(criteria.Name)).ToList();
                }
            }
            var collection = (from p in o
                              orderby p.Client.NameShort, p.Name
                              select p).ToList();
            return collection;
        }

        public static void PopulateGridViewNormal(ClientDestinationFilterCriteria criteria, CustomControls.EntityGridView gridView)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                List<string[]> items = new List<string[]>();
                foreach (var obj in GetCollection(model, criteria))
                {
                    items.Add(new string[] { obj.Id.ToString(), obj.Client.NameShort, obj.Name, obj.Country.ToString(), obj.Company, obj.Address });
                }
                gridView.SetItems(items);   
            }
        }

        public static void PopulateSelectBox(ClientDestinationFilterCriteria criteria, CustomControls.EntitySelectBox selectBox, int selectedId, bool showOptionAll)
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

        public static void PopulateListBox(ClientDestinationFilterCriteria criteria, CustomControls.EntityListBox listBox, List<int> selectedIds)
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
            using (ClientDestinationFormBrowse form = new ClientDestinationFormBrowse())
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Add()
        {
            bool result = false;
            using (ClientDestinationFormEdit form = new ClientDestinationFormEdit { EntityId = 0 })
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Edit(int selectedId)
        {
            bool result = false;
            using (ClientDestinationFormEdit form = new ClientDestinationFormEdit { EntityId = selectedId })
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static ClientDestination GetById(EntityModelSirius model, int id, bool createNewIfNotExists)
        {
            ClientDestination result;
            result = model.ClientDestinations.FirstOrDefault(o => o.Id == id);
            if ((result == null) && (createNewIfNotExists))
            {
                result = new ClientDestination();
                /*
                result.Client = model.Clients.FirstOrDefault(o => o.Company.Id == Configuration.Main.LoggedCompanyId);
                result.Country = model.Countries.FirstOrDefault();
                */
            }
            return result;
        }
    }
}
