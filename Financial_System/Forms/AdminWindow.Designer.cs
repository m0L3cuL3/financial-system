
namespace Financial_System.Forms
{
    partial class AdminWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.UserTextBox = new Financial_System.CustomUI.Textbox.RoundTextBox();
            this.PassTextBox = new Financial_System.CustomUI.Textbox.RoundTextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.UserTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.UserGridView = new System.Windows.Forms.DataGridView();
            this.UserIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsernameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addUserButton = new System.Windows.Forms.Button();
            this.DatabaseTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TermId_txtBox = new Financial_System.CustomUI.Textbox.RoundTextBox();
            this.TermDGV = new System.Windows.Forms.DataGridView();
            this.TermIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TermDescColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.TermDesc_txtBox = new Financial_System.CustomUI.Textbox.RoundTextBox();
            this.AddTerm_Btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InitializeDb_Btn = new System.Windows.Forms.Button();
            this.TopBarPanel.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.UserTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).BeginInit();
            this.DatabaseTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TermDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.TopBarPanel.Controls.Add(this.CloseButton);
            this.TopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(747, 30);
            this.TopBarPanel.TabIndex = 3;
            this.TopBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBarPanel_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.CloseButton.ForeColor = System.Drawing.Color.Red;
            this.CloseButton.Location = new System.Drawing.Point(723, 6);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(18, 18);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // UserTextBox
            // 
            this.UserTextBox.BackColor = System.Drawing.Color.Transparent;
            this.UserTextBox.BorderColor = System.Drawing.Color.Gray;
            this.UserTextBox.BorderSize = 1;
            this.UserTextBox.Br = System.Drawing.Color.White;
            this.UserTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTextBox.ForeColor = System.Drawing.Color.Black;
            this.UserTextBox.Location = new System.Drawing.Point(14, 40);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.PasswordChar = '\0';
            this.UserTextBox.Size = new System.Drawing.Size(180, 33);
            this.UserTextBox.TabIndex = 4;
            this.UserTextBox.textboxRadius = 15;
            this.UserTextBox.UseSystemPasswordChar = false;
            // 
            // PassTextBox
            // 
            this.PassTextBox.BackColor = System.Drawing.Color.Transparent;
            this.PassTextBox.BorderColor = System.Drawing.Color.Gray;
            this.PassTextBox.BorderSize = 1;
            this.PassTextBox.Br = System.Drawing.Color.White;
            this.PassTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTextBox.ForeColor = System.Drawing.Color.Black;
            this.PassTextBox.Location = new System.Drawing.Point(14, 105);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.PasswordChar = '\0';
            this.PassTextBox.Size = new System.Drawing.Size(180, 33);
            this.PassTextBox.TabIndex = 5;
            this.PassTextBox.textboxRadius = 15;
            this.PassTextBox.UseSystemPasswordChar = false;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.Color.DimGray;
            this.userLabel.Location = new System.Drawing.Point(22, 20);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(71, 17);
            this.userLabel.TabIndex = 6;
            this.userLabel.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(22, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Password";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.UserTab);
            this.TabControl.Controls.Add(this.DatabaseTab);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.Location = new System.Drawing.Point(0, 30);
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(747, 433);
            this.TabControl.TabIndex = 8;
            // 
            // UserTab
            // 
            this.UserTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UserTab.Controls.Add(this.button1);
            this.UserTab.Controls.Add(this.UserGridView);
            this.UserTab.Controls.Add(this.addUserButton);
            this.UserTab.Controls.Add(this.UserTextBox);
            this.UserTab.Controls.Add(this.label1);
            this.UserTab.Controls.Add(this.PassTextBox);
            this.UserTab.Controls.Add(this.userLabel);
            this.UserTab.Location = new System.Drawing.Point(4, 25);
            this.UserTab.Name = "UserTab";
            this.UserTab.Padding = new System.Windows.Forms.Padding(3);
            this.UserTab.Size = new System.Drawing.Size(739, 404);
            this.UserTab.TabIndex = 0;
            this.UserTab.Text = "User Tools";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(116)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(567, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 31);
            this.button1.TabIndex = 20;
            this.button1.Text = "Load All Users";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserGridView
            // 
            this.UserGridView.AllowUserToAddRows = false;
            this.UserGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.UserGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UserGridView.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.UserGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UserGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserIdColumn,
            this.UsernameColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.UserGridView.Location = new System.Drawing.Point(210, 20);
            this.UserGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UserGridView.Name = "UserGridView";
            this.UserGridView.ReadOnly = true;
            this.UserGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.UserGridView.RowHeadersVisible = false;
            this.UserGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserGridView.Size = new System.Drawing.Size(510, 332);
            this.UserGridView.TabIndex = 19;
            // 
            // UserIdColumn
            // 
            this.UserIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserIdColumn.HeaderText = "User ID";
            this.UserIdColumn.Name = "UserIdColumn";
            this.UserIdColumn.ReadOnly = true;
            this.UserIdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // UsernameColumn
            // 
            this.UsernameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UsernameColumn.HeaderText = "Username";
            this.UsernameColumn.Name = "UsernameColumn";
            this.UsernameColumn.ReadOnly = true;
            this.UsernameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(116)))));
            this.addUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserButton.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.addUserButton.ForeColor = System.Drawing.Color.White;
            this.addUserButton.Location = new System.Drawing.Point(25, 154);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(153, 31);
            this.addUserButton.TabIndex = 8;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // DatabaseTab
            // 
            this.DatabaseTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DatabaseTab.Controls.Add(this.groupBox2);
            this.DatabaseTab.Controls.Add(this.groupBox1);
            this.DatabaseTab.Location = new System.Drawing.Point(4, 25);
            this.DatabaseTab.Name = "DatabaseTab";
            this.DatabaseTab.Padding = new System.Windows.Forms.Padding(3);
            this.DatabaseTab.Size = new System.Drawing.Size(739, 404);
            this.DatabaseTab.TabIndex = 1;
            this.DatabaseTab.Text = "Database Tools";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TermId_txtBox);
            this.groupBox2.Controls.Add(this.TermDGV);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TermDesc_txtBox);
            this.groupBox2.Controls.Add(this.AddTerm_Btn);
            this.groupBox2.Location = new System.Drawing.Point(25, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 272);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setup Academic Term";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(25, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Term ID";
            // 
            // TermId_txtBox
            // 
            this.TermId_txtBox.BackColor = System.Drawing.Color.Transparent;
            this.TermId_txtBox.BorderColor = System.Drawing.Color.Gray;
            this.TermId_txtBox.BorderSize = 1;
            this.TermId_txtBox.Br = System.Drawing.Color.White;
            this.TermId_txtBox.Font = new System.Drawing.Font("Ebrima", 12F);
            this.TermId_txtBox.ForeColor = System.Drawing.Color.Black;
            this.TermId_txtBox.Location = new System.Drawing.Point(18, 46);
            this.TermId_txtBox.Name = "TermId_txtBox";
            this.TermId_txtBox.PasswordChar = '\0';
            this.TermId_txtBox.Size = new System.Drawing.Size(165, 26);
            this.TermId_txtBox.TabIndex = 21;
            this.TermId_txtBox.textboxRadius = 15;
            this.TermId_txtBox.UseSystemPasswordChar = false;
            // 
            // TermDGV
            // 
            this.TermDGV.AllowUserToAddRows = false;
            this.TermDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.TermDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.TermDGV.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.TermDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TermDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TermDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.TermDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TermDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TermIdColumn,
            this.TermDescColumn});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TermDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.TermDGV.Location = new System.Drawing.Point(202, 26);
            this.TermDGV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TermDGV.Name = "TermDGV";
            this.TermDGV.ReadOnly = true;
            this.TermDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TermDGV.RowHeadersVisible = false;
            this.TermDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TermDGV.Size = new System.Drawing.Size(245, 231);
            this.TermDGV.TabIndex = 20;
            // 
            // TermIdColumn
            // 
            this.TermIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TermIdColumn.HeaderText = "Term ID";
            this.TermIdColumn.Name = "TermIdColumn";
            this.TermIdColumn.ReadOnly = true;
            this.TermIdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TermDescColumn
            // 
            this.TermDescColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TermDescColumn.HeaderText = "Term Description";
            this.TermDescColumn.Name = "TermDescColumn";
            this.TermDescColumn.ReadOnly = true;
            this.TermDescColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(25, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Term Description";
            // 
            // TermDesc_txtBox
            // 
            this.TermDesc_txtBox.BackColor = System.Drawing.Color.Transparent;
            this.TermDesc_txtBox.BorderColor = System.Drawing.Color.Gray;
            this.TermDesc_txtBox.BorderSize = 1;
            this.TermDesc_txtBox.Br = System.Drawing.Color.White;
            this.TermDesc_txtBox.Font = new System.Drawing.Font("Ebrima", 12F);
            this.TermDesc_txtBox.ForeColor = System.Drawing.Color.Black;
            this.TermDesc_txtBox.Location = new System.Drawing.Point(18, 107);
            this.TermDesc_txtBox.Name = "TermDesc_txtBox";
            this.TermDesc_txtBox.PasswordChar = '\0';
            this.TermDesc_txtBox.Size = new System.Drawing.Size(165, 26);
            this.TermDesc_txtBox.TabIndex = 11;
            this.TermDesc_txtBox.textboxRadius = 15;
            this.TermDesc_txtBox.UseSystemPasswordChar = false;
            // 
            // AddTerm_Btn
            // 
            this.AddTerm_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(116)))));
            this.AddTerm_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTerm_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTerm_Btn.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.AddTerm_Btn.ForeColor = System.Drawing.Color.White;
            this.AddTerm_Btn.Location = new System.Drawing.Point(18, 226);
            this.AddTerm_Btn.Name = "AddTerm_Btn";
            this.AddTerm_Btn.Size = new System.Drawing.Size(165, 31);
            this.AddTerm_Btn.TabIndex = 10;
            this.AddTerm_Btn.Text = "Add Academic Term";
            this.AddTerm_Btn.UseVisualStyleBackColor = false;
            this.AddTerm_Btn.Click += new System.EventHandler(this.AddTerm_Btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.InitializeDb_Btn);
            this.groupBox1.Location = new System.Drawing.Point(25, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 79);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setup Database";
            // 
            // InitializeDb_Btn
            // 
            this.InitializeDb_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(116)))));
            this.InitializeDb_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InitializeDb_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InitializeDb_Btn.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.InitializeDb_Btn.ForeColor = System.Drawing.Color.White;
            this.InitializeDb_Btn.Location = new System.Drawing.Point(18, 29);
            this.InitializeDb_Btn.Name = "InitializeDb_Btn";
            this.InitializeDb_Btn.Size = new System.Drawing.Size(165, 31);
            this.InitializeDb_Btn.TabIndex = 9;
            this.InitializeDb_Btn.Text = "Initialize Database";
            this.InitializeDb_Btn.UseVisualStyleBackColor = false;
            this.InitializeDb_Btn.Click += new System.EventHandler(this.InitializeDb_Btn_Click);
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 463);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.TopBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminWindow";
            this.Load += new System.EventHandler(this.AdminWindow_Load);
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.UserTab.ResumeLayout(false);
            this.UserTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).EndInit();
            this.DatabaseTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TermDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Label CloseButton;
        private CustomUI.Textbox.RoundTextBox UserTextBox;
        private CustomUI.Textbox.RoundTextBox PassTextBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage UserTab;
        private System.Windows.Forms.TabPage DatabaseTab;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView UserGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsernameColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button InitializeDb_Btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private CustomUI.Textbox.RoundTextBox TermDesc_txtBox;
        private System.Windows.Forms.Button AddTerm_Btn;
        private System.Windows.Forms.DataGridView TermDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TermIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TermDescColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CustomUI.Textbox.RoundTextBox TermId_txtBox;
    }
}