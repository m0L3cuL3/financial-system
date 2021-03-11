
namespace Financial_System.UserControls
{
    partial class DashboardControl
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CollectablesPieChart = new LiveCharts.WinForms.PieChart();
            this.CollectablesPanel = new System.Windows.Forms.Panel();
            this.CollectablesLabel = new System.Windows.Forms.Label();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.NetworkInfoPanel = new System.Windows.Forms.Panel();
            this.NetworkInfoLabel = new System.Windows.Forms.Label();
            this.NetConLabel = new System.Windows.Forms.Label();
            this.NetConStatusLabel = new System.Windows.Forms.Label();
            this.DBInfoLabel = new System.Windows.Forms.Label();
            this.DBInfoPanel = new System.Windows.Forms.Panel();
            this.DBFileNameLabel = new System.Windows.Forms.Label();
            this.DBFileNameTitleLabel = new System.Windows.Forms.Label();
            this.DBFileSizeTitleLabel = new System.Windows.Forms.Label();
            this.DBFileSizeLabel = new System.Windows.Forms.Label();
            this.CollectablesPanel.SuspendLayout();
            this.NetworkInfoPanel.SuspendLayout();
            this.DBInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(18, 16);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(104, 25);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Dashboard";
            // 
            // CollectablesPieChart
            // 
            this.CollectablesPieChart.BackColor = System.Drawing.SystemColors.Control;
            this.CollectablesPieChart.BackColorTransparent = true;
            this.CollectablesPieChart.ForeColor = System.Drawing.Color.Black;
            this.CollectablesPieChart.Location = new System.Drawing.Point(7, 9);
            this.CollectablesPieChart.Name = "CollectablesPieChart";
            this.CollectablesPieChart.Size = new System.Drawing.Size(280, 134);
            this.CollectablesPieChart.TabIndex = 0;
            // 
            // CollectablesPanel
            // 
            this.CollectablesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.CollectablesPanel.Controls.Add(this.CollectablesPieChart);
            this.CollectablesPanel.Location = new System.Drawing.Point(463, 99);
            this.CollectablesPanel.Name = "CollectablesPanel";
            this.CollectablesPanel.Size = new System.Drawing.Size(294, 159);
            this.CollectablesPanel.TabIndex = 2;
            // 
            // CollectablesLabel
            // 
            this.CollectablesLabel.AutoSize = true;
            this.CollectablesLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollectablesLabel.Location = new System.Drawing.Point(459, 70);
            this.CollectablesLabel.Name = "CollectablesLabel";
            this.CollectablesLabel.Size = new System.Drawing.Size(170, 20);
            this.CollectablesLabel.TabIndex = 3;
            this.CollectablesLabel.Text = "Collectables (by term)";
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Location = new System.Drawing.Point(629, 72);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(128, 21);
            this.FilterComboBox.TabIndex = 4;
            this.FilterComboBox.SelectionChangeCommitted += new System.EventHandler(this.FilterComboBox_SelectionChangeCommitted);
            // 
            // NetworkInfoPanel
            // 
            this.NetworkInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.NetworkInfoPanel.Controls.Add(this.NetConStatusLabel);
            this.NetworkInfoPanel.Controls.Add(this.NetConLabel);
            this.NetworkInfoPanel.Location = new System.Drawing.Point(23, 203);
            this.NetworkInfoPanel.Name = "NetworkInfoPanel";
            this.NetworkInfoPanel.Size = new System.Drawing.Size(294, 55);
            this.NetworkInfoPanel.TabIndex = 3;
            // 
            // NetworkInfoLabel
            // 
            this.NetworkInfoLabel.AutoSize = true;
            this.NetworkInfoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetworkInfoLabel.Location = new System.Drawing.Point(19, 180);
            this.NetworkInfoLabel.Name = "NetworkInfoLabel";
            this.NetworkInfoLabel.Size = new System.Drawing.Size(160, 20);
            this.NetworkInfoLabel.TabIndex = 5;
            this.NetworkInfoLabel.Text = "Network Information";
            // 
            // NetConLabel
            // 
            this.NetConLabel.AutoSize = true;
            this.NetConLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetConLabel.Location = new System.Drawing.Point(15, 19);
            this.NetConLabel.Name = "NetConLabel";
            this.NetConLabel.Size = new System.Drawing.Size(148, 17);
            this.NetConLabel.TabIndex = 6;
            this.NetConLabel.Text = "Network Connection:";
            // 
            // NetConStatusLabel
            // 
            this.NetConStatusLabel.AutoSize = true;
            this.NetConStatusLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetConStatusLabel.Location = new System.Drawing.Point(220, 19);
            this.NetConStatusLabel.Name = "NetConStatusLabel";
            this.NetConStatusLabel.Size = new System.Drawing.Size(67, 17);
            this.NetConStatusLabel.TabIndex = 7;
            this.NetConStatusLabel.Text = "netStatus";
            // 
            // DBInfoLabel
            // 
            this.DBInfoLabel.AutoSize = true;
            this.DBInfoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBInfoLabel.Location = new System.Drawing.Point(19, 73);
            this.DBInfoLabel.Name = "DBInfoLabel";
            this.DBInfoLabel.Size = new System.Drawing.Size(169, 20);
            this.DBInfoLabel.TabIndex = 7;
            this.DBInfoLabel.Text = "Database Information";
            // 
            // DBInfoPanel
            // 
            this.DBInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.DBInfoPanel.Controls.Add(this.DBFileSizeLabel);
            this.DBInfoPanel.Controls.Add(this.DBFileSizeTitleLabel);
            this.DBInfoPanel.Controls.Add(this.DBFileNameLabel);
            this.DBInfoPanel.Controls.Add(this.DBFileNameTitleLabel);
            this.DBInfoPanel.Location = new System.Drawing.Point(23, 99);
            this.DBInfoPanel.Name = "DBInfoPanel";
            this.DBInfoPanel.Size = new System.Drawing.Size(294, 73);
            this.DBInfoPanel.TabIndex = 6;
            // 
            // DBFileNameLabel
            // 
            this.DBFileNameLabel.AutoSize = true;
            this.DBFileNameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBFileNameLabel.Location = new System.Drawing.Point(201, 19);
            this.DBFileNameLabel.Name = "DBFileNameLabel";
            this.DBFileNameLabel.Size = new System.Drawing.Size(86, 17);
            this.DBFileNameLabel.TabIndex = 7;
            this.DBFileNameLabel.Text = "dbFileName";
            // 
            // DBFileNameTitleLabel
            // 
            this.DBFileNameTitleLabel.AutoSize = true;
            this.DBFileNameTitleLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBFileNameTitleLabel.Location = new System.Drawing.Point(15, 19);
            this.DBFileNameTitleLabel.Name = "DBFileNameTitleLabel";
            this.DBFileNameTitleLabel.Size = new System.Drawing.Size(148, 17);
            this.DBFileNameTitleLabel.TabIndex = 6;
            this.DBFileNameTitleLabel.Text = "Database File Name: ";
            // 
            // DBFileSizeTitleLabel
            // 
            this.DBFileSizeTitleLabel.AutoSize = true;
            this.DBFileSizeTitleLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBFileSizeTitleLabel.Location = new System.Drawing.Point(15, 36);
            this.DBFileSizeTitleLabel.Name = "DBFileSizeTitleLabel";
            this.DBFileSizeTitleLabel.Size = new System.Drawing.Size(131, 17);
            this.DBFileSizeTitleLabel.TabIndex = 8;
            this.DBFileSizeTitleLabel.Text = "Database File Size: ";
            // 
            // DBFileSizeLabel
            // 
            this.DBFileSizeLabel.AutoSize = true;
            this.DBFileSizeLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBFileSizeLabel.Location = new System.Drawing.Point(218, 36);
            this.DBFileSizeLabel.Name = "DBFileSizeLabel";
            this.DBFileSizeLabel.Size = new System.Drawing.Size(69, 17);
            this.DBFileSizeLabel.TabIndex = 9;
            this.DBFileSizeLabel.Text = "dbFileSize";
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.DBInfoLabel);
            this.Controls.Add(this.DBInfoPanel);
            this.Controls.Add(this.NetworkInfoLabel);
            this.Controls.Add(this.NetworkInfoPanel);
            this.Controls.Add(this.FilterComboBox);
            this.Controls.Add(this.CollectablesLabel);
            this.Controls.Add(this.CollectablesPanel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(800, 440);
            this.CollectablesPanel.ResumeLayout(false);
            this.NetworkInfoPanel.ResumeLayout(false);
            this.NetworkInfoPanel.PerformLayout();
            this.DBInfoPanel.ResumeLayout(false);
            this.DBInfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private LiveCharts.WinForms.PieChart CollectablesPieChart;
        private System.Windows.Forms.Panel CollectablesPanel;
        private System.Windows.Forms.Label CollectablesLabel;
        private System.Windows.Forms.ComboBox FilterComboBox;
        private System.Windows.Forms.Panel NetworkInfoPanel;
        private System.Windows.Forms.Label NetworkInfoLabel;
        private System.Windows.Forms.Label NetConStatusLabel;
        private System.Windows.Forms.Label NetConLabel;
        private System.Windows.Forms.Label DBInfoLabel;
        private System.Windows.Forms.Panel DBInfoPanel;
        private System.Windows.Forms.Label DBFileSizeLabel;
        private System.Windows.Forms.Label DBFileSizeTitleLabel;
        private System.Windows.Forms.Label DBFileNameLabel;
        private System.Windows.Forms.Label DBFileNameTitleLabel;
    }
}
