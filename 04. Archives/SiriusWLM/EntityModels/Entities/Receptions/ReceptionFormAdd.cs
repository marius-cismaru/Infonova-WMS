using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Sirius.EntityModels.Receptions
{
    public partial class ReceptionFormAddVirtual : CustomControls.EntityFormAdd
    {
        public string LabelPrinter { get; set; }

        private new Reception Entity
        {
            get { return base.Entity as Reception; }
            set { base.Entity = value; }
        }

        private EntityModelSirius Model;
        private Client ClientSelected;
        private Warehouse WarehouseSelected;
        private WarehouseRoom WarehouseRoomSelected;
        private WarehouseRow WarehouseRowSelected;
        private List<WarehouseContainer> WarehouseContainerList;
        private List<ReceptionOrderProduct> ReceptionOrderProductList;
        private List<ReceptionProduct> ReceptionProductList;
        private List<Package> PackageList;
        private List<WarehouseContainers.WarehouseContainerLocation> WarehouseContainerLocationList;

        private int IndexReceptionOrderProduct;
        private int IndexPackage;

        public ReceptionFormAddVirtual()
        {
            InitializeComponent();

            LabelPrinter = string.Empty;

            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
            ClientSelected = null;
            WarehouseSelected = null;
            Entity = new Reception();
            ReceptionOrderProductList = new List<ReceptionOrderProduct>();
            ReceptionProductList = new List<ReceptionProduct>();
            WarehouseContainerList = new List<WarehouseContainer>();
            PackageList = new List<Package>();
            WarehouseContainerLocationList = new List<WarehouseContainers.WarehouseContainerLocation>();

            IndexReceptionOrderProduct = 1;
            IndexPackage = 1;
        }

        private void LoadFieldsFromReception()
        {
            dateTimePickerReceptionDateCreation.Value = Entity.DateCreation;
            CommonLibs.EnumsLib.PopulateSelectBox<Reception.OptionsOrderType>(selectBoxReceptionOrderType, Entity.OptionOrderType);
            textBoxReceptionOrderNumber.Text = Entity.OrderNumber;
            dateTimePickerReceptionOrderDate.Value = Entity.OrderDate;
            textBoxReceptionRepresentativeName.Text = Entity.RepresentativeName;
            textBoxReceptionRepresentativeID.Text = Entity.RepresentativeID;
            textBoxReceptionConveyance.Text = Entity.Conveyance;
            textBoxReceptionComment.Text = Entity.Comment;
        }

        private bool SaveFieldsToReception()
        {
            bool result = false;

            int number = 0;
            int.TryParse(textBoxReceptionNumber.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out number);
            if (number <= 0)
            {
                MessageBox.Show("Numar de receptie incorect. S-a completat cu urmatorul numar din baza de date", "ATENTIE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxReceptionNumber.Text = (Receptions.ReceptionCollection.GetMaxNumber(Configuration.Main.LoggedCompanyId, ClientSelected.Id) + 1).ToString();
            }
            else
            {
                if (Receptions.ReceptionCollection.CheckIfExistsByNumber(Configuration.Main.LoggedCompanyId, ClientSelected.Id, number))
                {
                    MessageBox.Show("Receptia cu acest numar mai exista deja. Modifica numarul receptiei sau lasa liber pentru a se completa automat cu urmatorul numar din baza de date.", "ATENTIE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if ((textBoxReceptionOrderNumber.Text.Trim() != string.Empty) || ((textBoxReceptionOrderNumber.Text.Trim() == string.Empty) && (MessageBox.Show("Numar document client necompletat. Se continua asa?", "ATENTIE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)))
                    {
                        if ((textBoxReceptionRepresentativeName.Text.Trim() != string.Empty) || ((textBoxReceptionRepresentativeName.Text.Trim() == string.Empty) && (MessageBox.Show("Nume reprezentant client necompletat. Se continua asa?", "ATENTIE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)))
                        {
                            Entity.Number = number;
                            Entity.DateCreation = dateTimePickerReceptionDateCreation.Value;
                            Entity.OptionOrderType = CommonLibs.EnumsLib.GetSelectBoxSelectedEnum<Reception.OptionsOrderType>(selectBoxReceptionOrderType);
                            Entity.OrderNumber = textBoxReceptionOrderNumber.Text.Trim();
                            Entity.OrderDate = dateTimePickerReceptionOrderDate.Value;
                            Entity.RepresentativeName = textBoxReceptionRepresentativeName.Text.Trim();
                            Entity.RepresentativeID = textBoxReceptionRepresentativeID.Text.Trim().ToUpperInvariant();
                            Entity.Conveyance = textBoxReceptionConveyance.Text.Trim();
                            Entity.Comment = textBoxReceptionComment.Text;
                            Entity.Client = ClientSelected;
                            Entity.Warehouse = WarehouseSelected;
                            Entity.User = Users.UserCollection.GetById(Model, Configuration.Main.LoggedUserId);
                            result = true;
                        }
                    }
                }
            }

            return result;
        }

        private WarehouseContainer GetNextFreeWarehouseContainerForNewPackage()
        {
            var containersUsed = from o in PackageList
                                 select o.WarehouseContainer;

            var collection = from o in WarehouseContainerList
                             where !containersUsed.Contains(o)
                             select o;
            return collection.FirstOrDefault();
        }

        protected override bool PreviousPageWizard()
        {
            bool allowPrevious = true;

            if (tabControlWizard.SelectedTab == tabPageStep5)
            {
                /*allowPrevious = PackageList.Count == 0;
                if (!allowPrevious)
                {
                    MessageBox.Show("S-au receptionat deja pachete. Nu se mai pot face modificari la datele receptiei. Pentru a putea face modificari, trebuie sterse toate pachetele receptionate deja.", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
            }

            return allowPrevious;
        }

        protected override bool NextPageWizard()
        {
            bool allowNext = true;

            if (tabControlWizard.SelectedTab == tabPageStep1)
            {
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
                allowNext = SaveFieldsToReception();
            }

            if (tabControlWizard.SelectedTab == tabPageStep3)
            {
                allowNext = ReceptionOrderProductList.Count > 0;
                if (!allowNext)
                {
                    MessageBox.Show("Trebuie introdus cel putin un articol.", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (tabControlWizard.SelectedTab == tabPageStep5)
            {
                allowNext = PackageList.Count > 0;
                if (!allowNext)
                {
                    MessageBox.Show("Trebuie receptionat cel putin un pachet.", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return allowNext;
        }

        protected override void ChangedPageWizard()
        {
            if (tabControlWizard.SelectedTab == tabPageStep1)
            {
                selectBoxClient.Enabled = (ReceptionOrderProductList.Count == 0) || (!ReceptionOrderProductList.Any(o => o.Reception.Client.Id == ClientSelected.Id));
                selectBoxWarehouse.Enabled = (PackageList.Count == 0) || (!PackageList.Any(o=>o.WarehouseContainer.WarehouseRow.WarehouseRoom.Warehouse.Id == WarehouseSelected.Id));
            }

            if (tabControlWizard.SelectedTab == tabPageStep2)
            {
            }

            if (tabControlWizard.SelectedTab == tabPageStep3)
            {
            }

            if (tabControlWizard.SelectedTab == tabPageStep4)
            {
                WarehouseRooms.WarehouseRoomCollection.PopulateSelectBoxWithAvailable(new WarehouseRooms.WarehouseRoomFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId, WarehouseId = WarehouseSelected.Id }, selectBoxWarehouseRoom, (WarehouseRoomSelected != null ? WarehouseRoomSelected.Id : 0), false);
            }

            if (tabControlWizard.SelectedTab == tabPageStep5)
            {
            }

            if (tabControlWizard.SelectedTab == tabPageStep6)
            {
                ReceptionProducts.ReceptionProductCollection.PopulateGridViewNormal(ReceptionOrderProductList, ReceptionProductList, PackageList, gridViewReceptionProducts);
            }
        }

        protected override void ShowForm()
        {
            SetFormName(Receptions.ReceptionCollection.EntityNameSingular);

            //Step1
            labelHeaderClient.Text = "Client: - , Depozit: -";
            Clients.ClientCollection.PopulateSelectBox(new Clients.ClientFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId }, selectBoxClient, 0, false);
            Warehouses.WarehouseCollection.PopulateSelectBox(new Warehouses.WarehouseFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId }, selectBoxWarehouse, 0, false);

            //Step2
            LoadFieldsFromReception();

            //Step3
            gridViewReceptionOrderProducts.SetCustomColumns(ReceptionOrderProducts.ReceptionOrderProductCollection.GridViewColumnsNormal);

            //Step4

            //Step5
            gridViewPackages.SetCustomColumns(Packages.PackageCollection.GridViewColumnsWithPosition);

            //Step6
            gridViewReceptionProducts.SetCustomColumns(ReceptionProducts.ReceptionProductCollection.GridViewColumnsNormal);
        }

        private void selectBoxWarehouseRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            WarehouseRoomSelected = WarehouseRooms.WarehouseRoomCollection.GetById(Model, selectBoxWarehouseRoom.GetSelectedId(), false);
            if (WarehouseRoomSelected != null)
            {
                WarehouseRows.WarehouseRowCollection.PopulateSelectBoxWithAvailable(new WarehouseRows.WarehouseRowFilterCriteria { WarehouseRoomId = WarehouseRoomSelected.Id, OptionIsLimited = WarehouseRows.WarehouseRowFilterCriteria.OptionsIsLimited.Yes }, selectBoxWarehouseRow, (WarehouseRowSelected != null ? WarehouseRowSelected.Id : 0), false);
            }
        }

        private void selectBoxWarehouseRow_SelectedIndexChanged(object sender, EventArgs e)
        {
            WarehouseRowSelected = WarehouseRows.WarehouseRowCollection.GetById(Model, selectBoxWarehouseRow.GetSelectedId(), false);
            if (WarehouseRowSelected != null)
            {
                pictureBoxWarehouseContainers.Refresh();
            }
        }

        private void pictureBoxWarehouseContainers_Paint(object sender, PaintEventArgs e)
        {
            WarehouseContainerLocationList = WarehouseRows.WarehouseRowCollection.RenderOnGraphics(Model, e.Graphics, WarehouseRowSelected, WarehouseContainerList, PackageList);
            WarehouseContainers.WarehouseContainerCollection.PopulateListBoxPackageRelation(WarehouseContainerList, PackageList, listBoxWarehouseContainers);
        }

        private void pictureBoxWarehouseContainers_MouseUp(object sender, MouseEventArgs e)
        {
            int i = 0;
            WarehouseContainer container = null;
            while ((container == null) && (i < WarehouseContainerLocationList.Count))
            {
                if(WarehouseContainerLocationList[i].Location.Contains(e.Location)) container = WarehouseContainerLocationList[i].Container;
                i++;
            }
            if (container != null)
            {
                if ((container.IsAvailable) && ((!container.WarehouseRow.IsLimited) || ((container.Packages.Count == 0) || (container.Packages.All(o => o.Delivery != null)))))
                {
                    if (WarehouseContainerList.Contains(container))
                    {
                        WarehouseContainerList.Remove(container);
                    }
                    else
                    {
                        WarehouseContainerList.Add(container);
                    }
                    pictureBoxWarehouseContainers.Refresh();
                }
            }
        }

        private void buttonWarehouseContainersReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sigur doriti sa goliti lista cu containere?", "ATENTIE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                WarehouseContainerList.Clear();
                WarehouseContainers.WarehouseContainerCollection.PopulateListBoxPackageRelation(WarehouseContainerList, PackageList, listBoxWarehouseContainers);
                pictureBoxWarehouseContainers.Refresh();
            }
        }

        protected override bool FinishWizard()
        {
            bool result = false;

            if (MessageBox.Show("Esti sigur ca doresti sa finalizezi receptia?", "INTREBARE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Reception reception;
                using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
                {
                    reception = new Reception();
                    reception.BatchList = Entity.BatchList;
                    reception.Client = Clients.ClientCollection.GetById(model, Entity.Client.Id, false);
                    reception.Comment = Entity.Comment;
                    reception.Conveyance = Entity.Conveyance;
                    reception.DateCreation = Entity.DateCreation;
                    reception.Number = Entity.Number;
                    reception.OrderType = Entity.OrderType;
                    reception.OrderDate = Entity.OrderDate;
                    reception.OrderNumber = Entity.OrderNumber;
                    reception.RepresentativeID = Entity.RepresentativeID;
                    reception.RepresentativeName = Entity.RepresentativeName;
                    reception.User = Users.UserCollection.GetById(model, Entity.User.Id);
                    reception.Warehouse = Warehouses.WarehouseCollection.GetById(model, Entity.Warehouse.Id, false);
                    model.Receptions.AddObject(reception);

                    ReceptionOrderProduct receptionOrderProduct;
                    foreach (var obj in ReceptionOrderProductList)
                    {
                        receptionOrderProduct = new ReceptionOrderProduct();
                        receptionOrderProduct.Product = Products.ProductCollection.GetById(model, obj.Product.Id, false);
                        receptionOrderProduct.Quantity = obj.Quantity;
                        receptionOrderProduct.Reception = reception;
                        receptionOrderProduct.WeightGross = obj.WeightGross;
                        receptionOrderProduct.WeightNet = obj.WeightNet;
                        model.ReceptionOrderProducts.AddObject(receptionOrderProduct);
                    }

                    Package package;
                    foreach (var obj in PackageList)
                    {
                        package = new Package();
                        package.Batch = obj.Batch;
                        package.Code = obj.Code;
                        package.ContainerInitial = obj.ContainerInitial;
                        package.DateExpiration = obj.DateExpiration;
                        package.DateProduction = obj.DateProduction;
                        package.Description = obj.Description;
                        package.PackageType = PackageTypes.PackageTypeCollection.GetById(model, obj.PackageType.Id, false);
                        package.Product = Products.ProductCollection.GetById(model, obj.Product.Id, false);
                        package.Quantity = obj.Quantity;
                        package.Reception = reception;
                        package.WarehouseContainer = WarehouseContainers.WarehouseContainerCollection.GetById(model, obj.WarehouseContainer.Id, false);
                        package.WeightGross = obj.WeightGross;
                        package.WeightNet = obj.WeightNet;
                        model.Packages.AddObject(package);
                    }

                    ReceptionProduct receptionProduct;
                    foreach (var obj in ReceptionProductList)
                    {
                        receptionProduct = new ReceptionProduct();
                        receptionProduct.Batch = obj.Batch;
                        receptionProduct.IsQualityOK = obj.IsQualityOK;
                        receptionProduct.Observation = obj.Observation;
                        receptionProduct.Origin = obj.Origin;
                        receptionProduct.PackageCount = obj.PackageCount;
                        receptionProduct.Product = Products.ProductCollection.GetById(model, obj.Product.Id, false);
                        receptionProduct.QuantityOrder = obj.QuantityOrder;
                        receptionProduct.QuantityReception = obj.QuantityReception;
                        receptionProduct.Reception = reception;
                        receptionProduct.Temperature = obj.Temperature;
                        model.ReceptionProducts.AddObject(receptionProduct);
                    }

                    model.SaveChanges();
                }

                /* Constructia de mai jos da erori la salvare - Container nu exista in relatie
                Model.Receptions.AddObject(Entity);

                foreach (var obj in ReceptionOrderProductList)
                {
                    Model.ReceptionOrderProducts.AddObject(obj);
                }

                foreach (var obj in ReceptionProductList)
                {
                    Model.ReceptionProducts.AddObject(obj);
                }

                foreach (var obj in PackageList)
                {
                    Model.Packages.AddObject(obj);
                }

                Model.SaveChanges();
                */

                Reports.ReportReceptionNote.ShowDialog(new Reports.ReportReceptionNoteFilterCriteria { ReceptionId = reception.Id });

                MessageBox.Show("Receptie salvata", "SUCCES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = true;
            }

            return result;
        }

        private void buttonClientBrowse_Click(object sender, EventArgs e)
        {
            Clients.ClientCollection.Browse();
            Model.Refresh(System.Data.Objects.RefreshMode.StoreWins, Model.Clients);
            Clients.ClientCollection.PopulateSelectBox(new Clients.ClientFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId }, selectBoxClient, ClientSelected != null ? ClientSelected.Id : 0, false);
        }

        private void buttonWarehouseBrowse_Click(object sender, EventArgs e)
        {
            Warehouses.WarehouseCollection.Browse();
            Model.Refresh(System.Data.Objects.RefreshMode.StoreWins, Model.Warehouses);
            Warehouses.WarehouseCollection.PopulateSelectBox(new Warehouses.WarehouseFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId }, selectBoxWarehouse, WarehouseSelected != null ? WarehouseSelected.Id : 0, false);
        }

        private void buttonReceptionOrderProductsAdd_Click(object sender, EventArgs e)
        {
            ReceptionOrderProduct productNew = new ReceptionOrderProduct();
            productNew.Id = IndexReceptionOrderProduct++;
            productNew.Reception = Entity;
            productNew.Product = ClientSelected.Products.FirstOrDefault();
            if (ReceptionOrderProducts.ReceptionOrderProductCollection.Add(Model, productNew))
            {
                var productToReplace = ReceptionOrderProductList.FirstOrDefault(o => o.Product.Id == productNew.Product.Id);
                if (productToReplace != null)
                {
                    if (MessageBox.Show("Acest articol mai exista deja. Doresti inlocuirea cantitatilor?", "ATENTIE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                    {
                        productToReplace.Quantity = productNew.Quantity;
                        productToReplace.WeightNet = productNew.WeightNet;
                        productToReplace.WeightGross = productNew.WeightGross;
                    }
                }
                else
                {
                    ReceptionOrderProductList.Add(productNew);
                }
                ReceptionOrderProducts.ReceptionOrderProductCollection.PopulateGridViewNormal(ReceptionOrderProductList, gridViewReceptionOrderProducts);
            }
        }

        private void buttonReceptionOrderProductsDelete_Click(object sender, EventArgs e)
        {
            int selectedId = gridViewReceptionOrderProducts.GetSelectedId();
            var obj = ReceptionOrderProductList.FirstOrDefault(o => o.Id == selectedId);
            if (obj != null)
            {
                if (!PackageList.Any(o => o.Product.Id == obj.Product.Id))
                {
                    if (MessageBox.Show("Esti sigur ca doresti sa stergi articolul selectat?", "INTREBARE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        var objToDelete = ReceptionOrderProductList.FirstOrDefault(o => o.Id == selectedId);
                        Model.Detach(objToDelete);
                        if (ReceptionOrderProductList.Remove(objToDelete))
                        {
                            ReceptionOrderProducts.ReceptionOrderProductCollection.PopulateGridViewNormal(ReceptionOrderProductList, gridViewReceptionOrderProducts);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Exista deja pachete receptionate pe acest articol. Pentru a putea sterge acest articol, trebuie mai intai sterse toate pachetele ce contin acest articol.", "INTREBARE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void buttonPackagesAdd_Click(object sender, EventArgs e)
        {
            Package packageNew = new Package();
            packageNew.Id = IndexPackage++;
            packageNew.Reception = Entity;
            if (Packages.PackageCollection.AddVirtual(Model, packageNew, ReceptionOrderProductList, PackageList, GetNextFreeWarehouseContainerForNewPackage()))
            {
                PackageList.Add(packageNew);
                Packages.PackageCollection.PopulateGridViewWithPosition(PackageList, gridViewPackages);
            }
        }

        private void buttonPackagesDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esti sigur ca doresti sa stergi pachetul selectat si toate pachetele introduse dupa acest pachet?", "INTREBARE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int selectedId = gridViewPackages.GetSelectedId();
                var objListToDelete = PackageList.Where(o => (o.Id >= selectedId)).ToList();
                foreach (var obj in objListToDelete)
                {
                    Model.Detach(obj);
                }
                if (PackageList.RemoveAll(o => (o.Id >= selectedId)) > 0)
                {
                    Packages.PackageCollection.PopulateGridViewWithPosition(PackageList, gridViewPackages);
                }
            }
        }

        private void buttonReceptionProductsEdit_Click(object sender, EventArgs e)
        {
            int selectedId = gridViewReceptionProducts.GetSelectedId();
            ReceptionProduct product = ReceptionProductList.FirstOrDefault(o => o.Id == selectedId);
            if (product != null)
            {
                if (ReceptionProducts.ReceptionProductCollection.Edit(product))
                {
                    ReceptionProducts.ReceptionProductCollection.PopulateGridViewNormal(Model, ReceptionProductList, gridViewReceptionProducts);
                }
            }
        }

        private void selectBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClientSelected = Clients.ClientCollection.GetById(Model, selectBoxClient.GetSelectedId(), false);
            if (ClientSelected != null)
            {
                textBoxReceptionNumber.Text = (Receptions.ReceptionCollection.GetMaxNumber(Configuration.Main.LoggedCompanyId, ClientSelected.Id) + 1).ToString();
            }
        }

        private void selectBoxWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            WarehouseSelected = Warehouses.WarehouseCollection.GetById(Model, selectBoxWarehouse.GetSelectedId(), false);
        }
    }
}
