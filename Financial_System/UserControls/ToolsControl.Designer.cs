
namespace Financial_System.UserControls
{
    partial class ToolsControl
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.FinancialPanel = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.IncomeStmtButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BalSheetButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CFButton = new System.Windows.Forms.Button();
            this.MonthYearGbox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GeneralPanel = new System.Windows.Forms.Panel();
            this.AddStudButton = new System.Windows.Forms.Button();
            this.Import_Btn = new System.Windows.Forms.Button();
            this.FinancialPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.MonthYearGbox.SuspendLayout();
            this.GeneralPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(18, 16);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(52, 22);
            this.TitleLabel.TabIndex = 7;
            this.TitleLabel.Text = "Tools";
            // 
            // FinancialPanel
            // 
            this.FinancialPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.FinancialPanel.Controls.Add(this.groupBox3);
            this.FinancialPanel.Controls.Add(this.groupBox2);
            this.FinancialPanel.Controls.Add(this.groupBox1);
            this.FinancialPanel.Controls.Add(this.MonthYearGbox);
            this.FinancialPanel.Location = new System.Drawing.Point(31, 106);
            this.FinancialPanel.Name = "FinancialPanel";
            this.FinancialPanel.Size = new System.Drawing.Size(235, 346);
            this.FinancialPanel.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.IncomeStmtButton);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(17, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 70);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Income Statement";
            // 
            // IncomeStmtButton
            // 
            this.IncomeStmtButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.IncomeStmtButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IncomeStmtButton.FlatAppearance.BorderSize = 0;
            this.IncomeStmtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncomeStmtButton.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomeStmtButton.ForeColor = System.Drawing.Color.White;
            this.IncomeStmtButton.Location = new System.Drawing.Point(18, 30);
            this.IncomeStmtButton.Name = "IncomeStmtButton";
            this.IncomeStmtButton.Size = new System.Drawing.Size(166, 25);
            this.IncomeStmtButton.TabIndex = 12;
            this.IncomeStmtButton.Text = "Open Tool";
            this.IncomeStmtButton.UseVisualStyleBackColor = false;
            this.IncomeStmtButton.Click += new System.EventHandler(this.IncomeStmtButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BalSheetButton);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 70);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Balance Sheet";
            // 
            // BalSheetButton
            // 
            this.BalSheetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.BalSheetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BalSheetButton.FlatAppearance.BorderSize = 0;
            this.BalSheetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BalSheetButton.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalSheetButton.ForeColor = System.Drawing.Color.White;
            this.BalSheetButton.Location = new System.Drawing.Point(18, 29);
            this.BalSheetButton.Name = "BalSheetButton";
            this.BalSheetButton.Size = new System.Drawing.Size(166, 25);
            this.BalSheetButton.TabIndex = 11;
            this.BalSheetButton.Text = "Open Tool";
            this.BalSheetButton.UseVisualStyleBackColor = false;
            this.BalSheetButton.Click += new System.EventHandler(this.BalSheetButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CFButton);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 70);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cash Flow Statement";
            // 
            // CFButton
            // 
            this.CFButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.CFButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CFButton.FlatAppearance.BorderSize = 0;
            this.CFButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CFButton.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CFButton.ForeColor = System.Drawing.Color.White;
            this.CFButton.Location = new System.Drawing.Point(18, 29);
            this.CFButton.Name = "CFButton";
            this.CFButton.Size = new System.Drawing.Size(166, 25);
            this.CFButton.TabIndex = 13;
            this.CFButton.Text = "Open Tool";
            this.CFButton.UseVisualStyleBackColor = false;
            this.CFButton.Click += new System.EventHandler(this.CFButton_Click);
            // 
            // MonthYearGbox
            // 
            this.MonthYearGbox.Controls.Add(this.label4);
            this.MonthYearGbox.Controls.Add(this.YearTextBox);
            this.MonthYearGbox.Controls.Add(this.label3);
            this.MonthYearGbox.Controls.Add(this.MonthComboBox);
            this.MonthYearGbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MonthYearGbox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthYearGbox.Location = new System.Drawing.Point(17, 16);
            this.MonthYearGbox.Name = "MonthYearGbox";
            this.MonthYearGbox.Size = new System.Drawing.Size(201, 87);
            this.MonthYearGbox.TabIndex = 14;
            this.MonthYearGbox.TabStop = false;
            this.MonthYearGbox.Text = "Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Input Year:";
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(119, 44);
            this.YearTextBox.Multiline = true;
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(65, 24);
            this.YearTextBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Select Month:";
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthComboBox.FormattingEnabled = true;
            this.MonthComboBox.Location = new System.Drawing.Point(18, 44);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(92, 24);
            this.MonthComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label1.Location = new System.Drawing.Point(27, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Financial Tools";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label2.Location = new System.Drawing.Point(291, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Academic Tools";
            // 
            // GeneralPanel
            // 
            this.GeneralPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.GeneralPanel.Controls.Add(this.Import_Btn);
            this.GeneralPanel.Controls.Add(this.AddStudButton);
            this.GeneralPanel.Location = new System.Drawing.Point(295, 106);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(159, 103);
            this.GeneralPanel.TabIndex = 10;
            // 
            // AddStudButton
            // 
            this.AddStudButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.AddStudButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddStudButton.FlatAppearance.BorderSize = 0;
            this.AddStudButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStudButton.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudButton.ForeColor = System.Drawing.Color.White;
            this.AddStudButton.Location = new System.Drawing.Point(15, 16);
            this.AddStudButton.Name = "AddStudButton";
            this.AddStudButton.Size = new System.Drawing.Size(129, 28);
            this.AddStudButton.TabIndex = 12;
            this.AddStudButton.Text = "Add New Student";
            this.AddStudButton.UseVisualStyleBackColor = false;
            this.AddStudButton.Click += new System.EventHandler(this.AddStudButton_Click);
            // 
            // Import_Btn
            // 
            this.Import_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.Import_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Import_Btn.FlatAppearance.BorderSize = 0;
            this.Import_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Import_Btn.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Import_Btn.ForeColor = System.Drawing.Color.White;
            this.Import_Btn.Location = new System.Drawing.Point(15, 56);
            this.Import_Btn.Name = "Import_Btn";
            this.Import_Btn.Size = new System.Drawing.Size(129, 28);
            this.Import_Btn.TabIndex = 13;
            this.Import_Btn.Text = "Import Student Data";
            this.Import_Btn.UseVisualStyleBackColor = false;
            this.Import_Btn.Click += new System.EventHandler(this.Import_Btn_Click);
            // 
            // ToolsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GeneralPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FinancialPanel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "ToolsControl";
            this.Size = new System.Drawing.Size(848, 478);
            this.Load += new System.EventHandler(this.ToolsControl_Load);
            this.FinancialPanel.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.MonthYearGbox.ResumeLayout(false);
            this.MonthYearGbox.PerformLayout();
            this.GeneralPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel FinancialPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel GeneralPanel;
        private System.Windows.Forms.Button CFButton;
        private System.Windows.Forms.Button IncomeStmtButton;
        private System.Windows.Forms.Button BalSheetButton;
        private System.Windows.Forms.Button AddStudButton;
        private System.Windows.Forms.GroupBox MonthYearGbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MonthComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Import_Btn;
    }
}
