namespace Sirius.EntityModels.Packages
{
    partial class PackageFormBrowse
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
            this.selectBoxFilterClient = new Sirius.CustomControls.EntitySelectBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectBoxFilterWarehouse = new Sirius.CustomControls.EntitySelectBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFilterCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.selectBoxFilterProduct = new Sirius.CustomControls.EntitySelectBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFilterWarehouseContainerName = new System.Windows.Forms.TextBox();
            this.textBoxFilterReceptionNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFilterDeliveryNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.selectBoxIsExisting = new Sirius.CustomControls.EntitySelectBox();
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
            this.panelBottom.Location = new System.Drawing.Point(0, 519);
            this.panelBottom.Size = new System.Drawing.Size(910, 38);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(819, 6);
            // 
            // splitContainerFilter
            // 
            this.splitContainerFilter.Size = new System.Drawing.Size(910, 519);
            this.splitContainerFilter.SplitterDistance = 160;
            // 
            // panelFilterHeader
            // 
            this.panelFilterHeader.Size = new System.Drawing.Size(158, 32);
            // 
            // splitContainerMasterDetail
            // 
            this.splitContainerMasterDetail.Size = new System.Drawing.Size(746, 519);
            this.splitContainerMasterDetail.SplitterDistance = 245;
            // 
            // panelMasterFooter
            // 
            this.panelMasterFooter.Location = new System.Drawing.Point(0, 219);
            this.panelMasterFooter.Size = new System.Drawing.Size(744, 24);
            // 
            // panelMasterHeader
            // 
            this.panelMasterHeader.Size = new System.Drawing.Size(744, 32);
            // 
            // buttonMasterDelete
            // 
            this.buttonMasterDelete.Enabled = false;
            // 
            // buttonMasterEdit
            // 
            this.buttonMasterEdit.Enabled = false;
            // 
            // buttonMasterView
            // 
            this.buttonMasterView.Enabled = false;
            // 
            // panelDetailFooter
            // 
            this.panelDetailFooter.Location = new System.Drawing.Point(0, 244);
            this.panelDetailFooter.Size = new System.Drawing.Size(744, 24);
            // 
            // panelDetailHeader
            // 
            this.panelDetailHeader.Size = new System.Drawing.Size(744, 32);
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelFilter.Controls.Add(this.tablePanelFilter);
            this.panelFilter.Size = new System.Drawing.Size(158, 485);
            // 
            // buttonMasterRefresh
            // 
            this.toolTipMain.SetToolTip(this.buttonMasterRefresh, "Reimprospatare date");
            // 
            // panelDetailDescription
            // 
            this.panelDetailDescription.Size = new System.Drawing.Size(744, 24);
            // 
            // tablePanelFilter
            // 
            this.tablePanelFilter.AutoScroll = true;
            this.tablePanelFilter.ColumnCount = 1;
            this.tablePanelFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanelFilter.Controls.Add(this.selectBoxFilterClient, 0, 3);
            this.tablePanelFilter.Controls.Add(this.label1, 0, 4);
            this.tablePanelFilter.Controls.Add(this.selectBoxFilterWarehouse, 0, 5);
            this.tablePanelFilter.Controls.Add(this.label3, 0, 10);
            this.tablePanelFilter.Controls.Add(this.label2, 0, 6);
            this.tablePanelFilter.Controls.Add(this.textBoxFilterCode, 0, 9);
            this.tablePanelFilter.Controls.Add(this.label9, 0, 2);
            this.tablePanelFilter.Controls.Add(this.label5, 0, 12);
            this.tablePanelFilter.Controls.Add(this.selectBoxFilterProduct, 0, 7);
            this.tablePanelFilter.Controls.Add(this.label4, 0, 8);
            this.tablePanelFilter.Controls.Add(this.textBoxFilterWarehouseContainerName, 0, 11);
            this.tablePanelFilter.Controls.Add(this.textBoxFilterReceptionNumber, 0, 13);
            this.tablePanelFilter.Controls.Add(this.label6, 0, 14);
            this.tablePanelFilter.Controls.Add(this.textBoxFilterDeliveryNumber, 0, 15);
            this.tablePanelFilter.Controls.Add(this.label7, 0, 0);
            this.tablePanelFilter.Controls.Add(this.selectBoxIsExisting, 0, 1);
            this.tablePanelFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelFilter.Location = new System.Drawing.Point(0, 0);
            this.tablePanelFilter.Name = "tablePanelFilter";
            this.tablePanelFilter.RowCount = 17;
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
            this.tablePanelFilter.Size = new System.Drawing.Size(158, 485);
            this.tablePanelFilter.TabIndex = 1;
            // 
            // selectBoxFilterClient
            // 
            this.selectBoxFilterClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectBoxFilterClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBoxFilterClient.FormattingEnabled = true;
            this.selectBoxFilterClient.Location = new System.Drawing.Point(3, 59);
            this.selectBoxFilterClient.Name = "selectBoxFilterClient";
            this.selectBoxFilterClient.Size = new System.Drawing.Size(152, 22);
            this.selectBoxFilterClient.TabIndex = 17;
            this.selectBoxFilterClient.SelectedIndexChanged += new System.EventHandler(this.selectBoxFilterClient_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Depozit";
            // 
            // selectBoxFilterWarehouse
            // 
            this.selectBoxFilterWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectBoxFilterWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBoxFilterWarehouse.FormattingEnabled = true;
            this.selectBoxFilterWarehouse.Location = new System.Drawing.Point(3, 101);
            this.selectBoxFilterWarehouse.Name = "selectBoxFilterWarehouse";
            this.selectBoxFilterWarehouse.Size = new System.Drawing.Size(152, 22);
            this.selectBoxFilterWarehouse.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Container";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Articol";
            // 
            // textBoxFilterCode
            // 
            this.textBoxFilterCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilterCode.Location = new System.Drawing.Point(3, 185);
            this.textBoxFilterCode.Name = "textBoxFilterCode";
            this.textBoxFilterCode.Size = new System.Drawing.Size(152, 22);
            this.textBoxFilterCode.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 14);
            this.label9.TabIndex = 16;
            this.label9.Text = "Client";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Numar receptie";
            // 
            // selectBoxFilterProduct
            // 
            this.selectBoxFilterProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectBoxFilterProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBoxFilterProduct.FormattingEnabled = true;
            this.selectBoxFilterProduct.Location = new System.Drawing.Point(3, 143);
            this.selectBoxFilterProduct.Name = "selectBoxFilterProduct";
            this.selectBoxFilterProduct.Size = new System.Drawing.Size(152, 22);
            this.selectBoxFilterProduct.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 14);
            this.label4.TabIndex = 20;
            this.label4.Text = "Cod";
            // 
            // textBoxFilterWarehouseContainerName
            // 
            this.textBoxFilterWarehouseContainerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilterWarehouseContainerName.Location = new System.Drawing.Point(3, 227);
            this.textBoxFilterWarehouseContainerName.Name = "textBoxFilterWarehouseContainerName";
            this.textBoxFilterWarehouseContainerName.Size = new System.Drawing.Size(152, 22);
            this.textBoxFilterWarehouseContainerName.TabIndex = 21;
            // 
            // textBoxFilterReceptionNumber
            // 
            this.textBoxFilterReceptionNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilterReceptionNumber.Location = new System.Drawing.Point(3, 269);
            this.textBoxFilterReceptionNumber.Name = "textBoxFilterReceptionNumber";
            this.textBoxFilterReceptionNumber.Size = new System.Drawing.Size(152, 22);
            this.textBoxFilterReceptionNumber.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 14);
            this.label6.TabIndex = 23;
            this.label6.Text = "Numar livrare";
            // 
            // textBoxFilterDeliveryNumber
            // 
            this.textBoxFilterDeliveryNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilterDeliveryNumber.Location = new System.Drawing.Point(3, 311);
            this.textBoxFilterDeliveryNumber.Name = "textBoxFilterDeliveryNumber";
            this.textBoxFilterDeliveryNumber.Size = new System.Drawing.Size(152, 22);
            this.textBoxFilterDeliveryNumber.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 14);
            this.label7.TabIndex = 25;
            this.label7.Text = "Existent?";
            // 
            // selectBoxIsExisting
            // 
            this.selectBoxIsExisting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectBoxIsExisting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBoxIsExisting.FormattingEnabled = true;
            this.selectBoxIsExisting.Location = new System.Drawing.Point(3, 17);
            this.selectBoxIsExisting.Name = "selectBoxIsExisting";
            this.selectBoxIsExisting.Size = new System.Drawing.Size(152, 22);
            this.selectBoxIsExisting.TabIndex = 26;
            // 
            // PackageFormBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 557);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "PackageFormBrowse";
            this.Text = "FormBrowse";
            this.Controls.SetChildIndex(this.panelBottom, 0);
            this.Controls.SetChildIndex(this.splitContainerFilter, 0);
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
            this.panelMasterHeader.PerformLayout();
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
        private CustomControls.EntitySelectBox selectBoxFilterWarehouse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFilterCode;
        private System.Windows.Forms.Label label5;
        private CustomControls.EntitySelectBox selectBoxFilterClient;
        private System.Windows.Forms.Label label9;
        private CustomControls.EntitySelectBox selectBoxFilterProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFilterWarehouseContainerName;
        private System.Windows.Forms.TextBox textBoxFilterReceptionNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFilterDeliveryNumber;
        private System.Windows.Forms.Label label7;
        private CustomControls.EntitySelectBox selectBoxIsExisting;

    }
}