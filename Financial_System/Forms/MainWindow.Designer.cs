﻿
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
            this.CloseButton = new System.Windows.Forms.Label();
            this.SideMenuPanel = new System.Windows.Forms.Panel();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.SetupButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.CollectionPanel = new System.Windows.Forms.Panel();
            this.TransactionButton = new System.Windows.Forms.Button();
            this.StudentLedgerButton = new System.Windows.Forms.Button();
            this.CollectionsButton = new System.Windows.Forms.Button();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.GetStartedButton = new System.Windows.Forms.Button();
            this.SpacePanel = new System.Windows.Forms.Panel();
            this.PCHS_logo_picbox = new System.Windows.Forms.PictureBox();
            this.HeadPanel = new System.Windows.Forms.Panel();
            this.DisplayControlPanel = new System.Windows.Forms.Panel();
            this.TestButton2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TopBarPanel.SuspendLayout();
            this.SideMenuPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.CollectionPanel.SuspendLayout();
            this.SpacePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCHS_logo_picbox)).BeginInit();
            this.DisplayControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TopBarPanel.Controls.Add(this.CloseButton);
            this.TopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(971, 30);
            this.TopBarPanel.TabIndex = 0;
            this.TopBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBarPanel_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.Red;
            this.CloseButton.Location = new System.Drawing.Point(948, 6);
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
            this.SideMenuPanel.Size = new System.Drawing.Size(171, 488);
            this.SideMenuPanel.TabIndex = 1;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.ButtonPanel.Controls.Add(this.SetupButton);
            this.ButtonPanel.Controls.Add(this.ReportButton);
            this.ButtonPanel.Controls.Add(this.CollectionPanel);
            this.ButtonPanel.Controls.Add(this.DashboardButton);
            this.ButtonPanel.Controls.Add(this.GetStartedButton);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 137);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(171, 333);
            this.ButtonPanel.TabIndex = 8;
            // 
            // SetupButton
            // 
            this.SetupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetupButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SetupButton.FlatAppearance.BorderSize = 0;
            this.SetupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetupButton.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetupButton.ForeColor = System.Drawing.Color.White;
            this.SetupButton.Location = new System.Drawing.Point(0, 167);
            this.SetupButton.Name = "SetupButton";
            this.SetupButton.Size = new System.Drawing.Size(171, 27);
            this.SetupButton.TabIndex = 10;
            this.SetupButton.Text = "Setup";
            this.SetupButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SetupButton.UseVisualStyleBackColor = true;
            // 
            // ReportButton
            // 
            this.ReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReportButton.FlatAppearance.BorderSize = 0;
            this.ReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportButton.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportButton.ForeColor = System.Drawing.Color.White;
            this.ReportButton.Location = new System.Drawing.Point(0, 140);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(171, 27);
            this.ReportButton.TabIndex = 9;
            this.ReportButton.Text = "Reports";
            this.ReportButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // CollectionPanel
            // 
            this.CollectionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.CollectionPanel.Controls.Add(this.TransactionButton);
            this.CollectionPanel.Controls.Add(this.StudentLedgerButton);
            this.CollectionPanel.Controls.Add(this.CollectionsButton);
            this.CollectionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CollectionPanel.Location = new System.Drawing.Point(0, 54);
            this.CollectionPanel.Name = "CollectionPanel";
            this.CollectionPanel.Size = new System.Drawing.Size(171, 86);
            this.CollectionPanel.TabIndex = 6;
            // 
            // TransactionButton
            // 
            this.TransactionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.TransactionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransactionButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.TransactionButton.FlatAppearance.BorderSize = 0;
            this.TransactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionButton.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionButton.ForeColor = System.Drawing.Color.White;
            this.TransactionButton.Location = new System.Drawing.Point(0, 54);
            this.TransactionButton.Name = "TransactionButton";
            this.TransactionButton.Size = new System.Drawing.Size(171, 27);
            this.TransactionButton.TabIndex = 11;
            this.TransactionButton.Text = "Create Transaction";
            this.TransactionButton.UseVisualStyleBackColor = false;
            this.TransactionButton.Click += new System.EventHandler(this.TransactionButton_Click);
            // 
            // StudentLedgerButton
            // 
            this.StudentLedgerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.StudentLedgerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudentLedgerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.StudentLedgerButton.FlatAppearance.BorderSize = 0;
            this.StudentLedgerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentLedgerButton.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLedgerButton.ForeColor = System.Drawing.Color.White;
            this.StudentLedgerButton.Location = new System.Drawing.Point(0, 27);
            this.StudentLedgerButton.Name = "StudentLedgerButton";
            this.StudentLedgerButton.Size = new System.Drawing.Size(171, 27);
            this.StudentLedgerButton.TabIndex = 12;
            this.StudentLedgerButton.Text = "Student Ledgers";
            this.StudentLedgerButton.UseVisualStyleBackColor = false;
            this.StudentLedgerButton.Click += new System.EventHandler(this.StudentLedgerButton_Click);
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
            this.CollectionsButton.Location = new System.Drawing.Point(0, 0);
            this.CollectionsButton.Name = "CollectionsButton";
            this.CollectionsButton.Size = new System.Drawing.Size(171, 27);
            this.CollectionsButton.TabIndex = 9;
            this.CollectionsButton.Text = "Collections";
            this.CollectionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CollectionsButton.UseVisualStyleBackColor = false;
            this.CollectionsButton.Click += new System.EventHandler(this.CollectionsBtn_Click);
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
            this.HeadPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadPanel.Location = new System.Drawing.Point(171, 30);
            this.HeadPanel.Name = "HeadPanel";
            this.HeadPanel.Size = new System.Drawing.Size(800, 48);
            this.HeadPanel.TabIndex = 2;
            // 
            // DisplayControlPanel
            // 
            this.DisplayControlPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DisplayControlPanel.Controls.Add(this.button1);
            this.DisplayControlPanel.Controls.Add(this.TestButton2);
            this.DisplayControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayControlPanel.Location = new System.Drawing.Point(171, 78);
            this.DisplayControlPanel.Name = "DisplayControlPanel";
            this.DisplayControlPanel.Size = new System.Drawing.Size(800, 440);
            this.DisplayControlPanel.TabIndex = 3;
            // 
            // TestButton2
            // 
            this.TestButton2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TestButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TestButton2.FlatAppearance.BorderSize = 0;
            this.TestButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TestButton2.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestButton2.ForeColor = System.Drawing.Color.Black;
            this.TestButton2.Location = new System.Drawing.Point(18, 53);
            this.TestButton2.Name = "TestButton2";
            this.TestButton2.Size = new System.Drawing.Size(171, 27);
            this.TestButton2.TabIndex = 12;
            this.TestButton2.Text = "Insert Student";
            this.TestButton2.UseVisualStyleBackColor = false;
            this.TestButton2.Click += new System.EventHandler(this.TestButton2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 518);
            this.Controls.Add(this.DisplayControlPanel);
            this.Controls.Add(this.HeadPanel);
            this.Controls.Add(this.SideMenuPanel);
            this.Controls.Add(this.TopBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
            this.SideMenuPanel.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            this.CollectionPanel.ResumeLayout(false);
            this.SpacePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PCHS_logo_picbox)).EndInit();
            this.DisplayControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Panel SideMenuPanel;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Panel HeadPanel;
        private System.Windows.Forms.Button DashboardButton;
        private System.Windows.Forms.Panel CollectionPanel;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button SetupButton;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button TransactionButton;
        private System.Windows.Forms.Button StudentLedgerButton;
        private System.Windows.Forms.Button CollectionsButton;
        private System.Windows.Forms.Button GetStartedButton;
        private System.Windows.Forms.Panel SpacePanel;
        private System.Windows.Forms.Button TestButton2;
        public System.Windows.Forms.Panel DisplayControlPanel;
        private System.Windows.Forms.PictureBox PCHS_logo_picbox;
        private System.Windows.Forms.Button button1;
    }
}