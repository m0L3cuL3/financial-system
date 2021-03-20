
namespace Financial_System.UserControls
{
    partial class StudentItemControl
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
            this.StudentNameLabel = new System.Windows.Forms.Label();
            this.StudentSectionLabel = new System.Windows.Forms.Label();
            this.ViewLedgerButton = new System.Windows.Forms.Button();
            this.StudentIDLabel = new System.Windows.Forms.Label();
            this.StudentLevelLabel = new System.Windows.Forms.Label();
            this.ProfilePanel = new Financial_System.CustomUI.GradientPanel();
            this.SuspendLayout();
            // 
            // StudentNameLabel
            // 
            this.StudentNameLabel.AutoSize = true;
            this.StudentNameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.StudentNameLabel.Location = new System.Drawing.Point(74, 9);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.Size = new System.Drawing.Size(97, 17);
            this.StudentNameLabel.TabIndex = 7;
            this.StudentNameLabel.Text = "StudentName";
            // 
            // StudentSectionLabel
            // 
            this.StudentSectionLabel.AutoSize = true;
            this.StudentSectionLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentSectionLabel.Location = new System.Drawing.Point(74, 43);
            this.StudentSectionLabel.Name = "StudentSectionLabel";
            this.StudentSectionLabel.Size = new System.Drawing.Size(104, 17);
            this.StudentSectionLabel.TabIndex = 9;
            this.StudentSectionLabel.Text = "StudentSection";
            // 
            // ViewLedgerButton
            // 
            this.ViewLedgerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.ViewLedgerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewLedgerButton.FlatAppearance.BorderSize = 0;
            this.ViewLedgerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewLedgerButton.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewLedgerButton.ForeColor = System.Drawing.Color.White;
            this.ViewLedgerButton.Location = new System.Drawing.Point(669, 32);
            this.ViewLedgerButton.Name = "ViewLedgerButton";
            this.ViewLedgerButton.Size = new System.Drawing.Size(119, 28);
            this.ViewLedgerButton.TabIndex = 10;
            this.ViewLedgerButton.Text = "View Ledger";
            this.ViewLedgerButton.UseVisualStyleBackColor = false;
            this.ViewLedgerButton.Click += new System.EventHandler(this.ViewLedgerButton_Click);
            // 
            // StudentIDLabel
            // 
            this.StudentIDLabel.AutoSize = true;
            this.StudentIDLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentIDLabel.Location = new System.Drawing.Point(666, 9);
            this.StudentIDLabel.Name = "StudentIDLabel";
            this.StudentIDLabel.Size = new System.Drawing.Size(69, 17);
            this.StudentIDLabel.TabIndex = 11;
            this.StudentIDLabel.Text = "StudentId";
            // 
            // StudentLevelLabel
            // 
            this.StudentLevelLabel.AutoSize = true;
            this.StudentLevelLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLevelLabel.Location = new System.Drawing.Point(74, 26);
            this.StudentLevelLabel.Name = "StudentLevelLabel";
            this.StudentLevelLabel.Size = new System.Drawing.Size(90, 17);
            this.StudentLevelLabel.TabIndex = 12;
            this.StudentLevelLabel.Text = "StudentLevel";
            // 
            // ProfilePanel
            // 
            this.ProfilePanel.Angle = -48F;
            this.ProfilePanel.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(142)))), ((int)(((byte)(208)))));
            this.ProfilePanel.Location = new System.Drawing.Point(12, 9);
            this.ProfilePanel.Name = "ProfilePanel";
            this.ProfilePanel.Size = new System.Drawing.Size(53, 51);
            this.ProfilePanel.TabIndex = 13;
            this.ProfilePanel.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            // 
            // StudentItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.ProfilePanel);
            this.Controls.Add(this.StudentLevelLabel);
            this.Controls.Add(this.StudentIDLabel);
            this.Controls.Add(this.ViewLedgerButton);
            this.Controls.Add(this.StudentSectionLabel);
            this.Controls.Add(this.StudentNameLabel);
            this.Margin = new System.Windows.Forms.Padding(10, 10, 0, 3);
            this.Name = "StudentItemControl";
            this.Size = new System.Drawing.Size(800, 68);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ViewLedgerButton;
        public System.Windows.Forms.Label StudentNameLabel;
        public System.Windows.Forms.Label StudentSectionLabel;
        public System.Windows.Forms.Label StudentIDLabel;
        public System.Windows.Forms.Label StudentLevelLabel;
        private CustomUI.GradientPanel ProfilePanel;
    }
}
