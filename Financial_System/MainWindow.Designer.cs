
namespace Financial_System
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.MainTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.tabGeneralLedger = new System.Windows.Forms.TabPage();
            this.SalesTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.invoiceTab = new System.Windows.Forms.TabPage();
            this.invoiceFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.topMenuInvoice = new MaterialSkin.Controls.MaterialCard();
            this.newInvoiceBtn = new MaterialSkin.Controls.MaterialButton();
            this.customerTab = new System.Windows.Forms.TabPage();
            this.itemTab = new System.Windows.Forms.TabPage();
            this.paymentTab = new System.Windows.Forms.TabPage();
            this.journalEntryTab = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.MainTabControl.SuspendLayout();
            this.tabGeneralLedger.SuspendLayout();
            this.SalesTabControl.SuspendLayout();
            this.invoiceTab.SuspendLayout();
            this.topMenuInvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.tabDashboard);
            this.MainTabControl.Controls.Add(this.tabGeneralLedger);
            this.MainTabControl.Depth = 0;
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.ImageList = this.iconList;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainTabControl.Multiline = true;
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(800, 500);
            this.MainTabControl.TabIndex = 0;
            // 
            // tabDashboard
            // 
            this.tabDashboard.ImageKey = "18064451721543238917-128.png";
            this.tabDashboard.Location = new System.Drawing.Point(4, 23);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabDashboard.Size = new System.Drawing.Size(684, 375);
            this.tabDashboard.TabIndex = 0;
            this.tabDashboard.Text = "Dashboard";
            this.tabDashboard.UseVisualStyleBackColor = true;
            // 
            // tabGeneralLedger
            // 
            this.tabGeneralLedger.Controls.Add(this.SalesTabControl);
            this.tabGeneralLedger.Controls.Add(this.materialTabSelector1);
            this.tabGeneralLedger.ImageKey = "12197944301543238863-128.png";
            this.tabGeneralLedger.Location = new System.Drawing.Point(4, 23);
            this.tabGeneralLedger.Name = "tabGeneralLedger";
            this.tabGeneralLedger.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneralLedger.Size = new System.Drawing.Size(792, 473);
            this.tabGeneralLedger.TabIndex = 1;
            this.tabGeneralLedger.Text = "Sales";
            this.tabGeneralLedger.UseVisualStyleBackColor = true;
            // 
            // SalesTabControl
            // 
            this.SalesTabControl.Controls.Add(this.invoiceTab);
            this.SalesTabControl.Controls.Add(this.customerTab);
            this.SalesTabControl.Controls.Add(this.itemTab);
            this.SalesTabControl.Controls.Add(this.paymentTab);
            this.SalesTabControl.Controls.Add(this.journalEntryTab);
            this.SalesTabControl.Depth = 0;
            this.SalesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesTabControl.Location = new System.Drawing.Point(3, 30);
            this.SalesTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.SalesTabControl.Multiline = true;
            this.SalesTabControl.Name = "SalesTabControl";
            this.SalesTabControl.SelectedIndex = 0;
            this.SalesTabControl.Size = new System.Drawing.Size(786, 440);
            this.SalesTabControl.TabIndex = 1;
            // 
            // invoiceTab
            // 
            this.invoiceTab.Controls.Add(this.invoiceFlowPanel);
            this.invoiceTab.Controls.Add(this.topMenuInvoice);
            this.invoiceTab.Location = new System.Drawing.Point(4, 22);
            this.invoiceTab.Name = "invoiceTab";
            this.invoiceTab.Padding = new System.Windows.Forms.Padding(3);
            this.invoiceTab.Size = new System.Drawing.Size(778, 414);
            this.invoiceTab.TabIndex = 0;
            this.invoiceTab.Text = "Invoices";
            this.invoiceTab.UseVisualStyleBackColor = true;
            // 
            // invoiceFlowPanel
            // 
            this.invoiceFlowPanel.AutoScroll = true;
            this.invoiceFlowPanel.AutoSize = true;
            this.invoiceFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoiceFlowPanel.Location = new System.Drawing.Point(3, 52);
            this.invoiceFlowPanel.Name = "invoiceFlowPanel";
            this.invoiceFlowPanel.Size = new System.Drawing.Size(772, 359);
            this.invoiceFlowPanel.TabIndex = 1;
            // 
            // topMenuInvoice
            // 
            this.topMenuInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.topMenuInvoice.Controls.Add(this.newInvoiceBtn);
            this.topMenuInvoice.Depth = 0;
            this.topMenuInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.topMenuInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.topMenuInvoice.Location = new System.Drawing.Point(3, 3);
            this.topMenuInvoice.Margin = new System.Windows.Forms.Padding(14);
            this.topMenuInvoice.MouseState = MaterialSkin.MouseState.HOVER;
            this.topMenuInvoice.Name = "topMenuInvoice";
            this.topMenuInvoice.Padding = new System.Windows.Forms.Padding(14);
            this.topMenuInvoice.Size = new System.Drawing.Size(772, 49);
            this.topMenuInvoice.TabIndex = 0;
            // 
            // newInvoiceBtn
            // 
            this.newInvoiceBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.newInvoiceBtn.Depth = 0;
            this.newInvoiceBtn.DrawShadows = true;
            this.newInvoiceBtn.HighEmphasis = true;
            this.newInvoiceBtn.Icon = null;
            this.newInvoiceBtn.Location = new System.Drawing.Point(4, 6);
            this.newInvoiceBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.newInvoiceBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.newInvoiceBtn.Name = "newInvoiceBtn";
            this.newInvoiceBtn.Size = new System.Drawing.Size(114, 36);
            this.newInvoiceBtn.TabIndex = 1;
            this.newInvoiceBtn.Text = "New Invoice";
            this.newInvoiceBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.newInvoiceBtn.UseAccentColor = false;
            this.newInvoiceBtn.UseVisualStyleBackColor = true;
            // 
            // customerTab
            // 
            this.customerTab.Location = new System.Drawing.Point(4, 22);
            this.customerTab.Name = "customerTab";
            this.customerTab.Padding = new System.Windows.Forms.Padding(3);
            this.customerTab.Size = new System.Drawing.Size(725, 316);
            this.customerTab.TabIndex = 1;
            this.customerTab.Text = "Customers";
            this.customerTab.UseVisualStyleBackColor = true;
            // 
            // itemTab
            // 
            this.itemTab.Location = new System.Drawing.Point(4, 22);
            this.itemTab.Name = "itemTab";
            this.itemTab.Size = new System.Drawing.Size(725, 316);
            this.itemTab.TabIndex = 2;
            this.itemTab.Text = "Items";
            this.itemTab.UseVisualStyleBackColor = true;
            // 
            // paymentTab
            // 
            this.paymentTab.Location = new System.Drawing.Point(4, 22);
            this.paymentTab.Name = "paymentTab";
            this.paymentTab.Size = new System.Drawing.Size(725, 316);
            this.paymentTab.TabIndex = 3;
            this.paymentTab.Text = "Payments";
            this.paymentTab.UseVisualStyleBackColor = true;
            // 
            // journalEntryTab
            // 
            this.journalEntryTab.Location = new System.Drawing.Point(4, 22);
            this.journalEntryTab.Name = "journalEntryTab";
            this.journalEntryTab.Size = new System.Drawing.Size(725, 316);
            this.journalEntryTab.TabIndex = 4;
            this.journalEntryTab.Text = "Journal Entry";
            this.journalEntryTab.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.SalesTabControl;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(3, 3);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(786, 27);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "18064451721543238917-128.png");
            this.iconList.Images.SetKeyName(1, "12197944301543238863-128.png");
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.MainTabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.MainTabControl;
            this.MaximizeBox = false;
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCHS Finance System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.MainTabControl.ResumeLayout(false);
            this.tabGeneralLedger.ResumeLayout(false);
            this.SalesTabControl.ResumeLayout(false);
            this.invoiceTab.ResumeLayout(false);
            this.invoiceTab.PerformLayout();
            this.topMenuInvoice.ResumeLayout(false);
            this.topMenuInvoice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl MainTabControl;
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.TabPage tabGeneralLedger;
        private System.Windows.Forms.ImageList iconList;
        private MaterialSkin.Controls.MaterialTabControl SalesTabControl;
        private System.Windows.Forms.TabPage invoiceTab;
        private System.Windows.Forms.TabPage customerTab;
        private System.Windows.Forms.TabPage itemTab;
        private System.Windows.Forms.TabPage paymentTab;
        private System.Windows.Forms.TabPage journalEntryTab;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialCard topMenuInvoice;
        private MaterialSkin.Controls.MaterialButton newInvoiceBtn;
        private System.Windows.Forms.FlowLayoutPanel invoiceFlowPanel;
    }
}

