namespace Sirius.EntityModels.WarehouseRows
{
    partial class WarehouseRowOverview
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseRowOverview));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.tablePanelHeader = new Sirius.CustomControls.TablePanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.selectBoxWarehouse = new Sirius.CustomControls.EntitySelectBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectBoxWarehouseRow = new Sirius.CustomControls.EntitySelectBox();
            this.selectBoxWarehouseRoom = new Sirius.CustomControls.EntitySelectBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            this.tablePanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.Control;
            this.panelHeader.Controls.Add(this.tablePanelHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(5, 4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(919, 50);
            this.panelHeader.TabIndex = 1;
            // 
            // tablePanelHeader
            // 
            this.tablePanelHeader.ColumnCount = 5;
            this.tablePanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tablePanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tablePanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tablePanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tablePanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanelHeader.Controls.Add(this.label2, 1, 0);
            this.tablePanelHeader.Controls.Add(this.label1, 0, 0);
            this.tablePanelHeader.Controls.Add(this.selectBoxWarehouse, 0, 1);
            this.tablePanelHeader.Controls.Add(this.label3, 2, 0);
            this.tablePanelHeader.Controls.Add(this.selectBoxWarehouseRow, 2, 1);
            this.tablePanelHeader.Controls.Add(this.selectBoxWarehouseRoom, 1, 1);
            this.tablePanelHeader.Controls.Add(this.buttonRefresh, 3, 1);
            this.tablePanelHeader.Controls.Add(this.buttonPrint, 4, 1);
            this.tablePanelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelHeader.Location = new System.Drawing.Point(0, 0);
            this.tablePanelHeader.Name = "tablePanelHeader";
            this.tablePanelHeader.RowCount = 2;
            this.tablePanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelHeader.Size = new System.Drawing.Size(919, 50);
            this.tablePanelHeader.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Camera";
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
            // selectBoxWarehouse
            // 
            this.selectBoxWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectBoxWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBoxWarehouse.FormattingEnabled = true;
            this.selectBoxWarehouse.Location = new System.Drawing.Point(3, 21);
            this.selectBoxWarehouse.Name = "selectBoxWarehouse";
            this.selectBoxWarehouse.Size = new System.Drawing.Size(124, 22);
            this.selectBoxWarehouse.TabIndex = 1;
            this.selectBoxWarehouse.SelectedIndexChanged += new System.EventHandler(this.selectBoxWarehouse_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rand";
            // 
            // selectBoxWarehouseRow
            // 
            this.selectBoxWarehouseRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectBoxWarehouseRow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBoxWarehouseRow.FormattingEnabled = true;
            this.selectBoxWarehouseRow.Location = new System.Drawing.Point(283, 21);
            this.selectBoxWarehouseRow.Name = "selectBoxWarehouseRow";
            this.selectBoxWarehouseRow.Size = new System.Drawing.Size(164, 22);
            this.selectBoxWarehouseRow.TabIndex = 5;
            this.selectBoxWarehouseRow.SelectedIndexChanged += new System.EventHandler(this.selectBoxWarehouseRow_SelectedIndexChanged);
            // 
            // selectBoxWarehouseRoom
            // 
            this.selectBoxWarehouseRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectBoxWarehouseRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBoxWarehouseRoom.FormattingEnabled = true;
            this.selectBoxWarehouseRoom.Location = new System.Drawing.Point(133, 21);
            this.selectBoxWarehouseRoom.Name = "selectBoxWarehouseRoom";
            this.selectBoxWarehouseRoom.Size = new System.Drawing.Size(144, 22);
            this.selectBoxWarehouseRoom.TabIndex = 3;
            this.selectBoxWarehouseRoom.SelectedIndexChanged += new System.EventHandler(this.selectBoxWarehouseRoom_SelectedIndexChanged);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.Image")));
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefresh.Location = new System.Drawing.Point(453, 19);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(124, 25);
            this.buttonRefresh.TabIndex = 6;
            this.buttonRefresh.Text = "Reimprospatare";
            this.buttonRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonPrint.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrint.Image")));
            this.buttonPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPrint.Location = new System.Drawing.Point(583, 19);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(85, 25);
            this.buttonPrint.TabIndex = 7;
            this.buttonPrint.Text = "Imprimare";
            this.buttonPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.Color.White;
            this.pictureBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMain.Location = new System.Drawing.Point(5, 54);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(919, 410);
            this.pictureBoxMain.TabIndex = 2;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxMain_Paint);
            // 
            // WarehouseRowOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "WarehouseRowOverview";
            this.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Size = new System.Drawing.Size(929, 468);
            this.Load += new System.EventHandler(this.WarehouseRowOverview_Load);
            this.panelHeader.ResumeLayout(false);
            this.tablePanelHeader.ResumeLayout(false);
            this.tablePanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private CustomControls.TablePanel tablePanelHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.EntitySelectBox selectBoxWarehouse;
        private CustomControls.EntitySelectBox selectBoxWarehouseRoom;
        private System.Windows.Forms.Label label3;
        private CustomControls.EntitySelectBox selectBoxWarehouseRow;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        protected System.Windows.Forms.Button buttonRefresh;
        protected System.Windows.Forms.Button buttonPrint;
    }
}
