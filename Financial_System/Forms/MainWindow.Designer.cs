
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
            this.statusTable = new System.Windows.Forms.DataGridView();
            this.entryListTab = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.DateHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DebitHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBox2 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBox3 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.MainTabControl.SuspendLayout();
            this.dashboardTab.SuspendLayout();
            this.ledgerTab.SuspendLayout();
            this.SalesTabControl.SuspendLayout();
            this.jeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusTable)).BeginInit();
            this.materialCard1.SuspendLayout();
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
            this.MainTabControl.Size = new System.Drawing.Size(916, 527);
            this.MainTabControl.TabIndex = 0;
            // 
            // dashboardTab
            // 
            this.dashboardTab.Controls.Add(this.TestBtn);
            this.dashboardTab.ImageKey = "18064451721543238917-128.png";
            this.dashboardTab.Location = new System.Drawing.Point(4, 23);
            this.dashboardTab.Name = "dashboardTab";
            this.dashboardTab.Padding = new System.Windows.Forms.Padding(3);
            this.dashboardTab.Size = new System.Drawing.Size(792, 473);
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
            this.ledgerTab.Size = new System.Drawing.Size(908, 500);
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
            this.SalesTabControl.Size = new System.Drawing.Size(902, 467);
            this.SalesTabControl.TabIndex = 1;
            // 
            // jeTab
            // 
            this.jeTab.Controls.Add(this.materialCard1);
            this.jeTab.Controls.Add(this.statusTable);
            this.jeTab.Location = new System.Drawing.Point(4, 22);
            this.jeTab.Name = "jeTab";
            this.jeTab.Padding = new System.Windows.Forms.Padding(3);
            this.jeTab.Size = new System.Drawing.Size(894, 441);
            this.jeTab.TabIndex = 0;
            this.jeTab.Text = "Journal Entry";
            this.jeTab.UseVisualStyleBackColor = true;
            // 
            // statusTable
            // 
            this.statusTable.AllowUserToAddRows = false;
            this.statusTable.AllowUserToDeleteRows = false;
            this.statusTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.statusTable.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.statusTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.statusTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.statusTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateHeader,
            this.AccountHeader,
            this.RefHeader,
            this.DebitHeader,
            this.CreditHeader});
            this.statusTable.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.statusTable.DefaultCellStyle = dataGridViewCellStyle10;
            this.statusTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statusTable.Location = new System.Drawing.Point(3, 3);
            this.statusTable.MultiSelect = false;
            this.statusTable.Name = "statusTable";
            this.statusTable.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.statusTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.statusTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.statusTable.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.statusTable.Size = new System.Drawing.Size(888, 269);
            this.statusTable.TabIndex = 0;
            // 
            // entryListTab
            // 
            this.entryListTab.Location = new System.Drawing.Point(4, 22);
            this.entryListTab.Name = "entryListTab";
            this.entryListTab.Padding = new System.Windows.Forms.Padding(3);
            this.entryListTab.Size = new System.Drawing.Size(778, 414);
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
            this.materialTabSelector1.Size = new System.Drawing.Size(902, 27);
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
            // materialCard1
            // 
            this.materialCard1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialTextBox2);
            this.materialCard1.Controls.Add(this.materialComboBox1);
            this.materialCard1.Controls.Add(this.materialTextBox1);
            this.materialCard1.Controls.Add(this.materialComboBox2);
            this.materialCard1.Controls.Add(this.materialComboBox3);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 272);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(888, 166);
            this.materialCard1.TabIndex = 1;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox1.Hint = "Date";
            this.materialTextBox1.Location = new System.Drawing.Point(17, 16);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(751, 36);
            this.materialTextBox1.TabIndex = 0;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.UseTallSize = false;
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 118;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.Hint = "Accounts";
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 29;
            this.materialComboBox1.Location = new System.Drawing.Point(17, 58);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(207, 35);
            this.materialComboBox1.TabIndex = 1;
            this.materialComboBox1.UseTallSize = false;
            // 
            // materialComboBox2
            // 
            this.materialComboBox2.AutoResize = false;
            this.materialComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox2.Depth = 0;
            this.materialComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox2.DropDownHeight = 118;
            this.materialComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox2.DropDownWidth = 121;
            this.materialComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox2.FormattingEnabled = true;
            this.materialComboBox2.Hint = "Ref. Type";
            this.materialComboBox2.IntegralHeight = false;
            this.materialComboBox2.ItemHeight = 29;
            this.materialComboBox2.Location = new System.Drawing.Point(230, 58);
            this.materialComboBox2.MaxDropDownItems = 4;
            this.materialComboBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox2.Name = "materialComboBox2";
            this.materialComboBox2.Size = new System.Drawing.Size(197, 35);
            this.materialComboBox2.TabIndex = 2;
            this.materialComboBox2.UseTallSize = false;
            // 
            // materialComboBox3
            // 
            this.materialComboBox3.AutoResize = false;
            this.materialComboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox3.Depth = 0;
            this.materialComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox3.DropDownHeight = 118;
            this.materialComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox3.DropDownWidth = 121;
            this.materialComboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox3.FormattingEnabled = true;
            this.materialComboBox3.Hint = "Debit/Credit";
            this.materialComboBox3.IntegralHeight = false;
            this.materialComboBox3.ItemHeight = 29;
            this.materialComboBox3.Location = new System.Drawing.Point(433, 58);
            this.materialComboBox3.MaxDropDownItems = 4;
            this.materialComboBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox3.Name = "materialComboBox3";
            this.materialComboBox3.Size = new System.Drawing.Size(156, 35);
            this.materialComboBox3.TabIndex = 3;
            this.materialComboBox3.UseTallSize = false;
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBox2.Hint = "Value";
            this.materialTextBox2.Location = new System.Drawing.Point(595, 58);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(173, 36);
            this.materialTextBox2.TabIndex = 4;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.UseTallSize = false;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 527);
            this.Controls.Add(this.MainTabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.MainTabControl;
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCHS Finance System";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.MainTabControl.ResumeLayout(false);
            this.dashboardTab.ResumeLayout(false);
            this.dashboardTab.PerformLayout();
            this.ledgerTab.ResumeLayout(false);
            this.SalesTabControl.ResumeLayout(false);
            this.jeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusTable)).EndInit();
            this.materialCard1.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView statusTable;
        private MaterialSkin.Controls.MaterialButton TestBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn DebitHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditHeader;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox2;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox3;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
    }
}

