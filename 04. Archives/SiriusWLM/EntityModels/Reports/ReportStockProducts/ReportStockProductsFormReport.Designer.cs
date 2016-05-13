namespace Sirius.EntityModels.Reports
{
    partial class ReportStockProductsFormReport
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
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePickerFilterDateExecution = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFilter)).BeginInit();
            this.splitContainerFilter.Panel1.SuspendLayout();
            this.splitContainerFilter.Panel2.SuspendLayout();
            this.splitContainerFilter.SuspendLayout();
            this.panelFilterHeader.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelMasterHeader.SuspendLayout();
            this.tablePanelFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerFilter
            // 
            this.splitContainerFilter.SplitterDistance = 175;
            // 
            // panelFilterHeader
            // 
            this.panelFilterHeader.Size = new System.Drawing.Size(173, 32);
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.tablePanelFilter);
            this.panelFilter.Size = new System.Drawing.Size(173, 325);
            // 
            // panelMasterHeader
            // 
            this.panelMasterHeader.Size = new System.Drawing.Size(599, 32);
            // 
            // tablePanelFilter
            // 
            this.tablePanelFilter.AutoScroll = true;
            this.tablePanelFilter.ColumnCount = 1;
            this.tablePanelFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanelFilter.Controls.Add(this.selectBoxFilterClient, 0, 1);
            this.tablePanelFilter.Controls.Add(this.label1, 0, 2);
            this.tablePanelFilter.Controls.Add(this.selectBoxFilterWarehouse, 0, 3);
            this.tablePanelFilter.Controls.Add(this.label9, 0, 0);
            this.tablePanelFilter.Controls.Add(this.dateTimePickerFilterDateExecution, 0, 5);
            this.tablePanelFilter.Controls.Add(this.label3, 0, 4);
            this.tablePanelFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelFilter.Location = new System.Drawing.Point(0, 0);
            this.tablePanelFilter.Name = "tablePanelFilter";
            this.tablePanelFilter.RowCount = 7;
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelFilter.Size = new System.Drawing.Size(173, 325);
            this.tablePanelFilter.TabIndex = 2;
            // 
            // selectBoxFilterClient
            // 
            this.selectBoxFilterClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectBoxFilterClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBoxFilterClient.FormattingEnabled = true;
            this.selectBoxFilterClient.Location = new System.Drawing.Point(3, 17);
            this.selectBoxFilterClient.Name = "selectBoxFilterClient";
            this.selectBoxFilterClient.Size = new System.Drawing.Size(167, 22);
            this.selectBoxFilterClient.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 42);
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
            this.selectBoxFilterWarehouse.Location = new System.Drawing.Point(3, 59);
            this.selectBoxFilterWarehouse.Name = "selectBoxFilterWarehouse";
            this.selectBoxFilterWarehouse.Size = new System.Drawing.Size(167, 22);
            this.selectBoxFilterWarehouse.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 14);
            this.label9.TabIndex = 16;
            this.label9.Text = "Client";
            // 
            // dateTimePickerFilterDateExecution
            // 
            this.dateTimePickerFilterDateExecution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFilterDateExecution.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerFilterDateExecution.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFilterDateExecution.Location = new System.Drawing.Point(3, 101);
            this.dateTimePickerFilterDateExecution.Name = "dateTimePickerFilterDateExecution";
            this.dateTimePickerFilterDateExecution.Size = new System.Drawing.Size(167, 22);
            this.dateTimePickerFilterDateExecution.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data executie";
            // 
            // ReportStockProductsFormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 397);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ReportStockProductsFormReport";
            this.Text = "ReportStockFormReport";
            this.panelBottom.ResumeLayout(false);
            this.splitContainerFilter.Panel1.ResumeLayout(false);
            this.splitContainerFilter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFilter)).EndInit();
            this.splitContainerFilter.ResumeLayout(false);
            this.panelFilterHeader.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelMasterHeader.ResumeLayout(false);
            this.tablePanelFilter.ResumeLayout(false);
            this.tablePanelFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.EntityTablePanel tablePanelFilter;
        private CustomControls.EntitySelectBox selectBoxFilterClient;
        private System.Windows.Forms.Label label1;
        private CustomControls.EntitySelectBox selectBoxFilterWarehouse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePickerFilterDateExecution;
    }
}