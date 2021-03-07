
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.StudentNameLabel = new System.Windows.Forms.Label();
            this.StudentSectionLabel = new System.Windows.Forms.Label();
            this.StudentIDLabel = new System.Windows.Forms.Label();
            this.StudentLevelLabel = new System.Windows.Forms.Label();
            this.StudentInfoPanel = new System.Windows.Forms.Panel();
            this.TopBarPanel.SuspendLayout();
            this.StudentInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(42)))));
            this.TopBarPanel.Controls.Add(this.CloseButton);
            this.TopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(705, 30);
            this.TopBarPanel.TabIndex = 0;
            this.TopBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBarPanel_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.AutoSize = true;
            this.CloseButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Location = new System.Drawing.Point(682, 6);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(17, 18);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 106);
            this.panel1.TabIndex = 1;
            // 
            // StudentNameLabel
            // 
            this.StudentNameLabel.AutoSize = true;
            this.StudentNameLabel.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentNameLabel.Location = new System.Drawing.Point(134, 15);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.Size = new System.Drawing.Size(106, 21);
            this.StudentNameLabel.TabIndex = 2;
            this.StudentNameLabel.Text = "StudentName";
            // 
            // StudentSectionLabel
            // 
            this.StudentSectionLabel.AutoSize = true;
            this.StudentSectionLabel.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentSectionLabel.Location = new System.Drawing.Point(134, 100);
            this.StudentSectionLabel.Name = "StudentSectionLabel";
            this.StudentSectionLabel.Size = new System.Drawing.Size(115, 21);
            this.StudentSectionLabel.TabIndex = 3;
            this.StudentSectionLabel.Text = "StudentSection";
            // 
            // StudentIDLabel
            // 
            this.StudentIDLabel.AutoSize = true;
            this.StudentIDLabel.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentIDLabel.Location = new System.Drawing.Point(134, 36);
            this.StudentIDLabel.Name = "StudentIDLabel";
            this.StudentIDLabel.Size = new System.Drawing.Size(79, 21);
            this.StudentIDLabel.TabIndex = 4;
            this.StudentIDLabel.Text = "StudentID";
            // 
            // StudentLevelLabel
            // 
            this.StudentLevelLabel.AutoSize = true;
            this.StudentLevelLabel.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLevelLabel.Location = new System.Drawing.Point(134, 79);
            this.StudentLevelLabel.Name = "StudentLevelLabel";
            this.StudentLevelLabel.Size = new System.Drawing.Size(100, 21);
            this.StudentLevelLabel.TabIndex = 5;
            this.StudentLevelLabel.Text = "StudentLevel";
            // 
            // StudentInfoPanel
            // 
            this.StudentInfoPanel.Controls.Add(this.panel1);
            this.StudentInfoPanel.Controls.Add(this.StudentLevelLabel);
            this.StudentInfoPanel.Controls.Add(this.StudentNameLabel);
            this.StudentInfoPanel.Controls.Add(this.StudentSectionLabel);
            this.StudentInfoPanel.Controls.Add(this.StudentIDLabel);
            this.StudentInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StudentInfoPanel.Location = new System.Drawing.Point(0, 30);
            this.StudentInfoPanel.Name = "StudentInfoPanel";
            this.StudentInfoPanel.Size = new System.Drawing.Size(705, 137);
            this.StudentInfoPanel.TabIndex = 6;
            // 
            // StudentLedgerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 534);
            this.Controls.Add(this.StudentInfoPanel);
            this.Controls.Add(this.TopBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentLedgerWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
            this.StudentInfoPanel.ResumeLayout(false);
            this.StudentInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label StudentNameLabel;
        public System.Windows.Forms.Label StudentSectionLabel;
        public System.Windows.Forms.Label StudentIDLabel;
        public System.Windows.Forms.Label StudentLevelLabel;
        private System.Windows.Forms.Panel StudentInfoPanel;
    }
}