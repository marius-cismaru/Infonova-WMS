using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Sirius.EntityModels.Deliveries
{
    public partial class DeliveryFormAdd : CustomControls.EntityFormAdd
    {
        private new Delivery Entity
        {
            get { return base.Entity as Delivery; }
            set { base.Entity = value; }
        }

        private EntityModelSirius Model;
        private Client ClientSelected;
        private Warehouse WarehouseSelected;
        private ClientDestination ClientDestinationSelected;
        private List<DeliveryOrderProduct> DeliveryOrderProductList;
        private List<Package> PackageSelectedList;
        private List<Package> PackagePickedList;

        private int IndexDeliveryOrderProduct;
        private bool CanPickPackages;

        public DeliveryFormAdd()
        {
            InitializeComponent();

            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
            ClientSelected = null;
            WarehouseSelected = null;
            Entity = new Delivery();
            DeliveryOrderProductList = new List<DeliveryOrderProduct>();
            PackageSelectedList = new List<Package>();
            PackagePickedList = new List<Package>();

            IndexDeliveryOrderProduct = 1;
            CanPickPackages = true;
        }

        private void LoadFieldsFromDeliveryStep2()
        {
            textBoxDeliveryNumber.Text = Entity.Number.ToString();
            dateTimePickerDeliveryDateCreation.Value = Entity.DateCreation;
            CommonLibs.EnumsLib.PopulateSelectBox<Delivery.OptionsOrderType>(selectBoxDeliveryOrderType, Entity.OptionOrderType);
            textBoxDeliveryOrderNumber.Text = Entity.OrderNumber;
            dateTimePickerDeliveryOrderDate.Value = Entity.OrderDate;
        }

        private void LoadFieldsFromDeliveryStep9()
        {
            ClientDestinations.ClientDestinationCollection.PopulateSelectBox(new ClientDestinations.ClientDestinationFilterCriteria { ClientId = ClientSelected.Id }, selectBoxDeliveryClientDestination, 0, false);
            textBoxDeliveryRepresentativeName.Text = Entity.RepresentativeName;
            textBoxDeliveryRepresentativeID.Text = Entity.RepresentativeID;
            textBoxDeliveryConveyance.Text = Entity.Conveyance;
            textBoxDeliverySeal.Text = Entity.Seal;
            textBoxDeliveryComment.Text = Entity.Comment;
        }

        private bool SaveFieldsToDeliveryStep2()
        {
            bool result = false;
            int number = 0;
            int.TryParse(textBoxDeliveryNumber.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out number);
            if (number <= 0)
            {
                MessageBox.Show("Numar de livrare incorect. S-a completat cu urmatorul numar din baza de date", "ATENTIE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxDeliveryNumber.Text = (Model.Deliveries.Max(o => o.Number) + 1).ToString();
            }
            else
            {
                if (Deliveries.DeliveryCollection.CheckIfExistsByNumber(Configuration.Main.LoggedCompanyId, number))
                {
                    MessageBox.Show("Livrarea cu acest numar mai exista deja. Modifica numarul livrarii sau lasa liber pentru a se completa automat cu urmatorul numar din baza de date.", "ATENTIE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if ((textBoxDeliveryOrderNumber.Text.Trim() != string.Empty) || ((textBoxDeliveryOrderNumber.Text.Trim() == string.Empty) && (MessageBox.Show("Numar document client necompletat. Se continua asa?", "ATENTIE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)))
                    {
                        Entity.Number = number;
                        Entity.DateCreation = dateTimePickerDeliveryDateCreation.Value;
                        Entity.OptionOrderType = CommonLibs.EnumsLib.GetSelectBoxSelectedEnum<Delivery.OptionsOrderType>(selectBoxDeliveryOrderType);
                        Entity.OrderNumber = textBoxDeliveryOrderNumber.Text.Trim();
                        Entity.OrderDate = dateTimePickerDeliveryOrderDate.Value;
                        Entity.Client = ClientSelected;
                        Entity.Warehouse = WarehouseSelected;
                        Entity.User = Users.UserCollection.GetById(Model, Configuration.Main.LoggedUserId);
                        result = true;
                    }
                }
            }
            return result;
        }

        private bool SaveFieldsToDeliveryStep9()
        {
            bool result = false;
            if ((textBoxDeliveryRepresentativeName.Text.Trim() != string.Empty) || ((textBoxDeliveryRepresentativeName.Text.Trim() == string.Empty) && (MessageBox.Show("Nume reprezentant client necompletat. Se continua asa?", "ATENTIE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)))
            {
                if ((textBoxDeliverySeal.Text.Trim() != string.Empty) || ((textBoxDeliverySeal.Text.Trim() == string.Empty) && (MessageBox.Show("Sigiliu necompletat. Se continua asa?", "ATENTIE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)))
                {
                    if (ClientDestinationSelected != null)
                    {
                        Entity.ClientDestination = ClientDestinationSelected;
                        Entity.RepresentativeName = textBoxDeliveryRepresentativeName.Text.Trim();
                        Entity.RepresentativeID = textBoxDeliveryRepresentativeID.Text.Trim().ToUpperInvariant();
                        Entity.Conveyance = textBoxDeliveryConveyance.Text.Trim();
                        Entity.Seal = textBoxDeliverySeal.Text;
                        Entity.Comment = textBoxDeliveryComment.Text;
                        result = true;
                    }
                    else
                    {
                        MessageBox.Show("Destinatie client nedefinita. Foloseste butonul Gestionare.", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return result;
        }

        private bool PickPackages()
        {
            bool result = false;
            if (CanPickPackages)
            {
                if (Entity.OptionPickMethod == Delivery.OptionsPickMethod.AutoFIFODateProduction)
                {
                    PackageSelectedList.Clear();
                    foreach (var product in DeliveryOrderProductList)
                    {
                        bool overpicked = false;
                        var packageCollection = Packages.PackageCollection.GetCollection(Model, new Packages.PackageFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId, ClientId = ClientSelected.Id, WarehouseId = WarehouseSelected.Id, ProductId = product.Product.Id, OptionIsExisting = Packages.PackageFilterCriteria.OptionsIsExisting.Yes });
                        packageCollection = from o in packageCollection
                                            orderby o.DateProduction, o.Reception.DateCreation, o.WarehouseContainer.WarehouseRow.WarehouseRoom.Code, o.WarehouseContainer.WarehouseRow.Code, o.WarehouseContainer.Interval, o.WarehouseContainer.Floor descending, o.WarehouseContainer.Interval
                                            select o;
                        double quantityTotal = 0;
                        foreach (var obj in packageCollection)
                        {
                            quantityTotal += obj.Quantity;
                            if (quantityTotal < product.Quantity)
                            {
                                PackageSelectedList.Add(obj);
                            }
                            else
                            {
                                if ((checkBoxDeliveryAllowOverdelivery.Checked) && (!overpicked))
                                {
                                    PackageSelectedList.Add(obj);
                                    overpicked = true;
                                }
                            }
                        }
                    }
                    Packages.PackageCollection.PopulateGridViewWithPosition(PackageSelectedList, gridViewPackagesSelect);
                    result = true;
                }
                CanPickPackages = false;
            }
            return result;
        }

        protected override bool NextPageWizard()
        {
            bool allowNext = true;

            if (tabControlWizard.SelectedTab == tabPageStep1)
            {
                ClientSelected = Clients.ClientCollection.GetById(Model, selectBoxClient.GetSelectedId(), false);
                WarehouseSelected = Warehouses.WarehouseCollection.GetById(Model, selectBoxWarehouse.GetSelectedId(), false);
                if ((ClientSelected != null) && (WarehouseSelected != null))
                {
                    labelHeaderClient.Text = "Client: " + ClientSelected.ToString() + ", Depozit: " + WarehouseSelected.ToString();
                }
                else
                {
                    MessageBox.Show("Trebuie sa existe cel putin un client si un depozit configurat. Apasa butonul Gestionare din dreptul lor pentru a adauga clienti sau depozite noi", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    allowNext = false;
                }
            }

            if (tabControlWizard.SelectedTab == tabPageStep2)
            {
                allowNext = SaveFieldsToDeliveryStep2();
            }

            if (tabControlWizard.SelectedTab == tabPageStep3)
            {
                allowNext = DeliveryOrderProductList.Count > 0;
                if (!allowNext)
                {
                    MessageBox.Show("Trebuie introdus cel putin un articol.", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (tabControlWizard.SelectedTab == tabPageStep4)
            {
                Entity.OptionPickMethod = CommonLibs.EnumsLib.GetSelectBoxSelectedEnum<Delivery.OptionsPickMethod>(selectBoxDeliveryPickMethod);
            }

            if (tabControlWizard.SelectedTab == tabPageStep5)
            {
                allowNext = PackageSelectedList.Count > 0;
                if (!allowNext)
                {
                    MessageBox.Show("Trebuie selectat pentru livrare cel putin un pachet.", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (tabControlWizard.SelectedTab == tabPageStep6)
            {
                Reports.ReportDeliveryPickingList.ShowDialog(new Reports.ReportDeliveryPickingListFilterCriteria { Delivery = Entity, PackageList = PackageSelectedList });
            }

            if (tabControlWizard.SelectedTab == tabPageStep7)
            {
                allowNext = PackagePickedList.Count > 0;
                if (!allowNext)
                {
                    MessageBox.Show("Trebuie cules cel putin un pachet.", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (tabControlWizard.SelectedTab == tabPageStep9)
            {
                allowNext = SaveFieldsToDeliveryStep9();
            }

            return allowNext;
        }

        protected override void ChangedPageWizard()
        {
            if (tabControlWizard.SelectedTab == tabPageStep1)
            {
            }

            if (tabControlWizard.SelectedTab == tabPageStep3)
            {
            }

            if (tabControlWizard.SelectedTab == tabPageStep4)
            {
                CommonLibs.EnumsLib.PopulateSelectBox<Delivery.OptionsPickMethod>(selectBoxDeliveryPickMethod, Entity.OptionPickMethod);
                CanPickPackages = true;
            }

            if (tabControlWizard.SelectedTab == tabPageStep5)
            {
                PickPackages();
            }

            if (tabControlWizard.SelectedTab == tabPageStep6)
            {
                DeliveryProducts.DeliveryProductCollection.PopulateGridViewNormal(Model, DeliveryOrderProductList, PackageSelectedList, gridViewDeliveryProductsSelectVerify);
            }

            if (tabControlWizard.SelectedTab == tabPageStep7)
            {
                checkedListBoxDeliveryProductsPick.ItemCheck -= checkedListBoxDeliveryProductsPick_ItemCheck;
                Packages.PackageCollection.PopulateCheckedListBox(Model, PackageSelectedList, PackagePickedList, checkedListBoxDeliveryProductsPick);
                checkedListBoxDeliveryProductsPick.ItemCheck += checkedListBoxDeliveryProductsPick_ItemCheck;
            }

            if (tabControlWizard.SelectedTab == tabPageStep8)
            {
                DeliveryProducts.DeliveryProductCollection.PopulateGridViewNormal(Model, DeliveryOrderProductList, PackagePickedList, gridViewDeliveryProductsPickVerify);
            }

            if (tabControlWizard.SelectedTab == tabPageStep9)
            {
                LoadFieldsFromDeliveryStep9();
            }
        }

        protected override void ShowForm()
        {
            SetFormName(Deliveries.DeliveryCollection.EntityNameSingular);

            //Step1
            labelHeaderClient.Text = "Client: - , Depozit: -";
            Clients.ClientCollection.PopulateSelectBox(new Clients.ClientFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId }, selectBoxClient, 0, false);
            Warehouses.WarehouseCollection.PopulateSelectBox(new Warehouses.WarehouseFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId }, selectBoxWarehouse, 0, false);

            //Step2
            if (Model.Deliveries.Count() > 0)
            {
                Entity.Number = Model.Deliveries.Max(o => o.Number) + 1;
            }
            else
            {
                Entity.Number = 1;
            }
            LoadFieldsFromDeliveryStep2();

            //Step3
            gridViewDeliveryOrderProducts.SetCustomColumns(DeliveryOrderProducts.DeliveryOrderProductCollection.GridViewColumnsNormal);

            //Step5
            gridViewPackagesSelect.SetCustomColumns(Packages.PackageCollection.GridViewColumnsWithPosition);

            //Step6
            gridViewDeliveryProductsSelectVerify.SetCustomColumns(DeliveryProducts.DeliveryProductCollection.GridViewColumnsNormal);

            //Step8
            gridViewDeliveryProductsPickVerify.SetCustomColumns(DeliveryProducts.DeliveryProductCollection.GridViewColumnsNormal);

            //Step9
        }

        protected override bool FinishWizard()
        {
            bool result = false;

            if (MessageBox.Show("Esti sigur ca doresti sa finalizezi livrarea?", "INTREBARE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (SaveFieldsToDeliveryStep9())
                {
                    Delivery delivery;
                    using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
                    {
                        delivery = new Delivery();
                        delivery.Client = Clients.ClientCollection.GetById(model, Entity.Client.Id, false);
                        delivery.ClientDestination = ClientDestinations.ClientDestinationCollection.GetById(model, Entity.ClientDestination.Id, false);
                        delivery.Comment = Entity.Comment;
                        delivery.Conveyance = Entity.Conveyance;
                        delivery.DateCreation = Entity.DateCreation;
                        delivery.Number = Entity.Number;
                        delivery.OrderType = Entity.OrderType;
                        delivery.OrderNumber = Entity.OrderNumber;
                        delivery.OrderDate = Entity.OrderDate;
                        delivery.RepresentativeID = Entity.RepresentativeID;
                        delivery.RepresentativeName = Entity.RepresentativeName;
                        delivery.Seal = Entity.Seal;
                        delivery.User = Users.UserCollection.GetById(model, Entity.User.Id);
                        delivery.Warehouse = Warehouses.WarehouseCollection.GetById(model, Entity.Warehouse.Id, false);

                        model.Deliveries.AddObject(delivery);

                        DeliveryOrderProduct deliveryOrderProduct;
                        foreach (var obj in DeliveryOrderProductList)
                        {
                            deliveryOrderProduct = new DeliveryOrderProduct();
                            deliveryOrderProduct.Delivery = delivery;
                            deliveryOrderProduct.Product = Products.ProductCollection.GetById(model, obj.Product.Id, false);
                            deliveryOrderProduct.Quantity = obj.Quantity;
                            deliveryOrderProduct.WeightNet = obj.WeightNet;

                            model.DeliveryOrderProducts.AddObject(deliveryOrderProduct);
                        }

                        Package package;
                        foreach (var obj in PackagePickedList)
                        {
                            package = Packages.PackageCollection.GetById(model, obj.Id, false);
                            package.Delivery = delivery;
                        }

                        model.SaveChanges();
                    }

                    /*
                    Model.Deliveries.AddObject(Entity);

                    foreach (var obj in DeliveryOrderProductList)
                    {
                        Model.DeliveryOrderProducts.AddObject(obj);
                    }

                    for (int i = 0; i < PackagePickedList.Count; i++)
                    {
                        PackagePickedList[i].Delivery = Entity;
                    }

                    Model.SaveChanges();
                    */

                    Reports.ReportDeliveryNotice.ShowDialog(new Reports.ReportDeliveryNoticeFilterCriteria { DeliveryId = delivery.Id });

                    MessageBox.Show("Livrare salvata", "SUCCES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    result = true;
                }
            }

            return result;
        }

        private void buttonDeliveryOrderProductsAdd_Click(object sender, EventArgs e)
        {
            DeliveryOrderProduct productNew = new DeliveryOrderProduct();
            productNew.Id = IndexDeliveryOrderProduct++;
            productNew.Delivery = Entity;
            productNew.Product = ClientSelected.Products.FirstOrDefault();
            if (DeliveryOrderProducts.DeliveryOrderProductCollection.Add(Model, productNew))
            {
                if (DeliveryOrderProductList.FirstOrDefault(o => o.Product == productNew.Product) == null)
                {
                    DeliveryOrderProductList.Add(productNew);
                }
                else
                {
                    if (MessageBox.Show("Acest articol mai exista deja. Doresti inlocuirea cantitatilor?", "ATENTIE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                    {
                        var productToReplace = DeliveryOrderProductList.FirstOrDefault(o => o.Product == productNew.Product);
                        productToReplace.Quantity = productNew.Quantity;
                        productToReplace.WeightNet = productNew.WeightNet;
                    }
                }
                DeliveryOrderProducts.DeliveryOrderProductCollection.PopulateGridViewNormal(DeliveryOrderProductList, gridViewDeliveryOrderProducts);
            }
        }

        private void buttonDeliveryOrderProductsDelete_Click(object sender, EventArgs e)
        {
            int selectedId = gridViewDeliveryOrderProducts.GetSelectedId();
            var obj = DeliveryOrderProductList.FirstOrDefault(o => o.Id == selectedId);
            if (obj != null)
            {
                if (!PackageSelectedList.Any(o => o.Product.Id == obj.Product.Id))
                {
                    if (MessageBox.Show("Esti sigur ca doresti sa stergi articolul selectat?", "INTREBARE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        Model.Detach(obj);
                        if (DeliveryOrderProductList.Remove(obj))
                        {
                            DeliveryOrderProducts.DeliveryOrderProductCollection.PopulateGridViewNormal(DeliveryOrderProductList, gridViewDeliveryOrderProducts);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Exista deja pachete selectate pentru livrare pe acest articol. Pentru a putea sterge acest articol, trebuie mai intai sterse toate pachetele ce contin acest articol.", "INTREBARE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void buttonPackagesSelectAdd_Click(object sender, EventArgs e)
        {
            using (Packages.PackageFormSelect formSelect = new Packages.PackageFormSelect())
            {
                formSelect.WarehouseId = WarehouseSelected.Id;
                formSelect.ClientId = ClientSelected.Id;
                formSelect.ProductIdsList = new List<int>();
                foreach (var obj in DeliveryOrderProductList)
                {
                    formSelect.ProductIdsList.Add(obj.Product.Id);
                }
                var packageSelected = Packages.PackageCollection.GetById(Model, gridViewPackagesSelect.GetSelectedId(), false);
                formSelect.ProductSelectedId = packageSelected != null ? packageSelected.Product.Id : 0;
                formSelect.PackageAlreadySelectedIdsList = new List<int>();
                foreach (var obj in PackageSelectedList)
                {
                    formSelect.PackageAlreadySelectedIdsList.Add(obj.Id);
                }

                if (formSelect.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (var obj in formSelect.PackageNewlySelectedIdsList)
                    {
                        PackageSelectedList.Add(Packages.PackageCollection.GetById(Model, obj, true));
                    }
                    Packages.PackageCollection.PopulateGridViewWithPosition(PackageSelectedList, gridViewPackagesSelect);
                }
            }
        }

        private void buttonPackagesSelectDelete_Click(object sender, EventArgs e)
        {
            var idList = gridViewPackagesSelect.GetSelectedIdList();
            if (idList.Count > 0)
            {
                foreach (var id in idList)
                {
                    var package = Packages.PackageCollection.GetById(Model, id, false);
                    if (package != null)
                    {
                        Model.Detach(package);
                        PackageSelectedList.Remove(package);
                    }
                }
                Packages.PackageCollection.PopulateGridViewWithPosition(PackageSelectedList, gridViewPackagesSelect);
            }
        }

        private void checkedListBoxDeliveryProductsPick_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                PackagePickedList.Add(PackageSelectedList[e.Index]);
            }
            else
            {
                PackagePickedList.Remove(PackageSelectedList[e.Index]);
            }
        }

        private void buttonDeliveryProductsPickSelectAll_Click(object sender, EventArgs e)
        {
            PackagePickedList.Clear();
            for (int i = 0; i < checkedListBoxDeliveryProductsPick.Items.Count; i++)
            {
                PackagePickedList.Add(PackageSelectedList[i]);
                checkedListBoxDeliveryProductsPick.ItemCheck -= checkedListBoxDeliveryProductsPick_ItemCheck;
                checkedListBoxDeliveryProductsPick.SetItemChecked(i, true);
                checkedListBoxDeliveryProductsPick.ItemCheck += checkedListBoxDeliveryProductsPick_ItemCheck;
            }
        }

        private void buttonDeliveryProductsPickSelectNone_Click(object sender, EventArgs e)
        {
            PackagePickedList.Clear();
            for (int i = 0; i < checkedListBoxDeliveryProductsPick.Items.Count; i++)
            {
                checkedListBoxDeliveryProductsPick.ItemCheck -= checkedListBoxDeliveryProductsPick_ItemCheck;
                checkedListBoxDeliveryProductsPick.SetItemChecked(i, false);
                checkedListBoxDeliveryProductsPick.ItemCheck += checkedListBoxDeliveryProductsPick_ItemCheck;
            }
        }

        private void buttonDeliveryClientDestinationsBrowse_Click(object sender, EventArgs e)
        {
            ClientDestinations.ClientDestinationCollection.Browse();
            Model.Refresh(System.Data.Objects.RefreshMode.StoreWins, Model.ClientDestinations);
            ClientDestinations.ClientDestinationCollection.PopulateSelectBox(new ClientDestinations.ClientDestinationFilterCriteria { ClientId = Entity.Client.Id }, selectBoxDeliveryClientDestination, ClientDestinationSelected != null ? ClientDestinationSelected.Id : 0, false);
        }

        private void selectBoxDeliveryClientDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClientDestinationSelected = ClientDestinations.ClientDestinationCollection.GetById(Model, selectBoxDeliveryClientDestination.GetSelectedId(), false);
        }
    }
}
