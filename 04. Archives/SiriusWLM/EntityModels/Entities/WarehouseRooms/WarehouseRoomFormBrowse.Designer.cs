namespace Sirius.EntityModels.WarehouseRooms
{
    partial class WarehouseRoomFormBrowse
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
            this.selectBoxFilterWarehouses = new Sirius.CustomControls.EntitySelectBox();
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
            this.tablePanelFilter.Controls.Add(this.selectBoxFilterWarehouses, 0, 1);
            this.tablePanelFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelFilter.Location = new System.Drawing.Point(0, 0);
            this.tablePanelFilter.Name = "tablePanelFilter";
            this.tablePanelFilter.RowCount = 3;
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            // WarehouseRoomFormBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 419);
            this.Name = "WarehouseRoomFormBrowse";
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
        private CustomControls.EntitySelectBox selectBoxFilterWarehouses;

    }
}