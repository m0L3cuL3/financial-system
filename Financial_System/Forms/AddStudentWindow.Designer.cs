
namespace Financial_System.Forms
{
    partial class AddStudentWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudentWindow));
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LevelComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addStudButton = new System.Windows.Forms.Button();
            this.SectionTextBox = new Financial_System.CustomUI.Textbox.RoundTextBox();
            this.SurnameTextBox = new Financial_System.CustomUI.Textbox.RoundTextBox();
            this.MidnameTextBox = new Financial_System.CustomUI.Textbox.RoundTextBox();
            this.FnameTextBox = new Financial_System.CustomUI.Textbox.RoundTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LRNTextBox = new Financial_System.CustomUI.Textbox.RoundTextBox();
            this.TopBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.TopBarPanel.Controls.Add(this.CloseButton);
            this.TopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(480, 30);
            this.TopBarPanel.TabIndex = 1;
            this.TopBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBarPanel_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.CloseButton.ForeColor = System.Drawing.Color.Red;
            this.CloseButton.Location = new System.Drawing.Point(456, 6);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(18, 18);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.Color.DimGray;
            this.userLabel.Location = new System.Drawing.Point(23, 117);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(75, 17);
            this.userLabel.TabIndex = 5;
            this.userLabel.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(23, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Second Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(23, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(257, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Section";
            // 
            // LevelComboBox
            // 
            this.LevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LevelComboBox.FormattingEnabled = true;
            this.LevelComboBox.Location = new System.Drawing.Point(260, 137);
            this.LevelComboBox.Name = "LevelComboBox";
            this.LevelComboBox.Size = new System.Drawing.Size(52, 21);
            this.LevelComboBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(257, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Level";
            // 
            // addStudButton
            // 
            this.addStudButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(116)))));
            this.addStudButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addStudButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudButton.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.addStudButton.ForeColor = System.Drawing.Color.White;
            this.addStudButton.Location = new System.Drawing.Point(260, 267);
            this.addStudButton.Name = "addStudButton";
            this.addStudButton.Size = new System.Drawing.Size(191, 33);
            this.addStudButton.TabIndex = 12;
            this.addStudButton.Text = "Add Student";
            this.addStudButton.UseVisualStyleBackColor = false;
            this.addStudButton.Click += new System.EventHandler(this.addStudButton_Click);
            // 
            // SectionTextBox
            // 
            this.SectionTextBox.BackColor = System.Drawing.Color.Transparent;
            this.SectionTextBox.BorderColor = System.Drawing.Color.Gray;
            this.SectionTextBox.BorderSize = 1;
            this.SectionTextBox.Br = System.Drawing.Color.White;
            this.SectionTextBox.Font = new System.Drawing.Font("Ebrima", 12F);
            this.SectionTextBox.ForeColor = System.Drawing.Color.Black;
            this.SectionTextBox.Location = new System.Drawing.Point(250, 70);
            this.SectionTextBox.Name = "SectionTextBox";
            this.SectionTextBox.PasswordChar = '\0';
            this.SectionTextBox.Size = new System.Drawing.Size(216, 33);
            this.SectionTextBox.TabIndex = 8;
            this.SectionTextBox.textboxRadius = 15;
            this.SectionTextBox.UseSystemPasswordChar = false;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.SurnameTextBox.BorderColor = System.Drawing.Color.Gray;
            this.SurnameTextBox.BorderSize = 1;
            this.SurnameTextBox.Br = System.Drawing.Color.White;
            this.SurnameTextBox.Font = new System.Drawing.Font("Ebrima", 12F);
            this.SurnameTextBox.ForeColor = System.Drawing.Color.Black;
            this.SurnameTextBox.Location = new System.Drawing.Point(16, 267);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.PasswordChar = '\0';
            this.SurnameTextBox.Size = new System.Drawing.Size(216, 33);
            this.SurnameTextBox.TabIndex = 4;
            this.SurnameTextBox.textboxRadius = 15;
            this.SurnameTextBox.UseSystemPasswordChar = false;
            // 
            // MidnameTextBox
            // 
            this.MidnameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.MidnameTextBox.BorderColor = System.Drawing.Color.Gray;
            this.MidnameTextBox.BorderSize = 1;
            this.MidnameTextBox.Br = System.Drawing.Color.White;
            this.MidnameTextBox.Font = new System.Drawing.Font("Ebrima", 12F);
            this.MidnameTextBox.ForeColor = System.Drawing.Color.Black;
            this.MidnameTextBox.Location = new System.Drawing.Point(16, 204);
            this.MidnameTextBox.Name = "MidnameTextBox";
            this.MidnameTextBox.PasswordChar = '\0';
            this.MidnameTextBox.Size = new System.Drawing.Size(216, 33);
            this.MidnameTextBox.TabIndex = 3;
            this.MidnameTextBox.textboxRadius = 15;
            this.MidnameTextBox.UseSystemPasswordChar = false;
            // 
            // FnameTextBox
            // 
            this.FnameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.FnameTextBox.BorderColor = System.Drawing.Color.Gray;
            this.FnameTextBox.BorderSize = 1;
            this.FnameTextBox.Br = System.Drawing.Color.White;
            this.FnameTextBox.Font = new System.Drawing.Font("Ebrima", 12F);
            this.FnameTextBox.ForeColor = System.Drawing.Color.Black;
            this.FnameTextBox.Location = new System.Drawing.Point(16, 137);
            this.FnameTextBox.Name = "FnameTextBox";
            this.FnameTextBox.PasswordChar = '\0';
            this.FnameTextBox.Size = new System.Drawing.Size(216, 33);
            this.FnameTextBox.TabIndex = 2;
            this.FnameTextBox.textboxRadius = 15;
            this.FnameTextBox.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(23, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "LRN";
            // 
            // LRNTextBox
            // 
            this.LRNTextBox.BackColor = System.Drawing.Color.Transparent;
            this.LRNTextBox.BorderColor = System.Drawing.Color.Gray;
            this.LRNTextBox.BorderSize = 1;
            this.LRNTextBox.Br = System.Drawing.Color.White;
            this.LRNTextBox.Font = new System.Drawing.Font("Ebrima", 12F);
            this.LRNTextBox.ForeColor = System.Drawing.Color.Black;
            this.LRNTextBox.Location = new System.Drawing.Point(16, 70);
            this.LRNTextBox.Name = "LRNTextBox";
            this.LRNTextBox.PasswordChar = '\0';
            this.LRNTextBox.Size = new System.Drawing.Size(216, 33);
            this.LRNTextBox.TabIndex = 13;
            this.LRNTextBox.textboxRadius = 15;
            this.LRNTextBox.UseSystemPasswordChar = false;
            // 
            // AddStudentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(480, 325);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LRNTextBox);
            this.Controls.Add(this.addStudButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LevelComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SectionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.MidnameTextBox);
            this.Controls.Add(this.FnameTextBox);
            this.Controls.Add(this.TopBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddStudentWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student";
            this.Load += new System.EventHandler(this.AddStudentWindow_Load);
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Label CloseButton;
        private CustomUI.Textbox.RoundTextBox FnameTextBox;
        private CustomUI.Textbox.RoundTextBox MidnameTextBox;
        private CustomUI.Textbox.RoundTextBox SurnameTextBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CustomUI.Textbox.RoundTextBox SectionTextBox;
        private System.Windows.Forms.ComboBox LevelComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addStudButton;
        private System.Windows.Forms.Label label5;
        private CustomUI.Textbox.RoundTextBox LRNTextBox;
    }
}