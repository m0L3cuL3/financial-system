
namespace Financial_System.Forms
{
    partial class CashFlowWindow
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.MonthYearLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.ExportToExcel_Btn = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.CalcFCF_Btn = new System.Windows.Forms.Button();
            this.FCF_Lbl = new System.Windows.Forms.Label();
            this.FCF_DGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CalcICF_Btn = new System.Windows.Forms.Button();
            this.CFI_Lbl = new System.Windows.Forms.Label();
            this.CFI_DGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CalcOCF_Btn = new System.Windows.Forms.Button();
            this.SC_Lbl = new System.Windows.Forms.Label();
            this.SubC_DGV = new System.Windows.Forms.DataGridView();
            this.SubDescColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AC_Lbl = new System.Windows.Forms.Label();
            this.AddC_DGV = new System.Windows.Forms.DataGridView();
            this.AddDescColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetCashOperation_Lbl = new System.Windows.Forms.Label();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.NetEarn_Lbl = new System.Windows.Forms.Label();
            this.NetEarnings_txtBox = new System.Windows.Forms.TextBox();
            this.LockCheckBox = new System.Windows.Forms.CheckBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TotalCashFlow_Lbl = new System.Windows.Forms.Label();
            this.TotalFCF_Lbl = new System.Windows.Forms.Label();
            this.TotalICF_Lbl = new System.Windows.Forms.Label();
            this.TotalOCF_Lbl = new System.Windows.Forms.Label();
            this.NetCashFinancing_Lbl = new System.Windows.Forms.Label();
            this.NetCashInvesting_Lbl = new System.Windows.Forms.Label();
            this.CashFlow_Lbl = new System.Windows.Forms.Label();
            this.TopBarPanel.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FCF_DGV)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CFI_DGV)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubC_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddC_DGV)).BeginInit();
            this.TabControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.TopBarPanel.Controls.Add(this.MonthYearLabel);
            this.TopBarPanel.Controls.Add(this.CloseButton);
            this.TopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBarPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(743, 30);
            this.TopBarPanel.TabIndex = 2;
            this.TopBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBarPanel_MouseMove);
            // 
            // MonthYearLabel
            // 
            this.MonthYearLabel.AutoSize = true;
            this.MonthYearLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthYearLabel.ForeColor = System.Drawing.Color.White;
            this.MonthYearLabel.Location = new System.Drawing.Point(315, 7);
            this.MonthYearLabel.Name = "MonthYearLabel";
            this.MonthYearLabel.Size = new System.Drawing.Size(113, 16);
            this.MonthYearLabel.TabIndex = 46;
            this.MonthYearLabel.Text = "MonthYearLabel";
            this.MonthYearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // ExportToExcel_Btn
            // 
            this.ExportToExcel_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(116)))));
            this.ExportToExcel_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportToExcel_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportToExcel_Btn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportToExcel_Btn.ForeColor = System.Drawing.Color.White;
            this.ExportToExcel_Btn.Location = new System.Drawing.Point(601, 428);
            this.ExportToExcel_Btn.Name = "ExportToExcel_Btn";
            this.ExportToExcel_Btn.Size = new System.Drawing.Size(130, 35);
            this.ExportToExcel_Btn.TabIndex = 39;
            this.ExportToExcel_Btn.Text = "Export To Excel";
            this.ExportToExcel_Btn.UseVisualStyleBackColor = false;
            this.ExportToExcel_Btn.Click += new System.EventHandler(this.ExportToExcel_Btn_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.CalcFCF_Btn);
            this.tabPage4.Controls.Add(this.FCF_Lbl);
            this.tabPage4.Controls.Add(this.FCF_DGV);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(735, 291);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Financing Cash Flow";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // CalcFCF_Btn
            // 
            this.CalcFCF_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(116)))));
            this.CalcFCF_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalcFCF_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalcFCF_Btn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcFCF_Btn.ForeColor = System.Drawing.Color.White;
            this.CalcFCF_Btn.Location = new System.Drawing.Point(260, 224);
            this.CalcFCF_Btn.Name = "CalcFCF_Btn";
            this.CalcFCF_Btn.Size = new System.Drawing.Size(215, 27);
            this.CalcFCF_Btn.TabIndex = 55;
            this.CalcFCF_Btn.Text = "Calculate Financing Cash Flow";
            this.ToolTip.SetToolTip(this.CalcFCF_Btn, "Calculate Operating Cash Flow.");
            this.CalcFCF_Btn.UseVisualStyleBackColor = false;
            this.CalcFCF_Btn.Click += new System.EventHandler(this.CalcFCF_Btn_Click);
            // 
            // FCF_Lbl
            // 
            this.FCF_Lbl.AutoSize = true;
            this.FCF_Lbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FCF_Lbl.ForeColor = System.Drawing.Color.DimGray;
            this.FCF_Lbl.Location = new System.Drawing.Point(213, 39);
            this.FCF_Lbl.Name = "FCF_Lbl";
            this.FCF_Lbl.Size = new System.Drawing.Size(175, 17);
            this.FCF_Lbl.TabIndex = 54;
            this.FCF_Lbl.Text = "Cash Flow from Financing";
            // 
            // FCF_DGV
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.FCF_DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.FCF_DGV.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.FCF_DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FCF_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.FCF_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FCF_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.FCF_DGV.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FCF_DGV.DefaultCellStyle = dataGridViewCellStyle15;
            this.FCF_DGV.Location = new System.Drawing.Point(216, 59);
            this.FCF_DGV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FCF_DGV.Name = "FCF_DGV";
            this.FCF_DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.FCF_DGV.RowHeadersVisible = false;
            this.FCF_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.FCF_DGV.Size = new System.Drawing.Size(306, 154);
            this.FCF_DGV.TabIndex = 53;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CalcICF_Btn);
            this.tabPage2.Controls.Add(this.CFI_Lbl);
            this.tabPage2.Controls.Add(this.CFI_DGV);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(735, 291);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Investing Cash Flow";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CalcICF_Btn
            // 
            this.CalcICF_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(116)))));
            this.CalcICF_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalcICF_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalcICF_Btn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcICF_Btn.ForeColor = System.Drawing.Color.White;
            this.CalcICF_Btn.Location = new System.Drawing.Point(260, 224);
            this.CalcICF_Btn.Name = "CalcICF_Btn";
            this.CalcICF_Btn.Size = new System.Drawing.Size(215, 27);
            this.CalcICF_Btn.TabIndex = 52;
            this.CalcICF_Btn.Text = "Calculate Investing Cash Flow";
            this.ToolTip.SetToolTip(this.CalcICF_Btn, "Calculate Operating Cash Flow.");
            this.CalcICF_Btn.UseVisualStyleBackColor = false;
            this.CalcICF_Btn.Click += new System.EventHandler(this.CalcICF_Btn_Click);
            // 
            // CFI_Lbl
            // 
            this.CFI_Lbl.AutoSize = true;
            this.CFI_Lbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CFI_Lbl.ForeColor = System.Drawing.Color.DimGray;
            this.CFI_Lbl.Location = new System.Drawing.Point(213, 39);
            this.CFI_Lbl.Name = "CFI_Lbl";
            this.CFI_Lbl.Size = new System.Drawing.Size(170, 17);
            this.CFI_Lbl.TabIndex = 51;
            this.CFI_Lbl.Text = "Cash Flow from Investing";
            // 
            // CFI_DGV
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.CFI_DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.CFI_DGV.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.CFI_DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CFI_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.CFI_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CFI_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.CFI_DGV.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CFI_DGV.DefaultCellStyle = dataGridViewCellStyle18;
            this.CFI_DGV.Location = new System.Drawing.Point(216, 59);
            this.CFI_DGV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CFI_DGV.Name = "CFI_DGV";
            this.CFI_DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CFI_DGV.RowHeadersVisible = false;
            this.CFI_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.CFI_DGV.Size = new System.Drawing.Size(306, 154);
            this.CFI_DGV.TabIndex = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Description";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CalcOCF_Btn);
            this.tabPage1.Controls.Add(this.SC_Lbl);
            this.tabPage1.Controls.Add(this.SubC_DGV);
            this.tabPage1.Controls.Add(this.AC_Lbl);
            this.tabPage1.Controls.Add(this.AddC_DGV);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(735, 291);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Operating Cash Flow";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CalcOCF_Btn
            // 
            this.CalcOCF_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(116)))));
            this.CalcOCF_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalcOCF_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalcOCF_Btn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcOCF_Btn.ForeColor = System.Drawing.Color.White;
            this.CalcOCF_Btn.Location = new System.Drawing.Point(262, 224);
            this.CalcOCF_Btn.Name = "CalcOCF_Btn";
            this.CalcOCF_Btn.Size = new System.Drawing.Size(215, 27);
            this.CalcOCF_Btn.TabIndex = 40;
            this.CalcOCF_Btn.Text = "Calculate Operating Cash Flow";
            this.ToolTip.SetToolTip(this.CalcOCF_Btn, "Calculate Operating Cash Flow.");
            this.CalcOCF_Btn.UseVisualStyleBackColor = false;
            this.CalcOCF_Btn.Click += new System.EventHandler(this.CalcOCF_Btn_Click);
            // 
            // SC_Lbl
            // 
            this.SC_Lbl.AutoSize = true;
            this.SC_Lbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SC_Lbl.ForeColor = System.Drawing.Color.DimGray;
            this.SC_Lbl.Location = new System.Drawing.Point(394, 39);
            this.SC_Lbl.Name = "SC_Lbl";
            this.SC_Lbl.Size = new System.Drawing.Size(142, 17);
            this.SC_Lbl.TabIndex = 51;
            this.SC_Lbl.Text = "Subtractions to Cash";
            // 
            // SubC_DGV
            // 
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.SubC_DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.SubC_DGV.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.SubC_DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SubC_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.SubC_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubC_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubDescColumn,
            this.SubAmountColumn});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SubC_DGV.DefaultCellStyle = dataGridViewCellStyle21;
            this.SubC_DGV.Location = new System.Drawing.Point(397, 59);
            this.SubC_DGV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SubC_DGV.Name = "SubC_DGV";
            this.SubC_DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SubC_DGV.RowHeadersVisible = false;
            this.SubC_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.SubC_DGV.Size = new System.Drawing.Size(306, 154);
            this.SubC_DGV.TabIndex = 50;
            // 
            // SubDescColumn
            // 
            this.SubDescColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubDescColumn.HeaderText = "Description";
            this.SubDescColumn.Name = "SubDescColumn";
            this.SubDescColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SubAmountColumn
            // 
            this.SubAmountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubAmountColumn.HeaderText = "Amount";
            this.SubAmountColumn.Name = "SubAmountColumn";
            this.SubAmountColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // AC_Lbl
            // 
            this.AC_Lbl.AutoSize = true;
            this.AC_Lbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AC_Lbl.ForeColor = System.Drawing.Color.DimGray;
            this.AC_Lbl.Location = new System.Drawing.Point(31, 39);
            this.AC_Lbl.Name = "AC_Lbl";
            this.AC_Lbl.Size = new System.Drawing.Size(123, 17);
            this.AC_Lbl.TabIndex = 49;
            this.AC_Lbl.Text = "Additions to Cash";
            // 
            // AddC_DGV
            // 
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.AddC_DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.AddC_DGV.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.AddC_DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AddC_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.AddC_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddC_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AddDescColumn,
            this.AddAmountColumn});
            this.AddC_DGV.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AddC_DGV.DefaultCellStyle = dataGridViewCellStyle24;
            this.AddC_DGV.Location = new System.Drawing.Point(34, 59);
            this.AddC_DGV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddC_DGV.Name = "AddC_DGV";
            this.AddC_DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AddC_DGV.RowHeadersVisible = false;
            this.AddC_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.AddC_DGV.Size = new System.Drawing.Size(306, 154);
            this.AddC_DGV.TabIndex = 48;
            // 
            // AddDescColumn
            // 
            this.AddDescColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AddDescColumn.HeaderText = "Description";
            this.AddDescColumn.Name = "AddDescColumn";
            this.AddDescColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // AddAmountColumn
            // 
            this.AddAmountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AddAmountColumn.HeaderText = "Amount";
            this.AddAmountColumn.Name = "AddAmountColumn";
            this.AddAmountColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NetCashOperation_Lbl
            // 
            this.NetCashOperation_Lbl.AutoSize = true;
            this.NetCashOperation_Lbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetCashOperation_Lbl.ForeColor = System.Drawing.Color.Black;
            this.NetCashOperation_Lbl.Location = new System.Drawing.Point(21, 26);
            this.NetCashOperation_Lbl.Name = "NetCashOperation_Lbl";
            this.NetCashOperation_Lbl.Size = new System.Drawing.Size(153, 16);
            this.NetCashOperation_Lbl.TabIndex = 56;
            this.NetCashOperation_Lbl.Text = "Net Cash from Operations: ";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.tabPage4);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabControl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.Location = new System.Drawing.Point(0, 30);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(743, 320);
            this.TabControl.TabIndex = 1;
            // 
            // NetEarn_Lbl
            // 
            this.NetEarn_Lbl.AutoSize = true;
            this.NetEarn_Lbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetEarn_Lbl.Location = new System.Drawing.Point(17, 26);
            this.NetEarn_Lbl.Name = "NetEarn_Lbl";
            this.NetEarn_Lbl.Size = new System.Drawing.Size(109, 16);
            this.NetEarn_Lbl.TabIndex = 41;
            this.NetEarn_Lbl.Text = "Input Net Earnings:";
            // 
            // NetEarnings_txtBox
            // 
            this.NetEarnings_txtBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetEarnings_txtBox.Location = new System.Drawing.Point(20, 45);
            this.NetEarnings_txtBox.Name = "NetEarnings_txtBox";
            this.NetEarnings_txtBox.Size = new System.Drawing.Size(129, 21);
            this.NetEarnings_txtBox.TabIndex = 40;
            this.ToolTip.SetToolTip(this.NetEarnings_txtBox, "Enter Net Earnings");
            // 
            // LockCheckBox
            // 
            this.LockCheckBox.AutoSize = true;
            this.LockCheckBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LockCheckBox.Location = new System.Drawing.Point(20, 71);
            this.LockCheckBox.Name = "LockCheckBox";
            this.LockCheckBox.Size = new System.Drawing.Size(120, 20);
            this.LockCheckBox.TabIndex = 42;
            this.LockCheckBox.Text = "Lock Net Earnings";
            this.ToolTip.SetToolTip(this.LockCheckBox, "Check to prevent changes to net earnings. (optional)");
            this.LockCheckBox.UseVisualStyleBackColor = true;
            this.LockCheckBox.CheckedChanged += new System.EventHandler(this.LockComboBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NetEarn_Lbl);
            this.groupBox1.Controls.Add(this.LockCheckBox);
            this.groupBox1.Controls.Add(this.NetEarnings_txtBox);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 107);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Net Earnings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TotalCashFlow_Lbl);
            this.groupBox2.Controls.Add(this.TotalFCF_Lbl);
            this.groupBox2.Controls.Add(this.TotalICF_Lbl);
            this.groupBox2.Controls.Add(this.TotalOCF_Lbl);
            this.groupBox2.Controls.Add(this.NetCashFinancing_Lbl);
            this.groupBox2.Controls.Add(this.NetCashInvesting_Lbl);
            this.groupBox2.Controls.Add(this.CashFlow_Lbl);
            this.groupBox2.Controls.Add(this.NetCashOperation_Lbl);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(182, 356);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 107);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // TotalCashFlow_Lbl
            // 
            this.TotalCashFlow_Lbl.AutoSize = true;
            this.TotalCashFlow_Lbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCashFlow_Lbl.ForeColor = System.Drawing.Color.Black;
            this.TotalCashFlow_Lbl.Location = new System.Drawing.Point(236, 80);
            this.TotalCashFlow_Lbl.Name = "TotalCashFlow_Lbl";
            this.TotalCashFlow_Lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalCashFlow_Lbl.Size = new System.Drawing.Size(28, 16);
            this.TotalCashFlow_Lbl.TabIndex = 62;
            this.TotalCashFlow_Lbl.Text = "N/A";
            // 
            // TotalFCF_Lbl
            // 
            this.TotalFCF_Lbl.AutoSize = true;
            this.TotalFCF_Lbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalFCF_Lbl.ForeColor = System.Drawing.Color.Black;
            this.TotalFCF_Lbl.Location = new System.Drawing.Point(236, 62);
            this.TotalFCF_Lbl.Name = "TotalFCF_Lbl";
            this.TotalFCF_Lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalFCF_Lbl.Size = new System.Drawing.Size(28, 16);
            this.TotalFCF_Lbl.TabIndex = 61;
            this.TotalFCF_Lbl.Text = "N/A";
            // 
            // TotalICF_Lbl
            // 
            this.TotalICF_Lbl.AutoSize = true;
            this.TotalICF_Lbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalICF_Lbl.ForeColor = System.Drawing.Color.Black;
            this.TotalICF_Lbl.Location = new System.Drawing.Point(236, 44);
            this.TotalICF_Lbl.Name = "TotalICF_Lbl";
            this.TotalICF_Lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalICF_Lbl.Size = new System.Drawing.Size(28, 16);
            this.TotalICF_Lbl.TabIndex = 60;
            this.TotalICF_Lbl.Text = "N/A";
            // 
            // TotalOCF_Lbl
            // 
            this.TotalOCF_Lbl.AutoSize = true;
            this.TotalOCF_Lbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalOCF_Lbl.ForeColor = System.Drawing.Color.Black;
            this.TotalOCF_Lbl.Location = new System.Drawing.Point(236, 26);
            this.TotalOCF_Lbl.Name = "TotalOCF_Lbl";
            this.TotalOCF_Lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalOCF_Lbl.Size = new System.Drawing.Size(28, 16);
            this.TotalOCF_Lbl.TabIndex = 59;
            this.TotalOCF_Lbl.Text = "N/A";
            // 
            // NetCashFinancing_Lbl
            // 
            this.NetCashFinancing_Lbl.AutoSize = true;
            this.NetCashFinancing_Lbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetCashFinancing_Lbl.ForeColor = System.Drawing.Color.Black;
            this.NetCashFinancing_Lbl.Location = new System.Drawing.Point(21, 62);
            this.NetCashFinancing_Lbl.Name = "NetCashFinancing_Lbl";
            this.NetCashFinancing_Lbl.Size = new System.Drawing.Size(145, 16);
            this.NetCashFinancing_Lbl.TabIndex = 58;
            this.NetCashFinancing_Lbl.Text = "Net Cash from Financing: ";
            // 
            // NetCashInvesting_Lbl
            // 
            this.NetCashInvesting_Lbl.AutoSize = true;
            this.NetCashInvesting_Lbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetCashInvesting_Lbl.ForeColor = System.Drawing.Color.Black;
            this.NetCashInvesting_Lbl.Location = new System.Drawing.Point(21, 44);
            this.NetCashInvesting_Lbl.Name = "NetCashInvesting_Lbl";
            this.NetCashInvesting_Lbl.Size = new System.Drawing.Size(142, 16);
            this.NetCashInvesting_Lbl.TabIndex = 57;
            this.NetCashInvesting_Lbl.Text = "Net Cash from Investing: ";
            // 
            // CashFlow_Lbl
            // 
            this.CashFlow_Lbl.AutoSize = true;
            this.CashFlow_Lbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashFlow_Lbl.Location = new System.Drawing.Point(21, 80);
            this.CashFlow_Lbl.Name = "CashFlow_Lbl";
            this.CashFlow_Lbl.Size = new System.Drawing.Size(95, 16);
            this.CashFlow_Lbl.TabIndex = 41;
            this.CashFlow_Lbl.Text = "Total Cash Flow:";
            // 
            // CashFlowWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 475);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.TopBarPanel);
            this.Controls.Add(this.ExportToExcel_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashFlowWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashFlowWindow";
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FCF_DGV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CFI_DGV)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubC_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddC_DGV)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Button ExportToExcel_Btn;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button CalcOCF_Btn;
        private System.Windows.Forms.Label NetCashOperation_Lbl;
        private System.Windows.Forms.Label SC_Lbl;
        private System.Windows.Forms.DataGridView SubC_DGV;
        private System.Windows.Forms.Label AC_Lbl;
        private System.Windows.Forms.DataGridView AddC_DGV;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubDescColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubAmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddDescColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddAmountColumn;
        private System.Windows.Forms.Label NetEarn_Lbl;
        private System.Windows.Forms.TextBox NetEarnings_txtBox;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.CheckBox LockCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label NetCashFinancing_Lbl;
        private System.Windows.Forms.Label NetCashInvesting_Lbl;
        private System.Windows.Forms.Label CashFlow_Lbl;
        private System.Windows.Forms.Button CalcICF_Btn;
        private System.Windows.Forms.Label CFI_Lbl;
        private System.Windows.Forms.DataGridView CFI_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button CalcFCF_Btn;
        private System.Windows.Forms.Label FCF_Lbl;
        private System.Windows.Forms.DataGridView FCF_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label TotalCashFlow_Lbl;
        private System.Windows.Forms.Label TotalFCF_Lbl;
        private System.Windows.Forms.Label TotalICF_Lbl;
        private System.Windows.Forms.Label TotalOCF_Lbl;
        private System.Windows.Forms.Label MonthYearLabel;
    }
}