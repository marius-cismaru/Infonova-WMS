namespace Sirius.EntityModels.Packages
{
    partial class PackageFormSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackageFormSelect));
            this.panelFooter = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.tablePanelFilter = new Sirius.CustomControls.EntityTablePanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFilterReceptionNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selectBoxFilterProduct = new Sirius.CustomControls.EntitySelectBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFilterPackageCode = new System.Windows.Forms.TextBox();
            this.selectBoxFilterClient = new Sirius.CustomControls.EntitySelectBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFilterWarehouse = new System.Windows.Forms.TextBox();
            this.panelFilterHeader = new System.Windows.Forms.Panel();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.gridView = new Sirius.CustomControls.EntityGridView();
            this.panelMainFooter = new System.Windows.Forms.Panel();
            this.labelMainFooterWeightNetSelected = new System.Windows.Forms.Label();
            this.labelMainFooterWeightNetTotal = new System.Windows.Forms.Label();
            this.panelMainHeader = new System.Windows.Forms.Panel();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.buttonSelectNone = new System.Windows.Forms.Button();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.tablePanelFilter.SuspendLayout();
            this.panelFilterHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.panelMainFooter.SuspendLayout();
            this.panelMainHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.buttonCancel);
            this.panelFooter.Controls.Add(this.buttonOK);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 308);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(2);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(601, 38);
            this.panelFooter.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(414, 7);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 25);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Anulare";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Image = ((System.Drawing.Image)(resources.GetObject("buttonOK.Image")));
            this.buttonOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOK.Location = new System.Drawing.Point(507, 7);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(87, 25);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.panelFilter);
            this.splitContainerMain.Panel1.Controls.Add(this.panelFilterHeader);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.gridView);
            this.splitContainerMain.Panel2.Controls.Add(this.panelMainFooter);
            this.splitContainerMain.Panel2.Controls.Add(this.panelMainHeader);
            this.splitContainerMain.Size = new System.Drawing.Size(601, 308);
            this.splitContainerMain.SplitterDistance = 324;
            this.splitContainerMain.SplitterWidth = 3;
            this.splitContainerMain.TabIndex = 2;
            // 
            // panelFilter
            // 
            this.panelFilter.AutoScroll = true;
            this.panelFilter.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelFilter.Controls.Add(this.tablePanelFilter);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFilter.Location = new System.Drawing.Point(0, 33);
            this.panelFilter.Margin = new System.Windows.Forms.Padding(2);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(322, 273);
            this.panelFilter.TabIndex = 3;
            // 
            // tablePanelFilter
            // 
            this.tablePanelFilter.AutoScroll = true;
            this.tablePanelFilter.ColumnCount = 1;
            this.tablePanelFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanelFilter.Controls.Add(this.label1, 0, 2);
            this.tablePanelFilter.Controls.Add(this.textBoxFilterReceptionNumber, 0, 9);
            this.tablePanelFilter.Controls.Add(this.label3, 0, 8);
            this.tablePanelFilter.Controls.Add(this.label2, 0, 4);
            this.tablePanelFilter.Controls.Add(this.selectBoxFilterProduct, 0, 5);
            this.tablePanelFilter.Controls.Add(this.label4, 0, 6);
            this.tablePanelFilter.Controls.Add(this.textBoxFilterPackageCode, 0, 7);
            this.tablePanelFilter.Controls.Add(this.selectBoxFilterClient, 0, 3);
            this.tablePanelFilter.Controls.Add(this.label5, 0, 0);
            this.tablePanelFilter.Controls.Add(this.textBoxFilterWarehouse, 0, 1);
            this.tablePanelFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelFilter.Location = new System.Drawing.Point(0, 0);
            this.tablePanelFilter.Margin = new System.Windows.Forms.Padding(2);
            this.tablePanelFilter.Name = "tablePanelFilter";
            this.tablePanelFilter.RowCount = 11;
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.Size = new System.Drawing.Size(322, 273);
            this.tablePanelFilter.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client";
            // 
            // textBoxFilterReceptionNumber
            // 
            this.textBoxFilterReceptionNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilterReceptionNumber.Location = new System.Drawing.Point(2, 176);
            this.textBoxFilterReceptionNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFilterReceptionNumber.Name = "textBoxFilterReceptionNumber";
            this.textBoxFilterReceptionNumber.Size = new System.Drawing.Size(318, 22);
            this.textBoxFilterReceptionNumber.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nr. receptie";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Articol";
            // 
            // selectBoxFilterProduct
            // 
            this.selectBoxFilterProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectBoxFilterProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBoxFilterProduct.FormattingEnabled = true;
            this.selectBoxFilterProduct.Location = new System.Drawing.Point(2, 96);
            this.selectBoxFilterProduct.Margin = new System.Windows.Forms.Padding(2);
            this.selectBoxFilterProduct.Name = "selectBoxFilterProduct";
            this.selectBoxFilterProduct.Size = new System.Drawing.Size(318, 22);
            this.selectBoxFilterProduct.TabIndex = 1;
            this.selectBoxFilterProduct.SelectedIndexChanged += new System.EventHandler(this.selectBoxFilterProduct_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cod pachet";
            // 
            // textBoxFilterPackageCode
            // 
            this.textBoxFilterPackageCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilterPackageCode.Location = new System.Drawing.Point(2, 136);
            this.textBoxFilterPackageCode.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFilterPackageCode.Name = "textBoxFilterPackageCode";
            this.textBoxFilterPackageCode.Size = new System.Drawing.Size(318, 22);
            this.textBoxFilterPackageCode.TabIndex = 8;
            // 
            // selectBoxFilterClient
            // 
            this.selectBoxFilterClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectBoxFilterClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBoxFilterClient.FormattingEnabled = true;
            this.selectBoxFilterClient.Location = new System.Drawing.Point(2, 56);
            this.selectBoxFilterClient.Margin = new System.Windows.Forms.Padding(2);
            this.selectBoxFilterClient.Name = "selectBoxFilterClient";
            this.selectBoxFilterClient.Size = new System.Drawing.Size(318, 22);
            this.selectBoxFilterClient.TabIndex = 9;
            this.selectBoxFilterClient.SelectedIndexChanged += new System.EventHandler(this.selectBoxFilterClient_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Depozit";
            // 
            // textBoxFilterWarehouse
            // 
            this.textBoxFilterWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilterWarehouse.Location = new System.Drawing.Point(2, 16);
            this.textBoxFilterWarehouse.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFilterWarehouse.Name = "textBoxFilterWarehouse";
            this.textBoxFilterWarehouse.ReadOnly = true;
            this.textBoxFilterWarehouse.Size = new System.Drawing.Size(318, 22);
            this.textBoxFilterWarehouse.TabIndex = 11;
            // 
            // panelFilterHeader
            // 
            this.panelFilterHeader.Controls.Add(this.buttonFilter);
            this.panelFilterHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilterHeader.Location = new System.Drawing.Point(0, 0);
            this.panelFilterHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelFilterHeader.Name = "panelFilterHeader";
            this.panelFilterHeader.Size = new System.Drawing.Size(322, 33);
            this.panelFilterHeader.TabIndex = 2;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Image = ((System.Drawing.Image)(resources.GetObject("buttonFilter.Image")));
            this.buttonFilter.Location = new System.Drawing.Point(5, 4);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(67, 25);
            this.buttonFilter.TabIndex = 2;
            this.buttonFilter.Text = "Filtrare";
            this.buttonFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView.EmptyDataText = "Nu exista inregistrari";
            this.gridView.Location = new System.Drawing.Point(0, 33);
            this.gridView.Margin = new System.Windows.Forms.Padding(2);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(272, 233);
            this.gridView.TabIndex = 20;
            this.gridView.SelectionChanged += new System.EventHandler(this.gridView_SelectionChanged);
            // 
            // panelMainFooter
            // 
            this.panelMainFooter.BackColor = System.Drawing.SystemColors.Control;
            this.panelMainFooter.Controls.Add(this.labelMainFooterWeightNetSelected);
            this.panelMainFooter.Controls.Add(this.labelMainFooterWeightNetTotal);
            this.panelMainFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMainFooter.Location = new System.Drawing.Point(0, 266);
            this.panelMainFooter.Margin = new System.Windows.Forms.Padding(2);
            this.panelMainFooter.Name = "panelMainFooter";
            this.panelMainFooter.Size = new System.Drawing.Size(272, 40);
            this.panelMainFooter.TabIndex = 21;
            // 
            // labelMainFooterWeightNetSelected
            // 
            this.labelMainFooterWeightNetSelected.AutoSize = true;
            this.labelMainFooterWeightNetSelected.Location = new System.Drawing.Point(4, 20);
            this.labelMainFooterWeightNetSelected.Name = "labelMainFooterWeightNetSelected";
            this.labelMainFooterWeightNetSelected.Size = new System.Drawing.Size(199, 14);
            this.labelMainFooterWeightNetSelected.TabIndex = 1;
            this.labelMainFooterWeightNetSelected.Text = "labelMainFooterWeightNetSelected";
            // 
            // labelMainFooterWeightNetTotal
            // 
            this.labelMainFooterWeightNetTotal.AutoSize = true;
            this.labelMainFooterWeightNetTotal.Location = new System.Drawing.Point(4, 4);
            this.labelMainFooterWeightNetTotal.Name = "labelMainFooterWeightNetTotal";
            this.labelMainFooterWeightNetTotal.Size = new System.Drawing.Size(179, 14);
            this.labelMainFooterWeightNetTotal.TabIndex = 0;
            this.labelMainFooterWeightNetTotal.Text = "labelMainFooterWeightNetTotal";
            // 
            // panelMainHeader
            // 
            this.panelMainHeader.BackColor = System.Drawing.SystemColors.Control;
            this.panelMainHeader.Controls.Add(this.buttonSelectAll);
            this.panelMainHeader.Controls.Add(this.buttonSelectNone);
            this.panelMainHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainHeader.Location = new System.Drawing.Point(0, 0);
            this.panelMainHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelMainHeader.Name = "panelMainHeader";
            this.panelMainHeader.Size = new System.Drawing.Size(272, 33);
            this.panelMainHeader.TabIndex = 18;
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.Location = new System.Drawing.Point(4, 4);
            this.buttonSelectAll.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(92, 26);
            this.buttonSelectAll.TabIndex = 48;
            this.buttonSelectAll.Text = "Selectare Tot";
            this.buttonSelectAll.UseVisualStyleBackColor = true;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // buttonSelectNone
            // 
            this.buttonSelectNone.Location = new System.Drawing.Point(100, 3);
            this.buttonSelectNone.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelectNone.Name = "buttonSelectNone";
            this.buttonSelectNone.Size = new System.Drawing.Size(107, 26);
            this.buttonSelectNone.TabIndex = 47;
            this.buttonSelectNone.Text = "Anulare selectie";
            this.buttonSelectNone.UseVisualStyleBackColor = true;
            this.buttonSelectNone.Click += new System.EventHandler(this.buttonSelectNone_Click);
            // 
            // PackageFormSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 346);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.panelFooter);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "PackageFormSelect";
            this.ShowInTaskbar = false;
            this.Text = "FormSelect";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FormSelect_Shown);
            this.panelFooter.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.tablePanelFilter.ResumeLayout(false);
            this.tablePanelFilter.PerformLayout();
            this.panelFilterHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.panelMainFooter.ResumeLayout(false);
            this.panelMainFooter.PerformLayout();
            this.panelMainHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        protected CustomControls.EntityGridView gridView;
        protected System.Windows.Forms.Panel panelFilter;
        protected System.Windows.Forms.Panel panelFilterHeader;
        private CustomControls.EntityTablePanel tablePanelFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFilterReceptionNumber;
        private CustomControls.EntitySelectBox selectBoxFilterProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelMainHeader;
        private System.Windows.Forms.Button buttonSelectAll;
        private System.Windows.Forms.Button buttonSelectNone;
        protected System.Windows.Forms.Button buttonOK;
        protected System.Windows.Forms.Button buttonCancel;
        protected System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFilterPackageCode;
        private CustomControls.EntitySelectBox selectBoxFilterClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFilterWarehouse;
        private System.Windows.Forms.Panel panelMainFooter;
        private System.Windows.Forms.Label labelMainFooterWeightNetTotal;
        private System.Windows.Forms.Label labelMainFooterWeightNetSelected;

    }
}