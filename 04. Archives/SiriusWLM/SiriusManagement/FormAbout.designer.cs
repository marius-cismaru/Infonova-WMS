namespace Sirius.SiriusManagement
{
	partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.groupBoxInit = new System.Windows.Forms.GroupBox();
            this.labelVersionDatabase = new System.Windows.Forms.Label();
            this.labelVersionProgram = new System.Windows.Forms.Label();
            this.panelDescription = new System.Windows.Forms.Panel();
            this.labelProgramDescription = new System.Windows.Forms.Label();
            this.labelProgramName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBoxUpdateLog = new System.Windows.Forms.GroupBox();
            this.richTextBoxUpdateLog = new System.Windows.Forms.RichTextBox();
            this.groupBoxInit.SuspendLayout();
            this.panelDescription.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxUpdateLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInit
            // 
            this.groupBoxInit.Controls.Add(this.labelVersionDatabase);
            this.groupBoxInit.Controls.Add(this.labelVersionProgram);
            this.groupBoxInit.Location = new System.Drawing.Point(14, 141);
            this.groupBoxInit.Name = "groupBoxInit";
            this.groupBoxInit.Size = new System.Drawing.Size(626, 57);
            this.groupBoxInit.TabIndex = 0;
            this.groupBoxInit.TabStop = false;
            this.groupBoxInit.Text = "Versiuni";
            // 
            // labelVersionDatabase
            // 
            this.labelVersionDatabase.AutoSize = true;
            this.labelVersionDatabase.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVersionDatabase.Location = new System.Drawing.Point(18, 34);
            this.labelVersionDatabase.Name = "labelVersionDatabase";
            this.labelVersionDatabase.Size = new System.Drawing.Size(51, 16);
            this.labelVersionDatabase.TabIndex = 1;
            this.labelVersionDatabase.Text = "Version";
            this.labelVersionDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersionProgram
            // 
            this.labelVersionProgram.AutoSize = true;
            this.labelVersionProgram.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVersionProgram.Location = new System.Drawing.Point(18, 18);
            this.labelVersionProgram.Name = "labelVersionProgram";
            this.labelVersionProgram.Size = new System.Drawing.Size(51, 16);
            this.labelVersionProgram.TabIndex = 1;
            this.labelVersionProgram.Text = "Version";
            this.labelVersionProgram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelDescription
            // 
            this.panelDescription.BackColor = System.Drawing.Color.White;
            this.panelDescription.Controls.Add(this.labelProgramDescription);
            this.panelDescription.Controls.Add(this.labelProgramName);
            this.panelDescription.Location = new System.Drawing.Point(14, 13);
            this.panelDescription.Name = "panelDescription";
            this.panelDescription.Size = new System.Drawing.Size(626, 83);
            this.panelDescription.TabIndex = 1;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelAuthor);
            this.panel1.Location = new System.Drawing.Point(14, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 33);
            this.panel1.TabIndex = 7;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAuthor.Location = new System.Drawing.Point(18, 9);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(95, 16);
            this.labelAuthor.TabIndex = 2;
            this.labelAuthor.Text = "ProgramAuthor";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Image = ((System.Drawing.Image)(resources.GetObject("buttonOK.Image")));
            this.buttonOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOK.Location = new System.Drawing.Point(553, 380);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(87, 25);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "OK";
            this.buttonOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // groupBoxUpdateLog
            // 
            this.groupBoxUpdateLog.Controls.Add(this.richTextBoxUpdateLog);
            this.groupBoxUpdateLog.Location = new System.Drawing.Point(12, 204);
            this.groupBoxUpdateLog.Name = "groupBoxUpdateLog";
            this.groupBoxUpdateLog.Size = new System.Drawing.Size(628, 165);
            this.groupBoxUpdateLog.TabIndex = 9;
            this.groupBoxUpdateLog.TabStop = false;
            this.groupBoxUpdateLog.Text = "Lista update-uri";
            // 
            // richTextBoxUpdateLog
            // 
            this.richTextBoxUpdateLog.Location = new System.Drawing.Point(23, 21);
            this.richTextBoxUpdateLog.Name = "richTextBoxUpdateLog";
            this.richTextBoxUpdateLog.ReadOnly = true;
            this.richTextBoxUpdateLog.Size = new System.Drawing.Size(587, 129);
            this.richTextBoxUpdateLog.TabIndex = 0;
            this.richTextBoxUpdateLog.Text = "";
            // 
            // FormAbout
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 417);
            this.Controls.Add(this.groupBoxUpdateLog);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDescription);
            this.Controls.Add(this.groupBoxInit);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProgramName";
            this.groupBoxInit.ResumeLayout(false);
            this.groupBoxInit.PerformLayout();
            this.panelDescription.ResumeLayout(false);
            this.panelDescription.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxUpdateLog.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Threading.Thread threadInitialize;

		private System.Windows.Forms.GroupBox groupBoxInit;
		private System.Windows.Forms.Panel panelDescription;
		private System.Windows.Forms.Label labelProgramName;
        private System.Windows.Forms.Label labelVersionDatabase;
        private System.Windows.Forms.Label labelProgramDescription;
        private System.Windows.Forms.Label labelVersionProgram;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAuthor;
        protected System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBoxUpdateLog;
        private System.Windows.Forms.RichTextBox richTextBoxUpdateLog;
	}
}