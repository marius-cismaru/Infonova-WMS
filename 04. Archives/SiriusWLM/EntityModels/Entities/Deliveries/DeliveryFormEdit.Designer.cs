namespace Sirius.EntityModels.Deliveries
{
    partial class DeliveryFormEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryFormEdit));
            this.tablePanelGeneral = new Sirius.CustomControls.EntityTablePanel();
            this.label40 = new System.Windows.Forms.Label();
            this.textBoxRepresentativeName = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.textBoxRepresentativeID = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.textBoxConveyance = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectBoxClientDestination = new Sirius.CustomControls.EntitySelectBox();
            this.textBoxSeal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonClientDestinationsBrowse = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDelivery = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectBoxOrderType = new Sirius.CustomControls.EntitySelectBox();
            this.textBoxOrderNumber = new System.Windows.Forms.TextBox();
            this.dateTimePickerOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label30 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePickerDateCreation = new System.Windows.Forms.DateTimePicker();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxWarehouse = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPageDeliveryOrderProducts = new System.Windows.Forms.TabPage();
            this.gridViewDeliveryOrderProducts = new Sirius.CustomControls.EntityGridView();
            this.panelDeliveryOrderProductsFooter = new System.Windows.Forms.Panel();
            this.labelMasterFooter = new System.Windows.Forms.Label();
            this.panelDeliveryOrderProductsHeader = new System.Windows.Forms.Panel();
            this.buttonDeliveryOrderProductsDelete = new System.Windows.Forms.Button();
            this.buttonDeliveryOrderProductsAdd = new System.Windows.Forms.Button();
            this.tabPageDeliveryProducts = new System.Windows.Forms.TabPage();
            this.gridViewDeliveryProducts = new Sirius.CustomControls.EntityGridView();
            this.panelDeliveryProductsFooter = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPagePackages = new System.Windows.Forms.TabPage();
            this.gridViewPackages = new Sirius.CustomControls.EntityGridView();
            this.panelPackagesFooter = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panelPackagesHeader = new System.Windows.Forms.Panel();
            this.buttonPackagesDelete = new System.Windows.Forms.Button();
            this.buttonPackagesAdd = new System.Windows.Forms.Button();
            this.panelBottom.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMain)).BeginInit();
            this.tablePanelGeneral.SuspendLayout();
            this.tabPageDeliveryOrderProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDeliveryOrderProducts)).BeginInit();
            this.panelDeliveryOrderProductsFooter.SuspendLayout();
            this.panelDeliveryOrderProductsHeader.SuspendLayout();
            this.tabPageDeliveryProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDeliveryProducts)).BeginInit();
            this.panelDeliveryProductsFooter.SuspendLayout();
            this.tabPagePackages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPackages)).BeginInit();
            this.panelPackagesFooter.SuspendLayout();
            this.panelPackagesHeader.SuspendLayout();
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
            this.tabControlMain.Controls.Add(this.tabPageDeliveryOrderProducts);
            this.tabControlMain.Controls.Add(this.tabPagePackages);
            this.tabControlMain.Controls.Add(this.tabPageDeliveryProducts);
            this.tabControlMain.Size = new System.Drawing.Size(587, 308);
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            this.tabControlMain.Controls.SetChildIndex(this.tabPageDeliveryProducts, 0);
            this.tabControlMain.Controls.SetChildIndex(this.tabPagePackages, 0);
            this.tabControlMain.Controls.SetChildIndex(this.tabPageDeliveryOrderProducts, 0);
            this.tabControlMain.Controls.SetChildIndex(this.tabPageGeneral, 0);
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
            this.tablePanelGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tablePanelGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tablePanelGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanelGeneral.Controls.Add(this.label40, 0, 13);
            this.tablePanelGeneral.Controls.Add(this.textBoxRepresentativeName, 1, 10);
            this.tablePanelGeneral.Controls.Add(this.label31, 0, 10);
            this.tablePanelGeneral.Controls.Add(this.textBoxRepresentativeID, 1, 11);
            this.tablePanelGeneral.Controls.Add(this.label38, 0, 11);
            this.tablePanelGeneral.Controls.Add(this.textBoxConveyance, 1, 12);
            this.tablePanelGeneral.Controls.Add(this.label39, 0, 12);
            this.tablePanelGeneral.Controls.Add(this.textBoxComment, 1, 13);
            this.tablePanelGeneral.Controls.Add(this.label3, 0, 8);
            this.tablePanelGeneral.Controls.Add(this.selectBoxClientDestination, 1, 8);
            this.tablePanelGeneral.Controls.Add(this.textBoxSeal, 1, 9);
            this.tablePanelGeneral.Controls.Add(this.label4, 0, 9);
            this.tablePanelGeneral.Controls.Add(this.buttonClientDestinationsBrowse, 2, 8);
            this.tablePanelGeneral.Controls.Add(this.label9, 2, 12);
            this.tablePanelGeneral.Controls.Add(this.textBoxClient, 1, 0);
            this.tablePanelGeneral.Controls.Add(this.label1, 0, 0);
            this.tablePanelGeneral.Controls.Add(this.textBoxDelivery, 1, 2);
            this.tablePanelGeneral.Controls.Add(this.label2, 0, 2);
            this.tablePanelGeneral.Controls.Add(this.selectBoxOrderType, 1, 5);
            this.tablePanelGeneral.Controls.Add(this.textBoxOrderNumber, 1, 6);
            this.tablePanelGeneral.Controls.Add(this.dateTimePickerOrderDate, 1, 7);
            this.tablePanelGeneral.Controls.Add(this.label30, 0, 5);
            this.tablePanelGeneral.Controls.Add(this.label7, 0, 6);
            this.tablePanelGeneral.Controls.Add(this.label8, 0, 7);
            this.tablePanelGeneral.Controls.Add(this.label10, 0, 3);
            this.tablePanelGeneral.Controls.Add(this.label11, 0, 4);
            this.tablePanelGeneral.Controls.Add(this.dateTimePickerDateCreation, 1, 4);
            this.tablePanelGeneral.Controls.Add(this.textBoxNumber, 1, 3);
            this.tablePanelGeneral.Controls.Add(this.textBoxWarehouse, 1, 1);
            this.tablePanelGeneral.Controls.Add(this.label12, 0, 1);
            this.tablePanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelGeneral.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tablePanelGeneral.Location = new System.Drawing.Point(3, 3);
            this.tablePanelGeneral.Name = "tablePanelGeneral";
            this.tablePanelGeneral.RowCount = 15;
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.Size = new System.Drawing.Size(573, 269);
            this.tablePanelGeneral.TabIndex = 7;
            // 
            // label40
            // 
            this.label40.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(85, 402);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(69, 14);
            this.label40.TabIndex = 51;
            this.label40.Text = "Comentariu";
            // 
            // textBoxRepresentativeName
            // 
            this.textBoxRepresentativeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRepresentativeName.Location = new System.Drawing.Point(161, 297);
            this.textBoxRepresentativeName.Name = "textBoxRepresentativeName";
            this.textBoxRepresentativeName.Size = new System.Drawing.Size(244, 22);
            this.textBoxRepresentativeName.TabIndex = 55;
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(7, 301);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(147, 14);
            this.label31.TabIndex = 45;
            this.label31.Text = "Nume reprezentant client";
            // 
            // textBoxRepresentativeID
            // 
            this.textBoxRepresentativeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRepresentativeID.Location = new System.Drawing.Point(161, 326);
            this.textBoxRepresentativeID.Name = "textBoxRepresentativeID";
            this.textBoxRepresentativeID.Size = new System.Drawing.Size(244, 22);
            this.textBoxRepresentativeID.TabIndex = 56;
            // 
            // label38
            // 
            this.label38.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(28, 330);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(126, 14);
            this.label38.TabIndex = 47;
            this.label38.Text = "CI reprezentant client";
            // 
            // textBoxConveyance
            // 
            this.textBoxConveyance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxConveyance.Location = new System.Drawing.Point(161, 355);
            this.textBoxConveyance.Name = "textBoxConveyance";
            this.textBoxConveyance.Size = new System.Drawing.Size(244, 22);
            this.textBoxConveyance.TabIndex = 57;
            // 
            // label39
            // 
            this.label39.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(46, 359);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(108, 14);
            this.label39.TabIndex = 49;
            this.label39.Text = "Mijloc de transport";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComment.Location = new System.Drawing.Point(161, 384);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(244, 51);
            this.textBoxComment.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 14);
            this.label3.TabIndex = 52;
            this.label3.Text = "Destinatie";
            // 
            // selectBoxClientDestination
            // 
            this.selectBoxClientDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectBoxClientDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBoxClientDestination.FormattingEnabled = true;
            this.selectBoxClientDestination.Location = new System.Drawing.Point(161, 237);
            this.selectBoxClientDestination.Name = "selectBoxClientDestination";
            this.selectBoxClientDestination.Size = new System.Drawing.Size(244, 22);
            this.selectBoxClientDestination.TabIndex = 53;
            this.selectBoxClientDestination.SelectedIndexChanged += new System.EventHandler(this.selectBoxClientDestination_SelectedIndexChanged);
            // 
            // textBoxSeal
            // 
            this.textBoxSeal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSeal.Location = new System.Drawing.Point(161, 268);
            this.textBoxSeal.Name = "textBoxSeal";
            this.textBoxSeal.Size = new System.Drawing.Size(244, 22);
            this.textBoxSeal.TabIndex = 54;
            this.toolTipMain.SetToolTip(this.textBoxSeal, "Cod");
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 14);
            this.label4.TabIndex = 55;
            this.label4.Text = "Sigiliu";
            // 
            // buttonClientDestinationsBrowse
            // 
            this.buttonClientDestinationsBrowse.Location = new System.Drawing.Point(412, 236);
            this.buttonClientDestinationsBrowse.Name = "buttonClientDestinationsBrowse";
            this.buttonClientDestinationsBrowse.Size = new System.Drawing.Size(75, 25);
            this.buttonClientDestinationsBrowse.TabIndex = 56;
            this.buttonClientDestinationsBrowse.Text = "Gestionare";
            this.buttonClientDestinationsBrowse.UseVisualStyleBackColor = true;
            this.buttonClientDestinationsBrowse.Click += new System.EventHandler(this.buttonClientDestinationsBrowse_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(412, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 14);
            this.label9.TabIndex = 59;
            this.label9.Text = "Cap tractor / remorca";
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
            // textBoxDelivery
            // 
            this.textBoxDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDelivery.Location = new System.Drawing.Point(161, 62);
            this.textBoxDelivery.Name = "textBoxDelivery";
            this.textBoxDelivery.ReadOnly = true;
            this.textBoxDelivery.Size = new System.Drawing.Size(244, 22);
            this.textBoxDelivery.TabIndex = 62;
            this.toolTipMain.SetToolTip(this.textBoxDelivery, "Cod");
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 63;
            this.label2.Text = "Livrare";
            // 
            // selectBoxOrderType
            // 
            this.selectBoxOrderType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectBoxOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBoxOrderType.FormattingEnabled = true;
            this.selectBoxOrderType.Location = new System.Drawing.Point(161, 149);
            this.selectBoxOrderType.Name = "selectBoxOrderType";
            this.selectBoxOrderType.Size = new System.Drawing.Size(244, 22);
            this.selectBoxOrderType.TabIndex = 64;
            // 
            // textBoxOrderNumber
            // 
            this.textBoxOrderNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOrderNumber.Location = new System.Drawing.Point(161, 178);
            this.textBoxOrderNumber.Name = "textBoxOrderNumber";
            this.textBoxOrderNumber.Size = new System.Drawing.Size(244, 22);
            this.textBoxOrderNumber.TabIndex = 65;
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
            this.dateTimePickerOrderDate.TabIndex = 66;
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(37, 153);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(117, 14);
            this.label30.TabIndex = 67;
            this.label30.Text = "Tip document client";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 14);
            this.label7.TabIndex = 68;
            this.label7.Text = "Numar document client";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 14);
            this.label8.TabIndex = 69;
            this.label8.Text = "Data document client";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(112, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 14);
            this.label10.TabIndex = 70;
            this.label10.Text = "Numar";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(122, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 14);
            this.label11.TabIndex = 71;
            this.label11.Text = "Data";
            // 
            // dateTimePickerDateCreation
            // 
            this.dateTimePickerDateCreation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateCreation.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerDateCreation.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateCreation.Location = new System.Drawing.Point(161, 120);
            this.dateTimePickerDateCreation.Name = "dateTimePickerDateCreation";
            this.dateTimePickerDateCreation.Size = new System.Drawing.Size(244, 22);
            this.dateTimePickerDateCreation.TabIndex = 72;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNumber.Location = new System.Drawing.Point(161, 91);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(244, 22);
            this.textBoxNumber.TabIndex = 73;
            this.toolTipMain.SetToolTip(this.textBoxNumber, "Cod");
            // 
            // textBoxWarehouse
            // 
            this.textBoxWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWarehouse.Location = new System.Drawing.Point(161, 33);
            this.textBoxWarehouse.Name = "textBoxWarehouse";
            this.textBoxWarehouse.ReadOnly = true;
            this.textBoxWarehouse.Size = new System.Drawing.Size(244, 22);
            this.textBoxWarehouse.TabIndex = 74;
            this.toolTipMain.SetToolTip(this.textBoxWarehouse, "Cod");
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(106, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 14);
            this.label12.TabIndex = 75;
            this.label12.Text = "Depozit";
            // 
            // tabPageDeliveryOrderProducts
            // 
            this.tabPageDeliveryOrderProducts.Controls.Add(this.gridViewDeliveryOrderProducts);
            this.tabPageDeliveryOrderProducts.Controls.Add(this.panelDeliveryOrderProductsFooter);
            this.tabPageDeliveryOrderProducts.Controls.Add(this.panelDeliveryOrderProductsHeader);
            this.tabPageDeliveryOrderProducts.Location = new System.Drawing.Point(4, 29);
            this.tabPageDeliveryOrderProducts.Name = "tabPageDeliveryOrderProducts";
            this.tabPageDeliveryOrderProducts.Size = new System.Drawing.Size(579, 275);
            this.tabPageDeliveryOrderProducts.TabIndex = 1;
            this.tabPageDeliveryOrderProducts.Text = "Cantitati document client";
            this.tabPageDeliveryOrderProducts.UseVisualStyleBackColor = true;
            // 
            // gridViewDeliveryOrderProducts
            // 
            this.gridViewDeliveryOrderProducts.AllowUserToAddRows = false;
            this.gridViewDeliveryOrderProducts.AllowUserToDeleteRows = false;
            this.gridViewDeliveryOrderProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridViewDeliveryOrderProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewDeliveryOrderProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewDeliveryOrderProducts.EmptyDataText = "Nu exista inregistrari";
            this.gridViewDeliveryOrderProducts.Location = new System.Drawing.Point(0, 32);
            this.gridViewDeliveryOrderProducts.MultiSelect = false;
            this.gridViewDeliveryOrderProducts.Name = "gridViewDeliveryOrderProducts";
            this.gridViewDeliveryOrderProducts.ReadOnly = true;
            this.gridViewDeliveryOrderProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewDeliveryOrderProducts.Size = new System.Drawing.Size(579, 219);
            this.gridViewDeliveryOrderProducts.TabIndex = 13;
            // 
            // panelDeliveryOrderProductsFooter
            // 
            this.panelDeliveryOrderProductsFooter.Controls.Add(this.labelMasterFooter);
            this.panelDeliveryOrderProductsFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDeliveryOrderProductsFooter.Location = new System.Drawing.Point(0, 251);
            this.panelDeliveryOrderProductsFooter.Name = "panelDeliveryOrderProductsFooter";
            this.panelDeliveryOrderProductsFooter.Size = new System.Drawing.Size(579, 24);
            this.panelDeliveryOrderProductsFooter.TabIndex = 12;
            // 
            // labelMasterFooter
            // 
            this.labelMasterFooter.AutoSize = true;
            this.labelMasterFooter.Location = new System.Drawing.Point(4, 5);
            this.labelMasterFooter.Name = "labelMasterFooter";
            this.labelMasterFooter.Size = new System.Drawing.Size(0, 14);
            this.labelMasterFooter.TabIndex = 0;
            // 
            // panelDeliveryOrderProductsHeader
            // 
            this.panelDeliveryOrderProductsHeader.Controls.Add(this.buttonDeliveryOrderProductsDelete);
            this.panelDeliveryOrderProductsHeader.Controls.Add(this.buttonDeliveryOrderProductsAdd);
            this.panelDeliveryOrderProductsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDeliveryOrderProductsHeader.Location = new System.Drawing.Point(0, 0);
            this.panelDeliveryOrderProductsHeader.Name = "panelDeliveryOrderProductsHeader";
            this.panelDeliveryOrderProductsHeader.Size = new System.Drawing.Size(579, 32);
            this.panelDeliveryOrderProductsHeader.TabIndex = 11;
            // 
            // buttonDeliveryOrderProductsDelete
            // 
            this.buttonDeliveryOrderProductsDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeliveryOrderProductsDelete.Image")));
            this.buttonDeliveryOrderProductsDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeliveryOrderProductsDelete.Location = new System.Drawing.Point(94, 4);
            this.buttonDeliveryOrderProductsDelete.Name = "buttonDeliveryOrderProductsDelete";
            this.buttonDeliveryOrderProductsDelete.Size = new System.Drawing.Size(79, 25);
            this.buttonDeliveryOrderProductsDelete.TabIndex = 4;
            this.buttonDeliveryOrderProductsDelete.Text = "Stergere";
            this.buttonDeliveryOrderProductsDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDeliveryOrderProductsDelete.UseVisualStyleBackColor = true;
            this.buttonDeliveryOrderProductsDelete.Click += new System.EventHandler(this.buttonDeliveryOrderProductsDelete_Click);
            // 
            // buttonDeliveryOrderProductsAdd
            // 
            this.buttonDeliveryOrderProductsAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeliveryOrderProductsAdd.Image")));
            this.buttonDeliveryOrderProductsAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeliveryOrderProductsAdd.Location = new System.Drawing.Point(4, 4);
            this.buttonDeliveryOrderProductsAdd.Name = "buttonDeliveryOrderProductsAdd";
            this.buttonDeliveryOrderProductsAdd.Size = new System.Drawing.Size(84, 25);
            this.buttonDeliveryOrderProductsAdd.TabIndex = 1;
            this.buttonDeliveryOrderProductsAdd.Text = "Adaugare";
            this.buttonDeliveryOrderProductsAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDeliveryOrderProductsAdd.UseVisualStyleBackColor = true;
            this.buttonDeliveryOrderProductsAdd.Click += new System.EventHandler(this.buttonDeliveryOrderProductsAdd_Click);
            // 
            // tabPageDeliveryProducts
            // 
            this.tabPageDeliveryProducts.Controls.Add(this.gridViewDeliveryProducts);
            this.tabPageDeliveryProducts.Controls.Add(this.panelDeliveryProductsFooter);
            this.tabPageDeliveryProducts.Location = new System.Drawing.Point(4, 29);
            this.tabPageDeliveryProducts.Name = "tabPageDeliveryProducts";
            this.tabPageDeliveryProducts.Size = new System.Drawing.Size(579, 275);
            this.tabPageDeliveryProducts.TabIndex = 2;
            this.tabPageDeliveryProducts.Text = "Cantitati livrare";
            this.tabPageDeliveryProducts.UseVisualStyleBackColor = true;
            // 
            // gridViewDeliveryProducts
            // 
            this.gridViewDeliveryProducts.AllowUserToAddRows = false;
            this.gridViewDeliveryProducts.AllowUserToDeleteRows = false;
            this.gridViewDeliveryProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridViewDeliveryProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewDeliveryProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewDeliveryProducts.EmptyDataText = "Nu exista inregistrari";
            this.gridViewDeliveryProducts.Location = new System.Drawing.Point(0, 0);
            this.gridViewDeliveryProducts.MultiSelect = false;
            this.gridViewDeliveryProducts.Name = "gridViewDeliveryProducts";
            this.gridViewDeliveryProducts.ReadOnly = true;
            this.gridViewDeliveryProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewDeliveryProducts.Size = new System.Drawing.Size(579, 251);
            this.gridViewDeliveryProducts.TabIndex = 16;
            // 
            // panelDeliveryProductsFooter
            // 
            this.panelDeliveryProductsFooter.Controls.Add(this.label5);
            this.panelDeliveryProductsFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDeliveryProductsFooter.Location = new System.Drawing.Point(0, 251);
            this.panelDeliveryProductsFooter.Name = "panelDeliveryProductsFooter";
            this.panelDeliveryProductsFooter.Size = new System.Drawing.Size(579, 24);
            this.panelDeliveryProductsFooter.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 14);
            this.label5.TabIndex = 0;
            // 
            // tabPagePackages
            // 
            this.tabPagePackages.Controls.Add(this.gridViewPackages);
            this.tabPagePackages.Controls.Add(this.panelPackagesFooter);
            this.tabPagePackages.Controls.Add(this.panelPackagesHeader);
            this.tabPagePackages.Location = new System.Drawing.Point(4, 29);
            this.tabPagePackages.Name = "tabPagePackages";
            this.tabPagePackages.Size = new System.Drawing.Size(579, 275);
            this.tabPagePackages.TabIndex = 3;
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
            this.gridViewPackages.Name = "gridViewPackages";
            this.gridViewPackages.ReadOnly = true;
            this.gridViewPackages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewPackages.Size = new System.Drawing.Size(579, 219);
            this.gridViewPackages.TabIndex = 16;
            // 
            // panelPackagesFooter
            // 
            this.panelPackagesFooter.Controls.Add(this.label6);
            this.panelPackagesFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPackagesFooter.Location = new System.Drawing.Point(0, 251);
            this.panelPackagesFooter.Name = "panelPackagesFooter";
            this.panelPackagesFooter.Size = new System.Drawing.Size(579, 24);
            this.panelPackagesFooter.TabIndex = 15;
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
            this.panelPackagesHeader.Controls.Add(this.buttonPackagesDelete);
            this.panelPackagesHeader.Controls.Add(this.buttonPackagesAdd);
            this.panelPackagesHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPackagesHeader.Location = new System.Drawing.Point(0, 0);
            this.panelPackagesHeader.Name = "panelPackagesHeader";
            this.panelPackagesHeader.Size = new System.Drawing.Size(579, 32);
            this.panelPackagesHeader.TabIndex = 14;
            // 
            // buttonPackagesDelete
            // 
            this.buttonPackagesDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonPackagesDelete.Image")));
            this.buttonPackagesDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPackagesDelete.Location = new System.Drawing.Point(94, 4);
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
            // DeliveryFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 346);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "DeliveryFormEdit";
            this.Text = "FormEdit";
            this.Shown += new System.EventHandler(this.FormEdit_Shown);
            this.panelBottom.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMain)).EndInit();
            this.tablePanelGeneral.ResumeLayout(false);
            this.tablePanelGeneral.PerformLayout();
            this.tabPageDeliveryOrderProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDeliveryOrderProducts)).EndInit();
            this.panelDeliveryOrderProductsFooter.ResumeLayout(false);
            this.panelDeliveryOrderProductsFooter.PerformLayout();
            this.panelDeliveryOrderProductsHeader.ResumeLayout(false);
            this.tabPageDeliveryProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDeliveryProducts)).EndInit();
            this.panelDeliveryProductsFooter.ResumeLayout(false);
            this.panelDeliveryProductsFooter.PerformLayout();
            this.tabPagePackages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPackages)).EndInit();
            this.panelPackagesFooter.ResumeLayout(false);
            this.panelPackagesFooter.PerformLayout();
            this.panelPackagesHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.EntityTablePanel tablePanelGeneral;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox textBoxRepresentativeName;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textBoxRepresentativeID;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox textBoxConveyance;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label label3;
        private CustomControls.EntitySelectBox selectBoxClientDestination;
        private System.Windows.Forms.TextBox textBoxSeal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonClientDestinationsBrowse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDelivery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageDeliveryOrderProducts;
        protected CustomControls.EntityGridView gridViewDeliveryOrderProducts;
        protected System.Windows.Forms.Panel panelDeliveryOrderProductsFooter;
        private System.Windows.Forms.Label labelMasterFooter;
        protected System.Windows.Forms.Panel panelDeliveryOrderProductsHeader;
        protected System.Windows.Forms.Button buttonDeliveryOrderProductsAdd;
        protected System.Windows.Forms.Button buttonDeliveryOrderProductsDelete;
        private System.Windows.Forms.TabPage tabPageDeliveryProducts;
        private System.Windows.Forms.TabPage tabPagePackages;
        protected CustomControls.EntityGridView gridViewDeliveryProducts;
        protected System.Windows.Forms.Panel panelDeliveryProductsFooter;
        private System.Windows.Forms.Label label5;
        protected CustomControls.EntityGridView gridViewPackages;
        protected System.Windows.Forms.Panel panelPackagesFooter;
        private System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Panel panelPackagesHeader;
        protected System.Windows.Forms.Button buttonPackagesDelete;
        protected System.Windows.Forms.Button buttonPackagesAdd;
        private CustomControls.EntitySelectBox selectBoxOrderType;
        private System.Windows.Forms.TextBox textBoxOrderNumber;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrderDate;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateCreation;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxWarehouse;
        private System.Windows.Forms.Label label12;

    }
}