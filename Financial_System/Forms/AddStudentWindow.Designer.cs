
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
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addStudButton = new System.Windows.Forms.Button();
            this.roundTextBox4 = new Financial_System.CustomUI.Textbox.RoundTextBox();
            this.roundTextBox3 = new Financial_System.CustomUI.Textbox.RoundTextBox();
            this.roundTextBox2 = new Financial_System.CustomUI.Textbox.RoundTextBox();
            this.roundTextBox1 = new Financial_System.CustomUI.Textbox.RoundTextBox();
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
            this.userLabel.Location = new System.Drawing.Point(19, 50);
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
            this.label1.Location = new System.Drawing.Point(19, 117);
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
            this.label2.Location = new System.Drawing.Point(19, 180);
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
            // FilterComboBox
            // 
            this.FilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Location = new System.Drawing.Point(260, 137);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(52, 21);
            this.FilterComboBox.TabIndex = 10;
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
            this.addStudButton.Location = new System.Drawing.Point(260, 200);
            this.addStudButton.Name = "addStudButton";
            this.addStudButton.Size = new System.Drawing.Size(191, 33);
            this.addStudButton.TabIndex = 12;
            this.addStudButton.Text = "Add Student";
            this.addStudButton.UseVisualStyleBackColor = false;
            // 
            // roundTextBox4
            // 
            this.roundTextBox4.BackColor = System.Drawing.Color.Transparent;
            this.roundTextBox4.BorderColor = System.Drawing.Color.Gray;
            this.roundTextBox4.BorderSize = 1;
            this.roundTextBox4.Br = System.Drawing.Color.White;
            this.roundTextBox4.Font = new System.Drawing.Font("Ebrima", 12F);
            this.roundTextBox4.ForeColor = System.Drawing.Color.Black;
            this.roundTextBox4.Location = new System.Drawing.Point(250, 70);
            this.roundTextBox4.Name = "roundTextBox4";
            this.roundTextBox4.PasswordChar = '\0';
            this.roundTextBox4.Size = new System.Drawing.Size(216, 33);
            this.roundTextBox4.TabIndex = 8;
            this.roundTextBox4.textboxRadius = 15;
            this.roundTextBox4.UseSystemPasswordChar = false;
            // 
            // roundTextBox3
            // 
            this.roundTextBox3.BackColor = System.Drawing.Color.Transparent;
            this.roundTextBox3.BorderColor = System.Drawing.Color.Gray;
            this.roundTextBox3.BorderSize = 1;
            this.roundTextBox3.Br = System.Drawing.Color.White;
            this.roundTextBox3.Font = new System.Drawing.Font("Ebrima", 12F);
            this.roundTextBox3.ForeColor = System.Drawing.Color.Black;
            this.roundTextBox3.Location = new System.Drawing.Point(12, 200);
            this.roundTextBox3.Name = "roundTextBox3";
            this.roundTextBox3.PasswordChar = '\0';
            this.roundTextBox3.Size = new System.Drawing.Size(216, 33);
            this.roundTextBox3.TabIndex = 4;
            this.roundTextBox3.textboxRadius = 15;
            this.roundTextBox3.UseSystemPasswordChar = false;
            // 
            // roundTextBox2
            // 
            this.roundTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.roundTextBox2.BorderColor = System.Drawing.Color.Gray;
            this.roundTextBox2.BorderSize = 1;
            this.roundTextBox2.Br = System.Drawing.Color.White;
            this.roundTextBox2.Font = new System.Drawing.Font("Ebrima", 12F);
            this.roundTextBox2.ForeColor = System.Drawing.Color.Black;
            this.roundTextBox2.Location = new System.Drawing.Point(12, 137);
            this.roundTextBox2.Name = "roundTextBox2";
            this.roundTextBox2.PasswordChar = '\0';
            this.roundTextBox2.Size = new System.Drawing.Size(216, 33);
            this.roundTextBox2.TabIndex = 3;
            this.roundTextBox2.textboxRadius = 15;
            this.roundTextBox2.UseSystemPasswordChar = false;
            // 
            // roundTextBox1
            // 
            this.roundTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.roundTextBox1.BorderColor = System.Drawing.Color.Gray;
            this.roundTextBox1.BorderSize = 1;
            this.roundTextBox1.Br = System.Drawing.Color.White;
            this.roundTextBox1.Font = new System.Drawing.Font("Ebrima", 12F);
            this.roundTextBox1.ForeColor = System.Drawing.Color.Black;
            this.roundTextBox1.Location = new System.Drawing.Point(12, 70);
            this.roundTextBox1.Name = "roundTextBox1";
            this.roundTextBox1.PasswordChar = '\0';
            this.roundTextBox1.Size = new System.Drawing.Size(216, 33);
            this.roundTextBox1.TabIndex = 2;
            this.roundTextBox1.textboxRadius = 15;
            this.roundTextBox1.UseSystemPasswordChar = false;
            // 
            // AddStudentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 247);
            this.Controls.Add(this.addStudButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FilterComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roundTextBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.roundTextBox3);
            this.Controls.Add(this.roundTextBox2);
            this.Controls.Add(this.roundTextBox1);
            this.Controls.Add(this.TopBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStudentWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudentWindow";
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Label CloseButton;
        private CustomUI.Textbox.RoundTextBox roundTextBox1;
        private CustomUI.Textbox.RoundTextBox roundTextBox2;
        private CustomUI.Textbox.RoundTextBox roundTextBox3;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CustomUI.Textbox.RoundTextBox roundTextBox4;
        private System.Windows.Forms.ComboBox FilterComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addStudButton;
    }
}