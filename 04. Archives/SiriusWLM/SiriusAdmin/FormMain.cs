using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sirius.EntityModels;

namespace Sirius.SiriusAdmin
{
    public partial class FormMain : Form
    {
        private EntityModels.EntityModelSirius Model;

        TreeNode menuManagement;
        TreeNode menuManagementCountries;
        TreeNode menuManagementCompanies;
        TreeNode menuManagementMeasuringUnits;
        TreeNode menuManagementLabels;
        TreeNode menuSecurity;
        TreeNode menuSecurityUsers;
        TreeNode menuConfiguration;
        TreeNode menuConfigurationFile;
        TreeNode menuConfigurationVersions;
        TreeNode menuUtils;
        TreeNode menuUtilsMovePackagesFromTestToProduction;

        public FormMain()
        {
            InitializeComponent();
            Text = Settings.GetProgramNameFull();
            Model = new EntityModels.EntityModelSirius(Configuration.Main.SQLConnectionString);
        }

        private void BuildTreeMenu()
        {
            //Management
            menuManagement = new TreeNode { Text = "Management", ImageIndex = 0, SelectedImageIndex = 0 };
            menuManagementCountries = new TreeNode { Text = "Tari", ImageIndex = 2, SelectedImageIndex = 2 };
            menuManagementCompanies = new TreeNode { Text = "Companii", ImageIndex = 2, SelectedImageIndex = 2 };
            menuManagementMeasuringUnits = new TreeNode { Text = "Unitati de masura", ImageIndex = 2, SelectedImageIndex = 2 };
            menuManagementLabels = new TreeNode { Text = "Etichete", ImageIndex = 2, SelectedImageIndex = 2 };
            menuManagement.Nodes.AddRange(new TreeNode[] {
                menuManagementCountries,
                menuManagementCompanies,
                menuManagementMeasuringUnits,
                menuManagementLabels
            });
            treeViewMenu.Nodes.Add(menuManagement);

            menuSecurity = new TreeNode { Text = "Securitate", ImageIndex = 0, SelectedImageIndex = 0 };
            menuSecurityUsers = new TreeNode { Text = "Utilizatori", ImageIndex = 2, SelectedImageIndex = 2 };
            menuSecurity.Nodes.AddRange(new TreeNode[] {
                menuSecurityUsers
            });
            treeViewMenu.Nodes.Add(menuSecurity);

            menuConfiguration = new TreeNode { Text = "Configurare", ImageIndex = 0, SelectedImageIndex = 0 };
            menuConfigurationFile = new TreeNode { Text = "Fisier configurare", ImageIndex = 2, SelectedImageIndex = 2 };
            menuConfigurationVersions = new TreeNode { Text = "Versiuni", ImageIndex = 2, SelectedImageIndex = 2 };
            menuConfiguration.Nodes.AddRange(new TreeNode[] {
                menuConfigurationFile,
                menuConfigurationVersions
            });
            treeViewMenu.Nodes.Add(menuConfiguration);

            menuUtils = new TreeNode { Text = "Utile", ImageIndex = 0, SelectedImageIndex = 0 };
            menuUtilsMovePackagesFromTestToProduction = new TreeNode { Text = "Muta pachete test -> prod", ImageIndex = 2, SelectedImageIndex = 2 };
            menuUtils.Nodes.AddRange(new TreeNode[] {
                menuUtilsMovePackagesFromTestToProduction
            });
            treeViewMenu.Nodes.Add(menuUtils);
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            Text = Settings.GetProgramNameFull();
            BuildTreeMenu();
        }

        private void treeViewMenu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //Management
            if (e.Node == menuManagementCountries)
            {
                EntityModels.Countries.CountryCollection.Browse();
            }
            if (e.Node == menuManagementCompanies)
            {
                EntityModels.Companies.CompanyCollection.Browse();
            }
            if (e.Node == menuManagementMeasuringUnits)
            {
                EntityModels.MeasuringUnits.MeasuringUnitCollection.Browse();
            }
            if (e.Node == menuManagementLabels)
            {
                EntityModels.Labels.LabelCollection.Browse();
            }

            //Security
            if (e.Node == menuSecurityUsers)
            {
                EntityModels.Users.UserCollection.Browse();
            }

            //Configurare
            if (e.Node == menuConfigurationFile)
            {
                using (FormConfigurationEdit form = new FormConfigurationEdit())
                {
                    form.ShowDialog();
                }
            }
            if (e.Node == menuConfigurationVersions)
            {
                EntityModels.ConfigurationVersions.ConfigurationVersionCollection.Browse();
            }

            //Utile
            if (e.Node == menuUtilsMovePackagesFromTestToProduction)
            {
                using (EntityModels.EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
                {
                    /*var collection = from o in model.Packages
                                     where o.WarehouseContainer.WarehouseRow.WarehouseRoom.Warehouse.Company.Id == 2
                                     select o;

                    foreach (var objToModify in collection)
                    {
                        var containerNew = (from o in model.WarehouseContainers
                                            where (o.Name == objToModify.WarehouseContainer.Name) && (o.WarehouseRow.WarehouseRoom.Warehouse.Company.Id == 1)
                                            select o).FirstOrDefault();
                        if (containerNew != null)
                        {
                            objToModify.WarehouseContainer = containerNew;
                        }
                        else
                        {
                            MessageBox.Show(objToModify.Id.ToString() + " - nu are inlocuitor");
                        }
                    }

                    model.SaveChanges();

                    MessageBox.Show("Done " + collection.Count().ToString());
                    */

                    /*
                    //Delete containers from test
                    var objs1 = model.WarehouseContainers.Where(o => o.WarehouseRow.WarehouseRoom.Warehouse.Company.Id == 2).ToList();
                    foreach (var obj in objs1)
                    {
                        model.WarehouseContainers.DeleteObject(obj);
                    }
                    model.SaveChanges();
                    MessageBox.Show("Done deleting " + objs1.Count.ToString());

                    //Delete rows from test
                    var objs2 = model.WarehouseRows.Where(o => o.WarehouseRoom.Warehouse.Company.Id == 2).ToList();
                    foreach (var obj in objs2)
                    {
                        model.WarehouseRows.DeleteObject(obj);
                    }
                    model.SaveChanges();
                    MessageBox.Show("Done deleting " + objs2.Count.ToString());

                    //Delete rooms from test
                    var objs3 = model.WarehouseRooms.Where(o => o.Warehouse.Company.Id == 2).ToList();
                    foreach (var obj in objs3)
                    {
                        model.WarehouseRooms.DeleteObject(obj);
                    }
                    model.SaveChanges();
                    MessageBox.Show("Done deleting " + objs3.Count.ToString());

                    //Delete warehouses from test
                    var objs4 = model.Warehouses.Where(o => o.Company.Id == 2).ToList();
                    foreach (var obj in objs4)
                    {
                        model.Warehouses.DeleteObject(obj);
                    }
                    model.SaveChanges();
                    MessageBox.Show("Done deleting " + objs4.Count.ToString());
                     * */
                }
            }
        }
    }
}
