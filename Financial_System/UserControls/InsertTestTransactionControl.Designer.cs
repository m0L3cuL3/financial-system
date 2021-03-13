namespace Financial_System.UserControls
{
    partial class InsertTestTransactionControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.postpaymentbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StudentDataGridView = new System.Windows.Forms.DataGridView();
            this.StudentIDTextBox = new System.Windows.Forms.TextBox();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.ReceiptNumTextBox = new System.Windows.Forms.TextBox();
            this.AmountNumericBox = new System.Windows.Forms.NumericUpDown();
            this.StudentIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // postpaymentbtn
            // 
            this.postpaymentbtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postpaymentbtn.Location = new System.Drawing.Point(100, 390);
            this.postpaymentbtn.Name = "postpaymentbtn";
            this.postpaymentbtn.Size = new System.Drawing.Size(420, 26);
            this.postpaymentbtn.TabIndex = 0;
            this.postpaymentbtn.Text = "Post Payment";
            this.postpaymentbtn.UseVisualStyleBackColor = true;
            this.postpaymentbtn.Click += new System.EventHandler(this.postpaymentbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Student ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(368, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Receipt #";
            // 
            // StudentDataGridView
            // 
            this.StudentDataGridView.AllowUserToAddRows = false;
            this.StudentDataGridView.AllowUserToDeleteRows = false;
            this.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentIdColumn,
            this.StudentName,
            this.StudentSection,
            this.StudentLevel});
            this.StudentDataGridView.Location = new System.Drawing.Point(20, 17);
            this.StudentDataGridView.MultiSelect = false;
            this.StudentDataGridView.Name = "StudentDataGridView";
            this.StudentDataGridView.ReadOnly = true;
            this.StudentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentDataGridView.Size = new System.Drawing.Size(500, 232);
            this.StudentDataGridView.TabIndex = 10;
            this.StudentDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.StudentDataGridView_CellMouseClick);
            // 
            // StudentIDTextBox
            // 
            this.StudentIDTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentIDTextBox.Location = new System.Drawing.Point(20, 363);
            this.StudentIDTextBox.Name = "StudentIDTextBox";
            this.StudentIDTextBox.ReadOnly = true;
            this.StudentIDTextBox.Size = new System.Drawing.Size(62, 21);
            this.StudentIDTextBox.TabIndex = 11;
            this.StudentIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeTextBox.Location = new System.Drawing.Point(207, 363);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(158, 21);
            this.TypeTextBox.TabIndex = 13;
            this.TypeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReceiptNumTextBox
            // 
            this.ReceiptNumTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiptNumTextBox.Location = new System.Drawing.Point(371, 363);
            this.ReceiptNumTextBox.Name = "ReceiptNumTextBox";
            this.ReceiptNumTextBox.Size = new System.Drawing.Size(149, 21);
            this.ReceiptNumTextBox.TabIndex = 14;
            this.ReceiptNumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AmountNumericBox
            // 
            this.AmountNumericBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountNumericBox.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.AmountNumericBox.Location = new System.Drawing.Point(100, 363);
            this.AmountNumericBox.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.AmountNumericBox.Name = "AmountNumericBox";
            this.AmountNumericBox.Size = new System.Drawing.Size(101, 21);
            this.AmountNumericBox.TabIndex = 15;
            this.AmountNumericBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AmountNumericBox.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // StudentIdColumn
            // 
            this.StudentIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentIdColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.StudentIdColumn.HeaderText = "Student ID";
            this.StudentIdColumn.Name = "StudentIdColumn";
            this.StudentIdColumn.ReadOnly = true;
            this.StudentIdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // StudentName
            // 
            this.StudentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentName.DefaultCellStyle = dataGridViewCellStyle2;
            this.StudentName.HeaderText = "Student Fullname";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // StudentSection
            // 
            this.StudentSection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentSection.DefaultCellStyle = dataGridViewCellStyle3;
            this.StudentSection.HeaderText = "Section";
            this.StudentSection.Name = "StudentSection";
            this.StudentSection.ReadOnly = true;
            this.StudentSection.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // StudentLevel
            // 
            this.StudentLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLevel.DefaultCellStyle = dataGridViewCellStyle4;
            this.StudentLevel.HeaderText = "Level";
            this.StudentLevel.Name = "StudentLevel";
            this.StudentLevel.ReadOnly = true;
            this.StudentLevel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // InsertTestTransactionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AmountNumericBox);
            this.Controls.Add(this.ReceiptNumTextBox);
            this.Controls.Add(this.TypeTextBox);
            this.Controls.Add(this.StudentIDTextBox);
            this.Controls.Add(this.StudentDataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.postpaymentbtn);
            this.Name = "InsertTestTransactionControl";
            this.Size = new System.Drawing.Size(800, 440);
            this.Load += new System.EventHandler(this.InsertTestTransactionControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumericBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button postpaymentbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView StudentDataGridView;
        private System.Windows.Forms.TextBox StudentIDTextBox;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.TextBox ReceiptNumTextBox;
        private System.Windows.Forms.NumericUpDown AmountNumericBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentLevel;
    }
}
