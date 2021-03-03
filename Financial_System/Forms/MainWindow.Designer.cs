
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
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SideMenuPanel = new System.Windows.Forms.Panel();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.HeadPanel = new System.Windows.Forms.Panel();
            this.CollectionPanel = new System.Windows.Forms.Panel();
            this.GetStartedButton = new System.Windows.Forms.Button();
            this.CollectionsButton = new System.Windows.Forms.Button();
            this.InvoiceButton = new System.Windows.Forms.Button();
            this.StudentButton = new System.Windows.Forms.Button();
            this.ItemButton = new System.Windows.Forms.Button();
            this.TransactionButton = new System.Windows.Forms.Button();
            this.JournalEntryButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SpacePanel = new System.Windows.Forms.Panel();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.ReportButton = new System.Windows.Forms.Button();
            this.SetupButton = new System.Windows.Forms.Button();
            this.TopBarPanel.SuspendLayout();
            this.SideMenuPanel.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            this.CollectionPanel.SuspendLayout();
            this.SpacePanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TopBarPanel.Controls.Add(this.label1);
            this.TopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(971, 30);
            this.TopBarPanel.TabIndex = 0;
            this.TopBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBarPanel_MouseMove);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(948, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // SideMenuPanel
            // 
            this.SideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(42)))));
            this.SideMenuPanel.Controls.Add(this.ButtonPanel);
            this.SideMenuPanel.Controls.Add(this.SpacePanel);
            this.SideMenuPanel.Controls.Add(this.TitlePanel);
            this.SideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenuPanel.Location = new System.Drawing.Point(0, 30);
            this.SideMenuPanel.Name = "SideMenuPanel";
            this.SideMenuPanel.Size = new System.Drawing.Size(171, 488);
            this.SideMenuPanel.TabIndex = 1;
            // 
            // DashboardButton
            // 
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
            this.DashboardButton.UseVisualStyleBackColor = true;
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(42)))));
            this.TitlePanel.Controls.Add(this.label2);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(171, 48);
            this.TitlePanel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "PCHS";
            // 
            // HeadPanel
            // 
            this.HeadPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadPanel.Location = new System.Drawing.Point(171, 30);
            this.HeadPanel.Name = "HeadPanel";
            this.HeadPanel.Size = new System.Drawing.Size(800, 48);
            this.HeadPanel.TabIndex = 2;
            // 
            // CollectionPanel
            // 
            this.CollectionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(42)))));
            this.CollectionPanel.Controls.Add(this.JournalEntryButton);
            this.CollectionPanel.Controls.Add(this.TransactionButton);
            this.CollectionPanel.Controls.Add(this.ItemButton);
            this.CollectionPanel.Controls.Add(this.StudentButton);
            this.CollectionPanel.Controls.Add(this.InvoiceButton);
            this.CollectionPanel.Controls.Add(this.CollectionsButton);
            this.CollectionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CollectionPanel.Location = new System.Drawing.Point(0, 54);
            this.CollectionPanel.Name = "CollectionPanel";
            this.CollectionPanel.Size = new System.Drawing.Size(171, 27);
            this.CollectionPanel.TabIndex = 6;
            // 
            // GetStartedButton
            // 
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
            this.GetStartedButton.UseVisualStyleBackColor = true;
            // 
            // CollectionsButton
            // 
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
            this.CollectionsButton.UseVisualStyleBackColor = true;
            this.CollectionsButton.Click += new System.EventHandler(this.CollectionsBtn_Click);
            // 
            // InvoiceButton
            // 
            this.InvoiceButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.InvoiceButton.FlatAppearance.BorderSize = 0;
            this.InvoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InvoiceButton.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceButton.ForeColor = System.Drawing.Color.White;
            this.InvoiceButton.Location = new System.Drawing.Point(0, 27);
            this.InvoiceButton.Name = "InvoiceButton";
            this.InvoiceButton.Size = new System.Drawing.Size(171, 27);
            this.InvoiceButton.TabIndex = 10;
            this.InvoiceButton.Text = "Invoices";
            this.InvoiceButton.UseVisualStyleBackColor = true;
            // 
            // StudentButton
            // 
            this.StudentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.StudentButton.FlatAppearance.BorderSize = 0;
            this.StudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentButton.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentButton.ForeColor = System.Drawing.Color.White;
            this.StudentButton.Location = new System.Drawing.Point(0, 54);
            this.StudentButton.Name = "StudentButton";
            this.StudentButton.Size = new System.Drawing.Size(171, 27);
            this.StudentButton.TabIndex = 11;
            this.StudentButton.Text = "Students";
            this.StudentButton.UseVisualStyleBackColor = true;
            // 
            // ItemButton
            // 
            this.ItemButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ItemButton.FlatAppearance.BorderSize = 0;
            this.ItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemButton.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemButton.ForeColor = System.Drawing.Color.White;
            this.ItemButton.Location = new System.Drawing.Point(0, 81);
            this.ItemButton.Name = "ItemButton";
            this.ItemButton.Size = new System.Drawing.Size(171, 27);
            this.ItemButton.TabIndex = 12;
            this.ItemButton.Text = "Items";
            this.ItemButton.UseVisualStyleBackColor = true;
            // 
            // TransactionButton
            // 
            this.TransactionButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.TransactionButton.FlatAppearance.BorderSize = 0;
            this.TransactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionButton.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionButton.ForeColor = System.Drawing.Color.White;
            this.TransactionButton.Location = new System.Drawing.Point(0, 108);
            this.TransactionButton.Name = "TransactionButton";
            this.TransactionButton.Size = new System.Drawing.Size(171, 27);
            this.TransactionButton.TabIndex = 13;
            this.TransactionButton.Text = "Transactions";
            this.TransactionButton.UseVisualStyleBackColor = true;
            // 
            // JournalEntryButton
            // 
            this.JournalEntryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.JournalEntryButton.FlatAppearance.BorderSize = 0;
            this.JournalEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JournalEntryButton.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JournalEntryButton.ForeColor = System.Drawing.Color.White;
            this.JournalEntryButton.Location = new System.Drawing.Point(0, 135);
            this.JournalEntryButton.Name = "JournalEntryButton";
            this.JournalEntryButton.Size = new System.Drawing.Size(171, 27);
            this.JournalEntryButton.TabIndex = 14;
            this.JournalEntryButton.Text = "Journal Entry";
            this.JournalEntryButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Menu";
            // 
            // SpacePanel
            // 
            this.SpacePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(42)))));
            this.SpacePanel.Controls.Add(this.label4);
            this.SpacePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SpacePanel.Location = new System.Drawing.Point(0, 48);
            this.SpacePanel.Name = "SpacePanel";
            this.SpacePanel.Size = new System.Drawing.Size(171, 89);
            this.SpacePanel.TabIndex = 7;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(42)))));
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
            // ReportButton
            // 
            this.ReportButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReportButton.FlatAppearance.BorderSize = 0;
            this.ReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportButton.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportButton.ForeColor = System.Drawing.Color.White;
            this.ReportButton.Location = new System.Drawing.Point(0, 81);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(171, 27);
            this.ReportButton.TabIndex = 9;
            this.ReportButton.Text = "Reports";
            this.ReportButton.UseVisualStyleBackColor = true;
            // 
            // SetupButton
            // 
            this.SetupButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SetupButton.FlatAppearance.BorderSize = 0;
            this.SetupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetupButton.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetupButton.ForeColor = System.Drawing.Color.White;
            this.SetupButton.Location = new System.Drawing.Point(0, 108);
            this.SetupButton.Name = "SetupButton";
            this.SetupButton.Size = new System.Drawing.Size(171, 27);
            this.SetupButton.TabIndex = 10;
            this.SetupButton.Text = "Setup";
            this.SetupButton.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 518);
            this.Controls.Add(this.HeadPanel);
            this.Controls.Add(this.SideMenuPanel);
            this.Controls.Add(this.TopBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
            this.SideMenuPanel.ResumeLayout(false);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.CollectionPanel.ResumeLayout(false);
            this.SpacePanel.ResumeLayout(false);
            this.SpacePanel.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Panel SideMenuPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel HeadPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DashboardButton;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Panel CollectionPanel;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button SetupButton;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button JournalEntryButton;
        private System.Windows.Forms.Button TransactionButton;
        private System.Windows.Forms.Button ItemButton;
        private System.Windows.Forms.Button StudentButton;
        private System.Windows.Forms.Button InvoiceButton;
        private System.Windows.Forms.Button CollectionsButton;
        private System.Windows.Forms.Button GetStartedButton;
        private System.Windows.Forms.Panel SpacePanel;
        private System.Windows.Forms.Label label4;
    }
}