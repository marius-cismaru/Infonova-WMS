namespace Sirius.EntityModels.Labels
{
    partial class LabelFormEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabelFormEdit));
            this.tablePanelGeneral = new Sirius.CustomControls.EntityTablePanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.selectBoxScope = new Sirius.CustomControls.EntitySelectBox();
            this.textBoxDateCreation = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDateModification = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxIsDefault = new System.Windows.Forms.CheckBox();
            this.tabPageHelp = new System.Windows.Forms.TabPage();
            this.richTextBoxHelp = new System.Windows.Forms.RichTextBox();
            this.richTextBoxZPLCode = new System.Windows.Forms.RichTextBox();
            this.panelBottom.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMain)).BeginInit();
            this.tablePanelGeneral.SuspendLayout();
            this.tabPageHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 365);
            this.panelBottom.Size = new System.Drawing.Size(709, 38);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(615, 6);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(522, 6);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageHelp);
            this.tabControlMain.Size = new System.Drawing.Size(709, 365);
            this.tabControlMain.Controls.SetChildIndex(this.tabPageHelp, 0);
            this.tabControlMain.Controls.SetChildIndex(this.tabPageGeneral, 0);
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.tablePanelGeneral);
            this.tabPageGeneral.Size = new System.Drawing.Size(701, 332);
            // 
            // tablePanelGeneral
            // 
            this.tablePanelGeneral.AutoScroll = true;
            this.tablePanelGeneral.BackColor = System.Drawing.SystemColors.Control;
            this.tablePanelGeneral.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tablePanelGeneral.ColumnCount = 3;
            this.tablePanelGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tablePanelGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tablePanelGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanelGeneral.Controls.Add(this.label2, 0, 5);
            this.tablePanelGeneral.Controls.Add(this.label4, 0, 0);
            this.tablePanelGeneral.Controls.Add(this.selectBoxScope, 1, 0);
            this.tablePanelGeneral.Controls.Add(this.textBoxDateCreation, 1, 2);
            this.tablePanelGeneral.Controls.Add(this.textBoxDescription, 1, 4);
            this.tablePanelGeneral.Controls.Add(this.label3, 0, 4);
            this.tablePanelGeneral.Controls.Add(this.label1, 0, 2);
            this.tablePanelGeneral.Controls.Add(this.label5, 0, 3);
            this.tablePanelGeneral.Controls.Add(this.textBoxDateModification, 1, 3);
            this.tablePanelGeneral.Controls.Add(this.label6, 0, 1);
            this.tablePanelGeneral.Controls.Add(this.checkBoxIsDefault, 1, 1);
            this.tablePanelGeneral.Controls.Add(this.richTextBoxZPLCode, 1, 5);
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
            this.tablePanelGeneral.Size = new System.Drawing.Size(695, 326);
            this.tablePanelGeneral.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cod ZPL";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Scop";
            // 
            // selectBoxScope
            // 
            this.selectBoxScope.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectBoxScope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBoxScope.FormattingEnabled = true;
            this.selectBoxScope.Location = new System.Drawing.Point(105, 4);
            this.selectBoxScope.Name = "selectBoxScope";
            this.selectBoxScope.Size = new System.Drawing.Size(494, 22);
            this.selectBoxScope.TabIndex = 6;
            // 
            // textBoxDateCreation
            // 
            this.textBoxDateCreation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDateCreation.Location = new System.Drawing.Point(105, 54);
            this.textBoxDateCreation.Name = "textBoxDateCreation";
            this.textBoxDateCreation.ReadOnly = true;
            this.textBoxDateCreation.Size = new System.Drawing.Size(494, 22);
            this.textBoxDateCreation.TabIndex = 8;
            this.toolTipMain.SetToolTip(this.textBoxDateCreation, "Denumirea completa a Companiei");
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.Location = new System.Drawing.Point(105, 112);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(494, 22);
            this.textBoxDescription.TabIndex = 2;
            this.toolTipMain.SetToolTip(this.textBoxDescription, "Denumirea completa a Companiei");
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descriere";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data creare";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data ultima modificare";
            // 
            // textBoxDateModification
            // 
            this.textBoxDateModification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDateModification.Location = new System.Drawing.Point(105, 83);
            this.textBoxDateModification.Name = "textBoxDateModification";
            this.textBoxDateModification.ReadOnly = true;
            this.textBoxDateModification.Size = new System.Drawing.Size(494, 22);
            this.textBoxDateModification.TabIndex = 11;
            this.toolTipMain.SetToolTip(this.textBoxDateModification, "Denumirea completa a Companiei");
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "Implicit?";
            // 
            // checkBoxIsDefault
            // 
            this.checkBoxIsDefault.AutoSize = true;
            this.checkBoxIsDefault.Location = new System.Drawing.Point(105, 33);
            this.checkBoxIsDefault.Name = "checkBoxIsDefault";
            this.checkBoxIsDefault.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIsDefault.TabIndex = 13;
            this.checkBoxIsDefault.UseVisualStyleBackColor = true;
            // 
            // tabPageHelp
            // 
            this.tabPageHelp.Controls.Add(this.richTextBoxHelp);
            this.tabPageHelp.Location = new System.Drawing.Point(4, 29);
            this.tabPageHelp.Name = "tabPageHelp";
            this.tabPageHelp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHelp.Size = new System.Drawing.Size(701, 332);
            this.tabPageHelp.TabIndex = 1;
            this.tabPageHelp.Text = "Ajutor";
            this.tabPageHelp.UseVisualStyleBackColor = true;
            // 
            // richTextBoxHelp
            // 
            this.richTextBoxHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxHelp.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxHelp.Name = "richTextBoxHelp";
            this.richTextBoxHelp.Size = new System.Drawing.Size(695, 326);
            this.richTextBoxHelp.TabIndex = 0;
            this.richTextBoxHelp.Text = resources.GetString("richTextBoxHelp.Text");
            // 
            // richTextBoxZPLCode
            // 
            this.richTextBoxZPLCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxZPLCode.Location = new System.Drawing.Point(105, 141);
            this.richTextBoxZPLCode.Name = "richTextBoxZPLCode";
            this.richTextBoxZPLCode.Size = new System.Drawing.Size(494, 172);
            this.richTextBoxZPLCode.TabIndex = 14;
            this.richTextBoxZPLCode.Text = "";
            // 
            // LabelFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 403);
            this.Name = "LabelFormEdit";
            this.Text = "FormEdit";
            this.Shown += new System.EventHandler(this.FormEdit_Shown);
            this.panelBottom.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMain)).EndInit();
            this.tablePanelGeneral.ResumeLayout(false);
            this.tablePanelGeneral.PerformLayout();
            this.tabPageHelp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.EntityTablePanel tablePanelGeneral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CustomControls.EntitySelectBox selectBoxScope;
        private System.Windows.Forms.TextBox textBoxDateCreation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDateModification;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxIsDefault;
        private System.Windows.Forms.TabPage tabPageHelp;
        private System.Windows.Forms.RichTextBox richTextBoxHelp;
        private System.Windows.Forms.RichTextBox richTextBoxZPLCode;
    }
}