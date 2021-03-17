
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
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.ProfilePicPanel = new System.Windows.Forms.Panel();
            this.StudentLevelLabel = new System.Windows.Forms.Label();
            this.StudentIDLabel = new System.Windows.Forms.Label();
            this.StudentSectionLabel = new System.Windows.Forms.Label();
            this.StudentNameLabel = new System.Windows.Forms.Label();
            this.SideInfoPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StudentIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiptNumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TypeCmBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ReceiptBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PostPaymentButton = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
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
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(827, 30);
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
            this.CloseButton.Location = new System.Drawing.Point(803, 6);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(18, 18);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ProfilePicPanel
            // 
            this.ProfilePicPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ProfilePicPanel.Location = new System.Drawing.Point(12, 11);
            this.ProfilePicPanel.Name = "ProfilePicPanel";
            this.ProfilePicPanel.Size = new System.Drawing.Size(69, 59);
            this.ProfilePicPanel.TabIndex = 1;
            // 
            // StudentLevelLabel
            // 
            this.StudentLevelLabel.AutoSize = true;
            this.StudentLevelLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLevelLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.StudentLevelLabel.Location = new System.Drawing.Point(87, 32);
            this.StudentLevelLabel.Name = "StudentLevelLabel";
            this.StudentLevelLabel.Size = new System.Drawing.Size(90, 17);
            this.StudentLevelLabel.TabIndex = 16;
            this.StudentLevelLabel.Text = "StudentLevel";
            // 
            // StudentIDLabel
            // 
            this.StudentIDLabel.AutoSize = true;
            this.StudentIDLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentIDLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.StudentIDLabel.Location = new System.Drawing.Point(9, 73);
            this.StudentIDLabel.Name = "StudentIDLabel";
            this.StudentIDLabel.Size = new System.Drawing.Size(69, 17);
            this.StudentIDLabel.TabIndex = 15;
            this.StudentIDLabel.Text = "StudentId";
            // 
            // StudentSectionLabel
            // 
            this.StudentSectionLabel.AutoSize = true;
            this.StudentSectionLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentSectionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.StudentSectionLabel.Location = new System.Drawing.Point(87, 53);
            this.StudentSectionLabel.Name = "StudentSectionLabel";
            this.StudentSectionLabel.Size = new System.Drawing.Size(104, 17);
            this.StudentSectionLabel.TabIndex = 14;
            this.StudentSectionLabel.Text = "StudentSection";
            // 
            // StudentNameLabel
            // 
            this.StudentNameLabel.AutoSize = true;
            this.StudentNameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.StudentNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.StudentNameLabel.Location = new System.Drawing.Point(87, 11);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.Size = new System.Drawing.Size(97, 17);
            this.StudentNameLabel.TabIndex = 13;
            this.StudentNameLabel.Text = "StudentName";
            // 
            // SideInfoPanel
            // 
            this.SideInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.SideInfoPanel.Controls.Add(this.ProfilePicPanel);
            this.SideInfoPanel.Controls.Add(this.StudentLevelLabel);
            this.SideInfoPanel.Controls.Add(this.StudentNameLabel);
            this.SideInfoPanel.Controls.Add(this.StudentIDLabel);
            this.SideInfoPanel.Controls.Add(this.StudentSectionLabel);
            this.SideInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SideInfoPanel.Location = new System.Drawing.Point(0, 30);
            this.SideInfoPanel.Name = "SideInfoPanel";
            this.SideInfoPanel.Size = new System.Drawing.Size(827, 97);
            this.SideInfoPanel.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentIdColumn,
            this.AmountColumn,
            this.TypeColumn,
            this.ReceiptNumColumn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(803, 198);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // TypeColumn
            // 
            this.TypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TypeColumn.HeaderText = "Type";
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.ReadOnly = true;
            this.TypeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ReceiptNumColumn
            // 
            this.ReceiptNumColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReceiptNumColumn.HeaderText = "Receipt #";
            this.ReceiptNumColumn.Name = "ReceiptNumColumn";
            this.ReceiptNumColumn.ReadOnly = true;
            this.ReceiptNumColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(12, 401);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(100, 20);
            this.amountBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Amount";
            // 
            // TypeCmBox
            // 
            this.TypeCmBox.FormattingEnabled = true;
            this.TypeCmBox.Items.AddRange(new object[] {
            "Tuition Payment"});
            this.TypeCmBox.Location = new System.Drawing.Point(135, 401);
            this.TypeCmBox.Name = "TypeCmBox";
            this.TypeCmBox.Size = new System.Drawing.Size(121, 21);
            this.TypeCmBox.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Type";
            // 
            // ReceiptBox
            // 
            this.ReceiptBox.Location = new System.Drawing.Point(276, 401);
            this.ReceiptBox.Name = "ReceiptBox";
            this.ReceiptBox.Size = new System.Drawing.Size(100, 20);
            this.ReceiptBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Receipt #";
            // 
            // PostPaymentButton
            // 
            this.PostPaymentButton.Location = new System.Drawing.Point(12, 428);
            this.PostPaymentButton.Name = "PostPaymentButton";
            this.PostPaymentButton.Size = new System.Drawing.Size(364, 23);
            this.PostPaymentButton.TabIndex = 25;
            this.PostPaymentButton.Text = "Post Payment";
            this.PostPaymentButton.UseVisualStyleBackColor = true;
            this.PostPaymentButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(722, 428);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(93, 23);
            this.printBtn.TabIndex = 26;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = true;
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(609, 428);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(107, 23);
            this.exportBtn.TabIndex = 27;
            this.exportBtn.Text = "Export to CSV";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // StudentLedgerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 466);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.PostPaymentButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReceiptBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TypeCmBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SideInfoPanel);
            this.Controls.Add(this.TopBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentLedgerWindow";
            this.Text = "StudentLedgerWindow";
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
        private System.Windows.Forms.Panel ProfilePicPanel;
        public System.Windows.Forms.Label StudentLevelLabel;
        public System.Windows.Forms.Label StudentIDLabel;
        public System.Windows.Forms.Label StudentSectionLabel;
        public System.Windows.Forms.Label StudentNameLabel;
        private System.Windows.Forms.Panel SideInfoPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptNumColumn;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TypeCmBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ReceiptBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PostPaymentButton;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button exportBtn;
    }
}