
namespace Financial_System.Forms
{
    partial class LoginWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWindow));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.LogoImgBox = new System.Windows.Forms.PictureBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.IsAdminCheckBox = new System.Windows.Forms.CheckBox();
            this.passTextBox = new Financial_System.CustomUI.Textbox.RoundTextBox();
            this.userTextBox = new Financial_System.CustomUI.Textbox.RoundTextBox();
            this.TopPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.CloseButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(289, 26);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.Red;
            this.CloseButton.Location = new System.Drawing.Point(266, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(18, 18);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.LogoPanel.Controls.Add(this.TitleLabel);
            this.LogoPanel.Controls.Add(this.LogoImgBox);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 26);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(289, 183);
            this.LogoPanel.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(48, 146);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(204, 22);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "PCHS Finance System";
            // 
            // LogoImgBox
            // 
            this.LogoImgBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoImgBox.Image")));
            this.LogoImgBox.Location = new System.Drawing.Point(72, 6);
            this.LogoImgBox.Name = "LogoImgBox";
            this.LogoImgBox.Size = new System.Drawing.Size(144, 137);
            this.LogoImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoImgBox.TabIndex = 0;
            this.LogoImgBox.TabStop = false;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.Color.DimGray;
            this.userLabel.Location = new System.Drawing.Point(50, 244);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(71, 17);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "Username";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.ForeColor = System.Drawing.Color.DimGray;
            this.passLabel.Location = new System.Drawing.Point(50, 312);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(69, 17);
            this.passLabel.TabIndex = 4;
            this.passLabel.Text = "Password";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(116)))));
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(82, 385);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(124, 31);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // IsAdminCheckBox
            // 
            this.IsAdminCheckBox.AutoSize = true;
            this.IsAdminCheckBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.IsAdminCheckBox.Location = new System.Drawing.Point(59, 450);
            this.IsAdminCheckBox.Name = "IsAdminCheckBox";
            this.IsAdminCheckBox.Size = new System.Drawing.Size(170, 21);
            this.IsAdminCheckBox.TabIndex = 7;
            this.IsAdminCheckBox.Text = "Login As Administrator";
            this.IsAdminCheckBox.UseVisualStyleBackColor = true;
            this.IsAdminCheckBox.CheckedChanged += new System.EventHandler(this.IsAdminCheckBox_CheckedChanged);
            // 
            // passTextBox
            // 
            this.passTextBox.BackColor = System.Drawing.Color.Transparent;
            this.passTextBox.BorderColor = System.Drawing.Color.Gray;
            this.passTextBox.BorderSize = 1;
            this.passTextBox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.passTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passTextBox.ForeColor = System.Drawing.Color.Black;
            this.passTextBox.Location = new System.Drawing.Point(44, 332);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '●';
            this.passTextBox.Size = new System.Drawing.Size(200, 33);
            this.passTextBox.TabIndex = 3;
            this.passTextBox.textboxRadius = 15;
            this.passTextBox.UseSystemPasswordChar = true;
            // 
            // userTextBox
            // 
            this.userTextBox.BackColor = System.Drawing.Color.Transparent;
            this.userTextBox.BorderColor = System.Drawing.Color.Gray;
            this.userTextBox.BorderSize = 1;
            this.userTextBox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.userTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userTextBox.ForeColor = System.Drawing.Color.Black;
            this.userTextBox.Location = new System.Drawing.Point(44, 264);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.PasswordChar = '\0';
            this.userTextBox.Size = new System.Drawing.Size(200, 33);
            this.userTextBox.TabIndex = 2;
            this.userTextBox.textboxRadius = 15;
            this.userTextBox.UseSystemPasswordChar = false;
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(289, 503);
            this.Controls.Add(this.IsAdminCheckBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.LogoPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginWindow_FormClosing);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.PictureBox LogoImgBox;
        private System.Windows.Forms.Label TitleLabel;
        private CustomUI.Textbox.RoundTextBox userTextBox;
        private CustomUI.Textbox.RoundTextBox passTextBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.CheckBox IsAdminCheckBox;
    }
}