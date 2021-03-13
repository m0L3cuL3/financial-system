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
            this.listView1 = new System.Windows.Forms.ListView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TransIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.exportToCSVButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateValueLabel = new System.Windows.Forms.Label();
            this.separator2 = new Financial_System.UserControls.Separator();
            this.separator1 = new Financial_System.UserControls.Separator();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(14, 61);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(296, 284);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransIdColumn,
            this.StudentIdColumn,
            this.TypeColumn,
            this.AmountColumn});
            this.dataGridView1.Location = new System.Drawing.Point(328, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(455, 284);
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
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.headerLabel.Location = new System.Drawing.Point(11, 12);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(157, 17);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "Daily Collections Report";
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.totalLabel.Location = new System.Drawing.Point(656, 348);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(48, 17);
            this.totalLabel.TabIndex = 3;
            this.totalLabel.Text = "Total: ";
            // 
            // amountLabel
            // 
            this.amountLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.ForeColor = System.Drawing.Color.Black;
            this.amountLabel.Location = new System.Drawing.Point(710, 348);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(71, 17);
            this.amountLabel.TabIndex = 4;
            this.amountLabel.Text = "12, 312, 31";
            // 
            // exportToCSVButton
            // 
            this.exportToCSVButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exportToCSVButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.exportToCSVButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportToCSVButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportToCSVButton.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportToCSVButton.ForeColor = System.Drawing.Color.White;
            this.exportToCSVButton.Location = new System.Drawing.Point(561, 397);
            this.exportToCSVButton.Name = "exportToCSVButton";
            this.exportToCSVButton.Size = new System.Drawing.Size(108, 30);
            this.exportToCSVButton.TabIndex = 7;
            this.exportToCSVButton.Text = "Export To CSV";
            this.exportToCSVButton.UseVisualStyleBackColor = false;
            // 
            // printButton
            // 
            this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.printButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.printButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.ForeColor = System.Drawing.Color.White;
            this.printButton.Location = new System.Drawing.Point(675, 397);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(108, 30);
            this.printButton.TabIndex = 8;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = false;
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.dateLabel.Location = new System.Drawing.Point(634, 12);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(45, 17);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "Date: ";
            // 
            // dateValueLabel
            // 
            this.dateValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateValueLabel.AutoSize = true;
            this.dateValueLabel.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateValueLabel.ForeColor = System.Drawing.Color.Black;
            this.dateValueLabel.Location = new System.Drawing.Point(685, 12);
            this.dateValueLabel.Name = "dateValueLabel";
            this.dateValueLabel.Size = new System.Drawing.Size(98, 17);
            this.dateValueLabel.TabIndex = 10;
            this.dateValueLabel.Text = "March 13, 2021";
            // 
            // separator2
            // 
            this.separator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.separator2.IsVertical = false;
            this.separator2.Location = new System.Drawing.Point(14, 368);
            this.separator2.Name = "separator2";
            this.separator2.Size = new System.Drawing.Size(769, 23);
            this.separator2.TabIndex = 6;
            this.separator2.Text = "separator2";
            this.separator2.Thickness = 5;
            // 
            // separator1
            // 
            this.separator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.separator1.IsVertical = false;
            this.separator1.Location = new System.Drawing.Point(14, 32);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(769, 23);
            this.separator1.TabIndex = 5;
            this.separator1.Text = "separator1";
            this.separator1.Thickness = 5;
            // 
            // ReportsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateValueLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.exportToCSVButton);
            this.Controls.Add(this.separator2);
            this.Controls.Add(this.separator1);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listView1);
            this.Name = "ReportsControl";
            this.Size = new System.Drawing.Size(800, 440);
            this.Load += new System.EventHandler(this.ReportsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label amountLabel;
        private Separator separator1;
        private Separator separator2;
        private System.Windows.Forms.Button exportToCSVButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label dateValueLabel;
    }
}
