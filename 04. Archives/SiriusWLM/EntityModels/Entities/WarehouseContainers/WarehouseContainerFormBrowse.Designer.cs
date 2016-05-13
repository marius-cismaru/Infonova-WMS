namespace Sirius.EntityModels.WarehouseContainers
{
    partial class WarehouseContainerFormBrowse
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
            this.tablePanelFilter = new Sirius.CustomControls.EntityTablePanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFilterRoom = new System.Windows.Forms.TextBox();
            this.selectBoxFilterWarehouses = new Sirius.CustomControls.EntitySelectBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFilterName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.selectBoxFilterIsAvailable = new Sirius.CustomControls.EntitySelectBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxFilterRow = new System.Windows.Forms.TextBox();
            this.textBoxFilterInterval = new System.Windows.Forms.TextBox();
            this.textBoxFilterSlot = new System.Windows.Forms.TextBox();
            this.textBoxFilterFloor = new System.Windows.Forms.TextBox();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFilter)).BeginInit();
            this.splitContainerFilter.Panel1.SuspendLayout();
            this.splitContainerFilter.Panel2.SuspendLayout();
            this.splitContainerFilter.SuspendLayout();
            this.panelFilterHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMasterDetail)).BeginInit();
            this.splitContainerMasterDetail.Panel1.SuspendLayout();
            this.splitContainerMasterDetail.Panel2.SuspendLayout();
            this.splitContainerMasterDetail.SuspendLayout();
            this.panelMasterHeader.SuspendLayout();
            this.panelDetailFooter.SuspendLayout();
            this.panelDetailHeader.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelDetailDescription.SuspendLayout();
            this.tablePanelFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 381);
            this.panelBottom.Size = new System.Drawing.Size(791, 38);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(700, 6);
            // 
            // splitContainerFilter
            // 
            this.splitContainerFilter.Size = new System.Drawing.Size(791, 381);
            this.splitContainerFilter.SplitterDistance = 142;
            // 
            // panelFilterHeader
            // 
            this.panelFilterHeader.Size = new System.Drawing.Size(140, 32);
            // 
            // splitContainerMasterDetail
            // 
            this.splitContainerMasterDetail.Size = new System.Drawing.Size(645, 381);
            this.splitContainerMasterDetail.SplitterDistance = 198;
            // 
            // panelMasterFooter
            // 
            this.panelMasterFooter.Location = new System.Drawing.Point(0, 172);
            this.panelMasterFooter.Size = new System.Drawing.Size(643, 24);
            // 
            // panelMasterHeader
            // 
            this.panelMasterHeader.Size = new System.Drawing.Size(643, 32);
            // 
            // panelDetailFooter
            // 
            this.panelDetailFooter.Location = new System.Drawing.Point(0, 153);
            this.panelDetailFooter.Size = new System.Drawing.Size(643, 24);
            // 
            // panelDetailHeader
            // 
            this.panelDetailHeader.Size = new System.Drawing.Size(643, 32);
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelFilter.Controls.Add(this.tablePanelFilter);
            this.panelFilter.Size = new System.Drawing.Size(140, 347);
            // 
            // buttonMasterRefresh
            // 
            this.toolTipMain.SetToolTip(this.buttonMasterRefresh, "Reimprospatare date");
            // 
            // panelDetailDescription
            // 
            this.panelDetailDescription.Size = new System.Drawing.Size(643, 24);
            // 
            // tablePanelFilter
            // 
            this.tablePanelFilter.AutoScroll = true;
            this.tablePanelFilter.ColumnCount = 1;
            this.tablePanelFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanelFilter.Controls.Add(this.label1, 0, 0);
            this.tablePanelFilter.Controls.Add(this.textBoxFilterRoom, 0, 7);
            this.tablePanelFilter.Controls.Add(this.selectBoxFilterWarehouses, 0, 1);
            this.tablePanelFilter.Controls.Add(this.label3, 0, 6);
            this.tablePanelFilter.Controls.Add(this.label2, 0, 4);
            this.tablePanelFilter.Controls.Add(this.textBoxFilterName, 0, 5);
            this.tablePanelFilter.Controls.Add(this.label4, 0, 2);
            this.tablePanelFilter.Controls.Add(this.selectBoxFilterIsAvailable, 0, 3);
            this.tablePanelFilter.Controls.Add(this.label5, 0, 9);
            this.tablePanelFilter.Controls.Add(this.label6, 0, 11);
            this.tablePanelFilter.Controls.Add(this.label7, 0, 13);
            this.tablePanelFilter.Controls.Add(this.label8, 0, 15);
            this.tablePanelFilter.Controls.Add(this.textBoxFilterRow, 0, 10);
            this.tablePanelFilter.Controls.Add(this.textBoxFilterInterval, 0, 12);
            this.tablePanelFilter.Controls.Add(this.textBoxFilterSlot, 0, 14);
            this.tablePanelFilter.Controls.Add(this.textBoxFilterFloor, 0, 16);
            this.tablePanelFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelFilter.Location = new System.Drawing.Point(0, 0);
            this.tablePanelFilter.Name = "tablePanelFilter";
            this.tablePanelFilter.RowCount = 19;
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
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.Size = new System.Drawing.Size(140, 347);
            this.tablePanelFilter.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Depozit";
            // 
            // textBoxFilterRoom
            // 
            this.textBoxFilterRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilterRoom.Location = new System.Drawing.Point(3, 142);
            this.textBoxFilterRoom.Name = "textBoxFilterRoom";
            this.textBoxFilterRoom.Size = new System.Drawing.Size(134, 22);
            this.textBoxFilterRoom.TabIndex = 5;
            // 
            // selectBoxFilterWarehouses
            // 
            this.selectBoxFilterWarehouses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectBoxFilterWarehouses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBoxFilterWarehouses.FormattingEnabled = true;
            this.selectBoxFilterWarehouses.Location = new System.Drawing.Point(3, 17);
            this.selectBoxFilterWarehouses.Name = "selectBoxFilterWarehouses";
            this.selectBoxFilterWarehouses.Size = new System.Drawing.Size(134, 22);
            this.selectBoxFilterWarehouses.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Camera";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cod";
            // 
            // textBoxFilterName
            // 
            this.textBoxFilterName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilterName.Location = new System.Drawing.Point(3, 100);
            this.textBoxFilterName.Name = "textBoxFilterName";
            this.textBoxFilterName.Size = new System.Drawing.Size(134, 22);
            this.textBoxFilterName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Disponibil?";
            // 
            // selectBoxFilterIsAvailable
            // 
            this.selectBoxFilterIsAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectBoxFilterIsAvailable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBoxFilterIsAvailable.FormattingEnabled = true;
            this.selectBoxFilterIsAvailable.Location = new System.Drawing.Point(3, 59);
            this.selectBoxFilterIsAvailable.Name = "selectBoxFilterIsAvailable";
            this.selectBoxFilterIsAvailable.Size = new System.Drawing.Size(134, 22);
            this.selectBoxFilterIsAvailable.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rand";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 14);
            this.label6.TabIndex = 9;
            this.label6.Text = "Interval";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 14);
            this.label7.TabIndex = 10;
            this.label7.Text = "Slot";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 14);
            this.label8.TabIndex = 11;
            this.label8.Text = "Etaj";
            // 
            // textBoxFilterRow
            // 
            this.textBoxFilterRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilterRow.Location = new System.Drawing.Point(3, 184);
            this.textBoxFilterRow.Name = "textBoxFilterRow";
            this.textBoxFilterRow.Size = new System.Drawing.Size(134, 22);
            this.textBoxFilterRow.TabIndex = 12;
            // 
            // textBoxFilterInterval
            // 
            this.textBoxFilterInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilterInterval.Location = new System.Drawing.Point(3, 226);
            this.textBoxFilterInterval.Name = "textBoxFilterInterval";
            this.textBoxFilterInterval.Size = new System.Drawing.Size(134, 22);
            this.textBoxFilterInterval.TabIndex = 13;
            // 
            // textBoxFilterSlot
            // 
            this.textBoxFilterSlot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilterSlot.Location = new System.Drawing.Point(3, 268);
            this.textBoxFilterSlot.Name = "textBoxFilterSlot";
            this.textBoxFilterSlot.Size = new System.Drawing.Size(134, 22);
            this.textBoxFilterSlot.TabIndex = 14;
            // 
            // textBoxFilterFloor
            // 
            this.textBoxFilterFloor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilterFloor.Location = new System.Drawing.Point(3, 310);
            this.textBoxFilterFloor.Name = "textBoxFilterFloor";
            this.textBoxFilterFloor.Size = new System.Drawing.Size(134, 22);
            this.textBoxFilterFloor.TabIndex = 15;
            // 
            // WarehouseContainerFormBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 419);
            this.Name = "WarehouseContainerFormBrowse";
            this.Text = "FormBrowse";
            this.panelBottom.ResumeLayout(false);
            this.splitContainerFilter.Panel1.ResumeLayout(false);
            this.splitContainerFilter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFilter)).EndInit();
            this.splitContainerFilter.ResumeLayout(false);
            this.panelFilterHeader.ResumeLayout(false);
            this.splitContainerMasterDetail.Panel1.ResumeLayout(false);
            this.splitContainerMasterDetail.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMasterDetail)).EndInit();
            this.splitContainerMasterDetail.ResumeLayout(false);
            this.panelMasterHeader.ResumeLayout(false);
            this.panelDetailFooter.ResumeLayout(false);
            this.panelDetailFooter.PerformLayout();
            this.panelDetailHeader.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelDetailDescription.ResumeLayout(false);
            this.panelDetailDescription.PerformLayout();
            this.tablePanelFilter.ResumeLayout(false);
            this.tablePanelFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.EntityTablePanel tablePanelFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFilterRoom;
        private CustomControls.EntitySelectBox selectBoxFilterWarehouses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFilterName;
        private System.Windows.Forms.Label label4;
        private CustomControls.EntitySelectBox selectBoxFilterIsAvailable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxFilterRow;
        private System.Windows.Forms.TextBox textBoxFilterInterval;
        private System.Windows.Forms.TextBox textBoxFilterSlot;
        private System.Windows.Forms.TextBox textBoxFilterFloor;

    }
}