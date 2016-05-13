namespace Sirius.EntityModels.Products
{
    partial class ProductFormBrowse
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
            this.label1 = new System.Windows.Forms.Label();
            this.selectBoxFilterClients = new Sirius.CustomControls.EntitySelectBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFilterCode = new System.Windows.Forms.TextBox();
            this.textBoxFilterName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tablePanelFilter = new Sirius.CustomControls.EntityTablePanel();
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
            this.panelBottom.Location = new System.Drawing.Point(0, 342);
            this.panelBottom.Size = new System.Drawing.Size(791, 38);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(700, 6);
            // 
            // splitContainerFilter
            // 
            this.splitContainerFilter.Size = new System.Drawing.Size(791, 342);
            this.splitContainerFilter.SplitterDistance = 142;
            // 
            // panelFilterHeader
            // 
            this.panelFilterHeader.Size = new System.Drawing.Size(140, 32);
            // 
            // splitContainerMasterDetail
            // 
            this.splitContainerMasterDetail.Size = new System.Drawing.Size(645, 342);
            this.splitContainerMasterDetail.SplitterDistance = 178;
            // 
            // panelMasterFooter
            // 
            this.panelMasterFooter.Location = new System.Drawing.Point(0, 152);
            this.panelMasterFooter.Size = new System.Drawing.Size(643, 24);
            // 
            // panelMasterHeader
            // 
            this.panelMasterHeader.Size = new System.Drawing.Size(643, 32);
            // 
            // panelDetailFooter
            // 
            this.panelDetailFooter.Location = new System.Drawing.Point(0, 134);
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
            this.panelFilter.Padding = new System.Windows.Forms.Padding(2);
            this.panelFilter.Size = new System.Drawing.Size(140, 308);
            // 
            // buttonMasterRefresh
            // 
            this.toolTipMain.SetToolTip(this.buttonMasterRefresh, "Reimprospatare date");
            // 
            // panelDetailDescription
            // 
            this.panelDetailDescription.Size = new System.Drawing.Size(643, 24);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client";
            // 
            // selectBoxFilterClients
            // 
            this.selectBoxFilterClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectBoxFilterClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBoxFilterClients.FormattingEnabled = true;
            this.selectBoxFilterClients.Location = new System.Drawing.Point(3, 17);
            this.selectBoxFilterClients.Name = "selectBoxFilterClients";
            this.selectBoxFilterClients.Size = new System.Drawing.Size(130, 22);
            this.selectBoxFilterClients.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cod";
            // 
            // textBoxFilterCode
            // 
            this.textBoxFilterCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilterCode.Location = new System.Drawing.Point(3, 59);
            this.textBoxFilterCode.Name = "textBoxFilterCode";
            this.textBoxFilterCode.Size = new System.Drawing.Size(130, 22);
            this.textBoxFilterCode.TabIndex = 3;
            // 
            // textBoxFilterName
            // 
            this.textBoxFilterName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilterName.Location = new System.Drawing.Point(3, 101);
            this.textBoxFilterName.Name = "textBoxFilterName";
            this.textBoxFilterName.Size = new System.Drawing.Size(130, 22);
            this.textBoxFilterName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Denumire";
            // 
            // tablePanelFilter
            // 
            this.tablePanelFilter.AutoScroll = true;
            this.tablePanelFilter.ColumnCount = 1;
            this.tablePanelFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanelFilter.Controls.Add(this.label1, 0, 0);
            this.tablePanelFilter.Controls.Add(this.textBoxFilterName, 0, 5);
            this.tablePanelFilter.Controls.Add(this.selectBoxFilterClients, 0, 1);
            this.tablePanelFilter.Controls.Add(this.label3, 0, 4);
            this.tablePanelFilter.Controls.Add(this.label2, 0, 2);
            this.tablePanelFilter.Controls.Add(this.textBoxFilterCode, 0, 3);
            this.tablePanelFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelFilter.Location = new System.Drawing.Point(2, 2);
            this.tablePanelFilter.Name = "tablePanelFilter";
            this.tablePanelFilter.RowCount = 7;
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.Size = new System.Drawing.Size(136, 304);
            this.tablePanelFilter.TabIndex = 0;
            // 
            // ProductFormBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 380);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ProductFormBrowse";
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

        private System.Windows.Forms.Label label2;
        private CustomControls.EntitySelectBox selectBoxFilterClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFilterName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFilterCode;
        private CustomControls.EntityTablePanel tablePanelFilter;
    }
}