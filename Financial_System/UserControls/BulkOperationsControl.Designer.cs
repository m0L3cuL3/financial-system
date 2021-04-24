namespace Financial_System.UserControls
{
    partial class BulkOperationsControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addFeebtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addPaymentbtn = new System.Windows.Forms.Button();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.payment_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feepayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fgfamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeToGroup = new System.Windows.Forms.Button();
            this.FGFlabel = new System.Windows.Forms.Label();
            this.removeFeebtn = new System.Windows.Forms.Button();
            this.paymenttoGroupbtn = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newGroupbtn = new System.Windows.Forms.Button();
            this.totallbl = new System.Windows.Forms.Label();
            this.paymentlbl = new System.Windows.Forms.Label();
            this.amountlbl = new System.Windows.Forms.Label();
            this.execute = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newList = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.listid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listdesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fee Templates";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.amount});
            this.dataGridView1.Location = new System.Drawing.Point(7, 32);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(208, 178);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.Leave += new System.EventHandler(this.dataGridView1_Leave);
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id.Width = 35;
            // 
            // name
            // 
            this.name.Frozen = true;
            this.name.HeaderText = "Fee Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.Frozen = true;
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Width = 70;
            // 
            // addFeebtn
            // 
            this.addFeebtn.Location = new System.Drawing.Point(136, 7);
            this.addFeebtn.Name = "addFeebtn";
            this.addFeebtn.Size = new System.Drawing.Size(79, 23);
            this.addFeebtn.TabIndex = 3;
            this.addFeebtn.Text = "Add Fee";
            this.addFeebtn.UseVisualStyleBackColor = true;
            this.addFeebtn.Click += new System.EventHandler(this.addFeebtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label2.Location = new System.Drawing.Point(6, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Payment Templates";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView2.Location = new System.Drawing.Point(7, 255);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(208, 178);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            this.dataGridView2.Leave += new System.EventHandler(this.dataGridView2_Leave);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 35;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Payment Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.Frozen = true;
            this.dataGridViewTextBoxColumn5.HeaderText = "Payment";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // addPaymentbtn
            // 
            this.addPaymentbtn.Location = new System.Drawing.Point(136, 232);
            this.addPaymentbtn.Name = "addPaymentbtn";
            this.addPaymentbtn.Size = new System.Drawing.Size(79, 23);
            this.addPaymentbtn.TabIndex = 7;
            this.addPaymentbtn.Text = "Add Payment";
            this.addPaymentbtn.UseVisualStyleBackColor = true;
            this.addPaymentbtn.Click += new System.EventHandler(this.addPaymentbtn_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.Location = new System.Drawing.Point(9, 444);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(103, 23);
            this.refreshbtn.TabIndex = 8;
            this.refreshbtn.Text = "Refresh Tables";
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.payment_id,
            this.feepayment,
            this.dataGridViewTextBoxColumn8,
            this.fgfamount});
            this.dataGridView3.Location = new System.Drawing.Point(256, 45);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(259, 372);
            this.dataGridView3.TabIndex = 9;
            this.dataGridView3.Leave += new System.EventHandler(this.dataGridView3_Leave);
            // 
            // payment_id
            // 
            this.payment_id.Frozen = true;
            this.payment_id.HeaderText = "id";
            this.payment_id.Name = "payment_id";
            this.payment_id.ReadOnly = true;
            this.payment_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.payment_id.Width = 35;
            // 
            // feepayment
            // 
            this.feepayment.Frozen = true;
            this.feepayment.HeaderText = "Fee/Payment";
            this.feepayment.Name = "feepayment";
            this.feepayment.ReadOnly = true;
            this.feepayment.Width = 120;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.Frozen = true;
            this.dataGridViewTextBoxColumn8.HeaderText = "Payment";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 50;
            // 
            // fgfamount
            // 
            this.fgfamount.HeaderText = "Amount";
            this.fgfamount.Name = "fgfamount";
            this.fgfamount.ReadOnly = true;
            this.fgfamount.Width = 50;
            // 
            // feeToGroup
            // 
            this.feeToGroup.Location = new System.Drawing.Point(221, 69);
            this.feeToGroup.Name = "feeToGroup";
            this.feeToGroup.Size = new System.Drawing.Size(29, 49);
            this.feeToGroup.TabIndex = 10;
            this.feeToGroup.Text = ">>";
            this.feeToGroup.UseVisualStyleBackColor = true;
            this.feeToGroup.Click += new System.EventHandler(this.feeToGroup_Click);
            // 
            // FGFlabel
            // 
            this.FGFlabel.AutoSize = true;
            this.FGFlabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FGFlabel.Location = new System.Drawing.Point(253, 6);
            this.FGFlabel.Name = "FGFlabel";
            this.FGFlabel.Size = new System.Drawing.Size(292, 16);
            this.FGFlabel.TabIndex = 11;
            this.FGFlabel.Text = "Select a Fee Goup on the right to Populate this table";
            // 
            // removeFeebtn
            // 
            this.removeFeebtn.Location = new System.Drawing.Point(221, 148);
            this.removeFeebtn.Name = "removeFeebtn";
            this.removeFeebtn.Size = new System.Drawing.Size(29, 182);
            this.removeFeebtn.TabIndex = 12;
            this.removeFeebtn.Text = "<<";
            this.removeFeebtn.UseVisualStyleBackColor = true;
            this.removeFeebtn.Click += new System.EventHandler(this.removeFeebtn_Click);
            // 
            // paymenttoGroupbtn
            // 
            this.paymenttoGroupbtn.Location = new System.Drawing.Point(221, 369);
            this.paymenttoGroupbtn.Name = "paymenttoGroupbtn";
            this.paymenttoGroupbtn.Size = new System.Drawing.Size(29, 49);
            this.paymenttoGroupbtn.TabIndex = 13;
            this.paymenttoGroupbtn.Text = ">>";
            this.paymenttoGroupbtn.UseVisualStyleBackColor = true;
            this.paymenttoGroupbtn.Click += new System.EventHandler(this.paymenttoGroupbtn_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView4.Location = new System.Drawing.Point(18, 44);
            this.dataGridView4.MultiSelect = false;
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(258, 166);
            this.dataGridView4.TabIndex = 15;
            this.dataGridView4.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellClick);
            this.dataGridView4.SelectionChanged += new System.EventHandler(this.dataGridView4_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.Width = 35;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.Frozen = true;
            this.dataGridViewTextBoxColumn6.HeaderText = "Group Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.Frozen = true;
            this.dataGridViewTextBoxColumn7.HeaderText = "Description";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 120;
            // 
            // newGroupbtn
            // 
            this.newGroupbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGroupbtn.Location = new System.Drawing.Point(192, 19);
            this.newGroupbtn.Name = "newGroupbtn";
            this.newGroupbtn.Size = new System.Drawing.Size(84, 23);
            this.newGroupbtn.TabIndex = 16;
            this.newGroupbtn.Text = "New Group";
            this.newGroupbtn.UseVisualStyleBackColor = true;
            this.newGroupbtn.Click += new System.EventHandler(this.newGroupbtn_Click);
            // 
            // totallbl
            // 
            this.totallbl.AutoSize = true;
            this.totallbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallbl.Location = new System.Drawing.Point(402, 421);
            this.totallbl.Name = "totallbl";
            this.totallbl.Size = new System.Drawing.Size(44, 16);
            this.totallbl.TabIndex = 18;
            this.totallbl.Text = "Total";
            // 
            // paymentlbl
            // 
            this.paymentlbl.AutoSize = true;
            this.paymentlbl.Location = new System.Drawing.Point(418, 29);
            this.paymentlbl.Name = "paymentlbl";
            this.paymentlbl.Size = new System.Drawing.Size(48, 13);
            this.paymentlbl.TabIndex = 19;
            this.paymentlbl.Text = "Payment";
            // 
            // amountlbl
            // 
            this.amountlbl.AutoSize = true;
            this.amountlbl.Location = new System.Drawing.Point(471, 29);
            this.amountlbl.Name = "amountlbl";
            this.amountlbl.Size = new System.Drawing.Size(43, 13);
            this.amountlbl.TabIndex = 20;
            this.amountlbl.Text = "Amount";
            // 
            // execute
            // 
            this.execute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(116)))));
            this.execute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.execute.ForeColor = System.Drawing.Color.White;
            this.execute.Location = new System.Drawing.Point(18, 418);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(258, 38);
            this.execute.TabIndex = 22;
            this.execute.Text = "Execute Fee Group against Student List";
            this.execute.UseVisualStyleBackColor = false;
            this.execute.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.newList);
            this.groupBox1.Controls.Add(this.dataGridView5);
            this.groupBox1.Controls.Add(this.execute);
            this.groupBox1.Controls.Add(this.dataGridView4);
            this.groupBox1.Controls.Add(this.newGroupbtn);
            this.groupBox1.Location = new System.Drawing.Point(558, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 461);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apply Bulk Operations";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label4.Location = new System.Drawing.Point(14, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Student Lists";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label3.Location = new System.Drawing.Point(14, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Fee Group";
            // 
            // newList
            // 
            this.newList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newList.Location = new System.Drawing.Point(192, 233);
            this.newList.Name = "newList";
            this.newList.Size = new System.Drawing.Size(84, 23);
            this.newList.TabIndex = 23;
            this.newList.Text = "New List";
            this.newList.UseVisualStyleBackColor = true;
            this.newList.Click += new System.EventHandler(this.newList_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AllowUserToResizeColumns = false;
            this.dataGridView5.AllowUserToResizeRows = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.listid,
            this.listname,
            this.listdesc});
            this.dataGridView5.Location = new System.Drawing.Point(18, 262);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersVisible = false;
            this.dataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView5.Size = new System.Drawing.Size(258, 150);
            this.dataGridView5.TabIndex = 0;
            this.dataGridView5.SelectionChanged += new System.EventHandler(this.dataGridView5_SelectionChanged);
            // 
            // listid
            // 
            this.listid.HeaderText = "id";
            this.listid.Name = "listid";
            this.listid.Width = 30;
            // 
            // listname
            // 
            this.listname.HeaderText = "List Name";
            this.listname.Name = "listname";
            // 
            // listdesc
            // 
            this.listdesc.HeaderText = "Description";
            this.listdesc.Name = "listdesc";
            this.listdesc.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(253, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Fees/Payments in Group";
            // 
            // BulkOperationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.amountlbl);
            this.Controls.Add(this.paymentlbl);
            this.Controls.Add(this.totallbl);
            this.Controls.Add(this.paymenttoGroupbtn);
            this.Controls.Add(this.removeFeebtn);
            this.Controls.Add(this.FGFlabel);
            this.Controls.Add(this.feeToGroup);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.addPaymentbtn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addFeebtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "BulkOperationsControl";
            this.Size = new System.Drawing.Size(848, 478);
            this.Load += new System.EventHandler(this.BulkOperationsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addFeebtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button addPaymentbtn;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button feeToGroup;
        private System.Windows.Forms.Label FGFlabel;
        private System.Windows.Forms.Button removeFeebtn;
        private System.Windows.Forms.Button paymenttoGroupbtn;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button newGroupbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn feepayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn fgfamount;
        private System.Windows.Forms.Label totallbl;
        private System.Windows.Forms.Label paymentlbl;
        private System.Windows.Forms.Label amountlbl;
        private System.Windows.Forms.Button execute;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button newList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn listid;
        private System.Windows.Forms.DataGridViewTextBoxColumn listname;
        private System.Windows.Forms.DataGridViewTextBoxColumn listdesc;
    }
}
