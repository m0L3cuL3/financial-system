﻿
namespace Financial_System.Forms
{
    partial class StudentLedgerWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentLedgerWindow));
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.StudentIDLabel = new System.Windows.Forms.Label();
            this.StudentSectionLevelLabel = new System.Windows.Forms.Label();
            this.StudentNameLabel = new System.Windows.Forms.Label();
            this.SideInfoPanel = new System.Windows.Forms.Panel();
            this.StudentLRNLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProfilePanel = new Financial_System.CustomUI.GradientPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StudentIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TermColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiptNumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRecordedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TypeCmBox = new System.Windows.Forms.ComboBox();
            this.type_Lbl = new System.Windows.Forms.Label();
            this.ReceiptBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PostPaymentButton = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TermComboBox = new System.Windows.Forms.ComboBox();
            this.balORcredit = new System.Windows.Forms.Label();
            this.balancelbl = new System.Windows.Forms.Label();
            this.TopBarPanel.SuspendLayout();
            this.SideInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TopBarPanel.Controls.Add(this.CloseButton);
            this.TopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBarPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(854, 30);
            this.TopBarPanel.TabIndex = 0;
            this.TopBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBarPanel_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.CloseButton.ForeColor = System.Drawing.Color.Red;
            this.CloseButton.Location = new System.Drawing.Point(830, 6);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(18, 18);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // StudentIDLabel
            // 
            this.StudentIDLabel.AutoSize = true;
            this.StudentIDLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentIDLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.StudentIDLabel.Location = new System.Drawing.Point(86, 53);
            this.StudentIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StudentIDLabel.Name = "StudentIDLabel";
            this.StudentIDLabel.Size = new System.Drawing.Size(77, 16);
            this.StudentIDLabel.TabIndex = 15;
            this.StudentIDLabel.Text = "Student LRN:";
            // 
            // StudentSectionLevelLabel
            // 
            this.StudentSectionLevelLabel.AutoSize = true;
            this.StudentSectionLevelLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentSectionLevelLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.StudentSectionLevelLabel.Location = new System.Drawing.Point(179, 32);
            this.StudentSectionLevelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StudentSectionLevelLabel.Name = "StudentSectionLevelLabel";
            this.StudentSectionLevelLabel.Size = new System.Drawing.Size(115, 15);
            this.StudentSectionLevelLabel.TabIndex = 14;
            this.StudentSectionLevelLabel.Text = "StudentSectionLevel";
            // 
            // StudentNameLabel
            // 
            this.StudentNameLabel.AutoSize = true;
            this.StudentNameLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.StudentNameLabel.Location = new System.Drawing.Point(138, 11);
            this.StudentNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.Size = new System.Drawing.Size(79, 15);
            this.StudentNameLabel.TabIndex = 13;
            this.StudentNameLabel.Text = "StudentName";
            // 
            // SideInfoPanel
            // 
            this.SideInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.SideInfoPanel.Controls.Add(this.StudentLRNLabel);
            this.SideInfoPanel.Controls.Add(this.label6);
            this.SideInfoPanel.Controls.Add(this.TermComboBox);
            this.SideInfoPanel.Controls.Add(this.label4);
            this.SideInfoPanel.Controls.Add(this.label5);
            this.SideInfoPanel.Controls.Add(this.ProfilePanel);
            this.SideInfoPanel.Controls.Add(this.StudentNameLabel);
            this.SideInfoPanel.Controls.Add(this.StudentIDLabel);
            this.SideInfoPanel.Controls.Add(this.StudentSectionLevelLabel);
            this.SideInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SideInfoPanel.Location = new System.Drawing.Point(0, 30);
            this.SideInfoPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SideInfoPanel.Name = "SideInfoPanel";
            this.SideInfoPanel.Size = new System.Drawing.Size(854, 83);
            this.SideInfoPanel.TabIndex = 17;
            // 
            // StudentLRNLabel
            // 
            this.StudentLRNLabel.AutoSize = true;
            this.StudentLRNLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLRNLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.StudentLRNLabel.Location = new System.Drawing.Point(171, 53);
            this.StudentLRNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StudentLRNLabel.Name = "StudentLRNLabel";
            this.StudentLRNLabel.Size = new System.Drawing.Size(68, 15);
            this.StudentLRNLabel.TabIndex = 20;
            this.StudentLRNLabel.Text = "StudentLRN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(86, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Section/Level:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(86, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Name:";
            // 
            // ProfilePanel
            // 
            this.ProfilePanel.Angle = -48F;
            this.ProfilePanel.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(142)))), ((int)(((byte)(208)))));
            this.ProfilePanel.Location = new System.Drawing.Point(12, 11);
            this.ProfilePanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ProfilePanel.Name = "ProfilePanel";
            this.ProfilePanel.Size = new System.Drawing.Size(66, 58);
            this.ProfilePanel.TabIndex = 17;
            this.ProfilePanel.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(103)))), ((int)(((byte)(174)))));
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentIdColumn,
            this.AmountColumn,
            this.payment,
            this.TypeColumn,
            this.TermColumn,
            this.ReceiptNumColumn,
            this.DateRecordedColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 119);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(624, 332);
            this.dataGridView1.TabIndex = 18;
            // 
            // StudentIdColumn
            // 
            this.StudentIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentIdColumn.HeaderText = "Transaction ID";
            this.StudentIdColumn.Name = "StudentIdColumn";
            this.StudentIdColumn.ReadOnly = true;
            this.StudentIdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // AmountColumn
            // 
            this.AmountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AmountColumn.HeaderText = "Amount";
            this.AmountColumn.Name = "AmountColumn";
            this.AmountColumn.ReadOnly = true;
            this.AmountColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // payment
            // 
            this.payment.HeaderText = "Payment";
            this.payment.Name = "payment";
            this.payment.ReadOnly = true;
            // 
            // TypeColumn
            // 
            this.TypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TypeColumn.HeaderText = "Type";
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.ReadOnly = true;
            this.TypeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TermColumn
            // 
            this.TermColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TermColumn.HeaderText = "Term";
            this.TermColumn.Name = "TermColumn";
            this.TermColumn.ReadOnly = true;
            this.TermColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ReceiptNumColumn
            // 
            this.ReceiptNumColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReceiptNumColumn.HeaderText = "Reference";
            this.ReceiptNumColumn.Name = "ReceiptNumColumn";
            this.ReceiptNumColumn.ReadOnly = true;
            this.ReceiptNumColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DateRecordedColumn
            // 
            this.DateRecordedColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateRecordedColumn.HeaderText = "Date Recorded";
            this.DateRecordedColumn.Name = "DateRecordedColumn";
            this.DateRecordedColumn.ReadOnly = true;
            this.DateRecordedColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(647, 181);
            this.amountBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(193, 20);
            this.amountBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(644, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Amount";
            // 
            // TypeCmBox
            // 
            this.TypeCmBox.FormattingEnabled = true;
            this.TypeCmBox.Location = new System.Drawing.Point(647, 138);
            this.TypeCmBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TypeCmBox.Name = "TypeCmBox";
            this.TypeCmBox.Size = new System.Drawing.Size(193, 21);
            this.TypeCmBox.TabIndex = 21;
            // 
            // type_Lbl
            // 
            this.type_Lbl.AutoSize = true;
            this.type_Lbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_Lbl.Location = new System.Drawing.Point(644, 119);
            this.type_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.type_Lbl.Name = "type_Lbl";
            this.type_Lbl.Size = new System.Drawing.Size(86, 16);
            this.type_Lbl.TabIndex = 22;
            this.type_Lbl.Text = "Payment Type";
            // 
            // ReceiptBox
            // 
            this.ReceiptBox.Location = new System.Drawing.Point(647, 223);
            this.ReceiptBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ReceiptBox.Name = "ReceiptBox";
            this.ReceiptBox.Size = new System.Drawing.Size(193, 20);
            this.ReceiptBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(644, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Receipt Number";
            // 
            // PostPaymentButton
            // 
            this.PostPaymentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(116)))));
            this.PostPaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PostPaymentButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostPaymentButton.ForeColor = System.Drawing.Color.White;
            this.PostPaymentButton.Location = new System.Drawing.Point(647, 292);
            this.PostPaymentButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PostPaymentButton.Name = "PostPaymentButton";
            this.PostPaymentButton.Size = new System.Drawing.Size(193, 30);
            this.PostPaymentButton.TabIndex = 25;
            this.PostPaymentButton.Text = "Post Payment";
            this.PostPaymentButton.UseVisualStyleBackColor = false;
            this.PostPaymentButton.Click += new System.EventHandler(this.PostPaymentButton_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(116)))));
            this.exportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBtn.ForeColor = System.Drawing.Color.White;
            this.exportBtn.Location = new System.Drawing.Point(647, 421);
            this.exportBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(193, 30);
            this.exportBtn.TabIndex = 27;
            this.exportBtn.Text = "Export to Excel";
            this.exportBtn.UseVisualStyleBackColor = false;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(354, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Change Term";
            // 
            // TermComboBox
            // 
            this.TermComboBox.FormattingEnabled = true;
            this.TermComboBox.Location = new System.Drawing.Point(443, 53);
            this.TermComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TermComboBox.Name = "TermComboBox";
            this.TermComboBox.Size = new System.Drawing.Size(193, 21);
            this.TermComboBox.TabIndex = 30;
            // 
            // balORcredit
            // 
            this.balORcredit.AutoSize = true;
            this.balORcredit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balORcredit.Location = new System.Drawing.Point(644, 354);
            this.balORcredit.Name = "balORcredit";
            this.balORcredit.Size = new System.Drawing.Size(64, 17);
            this.balORcredit.TabIndex = 31;
            this.balORcredit.Text = "Balance:";
            // 
            // balancelbl
            // 
            this.balancelbl.AutoSize = true;
            this.balancelbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balancelbl.Location = new System.Drawing.Point(642, 371);
            this.balancelbl.Name = "balancelbl";
            this.balancelbl.Size = new System.Drawing.Size(78, 25);
            this.balancelbl.TabIndex = 32;
            this.balancelbl.Text = "₱ -----";
            // 
            // StudentLedgerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 463);
            this.Controls.Add(this.balancelbl);
            this.Controls.Add(this.balORcredit);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.PostPaymentButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReceiptBox);
            this.Controls.Add(this.type_Lbl);
            this.Controls.Add(this.TypeCmBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SideInfoPanel);
            this.Controls.Add(this.TopBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "StudentLedgerWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Ledger";
            this.Load += new System.EventHandler(this.StudentLedgerWindow_Load);
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
            this.SideInfoPanel.ResumeLayout(false);
            this.SideInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Label CloseButton;
        public System.Windows.Forms.Label StudentIDLabel;
        public System.Windows.Forms.Label StudentSectionLevelLabel;
        public System.Windows.Forms.Label StudentNameLabel;
        private System.Windows.Forms.Panel SideInfoPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TypeCmBox;
        private System.Windows.Forms.Label type_Lbl;
        private System.Windows.Forms.TextBox ReceiptBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PostPaymentButton;
        private System.Windows.Forms.Button exportBtn;
        private CustomUI.GradientPanel ProfilePanel;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label StudentLRNLabel;
        private System.Windows.Forms.ComboBox TermComboBox;
        private System.Windows.Forms.Label balORcredit;
        private System.Windows.Forms.Label balancelbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TermColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptNumColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRecordedColumn;
    }
}