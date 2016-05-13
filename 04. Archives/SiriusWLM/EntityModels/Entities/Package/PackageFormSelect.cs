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
    public partial class PackageFormSelect : Form
    {
        public int ClientId;
        public int WarehouseId;
        public int ClientSelectedId;
        public int ProductSelectedId;
        public List<int> ProductIdsList;
        public List<int> PackageAlreadySelectedIdsList;
        public List<int> PackageNewlySelectedIdsList;

        private EntityModelSirius Model;

        public PackageFormSelect()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
            ClientId = 0;
            ProductSelectedId = 0;
            ProductIdsList = new List<int>();
            PackageAlreadySelectedIdsList = new List<int>();
            PackageNewlySelectedIdsList = new List<int>();
        }

        private void RefreshPackages()
        {
            int receptionNumber = 0;
            int.TryParse(textBoxFilterReceptionNumber.Text, System.Globalization.NumberStyles.Integer, CultureInfo.InvariantCulture, out receptionNumber);
            int productId = selectBoxFilterProduct.GetSelectedId();
            string packageCode = textBoxFilterPackageCode.Text.Trim();
            var packages = from p in Model.Packages
                           where (!PackageAlreadySelectedIdsList.Contains(p.Id)) && (p.Reception.Warehouse.Id == WarehouseId) && ((ClientSelectedId == 0) || (p.Reception.Client.Id == ClientSelectedId)) && ((ProductSelectedId == 0) || (p.Product.Id == ProductSelectedId)) && ((receptionNumber == 0) || (p.Reception.Number == receptionNumber)) && ((packageCode == string.Empty) || (p.Code.Contains(packageCode))) && (p.Delivery == null)
                           orderby p.DateProduction
                           select p;
            Packages.PackageCollection.PopulateGridViewWithReception(packages.ToList(), gridView);
            if (packages.Count() > 0)
            {
                labelMainFooterWeightNetTotal.Text = "TOTAL Greutate Neta: " + packages.Sum(o => o.WeightNet).ToString("0.00", CultureInfo.InvariantCulture) + " Kg";
            }
            else
            {
                labelMainFooterWeightNetTotal.Text = "TOTAL Greutate Neta: 0 Kg";
            }
        }

        private void FormSelect_Shown(object sender, EventArgs e)
        {
            Text = "Selectare pachete";
            gridView.SetCustomColumns(Packages.PackageCollection.GridViewColumnsWithReception);
            Warehouse warehouse = Warehouses.WarehouseCollection.GetById(Model, WarehouseId, true);
            textBoxFilterWarehouse.Text = warehouse != null ? warehouse.ToString() : "- Nedefinit -";
            Clients.ClientCollection.PopulateSelectBox(new Clients.ClientFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId, ClientId = ClientId }, selectBoxFilterClient, ClientSelectedId, ClientId == 0 ? true : false);

            RefreshPackages();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            RefreshPackages();
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            gridView.SelectAll();
        }

        private void buttonSelectNone_Click(object sender, EventArgs e)
        {
            gridView.ClearSelection();
            if (gridView.Rows.Count > 0)
            {
                gridView.Rows[0].Selected = true;
                gridView.CurrentCell = gridView.Rows[0].Cells[1];
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            PackageNewlySelectedIdsList = gridView.GetSelectedIdList();
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void selectBoxFilterClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClientSelectedId = selectBoxFilterClient.GetSelectedId();
            Products.ProductCollection.PopulateSelectBox(ClientSelectedId, ProductIdsList, selectBoxFilterProduct, ProductSelectedId, ProductIdsList.Count == 0 ? true : false);
        }

        private void selectBoxFilterProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductSelectedId = selectBoxFilterProduct.GetSelectedId();
        }

        private void gridView_SelectionChanged(object sender, EventArgs e)
        {
            var packageSelectedIdList = gridView.GetSelectedIdList();
            var packages = from o in Model.Packages
                           where packageSelectedIdList.Contains(o.Id)
                           select o;
            if (packages.Count() > 0)
            {
                labelMainFooterWeightNetSelected.Text = "SELECTAT Greutate Neta: " + packages.Sum(o => o.WeightNet).ToString("0.00", CultureInfo.InvariantCulture) + " Kg";
            }
            else
            {
                labelMainFooterWeightNetSelected.Text = "SELECTAT Greutate Neta: 0 Kg";
            }
        }
    }
}
