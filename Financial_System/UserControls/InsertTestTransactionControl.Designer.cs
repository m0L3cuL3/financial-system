namespace Financial_System.UserControls
{
    partial class InsertTestTransactionControl
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
            this.postpaymentbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.amount = new Financial_System.CustomUI.Textbox.RoundTextBox();
            this.type = new Financial_System.CustomUI.Textbox.RoundTextBox();
            this.sid = new Financial_System.CustomUI.Textbox.RoundTextBox();
            this.receipt = new Financial_System.CustomUI.Textbox.RoundTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // postpaymentbtn
            // 
            this.postpaymentbtn.Location = new System.Drawing.Point(428, 240);
            this.postpaymentbtn.Name = "postpaymentbtn";
            this.postpaymentbtn.Size = new System.Drawing.Size(151, 25);
            this.postpaymentbtn.TabIndex = 0;
            this.postpaymentbtn.Text = "Post Payment";
            this.postpaymentbtn.UseVisualStyleBackColor = true;
            this.postpaymentbtn.Click += new System.EventHandler(this.postpaymentbtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "Post Payment";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // amount
            // 
            this.amount.BackColor = System.Drawing.Color.Transparent;
            this.amount.BorderColor = System.Drawing.Color.Gray;
            this.amount.BorderSize = 1;
            this.amount.Br = System.Drawing.Color.White;
            this.amount.Font = new System.Drawing.Font("Ebrima", 12F);
            this.amount.ForeColor = System.Drawing.Color.Black;
            this.amount.Location = new System.Drawing.Point(51, 36);
            this.amount.Name = "amount";
            this.amount.PasswordChar = '\0';
            this.amount.Size = new System.Drawing.Size(135, 33);
            this.amount.TabIndex = 2;
            this.amount.Text = "roundTextBox1";
            this.amount.textboxRadius = 15;
            this.amount.UseSystemPasswordChar = false;
            // 
            // type
            // 
            this.type.BackColor = System.Drawing.Color.Transparent;
            this.type.BorderColor = System.Drawing.Color.Gray;
            this.type.BorderSize = 1;
            this.type.Br = System.Drawing.Color.White;
            this.type.Font = new System.Drawing.Font("Ebrima", 12F);
            this.type.ForeColor = System.Drawing.Color.Black;
            this.type.Location = new System.Drawing.Point(51, 129);
            this.type.Name = "type";
            this.type.PasswordChar = '\0';
            this.type.Size = new System.Drawing.Size(135, 33);
            this.type.TabIndex = 3;
            this.type.Text = "roundTextBox2";
            this.type.textboxRadius = 15;
            this.type.UseSystemPasswordChar = false;
            // 
            // sid
            // 
            this.sid.BackColor = System.Drawing.Color.Transparent;
            this.sid.BorderColor = System.Drawing.Color.Gray;
            this.sid.BorderSize = 1;
            this.sid.Br = System.Drawing.Color.White;
            this.sid.Font = new System.Drawing.Font("Ebrima", 12F);
            this.sid.ForeColor = System.Drawing.Color.Black;
            this.sid.Location = new System.Drawing.Point(277, 36);
            this.sid.Name = "sid";
            this.sid.PasswordChar = '\0';
            this.sid.Size = new System.Drawing.Size(135, 33);
            this.sid.TabIndex = 4;
            this.sid.Text = "roundTextBox3";
            this.sid.textboxRadius = 15;
            this.sid.UseSystemPasswordChar = false;
            // 
            // receipt
            // 
            this.receipt.BackColor = System.Drawing.Color.Transparent;
            this.receipt.BorderColor = System.Drawing.Color.Gray;
            this.receipt.BorderSize = 1;
            this.receipt.Br = System.Drawing.Color.White;
            this.receipt.Font = new System.Drawing.Font("Ebrima", 12F);
            this.receipt.ForeColor = System.Drawing.Color.Black;
            this.receipt.Location = new System.Drawing.Point(277, 129);
            this.receipt.Name = "receipt";
            this.receipt.PasswordChar = '\0';
            this.receipt.Size = new System.Drawing.Size(135, 33);
            this.receipt.TabIndex = 5;
            this.receipt.Text = "roundTextBox4";
            this.receipt.textboxRadius = 15;
            this.receipt.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Student ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Receipt #";
            // 
            // InsertTestTransactionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.receipt);
            this.Controls.Add(this.sid);
            this.Controls.Add(this.type);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.postpaymentbtn);
            this.Name = "InsertTestTransactionControl";
            this.Size = new System.Drawing.Size(622, 291);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button postpaymentbtn;
        private System.Windows.Forms.Button button2;
        private CustomUI.Textbox.RoundTextBox amount;
        private CustomUI.Textbox.RoundTextBox type;
        private CustomUI.Textbox.RoundTextBox sid;
        private CustomUI.Textbox.RoundTextBox receipt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
