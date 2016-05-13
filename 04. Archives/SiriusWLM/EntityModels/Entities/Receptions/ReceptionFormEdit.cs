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
    public partial class ReceptionFormEdit : CustomControls.EntityFormEdit
    {
        private EntityModelSirius Model;
        private new Reception Entity {
            get { return base.Entity as Reception; }
            set { base.Entity = value; }
        }

        public ReceptionFormEdit()
            : base()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
        }

        private void RefreshPackages()
        {
            ReceptionProducts.ReceptionProductCollection.UpdateFromPackagesReal(Entity.Id);
            Packages.PackageCollection.PopulateGridViewWithProductAndDelivery(Entity.Id, gridViewPackages);
            ReceptionProducts.ReceptionProductCollection.PopulateGridViewNormal(new ReceptionProducts.ReceptionProductFilterCriteria { ReceptionId = Entity.Id }, gridViewReceptionProducts);
        }

        public override void FormEdit_Shown(object sender, EventArgs e)
        {
            Entity = ReceptionCollection.GetById(Model, EntityId, false);
            SetFormName(ReceptionCollection.EntityNameSingular);
            gridViewReceptionOrderProducts.SetCustomColumns(ReceptionOrderProducts.ReceptionOrderProductCollection.GridViewColumnsNormal);
            gridViewReceptionProducts.SetCustomColumns(ReceptionProducts.ReceptionProductCollection.GridViewColumnsNormal);
            gridViewPackages.SetCustomColumns(Packages.PackageCollection.GridViewColumnsWithProductAndDelivery);
            base.FormEdit_Shown(sender, e);
        }

        public override void LoadFieldsFromEntity()
        {
            textBoxClient.Text = Entity.Client.ToString();
            textBoxWarehouse.Text = Entity.Warehouse.ToString();
            textBoxReception.Text = Entity.ToString();
            CommonLibs.EnumsLib.PopulateSelectBox<Reception.OptionsOrderType>(selectBoxOrderType, Entity.OptionOrderType);
            textBoxNumber.Text = Entity.Number.ToString();
            dateTimePickerDateCreation.Value = Entity.DateCreation;
            textBoxOrderNumber.Text = Entity.OrderNumber;
            dateTimePickerOrderDate.Value = Entity.OrderDate;
            textBoxRepresentativeName.Text = Entity.RepresentativeName;
            textBoxRepresentativeID.Text = Entity.RepresentativeID;
            textBoxConveyance.Text = Entity.Conveyance;
            textBoxBatchList.Text = Entity.BatchList;
            textBoxComment.Text = Entity.Comment;

            ReceptionOrderProducts.ReceptionOrderProductCollection.PopulateGridViewNormal(new ReceptionOrderProducts.ReceptionOrderProductFilterCriteria { ReceptionId = Entity.Id }, gridViewReceptionOrderProducts);
            Packages.PackageCollection.PopulateGridViewWithProductAndDelivery(Entity.Id, gridViewPackages);
            ReceptionProducts.ReceptionProductCollection.PopulateGridViewNormal(new ReceptionProducts.ReceptionProductFilterCriteria { ReceptionId = Entity.Id }, gridViewReceptionProducts);
        }

        public override bool SaveFieldsToEntity()
        {
            bool result = false;

            int number = 0;
            int.TryParse(textBoxNumber.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out number);
            if (number <= 0)
            {
                MessageBox.Show("Numar de receptie incorect. S-a completat cu numarul original al receptiei", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                number = Entity.Number;
                textBoxNumber.Text = number.ToString();
            }
            else
            {
                if (Receptions.ReceptionCollection.CheckIfExistsByNumberExceptSelf(Configuration.Main.LoggedCompanyId, Entity.Client.Id, number, Entity.Id))
                {
                    MessageBox.Show("Receptia cu acest numar mai exista deja. Modifica numarul receptiei sau lasa liber pentru a se completa automat cu numarul original al receptiei.", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if ((textBoxRepresentativeName.Text.Trim() != string.Empty) || ((textBoxRepresentativeName.Text.Trim() == string.Empty) && (MessageBox.Show("Nume reprezentant client necompletat. Se continua asa?", "ATENTIE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)))
                    {
                        if ((textBoxConveyance.Text.Trim() != string.Empty) || ((textBoxConveyance.Text.Trim() == string.Empty) && (MessageBox.Show("Mijloc de transport necompletat. Se continua asa?", "ATENTIE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)))
                        {
                            Entity.Number = number;
                            Entity.DateCreation = dateTimePickerDateCreation.Value;
                            Entity.OptionOrderType = CommonLibs.EnumsLib.GetSelectBoxSelectedEnum<Reception.OptionsOrderType>(selectBoxOrderType);
                            Entity.OrderNumber = textBoxOrderNumber.Text.Trim();
                            Entity.OrderDate = dateTimePickerOrderDate.Value;
                            Entity.RepresentativeName = textBoxRepresentativeName.Text.Trim();
                            Entity.RepresentativeID = textBoxRepresentativeID.Text.Trim().ToUpperInvariant();
                            Entity.Conveyance = textBoxConveyance.Text.Trim();
                            Entity.BatchList = textBoxBatchList.Text;
                            Entity.Comment = textBoxComment.Text;
                            result = true;
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

        private void buttonReceptionOrderProductsAdd_Click(object sender, EventArgs e)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                ReceptionOrderProduct productNew = new ReceptionOrderProduct();
                productNew.Reception = Receptions.ReceptionCollection.GetById(model, Entity.Id, false);
                productNew.Product = Products.ProductCollection.GetCollection(model, new Products.ProductFilterCriteria { CompanyId = Configuration.Main.LoggedCompanyId, ClientId = Entity.Client.Id }).FirstOrDefault();
                if (ReceptionOrderProducts.ReceptionOrderProductCollection.Add(model, productNew))
                {
                    var productToReplace = model.ReceptionOrderProducts.FirstOrDefault(o => o.Reception.Id == Entity.Id && o.Product.Id == productNew.Product.Id);
                    if (productToReplace != null)
                    {
                        if (MessageBox.Show("Acest articol mai exista deja. Doresti inlocuirea cantitatilor?", "ATENTIE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                        {
                            productToReplace.Quantity = productNew.Quantity;
                            productToReplace.WeightNet = productNew.WeightNet;
                            productToReplace.WeightGross = productNew.WeightGross;
                            model.Detach(productNew);
                        }
                    }
                    else
                    {
                        model.ReceptionOrderProducts.AddObject(productNew);
                    }

                    model.SaveChanges();

                    ReceptionOrderProducts.ReceptionOrderProductCollection.PopulateGridViewNormal(new ReceptionOrderProducts.ReceptionOrderProductFilterCriteria { ReceptionId = Entity.Id }, gridViewReceptionOrderProducts);
                    RefreshPackages();
                }
            }
        }

        private void buttonReceptionOrderProductEdit_Click(object sender, EventArgs e)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                int selectedId = gridViewReceptionOrderProducts.GetSelectedId();
                var obj = model.ReceptionOrderProducts.FirstOrDefault(o => o.Id == selectedId);
                if (obj != null)
                {
                    //Pentru verificare daca s-a schimbat articolul
                    int productIdOld = obj.Product.Id;
                    double weightNet = obj.WeightNet;
                    double weightGross = obj.WeightGross;

                    if (ReceptionOrderProducts.ReceptionOrderProductCollection.Edit(model, obj))
                    {
                        //Daca s-a schimbat articolul, trebuie scimbat la toate pachetele
                        if (productIdOld != obj.Product.Id)
                        {
                            var packageList = model.Packages.Where(o => o.Reception.Id == Entity.Id && o.Product.Id == productIdOld);
                            if(packageList.Count() > 0)
                            {
                                foreach (var item in packageList)
                                {
                                    item.Product = obj.Product;
                                }
                                MessageBox.Show("Articolul s-a schimbat si la cele " + packageList.Count().ToString() + " pachete receptionate.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }

                            var receptionProduct = model.ReceptionProducts.FirstOrDefault(o => o.Reception.Id == Entity.Id && o.Product.Id == productIdOld);
                            if (receptionProduct != null)
                            {
                                receptionProduct.Product = obj.Product;
                            }
                        }

                        model.SaveChanges();

                        RefreshPackages();

                        ReceptionOrderProducts.ReceptionOrderProductCollection.PopulateGridViewNormal(new ReceptionOrderProducts.ReceptionOrderProductFilterCriteria { ReceptionId = Entity.Id }, gridViewReceptionOrderProducts);
                    }
                }
            }
        }

        private void buttonReceptionOrderProductsDelete_Click(object sender, EventArgs e)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                int selectedId = gridViewReceptionOrderProducts.GetSelectedId();
                var obj = model.ReceptionOrderProducts.FirstOrDefault(o => o.Id == selectedId);
                if (obj != null)
                {
                    if (!model.Packages.Any(o => o.Reception.Id == Entity.Id && o.Product.Id == obj.Product.Id))
                    {
                        if (MessageBox.Show("Esti sigur ca doresti sa stergi articolul selectat?", "INTREBARE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            model.ReceptionOrderProducts.DeleteObject(obj);
                            model.SaveChanges();
                            ReceptionOrderProducts.ReceptionOrderProductCollection.PopulateGridViewNormal(new ReceptionOrderProducts.ReceptionOrderProductFilterCriteria { ReceptionId = Entity.Id }, gridViewReceptionOrderProducts);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Exista deja pachete receptionate pe acest articol. Pentru a putea sterge acest articol, trebuie mai intai sterse toate pachetele ce contin acest articol.", "INTREBARE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void buttonPackagesAdd_Click(object sender, EventArgs e)
        {
            if (Packages.PackageCollection.AddReal(Entity.Id, gridViewPackages.GetSelectedId()))
            {
                RefreshPackages();
            }
        }

        private void buttonPackagesEdit_Click(object sender, EventArgs e)
        {
            if (gridViewPackages.Rows.Count > 0)
            {
                int selectedId = gridViewPackages.GetSelectedId();
                var package = Packages.PackageCollection.GetById(Model, selectedId, false);
                if (package != null)
                {
                    if ((package.Delivery == null) || ((package.Delivery != null) && (MessageBox.Show("Acest pachet a fost deja livrat cu livrarea nr. " + package.Delivery.ToString() + ". Sigur doresti sa-l editezi?", "ATENTIE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)))
                    {
                        if (Packages.PackageCollection.EditReal(selectedId))
                        {
                            RefreshPackages();
                        }
                    }
                }
            }
        }

        private void buttonPackagesDelete_Click(object sender, EventArgs e)
        {
            bool deletedOK = false;
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                Package obj = Packages.PackageCollection.GetById(model, gridViewPackages.GetSelectedId(), false);
                if (obj != null)
                {
                    if (obj.Delivery == null)
                    {
                        if (MessageBox.Show("Esti sigur ca doresti sa stergi pachetul " + obj.ToString() + "?", "INTREBARE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            model.Packages.DeleteObject(obj);
                            model.SaveChanges();
                            deletedOK = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Acest pachet a fost deja livrat cu livrarea nr. " + obj.Delivery.ToString() + " si nu poate fi sters din receptie. Pentru a-l putea sterge, el trebuie mai intai eliminat din livrare.", "ATENTIE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if(deletedOK)
            {
                RefreshPackages();
            }
        }

        private void buttonReceptionProductsEdit_Click(object sender, EventArgs e)
        {
            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                int selectedId = gridViewReceptionProducts.GetSelectedId();
                ReceptionProduct obj = model.ReceptionProducts.FirstOrDefault(o => o.Id == selectedId);
                if (obj != null)
                {
                    if (ReceptionProducts.ReceptionProductCollection.Edit(obj))
                    {
                        model.SaveChanges();
                        ReceptionProducts.ReceptionProductCollection.PopulateGridViewNormal(new ReceptionProducts.ReceptionProductFilterCriteria { ReceptionId = Entity.Id }, gridViewReceptionProducts);
                    }
                }
            }
        }
    }
}
