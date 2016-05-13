namespace Sirius.SiriusAdmin
{
    partial class FormConfigurationEdit
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
            this.tablePanelGeneral = new Sirius.CustomControls.EntityTablePanel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSQLServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSQLUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSQLPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSQLDatabase = new System.Windows.Forms.TextBox();
            this.buttonSQLTest = new System.Windows.Forms.Button();
            this.panelBottom.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMain)).BeginInit();
            this.tablePanelGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 365);
            this.panelBottom.Size = new System.Drawing.Size(709, 38);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(615, 6);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(522, 6);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Size = new System.Drawing.Size(709, 365);
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.tablePanelGeneral);
            this.tabPageGeneral.Size = new System.Drawing.Size(701, 332);
            // 
            // tablePanelGeneral
            // 
            this.tablePanelGeneral.AutoScroll = true;
            this.tablePanelGeneral.BackColor = System.Drawing.SystemColors.Control;
            this.tablePanelGeneral.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tablePanelGeneral.ColumnCount = 3;
            this.tablePanelGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tablePanelGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tablePanelGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanelGeneral.Controls.Add(this.label9, 0, 0);
            this.tablePanelGeneral.Controls.Add(this.textBoxSQLServer, 1, 0);
            this.tablePanelGeneral.Controls.Add(this.label4, 0, 1);
            this.tablePanelGeneral.Controls.Add(this.textBoxSQLUsername, 1, 1);
            this.tablePanelGeneral.Controls.Add(this.label6, 0, 2);
            this.tablePanelGeneral.Controls.Add(this.textBoxSQLPassword, 1, 2);
            this.tablePanelGeneral.Controls.Add(this.label1, 0, 3);
            this.tablePanelGeneral.Controls.Add(this.textBoxSQLDatabase, 1, 3);
            this.tablePanelGeneral.Controls.Add(this.buttonSQLTest, 2, 3);
            this.tablePanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelGeneral.Location = new System.Drawing.Point(3, 3);
            this.tablePanelGeneral.Name = "tablePanelGeneral";
            this.tablePanelGeneral.RowCount = 5;
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelGeneral.Size = new System.Drawing.Size(695, 326);
            this.tablePanelGeneral.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 14);
            this.label9.TabIndex = 50;
            this.label9.Text = "SQL Server";
            // 
            // textBoxSQLServer
            // 
            this.textBoxSQLServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSQLServer.Location = new System.Drawing.Point(155, 4);
            this.textBoxSQLServer.Name = "textBoxSQLServer";
            this.textBoxSQLServer.Size = new System.Drawing.Size(344, 22);
            this.textBoxSQLServer.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 14);
            this.label4.TabIndex = 52;
            this.label4.Text = "SQL Username";
            // 
            // textBoxSQLUsername
            // 
            this.textBoxSQLUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSQLUsername.Location = new System.Drawing.Point(155, 33);
            this.textBoxSQLUsername.Name = "textBoxSQLUsername";
            this.textBoxSQLUsername.Size = new System.Drawing.Size(344, 22);
            this.textBoxSQLUsername.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 14);
            this.label6.TabIndex = 54;
            this.label6.Text = "SQL Password";
            // 
            // textBoxSQLPassword
            // 
            this.textBoxSQLPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSQLPassword.Location = new System.Drawing.Point(155, 62);
            this.textBoxSQLPassword.Name = "textBoxSQLPassword";
            this.textBoxSQLPassword.Size = new System.Drawing.Size(344, 22);
            this.textBoxSQLPassword.TabIndex = 55;
            this.textBoxSQLPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 14);
            this.label1.TabIndex = 56;
            this.label1.Text = "SQL Database";
            // 
            // textBoxSQLDatabase
            // 
            this.textBoxSQLDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSQLDatabase.Location = new System.Drawing.Point(155, 92);
            this.textBoxSQLDatabase.Name = "textBoxSQLDatabase";
            this.textBoxSQLDatabase.Size = new System.Drawing.Size(344, 22);
            this.textBoxSQLDatabase.TabIndex = 57;
            // 
            // buttonSQLTest
            // 
            this.buttonSQLTest.Location = new System.Drawing.Point(506, 91);
            this.buttonSQLTest.Name = "buttonSQLTest";
            this.buttonSQLTest.Size = new System.Drawing.Size(92, 25);
            this.buttonSQLTest.TabIndex = 15;
            this.buttonSQLTest.Text = "Testare SQL";
            this.buttonSQLTest.UseVisualStyleBackColor = true;
            this.buttonSQLTest.Click += new System.EventHandler(this.buttonSQLTest_Click);
            // 
            // FormConfigurationEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 403);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FormConfigurationEdit";
            this.Text = "FormEdit";
            this.Shown += new System.EventHandler(this.FormEdit_Shown);
            this.panelBottom.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMain)).EndInit();
            this.tablePanelGeneral.ResumeLayout(false);
            this.tablePanelGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.EntityTablePanel tablePanelGeneral;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSQLServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSQLUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSQLPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSQLDatabase;
        private System.Windows.Forms.Button buttonSQLTest;
    }
}