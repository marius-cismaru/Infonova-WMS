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
    public partial class DeliveryFormEdit : CustomControls.EntityFormEdit
    {
        private EntityModelSirius Model;
        private new Delivery Entity
        {
            get { return base.Entity as Delivery; }
            set { base.Entity = value; }
        }
        private ClientDestination ClientDestinationSelected;

        public DeliveryFormEdit()
            : base()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
        }

        public override void FormEdit_Shown(object sender, EventArgs e)
        {
            Entity = DeliveryCollection.GetById(Model, EntityId, false);
            SetFormName(DeliveryCollection.EntityNameSingular);
            gridViewDeliveryOrderProducts.SetCustomColumns(DeliveryOrderProducts.DeliveryOrderProductCollection.GridViewColumnsNormal);
            gridViewDeliveryProducts.SetCustomColumns(DeliveryProducts.DeliveryProductCollection.GridViewColumnsNormal);
            gridViewPackages.SetCustomColumns(Packages.PackageCollection.GridViewColumnsWithProductAndReception);
            base.FormEdit_Shown(sender, e);
        }

        public override void LoadFieldsFromEntity()
        {
            textBoxClient.Text = Entity.Client.ToString();
            textBoxWarehouse.Text = Entity.Warehouse.ToString();
            textBoxDelivery.Text = Entity.ToString();
            ClientDestinations.ClientDestinationCollection.PopulateSelectBox(new ClientDestinations.ClientDestinationFilterCriteria { ClientId = Entity.Client.Id }, selectBoxClientDestination, Entity.ClientDestination != null ? Entity.ClientDestination.Id : 0, false);
            CommonLibs.EnumsLib.PopulateSelectBox<Delivery.OptionsOrderType>(selectBoxOrderType, Entity.OptionOrderType);
            textBoxNumber.Text = Entity.Number.ToString();
            dateTimePickerDateCreation.Value = Entity.DateCreation;
            textBoxOrderNumber.Text = Entity.OrderNumber;
            dateTimePickerOrderDate.Value = Entity.OrderDate;
            textBoxRepresentativeName.Text = Entity.RepresentativeName;
            textBoxRepresentativeID.Text = Entity.RepresentativeID;
            textBoxConveyance.Text = Entity.Conveyance;
            textBoxSeal.Text = Entity.Seal;
            textBoxComment.Text = Entity.Comment;

            DeliveryOrderProducts.DeliveryOrderProductCollection.PopulateGridViewNormal(new DeliveryOrderProducts.DeliveryOrderProductFilterCriteria { DeliveryId = Entity.Id }, gridViewDeliveryOrderProducts);

            Packages.PackageCollection.PopulateGridViewWithProductAndReception(Entity.Id, gridViewPackages);
        }

        public override bool SaveFieldsToEntity()
        {
            bool result = false;
            int number = 0;
            int.TryParse(textBoxNumber.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out number);
            if (number <= 0)
            {
                MessageBox.Show("Numar de livrare incorect. S-a completat cu numarul original al livrarii", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                number = Entity.Number;
                textBoxNumber.Text = number.ToString();
            }
            else
            {
                if (Deliveries.DeliveryCollection.CheckIfExistsByNumberExceptSelf(Configuration.Main.LoggedCompanyId, number, Entity.Id))
                {
                    MessageBox.Show("Livrarea cu acest numar mai exista deja. Modifica numarul livrarii sau lasa liber pentru a se completa automat cu numarul original al livrarii.", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if ((textBoxRepresentativeName.Text.Trim() != string.Empty) || ((textBoxRepresentativeName.Text.Trim() == string.Empty) && (MessageBox.Show("Nume reprezentant client necompletat. Se continua asa?", "ATENTIE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)))
                    {
                        if ((textBoxSeal.Text.Trim() != string.Empty) || ((textBoxSeal.Text.Trim() == string.Empty) && (MessageBox.Show("Sigiliu necompletat. Se continua asa?", "ATENTIE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)))
                        {
                            if (ClientDestinationSelected != null)
                            {
                                Entity.Number = number;
                                Entity.DateCreation = dateTimePickerDateCreation.Value;
                                Entity.OptionOrderType = CommonLibs.EnumsLib.GetSelectBoxSelectedEnum<Delivery.OptionsOrderType>(selectBoxOrderType);
                                Entity.OrderNumber = textBoxOrderNumber.Text.Trim();
                                Entity.OrderDate = dateTimePickerOrderDate.Value;
                                Entity.ClientDestination = ClientDestinationSelected;
                                Entity.RepresentativeName = textBoxRepresentativeName.Text.Trim();
                                Entity.RepresentativeID = textBoxRepresentativeID.Text.Trim().ToUpperInvariant();
                                Entity.Conveyance = textBoxConveyance.Text.Trim();
                                Entity.Seal = textBoxSeal.Text;
                                Entity.Comment = textBoxComment.Text;
                                result = true;
                            }
                            else
                            {
                                MessageBox.Show("Destinatie client nedefinita. Foloseste butonul Gestionare.", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            if (result)
            {
                Model.SaveChanges();
            }

            return result;
        }

        private void selectBoxClientDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClientDestinationSelected = ClientDestinations.ClientDestinationCollection.GetById(Model, selectBoxClientDestination.GetSelectedId(), true);
        }

        private void buttonClientDestinationsBrowse_Click(object sender, EventArgs e)
        {
            ClientDestinations.ClientDestinationCollection.Browse();
            Model.Refresh(System.Data.Objects.RefreshMode.StoreWins, Model.ClientDestinations);
            ClientDestinations.ClientDestinationCollection.PopulateSelectBox(new ClientDestinations.ClientDestinationFilterCriteria { ClientId = Entity.Client.Id }, selectBoxClientDestination, ClientDestinationSelected != null ? ClientDestinationSelected.Id : 0, false);
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedTab == tabPageDeliveryProducts)
            {
                DeliveryProducts.DeliveryProductCollection.PopulateGridViewNormal(new DeliveryProducts.DeliveryProductFilterCriteria { DeliveryId = Entity.Id }, gridViewDeliveryProducts);
            }
        }

        private void buttonDeliveryOrderProductsAdd_Click(object sender, EventArgs e)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                DeliveryOrderProduct orderProductNew = new DeliveryOrderProduct();
                orderProductNew.Delivery = Deliveries.DeliveryCollection.GetById(model, Entity.Id, false);
                orderProductNew.Product = Products.ProductCollection.GetCollection(model, new Products.ProductFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId, ClientId = Entity.Client.Id }).FirstOrDefault();
                if (DeliveryOrderProducts.DeliveryOrderProductCollection.Add(model, orderProductNew))
                {
                    var orderProductToReplace = model.DeliveryOrderProducts.FirstOrDefault(o => o.Delivery.Id == Entity.Id && o.Product.Id == orderProductNew.Product.Id);
                    if (orderProductToReplace != null)
                    {
                        if (MessageBox.Show("Acest articol mai exista deja. Doresti inlocuirea cantitatilor?", "ATENTIE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                        {
                            orderProductToReplace.Quantity = orderProductNew.Quantity;
                            orderProductToReplace.WeightNet = orderProductNew.WeightNet;
                            model.Detach(orderProductNew);
                        }
                    }
                    else
                    {
                        model.DeliveryOrderProducts.AddObject(orderProductNew);
                    }

                    model.SaveChanges();

                    DeliveryOrderProducts.DeliveryOrderProductCollection.PopulateGridViewNormal(new DeliveryOrderProducts.DeliveryOrderProductFilterCriteria { DeliveryId = Entity.Id }, gridViewDeliveryOrderProducts);
                }
            }
        }

        private void buttonDeliveryOrderProductsDelete_Click(object sender, EventArgs e)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                int selectedId = gridViewDeliveryOrderProducts.GetSelectedId();
                var obj = model.DeliveryOrderProducts.FirstOrDefault(o => o.Id == selectedId);
                if (obj != null)
                {
                    if (!model.Packages.Any(o => o.Delivery != null && o.Delivery.Id == Entity.Id && o.Product.Id == obj.Product.Id))
                    {
                        if (MessageBox.Show("Esti sigur ca doresti sa stergi articolul selectat?", "INTREBARE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            model.DeliveryOrderProducts.DeleteObject(obj);
                            model.SaveChanges();
                            DeliveryOrderProducts.DeliveryOrderProductCollection.PopulateGridViewNormal(new DeliveryOrderProducts.DeliveryOrderProductFilterCriteria { DeliveryId = Entity.Id }, gridViewDeliveryOrderProducts);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Exista deja pachete livrate pe acest articol. Pentru a putea sterge acest articol, trebuie mai intai sterse toate pachetele ce contin acest articol.", "INTREBARE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void buttonPackagesAdd_Click(object sender, EventArgs e)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                var orderProductList = DeliveryOrderProducts.DeliveryOrderProductCollection.GetCollection(model, new DeliveryOrderProducts.DeliveryOrderProductFilterCriteria { DeliveryId = Entity.Id });
                if (orderProductList.Count() > 0)
                {
                    using (Packages.PackageFormSelect formSelect = new Packages.PackageFormSelect())
                    {
                        formSelect.WarehouseId = Entity.Warehouse.Id;
                        formSelect.ClientId = Entity.Client.Id;
                        formSelect.ProductIdsList = orderProductList.Select(o => o.Product.Id).ToList();
                        var packageSelected = Packages.PackageCollection.GetById(model, gridViewPackages.GetSelectedId(), false);
                        formSelect.ProductSelectedId = packageSelected != null ? packageSelected.Product.Id : 0;
                        formSelect.PackageAlreadySelectedIdsList = model.Packages.Where(o => o.Delivery != null && o.Delivery.Id == Entity.Id).Select(o => o.Id).ToList();

                        if (formSelect.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            if (formSelect.PackageNewlySelectedIdsList.Count > 0)
                            {
                                Package package;
                                Delivery delivery = Deliveries.DeliveryCollection.GetById(model, Entity.Id, false);
                                foreach (var id in formSelect.PackageNewlySelectedIdsList)
                                {
                                    package = Packages.PackageCollection.GetById(model, id, false);
                                    if (package != null)
                                    {
                                        package.Delivery = delivery;
                                    }
                                }
                            }
                            model.SaveChanges();
                            Packages.PackageCollection.PopulateGridViewWithProductAndReception(Entity.Id, gridViewPackages);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nu se pot introduce pachete pentru ca nu sunt introduse cantitati de pe documentul client!", "ATENTIE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void buttonPackagesDelete_Click(object sender, EventArgs e)
        {
            var idList = gridViewPackages.GetSelectedIdList();
            if (idList.Count > 0)
            {
                if (MessageBox.Show("Esti sigur ca doresti sa stergi cel(e) " + idList.Count.ToString() + " pachet(e) selectate din livrare?", "INTREBARE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
                    {
                        Package package;
                        foreach (var id in idList)
                        {
                            package = Packages.PackageCollection.GetById(model, id, false);
                            if (package != null)
                            {
                                package.Delivery = null;
                            }
                        }
                        model.SaveChanges();
                        Packages.PackageCollection.PopulateGridViewWithProductAndReception(Entity.Id, gridViewPackages);
                    }
                }
            }
        }
    }
}
