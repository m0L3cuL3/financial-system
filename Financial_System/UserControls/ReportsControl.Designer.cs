namespace Financial_System.UserControls
{
    partial class ReportsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.titleLabel = new System.Windows.Forms.Label();
            this.dateDescLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.totalDescLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.exportButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.FilterButton = new System.Windows.Forms.Button();
            this.DayComboBox = new System.Windows.Forms.ComboBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.separator2 = new Financial_System.UserControls.Separator();
            this.separator1 = new Financial_System.UserControls.Separator();
            this.FilterSettingsCbox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TransIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReferenceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TermColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRecordedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransIdColumn,
            this.StudentIdColumn,
            this.TypeColumn,
            this.AmountColumn,
            this.ReferenceColumn,
            this.TermColumn,
            this.DateRecordedColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(18, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(811, 280);
            this.dataGridView1.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.titleLabel.Location = new System.Drawing.Point(15, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(115, 17);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Collection Report";
            // 
            // dateDescLabel
            // 
            this.dateDescLabel.AutoSize = true;
            this.dateDescLabel.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDescLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.dateDescLabel.Location = new System.Drawing.Point(680, 13);
            this.dateDescLabel.Name = "dateDescLabel";
            this.dateDescLabel.Size = new System.Drawing.Size(45, 17);
            this.dateDescLabel.TabIndex = 4;
            this.dateDescLabel.Text = "Date: ";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.Black;
            this.dateLabel.Location = new System.Drawing.Point(731, 13);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(31, 17);
            this.dateLabel.TabIndex = 5;
            this.dateLabel.Text = "N/A";
            // 
            // totalDescLabel
            // 
            this.totalDescLabel.AutoSize = true;
            this.totalDescLabel.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDescLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.totalDescLabel.Location = new System.Drawing.Point(698, 376);
            this.totalDescLabel.Name = "totalDescLabel";
            this.totalDescLabel.Size = new System.Drawing.Size(48, 17);
            this.totalDescLabel.TabIndex = 7;
            this.totalDescLabel.Text = "Total: ";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.Black;
            this.totalLabel.Location = new System.Drawing.Point(752, 376);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 17);
            this.totalLabel.TabIndex = 8;
            this.totalLabel.Text = "N/A";
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.exportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportButton.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.exportButton.ForeColor = System.Drawing.Color.White;
            this.exportButton.Location = new System.Drawing.Point(700, 431);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(129, 37);
            this.exportButton.TabIndex = 9;
            this.exportButton.Text = "Export To Excel";
            this.exportButton.UseVisualStyleBackColor = false;
            this.exportButton.Click += new System.EventHandler(this.expToCSVButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.RefreshButton.ForeColor = System.Drawing.Color.White;
            this.RefreshButton.Location = new System.Drawing.Point(18, 367);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(129, 26);
            this.RefreshButton.TabIndex = 11;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthComboBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthComboBox.FormattingEnabled = true;
            this.MonthComboBox.Location = new System.Drawing.Point(18, 438);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(96, 24);
            this.MonthComboBox.TabIndex = 12;
            // 
            // FilterButton
            // 
            this.FilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.FilterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterButton.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FilterButton.ForeColor = System.Drawing.Color.White;
            this.FilterButton.Location = new System.Drawing.Point(416, 439);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(117, 24);
            this.FilterButton.TabIndex = 13;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = false;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // DayComboBox
            // 
            this.DayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DayComboBox.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.DayComboBox.FormattingEnabled = true;
            this.DayComboBox.Location = new System.Drawing.Point(120, 438);
            this.DayComboBox.Name = "DayComboBox";
            this.DayComboBox.Size = new System.Drawing.Size(66, 24);
            this.DayComboBox.TabIndex = 14;
            // 
            // YearTextBox
            // 
            this.YearTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.YearTextBox.Location = new System.Drawing.Point(192, 439);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(100, 21);
            this.YearTextBox.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(189, 422);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 15);
            this.label15.TabIndex = 45;
            this.label15.Text = "Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(15, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 46;
            this.label1.Text = "Month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(117, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 47;
            this.label2.Text = "Day";
            // 
            // separator2
            // 
            this.separator2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.separator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.separator2.IsVertical = false;
            this.separator2.Location = new System.Drawing.Point(18, 396);
            this.separator2.Name = "separator2";
            this.separator2.Size = new System.Drawing.Size(811, 23);
            this.separator2.TabIndex = 6;
            this.separator2.Text = "separator2";
            this.separator2.Thickness = 5;
            // 
            // separator1
            // 
            this.separator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.separator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.separator1.IsVertical = false;
            this.separator1.Location = new System.Drawing.Point(18, 52);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(811, 23);
            this.separator1.TabIndex = 3;
            this.separator1.Text = "separator1";
            this.separator1.Thickness = 5;
            // 
            // FilterSettingsCbox
            // 
            this.FilterSettingsCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterSettingsCbox.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FilterSettingsCbox.FormattingEnabled = true;
            this.FilterSettingsCbox.Location = new System.Drawing.Point(298, 438);
            this.FilterSettingsCbox.Name = "FilterSettingsCbox";
            this.FilterSettingsCbox.Size = new System.Drawing.Size(112, 24);
            this.FilterSettingsCbox.TabIndex = 48;
            this.FilterSettingsCbox.SelectedIndexChanged += new System.EventHandler(this.FilterSettingsCbox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(295, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 49;
            this.label3.Text = "Filter Settings";
            // 
            // TransIdColumn
            // 
            this.TransIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TransIdColumn.HeaderText = "Transaction ID";
            this.TransIdColumn.Name = "TransIdColumn";
            this.TransIdColumn.ReadOnly = true;
            this.TransIdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // StudentIdColumn
            // 
            this.StudentIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentIdColumn.HeaderText = "Student ID";
            this.StudentIdColumn.Name = "StudentIdColumn";
            this.StudentIdColumn.ReadOnly = true;
            this.StudentIdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TypeColumn
            // 
            this.TypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TypeColumn.HeaderText = "Type";
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.ReadOnly = true;
            this.TypeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // AmountColumn
            // 
            this.AmountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AmountColumn.HeaderText = "Amount";
            this.AmountColumn.Name = "AmountColumn";
            this.AmountColumn.ReadOnly = true;
            this.AmountColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ReferenceColumn
            // 
            this.ReferenceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReferenceColumn.HeaderText = "Reference";
            this.ReferenceColumn.Name = "ReferenceColumn";
            this.ReferenceColumn.ReadOnly = true;
            this.ReferenceColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TermColumn
            // 
            this.TermColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TermColumn.HeaderText = "Term";
            this.TermColumn.Name = "TermColumn";
            this.TermColumn.ReadOnly = true;
            this.TermColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DateRecordedColumn
            // 
            this.DateRecordedColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateRecordedColumn.HeaderText = "Date Recorded";
            this.DateRecordedColumn.Name = "DateRecordedColumn";
            this.DateRecordedColumn.ReadOnly = true;
            this.DateRecordedColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ReportsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FilterSettingsCbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.DayComboBox);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.MonthComboBox);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.totalDescLabel);
            this.Controls.Add(this.separator2);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateDescLabel);
            this.Controls.Add(this.separator1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ReportsControl";
            this.Size = new System.Drawing.Size(848, 478);
            this.Load += new System.EventHandler(this.ReportsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label titleLabel;
        private Separator separator1;
        private System.Windows.Forms.Label dateDescLabel;
        private System.Windows.Forms.Label dateLabel;
        private Separator separator2;
        private System.Windows.Forms.Label totalDescLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.ComboBox MonthComboBox;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.ComboBox DayComboBox;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FilterSettingsCbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReferenceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TermColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRecordedColumn;
    }
}
