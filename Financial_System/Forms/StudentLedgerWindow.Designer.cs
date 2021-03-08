
namespace Financial_System.Forms
{
    partial class StudentLedgerWindow
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
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.ProfilePicPanel = new System.Windows.Forms.Panel();
            this.StudentLevelLabel = new System.Windows.Forms.Label();
            this.StudentIDLabel = new System.Windows.Forms.Label();
            this.StudentSectionLabel = new System.Windows.Forms.Label();
            this.StudentNameLabel = new System.Windows.Forms.Label();
            this.TopBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(42)))));
            this.TopBarPanel.Controls.Add(this.CloseButton);
            this.TopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(827, 30);
            this.TopBarPanel.TabIndex = 0;
            this.TopBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBarPanel_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.AutoSize = true;
            this.CloseButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Location = new System.Drawing.Point(803, 6);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(17, 18);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ProfilePicPanel
            // 
            this.ProfilePicPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ProfilePicPanel.Location = new System.Drawing.Point(26, 54);
            this.ProfilePicPanel.Name = "ProfilePicPanel";
            this.ProfilePicPanel.Size = new System.Drawing.Size(122, 116);
            this.ProfilePicPanel.TabIndex = 1;
            // 
            // StudentLevelLabel
            // 
            this.StudentLevelLabel.AutoSize = true;
            this.StudentLevelLabel.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLevelLabel.Location = new System.Drawing.Point(156, 79);
            this.StudentLevelLabel.Name = "StudentLevelLabel";
            this.StudentLevelLabel.Size = new System.Drawing.Size(81, 17);
            this.StudentLevelLabel.TabIndex = 16;
            this.StudentLevelLabel.Text = "StudentLevel";
            // 
            // StudentIDLabel
            // 
            this.StudentIDLabel.AutoSize = true;
            this.StudentIDLabel.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentIDLabel.Location = new System.Drawing.Point(156, 153);
            this.StudentIDLabel.Name = "StudentIDLabel";
            this.StudentIDLabel.Size = new System.Drawing.Size(63, 17);
            this.StudentIDLabel.TabIndex = 15;
            this.StudentIDLabel.Text = "StudentId";
            // 
            // StudentSectionLabel
            // 
            this.StudentSectionLabel.AutoSize = true;
            this.StudentSectionLabel.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentSectionLabel.Location = new System.Drawing.Point(156, 136);
            this.StudentSectionLabel.Name = "StudentSectionLabel";
            this.StudentSectionLabel.Size = new System.Drawing.Size(94, 17);
            this.StudentSectionLabel.TabIndex = 14;
            this.StudentSectionLabel.Text = "StudentSection";
            // 
            // StudentNameLabel
            // 
            this.StudentNameLabel.AutoSize = true;
            this.StudentNameLabel.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentNameLabel.Location = new System.Drawing.Point(154, 54);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.Size = new System.Drawing.Size(127, 25);
            this.StudentNameLabel.TabIndex = 13;
            this.StudentNameLabel.Text = "StudentName";
            // 
            // StudentLedgerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 466);
            this.Controls.Add(this.StudentLevelLabel);
            this.Controls.Add(this.StudentIDLabel);
            this.Controls.Add(this.StudentSectionLabel);
            this.Controls.Add(this.StudentNameLabel);
            this.Controls.Add(this.ProfilePicPanel);
            this.Controls.Add(this.TopBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentLedgerWindow";
            this.Text = "StudentLedgerWindow";
            this.Load += new System.EventHandler(this.StudentLedgerWindow_Load);
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Panel ProfilePicPanel;
        public System.Windows.Forms.Label StudentLevelLabel;
        public System.Windows.Forms.Label StudentIDLabel;
        public System.Windows.Forms.Label StudentSectionLabel;
        public System.Windows.Forms.Label StudentNameLabel;
    }
}