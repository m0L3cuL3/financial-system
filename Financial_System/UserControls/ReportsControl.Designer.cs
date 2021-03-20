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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TransIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiptColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRecordedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleLabel = new System.Windows.Forms.Label();
            this.dateDescLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.totalDescLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.expToCSVButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.separator2 = new Financial_System.UserControls.Separator();
            this.separator1 = new Financial_System.UserControls.Separator();
            this.RefreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransIdColumn,
            this.StudentIdColumn,
            this.TypeColumn,
            this.AmountColumn,
            this.ReceiptColumn,
            this.DateRecordedColumn});
            this.dataGridView1.Location = new System.Drawing.Point(18, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(811, 290);
            this.dataGridView1.TabIndex = 1;
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
            // ReceiptColumn
            // 
            this.ReceiptColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReceiptColumn.HeaderText = "Receipt #";
            this.ReceiptColumn.Name = "ReceiptColumn";
            this.ReceiptColumn.ReadOnly = true;
            this.ReceiptColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DateRecordedColumn
            // 
            this.DateRecordedColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateRecordedColumn.HeaderText = "Date Recorded";
            this.DateRecordedColumn.Name = "DateRecordedColumn";
            this.DateRecordedColumn.ReadOnly = true;
            this.DateRecordedColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.titleLabel.Location = new System.Drawing.Point(15, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(151, 17);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Daily Collection Report";
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
            this.totalDescLabel.Location = new System.Drawing.Point(698, 386);
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
            this.totalLabel.Location = new System.Drawing.Point(752, 386);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 17);
            this.totalLabel.TabIndex = 8;
            this.totalLabel.Text = "N/A";
            // 
            // expToCSVButton
            // 
            this.expToCSVButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.expToCSVButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expToCSVButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expToCSVButton.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expToCSVButton.ForeColor = System.Drawing.Color.White;
            this.expToCSVButton.Location = new System.Drawing.Point(566, 431);
            this.expToCSVButton.Name = "expToCSVButton";
            this.expToCSVButton.Size = new System.Drawing.Size(129, 37);
            this.expToCSVButton.TabIndex = 9;
            this.expToCSVButton.Text = "Export To CSV";
            this.expToCSVButton.UseVisualStyleBackColor = false;
            this.expToCSVButton.Click += new System.EventHandler(this.expToCSVButton_Click);
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.printButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.ForeColor = System.Drawing.Color.White;
            this.printButton.Location = new System.Drawing.Point(701, 431);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(129, 37);
            this.printButton.TabIndex = 10;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = false;
            // 
            // separator2
            // 
            this.separator2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.separator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.separator2.IsVertical = false;
            this.separator2.Location = new System.Drawing.Point(18, 406);
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
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Font = new System.Drawing.Font("Ebrima", 8F);
            this.RefreshButton.ForeColor = System.Drawing.Color.White;
            this.RefreshButton.Location = new System.Drawing.Point(18, 377);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(129, 26);
            this.RefreshButton.TabIndex = 11;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ReportsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.expToCSVButton);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn TransIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRecordedColumn;
        private System.Windows.Forms.Label titleLabel;
        private Separator separator1;
        private System.Windows.Forms.Label dateDescLabel;
        private System.Windows.Forms.Label dateLabel;
        private Separator separator2;
        private System.Windows.Forms.Label totalDescLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button expToCSVButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button RefreshButton;
    }
}
