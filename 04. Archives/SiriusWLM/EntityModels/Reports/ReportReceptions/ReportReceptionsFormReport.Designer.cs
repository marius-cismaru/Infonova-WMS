namespace Sirius.EntityModels.Reports
{
    partial class ReportReceptionsFormReport
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
            this.label7 = new System.Windows.Forms.Label();
            this.selectBoxFilterClient = new Sirius.CustomControls.EntitySelectBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectBoxFilterWarehouse = new Sirius.CustomControls.EntitySelectBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.selectBoxFilterProduct = new Sirius.CustomControls.EntitySelectBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFilterReceptionNumber = new System.Windows.Forms.TextBox();
            this.textBoxFilterDeliveryNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerFilterDateExecutionBegin = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerFilterDateExecutionEnd = new System.Windows.Forms.DateTimePicker();
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
            // panelBottom
            // 
            this.panelBottom.Size = new System.Drawing.Size(780, 38);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(686, 6);
            // 
            // splitContainerFilter
            // 
            this.splitContainerFilter.Size = new System.Drawing.Size(780, 359);
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
            this.tablePanelFilter.Controls.Add(this.label7, 0, 8);
            this.tablePanelFilter.Controls.Add(this.selectBoxFilterClient, 0, 1);
            this.tablePanelFilter.Controls.Add(this.label1, 0, 2);
            this.tablePanelFilter.Controls.Add(this.selectBoxFilterWarehouse, 0, 3);
            this.tablePanelFilter.Controls.Add(this.label9, 0, 0);
            this.tablePanelFilter.Controls.Add(this.label4, 0, 6);
            this.tablePanelFilter.Controls.Add(this.selectBoxFilterProduct, 0, 5);
            this.tablePanelFilter.Controls.Add(this.label2, 0, 4);
            this.tablePanelFilter.Controls.Add(this.textBoxFilterReceptionNumber, 0, 9);
            this.tablePanelFilter.Controls.Add(this.textBoxFilterDeliveryNumber, 0, 7);
            this.tablePanelFilter.Controls.Add(this.label5, 0, 10);
            this.tablePanelFilter.Controls.Add(this.dateTimePickerFilterDateExecutionBegin, 0, 11);
            this.tablePanelFilter.Controls.Add(this.label6, 0, 12);
            this.tablePanelFilter.Controls.Add(this.dateTimePickerFilterDateExecutionEnd, 0, 13);
            this.tablePanelFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelFilter.Location = new System.Drawing.Point(0, 0);
            this.tablePanelFilter.Name = "tablePanelFilter";
            this.tablePanelFilter.RowCount = 15;
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
            this.tablePanelFilter.Size = new System.Drawing.Size(173, 325);
            this.tablePanelFilter.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 14);
            this.label7.TabIndex = 27;
            this.label7.Text = "Numar receptie";
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
            this.selectBoxFilterClient.SelectedIndexChanged += new System.EventHandler(this.selectBoxFilterClient_SelectedIndexChanged);
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
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 21;
            this.label4.Text = "Numar livrare";
            // 
            // selectBoxFilterProduct
            // 
            this.selectBoxFilterProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectBoxFilterProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBoxFilterProduct.FormattingEnabled = true;
            this.selectBoxFilterProduct.Location = new System.Drawing.Point(3, 101);
            this.selectBoxFilterProduct.Name = "selectBoxFilterProduct";
            this.selectBoxFilterProduct.Size = new System.Drawing.Size(167, 22);
            this.selectBoxFilterProduct.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Articol";
            // 
            // textBoxFilterReceptionNumber
            // 
            this.textBoxFilterReceptionNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilterReceptionNumber.Location = new System.Drawing.Point(3, 185);
            this.textBoxFilterReceptionNumber.Name = "textBoxFilterReceptionNumber";
            this.textBoxFilterReceptionNumber.Size = new System.Drawing.Size(167, 22);
            this.textBoxFilterReceptionNumber.TabIndex = 22;
            // 
            // textBoxFilterDeliveryNumber
            // 
            this.textBoxFilterDeliveryNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilterDeliveryNumber.Location = new System.Drawing.Point(3, 143);
            this.textBoxFilterDeliveryNumber.Name = "textBoxFilterDeliveryNumber";
            this.textBoxFilterDeliveryNumber.Size = new System.Drawing.Size(167, 22);
            this.textBoxFilterDeliveryNumber.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 14);
            this.label5.TabIndex = 23;
            this.label5.Text = "Data de la";
            // 
            // dateTimePickerFilterDateExecutionBegin
            // 
            this.dateTimePickerFilterDateExecutionBegin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFilterDateExecutionBegin.Checked = false;
            this.dateTimePickerFilterDateExecutionBegin.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerFilterDateExecutionBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFilterDateExecutionBegin.Location = new System.Drawing.Point(3, 227);
            this.dateTimePickerFilterDateExecutionBegin.Name = "dateTimePickerFilterDateExecutionBegin";
            this.dateTimePickerFilterDateExecutionBegin.ShowCheckBox = true;
            this.dateTimePickerFilterDateExecutionBegin.Size = new System.Drawing.Size(167, 22);
            this.dateTimePickerFilterDateExecutionBegin.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 14);
            this.label6.TabIndex = 24;
            this.label6.Text = "Data pana la";
            // 
            // dateTimePickerFilterDateExecutionEnd
            // 
            this.dateTimePickerFilterDateExecutionEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFilterDateExecutionEnd.Checked = false;
            this.dateTimePickerFilterDateExecutionEnd.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerFilterDateExecutionEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFilterDateExecutionEnd.Location = new System.Drawing.Point(3, 269);
            this.dateTimePickerFilterDateExecutionEnd.Name = "dateTimePickerFilterDateExecutionEnd";
            this.dateTimePickerFilterDateExecutionEnd.ShowCheckBox = true;
            this.dateTimePickerFilterDateExecutionEnd.Size = new System.Drawing.Size(167, 22);
            this.dateTimePickerFilterDateExecutionEnd.TabIndex = 25;
            // 
            // ReportDeliveriesFormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 397);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ReportDeliveriesFormReport";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private CustomControls.EntitySelectBox selectBoxFilterProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFilterReceptionNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxFilterDeliveryNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerFilterDateExecutionBegin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerFilterDateExecutionEnd;
    }
}