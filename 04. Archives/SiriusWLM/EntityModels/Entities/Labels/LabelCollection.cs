using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Sirius.EntityModels.Labels
{
    public class LabelCollection
    {
        public static string EntityNameSingular = "Eticheta";
        public static string EntityNamePlural = "Etichete";

        public static CustomControls.GridViewColumn[] GridViewColumnsNormal = 
		{
			new CustomControls.GridViewColumn("Scop", 100, "C"),
			new CustomControls.GridViewColumn("Implicit?", 70, "C"),
			new CustomControls.GridViewColumn("Data creare", 100, "C"),
			new CustomControls.GridViewColumn("Denumire", 160, "L", true)
		};

        public static IOrderedQueryable<Label> GetCollection()
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                return GetCollection(model);
            }
        }

        public static IOrderedQueryable<Label> GetCollection(EntityModelSirius model)
        {
            var o = from p in model.Labels
                    select p;
            var collection = from p in o
                orderby p.Scope, p.DateCreation descending, p.Description
                select p;
            return collection;
        }

        public static void PopulateGridViewNormal(CustomControls.EntityGridView gridView)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                List<string[]> items = new List<string[]>();
                foreach (var obj in GetCollection(model))
                {
                    items.Add(new string[] { obj.Id.ToString(), obj.ScopeToString, (obj.IsDefault ? "Da" : "Nu"), obj.DateCreation.ToString("yyyy-MM-dd"), obj.Description });
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

        public static void PopulateListBox(CustomControls.EntityListBox listBox, List<int> selectedIds)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                List<CustomControls.EntityItem> items = new List<CustomControls.EntityItem>();
                foreach (var obj in GetCollection(model))
                {
                    items.Add(new CustomControls.EntityItem(obj.Id, obj.ToString()));
                }
                listBox.SetItems(items, selectedIds);
            }
        }

        public static bool Browse()
        {
            bool result = false;
            using (LabelFormBrowse form = new LabelFormBrowse())
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Add()
        {
            bool result = false;
            using (LabelFormEdit form = new LabelFormEdit())
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Edit(int selectedId)
        {
            bool result = false;
            using (LabelFormEdit form = new LabelFormEdit { EntityId = selectedId })
            {
                result = (form.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            }
            return result;
        }

        public static bool Delete(int selectedId)
        {
            bool result = false;
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                var obj = GetById(model, selectedId, false);
                if (obj != null)
                {
                    model.Labels.DeleteObject(obj);
                    model.SaveChanges();
                    result = true;
                }
            }
            return result;
        }

        public static Label GetById(EntityModelSirius model, int id, bool createNewIfNotExists)
        {
            Label result;
            result = model.Labels.FirstOrDefault(o => o.Id == id);
            if ((result == null) && (createNewIfNotExists))
            {
                result = new Label();
            }
            return result;
        }

        public static Label GetDefaultByScope(EntityModelSirius model, Label.OptionsScope scope)
        {
            return model.Labels.FirstOrDefault(o => (o.Scope == (int)scope) && (o.IsDefault == true));
        }

        public static Label GetDefaultByScope(Label.OptionsScope scope)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                return GetDefaultByScope(model, scope);
            }
        }

        public static bool CheckIfExistsById(int id)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                return (model.Labels.FirstOrDefault(o => o.Id == id) != null);
            }
        }

        public static string PrintPackage(Package package, string printer)
        {
            string result = string.Empty;
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                Label label = GetDefaultByScope(model, Label.OptionsScope.Package);
                if (label != null)
                {
                    printer = printer.Trim();
                    if (printer != string.Empty)
                    {
                        string codeZPL = label.ZPLCode;
                        codeZPL = codeZPL.Replace("%COMNAM%", package.Product.Client.Company.NameLong);
                        codeZPL = codeZPL.Replace("%CLINAM%", package.Product.Client.NameShort);
                        codeZPL = codeZPL.Replace("%CLICOD%", package.Product.Client.Code.ToString());
                        codeZPL = codeZPL.Replace("%PRONAM%", package.Product.Name);
                        codeZPL = codeZPL.Replace("%PROCOD%", package.Product.Code);
                        codeZPL = codeZPL.Replace("%PROID%", package.Product.IdToString);
                        codeZPL = codeZPL.Replace("%PACCOD%", package.Code);
                        codeZPL = codeZPL.Replace("%PACTYP%", package.PackageType.ToString());
                        codeZPL = codeZPL.Replace("%CON%", package.WarehouseContainer.Name);
                        codeZPL = codeZPL.Replace("%QUA%", package.Quantity.ToString("0.00", CultureInfo.InvariantCulture) + " " + package.Product.MeasuringUnit.ToString());
                        codeZPL = codeZPL.Replace("%WEINET%", package.WeightNet.ToString("0.00", CultureInfo.InvariantCulture) + " Kg");
                        codeZPL = codeZPL.Replace("%WEIGRO%", package.WeightGross.ToString("0.00", CultureInfo.InvariantCulture) + " Kg");
                        codeZPL = codeZPL.Replace("%DATREC%", package.Reception.DateCreation.ToString("dd.MM.yyyy"));
                        codeZPL = codeZPL.Replace("%DATPRO%", package.DateProduction.ToString("dd.MM.yyyy"));
                        codeZPL = codeZPL.Replace("%DATEXP%", package.DateExpiration.ToString("dd.MM.yyyy"));
                        try
                        {
                            CommonLibs.LabelPrintingZPL.SendStringToPrinter(printer, codeZPL);
                            result = string.Empty;
                        }
                        catch (Exception ex)
                        {
                            result = ex.ToString();
                        }
                    }
                }
            }
            return result;
        }
    }
}
