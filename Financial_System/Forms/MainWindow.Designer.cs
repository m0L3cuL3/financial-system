
namespace Financial_System.Forms
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new Financial_System.CustomUI.GradientPanel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.SideMenuPanel = new System.Windows.Forms.Panel();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.ToolsButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.CollectionsButton = new System.Windows.Forms.Button();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.GetStartedButton = new System.Windows.Forms.Button();
            this.SpacePanel = new System.Windows.Forms.Panel();
            this.PCHS_logo_picbox = new System.Windows.Forms.PictureBox();
            this.HeadPanel = new System.Windows.Forms.Panel();
            this.editProfButton = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.ProfilePanel = new Financial_System.CustomUI.GradientPanel();
            this.DisplayControlPanel = new System.Windows.Forms.Panel();
            this.TopBarPanel.SuspendLayout();
            this.SideMenuPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.SpacePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCHS_logo_picbox)).BeginInit();
            this.HeadPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TopBarPanel.Controls.Add(this.gradientPanel1);
            this.TopBarPanel.Controls.Add(this.CloseButton);
            this.TopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(1019, 30);
            this.TopBarPanel.TabIndex = 0;
            this.TopBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBarPanel_MouseMove);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(142)))), ((int)(((byte)(208)))));
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 25);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1019, 5);
            this.gradientPanel1.TabIndex = 1;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(94)))), ((int)(((byte)(164)))));
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.Red;
            this.CloseButton.Location = new System.Drawing.Point(996, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(18, 18);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SideMenuPanel
            // 
            this.SideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.SideMenuPanel.Controls.Add(this.ButtonPanel);
            this.SideMenuPanel.Controls.Add(this.SpacePanel);
            this.SideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenuPanel.Location = new System.Drawing.Point(0, 30);
            this.SideMenuPanel.Name = "SideMenuPanel";
            this.SideMenuPanel.Size = new System.Drawing.Size(171, 526);
            this.SideMenuPanel.TabIndex = 1;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.ButtonPanel.Controls.Add(this.ToolsButton);
            this.ButtonPanel.Controls.Add(this.ReportButton);
            this.ButtonPanel.Controls.Add(this.CollectionsButton);
            this.ButtonPanel.Controls.Add(this.DashboardButton);
            this.ButtonPanel.Controls.Add(this.GetStartedButton);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 137);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(171, 333);
            this.ButtonPanel.TabIndex = 8;
            // 
            // ToolsButton
            // 
            this.ToolsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToolsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolsButton.FlatAppearance.BorderSize = 0;
            this.ToolsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToolsButton.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolsButton.ForeColor = System.Drawing.Color.White;
            this.ToolsButton.Location = new System.Drawing.Point(0, 108);
            this.ToolsButton.Name = "ToolsButton";
            this.ToolsButton.Size = new System.Drawing.Size(171, 27);
            this.ToolsButton.TabIndex = 14;
            this.ToolsButton.Text = "Tools";
            this.ToolsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolsButton.UseVisualStyleBackColor = true;
            this.ToolsButton.Click += new System.EventHandler(this.ToolsButton_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReportButton.FlatAppearance.BorderSize = 0;
            this.ReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportButton.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportButton.ForeColor = System.Drawing.Color.White;
            this.ReportButton.Location = new System.Drawing.Point(0, 81);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(171, 27);
            this.ReportButton.TabIndex = 13;
            this.ReportButton.Text = "Reports";
            this.ReportButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // CollectionsButton
            // 
            this.CollectionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.CollectionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CollectionsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CollectionsButton.FlatAppearance.BorderSize = 0;
            this.CollectionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CollectionsButton.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollectionsButton.ForeColor = System.Drawing.Color.White;
            this.CollectionsButton.Location = new System.Drawing.Point(0, 54);
            this.CollectionsButton.Name = "CollectionsButton";
            this.CollectionsButton.Size = new System.Drawing.Size(171, 27);
            this.CollectionsButton.TabIndex = 12;
            this.CollectionsButton.Text = "Collections";
            this.CollectionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CollectionsButton.UseVisualStyleBackColor = false;
            this.CollectionsButton.Click += new System.EventHandler(this.CollectionsButton_Click);
            // 
            // DashboardButton
            // 
            this.DashboardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashboardButton.FlatAppearance.BorderSize = 0;
            this.DashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardButton.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardButton.ForeColor = System.Drawing.Color.White;
            this.DashboardButton.Location = new System.Drawing.Point(0, 27);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(171, 27);
            this.DashboardButton.TabIndex = 7;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardButton.UseVisualStyleBackColor = true;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // GetStartedButton
            // 
            this.GetStartedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetStartedButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.GetStartedButton.FlatAppearance.BorderSize = 0;
            this.GetStartedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetStartedButton.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetStartedButton.ForeColor = System.Drawing.Color.White;
            this.GetStartedButton.Location = new System.Drawing.Point(0, 0);
            this.GetStartedButton.Name = "GetStartedButton";
            this.GetStartedButton.Size = new System.Drawing.Size(171, 27);
            this.GetStartedButton.TabIndex = 8;
            this.GetStartedButton.Text = "Get Started";
            this.GetStartedButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GetStartedButton.UseVisualStyleBackColor = true;
            this.GetStartedButton.Click += new System.EventHandler(this.GetStartedButton_Click);
            // 
            // SpacePanel
            // 
            this.SpacePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.SpacePanel.Controls.Add(this.PCHS_logo_picbox);
            this.SpacePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SpacePanel.Location = new System.Drawing.Point(0, 0);
            this.SpacePanel.Name = "SpacePanel";
            this.SpacePanel.Size = new System.Drawing.Size(171, 137);
            this.SpacePanel.TabIndex = 7;
            // 
            // PCHS_logo_picbox
            // 
            this.PCHS_logo_picbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.PCHS_logo_picbox.Image = ((System.Drawing.Image)(resources.GetObject("PCHS_logo_picbox.Image")));
            this.PCHS_logo_picbox.Location = new System.Drawing.Point(21, 6);
            this.PCHS_logo_picbox.Name = "PCHS_logo_picbox";
            this.PCHS_logo_picbox.Size = new System.Drawing.Size(126, 125);
            this.PCHS_logo_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCHS_logo_picbox.TabIndex = 0;
            this.PCHS_logo_picbox.TabStop = false;
            this.PCHS_logo_picbox.Click += new System.EventHandler(this.PCHS_logo_picbox_Click);
            // 
            // HeadPanel
            // 
            this.HeadPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.HeadPanel.Controls.Add(this.editProfButton);
            this.HeadPanel.Controls.Add(this.UsernameLabel);
            this.HeadPanel.Controls.Add(this.ProfilePanel);
            this.HeadPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadPanel.Location = new System.Drawing.Point(171, 30);
            this.HeadPanel.Name = "HeadPanel";
            this.HeadPanel.Size = new System.Drawing.Size(848, 48);
            this.HeadPanel.TabIndex = 2;
            // 
            // editProfButton
            // 
            this.editProfButton.AutoSize = true;
            this.editProfButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editProfButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProfButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(117)))), ((int)(((byte)(174)))));
            this.editProfButton.Location = new System.Drawing.Point(48, 26);
            this.editProfButton.Name = "editProfButton";
            this.editProfButton.Size = new System.Drawing.Size(64, 16);
            this.editProfButton.TabIndex = 16;
            this.editProfButton.Text = "edit profile";
            this.editProfButton.Click += new System.EventHandler(this.editProfButton_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(48, 6);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(71, 17);
            this.UsernameLabel.TabIndex = 15;
            this.UsernameLabel.Text = "Username";
            // 
            // ProfilePanel
            // 
            this.ProfilePanel.Angle = -48F;
            this.ProfilePanel.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(142)))), ((int)(((byte)(208)))));
            this.ProfilePanel.Location = new System.Drawing.Point(6, 6);
            this.ProfilePanel.Name = "ProfilePanel";
            this.ProfilePanel.Size = new System.Drawing.Size(36, 36);
            this.ProfilePanel.TabIndex = 14;
            this.ProfilePanel.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            // 
            // DisplayControlPanel
            // 
            this.DisplayControlPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DisplayControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayControlPanel.Location = new System.Drawing.Point(171, 78);
            this.DisplayControlPanel.Name = "DisplayControlPanel";
            this.DisplayControlPanel.Size = new System.Drawing.Size(848, 478);
            this.DisplayControlPanel.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 556);
            this.Controls.Add(this.DisplayControlPanel);
            this.Controls.Add(this.HeadPanel);
            this.Controls.Add(this.SideMenuPanel);
            this.Controls.Add(this.TopBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
            this.SideMenuPanel.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            this.SpacePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PCHS_logo_picbox)).EndInit();
            this.HeadPanel.ResumeLayout(false);
            this.HeadPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Panel SideMenuPanel;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Panel HeadPanel;
        private System.Windows.Forms.Button DashboardButton;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button GetStartedButton;
        private System.Windows.Forms.Panel SpacePanel;
        public System.Windows.Forms.Panel DisplayControlPanel;
        private System.Windows.Forms.PictureBox PCHS_logo_picbox;
        private System.Windows.Forms.Button ToolsButton;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button CollectionsButton;
        private CustomUI.GradientPanel ProfilePanel;
        public System.Windows.Forms.Label UsernameLabel;
        private CustomUI.GradientPanel gradientPanel1;
        public System.Windows.Forms.Label editProfButton;
    }
}