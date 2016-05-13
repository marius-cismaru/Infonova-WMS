namespace Sirius.EntityModels.Clients
{
    partial class ClientFormEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNameLong = new System.Windows.Forms.TextBox();
            this.textBoxNameShort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selectBoxCountry = new Sirius.CustomControls.EntitySelectBox();
            this.textBoxCompany = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNameSymbol3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNameSymbol1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxNumberRegistry = new System.Windows.Forms.TextBox();
            this.textBoxNumberFiscal = new System.Windows.Forms.TextBox();
            this.textBoxEmailAddressList = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPageProducts = new System.Windows.Forms.TabPage();
            this.gridViewProducts = new Sirius.CustomControls.EntityGridView();
            this.panelProductsFooter = new System.Windows.Forms.Panel();
            this.labelMasterFooter = new System.Windows.Forms.Label();
            this.panelProductsHeader = new System.Windows.Forms.Panel();
            this.buttonProductsBrowse = new System.Windows.Forms.Button();
            this.tabPageDestinations = new System.Windows.Forms.TabPage();
            this.gridViewDestinations = new Sirius.CustomControls.EntityGridView();
            this.panelDestinationsFooter = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panelDestinationsHeader = new System.Windows.Forms.Panel();
            this.buttonDestinationsBrowse = new System.Windows.Forms.Button();
            this.tabPageEmailSendReports = new System.Windows.Forms.TabPage();
            this.tablePanelEmailSendReports = new Sirius.CustomControls.EntityTablePanel();
            this.label16 = new System.Windows.Forms.Label();
            this.checkBoxEmailSendReportStock = new System.Windows.Forms.CheckBox();
            this.panelBottom.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMain)).BeginInit();
            this.tablePanelGeneral.SuspendLayout();
            this.tabPageProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).BeginInit();
            this.panelProductsFooter.SuspendLayout();
            this.panelProductsHeader.SuspendLayout();
            this.tabPageDestinations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDestinations)).BeginInit();
            this.panelDestinationsFooter.SuspendLayout();
            this.panelDestinationsHeader.SuspendLayout();
            this.tabPageEmailSendReports.SuspendLayout();
            this.tablePanelEmailSendReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 462);
            this.panelBottom.Size = new System.Drawing.Size(663, 38);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(564, 6);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(471, 6);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageProducts);
            this.tabControlMain.Controls.Add(this.tabPageDestinations);
            this.tabControlMain.Controls.Add(this.tabPageEmailSendReports);
            this.tabControlMain.Size = new System.Drawing.Size(663, 462);
            this.tabControlMain.Controls.SetChildIndex(this.tabPageEmailSendReports, 0);
            this.tabControlMain.Controls.SetChildIndex(this.tabPageDestinations, 0);
            this.tabControlMain.Controls.SetChildIndex(this.tabPageProducts, 0);
            this.tabControlMain.Controls.SetChildIndex(this.tabPageGeneral, 0);
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.tablePanelGeneral);
            this.tabPageGeneral.Size = new System.Drawing.Size(655, 429);
            // 
            // tablePanelGeneral
            // 
            this.tablePanelGeneral.AutoScroll = true;
            this.tablePanelGeneral.BackColor = System.Drawing.SystemColors.Control;
            this.tablePanelGeneral.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tablePanelGeneral.ColumnCount = 3;
            this.tablePanelGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tablePanelGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tablePanelGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanelGeneral.Controls.Add(this.label1, 0, 2);
            this.tablePanelGeneral.Controls.Add(this.textBoxNameLong, 1, 2);
            this.tablePanelGeneral.Controls.Add(this.textBoxNameShort, 1, 3);
            this.tablePanelGeneral.Controls.Add(this.label2, 0, 3);
            this.tablePanelGeneral.Controls.Add(this.label3, 0, 1);
            this.tablePanelGeneral.Controls.Add(this.selectBoxCountry, 1, 1);
            this.tablePanelGeneral.Controls.Add(this.textBoxCompany, 1, 0);
            this.tablePanelGeneral.Controls.Add(this.label4, 0, 0);
            this.tablePanelGeneral.Controls.Add(this.textBoxNameSymbol3, 1, 4);
            this.tablePanelGeneral.Controls.Add(this.label5, 0, 4);
            this.tablePanelGeneral.Controls.Add(this.textBoxNameSymbol1, 1, 5);
            this.tablePanelGeneral.Controls.Add(this.label7, 0, 5);
            this.tablePanelGeneral.Controls.Add(this.label8, 0, 6);
            this.tablePanelGeneral.Controls.Add(this.label9, 0, 7);
            this.tablePanelGeneral.Controls.Add(this.label10, 0, 8);
            this.tablePanelGeneral.Controls.Add(this.textBoxNumberRegistry, 1, 6);
            this.tablePanelGeneral.Controls.Add(this.textBoxNumberFiscal, 1, 7);
            this.tablePanelGeneral.Controls.Add(this.textBoxEmailAddressList, 1, 9);
            this.tablePanelGeneral.Controls.Add(this.textBoxAddress, 1, 8);
            this.tablePanelGeneral.Controls.Add(this.label11, 0, 9);
            this.tablePanelGeneral.Controls.Add(this.label12, 2, 9);
            this.tablePanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelGeneral.Location = new System.Drawing.Point(3, 3);
            this.tablePanelGeneral.Name = "tablePanelGeneral";
            this.tablePanelGeneral.RowCount = 11;
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
            this.tablePanelGeneral.Size = new System.Drawing.Size(649, 423);
            this.tablePanelGeneral.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Denumire completa";
            // 
            // textBoxNameLong
            // 
            this.textBoxNameLong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNameLong.Location = new System.Drawing.Point(155, 62);
            this.textBoxNameLong.Name = "textBoxNameLong";
            this.textBoxNameLong.Size = new System.Drawing.Size(294, 22);
            this.textBoxNameLong.TabIndex = 2;
            this.toolTipMain.SetToolTip(this.textBoxNameLong, "Denumirea completa a Companiei");
            // 
            // textBoxNameShort
            // 
            this.textBoxNameShort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNameShort.Location = new System.Drawing.Point(155, 91);
            this.textBoxNameShort.Name = "textBoxNameShort";
            this.textBoxNameShort.Size = new System.Drawing.Size(294, 22);
            this.textBoxNameShort.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Denumire cautare";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tara";
            // 
            // selectBoxCountry
            // 
            this.selectBoxCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBoxCountry.FormattingEnabled = true;
            this.selectBoxCountry.Location = new System.Drawing.Point(155, 33);
            this.selectBoxCountry.Name = "selectBoxCountry";
            this.selectBoxCountry.Size = new System.Drawing.Size(294, 22);
            this.selectBoxCountry.TabIndex = 6;
            // 
            // textBoxCompany
            // 
            this.textBoxCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCompany.Location = new System.Drawing.Point(155, 4);
            this.textBoxCompany.Name = "textBoxCompany";
            this.textBoxCompany.ReadOnly = true;
            this.textBoxCompany.Size = new System.Drawing.Size(294, 22);
            this.textBoxCompany.TabIndex = 8;
            this.toolTipMain.SetToolTip(this.textBoxCompany, "Denumirea completa a Companiei");
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Companie";
            // 
            // textBoxNameSymbol3
            // 
            this.textBoxNameSymbol3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNameSymbol3.Location = new System.Drawing.Point(155, 120);
            this.textBoxNameSymbol3.Name = "textBoxNameSymbol3";
            this.textBoxNameSymbol3.Size = new System.Drawing.Size(294, 22);
            this.textBoxNameSymbol3.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "Prescurtare 3 litere";
            // 
            // textBoxNameSymbol1
            // 
            this.textBoxNameSymbol1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNameSymbol1.Location = new System.Drawing.Point(155, 149);
            this.textBoxNameSymbol1.Name = "textBoxNameSymbol1";
            this.textBoxNameSymbol1.Size = new System.Drawing.Size(294, 22);
            this.textBoxNameSymbol1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 14);
            this.label7.TabIndex = 13;
            this.label7.Text = "Prescurtare 1 litera";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 14);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nr. Reg. Com.";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(122, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 14);
            this.label9.TabIndex = 15;
            this.label9.Text = "CUI";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 14);
            this.label10.TabIndex = 20;
            this.label10.Text = "Adresa sediu social";
            // 
            // textBoxNumberRegistry
            // 
            this.textBoxNumberRegistry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNumberRegistry.Location = new System.Drawing.Point(155, 178);
            this.textBoxNumberRegistry.Name = "textBoxNumberRegistry";
            this.textBoxNumberRegistry.Size = new System.Drawing.Size(294, 22);
            this.textBoxNumberRegistry.TabIndex = 21;
            this.toolTipMain.SetToolTip(this.textBoxNumberRegistry, "Denumirea completa a Companiei");
            // 
            // textBoxNumberFiscal
            // 
            this.textBoxNumberFiscal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNumberFiscal.Location = new System.Drawing.Point(155, 207);
            this.textBoxNumberFiscal.Name = "textBoxNumberFiscal";
            this.textBoxNumberFiscal.Size = new System.Drawing.Size(294, 22);
            this.textBoxNumberFiscal.TabIndex = 22;
            this.toolTipMain.SetToolTip(this.textBoxNumberFiscal, "Denumirea completa a Companiei");
            // 
            // textBoxEmailAddressList
            // 
            this.textBoxEmailAddressList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmailAddressList.Location = new System.Drawing.Point(155, 303);
            this.textBoxEmailAddressList.Multiline = true;
            this.textBoxEmailAddressList.Name = "textBoxEmailAddressList";
            this.textBoxEmailAddressList.Size = new System.Drawing.Size(294, 100);
            this.textBoxEmailAddressList.TabIndex = 24;
            this.toolTipMain.SetToolTip(this.textBoxEmailAddressList, "Denumirea completa a Companiei");
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddress.Location = new System.Drawing.Point(155, 236);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(294, 60);
            this.textBoxAddress.TabIndex = 23;
            this.toolTipMain.SetToolTip(this.textBoxAddress, "Denumirea completa a Companiei");
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(72, 346);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 14);
            this.label11.TabIndex = 25;
            this.label11.Text = "Adrese email";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(456, 346);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 14);
            this.label12.TabIndex = 26;
            this.label12.Text = "despartite prin vrgula";
            // 
            // tabPageProducts
            // 
            this.tabPageProducts.Controls.Add(this.gridViewProducts);
            this.tabPageProducts.Controls.Add(this.panelProductsFooter);
            this.tabPageProducts.Controls.Add(this.panelProductsHeader);
            this.tabPageProducts.Location = new System.Drawing.Point(4, 29);
            this.tabPageProducts.Name = "tabPageProducts";
            this.tabPageProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProducts.Size = new System.Drawing.Size(655, 429);
            this.tabPageProducts.TabIndex = 1;
            this.tabPageProducts.Text = "Articole";
            this.tabPageProducts.UseVisualStyleBackColor = true;
            // 
            // gridViewProducts
            // 
            this.gridViewProducts.AllowUserToAddRows = false;
            this.gridViewProducts.AllowUserToDeleteRows = false;
            this.gridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewProducts.EmptyDataText = "Nu exista inregistrari";
            this.gridViewProducts.Location = new System.Drawing.Point(3, 35);
            this.gridViewProducts.MultiSelect = false;
            this.gridViewProducts.Name = "gridViewProducts";
            this.gridViewProducts.ReadOnly = true;
            this.gridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewProducts.Size = new System.Drawing.Size(649, 367);
            this.gridViewProducts.TabIndex = 10;
            // 
            // panelProductsFooter
            // 
            this.panelProductsFooter.Controls.Add(this.labelMasterFooter);
            this.panelProductsFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelProductsFooter.Location = new System.Drawing.Point(3, 402);
            this.panelProductsFooter.Name = "panelProductsFooter";
            this.panelProductsFooter.Size = new System.Drawing.Size(649, 24);
            this.panelProductsFooter.TabIndex = 9;
            // 
            // labelMasterFooter
            // 
            this.labelMasterFooter.AutoSize = true;
            this.labelMasterFooter.Location = new System.Drawing.Point(4, 5);
            this.labelMasterFooter.Name = "labelMasterFooter";
            this.labelMasterFooter.Size = new System.Drawing.Size(0, 14);
            this.labelMasterFooter.TabIndex = 0;
            // 
            // panelProductsHeader
            // 
            this.panelProductsHeader.Controls.Add(this.buttonProductsBrowse);
            this.panelProductsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProductsHeader.Location = new System.Drawing.Point(3, 3);
            this.panelProductsHeader.Name = "panelProductsHeader";
            this.panelProductsHeader.Size = new System.Drawing.Size(649, 32);
            this.panelProductsHeader.TabIndex = 8;
            // 
            // buttonProductsBrowse
            // 
            this.buttonProductsBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProductsBrowse.Location = new System.Drawing.Point(4, 4);
            this.buttonProductsBrowse.Name = "buttonProductsBrowse";
            this.buttonProductsBrowse.Size = new System.Drawing.Size(98, 23);
            this.buttonProductsBrowse.TabIndex = 4;
            this.buttonProductsBrowse.Text = "Gestionare";
            this.buttonProductsBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipMain.SetToolTip(this.buttonProductsBrowse, "Gestionare");
            this.buttonProductsBrowse.UseVisualStyleBackColor = true;
            this.buttonProductsBrowse.Click += new System.EventHandler(this.buttonProductsBrowse_Click);
            // 
            // tabPageDestinations
            // 
            this.tabPageDestinations.Controls.Add(this.gridViewDestinations);
            this.tabPageDestinations.Controls.Add(this.panelDestinationsFooter);
            this.tabPageDestinations.Controls.Add(this.panelDestinationsHeader);
            this.tabPageDestinations.Location = new System.Drawing.Point(4, 29);
            this.tabPageDestinations.Name = "tabPageDestinations";
            this.tabPageDestinations.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDestinations.Size = new System.Drawing.Size(655, 429);
            this.tabPageDestinations.TabIndex = 2;
            this.tabPageDestinations.Text = "Destinatii livrari";
            this.tabPageDestinations.UseVisualStyleBackColor = true;
            // 
            // gridViewDestinations
            // 
            this.gridViewDestinations.AllowUserToAddRows = false;
            this.gridViewDestinations.AllowUserToDeleteRows = false;
            this.gridViewDestinations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridViewDestinations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewDestinations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewDestinations.EmptyDataText = "Nu exista inregistrari";
            this.gridViewDestinations.Location = new System.Drawing.Point(3, 35);
            this.gridViewDestinations.MultiSelect = false;
            this.gridViewDestinations.Name = "gridViewDestinations";
            this.gridViewDestinations.ReadOnly = true;
            this.gridViewDestinations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewDestinations.Size = new System.Drawing.Size(649, 367);
            this.gridViewDestinations.TabIndex = 13;
            // 
            // panelDestinationsFooter
            // 
            this.panelDestinationsFooter.Controls.Add(this.label6);
            this.panelDestinationsFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDestinationsFooter.Location = new System.Drawing.Point(3, 402);
            this.panelDestinationsFooter.Name = "panelDestinationsFooter";
            this.panelDestinationsFooter.Size = new System.Drawing.Size(649, 24);
            this.panelDestinationsFooter.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 14);
            this.label6.TabIndex = 0;
            // 
            // panelDestinationsHeader
            // 
            this.panelDestinationsHeader.Controls.Add(this.buttonDestinationsBrowse);
            this.panelDestinationsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDestinationsHeader.Location = new System.Drawing.Point(3, 3);
            this.panelDestinationsHeader.Name = "panelDestinationsHeader";
            this.panelDestinationsHeader.Size = new System.Drawing.Size(649, 32);
            this.panelDestinationsHeader.TabIndex = 11;
            // 
            // buttonDestinationsBrowse
            // 
            this.buttonDestinationsBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDestinationsBrowse.Location = new System.Drawing.Point(4, 4);
            this.buttonDestinationsBrowse.Name = "buttonDestinationsBrowse";
            this.buttonDestinationsBrowse.Size = new System.Drawing.Size(98, 23);
            this.buttonDestinationsBrowse.TabIndex = 4;
            this.buttonDestinationsBrowse.Text = "Gestionare";
            this.buttonDestinationsBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipMain.SetToolTip(this.buttonDestinationsBrowse, "Gestionare");
            this.buttonDestinationsBrowse.UseVisualStyleBackColor = true;
            this.buttonDestinationsBrowse.Click += new System.EventHandler(this.buttonDestinationsBrowse_Click);
            // 
            // tabPageEmailSendReports
            // 
            this.tabPageEmailSendReports.Controls.Add(this.tablePanelEmailSendReports);
            this.tabPageEmailSendReports.Location = new System.Drawing.Point(4, 29);
            this.tabPageEmailSendReports.Name = "tabPageEmailSendReports";
            this.tabPageEmailSendReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmailSendReports.Size = new System.Drawing.Size(609, 327);
            this.tabPageEmailSendReports.TabIndex = 3;
            this.tabPageEmailSendReports.Text = "Rapoarte pe email";
            this.tabPageEmailSendReports.UseVisualStyleBackColor = true;
            // 
            // tablePanelEmailSendReports
            // 
            this.tablePanelEmailSendReports.AutoScroll = true;
            this.tablePanelEmailSendReports.BackColor = System.Drawing.SystemColors.Control;
            this.tablePanelEmailSendReports.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tablePanelEmailSendReports.ColumnCount = 3;
            this.tablePanelEmailSendReports.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tablePanelEmailSendReports.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tablePanelEmailSendReports.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanelEmailSendReports.Controls.Add(this.label16, 0, 0);
            this.tablePanelEmailSendReports.Controls.Add(this.checkBoxEmailSendReportStock, 1, 0);
            this.tablePanelEmailSendReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelEmailSendReports.Location = new System.Drawing.Point(3, 3);
            this.tablePanelEmailSendReports.Name = "tablePanelEmailSendReports";
            this.tablePanelEmailSendReports.RowCount = 2;
            this.tablePanelEmailSendReports.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelEmailSendReports.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelEmailSendReports.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelEmailSendReports.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelEmailSendReports.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelEmailSendReports.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelEmailSendReports.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelEmailSendReports.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelEmailSendReports.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelEmailSendReports.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelEmailSendReports.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelEmailSendReports.Size = new System.Drawing.Size(603, 321);
            this.tablePanelEmailSendReports.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(78, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 14);
            this.label16.TabIndex = 9;
            this.label16.Text = "Raport stoc";
            // 
            // checkBoxEmailSendReportStock
            // 
            this.checkBoxEmailSendReportStock.AutoSize = true;
            this.checkBoxEmailSendReportStock.Location = new System.Drawing.Point(155, 4);
            this.checkBoxEmailSendReportStock.Name = "checkBoxEmailSendReportStock";
            this.checkBoxEmailSendReportStock.Size = new System.Drawing.Size(15, 14);
            this.checkBoxEmailSendReportStock.TabIndex = 10;
            this.checkBoxEmailSendReportStock.UseVisualStyleBackColor = true;
            // 
            // ClientFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 500);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ClientFormEdit";
            this.Text = "FormEdit";
            this.Shown += new System.EventHandler(this.FormEdit_Shown);
            this.panelBottom.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMain)).EndInit();
            this.tablePanelGeneral.ResumeLayout(false);
            this.tablePanelGeneral.PerformLayout();
            this.tabPageProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).EndInit();
            this.panelProductsFooter.ResumeLayout(false);
            this.panelProductsFooter.PerformLayout();
            this.panelProductsHeader.ResumeLayout(false);
            this.tabPageDestinations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDestinations)).EndInit();
            this.panelDestinationsFooter.ResumeLayout(false);
            this.panelDestinationsFooter.PerformLayout();
            this.panelDestinationsHeader.ResumeLayout(false);
            this.tabPageEmailSendReports.ResumeLayout(false);
            this.tablePanelEmailSendReports.ResumeLayout(false);
            this.tablePanelEmailSendReports.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.EntityTablePanel tablePanelGeneral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNameLong;
        private System.Windows.Forms.TextBox textBoxNameShort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CustomControls.EntitySelectBox selectBoxCountry;
        private System.Windows.Forms.TextBox textBoxCompany;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNameSymbol3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPageProducts;
        protected CustomControls.EntityGridView gridViewProducts;
        protected System.Windows.Forms.Panel panelProductsFooter;
        private System.Windows.Forms.Label labelMasterFooter;
        protected System.Windows.Forms.Panel panelProductsHeader;
        protected System.Windows.Forms.Button buttonProductsBrowse;
        private System.Windows.Forms.TabPage tabPageDestinations;
        protected CustomControls.EntityGridView gridViewDestinations;
        protected System.Windows.Forms.Panel panelDestinationsFooter;
        private System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Panel panelDestinationsHeader;
        protected System.Windows.Forms.Button buttonDestinationsBrowse;
        private System.Windows.Forms.TextBox textBoxNameSymbol1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxNumberRegistry;
        private System.Windows.Forms.TextBox textBoxNumberFiscal;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxEmailAddressList;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPageEmailSendReports;
        private CustomControls.EntityTablePanel tablePanelEmailSendReports;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox checkBoxEmailSendReportStock;
    }
}