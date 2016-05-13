namespace Sirius.SiriusManagement
{
	partial class FormLogin
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
            this.groupBoxInit = new System.Windows.Forms.GroupBox();
            this.progressBarInit = new System.Windows.Forms.ProgressBar();
            this.richTextBoxProgress = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelProgramDescription = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelProgramName = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAuthenticate = new System.Windows.Forms.Button();
            this.groupBoxCompany = new System.Windows.Forms.GroupBox();
            this.buttonCompanySelect = new System.Windows.Forms.Button();
            this.selectBoxCompany = new Sirius.CustomControls.EntitySelectBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReinitialize = new System.Windows.Forms.Button();
            this.groupBoxInit.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxCompany.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInit
            // 
            this.groupBoxInit.Controls.Add(this.buttonReinitialize);
            this.groupBoxInit.Controls.Add(this.progressBarInit);
            this.groupBoxInit.Controls.Add(this.richTextBoxProgress);
            this.groupBoxInit.Location = new System.Drawing.Point(14, 102);
            this.groupBoxInit.Name = "groupBoxInit";
            this.groupBoxInit.Size = new System.Drawing.Size(595, 186);
            this.groupBoxInit.TabIndex = 0;
            this.groupBoxInit.TabStop = false;
            this.groupBoxInit.Text = "Initializare";
            // 
            // progressBarInit
            // 
            this.progressBarInit.Location = new System.Drawing.Point(15, 21);
            this.progressBarInit.Name = "progressBarInit";
            this.progressBarInit.Size = new System.Drawing.Size(451, 23);
            this.progressBarInit.TabIndex = 3;
            // 
            // richTextBoxProgress
            // 
            this.richTextBoxProgress.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxProgress.Location = new System.Drawing.Point(15, 51);
            this.richTextBoxProgress.Name = "richTextBoxProgress";
            this.richTextBoxProgress.ReadOnly = true;
            this.richTextBoxProgress.Size = new System.Drawing.Size(565, 118);
            this.richTextBoxProgress.TabIndex = 2;
            this.richTextBoxProgress.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelProgramDescription);
            this.panel1.Controls.Add(this.labelVersion);
            this.panel1.Controls.Add(this.labelProgramName);
            this.panel1.Location = new System.Drawing.Point(14, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 83);
            this.panel1.TabIndex = 1;
            // 
            // labelProgramDescription
            // 
            this.labelProgramDescription.AutoSize = true;
            this.labelProgramDescription.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelProgramDescription.Location = new System.Drawing.Point(19, 52);
            this.labelProgramDescription.Name = "labelProgramDescription";
            this.labelProgramDescription.Size = new System.Drawing.Size(158, 18);
            this.labelProgramDescription.TabIndex = 2;
            this.labelProgramDescription.Text = "ProgramDescription";
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelVersion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVersion.Location = new System.Drawing.Point(330, 10);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(250, 17);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "Version";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelProgramName
            // 
            this.labelProgramName.AutoSize = true;
            this.labelProgramName.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelProgramName.ForeColor = System.Drawing.Color.Gray;
            this.labelProgramName.Location = new System.Drawing.Point(14, 10);
            this.labelProgramName.Name = "labelProgramName";
            this.labelProgramName.Size = new System.Drawing.Size(250, 39);
            this.labelProgramName.TabIndex = 0;
            this.labelProgramName.Text = "ProgramName";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Enabled = false;
            this.textBoxUsername.Location = new System.Drawing.Point(110, 22);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(172, 22);
            this.textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Enabled = false;
            this.textBoxPassword.Location = new System.Drawing.Point(110, 51);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(172, 22);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonExit);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.buttonAuthenticate);
            this.groupBox2.Controls.Add(this.textBoxPassword);
            this.groupBox2.Controls.Add(this.textBoxUsername);
            this.groupBox2.Location = new System.Drawing.Point(12, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 117);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Autentificare";
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(58, 80);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(108, 27);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Iesire";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Parola";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nume Utilizator";
            // 
            // buttonAuthenticate
            // 
            this.buttonAuthenticate.Enabled = false;
            this.buttonAuthenticate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAuthenticate.Location = new System.Drawing.Point(174, 80);
            this.buttonAuthenticate.Name = "buttonAuthenticate";
            this.buttonAuthenticate.Size = new System.Drawing.Size(108, 27);
            this.buttonAuthenticate.TabIndex = 4;
            this.buttonAuthenticate.Text = "Autentificare";
            this.buttonAuthenticate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAuthenticate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAuthenticate.UseVisualStyleBackColor = true;
            this.buttonAuthenticate.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // groupBoxCompany
            // 
            this.groupBoxCompany.Controls.Add(this.buttonCompanySelect);
            this.groupBoxCompany.Controls.Add(this.selectBoxCompany);
            this.groupBoxCompany.Controls.Add(this.label1);
            this.groupBoxCompany.Location = new System.Drawing.Point(317, 294);
            this.groupBoxCompany.Name = "groupBoxCompany";
            this.groupBoxCompany.Size = new System.Drawing.Size(289, 117);
            this.groupBoxCompany.TabIndex = 6;
            this.groupBoxCompany.TabStop = false;
            this.groupBoxCompany.Text = "Selectare Companie";
            // 
            // buttonCompanySelect
            // 
            this.buttonCompanySelect.Enabled = false;
            this.buttonCompanySelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCompanySelect.Location = new System.Drawing.Point(166, 80);
            this.buttonCompanySelect.Name = "buttonCompanySelect";
            this.buttonCompanySelect.Size = new System.Drawing.Size(108, 27);
            this.buttonCompanySelect.TabIndex = 8;
            this.buttonCompanySelect.Text = "Selectare";
            this.buttonCompanySelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCompanySelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCompanySelect.UseVisualStyleBackColor = true;
            this.buttonCompanySelect.Click += new System.EventHandler(this.buttonCompanySelect_Click);
            // 
            // selectBoxCompany
            // 
            this.selectBoxCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBoxCompany.Enabled = false;
            this.selectBoxCompany.FormattingEnabled = true;
            this.selectBoxCompany.Location = new System.Drawing.Point(77, 22);
            this.selectBoxCompany.Name = "selectBoxCompany";
            this.selectBoxCompany.Size = new System.Drawing.Size(196, 22);
            this.selectBoxCompany.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Companie";
            // 
            // buttonReinitialize
            // 
            this.buttonReinitialize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReinitialize.Location = new System.Drawing.Point(472, 18);
            this.buttonReinitialize.Name = "buttonReinitialize";
            this.buttonReinitialize.Size = new System.Drawing.Size(108, 27);
            this.buttonReinitialize.TabIndex = 5;
            this.buttonReinitialize.Text = "Reinitializare";
            this.buttonReinitialize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReinitialize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReinitialize.UseVisualStyleBackColor = true;
            this.buttonReinitialize.Click += new System.EventHandler(this.buttonReinitialize_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(624, 423);
            this.Controls.Add(this.groupBoxCompany);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxInit);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgramName";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.Shown += new System.EventHandler(this.FormLogin_Shown);
            this.groupBoxInit.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxCompany.ResumeLayout(false);
            this.groupBoxCompany.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Threading.Thread threadInitialize;

		private System.Windows.Forms.GroupBox groupBoxInit;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label labelProgramName;
		private System.Windows.Forms.Label labelVersion;
		private System.Windows.Forms.TextBox textBoxUsername;
		private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonAuthenticate;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox richTextBoxProgress;
		private System.Windows.Forms.Label labelProgramDescription;
        private System.Windows.Forms.GroupBox groupBoxCompany;
        private Sirius.CustomControls.EntitySelectBox selectBoxCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCompanySelect;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ProgressBar progressBarInit;
        private System.Windows.Forms.Button buttonReinitialize;
	}
}