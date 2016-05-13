using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Sirius.EntityModels.Packages
{
    public partial class PackageFormBrowse : CustomControls.EntityFormBrowse
    {
        public string LabelPrinterName;

        private EntityModelSirius Model;
        private PackageFilterCriteria Criteria;

        //Context Menu Master Reports
        private ToolStripMenuItem menuItemMasterReportsLabel;

        public PackageFormBrowse()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
            VisibleExtraPanels = ExtraPanels.Filter;
            labelDetailDescription.Text = "Lista articole";
            Criteria = new PackageFilterCriteria
            {
                CompanyId = Configuration.Main.LoggedCompanyId
            };

            //Context Menu Master Reports
            menuItemMasterReportsLabel = new ToolStripMenuItem("Etichete");
            contextMenuStripMasterReports.Items.Add(menuItemMasterReportsLabel);
        }

        private void GetLabelPrinterNameFromConfiguration()
        {
            LabelPrinterName = string.Empty;
            var configuration = ConfigurationStations.ConfigurationStationCollection.GetForThisStation(Model);
            if (configuration != null)
            {
                LabelPrinterName = configuration.LabelPrinterName;
            }
        }

        protected override void LoadFieldsFromFilter()
        {
            CommonLibs.EnumsLib.PopulateSelectBox<PackageFilterCriteria.OptionsIsExisting>(selectBoxIsExisting, Criteria.OptionIsExisting);
            Clients.ClientCollection.PopulateSelectBox(new Clients.ClientFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId }, selectBoxFilterClient, Criteria.ClientId, true);
            Warehouses.WarehouseCollection.PopulateSelectBox(new Warehouses.WarehouseFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId }, selectBoxFilterWarehouse, Criteria.WarehouseId, true);
            textBoxFilterCode.Text = Criteria.Code;
            textBoxFilterWarehouseContainerName.Text = Criteria.WarehouseContainerName;
            textBoxFilterReceptionNumber.Text = Criteria.ReceptionNumber > 0 ? Criteria.ReceptionNumber.ToString() : string.Empty;
            textBoxFilterDeliveryNumber.Text = Criteria.DeliveryNumber > 0 ? Criteria.DeliveryNumber.ToString() : string.Empty;

            base.LoadFieldsFromFilter();
        }

        protected override void SaveFieldsToFilter()
        {
            Criteria.OptionIsExisting = CommonLibs.EnumsLib.GetSelectBoxSelectedEnum<PackageFilterCriteria.OptionsIsExisting>(selectBoxIsExisting);
            Criteria.ClientId = selectBoxFilterClient.GetSelectedId();
            Criteria.WarehouseId = selectBoxFilterWarehouse.GetSelectedId();
            Criteria.ProductId = selectBoxFilterProduct.GetSelectedId();
            Criteria.Code = textBoxFilterCode.Text.Trim();
            Criteria.WarehouseContainerName = textBoxFilterWarehouseContainerName.Text.Trim();

            int receptionNumber = 0;
            int.TryParse(textBoxFilterReceptionNumber.Text, System.Globalization.NumberStyles.Integer, CultureInfo.InvariantCulture, out receptionNumber);
            Criteria.ReceptionNumber = receptionNumber;
            int deliveryNumber = 0;
            int.TryParse(textBoxFilterDeliveryNumber.Text, System.Globalization.NumberStyles.Integer, CultureInfo.InvariantCulture, out deliveryNumber);
            Criteria.DeliveryNumber = deliveryNumber;

            base.SaveFieldsToFilter();
        }

        protected override void RefreshEntitiesMaster()
        {
            SaveFieldsToFilter();
            PackageCollection.PopulateGridViewNormal(Criteria, gridViewMaster);
            base.RefreshEntitiesMaster();
        }

        protected override void ShowForm()
        {
            SetFormName(PackageCollection.EntityNamePlural);
            gridViewMaster.SetCustomColumns(PackageCollection.GridViewColumnsNormal);
            gridViewMaster.MultiSelect = true;
            GetLabelPrinterNameFromConfiguration();
            base.ShowForm();
        }

        protected override bool CheckIfAllowAddMaster()
        {
            return false;
        }

        protected override bool AddMaster()
        {
            return base.AddMaster();
        }

        protected override bool CheckIfAllowEditMaster()
        {
            return base.CheckIfAllowEditMaster();
        }

        protected override bool EditMaster()
        {
            return PackageCollection.EditReal(EntityMasterSelectedId);
        }

        protected override bool CheckIfAllowDeleteMaster()
        {
            return false;
        }

        protected override bool DeleteMaster()
        {
            return base.DeleteMaster();
        }

        private void selectBoxFilterClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            Criteria.ClientId = selectBoxFilterClient.GetSelectedId();
            Products.ProductCollection.PopulateSelectBox(new Products.ProductFilterCriteria { ClientId = Criteria.ClientId }, selectBoxFilterProduct, Criteria.ProductId, true);
        }

        protected override void ClickContextMenuMasterReports(ToolStripMenuItem menuItemClicked)
        {
            if (menuItemClicked == menuItemMasterReportsLabel)
            {
                if (LabelPrinterName != string.Empty)
                {
                    string printResult = string.Empty;
                    bool printedOK = false;
                    int countLabelsPrinted = 0;
                    do
                    {
                        Package obj;
                        List<Package> packageList = new List<Package>();
                        foreach (int id in gridViewMaster.GetSelectedIdList())
                        {
                            obj = Packages.PackageCollection.GetById(Model, id, false);
                            if (obj != null)
                            {
                                packageList.Add(obj);
                            }
                        }
                        foreach (var package in packageList.OrderBy(o => o.Code).ToList())
                        {
                            printResult += Labels.LabelCollection.PrintPackage(package, LabelPrinterName);
                            countLabelsPrinted++;
                        }
                        if (printResult == string.Empty)
                        {
                            printedOK = true;
                        }
                        else
                        {
                            if (MessageBox.Show("A intervenit o eroare la imprimarea etichetei de pachet. Doriti sa reincercati imprimarea?" + Environment.NewLine + Environment.NewLine + "Eroarea este:" + Environment.NewLine + printResult, "ATENTIE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                            {
                                printedOK = true;
                            }
                        }
                    } while (!printedOK);

                    MessageBox.Show("S-au imprimat " + countLabelsPrinted.ToString() + " etichete", "INFORMATIE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nu este definita imprimanta de etichete pe acest calculator. Mai intai defineste aceasta imprimanta de la Meniul Principal - Configurare", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
