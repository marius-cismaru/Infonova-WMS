namespace Sirius.CustomControls
{
    partial class EntityFormBrowse
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
            this.components = new System.ComponentModel.Container();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.splitContainerFilter = new System.Windows.Forms.SplitContainer();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.panelFilterHeader = new System.Windows.Forms.Panel();
            this.buttonMasterFilter = new System.Windows.Forms.Button();
            this.splitContainerMasterDetail = new System.Windows.Forms.SplitContainer();
            this.gridViewMaster = new Sirius.CustomControls.EntityGridView();
            this.panelMasterFooter = new System.Windows.Forms.Panel();
            this.labelMasterFooter = new System.Windows.Forms.Label();
            this.panelMasterHeader = new System.Windows.Forms.Panel();
            this.buttonMasterReports = new Sirius.CustomControls.SplitButton();
            this.contextMenuStripMasterReports = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonMasterExport = new System.Windows.Forms.Button();
            this.buttonMasterRefresh = new System.Windows.Forms.Button();
            this.buttonMasterDelete = new System.Windows.Forms.Button();
            this.buttonMasterEdit = new System.Windows.Forms.Button();
            this.buttonMasterView = new System.Windows.Forms.Button();
            this.buttonMasterAdd = new System.Windows.Forms.Button();
            this.gridViewDetail = new Sirius.CustomControls.EntityGridView();
            this.panelDetailFooter = new System.Windows.Forms.Panel();
            this.labelDetailFooter = new System.Windows.Forms.Label();
            this.panelDetailHeader = new System.Windows.Forms.Panel();
            this.buttonDetailDelete = new System.Windows.Forms.Button();
            this.buttonDetailEdit = new System.Windows.Forms.Button();
            this.buttonDetailView = new System.Windows.Forms.Button();
            this.buttonDetailAdd = new System.Windows.Forms.Button();
            this.panelDetailDescription = new System.Windows.Forms.Panel();
            this.labelDetailDescription = new System.Windows.Forms.Label();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMaster)).BeginInit();
            this.panelMasterFooter.SuspendLayout();
            this.panelMasterHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).BeginInit();
            this.panelDetailFooter.SuspendLayout();
            this.panelDetailHeader.SuspendLayout();
            this.panelDetailDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.buttonOK);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 408);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(709, 38);
            this.panelBottom.TabIndex = 0;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Image = global::Sirius.CustomControls.Properties.Resources.icon_16_accept;
            this.buttonOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOK.Location = new System.Drawing.Point(615, 6);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(87, 25);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // splitContainerFilter
            // 
            this.splitContainerFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerFilter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerFilter.Location = new System.Drawing.Point(0, 0);
            this.splitContainerFilter.Name = "splitContainerFilter";
            // 
            // splitContainerFilter.Panel1
            // 
            this.splitContainerFilter.Panel1.Controls.Add(this.panelFilter);
            this.splitContainerFilter.Panel1.Controls.Add(this.panelFilterHeader);
            // 
            // splitContainerFilter.Panel2
            // 
            this.splitContainerFilter.Panel2.Controls.Add(this.splitContainerMasterDetail);
            this.splitContainerFilter.Size = new System.Drawing.Size(709, 408);
            this.splitContainerFilter.SplitterDistance = 109;
            this.splitContainerFilter.TabIndex = 1;
            // 
            // panelFilter
            // 
            this.panelFilter.AutoScroll = true;
            this.panelFilter.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFilter.Location = new System.Drawing.Point(0, 32);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(107, 374);
            this.panelFilter.TabIndex = 1;
            // 
            // panelFilterHeader
            // 
            this.panelFilterHeader.Controls.Add(this.buttonMasterFilter);
            this.panelFilterHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilterHeader.Location = new System.Drawing.Point(0, 0);
            this.panelFilterHeader.Name = "panelFilterHeader";
            this.panelFilterHeader.Size = new System.Drawing.Size(107, 32);
            this.panelFilterHeader.TabIndex = 0;
            // 
            // buttonMasterFilter
            // 
            this.buttonMasterFilter.Image = global::Sirius.CustomControls.Properties.Resources.icon_16_funnel;
            this.buttonMasterFilter.Location = new System.Drawing.Point(3, 3);
            this.buttonMasterFilter.Name = "buttonMasterFilter";
            this.buttonMasterFilter.Size = new System.Drawing.Size(67, 25);
            this.buttonMasterFilter.TabIndex = 1;
            this.buttonMasterFilter.Text = "Filtrare";
            this.buttonMasterFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMasterFilter.UseVisualStyleBackColor = true;
            this.buttonMasterFilter.Click += new System.EventHandler(this.buttonMasterFilter_Click);
            // 
            // splitContainerMasterDetail
            // 
            this.splitContainerMasterDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerMasterDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMasterDetail.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMasterDetail.Name = "splitContainerMasterDetail";
            this.splitContainerMasterDetail.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMasterDetail.Panel1
            // 
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.gridViewMaster);
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.panelMasterFooter);
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.panelMasterHeader);
            // 
            // splitContainerMasterDetail.Panel2
            // 
            this.splitContainerMasterDetail.Panel2.Controls.Add(this.gridViewDetail);
            this.splitContainerMasterDetail.Panel2.Controls.Add(this.panelDetailFooter);
            this.splitContainerMasterDetail.Panel2.Controls.Add(this.panelDetailHeader);
            this.splitContainerMasterDetail.Panel2.Controls.Add(this.panelDetailDescription);
            this.splitContainerMasterDetail.Size = new System.Drawing.Size(596, 408);
            this.splitContainerMasterDetail.SplitterDistance = 214;
            this.splitContainerMasterDetail.TabIndex = 0;
            // 
            // gridViewMaster
            // 
            this.gridViewMaster.AllowUserToAddRows = false;
            this.gridViewMaster.AllowUserToDeleteRows = false;
            this.gridViewMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridViewMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewMaster.EmptyDataText = "Nu exista inregistrari";
            this.gridViewMaster.Location = new System.Drawing.Point(0, 32);
            this.gridViewMaster.MultiSelect = false;
            this.gridViewMaster.Name = "gridViewMaster";
            this.gridViewMaster.ReadOnly = true;
            this.gridViewMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewMaster.Size = new System.Drawing.Size(594, 156);
            this.gridViewMaster.TabIndex = 7;
            this.gridViewMaster.SelectionChanged += new System.EventHandler(this.gridViewMaster_SelectionChanged);
            // 
            // panelMasterFooter
            // 
            this.panelMasterFooter.Controls.Add(this.labelMasterFooter);
            this.panelMasterFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMasterFooter.Location = new System.Drawing.Point(0, 188);
            this.panelMasterFooter.Name = "panelMasterFooter";
            this.panelMasterFooter.Size = new System.Drawing.Size(594, 24);
            this.panelMasterFooter.TabIndex = 6;
            // 
            // labelMasterFooter
            // 
            this.labelMasterFooter.AutoSize = true;
            this.labelMasterFooter.Location = new System.Drawing.Point(4, 5);
            this.labelMasterFooter.Name = "labelMasterFooter";
            this.labelMasterFooter.Size = new System.Drawing.Size(0, 14);
            this.labelMasterFooter.TabIndex = 0;
            // 
            // panelMasterHeader
            // 
            this.panelMasterHeader.Controls.Add(this.buttonMasterReports);
            this.panelMasterHeader.Controls.Add(this.buttonMasterExport);
            this.panelMasterHeader.Controls.Add(this.buttonMasterRefresh);
            this.panelMasterHeader.Controls.Add(this.buttonMasterDelete);
            this.panelMasterHeader.Controls.Add(this.buttonMasterEdit);
            this.panelMasterHeader.Controls.Add(this.buttonMasterView);
            this.panelMasterHeader.Controls.Add(this.buttonMasterAdd);
            this.panelMasterHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMasterHeader.Location = new System.Drawing.Point(0, 0);
            this.panelMasterHeader.Name = "panelMasterHeader";
            this.panelMasterHeader.Size = new System.Drawing.Size(594, 32);
            this.panelMasterHeader.TabIndex = 5;
            // 
            // buttonMasterReports
            // 
            this.buttonMasterReports.AutoSize = true;
            this.buttonMasterReports.ContextMenuStrip = this.contextMenuStripMasterReports;
            this.buttonMasterReports.Image = global::Sirius.CustomControls.Properties.Resources.icon_16_win_organizer;
            this.buttonMasterReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMasterReports.Location = new System.Drawing.Point(373, 3);
            this.buttonMasterReports.Name = "buttonMasterReports";
            this.buttonMasterReports.Size = new System.Drawing.Size(115, 25);
            this.buttonMasterReports.SplitMenuStrip = this.contextMenuStripMasterReports;
            this.buttonMasterReports.TabIndex = 6;
            this.buttonMasterReports.Text = "Documente";
            this.buttonMasterReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMasterReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipMain.SetToolTip(this.buttonMasterReports, "Listare documente");
            this.buttonMasterReports.UseVisualStyleBackColor = true;
            // 
            // contextMenuStripMasterReports
            // 
            this.contextMenuStripMasterReports.Name = "contextMenuStrip1";
            this.contextMenuStripMasterReports.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStripMasterReports.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripMasterReports_ItemClicked);
            // 
            // buttonMasterExport
            // 
            this.buttonMasterExport.Image = global::Sirius.CustomControls.Properties.Resources.icon_16_table_go;
            this.buttonMasterExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMasterExport.Location = new System.Drawing.Point(494, 3);
            this.buttonMasterExport.Name = "buttonMasterExport";
            this.buttonMasterExport.Size = new System.Drawing.Size(68, 25);
            this.buttonMasterExport.TabIndex = 5;
            this.buttonMasterExport.Text = "Export";
            this.buttonMasterExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMasterExport.UseVisualStyleBackColor = true;
            // 
            // buttonMasterRefresh
            // 
            this.buttonMasterRefresh.Image = global::Sirius.CustomControls.Properties.Resources.icon_16_arrow_refresh;
            this.buttonMasterRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMasterRefresh.Location = new System.Drawing.Point(3, 3);
            this.buttonMasterRefresh.Name = "buttonMasterRefresh";
            this.buttonMasterRefresh.Size = new System.Drawing.Size(25, 25);
            this.buttonMasterRefresh.TabIndex = 4;
            this.buttonMasterRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipMain.SetToolTip(this.buttonMasterRefresh, "Reimprospatare date");
            this.buttonMasterRefresh.UseVisualStyleBackColor = true;
            this.buttonMasterRefresh.Click += new System.EventHandler(this.buttonMasterRefresh_Click);
            // 
            // buttonMasterDelete
            // 
            this.buttonMasterDelete.Image = global::Sirius.CustomControls.Properties.Resources.icon_16_delete;
            this.buttonMasterDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMasterDelete.Location = new System.Drawing.Point(288, 3);
            this.buttonMasterDelete.Name = "buttonMasterDelete";
            this.buttonMasterDelete.Size = new System.Drawing.Size(79, 25);
            this.buttonMasterDelete.TabIndex = 3;
            this.buttonMasterDelete.Text = "Stergere";
            this.buttonMasterDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMasterDelete.UseVisualStyleBackColor = true;
            this.buttonMasterDelete.Click += new System.EventHandler(this.buttonMasterDelete_Click);
            // 
            // buttonMasterEdit
            // 
            this.buttonMasterEdit.Image = global::Sirius.CustomControls.Properties.Resources.icon_16_page_edit;
            this.buttonMasterEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMasterEdit.Location = new System.Drawing.Point(213, 3);
            this.buttonMasterEdit.Name = "buttonMasterEdit";
            this.buttonMasterEdit.Size = new System.Drawing.Size(69, 25);
            this.buttonMasterEdit.TabIndex = 2;
            this.buttonMasterEdit.Text = "Editare";
            this.buttonMasterEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMasterEdit.UseVisualStyleBackColor = true;
            this.buttonMasterEdit.Click += new System.EventHandler(this.buttonMasterEdit_Click);
            // 
            // buttonMasterView
            // 
            this.buttonMasterView.Image = global::Sirius.CustomControls.Properties.Resources.icon_16_zoom;
            this.buttonMasterView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMasterView.Location = new System.Drawing.Point(123, 3);
            this.buttonMasterView.Name = "buttonMasterView";
            this.buttonMasterView.Size = new System.Drawing.Size(85, 25);
            this.buttonMasterView.TabIndex = 1;
            this.buttonMasterView.Text = "Vizualizare";
            this.buttonMasterView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMasterView.UseVisualStyleBackColor = true;
            // 
            // buttonMasterAdd
            // 
            this.buttonMasterAdd.Image = global::Sirius.CustomControls.Properties.Resources.icon_16_add;
            this.buttonMasterAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMasterAdd.Location = new System.Drawing.Point(33, 3);
            this.buttonMasterAdd.Name = "buttonMasterAdd";
            this.buttonMasterAdd.Size = new System.Drawing.Size(84, 25);
            this.buttonMasterAdd.TabIndex = 0;
            this.buttonMasterAdd.Text = "Adaugare";
            this.buttonMasterAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMasterAdd.UseVisualStyleBackColor = true;
            this.buttonMasterAdd.Click += new System.EventHandler(this.buttonMasterAdd_Click);
            // 
            // gridViewDetail
            // 
            this.gridViewDetail.AllowUserToAddRows = false;
            this.gridViewDetail.AllowUserToDeleteRows = false;
            this.gridViewDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridViewDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewDetail.EmptyDataText = "Nu exista inregistrari";
            this.gridViewDetail.Location = new System.Drawing.Point(0, 56);
            this.gridViewDetail.MultiSelect = false;
            this.gridViewDetail.Name = "gridViewDetail";
            this.gridViewDetail.ReadOnly = true;
            this.gridViewDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewDetail.Size = new System.Drawing.Size(594, 108);
            this.gridViewDetail.TabIndex = 8;
            this.gridViewDetail.SelectionChanged += new System.EventHandler(this.gridViewDetail_SelectionChanged);
            // 
            // panelDetailFooter
            // 
            this.panelDetailFooter.Controls.Add(this.labelDetailFooter);
            this.panelDetailFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDetailFooter.Location = new System.Drawing.Point(0, 164);
            this.panelDetailFooter.Name = "panelDetailFooter";
            this.panelDetailFooter.Size = new System.Drawing.Size(594, 24);
            this.panelDetailFooter.TabIndex = 7;
            // 
            // labelDetailFooter
            // 
            this.labelDetailFooter.AutoSize = true;
            this.labelDetailFooter.Location = new System.Drawing.Point(4, 5);
            this.labelDetailFooter.Name = "labelDetailFooter";
            this.labelDetailFooter.Size = new System.Drawing.Size(0, 14);
            this.labelDetailFooter.TabIndex = 0;
            // 
            // panelDetailHeader
            // 
            this.panelDetailHeader.Controls.Add(this.buttonDetailDelete);
            this.panelDetailHeader.Controls.Add(this.buttonDetailEdit);
            this.panelDetailHeader.Controls.Add(this.buttonDetailView);
            this.panelDetailHeader.Controls.Add(this.buttonDetailAdd);
            this.panelDetailHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDetailHeader.Location = new System.Drawing.Point(0, 24);
            this.panelDetailHeader.Name = "panelDetailHeader";
            this.panelDetailHeader.Size = new System.Drawing.Size(594, 32);
            this.panelDetailHeader.TabIndex = 6;
            // 
            // buttonDetailDelete
            // 
            this.buttonDetailDelete.Location = new System.Drawing.Point(213, 4);
            this.buttonDetailDelete.Name = "buttonDetailDelete";
            this.buttonDetailDelete.Size = new System.Drawing.Size(63, 25);
            this.buttonDetailDelete.TabIndex = 3;
            this.buttonDetailDelete.Text = "Stergere";
            this.buttonDetailDelete.UseVisualStyleBackColor = true;
            // 
            // buttonDetailEdit
            // 
            this.buttonDetailEdit.Location = new System.Drawing.Point(153, 4);
            this.buttonDetailEdit.Name = "buttonDetailEdit";
            this.buttonDetailEdit.Size = new System.Drawing.Size(54, 25);
            this.buttonDetailEdit.TabIndex = 2;
            this.buttonDetailEdit.Text = "Editare";
            this.buttonDetailEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDetailView
            // 
            this.buttonDetailView.Location = new System.Drawing.Point(77, 4);
            this.buttonDetailView.Name = "buttonDetailView";
            this.buttonDetailView.Size = new System.Drawing.Size(70, 25);
            this.buttonDetailView.TabIndex = 1;
            this.buttonDetailView.Text = "Vizualizare";
            this.buttonDetailView.UseVisualStyleBackColor = true;
            // 
            // buttonDetailAdd
            // 
            this.buttonDetailAdd.Location = new System.Drawing.Point(4, 4);
            this.buttonDetailAdd.Name = "buttonDetailAdd";
            this.buttonDetailAdd.Size = new System.Drawing.Size(67, 25);
            this.buttonDetailAdd.TabIndex = 0;
            this.buttonDetailAdd.Text = "Adaugare";
            this.buttonDetailAdd.UseVisualStyleBackColor = true;
            // 
            // panelDetailDescription
            // 
            this.panelDetailDescription.Controls.Add(this.labelDetailDescription);
            this.panelDetailDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDetailDescription.Location = new System.Drawing.Point(0, 0);
            this.panelDetailDescription.Name = "panelDetailDescription";
            this.panelDetailDescription.Size = new System.Drawing.Size(594, 24);
            this.panelDetailDescription.TabIndex = 9;
            // 
            // labelDetailDescription
            // 
            this.labelDetailDescription.AutoSize = true;
            this.labelDetailDescription.Location = new System.Drawing.Point(4, 5);
            this.labelDetailDescription.Name = "labelDetailDescription";
            this.labelDetailDescription.Size = new System.Drawing.Size(0, 14);
            this.labelDetailDescription.TabIndex = 0;
            // 
            // toolTipMain
            // 
            this.toolTipMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipMain.ToolTipTitle = "Descriere";
            // 
            // EntityFormBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 446);
            this.Controls.Add(this.splitContainerFilter);
            this.Controls.Add(this.panelBottom);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "EntityFormBrowse";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EntityFormBrowse";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FormBrowse_Shown);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMaster)).EndInit();
            this.panelMasterFooter.ResumeLayout(false);
            this.panelMasterFooter.PerformLayout();
            this.panelMasterHeader.ResumeLayout(false);
            this.panelMasterHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).EndInit();
            this.panelDetailFooter.ResumeLayout(false);
            this.panelDetailFooter.PerformLayout();
            this.panelDetailHeader.ResumeLayout(false);
            this.panelDetailDescription.ResumeLayout(false);
            this.panelDetailDescription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panelBottom;
        protected System.Windows.Forms.Button buttonOK;
        protected System.Windows.Forms.SplitContainer splitContainerFilter;
        protected System.Windows.Forms.Panel panelFilterHeader;
        protected System.Windows.Forms.Button buttonMasterFilter;
        protected System.Windows.Forms.SplitContainer splitContainerMasterDetail;
        protected System.Windows.Forms.Panel panelMasterFooter;
        private System.Windows.Forms.Label labelMasterFooter;
        protected System.Windows.Forms.Panel panelMasterHeader;
        protected System.Windows.Forms.Button buttonMasterDelete;
        protected System.Windows.Forms.Button buttonMasterEdit;
        protected System.Windows.Forms.Button buttonMasterView;
        protected System.Windows.Forms.Button buttonMasterAdd;
        protected EntityGridView gridViewDetail;
        protected System.Windows.Forms.Panel panelDetailFooter;
        protected System.Windows.Forms.Panel panelDetailHeader;
        protected System.Windows.Forms.Button buttonDetailDelete;
        protected System.Windows.Forms.Button buttonDetailEdit;
        protected System.Windows.Forms.Button buttonDetailView;
        protected System.Windows.Forms.Button buttonDetailAdd;
        protected System.Windows.Forms.Panel panelFilter;
        protected System.Windows.Forms.Button buttonMasterRefresh;
        public System.Windows.Forms.ToolTip toolTipMain;
        protected System.Windows.Forms.Panel panelDetailDescription;
        protected System.Windows.Forms.Label labelDetailDescription;
        protected System.Windows.Forms.Label labelDetailFooter;
        protected EntityGridView gridViewMaster;
        protected System.Windows.Forms.Button buttonMasterExport;
        protected SplitButton buttonMasterReports;
        protected System.Windows.Forms.ContextMenuStrip contextMenuStripMasterReports;
    }
}