
namespace Financial_System.Forms
{
    partial class ChangePasswordWindow
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
            this.label5 = new System.Windows.Forms.Label();
            this.CurrUserTextBox = new Financial_System.CustomUI.Textbox.RoundTextBox();
            this.UpdatePassButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NewPassTextBox = new Financial_System.CustomUI.Textbox.RoundTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrPassTextBox = new Financial_System.CustomUI.Textbox.RoundTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NewUserTextBox = new Financial_System.CustomUI.Textbox.RoundTextBox();
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
            this.TopBarPanel.Size = new System.Drawing.Size(486, 30);
            this.TopBarPanel.TabIndex = 2;
            this.TopBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBarPanel_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.CloseButton.ForeColor = System.Drawing.Color.Red;
            this.CloseButton.Location = new System.Drawing.Point(462, 6);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(18, 18);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(19, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Current Username";
            // 
            // CurrUserTextBox
            // 
            this.CurrUserTextBox.BackColor = System.Drawing.Color.Transparent;
            this.CurrUserTextBox.BorderColor = System.Drawing.Color.Gray;
            this.CurrUserTextBox.BorderSize = 1;
            this.CurrUserTextBox.Br = System.Drawing.Color.White;
            this.CurrUserTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CurrUserTextBox.ForeColor = System.Drawing.Color.Black;
            this.CurrUserTextBox.Location = new System.Drawing.Point(12, 61);
            this.CurrUserTextBox.Name = "CurrUserTextBox";
            this.CurrUserTextBox.PasswordChar = '\0';
            this.CurrUserTextBox.Size = new System.Drawing.Size(216, 33);
            this.CurrUserTextBox.TabIndex = 15;
            this.CurrUserTextBox.textboxRadius = 15;
            this.CurrUserTextBox.UseSystemPasswordChar = false;
            // 
            // UpdatePassButton
            // 
            this.UpdatePassButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(116)))));
            this.UpdatePassButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdatePassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdatePassButton.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UpdatePassButton.ForeColor = System.Drawing.Color.White;
            this.UpdatePassButton.Location = new System.Drawing.Point(254, 179);
            this.UpdatePassButton.Name = "UpdatePassButton";
            this.UpdatePassButton.Size = new System.Drawing.Size(216, 33);
            this.UpdatePassButton.TabIndex = 19;
            this.UpdatePassButton.Text = "Update";
            this.UpdatePassButton.UseVisualStyleBackColor = false;
            this.UpdatePassButton.Click += new System.EventHandler(this.UpdatePassButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(261, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "New Password";
            // 
            // NewPassTextBox
            // 
            this.NewPassTextBox.BackColor = System.Drawing.Color.Transparent;
            this.NewPassTextBox.BorderColor = System.Drawing.Color.Gray;
            this.NewPassTextBox.BorderSize = 1;
            this.NewPassTextBox.Br = System.Drawing.Color.White;
            this.NewPassTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NewPassTextBox.ForeColor = System.Drawing.Color.Black;
            this.NewPassTextBox.Location = new System.Drawing.Point(254, 121);
            this.NewPassTextBox.Name = "NewPassTextBox";
            this.NewPassTextBox.PasswordChar = '\0';
            this.NewPassTextBox.Size = new System.Drawing.Size(216, 33);
            this.NewPassTextBox.TabIndex = 20;
            this.NewPassTextBox.textboxRadius = 15;
            this.NewPassTextBox.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(19, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Current Password";
            // 
            // CurrPassTextBox
            // 
            this.CurrPassTextBox.BackColor = System.Drawing.Color.Transparent;
            this.CurrPassTextBox.BorderColor = System.Drawing.Color.Gray;
            this.CurrPassTextBox.BorderSize = 1;
            this.CurrPassTextBox.Br = System.Drawing.Color.White;
            this.CurrPassTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CurrPassTextBox.ForeColor = System.Drawing.Color.Black;
            this.CurrPassTextBox.Location = new System.Drawing.Point(12, 121);
            this.CurrPassTextBox.Name = "CurrPassTextBox";
            this.CurrPassTextBox.PasswordChar = '\0';
            this.CurrPassTextBox.Size = new System.Drawing.Size(216, 33);
            this.CurrPassTextBox.TabIndex = 22;
            this.CurrPassTextBox.textboxRadius = 15;
            this.CurrPassTextBox.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(261, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "New Username";
            // 
            // NewUserTextBox
            // 
            this.NewUserTextBox.BackColor = System.Drawing.Color.Transparent;
            this.NewUserTextBox.BorderColor = System.Drawing.Color.Gray;
            this.NewUserTextBox.BorderSize = 1;
            this.NewUserTextBox.Br = System.Drawing.Color.White;
            this.NewUserTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NewUserTextBox.ForeColor = System.Drawing.Color.Black;
            this.NewUserTextBox.Location = new System.Drawing.Point(254, 61);
            this.NewUserTextBox.Name = "NewUserTextBox";
            this.NewUserTextBox.PasswordChar = '\0';
            this.NewUserTextBox.Size = new System.Drawing.Size(216, 33);
            this.NewUserTextBox.TabIndex = 24;
            this.NewUserTextBox.textboxRadius = 15;
            this.NewUserTextBox.UseSystemPasswordChar = false;
            // 
            // ChangePasswordWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(486, 227);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewUserTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrPassTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewPassTextBox);
            this.Controls.Add(this.UpdatePassButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CurrUserTextBox);
            this.Controls.Add(this.TopBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePasswordWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePasswordWindow";
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label5;
        private CustomUI.Textbox.RoundTextBox CurrUserTextBox;
        private System.Windows.Forms.Button UpdatePassButton;
        private System.Windows.Forms.Label label2;
        private CustomUI.Textbox.RoundTextBox NewPassTextBox;
        private System.Windows.Forms.Label label1;
        private CustomUI.Textbox.RoundTextBox CurrPassTextBox;
        private System.Windows.Forms.Label label3;
        private CustomUI.Textbox.RoundTextBox NewUserTextBox;
    }
}