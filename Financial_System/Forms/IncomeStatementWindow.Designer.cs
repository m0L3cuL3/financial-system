
namespace Financial_System.Forms
{
    partial class IncomeStatementWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncomeStatementWindow));
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Revenue_txtBox = new System.Windows.Forms.TextBox();
            this.Cgs_txtBox = new System.Windows.Forms.TextBox();
            this.RnD_txtBox = new System.Windows.Forms.TextBox();
            this.Sga_txtBox = new System.Windows.Forms.TextBox();
            this.AddInEx_txtBox = new System.Windows.Forms.TextBox();
            this.Ebit_txtBox = new System.Windows.Forms.TextBox();
            this.IntEx_txtBox = new System.Windows.Forms.TextBox();
            this.Ebt_txtBox = new System.Windows.Forms.TextBox();
            this.InTax_txtBox = new System.Windows.Forms.TextBox();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.CalcIncState_Btn = new System.Windows.Forms.Button();
            this.ListPanel2 = new Financial_System.CustomUI.GradientPanel();
            this.TotalNetIncome_Lbl = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.TotalOperatingIncome_Lbl = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.TotalGrossProfit_Lbl = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.ListPanel = new Financial_System.CustomUI.GradientPanel();
            this.InTax_Lbl = new System.Windows.Forms.Label();
            this.Ebt_Lbl = new System.Windows.Forms.Label();
            this.IntExp_Lbl = new System.Windows.Forms.Label();
            this.Ebit_Lbl = new System.Windows.Forms.Label();
            this.AddInEx_Lbl = new System.Windows.Forms.Label();
            this.Sga_Lbl = new System.Windows.Forms.Label();
            this.RnD_Lbl = new System.Windows.Forms.Label();
            this.Cgs_Lbl = new System.Windows.Forms.Label();
            this.Revenue_Lbl = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ExportToExcel_Btn = new System.Windows.Forms.Button();
            this.TopBarPanel.SuspendLayout();
            this.GroupBox.SuspendLayout();
            this.ListPanel2.SuspendLayout();
            this.ListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.TopBarPanel.Controls.Add(this.CloseButton);
            this.TopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBarPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(743, 30);
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
            this.CloseButton.Location = new System.Drawing.Point(719, 6);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(18, 18);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Revenue:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cost of Goods Sold:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Research && Development:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(188, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sales, General && Admin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Additional Income/Expenses:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Earnings Before Interest && Tax:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(188, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Interest Expense:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(187, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Earnings Before Tax:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(91, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Income Tax:";
            // 
            // Revenue_txtBox
            // 
            this.Revenue_txtBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Revenue_txtBox.Location = new System.Drawing.Point(9, 46);
            this.Revenue_txtBox.Name = "Revenue_txtBox";
            this.Revenue_txtBox.Size = new System.Drawing.Size(161, 21);
            this.Revenue_txtBox.TabIndex = 13;
            this.Revenue_txtBox.TextChanged += new System.EventHandler(this.Revenue_txtBox_TextChanged);
            // 
            // Cgs_txtBox
            // 
            this.Cgs_txtBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cgs_txtBox.Location = new System.Drawing.Point(9, 108);
            this.Cgs_txtBox.Name = "Cgs_txtBox";
            this.Cgs_txtBox.Size = new System.Drawing.Size(161, 21);
            this.Cgs_txtBox.TabIndex = 14;
            this.Cgs_txtBox.TextChanged += new System.EventHandler(this.Cgs_txtBox_TextChanged);
            // 
            // RnD_txtBox
            // 
            this.RnD_txtBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RnD_txtBox.Location = new System.Drawing.Point(190, 46);
            this.RnD_txtBox.Name = "RnD_txtBox";
            this.RnD_txtBox.Size = new System.Drawing.Size(147, 21);
            this.RnD_txtBox.TabIndex = 15;
            this.RnD_txtBox.TextChanged += new System.EventHandler(this.RnD_txtBox_TextChanged);
            // 
            // Sga_txtBox
            // 
            this.Sga_txtBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sga_txtBox.Location = new System.Drawing.Point(191, 108);
            this.Sga_txtBox.Name = "Sga_txtBox";
            this.Sga_txtBox.Size = new System.Drawing.Size(147, 21);
            this.Sga_txtBox.TabIndex = 16;
            this.Sga_txtBox.TextChanged += new System.EventHandler(this.Sga_txtBox_TextChanged);
            // 
            // AddInEx_txtBox
            // 
            this.AddInEx_txtBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddInEx_txtBox.Location = new System.Drawing.Point(9, 172);
            this.AddInEx_txtBox.Name = "AddInEx_txtBox";
            this.AddInEx_txtBox.Size = new System.Drawing.Size(161, 21);
            this.AddInEx_txtBox.TabIndex = 17;
            this.AddInEx_txtBox.TextChanged += new System.EventHandler(this.AddInEx_txtBox_TextChanged);
            // 
            // Ebit_txtBox
            // 
            this.Ebit_txtBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ebit_txtBox.Location = new System.Drawing.Point(9, 234);
            this.Ebit_txtBox.Name = "Ebit_txtBox";
            this.Ebit_txtBox.Size = new System.Drawing.Size(161, 21);
            this.Ebit_txtBox.TabIndex = 18;
            this.Ebit_txtBox.TextChanged += new System.EventHandler(this.Ebit_txtBox_TextChanged);
            // 
            // IntEx_txtBox
            // 
            this.IntEx_txtBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntEx_txtBox.Location = new System.Drawing.Point(191, 172);
            this.IntEx_txtBox.Name = "IntEx_txtBox";
            this.IntEx_txtBox.Size = new System.Drawing.Size(147, 21);
            this.IntEx_txtBox.TabIndex = 19;
            this.IntEx_txtBox.TextChanged += new System.EventHandler(this.IntEx_txtBox_TextChanged);
            // 
            // Ebt_txtBox
            // 
            this.Ebt_txtBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ebt_txtBox.Location = new System.Drawing.Point(190, 234);
            this.Ebt_txtBox.Name = "Ebt_txtBox";
            this.Ebt_txtBox.Size = new System.Drawing.Size(147, 21);
            this.Ebt_txtBox.TabIndex = 20;
            this.Ebt_txtBox.TextChanged += new System.EventHandler(this.Ebt_txtBox_TextChanged);
            // 
            // InTax_txtBox
            // 
            this.InTax_txtBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InTax_txtBox.Location = new System.Drawing.Point(94, 300);
            this.InTax_txtBox.Name = "InTax_txtBox";
            this.InTax_txtBox.Size = new System.Drawing.Size(161, 21);
            this.InTax_txtBox.TabIndex = 21;
            this.InTax_txtBox.TextChanged += new System.EventHandler(this.InTax_txtBox_TextChanged);
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.CalcIncState_Btn);
            this.GroupBox.Controls.Add(this.label1);
            this.GroupBox.Controls.Add(this.InTax_txtBox);
            this.GroupBox.Controls.Add(this.label2);
            this.GroupBox.Controls.Add(this.Ebt_txtBox);
            this.GroupBox.Controls.Add(this.label3);
            this.GroupBox.Controls.Add(this.IntEx_txtBox);
            this.GroupBox.Controls.Add(this.label4);
            this.GroupBox.Controls.Add(this.Ebit_txtBox);
            this.GroupBox.Controls.Add(this.label5);
            this.GroupBox.Controls.Add(this.AddInEx_txtBox);
            this.GroupBox.Controls.Add(this.label6);
            this.GroupBox.Controls.Add(this.Sga_txtBox);
            this.GroupBox.Controls.Add(this.label7);
            this.GroupBox.Controls.Add(this.RnD_txtBox);
            this.GroupBox.Controls.Add(this.label8);
            this.GroupBox.Controls.Add(this.Cgs_txtBox);
            this.GroupBox.Controls.Add(this.label9);
            this.GroupBox.Controls.Add(this.Revenue_txtBox);
            this.GroupBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox.Location = new System.Drawing.Point(12, 36);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(347, 427);
            this.GroupBox.TabIndex = 22;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Set Values";
            // 
            // CalcIncState_Btn
            // 
            this.CalcIncState_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(116)))));
            this.CalcIncState_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalcIncState_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalcIncState_Btn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcIncState_Btn.ForeColor = System.Drawing.Color.White;
            this.CalcIncState_Btn.Location = new System.Drawing.Point(66, 372);
            this.CalcIncState_Btn.Name = "CalcIncState_Btn";
            this.CalcIncState_Btn.Size = new System.Drawing.Size(215, 34);
            this.CalcIncState_Btn.TabIndex = 41;
            this.CalcIncState_Btn.Text = "Calculate Income Statement";
            this.CalcIncState_Btn.UseVisualStyleBackColor = false;
            this.CalcIncState_Btn.Click += new System.EventHandler(this.CalcIncState_Btn_Click);
            // 
            // ListPanel2
            // 
            this.ListPanel2.Angle = 45F;
            this.ListPanel2.BottomColor = System.Drawing.Color.SteelBlue;
            this.ListPanel2.Controls.Add(this.TotalNetIncome_Lbl);
            this.ListPanel2.Controls.Add(this.label22);
            this.ListPanel2.Controls.Add(this.TotalOperatingIncome_Lbl);
            this.ListPanel2.Controls.Add(this.label20);
            this.ListPanel2.Controls.Add(this.TotalGrossProfit_Lbl);
            this.ListPanel2.Controls.Add(this.label36);
            this.ListPanel2.Location = new System.Drawing.Point(365, 285);
            this.ListPanel2.Name = "ListPanel2";
            this.ListPanel2.Size = new System.Drawing.Size(366, 108);
            this.ListPanel2.TabIndex = 24;
            this.ListPanel2.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            // 
            // TotalNetIncome_Lbl
            // 
            this.TotalNetIncome_Lbl.BackColor = System.Drawing.Color.Transparent;
            this.TotalNetIncome_Lbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalNetIncome_Lbl.ForeColor = System.Drawing.Color.Lime;
            this.TotalNetIncome_Lbl.Location = new System.Drawing.Point(103, 78);
            this.TotalNetIncome_Lbl.Name = "TotalNetIncome_Lbl";
            this.TotalNetIncome_Lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalNetIncome_Lbl.Size = new System.Drawing.Size(233, 16);
            this.TotalNetIncome_Lbl.TabIndex = 30;
            this.TotalNetIncome_Lbl.Text = "N/A";
            this.TotalNetIncome_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(23, 78);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 16);
            this.label22.TabIndex = 29;
            this.label22.Text = "Net Income:";
            // 
            // TotalOperatingIncome_Lbl
            // 
            this.TotalOperatingIncome_Lbl.BackColor = System.Drawing.Color.Transparent;
            this.TotalOperatingIncome_Lbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalOperatingIncome_Lbl.ForeColor = System.Drawing.Color.Lime;
            this.TotalOperatingIncome_Lbl.Location = new System.Drawing.Point(140, 46);
            this.TotalOperatingIncome_Lbl.Name = "TotalOperatingIncome_Lbl";
            this.TotalOperatingIncome_Lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalOperatingIncome_Lbl.Size = new System.Drawing.Size(196, 16);
            this.TotalOperatingIncome_Lbl.TabIndex = 28;
            this.TotalOperatingIncome_Lbl.Text = "N/A";
            this.TotalOperatingIncome_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(23, 46);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(111, 16);
            this.label20.TabIndex = 27;
            this.label20.Text = "Operating Income:";
            // 
            // TotalGrossProfit_Lbl
            // 
            this.TotalGrossProfit_Lbl.BackColor = System.Drawing.Color.Transparent;
            this.TotalGrossProfit_Lbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalGrossProfit_Lbl.ForeColor = System.Drawing.Color.Lime;
            this.TotalGrossProfit_Lbl.Location = new System.Drawing.Point(97, 14);
            this.TotalGrossProfit_Lbl.Name = "TotalGrossProfit_Lbl";
            this.TotalGrossProfit_Lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalGrossProfit_Lbl.Size = new System.Drawing.Size(239, 16);
            this.TotalGrossProfit_Lbl.TabIndex = 26;
            this.TotalGrossProfit_Lbl.Text = "N/A";
            this.TotalGrossProfit_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(23, 14);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(68, 16);
            this.label36.TabIndex = 22;
            this.label36.Text = "Gross Profit:";
            // 
            // ListPanel
            // 
            this.ListPanel.Angle = 45F;
            this.ListPanel.BottomColor = System.Drawing.Color.SteelBlue;
            this.ListPanel.Controls.Add(this.InTax_Lbl);
            this.ListPanel.Controls.Add(this.Ebt_Lbl);
            this.ListPanel.Controls.Add(this.IntExp_Lbl);
            this.ListPanel.Controls.Add(this.Ebit_Lbl);
            this.ListPanel.Controls.Add(this.AddInEx_Lbl);
            this.ListPanel.Controls.Add(this.Sga_Lbl);
            this.ListPanel.Controls.Add(this.RnD_Lbl);
            this.ListPanel.Controls.Add(this.Cgs_Lbl);
            this.ListPanel.Controls.Add(this.Revenue_Lbl);
            this.ListPanel.Controls.Add(this.label18);
            this.ListPanel.Controls.Add(this.label17);
            this.ListPanel.Controls.Add(this.label16);
            this.ListPanel.Controls.Add(this.label15);
            this.ListPanel.Controls.Add(this.label14);
            this.ListPanel.Controls.Add(this.label13);
            this.ListPanel.Controls.Add(this.label12);
            this.ListPanel.Controls.Add(this.label11);
            this.ListPanel.Controls.Add(this.label10);
            this.ListPanel.Location = new System.Drawing.Point(365, 36);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(366, 243);
            this.ListPanel.TabIndex = 23;
            this.ListPanel.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            // 
            // InTax_Lbl
            // 
            this.InTax_Lbl.BackColor = System.Drawing.Color.Transparent;
            this.InTax_Lbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InTax_Lbl.ForeColor = System.Drawing.Color.Lime;
            this.InTax_Lbl.Location = new System.Drawing.Point(110, 211);
            this.InTax_Lbl.Name = "InTax_Lbl";
            this.InTax_Lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.InTax_Lbl.Size = new System.Drawing.Size(226, 16);
            this.InTax_Lbl.TabIndex = 34;
            this.InTax_Lbl.Text = "N/A";
            this.InTax_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Ebt_Lbl
            // 
            this.Ebt_Lbl.BackColor = System.Drawing.Color.Transparent;
            this.Ebt_Lbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ebt_Lbl.ForeColor = System.Drawing.Color.Lime;
            this.Ebt_Lbl.Location = new System.Drawing.Point(149, 187);
            this.Ebt_Lbl.Name = "Ebt_Lbl";
            this.Ebt_Lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Ebt_Lbl.Size = new System.Drawing.Size(187, 16);
            this.Ebt_Lbl.TabIndex = 33;
            this.Ebt_Lbl.Text = "N/A";
            this.Ebt_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IntExp_Lbl
            // 
            this.IntExp_Lbl.BackColor = System.Drawing.Color.Transparent;
            this.IntExp_Lbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntExp_Lbl.ForeColor = System.Drawing.Color.Lime;
            this.IntExp_Lbl.Location = new System.Drawing.Point(134, 163);
            this.IntExp_Lbl.Name = "IntExp_Lbl";
            this.IntExp_Lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.IntExp_Lbl.Size = new System.Drawing.Size(202, 16);
            this.IntExp_Lbl.TabIndex = 32;
            this.IntExp_Lbl.Text = "N/A";
            this.IntExp_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Ebit_Lbl
            // 
            this.Ebit_Lbl.BackColor = System.Drawing.Color.Transparent;
            this.Ebit_Lbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ebit_Lbl.ForeColor = System.Drawing.Color.Lime;
            this.Ebit_Lbl.Location = new System.Drawing.Point(200, 139);
            this.Ebit_Lbl.Name = "Ebit_Lbl";
            this.Ebit_Lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Ebit_Lbl.Size = new System.Drawing.Size(136, 16);
            this.Ebit_Lbl.TabIndex = 31;
            this.Ebit_Lbl.Text = "N/A";
            this.Ebit_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddInEx_Lbl
            // 
            this.AddInEx_Lbl.BackColor = System.Drawing.Color.Transparent;
            this.AddInEx_Lbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddInEx_Lbl.ForeColor = System.Drawing.Color.Lime;
            this.AddInEx_Lbl.Location = new System.Drawing.Point(200, 115);
            this.AddInEx_Lbl.Name = "AddInEx_Lbl";
            this.AddInEx_Lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddInEx_Lbl.Size = new System.Drawing.Size(136, 16);
            this.AddInEx_Lbl.TabIndex = 30;
            this.AddInEx_Lbl.Text = "N/A";
            this.AddInEx_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sga_Lbl
            // 
            this.Sga_Lbl.BackColor = System.Drawing.Color.Transparent;
            this.Sga_Lbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sga_Lbl.ForeColor = System.Drawing.Color.Lime;
            this.Sga_Lbl.Location = new System.Drawing.Point(172, 91);
            this.Sga_Lbl.Name = "Sga_Lbl";
            this.Sga_Lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Sga_Lbl.Size = new System.Drawing.Size(164, 16);
            this.Sga_Lbl.TabIndex = 29;
            this.Sga_Lbl.Text = "N/A";
            this.Sga_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RnD_Lbl
            // 
            this.RnD_Lbl.BackColor = System.Drawing.Color.Transparent;
            this.RnD_Lbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RnD_Lbl.ForeColor = System.Drawing.Color.Lime;
            this.RnD_Lbl.Location = new System.Drawing.Point(186, 67);
            this.RnD_Lbl.Name = "RnD_Lbl";
            this.RnD_Lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RnD_Lbl.Size = new System.Drawing.Size(150, 16);
            this.RnD_Lbl.TabIndex = 28;
            this.RnD_Lbl.Text = "N/A";
            this.RnD_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cgs_Lbl
            // 
            this.Cgs_Lbl.BackColor = System.Drawing.Color.Transparent;
            this.Cgs_Lbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cgs_Lbl.ForeColor = System.Drawing.Color.Lime;
            this.Cgs_Lbl.Location = new System.Drawing.Point(149, 43);
            this.Cgs_Lbl.Name = "Cgs_Lbl";
            this.Cgs_Lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cgs_Lbl.Size = new System.Drawing.Size(187, 16);
            this.Cgs_Lbl.TabIndex = 27;
            this.Cgs_Lbl.Text = "N/A";
            this.Cgs_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Revenue_Lbl
            // 
            this.Revenue_Lbl.BackColor = System.Drawing.Color.Transparent;
            this.Revenue_Lbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Revenue_Lbl.ForeColor = System.Drawing.Color.Lime;
            this.Revenue_Lbl.Location = new System.Drawing.Point(97, 19);
            this.Revenue_Lbl.Name = "Revenue_Lbl";
            this.Revenue_Lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Revenue_Lbl.Size = new System.Drawing.Size(239, 16);
            this.Revenue_Lbl.TabIndex = 26;
            this.Revenue_Lbl.Text = "N/A";
            this.Revenue_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(23, 211);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 16);
            this.label18.TabIndex = 25;
            this.label18.Text = "Income Tax:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(23, 187);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 16);
            this.label17.TabIndex = 24;
            this.label17.Text = "Earnings Before Tax:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(23, 163);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 16);
            this.label16.TabIndex = 22;
            this.label16.Text = "Interest Expense:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(23, 139);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(166, 16);
            this.label15.TabIndex = 22;
            this.label15.Text = "Earnings Before Interest && Tax:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(23, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(164, 16);
            this.label14.TabIndex = 23;
            this.label14.Text = "Additional Income/Expenses:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(23, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "Sales, General && Admin:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(23, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Research && Development:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(23, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Cost of Goods Sold:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(23, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Revenue:";
            // 
            // ExportToExcel_Btn
            // 
            this.ExportToExcel_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(116)))));
            this.ExportToExcel_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportToExcel_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportToExcel_Btn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportToExcel_Btn.ForeColor = System.Drawing.Color.White;
            this.ExportToExcel_Btn.Location = new System.Drawing.Point(565, 429);
            this.ExportToExcel_Btn.Name = "ExportToExcel_Btn";
            this.ExportToExcel_Btn.Size = new System.Drawing.Size(166, 34);
            this.ExportToExcel_Btn.TabIndex = 42;
            this.ExportToExcel_Btn.Text = "Export To Excel";
            this.ExportToExcel_Btn.UseVisualStyleBackColor = false;
            this.ExportToExcel_Btn.Click += new System.EventHandler(this.ExportToExcel_Click);
            // 
            // IncomeStatementWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 475);
            this.Controls.Add(this.ExportToExcel_Btn);
            this.Controls.Add(this.ListPanel2);
            this.Controls.Add(this.ListPanel);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.TopBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IncomeStatementWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IncomeStatementWindow";
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ListPanel2.ResumeLayout(false);
            this.ListPanel2.PerformLayout();
            this.ListPanel.ResumeLayout(false);
            this.ListPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Revenue_txtBox;
        private System.Windows.Forms.TextBox Cgs_txtBox;
        private System.Windows.Forms.TextBox RnD_txtBox;
        private System.Windows.Forms.TextBox Sga_txtBox;
        private System.Windows.Forms.TextBox AddInEx_txtBox;
        private System.Windows.Forms.TextBox Ebit_txtBox;
        private System.Windows.Forms.TextBox IntEx_txtBox;
        private System.Windows.Forms.TextBox Ebt_txtBox;
        private System.Windows.Forms.TextBox InTax_txtBox;
        private System.Windows.Forms.GroupBox GroupBox;
        private CustomUI.GradientPanel ListPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label InTax_Lbl;
        private System.Windows.Forms.Label Ebt_Lbl;
        private System.Windows.Forms.Label IntExp_Lbl;
        private System.Windows.Forms.Label Ebit_Lbl;
        private System.Windows.Forms.Label AddInEx_Lbl;
        private System.Windows.Forms.Label Sga_Lbl;
        private System.Windows.Forms.Label RnD_Lbl;
        private System.Windows.Forms.Label Cgs_Lbl;
        private System.Windows.Forms.Label Revenue_Lbl;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button CalcIncState_Btn;
        private CustomUI.GradientPanel ListPanel2;
        private System.Windows.Forms.Label TotalNetIncome_Lbl;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label TotalOperatingIncome_Lbl;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label TotalGrossProfit_Lbl;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button ExportToExcel_Btn;
    }
}