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
    public partial class PackageFormEditReal : CustomControls.EntityFormEdit
    {
        public EntityModelSirius Model;
        public new Package Entity
        {
            get { return base.Entity as Package; }
            set { base.Entity = value; }
        }
        public string LabelPrinterName;

        private Product ProductSelected;
        private PackageType PackageTypeSelected;
        private WarehouseContainer WarehouseContainerSelected;

        public PackageFormEditReal()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
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
            Entity = Packages.PackageCollection.GetById(Model, EntityId, false);
            if (Entity == null)
            {
                MessageBox.Show("Pachet nedefinit.", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            base.FormEdit_Shown(sender, e);
        }

        public override void LoadFieldsFromEntity()
        {
            checkBoxDoLabelPrint.Checked = Configuration.Personal.ReceptionDoLabelPrint;

            ReceptionOrderProducts.ReceptionOrderProductCollection.PopulateSelectBox(Model.ReceptionOrderProducts.Where(o=>o.Reception.Id == Entity.Reception.Id).ToList(), selectBoxProduct, Entity.Product != null ? Entity.Product.Id : 0);
            PackageTypes.PackageTypeCollection.PopulateSelectBox(selectBoxPackageType, Entity.PackageType != null ? Entity.PackageType.Id : 0, false);

            textBoxCode.Text = Entity.Code;
            textBoxDateProduction.Text = CommonLibs.StringsLib.ConvertFromDateToShortString(Entity.DateProduction);
            textBoxDateExpiration.Text = CommonLibs.StringsLib.ConvertFromDateToShortString(Entity.DateExpiration);
            textBoxQuantity.Text = Entity.Quantity.ToString();
            textBoxWeightGross.Text = Entity.WeightGross.ToString();
            textBoxWarehouseContainer.Text = Entity.WarehouseContainer.ToString();
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
                bool validationOK = true;
                string validationText = string.Empty;
                double quantity = 0, weightNet = 0, weightGross = 0;
                DateTime? dateProduction, dateExpiration;
                int shelfLife;

                validationOK &= ProductSelected != null;
                validationText += ProductSelected == null ? (Environment.NewLine + " - Articol inexistent") : string.Empty;
                validationOK &= PackageTypeSelected != null;
                validationText += PackageTypeSelected == null ? (Environment.NewLine + " - Tip pachet inexistent") : string.Empty;

                bool isDuplicateCode = Packages.PackageCollection.CheckIfExistsByCodeExceptSelf(textBoxCode.Text.Trim().ToUpper(), Entity.Id);
                validationOK &= !isDuplicateCode;
                validationText += isDuplicateCode ? (Environment.NewLine + " - Cod: mai exista deja (duplicat)") : string.Empty;

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

                WarehouseContainerSelected = WarehouseContainers.WarehouseContainerCollection.GetByName(Model, textBoxWarehouseContainer.Text.Trim());
                if (WarehouseContainerSelected == null)
                {
                    validationOK = false;
                    validationText += Environment.NewLine + " - Container: inexistent";
                }
                else
                {
                    bool warehouseContainerAvailable = WarehouseContainers.WarehouseContainerCollection.CheckIfAvailableByIdExceptSelfPackage(WarehouseContainerSelected.Id, Entity.Id);
                    validationOK &= warehouseContainerAvailable;
                    validationText += !warehouseContainerAvailable ? (Environment.NewLine + " - Container: nedisponibil sau ocupat") : string.Empty;
                }

                if (validationOK)
                {
                    Entity.Code = textBoxCode.Text.Trim().ToUpper();
                    Entity.WarehouseContainer = WarehouseContainerSelected;
                    Entity.Product = ProductSelected;
                    Entity.PackageType = PackageTypeSelected;
                    Entity.Batch = textBoxBatch.Text.Trim();
                    Entity.ContainerInitial = WarehouseContainerSelected.ToString();
                    Entity.DateProduction = dateProduction.Value;
                    Entity.DateExpiration = dateExpiration.Value;
                    Entity.Quantity = quantity;
                    Entity.WeightNet = weightNet;
                    Entity.WeightGross = weightGross;
                    Entity.Description = textBoxDescription.Text.Trim();

                    Model.SaveChanges();

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
            return result;
        }

        private void selectBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductSelected = Products.ProductCollection.GetById(Model, selectBoxProduct.GetSelectedId(), false);
            if (ProductSelected != null)
            {
                labelQuantity.Text = "Cantitate [" + ProductSelected.MeasuringUnit.ToString() + "]";
                textBoxQuantity_TextChanged(sender, e);
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

        private void buttonConfigurationStationBrowse_Click(object sender, EventArgs e)
        {
            ConfigurationStations.ConfigurationStationCollection.Browse();
            Model.Refresh(System.Data.Objects.RefreshMode.StoreWins, Model.ConfigurationStations);
            GetLabelPrinterNameFromConfiguration();
        }

        private void buttonWarehouseContainerSelect_Click(object sender, EventArgs e)
        {
            List<int> warehouseContainerIdList = WarehouseContainers.WarehouseContainerCollection.Select(Entity.Reception.Warehouse.Id, 1);
            if (warehouseContainerIdList.Count > 0)
            {
                WarehouseContainerSelected = WarehouseContainers.WarehouseContainerCollection.GetById(Model, warehouseContainerIdList[0], false);
                if (WarehouseContainerSelected != null)
                {
                    textBoxWarehouseContainer.Text = WarehouseContainerSelected.ToString();
                }
            }
        }
    }
}
