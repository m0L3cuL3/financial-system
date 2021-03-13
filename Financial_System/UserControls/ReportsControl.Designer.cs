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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransIdColumn,
            this.StudentIdColumn,
            this.TypeColumn,
            this.AmountColumn,
            this.ReceiptColumn,
            this.DateRecordedColumn});
            this.dataGridView1.Location = new System.Drawing.Point(17, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(763, 188);
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
            // ReportsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "ReportsControl";
            this.Size = new System.Drawing.Size(800, 440);
            this.Load += new System.EventHandler(this.ReportsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRecordedColumn;
    }
}
