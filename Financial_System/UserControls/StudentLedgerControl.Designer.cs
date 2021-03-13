
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
            this.roundTextBox1 = new Financial_System.CustomUI.Textbox.RoundTextBox();
            this.SuspendLayout();
            // 
            // FilterButton
            // 
            this.FilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(228)))), ((int)(((byte)(237)))));
            this.FilterButton.FlatAppearance.BorderSize = 0;
            this.FilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterButton.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterButton.Location = new System.Drawing.Point(509, 16);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(75, 29);
            this.FilterButton.TabIndex = 8;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.TitleLabel.Location = new System.Drawing.Point(18, 16);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(108, 17);
            this.TitleLabel.TabIndex = 6;
            this.TitleLabel.Text = "Student Ledgers";
            // 
            // StudentFlowPanel
            // 
            this.StudentFlowPanel.AutoScroll = true;
            this.StudentFlowPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StudentFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.StudentFlowPanel.Location = new System.Drawing.Point(0, 61);
            this.StudentFlowPanel.Name = "StudentFlowPanel";
            this.StudentFlowPanel.Size = new System.Drawing.Size(800, 379);
            this.StudentFlowPanel.TabIndex = 9;
            this.StudentFlowPanel.WrapContents = false;
            // 
            // roundTextBox1
            // 
            this.roundTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.roundTextBox1.BorderColor = System.Drawing.Color.Transparent;
            this.roundTextBox1.BorderSize = 0;
            this.roundTextBox1.Br = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.roundTextBox1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundTextBox1.ForeColor = System.Drawing.Color.Black;
            this.roundTextBox1.Location = new System.Drawing.Point(590, 16);
            this.roundTextBox1.Name = "roundTextBox1";
            this.roundTextBox1.PasswordChar = '\0';
            this.roundTextBox1.Size = new System.Drawing.Size(189, 29);
            this.roundTextBox1.TabIndex = 7;
            this.roundTextBox1.textboxRadius = 15;
            this.roundTextBox1.UseSystemPasswordChar = false;
            // 
            // StudentLedgerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StudentFlowPanel);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.roundTextBox1);
            this.Controls.Add(this.TitleLabel);
            this.Name = "StudentLedgerControl";
            this.Size = new System.Drawing.Size(800, 440);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FilterButton;
        private CustomUI.Textbox.RoundTextBox roundTextBox1;
        private System.Windows.Forms.Label TitleLabel;
        public System.Windows.Forms.FlowLayoutPanel StudentFlowPanel;
    }
}
