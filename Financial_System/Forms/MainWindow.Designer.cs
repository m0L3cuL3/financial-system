
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.MainTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.dashboardTab = new System.Windows.Forms.TabPage();
            this.studentTransTab = new System.Windows.Forms.TabPage();
            this.SalesTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.studentStatusTab = new System.Windows.Forms.TabPage();
            this.statusTable = new System.Windows.Forms.DataGridView();
            this.LRNHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentNameHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LevelHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuarterHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueTab = new System.Windows.Forms.TabPage();
            this.reportTab = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.TestBtn = new MaterialSkin.Controls.MaterialButton();
            this.MainTabControl.SuspendLayout();
            this.dashboardTab.SuspendLayout();
            this.studentTransTab.SuspendLayout();
            this.SalesTabControl.SuspendLayout();
            this.studentStatusTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusTable)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.dashboardTab);
            this.MainTabControl.Controls.Add(this.studentTransTab);
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
            // studentTransTab
            // 
            this.studentTransTab.Controls.Add(this.SalesTabControl);
            this.studentTransTab.Controls.Add(this.materialTabSelector1);
            this.studentTransTab.ImageKey = "12197944301543238863-128.png";
            this.studentTransTab.Location = new System.Drawing.Point(4, 23);
            this.studentTransTab.Name = "studentTransTab";
            this.studentTransTab.Padding = new System.Windows.Forms.Padding(3);
            this.studentTransTab.Size = new System.Drawing.Size(792, 473);
            this.studentTransTab.TabIndex = 1;
            this.studentTransTab.Text = "Student Transactions";
            this.studentTransTab.UseVisualStyleBackColor = true;
            // 
            // SalesTabControl
            // 
            this.SalesTabControl.Controls.Add(this.studentStatusTab);
            this.SalesTabControl.Controls.Add(this.dueTab);
            this.SalesTabControl.Controls.Add(this.reportTab);
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
            // studentStatusTab
            // 
            this.studentStatusTab.Controls.Add(this.statusTable);
            this.studentStatusTab.Location = new System.Drawing.Point(4, 22);
            this.studentStatusTab.Name = "studentStatusTab";
            this.studentStatusTab.Padding = new System.Windows.Forms.Padding(3);
            this.studentStatusTab.Size = new System.Drawing.Size(778, 414);
            this.studentStatusTab.TabIndex = 0;
            this.studentStatusTab.Text = "Student Status";
            this.studentStatusTab.UseVisualStyleBackColor = true;
            // 
            // statusTable
            // 
            this.statusTable.AllowUserToAddRows = false;
            this.statusTable.AllowUserToDeleteRows = false;
            this.statusTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.statusTable.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.statusTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.statusTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.statusTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LRNHeader,
            this.StudentNameHeader,
            this.SectionHeader,
            this.LevelHeader,
            this.QuarterHeader,
            this.StatusHeader});
            this.statusTable.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.statusTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.statusTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statusTable.Location = new System.Drawing.Point(3, 3);
            this.statusTable.Name = "statusTable";
            this.statusTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.statusTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.statusTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.statusTable.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.statusTable.Size = new System.Drawing.Size(772, 237);
            this.statusTable.TabIndex = 0;
            // 
            // LRNHeader
            // 
            this.LRNHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LRNHeader.HeaderText = "LRN";
            this.LRNHeader.Name = "LRNHeader";
            this.LRNHeader.ReadOnly = true;
            this.LRNHeader.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // StudentNameHeader
            // 
            this.StudentNameHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentNameHeader.HeaderText = "Name";
            this.StudentNameHeader.Name = "StudentNameHeader";
            this.StudentNameHeader.ReadOnly = true;
            this.StudentNameHeader.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SectionHeader
            // 
            this.SectionHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SectionHeader.HeaderText = "Section";
            this.SectionHeader.Name = "SectionHeader";
            this.SectionHeader.ReadOnly = true;
            this.SectionHeader.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // LevelHeader
            // 
            this.LevelHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LevelHeader.HeaderText = "Level";
            this.LevelHeader.Name = "LevelHeader";
            this.LevelHeader.ReadOnly = true;
            this.LevelHeader.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // QuarterHeader
            // 
            this.QuarterHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QuarterHeader.HeaderText = "Quarter";
            this.QuarterHeader.Name = "QuarterHeader";
            this.QuarterHeader.ReadOnly = true;
            this.QuarterHeader.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // StatusHeader
            // 
            this.StatusHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StatusHeader.HeaderText = "Status";
            this.StatusHeader.Name = "StatusHeader";
            this.StatusHeader.ReadOnly = true;
            this.StatusHeader.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dueTab
            // 
            this.dueTab.Location = new System.Drawing.Point(4, 22);
            this.dueTab.Name = "dueTab";
            this.dueTab.Padding = new System.Windows.Forms.Padding(3);
            this.dueTab.Size = new System.Drawing.Size(778, 414);
            this.dueTab.TabIndex = 1;
            this.dueTab.Text = "Student Dues";
            this.dueTab.UseVisualStyleBackColor = true;
            // 
            // reportTab
            // 
            this.reportTab.Location = new System.Drawing.Point(4, 22);
            this.reportTab.Name = "reportTab";
            this.reportTab.Size = new System.Drawing.Size(778, 414);
            this.reportTab.TabIndex = 3;
            this.reportTab.Text = "Reports";
            this.reportTab.UseVisualStyleBackColor = true;
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
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
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
            this.studentTransTab.ResumeLayout(false);
            this.SalesTabControl.ResumeLayout(false);
            this.studentStatusTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl MainTabControl;
        private System.Windows.Forms.TabPage dashboardTab;
        private System.Windows.Forms.TabPage studentTransTab;
        private System.Windows.Forms.ImageList iconList;
        private MaterialSkin.Controls.MaterialTabControl SalesTabControl;
        private System.Windows.Forms.TabPage studentStatusTab;
        private System.Windows.Forms.TabPage dueTab;
        private System.Windows.Forms.TabPage reportTab;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.DataGridView statusTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn LRNHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNameHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectionHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn LevelHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuarterHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusHeader;
        private MaterialSkin.Controls.MaterialButton TestBtn;
    }
}

