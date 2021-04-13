
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
            this.CFButton = new System.Windows.Forms.Button();
            this.IncomeStmtButton = new System.Windows.Forms.Button();
            this.BalSheetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GeneralPanel = new System.Windows.Forms.Panel();
            this.AddStudButton = new System.Windows.Forms.Button();
            this.MonthYearGbox = new System.Windows.Forms.GroupBox();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FinancialPanel.SuspendLayout();
            this.GeneralPanel.SuspendLayout();
            this.MonthYearGbox.SuspendLayout();
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
            this.FinancialPanel.Controls.Add(this.BalSheetButton);
            this.FinancialPanel.Controls.Add(this.MonthYearGbox);
            this.FinancialPanel.Controls.Add(this.CFButton);
            this.FinancialPanel.Controls.Add(this.IncomeStmtButton);
            this.FinancialPanel.Location = new System.Drawing.Point(22, 106);
            this.FinancialPanel.Name = "FinancialPanel";
            this.FinancialPanel.Size = new System.Drawing.Size(188, 273);
            this.FinancialPanel.TabIndex = 8;
            // 
            // CFButton
            // 
            this.CFButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.CFButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CFButton.FlatAppearance.BorderSize = 0;
            this.CFButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CFButton.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CFButton.ForeColor = System.Drawing.Color.White;
            this.CFButton.Location = new System.Drawing.Point(17, 233);
            this.CFButton.Name = "CFButton";
            this.CFButton.Size = new System.Drawing.Size(152, 28);
            this.CFButton.TabIndex = 13;
            this.CFButton.Text = "Cash Flow Statement";
            this.CFButton.UseVisualStyleBackColor = false;
            this.CFButton.Click += new System.EventHandler(this.CFButton_Click);
            // 
            // IncomeStmtButton
            // 
            this.IncomeStmtButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.IncomeStmtButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IncomeStmtButton.FlatAppearance.BorderSize = 0;
            this.IncomeStmtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncomeStmtButton.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomeStmtButton.ForeColor = System.Drawing.Color.White;
            this.IncomeStmtButton.Location = new System.Drawing.Point(17, 199);
            this.IncomeStmtButton.Name = "IncomeStmtButton";
            this.IncomeStmtButton.Size = new System.Drawing.Size(152, 28);
            this.IncomeStmtButton.TabIndex = 12;
            this.IncomeStmtButton.Text = "Income Statement";
            this.IncomeStmtButton.UseVisualStyleBackColor = false;
            this.IncomeStmtButton.Click += new System.EventHandler(this.IncomeStmtButton_Click);
            // 
            // BalSheetButton
            // 
            this.BalSheetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.BalSheetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BalSheetButton.FlatAppearance.BorderSize = 0;
            this.BalSheetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BalSheetButton.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalSheetButton.ForeColor = System.Drawing.Color.White;
            this.BalSheetButton.Location = new System.Drawing.Point(17, 165);
            this.BalSheetButton.Name = "BalSheetButton";
            this.BalSheetButton.Size = new System.Drawing.Size(152, 28);
            this.BalSheetButton.TabIndex = 11;
            this.BalSheetButton.Text = "Balance Sheet";
            this.BalSheetButton.UseVisualStyleBackColor = false;
            this.BalSheetButton.Click += new System.EventHandler(this.BalSheetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label1.Location = new System.Drawing.Point(18, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Financial Tools";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label2.Location = new System.Drawing.Point(235, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Academic Tools";
            // 
            // GeneralPanel
            // 
            this.GeneralPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.GeneralPanel.Controls.Add(this.AddStudButton);
            this.GeneralPanel.Location = new System.Drawing.Point(239, 106);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(159, 128);
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
            this.MonthYearGbox.Size = new System.Drawing.Size(152, 134);
            this.MonthYearGbox.TabIndex = 14;
            this.MonthYearGbox.TabStop = false;
            this.MonthYearGbox.Text = "Month && Year";
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthComboBox.FormattingEnabled = true;
            this.MonthComboBox.Location = new System.Drawing.Point(18, 44);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(114, 24);
            this.MonthComboBox.TabIndex = 0;
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
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(18, 91);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(114, 21);
            this.YearTextBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Input Year:";
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
            this.GeneralPanel.ResumeLayout(false);
            this.MonthYearGbox.ResumeLayout(false);
            this.MonthYearGbox.PerformLayout();
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
    }
}
