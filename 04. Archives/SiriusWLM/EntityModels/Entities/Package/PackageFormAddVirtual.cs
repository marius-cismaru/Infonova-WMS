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
    public partial class PackageFormAddVirtual : CustomControls.EntityFormEdit
    {
        public EntityModelSirius Model;
        public new Package Entity
        {
            get { return base.Entity as Package; }
            set { base.Entity = value; }
        }
        public List<ReceptionOrderProduct> ReceptionOrderProductList;
        public List<Package> PackageList;
        public WarehouseContainer WarehouseContainerNext;
        public string LabelPrinterName;

        private Package EntityPrevious;
        private Product ProductSelected;
        private PackageType PackageTypeSelected;
        private WarehouseContainer WarehouseContainerSelected;

        public PackageFormAddVirtual()
        {
            InitializeComponent();
            //Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
            //Entity = new Package();
        }

        private void PopulateTextBoxShelfLife()
        {
            int result = 0;
            DateTime? dateProduction = CommonLibs.StringsLib.ConvertFromShortStringToDate(textBoxDateProduction.Text);
            DateTime? dateExpiration = CommonLibs.StringsLib.ConvertFromShortStringToDate(textBoxDateExpiration.Text);
            if ((dateProduction != null) && (dateExpiration != null))
            {
                result = dateExpiration.Value.Subtract(dateProduction.Value).Days;
            }
            textBoxShelfLife.Text = result.ToString();
        }

        private void PopulateTextBoxDateExpiration()
        {
            DateTime dateExpiration;
            DateTime? dateProduction = CommonLibs.StringsLib.ConvertFromShortStringToDate(textBoxDateProduction.Text);
            int shelfLife = 0;
            int.TryParse(textBoxShelfLife.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out shelfLife);
            if (dateProduction != null)
            {
                dateExpiration = dateProduction.Value.AddDays(shelfLife);
                textBoxDateExpiration.Text = CommonLibs.StringsLib.ConvertFromDateToShortString(dateExpiration);
            }
            else
            {
                textBoxDateExpiration.Text = string.Empty;
            }
        }

        private void GetLabelPrinterNameFromConfiguration()
        {
            LabelPrinterName = "- Nedefinit -";
            var configuration = ConfigurationStations.ConfigurationStationCollection.GetForThisStation(Model);
            if (configuration != null)
            {
                LabelPrinterName = configuration.LabelPrinterName;
            }
            textBoxLabelPrinterName.Text = LabelPrinterName;
        }

        public override void FormEdit_Shown(object sender, EventArgs e)
        {
            GetLabelPrinterNameFromConfiguration();
            Text = "Adaugare " + Packages.PackageCollection.EntityNameSingular + " nou";

            base.FormEdit_Shown(sender, e);
        }

        public override void LoadFieldsFromEntity()
        {
            checkBoxDoLabelPrint.Checked = Configuration.Personal.ReceptionDoLabelPrint;
            if (PackageList.Count > 0)
            {
                EntityPrevious = PackageList[PackageList.Count - 1];
            }
            if (EntityPrevious != null)
            {
                Entity.Batch = EntityPrevious.Batch;
                Entity.Description = EntityPrevious.Description;
                Entity.DateExpiration = EntityPrevious.DateExpiration;
                Entity.DateProduction = EntityPrevious.DateProduction;
                Entity.PackageType = EntityPrevious.PackageType;
                Entity.Product = EntityPrevious.Product;
            }

            ReceptionOrderProducts.ReceptionOrderProductCollection.PopulateSelectBox(ReceptionOrderProductList, selectBoxProduct, Entity.Product != null ? Entity.Product.Id : 0);
            PackageTypes.PackageTypeCollection.PopulateSelectBox(selectBoxPackageType, Entity != null ? (Entity.PackageType != null ? Entity.PackageType.Id : 0) : 0, false);
            CustomControls.EntityItem itemWarehouseContainerNext = null;
            if (WarehouseContainerNext != null)
            {
                itemWarehouseContainerNext = new CustomControls.EntityItem { Id = 0, Name = "Din cele selectate - " + WarehouseContainerNext.Name };
            }
            WarehouseContainers.WarehouseContainerCollection.PopulateSelectBoxWithUnlimited(new WarehouseContainers.WarehouseContainerFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId, WarehouseId = Entity.Reception.Warehouse.Id }, selectBoxWarehouseContainer, 0, itemWarehouseContainerNext);

            //Entity.Code = Packages.PackageCollection.GenerateNewCode(Entity.Reception.Client.NameSymbol1, Entity.Reception.Number, selectBoxProduct.SelectedIndex, PackageList.Count(o => o.Product.Id == ProductSelected.Id) + 1);

            //textBoxCode.Text = Entity.Code;
            textBoxDateProduction.Text = CommonLibs.StringsLib.ConvertFromDateToShortString(Entity.DateProduction);
            textBoxDateExpiration.Text = CommonLibs.StringsLib.ConvertFromDateToShortString(Entity.DateExpiration);
            textBoxBatch.Text = Entity.Batch;
            textBoxDescription.Text = Entity.Description;

            base.LoadFieldsFromEntity();
        }

        public override bool SaveFieldsToEntity()
        {
            bool result = false;

            Configuration.Personal.ReceptionDoLabelPrint = checkBoxDoLabelPrint.Checked;
            if ((checkBoxDoLabelPrint.Checked) && (LabelPrinterName == string.Empty))
            {
                MessageBox.Show("Nu este configurata imprimanta de etichete. Da click pe butonul Configurare din dreptul imprimantei", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                WarehouseContainer warehouseContainerNext = WarehouseContainerSelected;
                if (warehouseContainerNext == null)
                {
                    warehouseContainerNext = WarehouseContainerNext;
                }
                if (warehouseContainerNext != null)
                {
                    bool validationOK = true;
                    string validationText = string.Empty;
                    double quantity = 0, weightNet = 0, weightGross = 0;
                    DateTime? dateProduction, dateExpiration;
                    int shelfLife;

                    dateProduction = CommonLibs.StringsLib.ConvertFromShortStringToDate(textBoxDateProduction.Text);
                    validationOK &= dateProduction != null;
                    validationText += dateProduction == null ? (Environment.NewLine + " - Data productie: incorecta") : string.Empty;
                    dateExpiration = CommonLibs.StringsLib.ConvertFromShortStringToDate(textBoxDateExpiration.Text);
                    validationOK &= dateExpiration != null;
                    validationText += dateExpiration == null ? (Environment.NewLine + " - Data expirare: incorecta") : string.Empty;
                    int.TryParse(textBoxShelfLife.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out shelfLife);
                    validationOK &= shelfLife >= 0;
                    validationText += shelfLife < 0 ? (Environment.NewLine + " - Valabilitate: negativa") : string.Empty;
                    validationOK &= double.TryParse(textBoxQuantity.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out quantity);
                    validationText += quantity <= 0 ? (Environment.NewLine + " - Cantitate: incorecta") : string.Empty;
                    validationOK &= double.TryParse(textBoxWeightNet.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out weightNet);
                    validationText += weightNet <= 0 ? (Environment.NewLine + " - Greutate neta: valoare negativa sau zero") : string.Empty;
                    validationOK &= weightNet <= PackageTypeSelected.WeightNetMaxSupported;
                    validationText += weightNet > PackageTypeSelected.WeightNetMaxSupported ? (Environment.NewLine + "Greutate neta: valoare mai mare decat suporta tipul pachetului (max. " + PackageTypeSelected.WeightNetMaxSupported.ToString() + " Kg)") : string.Empty;

                    double.TryParse(textBoxWeightGross.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out weightGross);
                    validationOK &= weightGross >= 0;
                    validationText += weightGross < 0 ? (Environment.NewLine + " - Greutate bruta: valoare negativa") : string.Empty;

                    validationOK &= weightGross >= weightNet;
                    validationText += weightGross < weightNet ? (Environment.NewLine + " - Greutate bruta: mai mica decat greutatea neta") : string.Empty;

                    validationOK &= ProductSelected != null;
                    validationText += ProductSelected == null ? (Environment.NewLine + " - Articol inexistent") : string.Empty;
                    validationOK &= PackageTypeSelected != null;
                    validationText += PackageTypeSelected == null ? (Environment.NewLine + " - Tip pachet inexistent") : string.Empty;

                    if (validationOK)
                    {
                        Entity.WarehouseContainer = warehouseContainerNext;
                        Entity.Product = ProductSelected;
                        Entity.PackageType = PackageTypeSelected;
                        Entity.Batch = textBoxBatch.Text.Trim();
                        Entity.ContainerInitial = warehouseContainerNext.Name;
                        Entity.DateProduction = dateProduction.Value;
                        Entity.DateExpiration = dateExpiration.Value;
                        Entity.Quantity = quantity;
                        Entity.WeightNet = weightNet;
                        Entity.WeightGross = weightGross;
                        Entity.Description = textBoxDescription.Text.Trim();

                        //Imprimare eticheta adeziva pachet
                        if (checkBoxDoLabelPrint.Checked)
                        {
                            if (LabelPrinterName != string.Empty)
                            {
                                string printResult = string.Empty;
                                bool printedOK = false;
                                do
                                {
                                    printResult = Labels.LabelCollection.PrintPackage(Entity, LabelPrinterName);
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
                            }
                        }
                        result = true;
                    }
                    else
                    {
                        MessageBox.Show("Eroare introducere date:" + validationText, "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nu mai exista containere alocate. Intoarce-te la pasul anterior si aloca containere suplimentare sau selecteaza un container nelimitat.", "ATENTIE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            return result;
        }

        private void selectBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductSelected = Products.ProductCollection.GetById(Model, selectBoxProduct.GetSelectedId(), false);
            if (ProductSelected != null)
            {
                labelQuantity.Text = "Cantitate [" + ProductSelected.MeasuringUnit.ToString() + "]";
                textBoxQuantity_TextChanged(sender, e);
                Entity.Code = Packages.PackageCollection.GenerateNewCode(Entity.Reception.Client.NameSymbol1, Entity.Reception.Number, ReceptionOrderProductList.FindIndex(o => o.Product.Id == ProductSelected.Id), PackageList.Count(o => o.Product.Id == ProductSelected.Id) + 1);
                textBoxCode.Text = Entity.Code;
            }
        }

        private void selectBoxPackageType_SelectedIndexChanged(object sender, EventArgs e)
        {
            PackageTypeSelected = PackageTypes.PackageTypeCollection.GetById(Model, selectBoxPackageType.GetSelectedId(), false);
        }

        private void buttonPackageTypeBrowse_Click(object sender, EventArgs e)
        {
            PackageTypes.PackageTypeCollection.Browse();
            Model.Refresh(System.Data.Objects.RefreshMode.StoreWins, Model.PackageTypes);
            PackageTypes.PackageTypeCollection.PopulateSelectBox(selectBoxPackageType, PackageTypeSelected != null ? PackageTypeSelected.Id : 0, false);
        }

        private void textBoxDateProduction_TextChanged(object sender, EventArgs e)
        {
            PopulateTextBoxShelfLife();
        }

        private void textBoxDateExpiration_TextChanged(object sender, EventArgs e)
        {
            PopulateTextBoxShelfLife();
        }

        private void textBoxShelfLife_TextChanged(object sender, EventArgs e)
        {
            PopulateTextBoxDateExpiration();
        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            if (ProductSelected != null)
            {
                double quantity;
                double.TryParse(textBoxQuantity.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out quantity);
                textBoxWeightNet.Text = (quantity * ProductSelected.ConversionFactorKg).ToString("0.00", CultureInfo.InvariantCulture);
            }
        }

        private void selectBoxWarehouseContainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            WarehouseContainerSelected = WarehouseContainers.WarehouseContainerCollection.GetById(Model, selectBoxWarehouseContainer.GetSelectedId(), false);
        }

        private void buttonConfigurationStationBrowse_Click(object sender, EventArgs e)
        {
            ConfigurationStations.ConfigurationStationCollection.Browse();
            Model.Refresh(System.Data.Objects.RefreshMode.StoreWins, Model.ConfigurationStations);
            GetLabelPrinterNameFromConfiguration();
        }
    }
}
