namespace Sirius.EntityModels.ReceptionOrderProducts
{
    partial class ReceptionOrderProductFormEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tablePanelGeneral = new Sirius.CustomControls.EntityTablePanel();
            this.labelWeightNet = new System.Windows.Forms.Label();
            this.selectBoxProduct = new Sirius.CustomControls.EntitySelectBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonProductBrowse = new System.Windows.Forms.Button();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxWeightNet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.textBoxReception = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxWarehouse = new System.Windows.Forms.TextBox();
            this.textBoxWeightGross = new System.Windows.Forms.TextBox();
            this.labelWeightGross = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBottom.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMain)).BeginInit();
            this.tablePanelGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 308);
            this.panelBottom.Size = new System.Drawing.Size(587, 38);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(493, 6);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(400, 6);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Size = new System.Drawing.Size(587, 308);
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.tablePanelGeneral);
            this.tabPageGeneral.Size = new System.Drawing.Size(579, 275);
            // 
            // tablePanelGeneral
            // 
            this.tablePanelGeneral.AutoScroll = true;
            this.tablePanelGeneral.BackColor = System.Drawing.SystemColors.Control;
            this.tablePanelGeneral.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tablePanelGeneral.ColumnCount = 3;
            this.tablePanelGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tablePanelGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tablePanelGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanelGeneral.Controls.Add(this.labelWeightNet, 0, 5);
            this.tablePanelGeneral.Controls.Add(this.selectBoxProduct, 1, 3);
            this.tablePanelGeneral.Controls.Add(this.label3, 0, 3);
            this.tablePanelGeneral.Controls.Add(this.buttonProductBrowse, 2, 3);
            this.tablePanelGeneral.Controls.Add(this.labelQuantity, 0, 4);
            this.tablePanelGeneral.Controls.Add(this.textBoxQuantity, 1, 4);
            this.tablePanelGeneral.Controls.Add(this.textBoxWeightNet, 1, 5);
            this.tablePanelGeneral.Controls.Add(this.label2, 0, 0);
            this.tablePanelGeneral.Controls.Add(this.textBoxClient, 1, 0);
            this.tablePanelGeneral.Controls.Add(this.textBoxReception, 1, 2);
            this.tablePanelGeneral.Controls.Add(this.label5, 0, 2);
            this.tablePanelGeneral.Controls.Add(this.label6, 0, 1);
            this.tablePanelGeneral.Controls.Add(this.textBoxWarehouse, 1, 1);
            this.tablePanelGeneral.Controls.Add(this.textBoxWeightGross, 1, 6);
            this.tablePanelGeneral.Controls.Add(this.labelWeightGross, 0, 6);
            this.tablePanelGeneral.Controls.Add(this.label1, 2, 5);
            this.tablePanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelGeneral.Location = new System.Drawing.Point(3, 3);
            this.tablePanelGeneral.Name = "tablePanelGeneral";
            this.tablePanelGeneral.RowCount = 8;
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.Size = new System.Drawing.Size(573, 269);
            this.tablePanelGeneral.TabIndex = 3;
            // 
            // labelWeightNet
            // 
            this.labelWeightNet.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelWeightNet.AutoSize = true;
            this.labelWeightNet.Location = new System.Drawing.Point(15, 154);
            this.labelWeightNet.Name = "labelWeightNet";
            this.labelWeightNet.Size = new System.Drawing.Size(113, 14);
            this.labelWeightNet.TabIndex = 1;
            this.labelWeightNet.Text = "Greutate neta [Kg]";
            // 
            // selectBoxProduct
            // 
            this.selectBoxProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectBoxProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBoxProduct.FormattingEnabled = true;
            this.selectBoxProduct.Location = new System.Drawing.Point(135, 91);
            this.selectBoxProduct.Name = "selectBoxProduct";
            this.selectBoxProduct.Size = new System.Drawing.Size(294, 22);
            this.selectBoxProduct.TabIndex = 6;
            this.selectBoxProduct.SelectedIndexChanged += new System.EventHandler(this.selectBoxProduct_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Articol";
            // 
            // buttonProductBrowse
            // 
            this.buttonProductBrowse.Location = new System.Drawing.Point(436, 91);
            this.buttonProductBrowse.Name = "buttonProductBrowse";
            this.buttonProductBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonProductBrowse.TabIndex = 12;
            this.buttonProductBrowse.Text = "Gestionare";
            this.toolTipMain.SetToolTip(this.buttonProductBrowse, "Gestionare articole");
            this.buttonProductBrowse.UseVisualStyleBackColor = true;
            this.buttonProductBrowse.Click += new System.EventHandler(this.buttonProductBrowse_Click);
            // 
            // labelQuantity
            // 
            this.labelQuantity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(71, 125);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(57, 14);
            this.labelQuantity.TabIndex = 9;
            this.labelQuantity.Text = "Cantitate";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQuantity.Location = new System.Drawing.Point(135, 121);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(294, 22);
            this.textBoxQuantity.TabIndex = 2;
            this.toolTipMain.SetToolTip(this.textBoxQuantity, "Denumirea completa a Companiei");
            this.textBoxQuantity.TextChanged += new System.EventHandler(this.textBoxQuantity_TextChanged);
            // 
            // textBoxWeightNet
            // 
            this.textBoxWeightNet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWeightNet.Location = new System.Drawing.Point(135, 150);
            this.textBoxWeightNet.Name = "textBoxWeightNet";
            this.textBoxWeightNet.ReadOnly = true;
            this.textBoxWeightNet.Size = new System.Drawing.Size(294, 22);
            this.textBoxWeightNet.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 14);
            this.label2.TabIndex = 13;
            this.label2.Text = "Client";
            // 
            // textBoxClient
            // 
            this.textBoxClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClient.Location = new System.Drawing.Point(135, 4);
            this.textBoxClient.Name = "textBoxClient";
            this.textBoxClient.ReadOnly = true;
            this.textBoxClient.Size = new System.Drawing.Size(294, 22);
            this.textBoxClient.TabIndex = 14;
            this.toolTipMain.SetToolTip(this.textBoxClient, "Denumirea completa a Companiei");
            // 
            // textBoxReception
            // 
            this.textBoxReception.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReception.Location = new System.Drawing.Point(135, 62);
            this.textBoxReception.Name = "textBoxReception";
            this.textBoxReception.ReadOnly = true;
            this.textBoxReception.Size = new System.Drawing.Size(294, 22);
            this.textBoxReception.TabIndex = 15;
            this.toolTipMain.SetToolTip(this.textBoxReception, "Denumirea completa a Companiei");
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 14);
            this.label5.TabIndex = 16;
            this.label5.Text = "Receptie";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 14);
            this.label6.TabIndex = 17;
            this.label6.Text = "Depozit";
            // 
            // textBoxWarehouse
            // 
            this.textBoxWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWarehouse.Location = new System.Drawing.Point(135, 33);
            this.textBoxWarehouse.Name = "textBoxWarehouse";
            this.textBoxWarehouse.ReadOnly = true;
            this.textBoxWarehouse.Size = new System.Drawing.Size(294, 22);
            this.textBoxWarehouse.TabIndex = 18;
            this.toolTipMain.SetToolTip(this.textBoxWarehouse, "Denumirea completa a Companiei");
            // 
            // textBoxWeightGross
            // 
            this.textBoxWeightGross.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWeightGross.Location = new System.Drawing.Point(135, 180);
            this.textBoxWeightGross.Name = "textBoxWeightGross";
            this.textBoxWeightGross.Size = new System.Drawing.Size(294, 22);
            this.textBoxWeightGross.TabIndex = 19;
            this.toolTipMain.SetToolTip(this.textBoxWeightGross, "Denumirea completa a Companiei");
            // 
            // labelWeightGross
            // 
            this.labelWeightGross.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelWeightGross.AutoSize = true;
            this.labelWeightGross.Location = new System.Drawing.Point(11, 184);
            this.labelWeightGross.Name = "labelWeightGross";
            this.labelWeightGross.Size = new System.Drawing.Size(117, 14);
            this.labelWeightGross.TabIndex = 20;
            this.labelWeightGross.Text = "Greutate bruta [Kg]";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(436, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Conversie automata dupa factorul de greutate";
            // 
            // ReceptionOrderProductFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 346);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ReceptionOrderProductFormEdit";
            this.Text = "FormEdit";
            this.Shown += new System.EventHandler(this.FormEdit_Shown);
            this.panelBottom.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMain)).EndInit();
            this.tablePanelGeneral.ResumeLayout(false);
            this.tablePanelGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.EntityTablePanel tablePanelGeneral;
        private System.Windows.Forms.Label labelWeightNet;
        private CustomControls.EntitySelectBox selectBoxProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonProductBrowse;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxWeightNet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxClient;
        private System.Windows.Forms.TextBox textBoxReception;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxWarehouse;
        private System.Windows.Forms.TextBox textBoxWeightGross;
        private System.Windows.Forms.Label labelWeightGross;
        private System.Windows.Forms.Label label1;


    }
}