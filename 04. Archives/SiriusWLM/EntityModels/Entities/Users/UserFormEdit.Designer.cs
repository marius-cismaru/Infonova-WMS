namespace Sirius.EntityModels.Users
{
    partial class UserFormEdit
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxNumberPersonal = new System.Windows.Forms.TextBox();
            this.textBoxNumberID = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateBirth = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateEmployment = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateResignation = new System.Windows.Forms.DateTimePicker();
            this.tabPageCompanies = new System.Windows.Forms.TabPage();
            this.entityTablePanel1 = new Sirius.CustomControls.EntityTablePanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.entitySelectBoxCompany = new Sirius.CustomControls.EntitySelectBox();
            this.buttonCompanyAssign = new System.Windows.Forms.Button();
            this.buttonCompanyRemove = new System.Windows.Forms.Button();
            this.entityListBoxCompanies = new Sirius.CustomControls.EntityListBox();
            this.tabPageAuthentification = new System.Windows.Forms.TabPage();
            this.tablePanelAuthentification = new Sirius.CustomControls.EntityTablePanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.checkBoxBelongsToDomain = new System.Windows.Forms.CheckBox();
            this.textBoxDomainName = new System.Windows.Forms.TextBox();
            this.checkBoxIsActive = new System.Windows.Forms.CheckBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panelBottom.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMain)).BeginInit();
            this.tablePanelGeneral.SuspendLayout();
            this.tabPageCompanies.SuspendLayout();
            this.entityTablePanel1.SuspendLayout();
            this.tabPageAuthentification.SuspendLayout();
            this.tablePanelAuthentification.SuspendLayout();
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
            this.tabControlMain.Controls.Add(this.tabPageAuthentification);
            this.tabControlMain.Controls.Add(this.tabPageCompanies);
            this.tabControlMain.Size = new System.Drawing.Size(587, 308);
            this.tabControlMain.Controls.SetChildIndex(this.tabPageCompanies, 0);
            this.tabControlMain.Controls.SetChildIndex(this.tabPageAuthentification, 0);
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
            this.tablePanelGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tablePanelGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tablePanelGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanelGeneral.Controls.Add(this.label7, 0, 5);
            this.tablePanelGeneral.Controls.Add(this.label6, 0, 4);
            this.tablePanelGeneral.Controls.Add(this.label4, 0, 3);
            this.tablePanelGeneral.Controls.Add(this.label1, 0, 1);
            this.tablePanelGeneral.Controls.Add(this.label2, 0, 2);
            this.tablePanelGeneral.Controls.Add(this.label3, 0, 0);
            this.tablePanelGeneral.Controls.Add(this.textBoxName, 1, 0);
            this.tablePanelGeneral.Controls.Add(this.textBoxNumberPersonal, 1, 1);
            this.tablePanelGeneral.Controls.Add(this.textBoxNumberID, 1, 2);
            this.tablePanelGeneral.Controls.Add(this.dateTimePickerDateBirth, 1, 3);
            this.tablePanelGeneral.Controls.Add(this.dateTimePickerDateEmployment, 1, 4);
            this.tablePanelGeneral.Controls.Add(this.dateTimePickerDateResignation, 1, 5);
            this.tablePanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelGeneral.Location = new System.Drawing.Point(3, 3);
            this.tablePanelGeneral.Name = "tablePanelGeneral";
            this.tablePanelGeneral.RowCount = 7;
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.Size = new System.Drawing.Size(573, 269);
            this.tablePanelGeneral.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 14);
            this.label7.TabIndex = 41;
            this.label7.Text = "Data plecare";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data angajare";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data nasterii";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "CNP";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "CI";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nume";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(155, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(294, 22);
            this.textBoxName.TabIndex = 2;
            this.toolTipMain.SetToolTip(this.textBoxName, "Username");
            // 
            // textBoxNumberPersonal
            // 
            this.textBoxNumberPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNumberPersonal.Location = new System.Drawing.Point(155, 33);
            this.textBoxNumberPersonal.Name = "textBoxNumberPersonal";
            this.textBoxNumberPersonal.Size = new System.Drawing.Size(294, 22);
            this.textBoxNumberPersonal.TabIndex = 3;
            // 
            // textBoxNumberID
            // 
            this.textBoxNumberID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNumberID.Location = new System.Drawing.Point(155, 62);
            this.textBoxNumberID.Name = "textBoxNumberID";
            this.textBoxNumberID.Size = new System.Drawing.Size(294, 22);
            this.textBoxNumberID.TabIndex = 13;
            // 
            // dateTimePickerDateBirth
            // 
            this.dateTimePickerDateBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateBirth.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerDateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateBirth.Location = new System.Drawing.Point(155, 91);
            this.dateTimePickerDateBirth.Name = "dateTimePickerDateBirth";
            this.dateTimePickerDateBirth.Size = new System.Drawing.Size(294, 22);
            this.dateTimePickerDateBirth.TabIndex = 38;
            this.toolTipMain.SetToolTip(this.dateTimePickerDateBirth, "Data nasterii");
            // 
            // dateTimePickerDateEmployment
            // 
            this.dateTimePickerDateEmployment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateEmployment.Checked = false;
            this.dateTimePickerDateEmployment.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerDateEmployment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateEmployment.Location = new System.Drawing.Point(155, 120);
            this.dateTimePickerDateEmployment.Name = "dateTimePickerDateEmployment";
            this.dateTimePickerDateEmployment.ShowCheckBox = true;
            this.dateTimePickerDateEmployment.Size = new System.Drawing.Size(294, 22);
            this.dateTimePickerDateEmployment.TabIndex = 39;
            this.toolTipMain.SetToolTip(this.dateTimePickerDateEmployment, "Data angajarii in firma");
            // 
            // dateTimePickerDateResignation
            // 
            this.dateTimePickerDateResignation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateResignation.Checked = false;
            this.dateTimePickerDateResignation.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerDateResignation.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateResignation.Location = new System.Drawing.Point(155, 149);
            this.dateTimePickerDateResignation.Name = "dateTimePickerDateResignation";
            this.dateTimePickerDateResignation.ShowCheckBox = true;
            this.dateTimePickerDateResignation.Size = new System.Drawing.Size(294, 22);
            this.dateTimePickerDateResignation.TabIndex = 40;
            this.toolTipMain.SetToolTip(this.dateTimePickerDateResignation, "Data plecarii din firma");
            // 
            // tabPageCompanies
            // 
            this.tabPageCompanies.Controls.Add(this.entityTablePanel1);
            this.tabPageCompanies.Location = new System.Drawing.Point(4, 29);
            this.tabPageCompanies.Name = "tabPageCompanies";
            this.tabPageCompanies.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCompanies.Size = new System.Drawing.Size(579, 275);
            this.tabPageCompanies.TabIndex = 1;
            this.tabPageCompanies.Text = "Alocare companii";
            this.tabPageCompanies.UseVisualStyleBackColor = true;
            // 
            // entityTablePanel1
            // 
            this.entityTablePanel1.AutoScroll = true;
            this.entityTablePanel1.BackColor = System.Drawing.SystemColors.Control;
            this.entityTablePanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.entityTablePanel1.ColumnCount = 3;
            this.entityTablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.entityTablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.entityTablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.entityTablePanel1.Controls.Add(this.label5, 0, 1);
            this.entityTablePanel1.Controls.Add(this.label8, 0, 0);
            this.entityTablePanel1.Controls.Add(this.entitySelectBoxCompany, 1, 0);
            this.entityTablePanel1.Controls.Add(this.buttonCompanyAssign, 2, 0);
            this.entityTablePanel1.Controls.Add(this.buttonCompanyRemove, 2, 1);
            this.entityTablePanel1.Controls.Add(this.entityListBoxCompanies, 1, 1);
            this.entityTablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entityTablePanel1.Location = new System.Drawing.Point(3, 3);
            this.entityTablePanel1.Name = "entityTablePanel1";
            this.entityTablePanel1.RowCount = 3;
            this.entityTablePanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.entityTablePanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.entityTablePanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.entityTablePanel1.Size = new System.Drawing.Size(573, 269);
            this.entityTablePanel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Companii alocate";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 14);
            this.label8.TabIndex = 5;
            this.label8.Text = "Companie";
            // 
            // entitySelectBoxCompany
            // 
            this.entitySelectBoxCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.entitySelectBoxCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.entitySelectBoxCompany.FormattingEnabled = true;
            this.entitySelectBoxCompany.Location = new System.Drawing.Point(155, 5);
            this.entitySelectBoxCompany.Name = "entitySelectBoxCompany";
            this.entitySelectBoxCompany.Size = new System.Drawing.Size(294, 22);
            this.entitySelectBoxCompany.TabIndex = 6;
            // 
            // buttonCompanyAssign
            // 
            this.buttonCompanyAssign.Location = new System.Drawing.Point(456, 4);
            this.buttonCompanyAssign.Name = "buttonCompanyAssign";
            this.buttonCompanyAssign.Size = new System.Drawing.Size(69, 23);
            this.buttonCompanyAssign.TabIndex = 7;
            this.buttonCompanyAssign.Text = "Alocare";
            this.buttonCompanyAssign.UseVisualStyleBackColor = true;
            this.buttonCompanyAssign.Click += new System.EventHandler(this.buttonCompanyAssign_Click);
            // 
            // buttonCompanyRemove
            // 
            this.buttonCompanyRemove.Location = new System.Drawing.Point(456, 34);
            this.buttonCompanyRemove.Name = "buttonCompanyRemove";
            this.buttonCompanyRemove.Size = new System.Drawing.Size(69, 23);
            this.buttonCompanyRemove.TabIndex = 9;
            this.buttonCompanyRemove.Text = "Stergere";
            this.buttonCompanyRemove.UseVisualStyleBackColor = true;
            this.buttonCompanyRemove.Click += new System.EventHandler(this.buttonCompanyRemove_Click);
            // 
            // entityListBoxCompanies
            // 
            this.entityListBoxCompanies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.entityListBoxCompanies.FormattingEnabled = true;
            this.entityListBoxCompanies.ItemHeight = 14;
            this.entityListBoxCompanies.Location = new System.Drawing.Point(155, 34);
            this.entityListBoxCompanies.Name = "entityListBoxCompanies";
            this.entityListBoxCompanies.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.entityListBoxCompanies.Size = new System.Drawing.Size(294, 130);
            this.entityListBoxCompanies.TabIndex = 10;
            // 
            // tabPageAuthentification
            // 
            this.tabPageAuthentification.Controls.Add(this.tablePanelAuthentification);
            this.tabPageAuthentification.Location = new System.Drawing.Point(4, 29);
            this.tabPageAuthentification.Name = "tabPageAuthentification";
            this.tabPageAuthentification.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAuthentification.Size = new System.Drawing.Size(579, 275);
            this.tabPageAuthentification.TabIndex = 2;
            this.tabPageAuthentification.Text = "Autentificare";
            this.tabPageAuthentification.UseVisualStyleBackColor = true;
            // 
            // tablePanelAuthentification
            // 
            this.tablePanelAuthentification.AutoScroll = true;
            this.tablePanelAuthentification.BackColor = System.Drawing.SystemColors.Control;
            this.tablePanelAuthentification.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tablePanelAuthentification.ColumnCount = 3;
            this.tablePanelAuthentification.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tablePanelAuthentification.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tablePanelAuthentification.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanelAuthentification.Controls.Add(this.label9, 0, 4);
            this.tablePanelAuthentification.Controls.Add(this.label11, 0, 3);
            this.tablePanelAuthentification.Controls.Add(this.label13, 0, 2);
            this.tablePanelAuthentification.Controls.Add(this.label14, 0, 0);
            this.tablePanelAuthentification.Controls.Add(this.textBoxUsername, 1, 0);
            this.tablePanelAuthentification.Controls.Add(this.checkBoxBelongsToDomain, 1, 2);
            this.tablePanelAuthentification.Controls.Add(this.textBoxDomainName, 1, 3);
            this.tablePanelAuthentification.Controls.Add(this.checkBoxIsActive, 1, 4);
            this.tablePanelAuthentification.Controls.Add(this.textBoxPassword, 1, 1);
            this.tablePanelAuthentification.Controls.Add(this.label10, 0, 1);
            this.tablePanelAuthentification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelAuthentification.Location = new System.Drawing.Point(3, 3);
            this.tablePanelAuthentification.Name = "tablePanelAuthentification";
            this.tablePanelAuthentification.RowCount = 6;
            this.tablePanelAuthentification.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelAuthentification.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelAuthentification.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelAuthentification.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelAuthentification.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelAuthentification.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelAuthentification.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelAuthentification.Size = new System.Drawing.Size(573, 269);
            this.tablePanelAuthentification.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(108, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 14);
            this.label9.TabIndex = 12;
            this.label9.Text = "Activ?";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(93, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 14);
            this.label11.TabIndex = 7;
            this.label11.Text = "Domeniu";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(38, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 14);
            this.label13.TabIndex = 4;
            this.label13.Text = "Apartine domeniu?";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(60, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 14);
            this.label14.TabIndex = 5;
            this.label14.Text = "Nume utilizator";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUsername.Location = new System.Drawing.Point(155, 4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(294, 22);
            this.textBoxUsername.TabIndex = 2;
            this.toolTipMain.SetToolTip(this.textBoxUsername, "Username");
            // 
            // checkBoxBelongsToDomain
            // 
            this.checkBoxBelongsToDomain.AutoSize = true;
            this.checkBoxBelongsToDomain.Location = new System.Drawing.Point(155, 62);
            this.checkBoxBelongsToDomain.Name = "checkBoxBelongsToDomain";
            this.checkBoxBelongsToDomain.Size = new System.Drawing.Size(15, 14);
            this.checkBoxBelongsToDomain.TabIndex = 8;
            this.checkBoxBelongsToDomain.UseVisualStyleBackColor = true;
            // 
            // textBoxDomainName
            // 
            this.textBoxDomainName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDomainName.Location = new System.Drawing.Point(155, 83);
            this.textBoxDomainName.Name = "textBoxDomainName";
            this.textBoxDomainName.Size = new System.Drawing.Size(294, 22);
            this.textBoxDomainName.TabIndex = 9;
            this.toolTipMain.SetToolTip(this.textBoxDomainName, "Denumire Domeniu Windows");
            // 
            // checkBoxIsActive
            // 
            this.checkBoxIsActive.AutoSize = true;
            this.checkBoxIsActive.Location = new System.Drawing.Point(155, 112);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIsActive.TabIndex = 11;
            this.checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.Location = new System.Drawing.Point(155, 33);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(294, 22);
            this.textBoxPassword.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(109, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 14);
            this.label10.TabIndex = 10;
            this.label10.Text = "Parola";
            // 
            // UserFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 346);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "UserFormEdit";
            this.Text = "FormEdit";
            this.Shown += new System.EventHandler(this.FormEdit_Shown);
            this.panelBottom.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMain)).EndInit();
            this.tablePanelGeneral.ResumeLayout(false);
            this.tablePanelGeneral.PerformLayout();
            this.tabPageCompanies.ResumeLayout(false);
            this.entityTablePanel1.ResumeLayout(false);
            this.entityTablePanel1.PerformLayout();
            this.tabPageAuthentification.ResumeLayout(false);
            this.tablePanelAuthentification.ResumeLayout(false);
            this.tablePanelAuthentification.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.EntityTablePanel tablePanelGeneral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxNumberPersonal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageCompanies;
        private CustomControls.EntityTablePanel entityTablePanel1;
        private System.Windows.Forms.Label label8;
        private CustomControls.EntitySelectBox entitySelectBoxCompany;
        private System.Windows.Forms.Button buttonCompanyAssign;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCompanyRemove;
        private CustomControls.EntityListBox entityListBoxCompanies;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPageAuthentification;
        private CustomControls.EntityTablePanel tablePanelAuthentification;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.CheckBox checkBoxBelongsToDomain;
        private System.Windows.Forms.TextBox textBoxDomainName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxNumberID;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateBirth;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateEmployment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxIsActive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateResignation;
    }
}