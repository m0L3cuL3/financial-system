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
            this.AmountTextBox = new Financial_System.CustomUI.Textbox.RoundTextBox();
            this.TypeTextBox = new Financial_System.CustomUI.Textbox.RoundTextBox();
            this.StudentIDTextBox = new Financial_System.CustomUI.Textbox.RoundTextBox();
            this.ReceiptNumTextBox = new Financial_System.CustomUI.Textbox.RoundTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // postpaymentbtn
            // 
            this.postpaymentbtn.Location = new System.Drawing.Point(617, 392);
            this.postpaymentbtn.Name = "postpaymentbtn";
            this.postpaymentbtn.Size = new System.Drawing.Size(151, 25);
            this.postpaymentbtn.TabIndex = 0;
            this.postpaymentbtn.Text = "Post Payment";
            this.postpaymentbtn.UseVisualStyleBackColor = true;
            this.postpaymentbtn.Click += new System.EventHandler(this.postpaymentbtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(460, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "Post Payment";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.BackColor = System.Drawing.Color.Transparent;
            this.AmountTextBox.BorderColor = System.Drawing.Color.Gray;
            this.AmountTextBox.BorderSize = 1;
            this.AmountTextBox.Br = System.Drawing.Color.White;
            this.AmountTextBox.Font = new System.Drawing.Font("Ebrima", 12F);
            this.AmountTextBox.ForeColor = System.Drawing.Color.Black;
            this.AmountTextBox.Location = new System.Drawing.Point(27, 108);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.PasswordChar = '\0';
            this.AmountTextBox.Size = new System.Drawing.Size(135, 33);
            this.AmountTextBox.TabIndex = 2;
            this.AmountTextBox.textboxRadius = 15;
            this.AmountTextBox.UseSystemPasswordChar = false;
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.BackColor = System.Drawing.Color.Transparent;
            this.TypeTextBox.BorderColor = System.Drawing.Color.Gray;
            this.TypeTextBox.BorderSize = 1;
            this.TypeTextBox.Br = System.Drawing.Color.White;
            this.TypeTextBox.Font = new System.Drawing.Font("Ebrima", 12F);
            this.TypeTextBox.ForeColor = System.Drawing.Color.Black;
            this.TypeTextBox.Location = new System.Drawing.Point(27, 178);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.PasswordChar = '\0';
            this.TypeTextBox.Size = new System.Drawing.Size(135, 33);
            this.TypeTextBox.TabIndex = 3;
            this.TypeTextBox.textboxRadius = 15;
            this.TypeTextBox.UseSystemPasswordChar = false;
            // 
            // StudentIDTextBox
            // 
            this.StudentIDTextBox.BackColor = System.Drawing.Color.Transparent;
            this.StudentIDTextBox.BorderColor = System.Drawing.Color.Gray;
            this.StudentIDTextBox.BorderSize = 1;
            this.StudentIDTextBox.Br = System.Drawing.Color.White;
            this.StudentIDTextBox.Font = new System.Drawing.Font("Ebrima", 12F);
            this.StudentIDTextBox.ForeColor = System.Drawing.Color.Black;
            this.StudentIDTextBox.Location = new System.Drawing.Point(27, 44);
            this.StudentIDTextBox.Name = "StudentIDTextBox";
            this.StudentIDTextBox.PasswordChar = '\0';
            this.StudentIDTextBox.Size = new System.Drawing.Size(135, 33);
            this.StudentIDTextBox.TabIndex = 4;
            this.StudentIDTextBox.textboxRadius = 15;
            this.StudentIDTextBox.UseSystemPasswordChar = false;
            // 
            // ReceiptNumTextBox
            // 
            this.ReceiptNumTextBox.BackColor = System.Drawing.Color.Transparent;
            this.ReceiptNumTextBox.BorderColor = System.Drawing.Color.Gray;
            this.ReceiptNumTextBox.BorderSize = 1;
            this.ReceiptNumTextBox.Br = System.Drawing.Color.White;
            this.ReceiptNumTextBox.Font = new System.Drawing.Font("Ebrima", 12F);
            this.ReceiptNumTextBox.ForeColor = System.Drawing.Color.Black;
            this.ReceiptNumTextBox.Location = new System.Drawing.Point(27, 247);
            this.ReceiptNumTextBox.Name = "ReceiptNumTextBox";
            this.ReceiptNumTextBox.PasswordChar = '\0';
            this.ReceiptNumTextBox.Size = new System.Drawing.Size(135, 33);
            this.ReceiptNumTextBox.TabIndex = 5;
            this.ReceiptNumTextBox.textboxRadius = 15;
            this.ReceiptNumTextBox.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Student ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 231);
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
            this.Controls.Add(this.ReceiptNumTextBox);
            this.Controls.Add(this.StudentIDTextBox);
            this.Controls.Add(this.TypeTextBox);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.postpaymentbtn);
            this.Name = "InsertTestTransactionControl";
            this.Size = new System.Drawing.Size(800, 440);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button postpaymentbtn;
        private System.Windows.Forms.Button button2;
        private CustomUI.Textbox.RoundTextBox AmountTextBox;
        private CustomUI.Textbox.RoundTextBox TypeTextBox;
        private CustomUI.Textbox.RoundTextBox StudentIDTextBox;
        private CustomUI.Textbox.RoundTextBox ReceiptNumTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
