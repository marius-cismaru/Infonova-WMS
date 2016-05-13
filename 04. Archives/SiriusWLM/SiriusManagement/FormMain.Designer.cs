namespace Sirius.SiriusManagement
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
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.treeViewMenu = new Sirius.CustomControls.TreeViewMenu();
            this.panelMenuHeaderOutside = new System.Windows.Forms.Panel();
            this.panelMenuHeaderInside = new System.Windows.Forms.Panel();
            this.labelMenuHeader = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageWarehouseRowsOverview = new System.Windows.Forms.TabPage();
            this.warehouseRowOverview = new Sirius.EntityModels.WarehouseRows.WarehouseRowOverview();
            this.panelMainHeaderOutside = new System.Windows.Forms.Panel();
            this.panelMainHeaderInside = new System.Windows.Forms.Panel();
            this.labelMainHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.panelMenuHeaderOutside.SuspendLayout();
            this.panelMenuHeaderInside.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageWarehouseRowsOverview.SuspendLayout();
            this.panelMainHeaderOutside.SuspendLayout();
            this.panelMainHeaderInside.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.Location = new System.Drawing.Point(4, 4);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.treeViewMenu);
            this.splitContainerMain.Panel1.Controls.Add(this.panelMenuHeaderOutside);
            this.splitContainerMain.Panel1.Padding = new System.Windows.Forms.Padding(4);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.tabControlMain);
            this.splitContainerMain.Panel2.Controls.Add(this.panelMainHeaderOutside);
            this.splitContainerMain.Panel2.Padding = new System.Windows.Forms.Padding(4);
            this.splitContainerMain.Size = new System.Drawing.Size(721, 461);
            this.splitContainerMain.SplitterDistance = 214;
            this.splitContainerMain.TabIndex = 1;
            // 
            // treeViewMenu
            // 
            this.treeViewMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewMenu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.treeViewMenu.ImageIndex = 0;
            this.treeViewMenu.ItemHeight = 25;
            this.treeViewMenu.Location = new System.Drawing.Point(4, 31);
            this.treeViewMenu.Name = "treeViewMenu";
            this.treeViewMenu.SelectedImageIndex = 0;
            this.treeViewMenu.Size = new System.Drawing.Size(204, 424);
            this.treeViewMenu.TabIndex = 1;
            this.treeViewMenu.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewMenu_NodeMouseClick);
            // 
            // panelMenuHeaderOutside
            // 
            this.panelMenuHeaderOutside.Controls.Add(this.panelMenuHeaderInside);
            this.panelMenuHeaderOutside.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuHeaderOutside.Location = new System.Drawing.Point(4, 4);
            this.panelMenuHeaderOutside.Name = "panelMenuHeaderOutside";
            this.panelMenuHeaderOutside.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.panelMenuHeaderOutside.Size = new System.Drawing.Size(204, 27);
            this.panelMenuHeaderOutside.TabIndex = 0;
            // 
            // panelMenuHeaderInside
            // 
            this.panelMenuHeaderInside.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenuHeaderInside.Controls.Add(this.labelMenuHeader);
            this.panelMenuHeaderInside.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenuHeaderInside.Location = new System.Drawing.Point(0, 0);
            this.panelMenuHeaderInside.Name = "panelMenuHeaderInside";
            this.panelMenuHeaderInside.Size = new System.Drawing.Size(204, 23);
            this.panelMenuHeaderInside.TabIndex = 0;
            // 
            // labelMenuHeader
            // 
            this.labelMenuHeader.AutoSize = true;
            this.labelMenuHeader.Location = new System.Drawing.Point(4, 4);
            this.labelMenuHeader.Name = "labelMenuHeader";
            this.labelMenuHeader.Size = new System.Drawing.Size(43, 14);
            this.labelMenuHeader.TabIndex = 0;
            this.labelMenuHeader.Text = "MENIU";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageWarehouseRowsOverview);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(4, 31);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(493, 424);
            this.tabControlMain.TabIndex = 3;
            // 
            // tabPageWarehouseRowsOverview
            // 
            this.tabPageWarehouseRowsOverview.Controls.Add(this.warehouseRowOverview);
            this.tabPageWarehouseRowsOverview.Location = new System.Drawing.Point(4, 23);
            this.tabPageWarehouseRowsOverview.Name = "tabPageWarehouseRowsOverview";
            this.tabPageWarehouseRowsOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWarehouseRowsOverview.Size = new System.Drawing.Size(485, 397);
            this.tabPageWarehouseRowsOverview.TabIndex = 0;
            this.tabPageWarehouseRowsOverview.Text = "Situatie pe randuri depozit";
            this.tabPageWarehouseRowsOverview.UseVisualStyleBackColor = true;
            // 
            // warehouseRowOverview
            // 
            this.warehouseRowOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.warehouseRowOverview.Location = new System.Drawing.Point(3, 3);
            this.warehouseRowOverview.Name = "warehouseRowOverview";
            this.warehouseRowOverview.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.warehouseRowOverview.Size = new System.Drawing.Size(479, 391);
            this.warehouseRowOverview.TabIndex = 0;
            // 
            // panelMainHeaderOutside
            // 
            this.panelMainHeaderOutside.Controls.Add(this.panelMainHeaderInside);
            this.panelMainHeaderOutside.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainHeaderOutside.Location = new System.Drawing.Point(4, 4);
            this.panelMainHeaderOutside.Name = "panelMainHeaderOutside";
            this.panelMainHeaderOutside.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.panelMainHeaderOutside.Size = new System.Drawing.Size(493, 27);
            this.panelMainHeaderOutside.TabIndex = 2;
            // 
            // panelMainHeaderInside
            // 
            this.panelMainHeaderInside.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMainHeaderInside.Controls.Add(this.labelMainHeader);
            this.panelMainHeaderInside.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainHeaderInside.Location = new System.Drawing.Point(0, 0);
            this.panelMainHeaderInside.Name = "panelMainHeaderInside";
            this.panelMainHeaderInside.Size = new System.Drawing.Size(493, 23);
            this.panelMainHeaderInside.TabIndex = 0;
            // 
            // labelMainHeader
            // 
            this.labelMainHeader.AutoSize = true;
            this.labelMainHeader.Location = new System.Drawing.Point(4, 4);
            this.labelMainHeader.Name = "labelMainHeader";
            this.labelMainHeader.Size = new System.Drawing.Size(53, 14);
            this.labelMainHeader.TabIndex = 0;
            this.labelMainHeader.Text = "Utilizator";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 469);
            this.Controls.Add(this.splitContainerMain);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.panelMenuHeaderOutside.ResumeLayout(false);
            this.panelMenuHeaderInside.ResumeLayout(false);
            this.panelMenuHeaderInside.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageWarehouseRowsOverview.ResumeLayout(false);
            this.panelMainHeaderOutside.ResumeLayout(false);
            this.panelMainHeaderInside.ResumeLayout(false);
            this.panelMainHeaderInside.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel panelMenuHeaderOutside;
        private System.Windows.Forms.Panel panelMenuHeaderInside;
        private System.Windows.Forms.Label labelMenuHeader;
        private System.Windows.Forms.Panel panelMainHeaderOutside;
        private System.Windows.Forms.Panel panelMainHeaderInside;
        private System.Windows.Forms.Label labelMainHeader;
        private CustomControls.TreeViewMenu treeViewMenu;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageWarehouseRowsOverview;
        private EntityModels.WarehouseRows.WarehouseRowOverview warehouseRowOverview;
    }
}

