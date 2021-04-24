
namespace Financial_System.UserControls
{
    partial class StudentLedgerControl
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
            this.FilterButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.StudentFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.FilterPanel = new Financial_System.CustomUI.GradientPanel();
            this.ShowAllRadioButton = new System.Windows.Forms.RadioButton();
            this.SectionRadioButton = new System.Windows.Forms.RadioButton();
            this.LevelRadioButton = new System.Windows.Forms.RadioButton();
            this.LRNRadioButton = new System.Windows.Forms.RadioButton();
            this.NameRadioButton = new System.Windows.Forms.RadioButton();
            this.FilterTextBox = new Financial_System.CustomUI.Textbox.RoundTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FilterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilterButton
            // 
            this.FilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(228)))), ((int)(((byte)(237)))));
            this.FilterButton.FlatAppearance.BorderSize = 0;
            this.FilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterButton.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterButton.Location = new System.Drawing.Point(491, 16);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(134, 29);
            this.FilterButton.TabIndex = 8;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = false;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(18, 16);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(159, 22);
            this.TitleLabel.TabIndex = 6;
            this.TitleLabel.Text = "Student Ledgers";
            // 
            // StudentFlowPanel
            // 
            this.StudentFlowPanel.AutoScroll = true;
            this.StudentFlowPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.StudentFlowPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StudentFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.StudentFlowPanel.Location = new System.Drawing.Point(0, 99);
            this.StudentFlowPanel.Name = "StudentFlowPanel";
            this.StudentFlowPanel.Size = new System.Drawing.Size(848, 379);
            this.StudentFlowPanel.TabIndex = 9;
            this.StudentFlowPanel.WrapContents = false;
            // 
            // FilterPanel
            // 
            this.FilterPanel.Angle = 86F;
            this.FilterPanel.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(42)))));
            this.FilterPanel.Controls.Add(this.ShowAllRadioButton);
            this.FilterPanel.Controls.Add(this.SectionRadioButton);
            this.FilterPanel.Controls.Add(this.LevelRadioButton);
            this.FilterPanel.Controls.Add(this.LRNRadioButton);
            this.FilterPanel.Controls.Add(this.NameRadioButton);
            this.FilterPanel.Location = new System.Drawing.Point(491, 51);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(329, 42);
            this.FilterPanel.TabIndex = 14;
            this.FilterPanel.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(94)))), ((int)(((byte)(164)))));
            // 
            // ShowAllRadioButton
            // 
            this.ShowAllRadioButton.AutoSize = true;
            this.ShowAllRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.ShowAllRadioButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllRadioButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ShowAllRadioButton.Location = new System.Drawing.Point(9, 11);
            this.ShowAllRadioButton.Name = "ShowAllRadioButton";
            this.ShowAllRadioButton.Size = new System.Drawing.Size(70, 20);
            this.ShowAllRadioButton.TabIndex = 14;
            this.ShowAllRadioButton.TabStop = true;
            this.ShowAllRadioButton.Text = "Show All";
            this.ShowAllRadioButton.UseVisualStyleBackColor = false;
            // 
            // SectionRadioButton
            // 
            this.SectionRadioButton.AutoSize = true;
            this.SectionRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.SectionRadioButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionRadioButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SectionRadioButton.Location = new System.Drawing.Point(199, 11);
            this.SectionRadioButton.Name = "SectionRadioButton";
            this.SectionRadioButton.Size = new System.Drawing.Size(66, 20);
            this.SectionRadioButton.TabIndex = 12;
            this.SectionRadioButton.TabStop = true;
            this.SectionRadioButton.Text = "Section";
            this.SectionRadioButton.UseVisualStyleBackColor = false;
            // 
            // LevelRadioButton
            // 
            this.LevelRadioButton.AutoSize = true;
            this.LevelRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.LevelRadioButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelRadioButton.ForeColor = System.Drawing.SystemColors.Control;
            this.LevelRadioButton.Location = new System.Drawing.Point(265, 11);
            this.LevelRadioButton.Name = "LevelRadioButton";
            this.LevelRadioButton.Size = new System.Drawing.Size(55, 20);
            this.LevelRadioButton.TabIndex = 13;
            this.LevelRadioButton.TabStop = true;
            this.LevelRadioButton.Text = "Level";
            this.LevelRadioButton.UseVisualStyleBackColor = false;
            // 
            // LRNRadioButton
            // 
            this.LRNRadioButton.AutoSize = true;
            this.LRNRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.LRNRadioButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRNRadioButton.ForeColor = System.Drawing.SystemColors.Control;
            this.LRNRadioButton.Location = new System.Drawing.Point(79, 11);
            this.LRNRadioButton.Name = "LRNRadioButton";
            this.LRNRadioButton.Size = new System.Drawing.Size(46, 20);
            this.LRNRadioButton.TabIndex = 10;
            this.LRNRadioButton.TabStop = true;
            this.LRNRadioButton.Text = "LRN";
            this.LRNRadioButton.UseVisualStyleBackColor = false;
            // 
            // NameRadioButton
            // 
            this.NameRadioButton.AutoSize = true;
            this.NameRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.NameRadioButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameRadioButton.ForeColor = System.Drawing.SystemColors.Control;
            this.NameRadioButton.Location = new System.Drawing.Point(125, 11);
            this.NameRadioButton.Name = "NameRadioButton";
            this.NameRadioButton.Size = new System.Drawing.Size(74, 20);
            this.NameRadioButton.TabIndex = 11;
            this.NameRadioButton.TabStop = true;
            this.NameRadioButton.Text = "Surname";
            this.NameRadioButton.UseVisualStyleBackColor = false;
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.BackColor = System.Drawing.Color.Transparent;
            this.FilterTextBox.BorderColor = System.Drawing.Color.Transparent;
            this.FilterTextBox.BorderSize = 0;
            this.FilterTextBox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.FilterTextBox.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterTextBox.ForeColor = System.Drawing.Color.Black;
            this.FilterTextBox.Location = new System.Drawing.Point(631, 16);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.PasswordChar = '\0';
            this.FilterTextBox.Size = new System.Drawing.Size(189, 29);
            this.FilterTextBox.TabIndex = 7;
            this.FilterTextBox.textboxRadius = 15;
            this.FilterTextBox.UseSystemPasswordChar = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "New Temporary Transaction";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "For Student not in the System Yet";
            // 
            // StudentLedgerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FilterPanel);
            this.Controls.Add(this.StudentFlowPanel);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.FilterTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "StudentLedgerControl";
            this.Size = new System.Drawing.Size(848, 478);
            this.FilterPanel.ResumeLayout(false);
            this.FilterPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FilterButton;
        private CustomUI.Textbox.RoundTextBox FilterTextBox;
        private System.Windows.Forms.Label TitleLabel;
        public System.Windows.Forms.FlowLayoutPanel StudentFlowPanel;
        private System.Windows.Forms.RadioButton LRNRadioButton;
        private System.Windows.Forms.RadioButton NameRadioButton;
        private System.Windows.Forms.RadioButton SectionRadioButton;
        private System.Windows.Forms.RadioButton LevelRadioButton;
        private CustomUI.GradientPanel FilterPanel;
        private System.Windows.Forms.RadioButton ShowAllRadioButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}
