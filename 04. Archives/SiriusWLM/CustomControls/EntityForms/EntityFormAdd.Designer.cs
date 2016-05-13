namespace Sirius.CustomControls
{
    partial class EntityFormAdd
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
            this.panelFooter = new System.Windows.Forms.Panel();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.errorProviderError = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeaderDescription = new System.Windows.Forms.Label();
            this.tabControlWizard = new Sirius.CustomControls.TabControlWizard();
            this.tabPageStep1 = new System.Windows.Forms.TabPage();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderError)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.tabControlWizard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.buttonPrevious);
            this.panelFooter.Controls.Add(this.buttonNext);
            this.panelFooter.Controls.Add(this.buttonFinish);
            this.panelFooter.Controls.Add(this.buttonCancel);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 360);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(617, 38);
            this.panelFooter.TabIndex = 0;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrevious.Location = new System.Drawing.Point(329, 6);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(95, 25);
            this.buttonPrevious.TabIndex = 3;
            this.buttonPrevious.Text = "<< Precedent";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext.Location = new System.Drawing.Point(430, 6);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(87, 25);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "Urmator >>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonFinish
            // 
            this.buttonFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFinish.Image = global::Sirius.CustomControls.Properties.Resources.icon_16_win_save;
            this.buttonFinish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFinish.Location = new System.Drawing.Point(523, 6);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(87, 25);
            this.buttonFinish.TabIndex = 1;
            this.buttonFinish.Text = "Salvare";
            this.buttonFinish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Image = global::Sirius.CustomControls.Properties.Resources.icon_16_cross;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(236, 6);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 25);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Anulare";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // errorProviderError
            // 
            this.errorProviderError.ContainerControl = this;
            // 
            // toolTipMain
            // 
            this.toolTipMain.AutoPopDelay = 0;
            this.toolTipMain.InitialDelay = 500;
            this.toolTipMain.ReshowDelay = 100;
            this.toolTipMain.ShowAlways = true;
            this.toolTipMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipMain.ToolTipTitle = "Descriere";
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.labelHeaderDescription);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(617, 36);
            this.panelHeader.TabIndex = 2;
            // 
            // labelHeaderDescription
            // 
            this.labelHeaderDescription.AutoSize = true;
            this.labelHeaderDescription.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHeaderDescription.Location = new System.Drawing.Point(12, 9);
            this.labelHeaderDescription.Name = "labelHeaderDescription";
            this.labelHeaderDescription.Size = new System.Drawing.Size(81, 16);
            this.labelHeaderDescription.TabIndex = 0;
            this.labelHeaderDescription.Text = "Description";
            // 
            // tabControlWizard
            // 
            this.tabControlWizard.Controls.Add(this.tabPageStep1);
            this.tabControlWizard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlWizard.Location = new System.Drawing.Point(0, 36);
            this.tabControlWizard.Name = "tabControlWizard";
            this.tabControlWizard.SelectedIndex = 0;
            this.tabControlWizard.Size = new System.Drawing.Size(617, 324);
            this.tabControlWizard.TabIndex = 1;
            this.tabControlWizard.SelectedIndexChanged += new System.EventHandler(this.tabControlWizard_SelectedIndexChanged);
            // 
            // tabPageStep1
            // 
            this.tabPageStep1.Location = new System.Drawing.Point(4, 23);
            this.tabPageStep1.Name = "tabPageStep1";
            this.tabPageStep1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStep1.Size = new System.Drawing.Size(609, 297);
            this.tabPageStep1.TabIndex = 0;
            this.tabPageStep1.Text = "Pas 1";
            this.tabPageStep1.UseVisualStyleBackColor = true;
            // 
            // EntityFormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(617, 398);
            this.Controls.Add(this.tabControlWizard);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "EntityFormAdd";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EntityFormAdd";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EntityFormAdd_FormClosing);
            this.Shown += new System.EventHandler(this.FormAdd_Shown);
            this.panelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderError)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tabControlWizard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panelFooter;
        protected System.Windows.Forms.Button buttonFinish;
        protected System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.ErrorProvider errorProviderError;
        public System.Windows.Forms.ToolTip toolTipMain;
        protected System.Windows.Forms.Button buttonNext;
        protected TabControlWizard tabControlWizard;
        protected System.Windows.Forms.TabPage tabPageStep1;
        protected System.Windows.Forms.Button buttonPrevious;
        protected System.Windows.Forms.Label labelHeaderDescription;
        protected System.Windows.Forms.Panel panelHeader;
    }
}