using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;
using Sirius.EntityModels;

namespace Sirius.SiriusManagement
{
    public partial class FormMain : Form
    {
        private EntityModelSirius Model;

        TreeNode menuShortcuts;
        TreeNode menuShortcutsStockPackages;
        TreeNode menuShortcutsReceptionAdd;
        TreeNode menuShortcutsDeliveryAdd;
        TreeNode menuShortcutsTransferAdd;

        TreeNode menuCollaborators;
        TreeNode menuCollaboratorsClients;
        TreeNode menuCollaboratorsClientUsers;
        TreeNode menuCollaboratorsClientDestinations;

        TreeNode menuStorage;
        TreeNode menuStorageWarehouses;
        TreeNode menuStorageWarehouseRooms;
        TreeNode menuStorageWarehouseRows;
        TreeNode menuStorageWarehouseContainers;
        TreeNode menuStoragePackageTypes;
        TreeNode menuStorageProducts;

        TreeNode menuStock;
        TreeNode menuStockPackages;
        TreeNode menuStockTransfers;

        TreeNode menuInput;
        TreeNode menuInputReceptions;

        TreeNode menuOutput;
        TreeNode menuOutputDeliveries;

        TreeNode menuReports;
        TreeNode menuReportStockProducts;
        TreeNode menuReportStockPackages;
        TreeNode menuReportStockVariationDetail;
        TreeNode menuReportReceptions;
        TreeNode menuReportDeliveries;

        TreeNode menuConfiguration;
        TreeNode menuConfigurationStation;

        TreeNode menuHelp;
        TreeNode menuHelpAbout;

        public FormMain()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
        }

        private void BuildTreeMenu()
        {
            //Shortcuts
            menuShortcuts = new TreeNode { Text = "Comenzi rapide", ImageIndex = 0, SelectedImageIndex = 0 };
            menuShortcutsStockPackages = new TreeNode { Text = "Stoc pachete", ImageIndex = 2, SelectedImageIndex = 2 };
            menuShortcutsReceptionAdd = new TreeNode { Text = "Adaugare receptie", ImageIndex = 2, SelectedImageIndex = 2 };
            menuShortcutsDeliveryAdd = new TreeNode { Text = "Adaugare livrare", ImageIndex = 2, SelectedImageIndex = 2 };
            menuShortcutsTransferAdd = new TreeNode { Text = "Adaugare transfer", ImageIndex = 2, SelectedImageIndex = 2 };
            menuShortcuts.Nodes.AddRange(new TreeNode[] {
                menuShortcutsStockPackages,
                menuShortcutsReceptionAdd,
                menuShortcutsDeliveryAdd,
                menuShortcutsTransferAdd
            });
            treeViewMenu.Nodes.Add(menuShortcuts);

            //Colaboratori
            menuCollaborators = new TreeNode { Text = "Colaboratori", ImageIndex = 0, SelectedImageIndex = 0 };
            menuCollaboratorsClients = new TreeNode { Text = "Clienti", ImageIndex = 2, SelectedImageIndex = 2 };
            menuCollaboratorsClientUsers = new TreeNode { Text = "Utilizatori Client", ImageIndex = 2, SelectedImageIndex = 2 };
            menuCollaboratorsClientDestinations = new TreeNode { Text = "Destinatii Livrare Client", ImageIndex = 2, SelectedImageIndex = 2 };
            menuCollaborators.Nodes.AddRange(new TreeNode[] {
                menuCollaboratorsClients,
                menuCollaboratorsClientUsers,
                menuCollaboratorsClientDestinations
            });
            treeViewMenu.Nodes.Add(menuCollaborators);

            //Depozitare
            menuStorage = new TreeNode { Text = "Depozitare", ImageIndex = 0, SelectedImageIndex = 0 };
            menuStorageWarehouses = new TreeNode { Text = "Depozite", ImageIndex = 2, SelectedImageIndex = 2 };
            menuStorageWarehouseRooms = new TreeNode { Text = "Camere de depozitare", ImageIndex = 2, SelectedImageIndex = 2 };
            menuStorageWarehouseRows = new TreeNode { Text = "Randuri de depozitare", ImageIndex = 2, SelectedImageIndex = 2 };
            menuStorageWarehouseContainers = new TreeNode { Text = "Containere", ImageIndex = 2, SelectedImageIndex = 2 };
            menuStoragePackageTypes = new TreeNode { Text = "Tipuri de impachetare", ImageIndex = 2, SelectedImageIndex = 2 };
            menuStorageProducts = new TreeNode { Text = "Articole clienti", ImageIndex = 2, SelectedImageIndex = 2 };
            menuStorage.Nodes.AddRange(new TreeNode[] {
                menuStorageWarehouses,
                menuStorageWarehouseRooms,
                menuStorageWarehouseRows,
                menuStorageWarehouseContainers,
                menuStoragePackageTypes,
                menuStorageProducts
            });
            treeViewMenu.Nodes.Add(menuStorage);

            //Stoc
            menuStock = new TreeNode { Text = "Stoc", ImageIndex = 0, SelectedImageIndex = 0 };
            menuStockPackages = new TreeNode { Text = "Pachete", ImageIndex = 2, SelectedImageIndex = 2 };
            menuStockTransfers = new TreeNode { Text = "Transferuri", ImageIndex = 2, SelectedImageIndex = 2 };
            menuStock.Nodes.AddRange(new TreeNode[] {
                menuStockPackages,
                menuStockTransfers
            });
            treeViewMenu.Nodes.Add(menuStock);

            //Intrari
            menuInput = new TreeNode { Text = "Intrari", ImageIndex = 0, SelectedImageIndex = 0 };
            menuInputReceptions = new TreeNode { Text = "Receptii", ImageIndex = 2, SelectedImageIndex = 2 };
            menuInput.Nodes.AddRange(new TreeNode[] {
                menuInputReceptions
            });
            treeViewMenu.Nodes.Add(menuInput);

            //Iesiri
            menuOutput = new TreeNode { Text = "Iesiri", ImageIndex = 0, SelectedImageIndex = 0 };
            menuOutputDeliveries = new TreeNode { Text = "Livrari", ImageIndex = 2, SelectedImageIndex = 2 };
            menuOutput.Nodes.AddRange(new TreeNode[] {
                menuOutputDeliveries
            });
            treeViewMenu.Nodes.Add(menuOutput);

            //Rapoarte
            menuReports = new TreeNode { Text = "Rapoarte", ImageIndex = 0, SelectedImageIndex = 0 };
            menuReportStockProducts = new TreeNode { Text = EntityModels.Reports.ReportStockProducts.Name, ImageIndex = 2, SelectedImageIndex = 2 };
            menuReportStockPackages = new TreeNode { Text = EntityModels.Reports.ReportStockPackages.Name, ImageIndex = 2, SelectedImageIndex = 2 };
            menuReportStockVariationDetail = new TreeNode { Text = EntityModels.Reports.ReportStockVariationDetail.Name, ImageIndex = 2, SelectedImageIndex = 2 };
            menuReportReceptions = new TreeNode { Text = EntityModels.Reports.ReportReceptions.Name, ImageIndex = 2, SelectedImageIndex = 2 };
            menuReportDeliveries = new TreeNode { Text = EntityModels.Reports.ReportDeliveries.Name, ImageIndex = 2, SelectedImageIndex = 2 };
            menuReports.Nodes.AddRange(new TreeNode[] {
                menuReportStockProducts,
                menuReportStockPackages,
                menuReportStockVariationDetail,
                menuReportReceptions,
                menuReportDeliveries
            });
            treeViewMenu.Nodes.Add(menuReports);

            //Configurare
            menuConfiguration = new TreeNode { Text = "Configurare", ImageIndex = 0, SelectedImageIndex = 0 };
            menuConfigurationStation = new TreeNode { Text = "Statie de lucru", ImageIndex = 2, SelectedImageIndex = 2 };
            menuConfiguration.Nodes.AddRange(new TreeNode[] {
                menuConfigurationStation
            });
            treeViewMenu.Nodes.Add(menuConfiguration);

            //Ajutor
            menuHelp = new TreeNode { Text = "Ajutor", ImageIndex = 0, SelectedImageIndex = 0 };
            menuHelpAbout = new TreeNode { Text = "Despre", ImageIndex = 2, SelectedImageIndex = 2 };
            menuHelp.Nodes.AddRange(new TreeNode[] {
                menuHelpAbout
            });
            treeViewMenu.Nodes.Add(menuHelp);
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            Text = Settings.GetProgramNameFull();
            labelMainHeader.Text = "Utilizator: " + Configuration.Main.LoggedUserUsername + " (" + Configuration.Main.LoggedUserName + ") - Companie: " + Configuration.Main.LoggedCompanyNameLong;
            BuildTreeMenu();

            Configuration.Personal.ReceptionDoLabelPrint = true;
        }

        private void treeViewMenu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //Shortcuts
            if (e.Node == menuShortcutsStockPackages)
            {
                EntityModels.Packages.PackageCollection.Browse();
            }
            if (e.Node == menuShortcutsReceptionAdd)
            {
                EntityModels.Receptions.ReceptionCollection.Add();
            }
            if (e.Node == menuShortcutsDeliveryAdd)
            {
                EntityModels.Deliveries.DeliveryCollection.Add();
            }
            if (e.Node == menuShortcutsTransferAdd)
            {
                EntityModels.Transfers.TransferCollection.Add();
            }

            //Collaborators
            if (e.Node == menuCollaboratorsClients)
            {
                EntityModels.Clients.ClientCollection.Browse();
            }
            if (e.Node == menuCollaboratorsClientUsers)
            {
                EntityModels.ClientUsers.ClientUserCollection.Browse();
            }
            if (e.Node == menuCollaboratorsClientDestinations)
            {
                EntityModels.ClientDestinations.ClientDestinationCollection.Browse();
            }

            //Storage
            if(e.Node == menuStorageWarehouses) 
            {
                EntityModels.Warehouses.WarehouseCollection.Browse();
            }
            if (e.Node == menuStorageWarehouseRooms)
            {
                EntityModels.WarehouseRooms.WarehouseRoomCollection.Browse();
            }
            if (e.Node == menuStorageWarehouseRows)
            {
                EntityModels.WarehouseRows.WarehouseRowCollection.Browse();
            }
            if(e.Node == menuStorageWarehouseContainers)
            {
                EntityModels.WarehouseContainers.WarehouseContainerCollection.Browse();
            }
            if (e.Node == menuStoragePackageTypes)
            {
                EntityModels.PackageTypes.PackageTypeCollection.Browse();
            }
            if (e.Node == menuStorageProducts)
            {
                EntityModels.Products.ProductCollection.Browse();
            }

            //Stock
            if (e.Node == menuStockPackages)
            {
                EntityModels.Packages.PackageCollection.Browse();
            }
            if (e.Node == menuStockTransfers)
            {
                EntityModels.Transfers.TransferCollection.Browse();
            }

            //Input
            if (e.Node == menuInputReceptions)
            {
                EntityModels.Receptions.ReceptionCollection.Browse();
            }

            //Output
            if (e.Node == menuOutputDeliveries)
            {
                EntityModels.Deliveries.DeliveryCollection.Browse();
            }

            //Reports
            if (e.Node == menuReportStockProducts)
            {
                EntityModels.Reports.ReportStockProducts.ShowDialog(new EntityModels.Reports.ReportStockProductsFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId });
            }
            if (e.Node == menuReportStockPackages)
            {
                EntityModels.Reports.ReportStockPackages.ShowDialog(new EntityModels.Reports.ReportStockPackagesFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId });
            }
            if (e.Node == menuReportStockVariationDetail)
            {
                EntityModels.Reports.ReportStockVariationDetail.ShowDialog(new EntityModels.Reports.ReportStockVariationDetailFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId });
            }
            if (e.Node == menuReportReceptions)
            {
                EntityModels.Reports.ReportReceptions.ShowDialog(new EntityModels.Reports.ReportReceptionsFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId });
            }
            if (e.Node == menuReportDeliveries)
            {
                EntityModels.Reports.ReportDeliveries.ShowDialog(new EntityModels.Reports.ReportDeliveriesFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId });
            }

            //Configuration
            if (e.Node == menuConfigurationStation)
            {
                EntityModels.ConfigurationStations.ConfigurationStationCollection.Browse();
            }

            //Help
            if (e.Node == menuHelpAbout)
            {
                using (FormAbout form = new FormAbout())
                {
                    form.ShowDialog();
                }
            }
        }
    }
}
