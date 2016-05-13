namespace Sirius.EntityModels.WarehouseContainers
{
    partial class WarehouseContainerFormSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseContainerFormSelect));
            this.panelFooter = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.splitContainerWarehouseContainersMain = new System.Windows.Forms.SplitContainer();
            this.splitContainerWarehouseContainersLeft = new System.Windows.Forms.SplitContainer();
            this.tablePanelWarehouseContainersLeft = new Sirius.CustomControls.EntityTablePanel();
            this.label8 = new System.Windows.Forms.Label();
            this.selectBoxWarehouseRoom = new Sirius.CustomControls.EntitySelectBox();
            this.label9 = new System.Windows.Forms.Label();
            this.selectBoxWarehouseRow = new Sirius.CustomControls.EntitySelectBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWarehouse = new System.Windows.Forms.TextBox();
            this.listBoxWarehouseContainers = new Sirius.CustomControls.EntityListBox();
            this.panelWarehouseContainersLeftHeader = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxWarehouseContainers = new System.Windows.Forms.PictureBox();
            this.panelWarehouseContainersMainHeader = new System.Windows.Forms.Panel();
            this.buttonWarehouseContainersReset = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerWarehouseContainersMain)).BeginInit();
            this.splitContainerWarehouseContainersMain.Panel1.SuspendLayout();
            this.splitContainerWarehouseContainersMain.Panel2.SuspendLayout();
            this.splitContainerWarehouseContainersMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerWarehouseContainersLeft)).BeginInit();
            this.splitContainerWarehouseContainersLeft.Panel1.SuspendLayout();
            this.splitContainerWarehouseContainersLeft.Panel2.SuspendLayout();
            this.splitContainerWarehouseContainersLeft.SuspendLayout();
            this.tablePanelWarehouseContainersLeft.SuspendLayout();
            this.panelWarehouseContainersLeftHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarehouseContainers)).BeginInit();
            this.panelWarehouseContainersMainHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.buttonCancel);
            this.panelFooter.Controls.Add(this.buttonOK);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 308);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(2);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(601, 38);
            this.panelFooter.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(414, 7);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 25);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Anulare";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Image = ((System.Drawing.Image)(resources.GetObject("buttonOK.Image")));
            this.buttonOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOK.Location = new System.Drawing.Point(507, 7);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(87, 25);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // splitContainerWarehouseContainersMain
            // 
            this.splitContainerWarehouseContainersMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerWarehouseContainersMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerWarehouseContainersMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerWarehouseContainersMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerWarehouseContainersMain.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainerWarehouseContainersMain.Name = "splitContainerWarehouseContainersMain";
            // 
            // splitContainerWarehouseContainersMain.Panel1
            // 
            this.splitContainerWarehouseContainersMain.Panel1.Controls.Add(this.splitContainerWarehouseContainersLeft);
            this.splitContainerWarehouseContainersMain.Panel1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            // 
            // splitContainerWarehouseContainersMain.Panel2
            // 
            this.splitContainerWarehouseContainersMain.Panel2.Controls.Add(this.pictureBoxWarehouseContainers);
            this.splitContainerWarehouseContainersMain.Panel2.Controls.Add(this.panelWarehouseContainersMainHeader);
            this.splitContainerWarehouseContainersMain.Panel2.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.splitContainerWarehouseContainersMain.Size = new System.Drawing.Size(601, 308);
            this.splitContainerWarehouseContainersMain.SplitterDistance = 176;
            this.splitContainerWarehouseContainersMain.SplitterWidth = 3;
            this.splitContainerWarehouseContainersMain.TabIndex = 2;
            // 
            // splitContainerWarehouseContainersLeft
            // 
            this.splitContainerWarehouseContainersLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerWarehouseContainersLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerWarehouseContainersLeft.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerWarehouseContainersLeft.Location = new System.Drawing.Point(2, 1);
            this.splitContainerWarehouseContainersLeft.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainerWarehouseContainersLeft.Name = "splitContainerWarehouseContainersLeft";
            this.splitContainerWarehouseContainersLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerWarehouseContainersLeft.Panel1
            // 
            this.splitContainerWarehouseContainersLeft.Panel1.Controls.Add(this.tablePanelWarehouseContainersLeft);
            this.splitContainerWarehouseContainersLeft.Panel1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            // 
            // splitContainerWarehouseContainersLeft.Panel2
            // 
            this.splitContainerWarehouseContainersLeft.Panel2.Controls.Add(this.listBoxWarehouseContainers);
            this.splitContainerWarehouseContainersLeft.Panel2.Controls.Add(this.panelWarehouseContainersLeftHeader);
            this.splitContainerWarehouseContainersLeft.Panel2.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.splitContainerWarehouseContainersLeft.Size = new System.Drawing.Size(172, 306);
            this.splitContainerWarehouseContainersLeft.SplitterDistance = 147;
            this.splitContainerWarehouseContainersLeft.SplitterWidth = 3;
            this.splitContainerWarehouseContainersLeft.TabIndex = 0;
            // 
            // tablePanelWarehouseContainersLeft
            // 
            this.tablePanelWarehouseContainersLeft.BackColor = System.Drawing.SystemColors.Control;
            this.tablePanelWarehouseContainersLeft.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tablePanelWarehouseContainersLeft.ColumnCount = 2;
            this.tablePanelWarehouseContainersLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tablePanelWarehouseContainersLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanelWarehouseContainersLeft.Controls.Add(this.label8, 0, 2);
            this.tablePanelWarehouseContainersLeft.Controls.Add(this.selectBoxWarehouseRoom, 0, 3);
            this.tablePanelWarehouseContainersLeft.Controls.Add(this.label9, 0, 4);
            this.tablePanelWarehouseContainersLeft.Controls.Add(this.selectBoxWarehouseRow, 0, 5);
            this.tablePanelWarehouseContainersLeft.Controls.Add(this.label1, 0, 0);
            this.tablePanelWarehouseContainersLeft.Controls.Add(this.textBoxWarehouse, 0, 1);
            this.tablePanelWarehouseContainersLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelWarehouseContainersLeft.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tablePanelWarehouseContainersLeft.Location = new System.Drawing.Point(2, 1);
            this.tablePanelWarehouseContainersLeft.Name = "tablePanelWarehouseContainersLeft";
            this.tablePanelWarehouseContainersLeft.RowCount = 7;
            this.tablePanelWarehouseContainersLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelWarehouseContainersLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelWarehouseContainersLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelWarehouseContainersLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelWarehouseContainersLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelWarehouseContainersLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelWarehouseContainersLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelWarehouseContainersLeft.Size = new System.Drawing.Size(166, 143);
            this.tablePanelWarehouseContainersLeft.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 14);
            this.label8.TabIndex = 5;
            this.label8.Text = "Camera de depozitare";
            // 
            // selectBoxWarehouseRoom
            // 
            this.selectBoxWarehouseRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectBoxWarehouseRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBoxWarehouseRoom.FormattingEnabled = true;
            this.selectBoxWarehouseRoom.Location = new System.Drawing.Point(4, 63);
            this.selectBoxWarehouseRoom.Name = "selectBoxWarehouseRoom";
            this.selectBoxWarehouseRoom.Size = new System.Drawing.Size(150, 22);
            this.selectBoxWarehouseRoom.TabIndex = 31;
            this.selectBoxWarehouseRoom.SelectedIndexChanged += new System.EventHandler(this.selectBoxWarehouseRoom_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 14);
            this.label9.TabIndex = 32;
            this.label9.Text = "Rand";
            // 
            // selectBoxWarehouseRow
            // 
            this.selectBoxWarehouseRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectBoxWarehouseRow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBoxWarehouseRow.FormattingEnabled = true;
            this.selectBoxWarehouseRow.Location = new System.Drawing.Point(4, 107);
            this.selectBoxWarehouseRow.Name = "selectBoxWarehouseRow";
            this.selectBoxWarehouseRow.Size = new System.Drawing.Size(150, 22);
            this.selectBoxWarehouseRow.TabIndex = 33;
            this.selectBoxWarehouseRow.SelectedIndexChanged += new System.EventHandler(this.selectBoxWarehouseRow_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 34;
            this.label1.Text = "Depozit";
            // 
            // textBoxWarehouse
            // 
            this.textBoxWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWarehouse.Location = new System.Drawing.Point(4, 19);
            this.textBoxWarehouse.Name = "textBoxWarehouse";
            this.textBoxWarehouse.ReadOnly = true;
            this.textBoxWarehouse.Size = new System.Drawing.Size(150, 22);
            this.textBoxWarehouse.TabIndex = 36;
            // 
            // listBoxWarehouseContainers
            // 
            this.listBoxWarehouseContainers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxWarehouseContainers.FormattingEnabled = true;
            this.listBoxWarehouseContainers.ItemHeight = 14;
            this.listBoxWarehouseContainers.Location = new System.Drawing.Point(2, 23);
            this.listBoxWarehouseContainers.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxWarehouseContainers.Name = "listBoxWarehouseContainers";
            this.listBoxWarehouseContainers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxWarehouseContainers.Size = new System.Drawing.Size(166, 130);
            this.listBoxWarehouseContainers.TabIndex = 1;
            // 
            // panelWarehouseContainersLeftHeader
            // 
            this.panelWarehouseContainersLeftHeader.BackColor = System.Drawing.SystemColors.Control;
            this.panelWarehouseContainersLeftHeader.Controls.Add(this.label5);
            this.panelWarehouseContainersLeftHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWarehouseContainersLeftHeader.Location = new System.Drawing.Point(2, 1);
            this.panelWarehouseContainersLeftHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelWarehouseContainersLeftHeader.Name = "panelWarehouseContainersLeftHeader";
            this.panelWarehouseContainersLeftHeader.Size = new System.Drawing.Size(166, 22);
            this.panelWarehouseContainersLeftHeader.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lista containere";
            // 
            // pictureBoxWarehouseContainers
            // 
            this.pictureBoxWarehouseContainers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxWarehouseContainers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxWarehouseContainers.Location = new System.Drawing.Point(2, 35);
            this.pictureBoxWarehouseContainers.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxWarehouseContainers.Name = "pictureBoxWarehouseContainers";
            this.pictureBoxWarehouseContainers.Size = new System.Drawing.Size(416, 270);
            this.pictureBoxWarehouseContainers.TabIndex = 2;
            this.pictureBoxWarehouseContainers.TabStop = false;
            this.pictureBoxWarehouseContainers.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxWarehouseContainers_Paint);
            this.pictureBoxWarehouseContainers.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxWarehouseContainers_MouseUp);
            // 
            // panelWarehouseContainersMainHeader
            // 
            this.panelWarehouseContainersMainHeader.BackColor = System.Drawing.SystemColors.Control;
            this.panelWarehouseContainersMainHeader.Controls.Add(this.buttonWarehouseContainersReset);
            this.panelWarehouseContainersMainHeader.Controls.Add(this.labelDescription);
            this.panelWarehouseContainersMainHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWarehouseContainersMainHeader.Location = new System.Drawing.Point(2, 1);
            this.panelWarehouseContainersMainHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelWarehouseContainersMainHeader.Name = "panelWarehouseContainersMainHeader";
            this.panelWarehouseContainersMainHeader.Size = new System.Drawing.Size(416, 34);
            this.panelWarehouseContainersMainHeader.TabIndex = 1;
            // 
            // buttonWarehouseContainersReset
            // 
            this.buttonWarehouseContainersReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWarehouseContainersReset.Location = new System.Drawing.Point(339, 3);
            this.buttonWarehouseContainersReset.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWarehouseContainersReset.Name = "buttonWarehouseContainersReset";
            this.buttonWarehouseContainersReset.Size = new System.Drawing.Size(75, 25);
            this.buttonWarehouseContainersReset.TabIndex = 1;
            this.buttonWarehouseContainersReset.Text = "Reset";
            this.buttonWarehouseContainersReset.UseVisualStyleBackColor = true;
            this.buttonWarehouseContainersReset.Click += new System.EventHandler(this.buttonWarehouseContainersReset_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(2, 10);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(120, 14);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = "Selectare containere";
            // 
            // WarehouseContainerFormSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 346);
            this.Controls.Add(this.splitContainerWarehouseContainersMain);
            this.Controls.Add(this.panelFooter);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "WarehouseContainerFormSelect";
            this.ShowInTaskbar = false;
            this.Text = "FormSelect";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FormSelect_Shown);
            this.panelFooter.ResumeLayout(false);
            this.splitContainerWarehouseContainersMain.Panel1.ResumeLayout(false);
            this.splitContainerWarehouseContainersMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerWarehouseContainersMain)).EndInit();
            this.splitContainerWarehouseContainersMain.ResumeLayout(false);
            this.splitContainerWarehouseContainersLeft.Panel1.ResumeLayout(false);
            this.splitContainerWarehouseContainersLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerWarehouseContainersLeft)).EndInit();
            this.splitContainerWarehouseContainersLeft.ResumeLayout(false);
            this.tablePanelWarehouseContainersLeft.ResumeLayout(false);
            this.tablePanelWarehouseContainersLeft.PerformLayout();
            this.panelWarehouseContainersLeftHeader.ResumeLayout(false);
            this.panelWarehouseContainersLeftHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarehouseContainers)).EndInit();
            this.panelWarehouseContainersMainHeader.ResumeLayout(false);
            this.panelWarehouseContainersMainHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panelFooter;
        protected System.Windows.Forms.Button buttonOK;
        protected System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.SplitContainer splitContainerWarehouseContainersMain;
        private System.Windows.Forms.SplitContainer splitContainerWarehouseContainersLeft;
        private CustomControls.EntityTablePanel tablePanelWarehouseContainersLeft;
        private System.Windows.Forms.Label label8;
        private CustomControls.EntitySelectBox selectBoxWarehouseRoom;
        private System.Windows.Forms.Label label9;
        private CustomControls.EntitySelectBox selectBoxWarehouseRow;
        private CustomControls.EntityListBox listBoxWarehouseContainers;
        private System.Windows.Forms.Panel panelWarehouseContainersLeftHeader;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxWarehouseContainers;
        private System.Windows.Forms.Panel panelWarehouseContainersMainHeader;
        private System.Windows.Forms.Button buttonWarehouseContainersReset;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWarehouse;

    }
}