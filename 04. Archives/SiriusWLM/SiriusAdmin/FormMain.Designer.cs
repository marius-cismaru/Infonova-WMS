namespace Sirius.SiriusAdmin
{
    partial class FormMain
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
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.panelMenuHeader = new System.Windows.Forms.Panel();
            this.richTextBoxMain = new System.Windows.Forms.RichTextBox();
            this.panelMainHeader = new System.Windows.Forms.Panel();
            this.treeViewMenu = new Sirius.CustomControls.TreeViewMenu();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripMain
            // 
            this.statusStripMain.Location = new System.Drawing.Point(5, 338);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(523, 22);
            this.statusStripMain.TabIndex = 1;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.Location = new System.Drawing.Point(5, 4);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.treeViewMenu);
            this.splitContainerMain.Panel1.Controls.Add(this.panelMenuHeader);
            this.splitContainerMain.Panel1.Padding = new System.Windows.Forms.Padding(4);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.richTextBoxMain);
            this.splitContainerMain.Panel2.Controls.Add(this.panelMainHeader);
            this.splitContainerMain.Panel2.Padding = new System.Windows.Forms.Padding(4);
            this.splitContainerMain.Size = new System.Drawing.Size(523, 334);
            this.splitContainerMain.SplitterDistance = 202;
            this.splitContainerMain.TabIndex = 2;
            // 
            // panelMenuHeader
            // 
            this.panelMenuHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuHeader.Location = new System.Drawing.Point(4, 4);
            this.panelMenuHeader.Name = "panelMenuHeader";
            this.panelMenuHeader.Size = new System.Drawing.Size(190, 38);
            this.panelMenuHeader.TabIndex = 2;
            // 
            // richTextBoxMain
            // 
            this.richTextBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxMain.Location = new System.Drawing.Point(4, 42);
            this.richTextBoxMain.Name = "richTextBoxMain";
            this.richTextBoxMain.Size = new System.Drawing.Size(305, 284);
            this.richTextBoxMain.TabIndex = 0;
            this.richTextBoxMain.Text = "";
            // 
            // panelMainHeader
            // 
            this.panelMainHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainHeader.Location = new System.Drawing.Point(4, 4);
            this.panelMainHeader.Name = "panelMainHeader";
            this.panelMainHeader.Size = new System.Drawing.Size(305, 38);
            this.panelMainHeader.TabIndex = 1;
            // 
            // treeViewMenu
            // 
            this.treeViewMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewMenu.ImageIndex = 0;
            this.treeViewMenu.ItemHeight = 25;
            this.treeViewMenu.Location = new System.Drawing.Point(4, 42);
            this.treeViewMenu.Name = "treeViewMenu";
            this.treeViewMenu.SelectedImageIndex = 0;
            this.treeViewMenu.Size = new System.Drawing.Size(190, 284);
            this.treeViewMenu.TabIndex = 3;
            this.treeViewMenu.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewMenu_NodeMouseClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 364);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.statusStripMain);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel panelMenuHeader;
        private System.Windows.Forms.RichTextBox richTextBoxMain;
        private System.Windows.Forms.Panel panelMainHeader;
        private CustomControls.TreeViewMenu treeViewMenu;


    }
}

