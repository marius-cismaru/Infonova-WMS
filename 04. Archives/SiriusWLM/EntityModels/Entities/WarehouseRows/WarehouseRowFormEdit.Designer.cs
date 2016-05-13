namespace Sirius.EntityModels.WarehouseRows
{
    partial class WarehouseRowFormEdit
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.checkBoxIsInverted = new System.Windows.Forms.CheckBox();
            this.selectBoxWarehouse = new Sirius.CustomControls.EntitySelectBox();
            this.selectBoxWarehouseRoom = new Sirius.CustomControls.EntitySelectBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxIsLimited = new System.Windows.Forms.CheckBox();
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
            this.panelBottom.Size = new System.Drawing.Size(639, 38);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(545, 6);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(452, 6);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Size = new System.Drawing.Size(639, 308);
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.tablePanelGeneral);
            this.tabPageGeneral.Size = new System.Drawing.Size(631, 275);
            // 
            // tablePanelGeneral
            // 
            this.tablePanelGeneral.AutoScroll = true;
            this.tablePanelGeneral.BackColor = System.Drawing.SystemColors.Control;
            this.tablePanelGeneral.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tablePanelGeneral.ColumnCount = 3;
            this.tablePanelGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tablePanelGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tablePanelGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanelGeneral.Controls.Add(this.label1, 0, 2);
            this.tablePanelGeneral.Controls.Add(this.label2, 0, 4);
            this.tablePanelGeneral.Controls.Add(this.label3, 0, 0);
            this.tablePanelGeneral.Controls.Add(this.label4, 0, 1);
            this.tablePanelGeneral.Controls.Add(this.textBoxCode, 1, 2);
            this.tablePanelGeneral.Controls.Add(this.checkBoxIsInverted, 1, 4);
            this.tablePanelGeneral.Controls.Add(this.selectBoxWarehouse, 1, 0);
            this.tablePanelGeneral.Controls.Add(this.selectBoxWarehouseRoom, 1, 1);
            this.tablePanelGeneral.Controls.Add(this.textBoxDescription, 1, 3);
            this.tablePanelGeneral.Controls.Add(this.label5, 0, 3);
            this.tablePanelGeneral.Controls.Add(this.label6, 0, 5);
            this.tablePanelGeneral.Controls.Add(this.checkBoxIsLimited, 1, 5);
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
            this.tablePanelGeneral.Size = new System.Drawing.Size(625, 269);
            this.tablePanelGeneral.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cod";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Inversat?";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Depozit";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Camera";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCode.Location = new System.Drawing.Point(125, 62);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(294, 22);
            this.textBoxCode.TabIndex = 2;
            this.toolTipMain.SetToolTip(this.textBoxCode, "Cod");
            // 
            // checkBoxIsInverted
            // 
            this.checkBoxIsInverted.AutoSize = true;
            this.checkBoxIsInverted.Location = new System.Drawing.Point(125, 120);
            this.checkBoxIsInverted.Name = "checkBoxIsInverted";
            this.checkBoxIsInverted.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIsInverted.TabIndex = 17;
            this.checkBoxIsInverted.UseVisualStyleBackColor = true;
            // 
            // selectBoxWarehouse
            // 
            this.selectBoxWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectBoxWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBoxWarehouse.FormattingEnabled = true;
            this.selectBoxWarehouse.Location = new System.Drawing.Point(125, 4);
            this.selectBoxWarehouse.Name = "selectBoxWarehouse";
            this.selectBoxWarehouse.Size = new System.Drawing.Size(294, 22);
            this.selectBoxWarehouse.TabIndex = 19;
            this.selectBoxWarehouse.SelectedIndexChanged += new System.EventHandler(this.selectBoxWarehouse_SelectedIndexChanged);
            // 
            // selectBoxWarehouseRoom
            // 
            this.selectBoxWarehouseRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectBoxWarehouseRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBoxWarehouseRoom.FormattingEnabled = true;
            this.selectBoxWarehouseRoom.Location = new System.Drawing.Point(125, 33);
            this.selectBoxWarehouseRoom.Name = "selectBoxWarehouseRoom";
            this.selectBoxWarehouseRoom.Size = new System.Drawing.Size(294, 22);
            this.selectBoxWarehouseRoom.TabIndex = 20;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.Location = new System.Drawing.Point(125, 91);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(294, 22);
            this.textBoxDescription.TabIndex = 21;
            this.toolTipMain.SetToolTip(this.textBoxDescription, "Cod");
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 14);
            this.label5.TabIndex = 22;
            this.label5.Text = "Descriere";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 28);
            this.label6.TabIndex = 23;
            this.label6.Text = "Contine containere limitate?";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxIsLimited
            // 
            this.checkBoxIsLimited.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxIsLimited.AutoSize = true;
            this.checkBoxIsLimited.Location = new System.Drawing.Point(125, 145);
            this.checkBoxIsLimited.Name = "checkBoxIsLimited";
            this.checkBoxIsLimited.Size = new System.Drawing.Size(294, 14);
            this.checkBoxIsLimited.TabIndex = 24;
            this.checkBoxIsLimited.UseVisualStyleBackColor = true;
            // 
            // WarehouseRowFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 346);
            this.Name = "WarehouseRowFormEdit";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxIsInverted;
        private CustomControls.EntitySelectBox selectBoxWarehouse;
        private CustomControls.EntitySelectBox selectBoxWarehouseRoom;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxIsLimited;
    }
}