
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.MainTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.dashboardTab = new System.Windows.Forms.TabPage();
            this.TestBtn = new MaterialSkin.Controls.MaterialButton();
            this.ledgerTab = new System.Windows.Forms.TabPage();
            this.SalesTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.jeTab = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.valueTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.accountsComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.dateTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.refTypeComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.debCredComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.JETable = new System.Windows.Forms.DataGridView();
            this.entryListTab = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.InsertBtn = new MaterialSkin.Controls.MaterialButton();
            this.DeleteBtn = new MaterialSkin.Controls.MaterialButton();
            this.totalLbl = new MaterialSkin.Controls.MaterialLabel();
            this.creditLbl = new MaterialSkin.Controls.MaterialLabel();
            this.balanceLbl = new MaterialSkin.Controls.MaterialLabel();
            this.DateHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DebitHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.MainTabControl.SuspendLayout();
            this.dashboardTab.SuspendLayout();
            this.ledgerTab.SuspendLayout();
            this.SalesTabControl.SuspendLayout();
            this.jeTab.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JETable)).BeginInit();
            this.materialCard2.SuspendLayout();
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
            this.TestBtn.Location = new System.Drawing.Point(344, 183);
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
            this.ledgerTab.Controls.Add(this.SalesTabControl);
            this.ledgerTab.Controls.Add(this.materialTabSelector1);
            this.ledgerTab.ImageKey = "12197944301543238863-128.png";
            this.ledgerTab.Location = new System.Drawing.Point(4, 23);
            this.ledgerTab.Name = "ledgerTab";
            this.ledgerTab.Padding = new System.Windows.Forms.Padding(3);
            this.ledgerTab.Size = new System.Drawing.Size(936, 535);
            this.ledgerTab.TabIndex = 1;
            this.ledgerTab.Text = "Ledger";
            this.ledgerTab.UseVisualStyleBackColor = true;
            // 
            // SalesTabControl
            // 
            this.SalesTabControl.Controls.Add(this.jeTab);
            this.SalesTabControl.Controls.Add(this.entryListTab);
            this.SalesTabControl.Depth = 0;
            this.SalesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesTabControl.Location = new System.Drawing.Point(3, 30);
            this.SalesTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.SalesTabControl.Multiline = true;
            this.SalesTabControl.Name = "SalesTabControl";
            this.SalesTabControl.SelectedIndex = 0;
            this.SalesTabControl.Size = new System.Drawing.Size(930, 502);
            this.SalesTabControl.TabIndex = 1;
            // 
            // jeTab
            // 
            this.jeTab.Controls.Add(this.materialCard1);
            this.jeTab.Controls.Add(this.JETable);
            this.jeTab.Location = new System.Drawing.Point(4, 22);
            this.jeTab.Name = "jeTab";
            this.jeTab.Padding = new System.Windows.Forms.Padding(3);
            this.jeTab.Size = new System.Drawing.Size(922, 476);
            this.jeTab.TabIndex = 0;
            this.jeTab.Text = "Journal Entry";
            this.jeTab.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            this.materialCard1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialButton1);
            this.materialCard1.Controls.Add(this.materialCard2);
            this.materialCard1.Controls.Add(this.descTextbox);
            this.materialCard1.Controls.Add(this.DeleteBtn);
            this.materialCard1.Controls.Add(this.InsertBtn);
            this.materialCard1.Controls.Add(this.valueTextBox);
            this.materialCard1.Controls.Add(this.accountsComboBox);
            this.materialCard1.Controls.Add(this.dateTextBox);
            this.materialCard1.Controls.Add(this.refTypeComboBox);
            this.materialCard1.Controls.Add(this.debCredComboBox);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 263);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(916, 210);
            this.materialCard1.TabIndex = 1;
            // 
            // valueTextBox
            // 
            this.valueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valueTextBox.Depth = 0;
            this.valueTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.valueTextBox.Hint = "Value";
            this.valueTextBox.Location = new System.Drawing.Point(275, 100);
            this.valueTextBox.MaxLength = 50;
            this.valueTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.valueTextBox.Multiline = false;
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(152, 36);
            this.valueTextBox.TabIndex = 4;
            this.valueTextBox.Text = "";
            this.valueTextBox.UseTallSize = false;
            // 
            // accountsComboBox
            // 
            this.accountsComboBox.AutoResize = false;
            this.accountsComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.accountsComboBox.Depth = 0;
            this.accountsComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.accountsComboBox.DropDownHeight = 118;
            this.accountsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountsComboBox.DropDownWidth = 121;
            this.accountsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.accountsComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.accountsComboBox.FormattingEnabled = true;
            this.accountsComboBox.Hint = "Accounts";
            this.accountsComboBox.IntegralHeight = false;
            this.accountsComboBox.ItemHeight = 29;
            this.accountsComboBox.Items.AddRange(new object[] {
            "Cash",
            "Bank",
            "Online"});
            this.accountsComboBox.Location = new System.Drawing.Point(17, 59);
            this.accountsComboBox.MaxDropDownItems = 4;
            this.accountsComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.accountsComboBox.Name = "accountsComboBox";
            this.accountsComboBox.Size = new System.Drawing.Size(207, 35);
            this.accountsComboBox.TabIndex = 1;
            this.accountsComboBox.UseTallSize = false;
            // 
            // dateTextBox
            // 
            this.dateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateTextBox.Depth = 0;
            this.dateTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.dateTextBox.Hint = "Date";
            this.dateTextBox.Location = new System.Drawing.Point(17, 17);
            this.dateTextBox.MaxLength = 50;
            this.dateTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.dateTextBox.Multiline = false;
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(207, 36);
            this.dateTextBox.TabIndex = 0;
            this.dateTextBox.Text = "";
            this.dateTextBox.UseTallSize = false;
            // 
            // refTypeComboBox
            // 
            this.refTypeComboBox.AutoResize = false;
            this.refTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.refTypeComboBox.Depth = 0;
            this.refTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.refTypeComboBox.DropDownHeight = 118;
            this.refTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.refTypeComboBox.DropDownWidth = 121;
            this.refTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.refTypeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.refTypeComboBox.FormattingEnabled = true;
            this.refTypeComboBox.Hint = "Ref. Type";
            this.refTypeComboBox.IntegralHeight = false;
            this.refTypeComboBox.ItemHeight = 29;
            this.refTypeComboBox.Items.AddRange(new object[] {
            "JV",
            "SV",
            "GL"});
            this.refTypeComboBox.Location = new System.Drawing.Point(230, 18);
            this.refTypeComboBox.MaxDropDownItems = 4;
            this.refTypeComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.refTypeComboBox.Name = "refTypeComboBox";
            this.refTypeComboBox.Size = new System.Drawing.Size(197, 35);
            this.refTypeComboBox.TabIndex = 2;
            this.refTypeComboBox.UseTallSize = false;
            // 
            // debCredComboBox
            // 
            this.debCredComboBox.AutoResize = false;
            this.debCredComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.debCredComboBox.Depth = 0;
            this.debCredComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.debCredComboBox.DropDownHeight = 118;
            this.debCredComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.debCredComboBox.DropDownWidth = 121;
            this.debCredComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.debCredComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.debCredComboBox.FormattingEnabled = true;
            this.debCredComboBox.Hint = "Debit/Credit";
            this.debCredComboBox.IntegralHeight = false;
            this.debCredComboBox.ItemHeight = 29;
            this.debCredComboBox.Location = new System.Drawing.Point(230, 59);
            this.debCredComboBox.MaxDropDownItems = 4;
            this.debCredComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.debCredComboBox.Name = "debCredComboBox";
            this.debCredComboBox.Size = new System.Drawing.Size(197, 35);
            this.debCredComboBox.TabIndex = 3;
            this.debCredComboBox.UseTallSize = false;
            // 
            // JETable
            // 
            this.JETable.AllowUserToAddRows = false;
            this.JETable.AllowUserToDeleteRows = false;
            this.JETable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.JETable.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.JETable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.JETable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.JETable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateHeader,
            this.AccountHeader,
            this.DescHeader,
            this.RefHeader,
            this.DebitHeader,
            this.CreditHeader});
            this.JETable.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.JETable.DefaultCellStyle = dataGridViewCellStyle10;
            this.JETable.Dock = System.Windows.Forms.DockStyle.Top;
            this.JETable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.JETable.Location = new System.Drawing.Point(3, 3);
            this.JETable.MultiSelect = false;
            this.JETable.Name = "JETable";
            this.JETable.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.JETable.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.JETable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.JETable.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.JETable.Size = new System.Drawing.Size(916, 252);
            this.JETable.TabIndex = 0;
            // 
            // entryListTab
            // 
            this.entryListTab.Location = new System.Drawing.Point(4, 22);
            this.entryListTab.Name = "entryListTab";
            this.entryListTab.Padding = new System.Windows.Forms.Padding(3);
            this.entryListTab.Size = new System.Drawing.Size(922, 476);
            this.entryListTab.TabIndex = 1;
            this.entryListTab.Text = "Entry List";
            this.entryListTab.UseVisualStyleBackColor = true;
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
            // InsertBtn
            // 
            this.InsertBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InsertBtn.Depth = 0;
            this.InsertBtn.DrawShadows = true;
            this.InsertBtn.HighEmphasis = true;
            this.InsertBtn.Icon = null;
            this.InsertBtn.Location = new System.Drawing.Point(275, 145);
            this.InsertBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.InsertBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(71, 36);
            this.InsertBtn.TabIndex = 5;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.InsertBtn.UseAccentColor = false;
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteBtn.Depth = 0;
            this.DeleteBtn.DrawShadows = true;
            this.DeleteBtn.HighEmphasis = true;
            this.DeleteBtn.Icon = null;
            this.DeleteBtn.Location = new System.Drawing.Point(354, 145);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(73, 36);
            this.DeleteBtn.TabIndex = 6;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DeleteBtn.UseAccentColor = false;
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Depth = 0;
            this.totalLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.totalLbl.Location = new System.Drawing.Point(17, 14);
            this.totalLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(42, 19);
            this.totalLbl.TabIndex = 7;
            this.totalLbl.Text = "Debit:";
            // 
            // creditLbl
            // 
            this.creditLbl.AutoSize = true;
            this.creditLbl.Depth = 0;
            this.creditLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.creditLbl.Location = new System.Drawing.Point(17, 42);
            this.creditLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.creditLbl.Name = "creditLbl";
            this.creditLbl.Size = new System.Drawing.Size(46, 19);
            this.creditLbl.TabIndex = 8;
            this.creditLbl.Text = "Credit:";
            // 
            // balanceLbl
            // 
            this.balanceLbl.AutoSize = true;
            this.balanceLbl.Depth = 0;
            this.balanceLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.balanceLbl.Location = new System.Drawing.Point(17, 67);
            this.balanceLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.balanceLbl.Name = "balanceLbl";
            this.balanceLbl.Size = new System.Drawing.Size(74, 19);
            this.balanceLbl.TabIndex = 9;
            this.balanceLbl.Text = "IsBalance:";
            // 
            // DateHeader
            // 
            this.DateHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateHeader.HeaderText = "Date";
            this.DateHeader.Name = "DateHeader";
            this.DateHeader.ReadOnly = true;
            // 
            // AccountHeader
            // 
            this.AccountHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AccountHeader.HeaderText = "Account";
            this.AccountHeader.Name = "AccountHeader";
            this.AccountHeader.ReadOnly = true;
            // 
            // DescHeader
            // 
            this.DescHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescHeader.HeaderText = "Description";
            this.DescHeader.Name = "DescHeader";
            this.DescHeader.ReadOnly = true;
            // 
            // RefHeader
            // 
            this.RefHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RefHeader.HeaderText = "Ref.";
            this.RefHeader.Name = "RefHeader";
            this.RefHeader.ReadOnly = true;
            // 
            // DebitHeader
            // 
            this.DebitHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DebitHeader.HeaderText = "Debit";
            this.DebitHeader.Name = "DebitHeader";
            this.DebitHeader.ReadOnly = true;
            // 
            // CreditHeader
            // 
            this.CreditHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CreditHeader.HeaderText = "Credit";
            this.CreditHeader.Name = "CreditHeader";
            this.CreditHeader.ReadOnly = true;
            // 
            // descTextbox
            // 
            this.descTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descTextbox.Depth = 0;
            this.descTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.descTextbox.Hint = "Description";
            this.descTextbox.Location = new System.Drawing.Point(17, 100);
            this.descTextbox.MaxLength = 50;
            this.descTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.descTextbox.Multiline = false;
            this.descTextbox.Name = "descTextbox";
            this.descTextbox.Size = new System.Drawing.Size(252, 36);
            this.descTextbox.TabIndex = 10;
            this.descTextbox.Text = "";
            this.descTextbox.UseTallSize = false;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.totalLbl);
            this.materialCard2.Controls.Add(this.creditLbl);
            this.materialCard2.Controls.Add(this.balanceLbl);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(444, 17);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(200, 100);
            this.materialCard2.TabIndex = 11;
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(773, 154);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(125, 36);
            this.materialButton1.TabIndex = 12;
            this.materialButton1.Text = "Submit Entry";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
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
            this.SalesTabControl.ResumeLayout(false);
            this.jeTab.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JETable)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl MainTabControl;
        private System.Windows.Forms.TabPage dashboardTab;
        private System.Windows.Forms.TabPage ledgerTab;
        private System.Windows.Forms.ImageList iconList;
        private MaterialSkin.Controls.MaterialTabControl SalesTabControl;
        private System.Windows.Forms.TabPage jeTab;
        private System.Windows.Forms.TabPage entryListTab;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.DataGridView JETable;
        private MaterialSkin.Controls.MaterialButton TestBtn;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox valueTextBox;
        private MaterialSkin.Controls.MaterialComboBox accountsComboBox;
        private MaterialSkin.Controls.MaterialComboBox refTypeComboBox;
        private MaterialSkin.Controls.MaterialComboBox debCredComboBox;
        private MaterialSkin.Controls.MaterialTextBox dateTextBox;
        private MaterialSkin.Controls.MaterialButton DeleteBtn;
        private MaterialSkin.Controls.MaterialButton InsertBtn;
        private MaterialSkin.Controls.MaterialLabel totalLbl;
        private MaterialSkin.Controls.MaterialLabel creditLbl;
        private MaterialSkin.Controls.MaterialLabel balanceLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn DebitHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditHeader;
        private MaterialSkin.Controls.MaterialTextBox descTextbox;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
    }
}

