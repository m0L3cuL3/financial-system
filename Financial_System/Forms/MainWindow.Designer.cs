
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
            this.dashboardTab = new System.Windows.Forms.TabPage();
            this.TestBtn = new MaterialSkin.Controls.MaterialButton();
            this.ledgerTab = new System.Windows.Forms.TabPage();
            this.JELTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.GeneralLedgerTab = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.FullnameTxtBox = new System.Windows.Forms.TextBox();
            this.SIDTxtBox = new System.Windows.Forms.TextBox();
            this.TIDTxtBox = new System.Windows.Forms.TextBox();
            this.LIDTxtBox = new System.Windows.Forms.TextBox();
            this.filterLbl = new MaterialSkin.Controls.MaterialLabel();
            this.LedgerDgv = new System.Windows.Forms.DataGridView();
            this.LedgerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LedgerButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.StudentListTab = new System.Windows.Forms.TabPage();
            this.LoadStudentBtn = new MaterialSkin.Controls.MaterialButton();
            this.InsertStudentBtn = new MaterialSkin.Controls.MaterialButton();
            this.StudentDgv = new System.Windows.Forms.DataGridView();
            this.sid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.MainTabControl.SuspendLayout();
            this.dashboardTab.SuspendLayout();
            this.ledgerTab.SuspendLayout();
            this.JELTabControl.SuspendLayout();
            this.GeneralLedgerTab.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LedgerDgv)).BeginInit();
            this.StudentListTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.dashboardTab);
            this.MainTabControl.Controls.Add(this.ledgerTab);
            this.MainTabControl.Depth = 0;
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.ImageList = this.iconList;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainTabControl.Multiline = true;
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(944, 562);
            this.MainTabControl.TabIndex = 0;
            // 
            // dashboardTab
            // 
            this.dashboardTab.Controls.Add(this.TestBtn);
            this.dashboardTab.ImageKey = "18064451721543238917-128.png";
            this.dashboardTab.Location = new System.Drawing.Point(4, 23);
            this.dashboardTab.Name = "dashboardTab";
            this.dashboardTab.Padding = new System.Windows.Forms.Padding(3);
            this.dashboardTab.Size = new System.Drawing.Size(936, 535);
            this.dashboardTab.TabIndex = 0;
            this.dashboardTab.Text = "Dashboard";
            this.dashboardTab.UseVisualStyleBackColor = true;
            // 
            // TestBtn
            // 
            this.TestBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TestBtn.Depth = 0;
            this.TestBtn.DrawShadows = true;
            this.TestBtn.HighEmphasis = true;
            this.TestBtn.Icon = null;
            this.TestBtn.Location = new System.Drawing.Point(258, 71);
            this.TestBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TestBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.TestBtn.Name = "TestBtn";
            this.TestBtn.Size = new System.Drawing.Size(124, 36);
            this.TestBtn.TabIndex = 0;
            this.TestBtn.Text = "Create Table";
            this.TestBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.TestBtn.UseAccentColor = false;
            this.TestBtn.UseVisualStyleBackColor = true;
            this.TestBtn.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // ledgerTab
            // 
            this.ledgerTab.Controls.Add(this.JELTabControl);
            this.ledgerTab.Controls.Add(this.materialTabSelector1);
            this.ledgerTab.ImageKey = "12197944301543238863-128.png";
            this.ledgerTab.Location = new System.Drawing.Point(4, 23);
            this.ledgerTab.Name = "ledgerTab";
            this.ledgerTab.Padding = new System.Windows.Forms.Padding(3);
            this.ledgerTab.Size = new System.Drawing.Size(936, 535);
            this.ledgerTab.TabIndex = 1;
            this.ledgerTab.Text = "Journal & Ledger";
            this.ledgerTab.UseVisualStyleBackColor = true;
            // 
            // JELTabControl
            // 
            this.JELTabControl.Controls.Add(this.GeneralLedgerTab);
            this.JELTabControl.Controls.Add(this.StudentListTab);
            this.JELTabControl.Depth = 0;
            this.JELTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JELTabControl.Location = new System.Drawing.Point(3, 30);
            this.JELTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.JELTabControl.Multiline = true;
            this.JELTabControl.Name = "JELTabControl";
            this.JELTabControl.SelectedIndex = 0;
            this.JELTabControl.Size = new System.Drawing.Size(930, 502);
            this.JELTabControl.TabIndex = 1;
            // 
            // GeneralLedgerTab
            // 
            this.GeneralLedgerTab.Controls.Add(this.materialCard1);
            this.GeneralLedgerTab.Controls.Add(this.LedgerDgv);
            this.GeneralLedgerTab.Location = new System.Drawing.Point(4, 22);
            this.GeneralLedgerTab.Name = "GeneralLedgerTab";
            this.GeneralLedgerTab.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralLedgerTab.Size = new System.Drawing.Size(922, 476);
            this.GeneralLedgerTab.TabIndex = 2;
            this.GeneralLedgerTab.Text = "General Ledger";
            this.GeneralLedgerTab.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.button4);
            this.materialCard1.Controls.Add(this.button3);
            this.materialCard1.Controls.Add(this.button2);
            this.materialCard1.Controls.Add(this.button1);
            this.materialCard1.Controls.Add(this.FullnameTxtBox);
            this.materialCard1.Controls.Add(this.SIDTxtBox);
            this.materialCard1.Controls.Add(this.TIDTxtBox);
            this.materialCard1.Controls.Add(this.LIDTxtBox);
            this.materialCard1.Controls.Add(this.filterLbl);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 285);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(410, 174);
            this.materialCard1.TabIndex = 1;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel4.HighEmphasis = true;
            this.materialLabel4.Location = new System.Drawing.Point(17, 124);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(68, 14);
            this.materialLabel4.TabIndex = 20;
            this.materialLabel4.Text = "By Fullname";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel3.HighEmphasis = true;
            this.materialLabel3.Location = new System.Drawing.Point(17, 98);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(73, 14);
            this.materialLabel3.TabIndex = 19;
            this.materialLabel3.Text = "By Student ID";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel2.HighEmphasis = true;
            this.materialLabel2.Location = new System.Drawing.Point(17, 72);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(96, 14);
            this.materialLabel2.TabIndex = 18;
            this.materialLabel2.Text = "By Transaction ID";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel1.HighEmphasis = true;
            this.materialLabel1.Location = new System.Drawing.Point(17, 46);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(67, 14);
            this.materialLabel1.TabIndex = 17;
            this.materialLabel1.Text = "By Ledger ID";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(319, 119);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(319, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FullnameTxtBox
            // 
            this.FullnameTxtBox.Location = new System.Drawing.Point(126, 121);
            this.FullnameTxtBox.Name = "FullnameTxtBox";
            this.FullnameTxtBox.Size = new System.Drawing.Size(187, 20);
            this.FullnameTxtBox.TabIndex = 12;
            // 
            // SIDTxtBox
            // 
            this.SIDTxtBox.Location = new System.Drawing.Point(126, 95);
            this.SIDTxtBox.Name = "SIDTxtBox";
            this.SIDTxtBox.Size = new System.Drawing.Size(187, 20);
            this.SIDTxtBox.TabIndex = 11;
            // 
            // TIDTxtBox
            // 
            this.TIDTxtBox.Location = new System.Drawing.Point(126, 69);
            this.TIDTxtBox.Name = "TIDTxtBox";
            this.TIDTxtBox.Size = new System.Drawing.Size(187, 20);
            this.TIDTxtBox.TabIndex = 10;
            // 
            // LIDTxtBox
            // 
            this.LIDTxtBox.Location = new System.Drawing.Point(126, 43);
            this.LIDTxtBox.Name = "LIDTxtBox";
            this.LIDTxtBox.Size = new System.Drawing.Size(187, 20);
            this.LIDTxtBox.TabIndex = 1;
            // 
            // filterLbl
            // 
            this.filterLbl.AutoSize = true;
            this.filterLbl.Depth = 0;
            this.filterLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.filterLbl.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.filterLbl.HighEmphasis = true;
            this.filterLbl.Location = new System.Drawing.Point(17, 11);
            this.filterLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.filterLbl.Name = "filterLbl";
            this.filterLbl.Size = new System.Drawing.Size(35, 17);
            this.filterLbl.TabIndex = 0;
            this.filterLbl.Text = "Filter";
            // 
            // LedgerDgv
            // 
            this.LedgerDgv.AllowUserToAddRows = false;
            this.LedgerDgv.AllowUserToDeleteRows = false;
            this.LedgerDgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.LedgerDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LedgerDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LedgerID,
            this.TransactionID,
            this.StudentID,
            this.Fullname,
            this.LedgerButton});
            this.LedgerDgv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LedgerDgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.LedgerDgv.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LedgerDgv.Location = new System.Drawing.Point(3, 3);
            this.LedgerDgv.MultiSelect = false;
            this.LedgerDgv.Name = "LedgerDgv";
            this.LedgerDgv.ReadOnly = true;
            this.LedgerDgv.ShowEditingIcon = false;
            this.LedgerDgv.Size = new System.Drawing.Size(916, 265);
            this.LedgerDgv.TabIndex = 0;
            this.LedgerDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LedgerDgv_CellContentClick);
            // 
            // LedgerID
            // 
            this.LedgerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LedgerID.HeaderText = "Ledger ID";
            this.LedgerID.Name = "LedgerID";
            this.LedgerID.ReadOnly = true;
            this.LedgerID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TransactionID
            // 
            this.TransactionID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TransactionID.HeaderText = "Transaction ID";
            this.TransactionID.Name = "TransactionID";
            this.TransactionID.ReadOnly = true;
            this.TransactionID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // StudentID
            // 
            this.StudentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentID.HeaderText = "Student ID";
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            this.StudentID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Fullname
            // 
            this.Fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fullname.HeaderText = "Fullname";
            this.Fullname.Name = "Fullname";
            this.Fullname.ReadOnly = true;
            this.Fullname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // LedgerButton
            // 
            this.LedgerButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LedgerButton.HeaderText = "Ledger";
            this.LedgerButton.Name = "LedgerButton";
            this.LedgerButton.ReadOnly = true;
            this.LedgerButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.LedgerButton.Text = "view transactions";
            this.LedgerButton.UseColumnTextForButtonValue = true;
            // 
            // StudentListTab
            // 
            this.StudentListTab.Controls.Add(this.LoadStudentBtn);
            this.StudentListTab.Controls.Add(this.InsertStudentBtn);
            this.StudentListTab.Controls.Add(this.StudentDgv);
            this.StudentListTab.Location = new System.Drawing.Point(4, 22);
            this.StudentListTab.Name = "StudentListTab";
            this.StudentListTab.Padding = new System.Windows.Forms.Padding(3);
            this.StudentListTab.Size = new System.Drawing.Size(922, 476);
            this.StudentListTab.TabIndex = 3;
            this.StudentListTab.Text = "Student List";
            this.StudentListTab.UseVisualStyleBackColor = true;
            // 
            // LoadStudentBtn
            // 
            this.LoadStudentBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoadStudentBtn.Depth = 0;
            this.LoadStudentBtn.DrawShadows = true;
            this.LoadStudentBtn.HighEmphasis = true;
            this.LoadStudentBtn.Icon = null;
            this.LoadStudentBtn.Location = new System.Drawing.Point(7, 349);
            this.LoadStudentBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LoadStudentBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoadStudentBtn.Name = "LoadStudentBtn";
            this.LoadStudentBtn.Size = new System.Drawing.Size(169, 36);
            this.LoadStudentBtn.TabIndex = 4;
            this.LoadStudentBtn.Text = "Load Student Data";
            this.LoadStudentBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.LoadStudentBtn.UseAccentColor = false;
            this.LoadStudentBtn.UseVisualStyleBackColor = true;
            this.LoadStudentBtn.Click += new System.EventHandler(this.LoadStudentBtn_Click);
            // 
            // InsertStudentBtn
            // 
            this.InsertStudentBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InsertStudentBtn.Depth = 0;
            this.InsertStudentBtn.DrawShadows = true;
            this.InsertStudentBtn.HighEmphasis = true;
            this.InsertStudentBtn.Icon = null;
            this.InsertStudentBtn.Location = new System.Drawing.Point(7, 301);
            this.InsertStudentBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.InsertStudentBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.InsertStudentBtn.Name = "InsertStudentBtn";
            this.InsertStudentBtn.Size = new System.Drawing.Size(182, 36);
            this.InsertStudentBtn.TabIndex = 3;
            this.InsertStudentBtn.Text = "Insert Student Data";
            this.InsertStudentBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.InsertStudentBtn.UseAccentColor = false;
            this.InsertStudentBtn.UseVisualStyleBackColor = true;
            this.InsertStudentBtn.Click += new System.EventHandler(this.InsertStudentBtn_Click);
            // 
            // StudentDgv
            // 
            this.StudentDgv.AllowUserToAddRows = false;
            this.StudentDgv.AllowUserToDeleteRows = false;
            this.StudentDgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.StudentDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sid,
            this.fname,
            this.midname,
            this.Surname,
            this.Section,
            this.YearLevel});
            this.StudentDgv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudentDgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.StudentDgv.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StudentDgv.Location = new System.Drawing.Point(3, 3);
            this.StudentDgv.MultiSelect = false;
            this.StudentDgv.Name = "StudentDgv";
            this.StudentDgv.ReadOnly = true;
            this.StudentDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentDgv.ShowEditingIcon = false;
            this.StudentDgv.Size = new System.Drawing.Size(916, 289);
            this.StudentDgv.TabIndex = 1;
            // 
            // sid
            // 
            this.sid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sid.HeaderText = "Student ID";
            this.sid.Name = "sid";
            this.sid.ReadOnly = true;
            this.sid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // fname
            // 
            this.fname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fname.HeaderText = "First Name";
            this.fname.Name = "fname";
            this.fname.ReadOnly = true;
            this.fname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // midname
            // 
            this.midname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.midname.HeaderText = "Middle Name";
            this.midname.Name = "midname";
            this.midname.ReadOnly = true;
            this.midname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Surname
            // 
            this.Surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            this.Surname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Section
            // 
            this.Section.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Section.HeaderText = "Section";
            this.Section.Name = "Section";
            this.Section.ReadOnly = true;
            this.Section.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // YearLevel
            // 
            this.YearLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.YearLevel.HeaderText = "Year Level";
            this.YearLevel.Name = "YearLevel";
            this.YearLevel.ReadOnly = true;
            this.YearLevel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.JELTabControl;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(3, 3);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(930, 27);
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
            this.ClientSize = new System.Drawing.Size(944, 562);
            this.Controls.Add(this.MainTabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.MainTabControl;
            this.MaximizeBox = false;
            this.Name = "mainWindow";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCHS Finance System";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.MainTabControl.ResumeLayout(false);
            this.dashboardTab.ResumeLayout(false);
            this.dashboardTab.PerformLayout();
            this.ledgerTab.ResumeLayout(false);
            this.JELTabControl.ResumeLayout(false);
            this.GeneralLedgerTab.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LedgerDgv)).EndInit();
            this.StudentListTab.ResumeLayout(false);
            this.StudentListTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl MainTabControl;
        private System.Windows.Forms.TabPage dashboardTab;
        private System.Windows.Forms.TabPage ledgerTab;
        private System.Windows.Forms.ImageList iconList;
        private MaterialSkin.Controls.MaterialTabControl JELTabControl;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialButton TestBtn;
        private System.Windows.Forms.TabPage GeneralLedgerTab;
        private System.Windows.Forms.TabPage StudentListTab;
        private System.Windows.Forms.DataGridView LedgerDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn LedgerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewButtonColumn LedgerButton;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel filterLbl;
        private System.Windows.Forms.TextBox LIDTxtBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox FullnameTxtBox;
        private System.Windows.Forms.TextBox SIDTxtBox;
        private System.Windows.Forms.TextBox TIDTxtBox;
        private System.Windows.Forms.DataGridView StudentDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn sid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn midname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearLevel;
        private MaterialSkin.Controls.MaterialButton LoadStudentBtn;
        private MaterialSkin.Controls.MaterialButton InsertStudentBtn;
    }
}

