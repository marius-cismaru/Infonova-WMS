namespace Sirius.EntityModels.WarehouseContainers
{
    partial class WarehouseContainerFormAdd
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
            this.v = new Sirius.CustomControls.EntityTablePanel();
            this.selectBoxWarehouse = new Sirius.CustomControls.EntitySelectBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonWarehouseBrowse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.selectBoxWarehouseRoom = new Sirius.CustomControls.EntitySelectBox();
            this.buttonRoomBrowse = new System.Windows.Forms.Button();
            this.selectBoxWarehouseRow = new Sirius.CustomControls.EntitySelectBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonRowBrowse = new System.Windows.Forms.Button();
            this.tabPageStep2 = new System.Windows.Forms.TabPage();
            this.tablePanelStep2 = new Sirius.CustomControls.EntityTablePanel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIntervalCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSlotCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxFloorCount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxIsAvailable = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderError)).BeginInit();
            this.tabControlWizard.SuspendLayout();
            this.tabPageStep1.SuspendLayout();
            this.v.SuspendLayout();
            this.tabPageStep2.SuspendLayout();
            this.tablePanelStep2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlWizard
            // 
            this.tabControlWizard.Controls.Add(this.tabPageStep2);
            this.tabControlWizard.Controls.SetChildIndex(this.tabPageStep2, 0);
            this.tabControlWizard.Controls.SetChildIndex(this.tabPageStep1, 0);
            // 
            // tabPageStep1
            // 
            this.tabPageStep1.Controls.Add(this.v);
            this.tabPageStep1.Text = "Pas 1 / 2 - Selectare depozit";
            // 
            // labelHeaderDescription
            // 
            this.labelHeaderDescription.Size = new System.Drawing.Size(258, 16);
            this.labelHeaderDescription.Text = "Pas 2 / 2 - Introducere date localizare";
            // 
            // v
            // 
            this.v.AutoScroll = true;
            this.v.BackColor = System.Drawing.SystemColors.Control;
            this.v.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.v.ColumnCount = 3;
            this.v.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.v.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.v.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.v.Controls.Add(this.selectBoxWarehouse, 1, 0);
            this.v.Controls.Add(this.label3, 0, 0);
            this.v.Controls.Add(this.buttonWarehouseBrowse, 2, 0);
            this.v.Controls.Add(this.label4, 0, 1);
            this.v.Controls.Add(this.selectBoxWarehouseRoom, 1, 1);
            this.v.Controls.Add(this.buttonRoomBrowse, 2, 1);
            this.v.Controls.Add(this.selectBoxWarehouseRow, 1, 2);
            this.v.Controls.Add(this.label9, 0, 2);
            this.v.Controls.Add(this.buttonRowBrowse, 2, 2);
            this.v.Dock = System.Windows.Forms.DockStyle.Fill;
            this.v.Location = new System.Drawing.Point(3, 3);
            this.v.Name = "v";
            this.v.RowCount = 4;
            this.v.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.v.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.v.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.v.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.v.Size = new System.Drawing.Size(603, 291);
            this.v.TabIndex = 2;
            // 
            // selectBoxWarehouse
            // 
            this.selectBoxWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectBoxWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBoxWarehouse.FormattingEnabled = true;
            this.selectBoxWarehouse.Location = new System.Drawing.Point(105, 5);
            this.selectBoxWarehouse.Name = "selectBoxWarehouse";
            this.selectBoxWarehouse.Size = new System.Drawing.Size(294, 22);
            this.selectBoxWarehouse.TabIndex = 6;
            this.selectBoxWarehouse.SelectedIndexChanged += new System.EventHandler(this.selectBoxWarehouse_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Depozit";
            // 
            // buttonWarehouseBrowse
            // 
            this.buttonWarehouseBrowse.Location = new System.Drawing.Point(406, 4);
            this.buttonWarehouseBrowse.Name = "buttonWarehouseBrowse";
            this.buttonWarehouseBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonWarehouseBrowse.TabIndex = 12;
            this.buttonWarehouseBrowse.Text = "Gestionare";
            this.buttonWarehouseBrowse.UseVisualStyleBackColor = true;
            this.buttonWarehouseBrowse.Click += new System.EventHandler(this.buttonWarehouseBrowse_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Camera";
            // 
            // selectBoxWarehouseRoom
            // 
            this.selectBoxWarehouseRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectBoxWarehouseRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBoxWarehouseRoom.FormattingEnabled = true;
            this.selectBoxWarehouseRoom.Location = new System.Drawing.Point(105, 35);
            this.selectBoxWarehouseRoom.Name = "selectBoxWarehouseRoom";
            this.selectBoxWarehouseRoom.Size = new System.Drawing.Size(294, 22);
            this.selectBoxWarehouseRoom.TabIndex = 13;
            this.selectBoxWarehouseRoom.SelectedIndexChanged += new System.EventHandler(this.selectBoxWarehouseRoom_SelectedIndexChanged);
            // 
            // buttonRoomBrowse
            // 
            this.buttonRoomBrowse.Location = new System.Drawing.Point(406, 34);
            this.buttonRoomBrowse.Name = "buttonRoomBrowse";
            this.buttonRoomBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonRoomBrowse.TabIndex = 14;
            this.buttonRoomBrowse.Text = "Gestionare";
            this.buttonRoomBrowse.UseVisualStyleBackColor = true;
            // 
            // selectBoxWarehouseRow
            // 
            this.selectBoxWarehouseRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectBoxWarehouseRow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBoxWarehouseRow.FormattingEnabled = true;
            this.selectBoxWarehouseRow.Location = new System.Drawing.Point(105, 65);
            this.selectBoxWarehouseRow.Name = "selectBoxWarehouseRow";
            this.selectBoxWarehouseRow.Size = new System.Drawing.Size(294, 22);
            this.selectBoxWarehouseRow.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 14);
            this.label9.TabIndex = 16;
            this.label9.Text = "Rand";
            // 
            // buttonRowBrowse
            // 
            this.buttonRowBrowse.Location = new System.Drawing.Point(406, 64);
            this.buttonRowBrowse.Name = "buttonRowBrowse";
            this.buttonRowBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonRowBrowse.TabIndex = 17;
            this.buttonRowBrowse.Text = "Gestionare";
            this.buttonRowBrowse.UseVisualStyleBackColor = true;
            // 
            // tabPageStep2
            // 
            this.tabPageStep2.Controls.Add(this.tablePanelStep2);
            this.tabPageStep2.Location = new System.Drawing.Point(4, 23);
            this.tabPageStep2.Name = "tabPageStep2";
            this.tabPageStep2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStep2.Size = new System.Drawing.Size(609, 297);
            this.tabPageStep2.TabIndex = 1;
            this.tabPageStep2.Text = "Pas 2 / 2 - Introducere date localizare";
            this.tabPageStep2.UseVisualStyleBackColor = true;
            // 
            // tablePanelStep2
            // 
            this.tablePanelStep2.AutoScroll = true;
            this.tablePanelStep2.BackColor = System.Drawing.SystemColors.Control;
            this.tablePanelStep2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tablePanelStep2.ColumnCount = 3;
            this.tablePanelStep2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tablePanelStep2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tablePanelStep2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanelStep2.Controls.Add(this.label5, 0, 1);
            this.tablePanelStep2.Controls.Add(this.textBoxIntervalCount, 1, 1);
            this.tablePanelStep2.Controls.Add(this.label6, 0, 2);
            this.tablePanelStep2.Controls.Add(this.textBoxSlotCount, 1, 2);
            this.tablePanelStep2.Controls.Add(this.label7, 0, 3);
            this.tablePanelStep2.Controls.Add(this.textBoxFloorCount, 1, 3);
            this.tablePanelStep2.Controls.Add(this.label8, 0, 4);
            this.tablePanelStep2.Controls.Add(this.checkBoxIsAvailable, 1, 4);
            this.tablePanelStep2.Controls.Add(this.label1, 0, 0);
            this.tablePanelStep2.Controls.Add(this.textBoxLocation, 1, 0);
            this.tablePanelStep2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelStep2.Location = new System.Drawing.Point(3, 3);
            this.tablePanelStep2.Name = "tablePanelStep2";
            this.tablePanelStep2.RowCount = 6;
            this.tablePanelStep2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelStep2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelStep2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelStep2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelStep2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelStep2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelStep2.Size = new System.Drawing.Size(603, 291);
            this.tablePanelStep2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 14);
            this.label5.TabIndex = 14;
            this.label5.Text = "Intervale pe rand";
            // 
            // textBoxIntervalCount
            // 
            this.textBoxIntervalCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIntervalCount.Location = new System.Drawing.Point(125, 33);
            this.textBoxIntervalCount.Name = "textBoxIntervalCount";
            this.textBoxIntervalCount.Size = new System.Drawing.Size(294, 22);
            this.textBoxIntervalCount.TabIndex = 15;
            this.toolTipMain.SetToolTip(this.textBoxIntervalCount, "Cod");
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 14);
            this.label6.TabIndex = 16;
            this.label6.Text = "Sloturi pe interval";
            // 
            // textBoxSlotCount
            // 
            this.textBoxSlotCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSlotCount.Location = new System.Drawing.Point(125, 62);
            this.textBoxSlotCount.Name = "textBoxSlotCount";
            this.textBoxSlotCount.Size = new System.Drawing.Size(294, 22);
            this.textBoxSlotCount.TabIndex = 17;
            this.toolTipMain.SetToolTip(this.textBoxSlotCount, "Cod");
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 14);
            this.label7.TabIndex = 18;
            this.label7.Text = "Etaje pe rand";
            // 
            // textBoxFloorCount
            // 
            this.textBoxFloorCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFloorCount.Location = new System.Drawing.Point(125, 91);
            this.textBoxFloorCount.Name = "textBoxFloorCount";
            this.textBoxFloorCount.Size = new System.Drawing.Size(294, 22);
            this.textBoxFloorCount.TabIndex = 19;
            this.toolTipMain.SetToolTip(this.textBoxFloorCount, "Cod");
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 14);
            this.label8.TabIndex = 20;
            this.label8.Text = "Disponibil?";
            // 
            // checkBoxIsAvailable
            // 
            this.checkBoxIsAvailable.AutoSize = true;
            this.checkBoxIsAvailable.Checked = true;
            this.checkBoxIsAvailable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsAvailable.Location = new System.Drawing.Point(125, 120);
            this.checkBoxIsAvailable.Name = "checkBoxIsAvailable";
            this.checkBoxIsAvailable.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIsAvailable.TabIndex = 21;
            this.checkBoxIsAvailable.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 14);
            this.label1.TabIndex = 22;
            this.label1.Text = "Localizare";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLocation.Location = new System.Drawing.Point(125, 4);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.ReadOnly = true;
            this.textBoxLocation.Size = new System.Drawing.Size(294, 22);
            this.textBoxLocation.TabIndex = 23;
            this.toolTipMain.SetToolTip(this.textBoxLocation, "Rand, camera, depozit");
            // 
            // WarehouseContainerFormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 398);
            this.Name = "WarehouseContainerFormAdd";
            this.Text = "FormAdd";
            this.panelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderError)).EndInit();
            this.tabControlWizard.ResumeLayout(false);
            this.tabPageStep1.ResumeLayout(false);
            this.v.ResumeLayout(false);
            this.v.PerformLayout();
            this.tabPageStep2.ResumeLayout(false);
            this.tablePanelStep2.ResumeLayout(false);
            this.tablePanelStep2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.EntityTablePanel v;
        private CustomControls.EntitySelectBox selectBoxWarehouse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonWarehouseBrowse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageStep2;
        private CustomControls.EntityTablePanel tablePanelStep2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxIntervalCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSlotCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxFloorCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxIsAvailable;
        private CustomControls.EntitySelectBox selectBoxWarehouseRoom;
        private System.Windows.Forms.Button buttonRoomBrowse;
        private CustomControls.EntitySelectBox selectBoxWarehouseRow;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonRowBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLocation;
    }
}