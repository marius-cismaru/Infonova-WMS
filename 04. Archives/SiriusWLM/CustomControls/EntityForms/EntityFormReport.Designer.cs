namespace Sirius.CustomControls
{
    partial class EntityFormReport
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
            this.buttonFilter = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.panelMasterHeader = new System.Windows.Forms.Panel();
            this.buttonPrintPreview = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonPageConfiguration = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.buttonSendEmailClient = new System.Windows.Forms.Button();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFilter)).BeginInit();
            this.splitContainerFilter.Panel1.SuspendLayout();
            this.splitContainerFilter.Panel2.SuspendLayout();
            this.splitContainerFilter.SuspendLayout();
            this.panelFilterHeader.SuspendLayout();
            this.panelMasterHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.buttonOK);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 359);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(805, 38);
            this.panelBottom.TabIndex = 0;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Image = global::Sirius.CustomControls.Properties.Resources.icon_16_accept;
            this.buttonOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOK.Location = new System.Drawing.Point(711, 6);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(87, 25);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.splitContainerFilter.Panel2.Controls.Add(this.webBrowser);
            this.splitContainerFilter.Panel2.Controls.Add(this.panelMasterHeader);
            this.splitContainerFilter.Size = new System.Drawing.Size(805, 359);
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
            this.panelFilter.Size = new System.Drawing.Size(107, 325);
            this.panelFilter.TabIndex = 1;
            // 
            // panelFilterHeader
            // 
            this.panelFilterHeader.Controls.Add(this.buttonFilter);
            this.panelFilterHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilterHeader.Location = new System.Drawing.Point(0, 0);
            this.panelFilterHeader.Name = "panelFilterHeader";
            this.panelFilterHeader.Size = new System.Drawing.Size(107, 32);
            this.panelFilterHeader.TabIndex = 0;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Image = global::Sirius.CustomControls.Properties.Resources.icon_16_funnel;
            this.buttonFilter.Location = new System.Drawing.Point(3, 3);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(67, 25);
            this.buttonFilter.TabIndex = 1;
            this.buttonFilter.Text = "Filtrare";
            this.buttonFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 32);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(690, 325);
            this.webBrowser.TabIndex = 9;
            // 
            // panelMasterHeader
            // 
            this.panelMasterHeader.Controls.Add(this.buttonSendEmailClient);
            this.panelMasterHeader.Controls.Add(this.buttonPrintPreview);
            this.panelMasterHeader.Controls.Add(this.buttonRefresh);
            this.panelMasterHeader.Controls.Add(this.buttonExport);
            this.panelMasterHeader.Controls.Add(this.buttonPageConfiguration);
            this.panelMasterHeader.Controls.Add(this.buttonPrint);
            this.panelMasterHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMasterHeader.Location = new System.Drawing.Point(0, 0);
            this.panelMasterHeader.Name = "panelMasterHeader";
            this.panelMasterHeader.Size = new System.Drawing.Size(690, 32);
            this.panelMasterHeader.TabIndex = 8;
            // 
            // buttonPrintPreview
            // 
            this.buttonPrintPreview.Image = global::Sirius.CustomControls.Properties.Resources.icon_16_zoom;
            this.buttonPrintPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPrintPreview.Location = new System.Drawing.Point(125, 3);
            this.buttonPrintPreview.Name = "buttonPrintPreview";
            this.buttonPrintPreview.Size = new System.Drawing.Size(102, 25);
            this.buttonPrintPreview.TabIndex = 5;
            this.buttonPrintPreview.Text = "Previzualizare";
            this.buttonPrintPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPrintPreview.UseVisualStyleBackColor = true;
            this.buttonPrintPreview.Click += new System.EventHandler(this.buttonPrintPreview_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Image = global::Sirius.CustomControls.Properties.Resources.icon_16_arrow_refresh;
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefresh.Location = new System.Drawing.Point(3, 3);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(115, 25);
            this.buttonRefresh.TabIndex = 4;
            this.buttonRefresh.Text = "Reimprospatare";
            this.buttonRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipMain.SetToolTip(this.buttonRefresh, "Reimprospatare date");
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // buttonExport
            // 
            this.buttonExport.Image = global::Sirius.CustomControls.Properties.Resources.icon_16_win_go_right;
            this.buttonExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExport.Location = new System.Drawing.Point(425, 3);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(69, 25);
            this.buttonExport.TabIndex = 2;
            this.buttonExport.Text = "Export";
            this.buttonExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExport.UseVisualStyleBackColor = true;
            // 
            // buttonPageConfiguration
            // 
            this.buttonPageConfiguration.Image = global::Sirius.CustomControls.Properties.Resources.icon_16_cog;
            this.buttonPageConfiguration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPageConfiguration.Location = new System.Drawing.Point(233, 3);
            this.buttonPageConfiguration.Name = "buttonPageConfiguration";
            this.buttonPageConfiguration.Size = new System.Drawing.Size(95, 25);
            this.buttonPageConfiguration.TabIndex = 1;
            this.buttonPageConfiguration.Text = "Configurare";
            this.buttonPageConfiguration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPageConfiguration.UseVisualStyleBackColor = true;
            this.buttonPageConfiguration.Click += new System.EventHandler(this.buttonPageConfiguration_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Image = global::Sirius.CustomControls.Properties.Resources.icon_16_printer;
            this.buttonPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPrint.Location = new System.Drawing.Point(334, 3);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(85, 25);
            this.buttonPrint.TabIndex = 0;
            this.buttonPrint.Text = "Imprimare";
            this.buttonPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // toolTipMain
            // 
            this.toolTipMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipMain.ToolTipTitle = "Descriere";
            // 
            // buttonSendEmailClient
            // 
            this.buttonSendEmailClient.Image = global::Sirius.CustomControls.Properties.Resources.icon_16_win_envelope_open_large;
            this.buttonSendEmailClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSendEmailClient.Location = new System.Drawing.Point(500, 3);
            this.buttonSendEmailClient.Name = "buttonSendEmailClient";
            this.buttonSendEmailClient.Size = new System.Drawing.Size(144, 25);
            this.buttonSendEmailClient.TabIndex = 6;
            this.buttonSendEmailClient.Text = "Trimitere email client";
            this.buttonSendEmailClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSendEmailClient.UseVisualStyleBackColor = true;
            this.buttonSendEmailClient.Click += new System.EventHandler(this.buttonSendEmailClient_Click);
            // 
            // EntityFormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 397);
            this.Controls.Add(this.splitContainerFilter);
            this.Controls.Add(this.panelBottom);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "EntityFormReport";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EntityFormBrowse";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FormReport_Shown);
            this.panelBottom.ResumeLayout(false);
            this.splitContainerFilter.Panel1.ResumeLayout(false);
            this.splitContainerFilter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFilter)).EndInit();
            this.splitContainerFilter.ResumeLayout(false);
            this.panelFilterHeader.ResumeLayout(false);
            this.panelMasterHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panelBottom;
        protected System.Windows.Forms.Button buttonOK;
        protected System.Windows.Forms.SplitContainer splitContainerFilter;
        protected System.Windows.Forms.Panel panelFilterHeader;
        protected System.Windows.Forms.Button buttonFilter;
        protected System.Windows.Forms.Panel panelFilter;
        public System.Windows.Forms.ToolTip toolTipMain;
        protected System.Windows.Forms.Panel panelMasterHeader;
        protected System.Windows.Forms.Button buttonRefresh;
        protected System.Windows.Forms.Button buttonExport;
        protected System.Windows.Forms.Button buttonPageConfiguration;
        protected System.Windows.Forms.Button buttonPrint;
        public System.Windows.Forms.WebBrowser webBrowser;
        protected System.Windows.Forms.Button buttonPrintPreview;
        protected System.Windows.Forms.Button buttonSendEmailClient;
    }
}