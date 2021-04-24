namespace Financial_System.Forms
{
    partial class EditFeeWindow
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
            this.updatebtn = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.TextBox();
            this.desc = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.amountlbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.titlelbl = new System.Windows.Forms.Label();
            this.deletebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.updatebtn.Location = new System.Drawing.Point(214, 327);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(75, 23);
            this.updatebtn.TabIndex = 11;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(202, 86);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(62, 20);
            this.amount.TabIndex = 8;
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(38, 148);
            this.desc.Multiline = true;
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(225, 146);
            this.desc.TabIndex = 9;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(39, 86);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(148, 20);
            this.name.TabIndex = 7;
            // 
            // amountlbl
            // 
            this.amountlbl.AutoSize = true;
            this.amountlbl.Location = new System.Drawing.Point(199, 70);
            this.amountlbl.Name = "amountlbl";
            this.amountlbl.Size = new System.Drawing.Size(43, 13);
            this.amountlbl.TabIndex = 13;
            this.amountlbl.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Description";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(36, 70);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(56, 13);
            this.namelbl.TabIndex = 10;
            this.namelbl.Text = "Fee Name";
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.titlelbl.Location = new System.Drawing.Point(68, 27);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(164, 20);
            this.titlelbl.TabIndex = 6;
            this.titlelbl.Text = "Edit/Delete Particular";
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Coral;
            this.deletebtn.Location = new System.Drawing.Point(12, 327);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 14;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // EditFeeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 362);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.name);
            this.Controls.Add(this.amountlbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.titlelbl);
            this.Name = "EditFeeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Fee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label amountlbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.Button deletebtn;
    }
}