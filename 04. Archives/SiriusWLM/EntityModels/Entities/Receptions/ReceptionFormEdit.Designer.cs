namespace Sirius.EntityModels.Receptions
{
    partial class ReceptionFormEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionFormEdit));
            this.tablePanelStep9 = new Sirius.CustomControls.EntityTablePanel();
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxReception = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRepresentativeName = new System.Windows.Forms.TextBox();
            this.textBoxRepresentativeID = new System.Windows.Forms.TextBox();
            this.textBoxConveyance = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.textBoxBatchList = new System.Windows.Forms.TextBox();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.selectBoxOrderType = new Sirius.CustomControls.EntitySelectBox();
            this.textBoxOrderNumber = new System.Windows.Forms.TextBox();
            this.dateTimePickerOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxWarehouse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateCreation = new System.Windows.Forms.DateTimePicker();
            this.tabPageReceptionOrderProducts = new System.Windows.Forms.TabPage();
            this.gridViewReceptionOrderProducts = new Sirius.CustomControls.EntityGridView();
            this.panelReceptionOrderProductsFooter = new System.Windows.Forms.Panel();
            this.labelMasterFooter = new System.Windows.Forms.Label();
            this.panelReceptionOrderProductsHeader = new System.Windows.Forms.Panel();
            this.buttonReceptionOrderProductEdit = new System.Windows.Forms.Button();
            this.buttonReceptionOrderProductsDelete = new System.Windows.Forms.Button();
            this.buttonReceptionOrderProductsAdd = new System.Windows.Forms.Button();
            this.tabPagePackages = new System.Windows.Forms.TabPage();
            this.gridViewPackages = new Sirius.CustomControls.EntityGridView();
            this.panelPackagesFooter = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panelPackagesHeader = new System.Windows.Forms.Panel();
            this.buttonPackagesEdit = new System.Windows.Forms.Button();
            this.buttonPackagesDelete = new System.Windows.Forms.Button();
            this.buttonPackagesAdd = new System.Windows.Forms.Button();
            this.tabPageReceptionProducts = new System.Windows.Forms.TabPage();
            this.gridViewReceptionProducts = new Sirius.CustomControls.EntityGridView();
            this.panelReceptionProductsFooter = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelReceptionProductsHeader = new System.Windows.Forms.Panel();
            this.buttonReceptionProductsEdit = new System.Windows.Forms.Button();
            this.panelBottom.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMain)).BeginInit();
            this.tablePanelStep9.SuspendLayout();
            this.tabPageReceptionOrderProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReceptionOrderProducts)).BeginInit();
            this.panelReceptionOrderProductsFooter.SuspendLayout();
            this.panelReceptionOrderProductsHeader.SuspendLayout();
            this.tabPagePackages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPackages)).BeginInit();
            this.panelPackagesFooter.SuspendLayout();
            this.panelPackagesHeader.SuspendLayout();
            this.tabPageReceptionProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReceptionProducts)).BeginInit();
            this.panelReceptionProductsFooter.SuspendLayout();
            this.panelReceptionProductsHeader.SuspendLayout();
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
            this.tabControlMain.Controls.Add(this.tabPageReceptionOrderProducts);
            this.tabControlMain.Controls.Add(this.tabPagePackages);
            this.tabControlMain.Controls.Add(this.tabPageReceptionProducts);
            this.tabControlMain.Size = new System.Drawing.Size(587, 308);
            this.tabControlMain.Controls.SetChildIndex(this.tabPageReceptionProducts, 0);
            this.tabControlMain.Controls.SetChildIndex(this.tabPagePackages, 0);
            this.tabControlMain.Controls.SetChildIndex(this.tabPageReceptionOrderProducts, 0);
            this.tabControlMain.Controls.SetChildIndex(this.tabPageGeneral, 0);
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.tablePanelStep9);
            this.tabPageGeneral.Size = new System.Drawing.Size(579, 275);
            // 
            // tablePanelStep9
            // 
            this.tablePanelStep9.AutoScroll = true;
            this.tablePanelStep9.BackColor = System.Drawing.SystemColors.Control;
            this.tablePanelStep9.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tablePanelStep9.ColumnCount = 3;
            this.tablePanelStep9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tablePanelStep9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tablePanelStep9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanelStep9.Controls.Add(this.textBoxClient, 1, 0);
            this.tablePanelStep9.Controls.Add(this.label1, 0, 0);
            this.tablePanelStep9.Controls.Add(this.textBoxReception, 1, 2);
            this.tablePanelStep9.Controls.Add(this.label2, 0, 2);
            this.tablePanelStep9.Controls.Add(this.textBoxRepresentativeName, 1, 8);
            this.tablePanelStep9.Controls.Add(this.textBoxRepresentativeID, 1, 9);
            this.tablePanelStep9.Controls.Add(this.textBoxConveyance, 1, 10);
            this.tablePanelStep9.Controls.Add(this.label31, 0, 8);
            this.tablePanelStep9.Controls.Add(this.label4, 0, 11);
            this.tablePanelStep9.Controls.Add(this.label38, 0, 9);
            this.tablePanelStep9.Controls.Add(this.label39, 0, 10);
            this.tablePanelStep9.Controls.Add(this.textBoxBatchList, 1, 11);
            this.tablePanelStep9.Controls.Add(this.textBoxComment, 1, 12);
            this.tablePanelStep9.Controls.Add(this.label40, 0, 12);
            this.tablePanelStep9.Controls.Add(this.label9, 2, 10);
            this.tablePanelStep9.Controls.Add(this.selectBoxOrderType, 1, 5);
            this.tablePanelStep9.Controls.Add(this.textBoxOrderNumber, 1, 6);
            this.tablePanelStep9.Controls.Add(this.dateTimePickerOrderDate, 1, 7);
            this.tablePanelStep9.Controls.Add(this.label7, 0, 6);
            this.tablePanelStep9.Controls.Add(this.label30, 0, 5);
            this.tablePanelStep9.Controls.Add(this.label8, 0, 7);
            this.tablePanelStep9.Controls.Add(this.textBoxWarehouse, 1, 1);
            this.tablePanelStep9.Controls.Add(this.label5, 0, 1);
            this.tablePanelStep9.Controls.Add(this.label10, 0, 3);
            this.tablePanelStep9.Controls.Add(this.label11, 0, 4);
            this.tablePanelStep9.Controls.Add(this.textBoxNumber, 1, 3);
            this.tablePanelStep9.Controls.Add(this.dateTimePickerDateCreation, 1, 4);
            this.tablePanelStep9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelStep9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tablePanelStep9.Location = new System.Drawing.Point(3, 3);
            this.tablePanelStep9.Name = "tablePanelStep9";
            this.tablePanelStep9.RowCount = 14;
            this.tablePanelStep9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelStep9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelStep9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelStep9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelStep9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelStep9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelStep9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelStep9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelStep9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelStep9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelStep9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelStep9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelStep9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelStep9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelStep9.Size = new System.Drawing.Size(573, 269);
            this.tablePanelStep9.TabIndex = 7;
            // 
            // textBoxClient
            // 
            this.textBoxClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClient.Location = new System.Drawing.Point(161, 4);
            this.textBoxClient.Name = "textBoxClient";
            this.textBoxClient.ReadOnly = true;
            this.textBoxClient.Size = new System.Drawing.Size(244, 22);
            this.textBoxClient.TabIndex = 60;
            this.toolTipMain.SetToolTip(this.textBoxClient, "Cod");
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 14);
            this.label1.TabIndex = 61;
            this.label1.Text = "Client";
            // 
            // textBoxReception
            // 
            this.textBoxReception.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReception.Location = new System.Drawing.Point(161, 62);
            this.textBoxReception.Name = "textBoxReception";
            this.textBoxReception.ReadOnly = true;
            this.textBoxReception.Size = new System.Drawing.Size(244, 22);
            this.textBoxReception.TabIndex = 62;
            this.toolTipMain.SetToolTip(this.textBoxReception, "Cod");
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 63;
            this.label2.Text = "Receptie";
            // 
            // textBoxRepresentativeName
            // 
            this.textBoxRepresentativeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRepresentativeName.Location = new System.Drawing.Point(161, 236);
            this.textBoxRepresentativeName.Name = "textBoxRepresentativeName";
            this.textBoxRepresentativeName.Size = new System.Drawing.Size(244, 22);
            this.textBoxRepresentativeName.TabIndex = 55;
            // 
            // textBoxRepresentativeID
            // 
            this.textBoxRepresentativeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRepresentativeID.Location = new System.Drawing.Point(161, 265);
            this.textBoxRepresentativeID.Name = "textBoxRepresentativeID";
            this.textBoxRepresentativeID.Size = new System.Drawing.Size(244, 22);
            this.textBoxRepresentativeID.TabIndex = 56;
            // 
            // textBoxConveyance
            // 
            this.textBoxConveyance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxConveyance.Location = new System.Drawing.Point(161, 294);
            this.textBoxConveyance.Name = "textBoxConveyance";
            this.textBoxConveyance.Size = new System.Drawing.Size(244, 22);
            this.textBoxConveyance.TabIndex = 57;
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(7, 240);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(147, 14);
            this.label31.TabIndex = 45;
            this.label31.Text = "Nume reprezentant client";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 14);
            this.label4.TabIndex = 55;
            this.label4.Text = "Lot-uri";
            // 
            // label38
            // 
            this.label38.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(28, 269);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(126, 14);
            this.label38.TabIndex = 47;
            this.label38.Text = "CI reprezentant client";
            // 
            // label39
            // 
            this.label39.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(46, 298);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(108, 14);
            this.label39.TabIndex = 49;
            this.label39.Text = "Mijloc de transport";
            // 
            // textBoxBatchList
            // 
            this.textBoxBatchList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBatchList.Location = new System.Drawing.Point(161, 323);
            this.textBoxBatchList.Multiline = true;
            this.textBoxBatchList.Name = "textBoxBatchList";
            this.textBoxBatchList.Size = new System.Drawing.Size(244, 51);
            this.textBoxBatchList.TabIndex = 64;
            // 
            // textBoxComment
            // 
            this.textBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComment.Location = new System.Drawing.Point(161, 381);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(244, 51);
            this.textBoxComment.TabIndex = 58;
            // 
            // label40
            // 
            this.label40.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(85, 399);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(69, 14);
            this.label40.TabIndex = 51;
            this.label40.Text = "Comentariu";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(412, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 14);
            this.label9.TabIndex = 65;
            this.label9.Text = "Cap tractor / remorca";
            // 
            // selectBoxOrderType
            // 
            this.selectBoxOrderType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectBoxOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBoxOrderType.FormattingEnabled = true;
            this.selectBoxOrderType.Location = new System.Drawing.Point(161, 149);
            this.selectBoxOrderType.Name = "selectBoxOrderType";
            this.selectBoxOrderType.Size = new System.Drawing.Size(244, 22);
            this.selectBoxOrderType.TabIndex = 66;
            // 
            // textBoxOrderNumber
            // 
            this.textBoxOrderNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOrderNumber.Location = new System.Drawing.Point(161, 178);
            this.textBoxOrderNumber.Name = "textBoxOrderNumber";
            this.textBoxOrderNumber.Size = new System.Drawing.Size(244, 22);
            this.textBoxOrderNumber.TabIndex = 67;
            this.toolTipMain.SetToolTip(this.textBoxOrderNumber, "Cod");
            // 
            // dateTimePickerOrderDate
            // 
            this.dateTimePickerOrderDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerOrderDate.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerOrderDate.Location = new System.Drawing.Point(161, 207);
            this.dateTimePickerOrderDate.Name = "dateTimePickerOrderDate";
            this.dateTimePickerOrderDate.Size = new System.Drawing.Size(244, 22);
            this.dateTimePickerOrderDate.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 14);
            this.label7.TabIndex = 70;
            this.label7.Text = "Numar document client";
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(37, 153);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(117, 14);
            this.label30.TabIndex = 69;
            this.label30.Text = "Tip document client";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 14);
            this.label8.TabIndex = 71;
            this.label8.Text = "Data document client";
            // 
            // textBoxWarehouse
            // 
            this.textBoxWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWarehouse.Location = new System.Drawing.Point(161, 33);
            this.textBoxWarehouse.Name = "textBoxWarehouse";
            this.textBoxWarehouse.ReadOnly = true;
            this.textBoxWarehouse.Size = new System.Drawing.Size(244, 22);
            this.textBoxWarehouse.TabIndex = 72;
            this.toolTipMain.SetToolTip(this.textBoxWarehouse, "Cod");
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 14);
            this.label5.TabIndex = 73;
            this.label5.Text = "Depozit";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(112, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 14);
            this.label10.TabIndex = 74;
            this.label10.Text = "Numar";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(122, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 14);
            this.label11.TabIndex = 75;
            this.label11.Text = "Data";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNumber.Location = new System.Drawing.Point(161, 91);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(244, 22);
            this.textBoxNumber.TabIndex = 76;
            this.toolTipMain.SetToolTip(this.textBoxNumber, "Cod");
            // 
            // dateTimePickerDateCreation
            // 
            this.dateTimePickerDateCreation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateCreation.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerDateCreation.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateCreation.Location = new System.Drawing.Point(161, 120);
            this.dateTimePickerDateCreation.Name = "dateTimePickerDateCreation";
            this.dateTimePickerDateCreation.Size = new System.Drawing.Size(244, 22);
            this.dateTimePickerDateCreation.TabIndex = 77;
            // 
            // tabPageReceptionOrderProducts
            // 
            this.tabPageReceptionOrderProducts.Controls.Add(this.gridViewReceptionOrderProducts);
            this.tabPageReceptionOrderProducts.Controls.Add(this.panelReceptionOrderProductsFooter);
            this.tabPageReceptionOrderProducts.Controls.Add(this.panelReceptionOrderProductsHeader);
            this.tabPageReceptionOrderProducts.Location = new System.Drawing.Point(4, 29);
            this.tabPageReceptionOrderProducts.Name = "tabPageReceptionOrderProducts";
            this.tabPageReceptionOrderProducts.Size = new System.Drawing.Size(579, 275);
            this.tabPageReceptionOrderProducts.TabIndex = 1;
            this.tabPageReceptionOrderProducts.Text = "Cantitati document client";
            this.tabPageReceptionOrderProducts.UseVisualStyleBackColor = true;
            // 
            // gridViewReceptionOrderProducts
            // 
            this.gridViewReceptionOrderProducts.AllowUserToAddRows = false;
            this.gridViewReceptionOrderProducts.AllowUserToDeleteRows = false;
            this.gridViewReceptionOrderProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridViewReceptionOrderProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewReceptionOrderProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewReceptionOrderProducts.EmptyDataText = "Nu exista inregistrari";
            this.gridViewReceptionOrderProducts.Location = new System.Drawing.Point(0, 32);
            this.gridViewReceptionOrderProducts.MultiSelect = false;
            this.gridViewReceptionOrderProducts.Name = "gridViewReceptionOrderProducts";
            this.gridViewReceptionOrderProducts.ReadOnly = true;
            this.gridViewReceptionOrderProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewReceptionOrderProducts.Size = new System.Drawing.Size(579, 219);
            this.gridViewReceptionOrderProducts.TabIndex = 16;
            // 
            // panelReceptionOrderProductsFooter
            // 
            this.panelReceptionOrderProductsFooter.Controls.Add(this.labelMasterFooter);
            this.panelReceptionOrderProductsFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelReceptionOrderProductsFooter.Location = new System.Drawing.Point(0, 251);
            this.panelReceptionOrderProductsFooter.Name = "panelReceptionOrderProductsFooter";
            this.panelReceptionOrderProductsFooter.Size = new System.Drawing.Size(579, 24);
            this.panelReceptionOrderProductsFooter.TabIndex = 15;
            // 
            // labelMasterFooter
            // 
            this.labelMasterFooter.AutoSize = true;
            this.labelMasterFooter.Location = new System.Drawing.Point(4, 5);
            this.labelMasterFooter.Name = "labelMasterFooter";
            this.labelMasterFooter.Size = new System.Drawing.Size(0, 14);
            this.labelMasterFooter.TabIndex = 0;
            // 
            // panelReceptionOrderProductsHeader
            // 
            this.panelReceptionOrderProductsHeader.Controls.Add(this.buttonReceptionOrderProductEdit);
            this.panelReceptionOrderProductsHeader.Controls.Add(this.buttonReceptionOrderProductsDelete);
            this.panelReceptionOrderProductsHeader.Controls.Add(this.buttonReceptionOrderProductsAdd);
            this.panelReceptionOrderProductsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReceptionOrderProductsHeader.Location = new System.Drawing.Point(0, 0);
            this.panelReceptionOrderProductsHeader.Name = "panelReceptionOrderProductsHeader";
            this.panelReceptionOrderProductsHeader.Size = new System.Drawing.Size(579, 32);
            this.panelReceptionOrderProductsHeader.TabIndex = 14;
            // 
            // buttonReceptionOrderProductEdit
            // 
            this.buttonReceptionOrderProductEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonReceptionOrderProductEdit.Image")));
            this.buttonReceptionOrderProductEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReceptionOrderProductEdit.Location = new System.Drawing.Point(94, 4);
            this.buttonReceptionOrderProductEdit.Name = "buttonReceptionOrderProductEdit";
            this.buttonReceptionOrderProductEdit.Size = new System.Drawing.Size(69, 25);
            this.buttonReceptionOrderProductEdit.TabIndex = 6;
            this.buttonReceptionOrderProductEdit.Text = "Editare";
            this.buttonReceptionOrderProductEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReceptionOrderProductEdit.UseVisualStyleBackColor = true;
            this.buttonReceptionOrderProductEdit.Click += new System.EventHandler(this.buttonReceptionOrderProductEdit_Click);
            // 
            // buttonReceptionOrderProductsDelete
            // 
            this.buttonReceptionOrderProductsDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonReceptionOrderProductsDelete.Image")));
            this.buttonReceptionOrderProductsDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReceptionOrderProductsDelete.Location = new System.Drawing.Point(169, 4);
            this.buttonReceptionOrderProductsDelete.Name = "buttonReceptionOrderProductsDelete";
            this.buttonReceptionOrderProductsDelete.Size = new System.Drawing.Size(79, 25);
            this.buttonReceptionOrderProductsDelete.TabIndex = 4;
            this.buttonReceptionOrderProductsDelete.Text = "Stergere";
            this.buttonReceptionOrderProductsDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReceptionOrderProductsDelete.UseVisualStyleBackColor = true;
            this.buttonReceptionOrderProductsDelete.Click += new System.EventHandler(this.buttonReceptionOrderProductsDelete_Click);
            // 
            // buttonReceptionOrderProductsAdd
            // 
            this.buttonReceptionOrderProductsAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonReceptionOrderProductsAdd.Image")));
            this.buttonReceptionOrderProductsAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReceptionOrderProductsAdd.Location = new System.Drawing.Point(4, 4);
            this.buttonReceptionOrderProductsAdd.Name = "buttonReceptionOrderProductsAdd";
            this.buttonReceptionOrderProductsAdd.Size = new System.Drawing.Size(84, 25);
            this.buttonReceptionOrderProductsAdd.TabIndex = 1;
            this.buttonReceptionOrderProductsAdd.Text = "Adaugare";
            this.buttonReceptionOrderProductsAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReceptionOrderProductsAdd.UseVisualStyleBackColor = true;
            this.buttonReceptionOrderProductsAdd.Click += new System.EventHandler(this.buttonReceptionOrderProductsAdd_Click);
            // 
            // tabPagePackages
            // 
            this.tabPagePackages.Controls.Add(this.gridViewPackages);
            this.tabPagePackages.Controls.Add(this.panelPackagesFooter);
            this.tabPagePackages.Controls.Add(this.panelPackagesHeader);
            this.tabPagePackages.Location = new System.Drawing.Point(4, 29);
            this.tabPagePackages.Name = "tabPagePackages";
            this.tabPagePackages.Size = new System.Drawing.Size(579, 275);
            this.tabPagePackages.TabIndex = 2;
            this.tabPagePackages.Text = "Pachete";
            this.tabPagePackages.UseVisualStyleBackColor = true;
            // 
            // gridViewPackages
            // 
            this.gridViewPackages.AllowUserToAddRows = false;
            this.gridViewPackages.AllowUserToDeleteRows = false;
            this.gridViewPackages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridViewPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewPackages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewPackages.EmptyDataText = "Nu exista inregistrari";
            this.gridViewPackages.Location = new System.Drawing.Point(0, 32);
            this.gridViewPackages.MultiSelect = false;
            this.gridViewPackages.Name = "gridViewPackages";
            this.gridViewPackages.ReadOnly = true;
            this.gridViewPackages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewPackages.Size = new System.Drawing.Size(579, 219);
            this.gridViewPackages.TabIndex = 19;
            // 
            // panelPackagesFooter
            // 
            this.panelPackagesFooter.Controls.Add(this.label6);
            this.panelPackagesFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPackagesFooter.Location = new System.Drawing.Point(0, 251);
            this.panelPackagesFooter.Name = "panelPackagesFooter";
            this.panelPackagesFooter.Size = new System.Drawing.Size(579, 24);
            this.panelPackagesFooter.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 14);
            this.label6.TabIndex = 0;
            // 
            // panelPackagesHeader
            // 
            this.panelPackagesHeader.Controls.Add(this.buttonPackagesEdit);
            this.panelPackagesHeader.Controls.Add(this.buttonPackagesDelete);
            this.panelPackagesHeader.Controls.Add(this.buttonPackagesAdd);
            this.panelPackagesHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPackagesHeader.Location = new System.Drawing.Point(0, 0);
            this.panelPackagesHeader.Name = "panelPackagesHeader";
            this.panelPackagesHeader.Size = new System.Drawing.Size(579, 32);
            this.panelPackagesHeader.TabIndex = 17;
            // 
            // buttonPackagesEdit
            // 
            this.buttonPackagesEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonPackagesEdit.Image")));
            this.buttonPackagesEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPackagesEdit.Location = new System.Drawing.Point(94, 4);
            this.buttonPackagesEdit.Name = "buttonPackagesEdit";
            this.buttonPackagesEdit.Size = new System.Drawing.Size(69, 25);
            this.buttonPackagesEdit.TabIndex = 5;
            this.buttonPackagesEdit.Text = "Editare";
            this.buttonPackagesEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPackagesEdit.UseVisualStyleBackColor = true;
            this.buttonPackagesEdit.Click += new System.EventHandler(this.buttonPackagesEdit_Click);
            // 
            // buttonPackagesDelete
            // 
            this.buttonPackagesDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonPackagesDelete.Image")));
            this.buttonPackagesDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPackagesDelete.Location = new System.Drawing.Point(169, 4);
            this.buttonPackagesDelete.Name = "buttonPackagesDelete";
            this.buttonPackagesDelete.Size = new System.Drawing.Size(79, 25);
            this.buttonPackagesDelete.TabIndex = 4;
            this.buttonPackagesDelete.Text = "Stergere";
            this.buttonPackagesDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPackagesDelete.UseVisualStyleBackColor = true;
            this.buttonPackagesDelete.Click += new System.EventHandler(this.buttonPackagesDelete_Click);
            // 
            // buttonPackagesAdd
            // 
            this.buttonPackagesAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonPackagesAdd.Image")));
            this.buttonPackagesAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPackagesAdd.Location = new System.Drawing.Point(4, 4);
            this.buttonPackagesAdd.Name = "buttonPackagesAdd";
            this.buttonPackagesAdd.Size = new System.Drawing.Size(84, 25);
            this.buttonPackagesAdd.TabIndex = 1;
            this.buttonPackagesAdd.Text = "Adaugare";
            this.buttonPackagesAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPackagesAdd.UseVisualStyleBackColor = true;
            this.buttonPackagesAdd.Click += new System.EventHandler(this.buttonPackagesAdd_Click);
            // 
            // tabPageReceptionProducts
            // 
            this.tabPageReceptionProducts.Controls.Add(this.gridViewReceptionProducts);
            this.tabPageReceptionProducts.Controls.Add(this.panelReceptionProductsFooter);
            this.tabPageReceptionProducts.Controls.Add(this.panelReceptionProductsHeader);
            this.tabPageReceptionProducts.Location = new System.Drawing.Point(4, 29);
            this.tabPageReceptionProducts.Name = "tabPageReceptionProducts";
            this.tabPageReceptionProducts.Size = new System.Drawing.Size(579, 275);
            this.tabPageReceptionProducts.TabIndex = 3;
            this.tabPageReceptionProducts.Text = "Cantitati receptie";
            this.tabPageReceptionProducts.UseVisualStyleBackColor = true;
            // 
            // gridViewReceptionProducts
            // 
            this.gridViewReceptionProducts.AllowUserToAddRows = false;
            this.gridViewReceptionProducts.AllowUserToDeleteRows = false;
            this.gridViewReceptionProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridViewReceptionProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewReceptionProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewReceptionProducts.EmptyDataText = "Nu exista inregistrari";
            this.gridViewReceptionProducts.Location = new System.Drawing.Point(0, 32);
            this.gridViewReceptionProducts.MultiSelect = false;
            this.gridViewReceptionProducts.Name = "gridViewReceptionProducts";
            this.gridViewReceptionProducts.ReadOnly = true;
            this.gridViewReceptionProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewReceptionProducts.Size = new System.Drawing.Size(579, 219);
            this.gridViewReceptionProducts.TabIndex = 19;
            // 
            // panelReceptionProductsFooter
            // 
            this.panelReceptionProductsFooter.Controls.Add(this.label3);
            this.panelReceptionProductsFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelReceptionProductsFooter.Location = new System.Drawing.Point(0, 251);
            this.panelReceptionProductsFooter.Name = "panelReceptionProductsFooter";
            this.panelReceptionProductsFooter.Size = new System.Drawing.Size(579, 24);
            this.panelReceptionProductsFooter.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 14);
            this.label3.TabIndex = 0;
            // 
            // panelReceptionProductsHeader
            // 
            this.panelReceptionProductsHeader.Controls.Add(this.buttonReceptionProductsEdit);
            this.panelReceptionProductsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReceptionProductsHeader.Location = new System.Drawing.Point(0, 0);
            this.panelReceptionProductsHeader.Name = "panelReceptionProductsHeader";
            this.panelReceptionProductsHeader.Size = new System.Drawing.Size(579, 32);
            this.panelReceptionProductsHeader.TabIndex = 17;
            // 
            // buttonReceptionProductsEdit
            // 
            this.buttonReceptionProductsEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonReceptionProductsEdit.Image")));
            this.buttonReceptionProductsEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReceptionProductsEdit.Location = new System.Drawing.Point(4, 4);
            this.buttonReceptionProductsEdit.Name = "buttonReceptionProductsEdit";
            this.buttonReceptionProductsEdit.Size = new System.Drawing.Size(69, 25);
            this.buttonReceptionProductsEdit.TabIndex = 4;
            this.buttonReceptionProductsEdit.Text = "Editare";
            this.buttonReceptionProductsEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReceptionProductsEdit.UseVisualStyleBackColor = true;
            this.buttonReceptionProductsEdit.Click += new System.EventHandler(this.buttonReceptionProductsEdit_Click);
            // 
            // ReceptionFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 346);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ReceptionFormEdit";
            this.Text = "FormEdit";
            this.Shown += new System.EventHandler(this.FormEdit_Shown);
            this.panelBottom.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMain)).EndInit();
            this.tablePanelStep9.ResumeLayout(false);
            this.tablePanelStep9.PerformLayout();
            this.tabPageReceptionOrderProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReceptionOrderProducts)).EndInit();
            this.panelReceptionOrderProductsFooter.ResumeLayout(false);
            this.panelReceptionOrderProductsFooter.PerformLayout();
            this.panelReceptionOrderProductsHeader.ResumeLayout(false);
            this.tabPagePackages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPackages)).EndInit();
            this.panelPackagesFooter.ResumeLayout(false);
            this.panelPackagesFooter.PerformLayout();
            this.panelPackagesHeader.ResumeLayout(false);
            this.tabPageReceptionProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReceptionProducts)).EndInit();
            this.panelReceptionProductsFooter.ResumeLayout(false);
            this.panelReceptionProductsFooter.PerformLayout();
            this.panelReceptionProductsHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.EntityTablePanel tablePanelStep9;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox textBoxRepresentativeName;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textBoxRepresentativeID;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox textBoxConveyance;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxReception;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBatchList;
        private System.Windows.Forms.Label label9;
        private CustomControls.EntitySelectBox selectBoxOrderType;
        private System.Windows.Forms.TextBox textBoxOrderNumber;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrderDate;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPageReceptionOrderProducts;
        protected CustomControls.EntityGridView gridViewReceptionOrderProducts;
        protected System.Windows.Forms.Panel panelReceptionOrderProductsFooter;
        private System.Windows.Forms.Label labelMasterFooter;
        protected System.Windows.Forms.Panel panelReceptionOrderProductsHeader;
        protected System.Windows.Forms.Button buttonReceptionOrderProductsDelete;
        protected System.Windows.Forms.Button buttonReceptionOrderProductsAdd;
        private System.Windows.Forms.TabPage tabPagePackages;
        private System.Windows.Forms.TabPage tabPageReceptionProducts;
        protected CustomControls.EntityGridView gridViewPackages;
        protected System.Windows.Forms.Panel panelPackagesFooter;
        private System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Panel panelPackagesHeader;
        protected System.Windows.Forms.Button buttonPackagesDelete;
        protected System.Windows.Forms.Button buttonPackagesAdd;
        protected CustomControls.EntityGridView gridViewReceptionProducts;
        protected System.Windows.Forms.Panel panelReceptionProductsFooter;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Panel panelReceptionProductsHeader;
        protected System.Windows.Forms.Button buttonReceptionProductsEdit;
        protected System.Windows.Forms.Button buttonPackagesEdit;
        protected System.Windows.Forms.Button buttonReceptionOrderProductEdit;
        private System.Windows.Forms.TextBox textBoxWarehouse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateCreation;

    }
}