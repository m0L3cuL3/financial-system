namespace Financial_System.Forms
{
    partial class StudentListWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lrn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.listlrn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listsurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listfname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listmiddlename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listlevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listsection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.desc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.familynamebx = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listidlbl = new System.Windows.Forms.Label();
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.TopBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create a List of Students";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "LRN";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(541, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 63);
            this.button1.TabIndex = 6;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lrn,
            this.surname,
            this.firstname,
            this.middlename,
            this.level,
            this.section});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(523, 355);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // lrn
            // 
            this.lrn.HeaderText = "LRN";
            this.lrn.Name = "lrn";
            // 
            // surname
            // 
            this.surname.HeaderText = "Surname";
            this.surname.Name = "surname";
            // 
            // firstname
            // 
            this.firstname.HeaderText = "Firstname";
            this.firstname.Name = "firstname";
            // 
            // middlename
            // 
            this.middlename.HeaderText = "Middlename";
            this.middlename.Name = "middlename";
            this.middlename.Width = 80;
            // 
            // level
            // 
            this.level.HeaderText = "Level";
            this.level.Name = "level";
            this.level.Width = 70;
            // 
            // section
            // 
            this.section.HeaderText = "Section";
            this.section.Name = "section";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 523);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "List of Enrolled Students";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.listlrn,
            this.listsurname,
            this.listfname,
            this.listmiddlename,
            this.listlevel,
            this.listsection});
            this.dataGridView2.Location = new System.Drawing.Point(576, 165);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(396, 355);
            this.dataGridView2.TabIndex = 9;
            // 
            // listlrn
            // 
            this.listlrn.HeaderText = "LRN";
            this.listlrn.Name = "listlrn";
            // 
            // listsurname
            // 
            this.listsurname.HeaderText = "Surname";
            this.listsurname.Name = "listsurname";
            this.listsurname.Width = 80;
            // 
            // listfname
            // 
            this.listfname.HeaderText = "Firstname";
            this.listfname.Name = "listfname";
            this.listfname.Width = 60;
            // 
            // listmiddlename
            // 
            this.listmiddlename.HeaderText = "Middlename";
            this.listmiddlename.Name = "listmiddlename";
            this.listmiddlename.Width = 80;
            // 
            // listlevel
            // 
            this.listlevel.HeaderText = "Level";
            this.listlevel.Name = "listlevel";
            this.listlevel.Width = 40;
            // 
            // listsection
            // 
            this.listsection.HeaderText = "Section";
            this.listsection.Name = "listsection";
            this.listsection.Width = 60;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox1.Location = new System.Drawing.Point(360, 139);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(71, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(437, 139);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(96, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Filter by:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(573, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "List Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(573, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "List Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Grade Level";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(434, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Section";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(576, 75);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 17;
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(576, 115);
            this.desc.Multiline = true;
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(396, 44);
            this.desc.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(118, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Family Name";
            // 
            // familynamebx
            // 
            this.familynamebx.Location = new System.Drawing.Point(118, 139);
            this.familynamebx.Name = "familynamebx";
            this.familynamebx.Size = new System.Drawing.Size(100, 20);
            this.familynamebx.TabIndex = 19;
            this.familynamebx.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(572, 523);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "Custom List";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(541, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 63);
            this.button2.TabIndex = 22;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(116)))));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(826, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 39);
            this.button3.TabIndex = 23;
            this.button3.Text = "Create List";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listidlbl
            // 
            this.listidlbl.AutoSize = true;
            this.listidlbl.Location = new System.Drawing.Point(696, 78);
            this.listidlbl.Name = "listidlbl";
            this.listidlbl.Size = new System.Drawing.Size(43, 13);
            this.listidlbl.TabIndex = 24;
            this.listidlbl.Text = "List ID: ";
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.TopBarPanel.Controls.Add(this.CloseButton);
            this.TopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(984, 30);
            this.TopBarPanel.TabIndex = 25;
            this.TopBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBarPanel_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.CloseButton.ForeColor = System.Drawing.Color.Red;
            this.CloseButton.Location = new System.Drawing.Point(960, 6);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(18, 18);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // StudentListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.TopBarPanel);
            this.Controls.Add(this.listidlbl);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.familynamebx);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentListWindow";
            this.Text = "Student Lists";
            this.Load += new System.EventHandler(this.StudentListWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox familynamebx;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label listidlbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn lrn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlename;
        private System.Windows.Forms.DataGridViewTextBoxColumn level;
        private System.Windows.Forms.DataGridViewTextBoxColumn section;
        private System.Windows.Forms.DataGridViewTextBoxColumn listlrn;
        private System.Windows.Forms.DataGridViewTextBoxColumn listsurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn listfname;
        private System.Windows.Forms.DataGridViewTextBoxColumn listmiddlename;
        private System.Windows.Forms.DataGridViewTextBoxColumn listlevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn listsection;
        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Label CloseButton;
    }
}