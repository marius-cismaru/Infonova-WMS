namespace Sirius.EntityModels.Companies
{
    partial class CompanyFormEdit
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
            this.buttonCountryBrowse = new System.Windows.Forms.Button();
            this.textBoxNumberRegistry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNumberFiscal = new System.Windows.Forms.TextBox();
            this.textBoxCapitalAmount = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxFax = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxBank = new System.Windows.Forms.TextBox();
            this.textBoxBankAccountRON = new System.Windows.Forms.TextBox();
            this.textBoxBankAccountEUR = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPageEmail = new System.Windows.Forms.TabPage();
            this.tablePanelEmail = new Sirius.CustomControls.EntityTablePanel();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxEmailSendServer = new System.Windows.Forms.TextBox();
            this.textBoxEmailSendPort = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxEmailSendEncryption = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxEmailSendAddress = new System.Windows.Forms.TextBox();
            this.textBoxEmailSendName = new System.Windows.Forms.TextBox();
            this.textBoxEmailSendUsername = new System.Windows.Forms.TextBox();
            this.textBoxEmailSendPassword = new System.Windows.Forms.TextBox();
            this.textBoxEmailReceiveAddressList = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panelBottom.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMain)).BeginInit();
            this.tablePanelGeneral.SuspendLayout();
            this.tabPageEmail.SuspendLayout();
            this.tablePanelEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 375);
            this.panelBottom.Size = new System.Drawing.Size(653, 38);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(559, 6);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(466, 6);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageEmail);
            this.tabControlMain.Size = new System.Drawing.Size(653, 375);
            this.tabControlMain.Controls.SetChildIndex(this.tabPageEmail, 0);
            this.tabControlMain.Controls.SetChildIndex(this.tabPageGeneral, 0);
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.tablePanelGeneral);
            this.tabPageGeneral.Size = new System.Drawing.Size(645, 342);
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
            this.tablePanelGeneral.Controls.Add(this.label1, 0, 1);
            this.tablePanelGeneral.Controls.Add(this.textBoxNameLong, 1, 1);
            this.tablePanelGeneral.Controls.Add(this.textBoxNameShort, 1, 2);
            this.tablePanelGeneral.Controls.Add(this.label2, 0, 2);
            this.tablePanelGeneral.Controls.Add(this.label3, 0, 0);
            this.tablePanelGeneral.Controls.Add(this.selectBoxCountry, 1, 0);
            this.tablePanelGeneral.Controls.Add(this.buttonCountryBrowse, 2, 0);
            this.tablePanelGeneral.Controls.Add(this.textBoxNumberRegistry, 1, 3);
            this.tablePanelGeneral.Controls.Add(this.label4, 0, 3);
            this.tablePanelGeneral.Controls.Add(this.label5, 0, 4);
            this.tablePanelGeneral.Controls.Add(this.label6, 0, 5);
            this.tablePanelGeneral.Controls.Add(this.label7, 0, 6);
            this.tablePanelGeneral.Controls.Add(this.textBoxNumberFiscal, 1, 4);
            this.tablePanelGeneral.Controls.Add(this.textBoxCapitalAmount, 1, 5);
            this.tablePanelGeneral.Controls.Add(this.textBoxPhone, 1, 6);
            this.tablePanelGeneral.Controls.Add(this.textBoxFax, 1, 7);
            this.tablePanelGeneral.Controls.Add(this.textBoxAddress, 1, 8);
            this.tablePanelGeneral.Controls.Add(this.label8, 0, 7);
            this.tablePanelGeneral.Controls.Add(this.label9, 0, 8);
            this.tablePanelGeneral.Controls.Add(this.textBoxBank, 1, 9);
            this.tablePanelGeneral.Controls.Add(this.textBoxBankAccountRON, 1, 10);
            this.tablePanelGeneral.Controls.Add(this.textBoxBankAccountEUR, 1, 11);
            this.tablePanelGeneral.Controls.Add(this.label10, 0, 9);
            this.tablePanelGeneral.Controls.Add(this.label11, 0, 10);
            this.tablePanelGeneral.Controls.Add(this.label12, 0, 11);
            this.tablePanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelGeneral.Location = new System.Drawing.Point(3, 3);
            this.tablePanelGeneral.Name = "tablePanelGeneral";
            this.tablePanelGeneral.RowCount = 13;
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
            this.tablePanelGeneral.Size = new System.Drawing.Size(639, 336);
            this.tablePanelGeneral.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Denumire completa";
            // 
            // textBoxNameLong
            // 
            this.textBoxNameLong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNameLong.Location = new System.Drawing.Point(155, 34);
            this.textBoxNameLong.Name = "textBoxNameLong";
            this.textBoxNameLong.Size = new System.Drawing.Size(294, 22);
            this.textBoxNameLong.TabIndex = 2;
            this.toolTipMain.SetToolTip(this.textBoxNameLong, "Denumirea completa a Companiei");
            // 
            // textBoxNameShort
            // 
            this.textBoxNameShort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNameShort.Location = new System.Drawing.Point(155, 63);
            this.textBoxNameShort.Name = "textBoxNameShort";
            this.textBoxNameShort.Size = new System.Drawing.Size(294, 22);
            this.textBoxNameShort.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Denumire prescurtata";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 8);
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
            this.selectBoxCountry.Location = new System.Drawing.Point(155, 4);
            this.selectBoxCountry.Name = "selectBoxCountry";
            this.selectBoxCountry.Size = new System.Drawing.Size(294, 22);
            this.selectBoxCountry.TabIndex = 6;
            // 
            // buttonCountryBrowse
            // 
            this.buttonCountryBrowse.Location = new System.Drawing.Point(456, 4);
            this.buttonCountryBrowse.Name = "buttonCountryBrowse";
            this.buttonCountryBrowse.Size = new System.Drawing.Size(76, 23);
            this.buttonCountryBrowse.TabIndex = 7;
            this.buttonCountryBrowse.Text = "Gestionare";
            this.buttonCountryBrowse.UseVisualStyleBackColor = true;
            this.buttonCountryBrowse.Click += new System.EventHandler(this.buttonCountryBrowse_Click);
            // 
            // textBoxNumberRegistry
            // 
            this.textBoxNumberRegistry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNumberRegistry.Location = new System.Drawing.Point(155, 92);
            this.textBoxNumberRegistry.Name = "textBoxNumberRegistry";
            this.textBoxNumberRegistry.Size = new System.Drawing.Size(294, 22);
            this.textBoxNumberRegistry.TabIndex = 8;
            this.toolTipMain.SetToolTip(this.textBoxNumberRegistry, "Denumirea completa a Companiei");
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nr. Reg. Com.";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "CUI";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 14);
            this.label6.TabIndex = 11;
            this.label6.Text = "Capital social [RON]";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 14);
            this.label7.TabIndex = 12;
            this.label7.Text = "Telefon";
            // 
            // textBoxNumberFiscal
            // 
            this.textBoxNumberFiscal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNumberFiscal.Location = new System.Drawing.Point(155, 121);
            this.textBoxNumberFiscal.Name = "textBoxNumberFiscal";
            this.textBoxNumberFiscal.Size = new System.Drawing.Size(294, 22);
            this.textBoxNumberFiscal.TabIndex = 13;
            this.toolTipMain.SetToolTip(this.textBoxNumberFiscal, "Denumirea completa a Companiei");
            // 
            // textBoxCapitalAmount
            // 
            this.textBoxCapitalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCapitalAmount.Location = new System.Drawing.Point(155, 150);
            this.textBoxCapitalAmount.Name = "textBoxCapitalAmount";
            this.textBoxCapitalAmount.Size = new System.Drawing.Size(294, 22);
            this.textBoxCapitalAmount.TabIndex = 14;
            this.toolTipMain.SetToolTip(this.textBoxCapitalAmount, "Denumirea completa a Companiei");
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPhone.Location = new System.Drawing.Point(155, 179);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(294, 22);
            this.textBoxPhone.TabIndex = 15;
            this.toolTipMain.SetToolTip(this.textBoxPhone, "Denumirea completa a Companiei");
            // 
            // textBoxFax
            // 
            this.textBoxFax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFax.Location = new System.Drawing.Point(155, 208);
            this.textBoxFax.Name = "textBoxFax";
            this.textBoxFax.Size = new System.Drawing.Size(294, 22);
            this.textBoxFax.TabIndex = 16;
            this.toolTipMain.SetToolTip(this.textBoxFax, "Denumirea completa a Companiei");
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddress.Location = new System.Drawing.Point(155, 237);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(294, 60);
            this.textBoxAddress.TabIndex = 17;
            this.toolTipMain.SetToolTip(this.textBoxAddress, "Denumirea completa a Companiei");
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(123, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 14);
            this.label8.TabIndex = 18;
            this.label8.Text = "Fax";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 14);
            this.label9.TabIndex = 19;
            this.label9.Text = "Adresa sediu social";
            // 
            // textBoxBank
            // 
            this.textBoxBank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBank.Location = new System.Drawing.Point(155, 304);
            this.textBoxBank.Name = "textBoxBank";
            this.textBoxBank.Size = new System.Drawing.Size(294, 22);
            this.textBoxBank.TabIndex = 20;
            this.toolTipMain.SetToolTip(this.textBoxBank, "Denumirea completa a Companiei");
            // 
            // textBoxBankAccountRON
            // 
            this.textBoxBankAccountRON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBankAccountRON.Location = new System.Drawing.Point(155, 333);
            this.textBoxBankAccountRON.Name = "textBoxBankAccountRON";
            this.textBoxBankAccountRON.Size = new System.Drawing.Size(294, 22);
            this.textBoxBankAccountRON.TabIndex = 21;
            this.toolTipMain.SetToolTip(this.textBoxBankAccountRON, "Denumirea completa a Companiei");
            // 
            // textBoxBankAccountEUR
            // 
            this.textBoxBankAccountEUR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBankAccountEUR.Location = new System.Drawing.Point(155, 362);
            this.textBoxBankAccountEUR.Name = "textBoxBankAccountEUR";
            this.textBoxBankAccountEUR.Size = new System.Drawing.Size(294, 22);
            this.textBoxBankAccountEUR.TabIndex = 22;
            this.toolTipMain.SetToolTip(this.textBoxBankAccountEUR, "Denumirea completa a Companiei");
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(109, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 14);
            this.label10.TabIndex = 23;
            this.label10.Text = "Banca";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 337);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 14);
            this.label11.TabIndex = 24;
            this.label11.Text = "Cont bancar IBAN - RON";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 366);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 14);
            this.label12.TabIndex = 25;
            this.label12.Text = "Cont bancar IBAN - EUR";
            // 
            // tabPageEmail
            // 
            this.tabPageEmail.Controls.Add(this.tablePanelEmail);
            this.tabPageEmail.Location = new System.Drawing.Point(4, 29);
            this.tabPageEmail.Name = "tabPageEmail";
            this.tabPageEmail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmail.Size = new System.Drawing.Size(645, 342);
            this.tabPageEmail.TabIndex = 1;
            this.tabPageEmail.Text = "Email";
            this.tabPageEmail.UseVisualStyleBackColor = true;
            // 
            // tablePanelEmail
            // 
            this.tablePanelEmail.AutoScroll = true;
            this.tablePanelEmail.BackColor = System.Drawing.SystemColors.Control;
            this.tablePanelEmail.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tablePanelEmail.ColumnCount = 3;
            this.tablePanelEmail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tablePanelEmail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tablePanelEmail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanelEmail.Controls.Add(this.label13, 0, 0);
            this.tablePanelEmail.Controls.Add(this.textBoxEmailSendServer, 1, 0);
            this.tablePanelEmail.Controls.Add(this.textBoxEmailSendPort, 1, 1);
            this.tablePanelEmail.Controls.Add(this.label14, 0, 1);
            this.tablePanelEmail.Controls.Add(this.textBoxEmailSendEncryption, 1, 2);
            this.tablePanelEmail.Controls.Add(this.label16, 0, 2);
            this.tablePanelEmail.Controls.Add(this.label17, 0, 3);
            this.tablePanelEmail.Controls.Add(this.label18, 0, 4);
            this.tablePanelEmail.Controls.Add(this.label19, 0, 5);
            this.tablePanelEmail.Controls.Add(this.textBoxEmailSendAddress, 1, 3);
            this.tablePanelEmail.Controls.Add(this.textBoxEmailSendName, 1, 4);
            this.tablePanelEmail.Controls.Add(this.textBoxEmailSendUsername, 1, 5);
            this.tablePanelEmail.Controls.Add(this.textBoxEmailSendPassword, 1, 6);
            this.tablePanelEmail.Controls.Add(this.textBoxEmailReceiveAddressList, 1, 7);
            this.tablePanelEmail.Controls.Add(this.label20, 0, 6);
            this.tablePanelEmail.Controls.Add(this.label21, 0, 7);
            this.tablePanelEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelEmail.Location = new System.Drawing.Point(3, 3);
            this.tablePanelEmail.Name = "tablePanelEmail";
            this.tablePanelEmail.RowCount = 9;
            this.tablePanelEmail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelEmail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelEmail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelEmail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelEmail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelEmail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelEmail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelEmail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelEmail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelEmail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelEmail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelEmail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelEmail.Size = new System.Drawing.Size(639, 336);
            this.tablePanelEmail.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(64, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 14);
            this.label13.TabIndex = 1;
            this.label13.Text = "Trimitere email - Server";
            // 
            // textBoxEmailSendServer
            // 
            this.textBoxEmailSendServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmailSendServer.Location = new System.Drawing.Point(205, 4);
            this.textBoxEmailSendServer.Name = "textBoxEmailSendServer";
            this.textBoxEmailSendServer.Size = new System.Drawing.Size(294, 22);
            this.textBoxEmailSendServer.TabIndex = 2;
            // 
            // textBoxEmailSendPort
            // 
            this.textBoxEmailSendPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmailSendPort.Location = new System.Drawing.Point(205, 33);
            this.textBoxEmailSendPort.Name = "textBoxEmailSendPort";
            this.textBoxEmailSendPort.Size = new System.Drawing.Size(294, 22);
            this.textBoxEmailSendPort.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(76, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 14);
            this.label14.TabIndex = 4;
            this.label14.Text = "Trimitere email - Port";
            // 
            // textBoxEmailSendEncryption
            // 
            this.textBoxEmailSendEncryption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmailSendEncryption.Location = new System.Drawing.Point(205, 62);
            this.textBoxEmailSendEncryption.Name = "textBoxEmailSendEncryption";
            this.textBoxEmailSendEncryption.Size = new System.Drawing.Size(294, 22);
            this.textBoxEmailSendEncryption.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(57, 66);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(141, 14);
            this.label16.TabIndex = 9;
            this.label16.Text = "Trimitere email - Criptare";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(62, 95);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(136, 14);
            this.label17.TabIndex = 10;
            this.label17.Text = "Trimitere email - Adresa";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(47, 124);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(151, 14);
            this.label18.TabIndex = 11;
            this.label18.Text = "Trimitere email - Denumire";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(45, 153);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(153, 14);
            this.label19.TabIndex = 12;
            this.label19.Text = "Trimitere email - Username";
            // 
            // textBoxEmailSendAddress
            // 
            this.textBoxEmailSendAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmailSendAddress.Location = new System.Drawing.Point(205, 91);
            this.textBoxEmailSendAddress.Name = "textBoxEmailSendAddress";
            this.textBoxEmailSendAddress.Size = new System.Drawing.Size(294, 22);
            this.textBoxEmailSendAddress.TabIndex = 13;
            // 
            // textBoxEmailSendName
            // 
            this.textBoxEmailSendName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmailSendName.Location = new System.Drawing.Point(205, 120);
            this.textBoxEmailSendName.Name = "textBoxEmailSendName";
            this.textBoxEmailSendName.Size = new System.Drawing.Size(294, 22);
            this.textBoxEmailSendName.TabIndex = 14;
            // 
            // textBoxEmailSendUsername
            // 
            this.textBoxEmailSendUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmailSendUsername.Location = new System.Drawing.Point(205, 149);
            this.textBoxEmailSendUsername.Name = "textBoxEmailSendUsername";
            this.textBoxEmailSendUsername.Size = new System.Drawing.Size(294, 22);
            this.textBoxEmailSendUsername.TabIndex = 15;
            // 
            // textBoxEmailSendPassword
            // 
            this.textBoxEmailSendPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmailSendPassword.Location = new System.Drawing.Point(205, 178);
            this.textBoxEmailSendPassword.Name = "textBoxEmailSendPassword";
            this.textBoxEmailSendPassword.Size = new System.Drawing.Size(294, 22);
            this.textBoxEmailSendPassword.TabIndex = 16;
            // 
            // textBoxEmailReceiveAddressList
            // 
            this.textBoxEmailReceiveAddressList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmailReceiveAddressList.Location = new System.Drawing.Point(205, 207);
            this.textBoxEmailReceiveAddressList.Multiline = true;
            this.textBoxEmailReceiveAddressList.Name = "textBoxEmailReceiveAddressList";
            this.textBoxEmailReceiveAddressList.Size = new System.Drawing.Size(294, 100);
            this.textBoxEmailReceiveAddressList.TabIndex = 17;
            this.toolTipMain.SetToolTip(this.textBoxEmailReceiveAddressList, "Denumirea completa a Companiei");
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(67, 182);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(131, 14);
            this.label20.TabIndex = 18;
            this.label20.Text = "Trimitere email - Parola";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(56, 250);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(142, 14);
            this.label21.TabIndex = 19;
            this.label21.Text = "Lista adrese primire email";
            // 
            // CompanyFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 413);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CompanyFormEdit";
            this.Text = "FormEdit";
            this.Shown += new System.EventHandler(this.FormEdit_Shown);
            this.panelBottom.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMain)).EndInit();
            this.tablePanelGeneral.ResumeLayout(false);
            this.tablePanelGeneral.PerformLayout();
            this.tabPageEmail.ResumeLayout(false);
            this.tablePanelEmail.ResumeLayout(false);
            this.tablePanelEmail.PerformLayout();
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
        private System.Windows.Forms.Button buttonCountryBrowse;
        private System.Windows.Forms.TextBox textBoxNumberRegistry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNumberFiscal;
        private System.Windows.Forms.TextBox textBoxCapitalAmount;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxFax;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxBank;
        private System.Windows.Forms.TextBox textBoxBankAccountRON;
        private System.Windows.Forms.TextBox textBoxBankAccountEUR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPageEmail;
        private CustomControls.EntityTablePanel tablePanelEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxEmailSendServer;
        private System.Windows.Forms.TextBox textBoxEmailSendPort;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxEmailSendEncryption;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxEmailSendAddress;
        private System.Windows.Forms.TextBox textBoxEmailSendName;
        private System.Windows.Forms.TextBox textBoxEmailSendUsername;
        private System.Windows.Forms.TextBox textBoxEmailSendPassword;
        private System.Windows.Forms.TextBox textBoxEmailReceiveAddressList;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
    }
}