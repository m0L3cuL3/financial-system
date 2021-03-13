
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
            this.FeeCollectionsLabel = new System.Windows.Forms.Label();
            this.NetworkInfoPanel = new System.Windows.Forms.Panel();
            this.NetConStatusLabel = new System.Windows.Forms.Label();
            this.NetConLabel = new System.Windows.Forms.Label();
            this.NetworkInfoLabel = new System.Windows.Forms.Label();
            this.DBInfoLabel = new System.Windows.Forms.Label();
            this.DBInfoPanel = new System.Windows.Forms.Panel();
            this.DBFileNameLabel = new System.Windows.Forms.Label();
            this.DBFileNameTitleLabel = new System.Windows.Forms.Label();
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
            this.CollectablesPieChart.Location = new System.Drawing.Point(12, 14);
            this.CollectablesPieChart.Name = "CollectablesPieChart";
            this.CollectablesPieChart.Size = new System.Drawing.Size(395, 287);
            this.CollectablesPieChart.TabIndex = 0;
            // 
            // CollectablesPanel
            // 
            this.CollectablesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.CollectablesPanel.Controls.Add(this.CollectablesPieChart);
            this.CollectablesPanel.Location = new System.Drawing.Point(360, 99);
            this.CollectablesPanel.Name = "CollectablesPanel";
            this.CollectablesPanel.Size = new System.Drawing.Size(419, 319);
            this.CollectablesPanel.TabIndex = 2;
            // 
            // FeeCollectionsLabel
            // 
            this.FeeCollectionsLabel.AutoSize = true;
            this.FeeCollectionsLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeeCollectionsLabel.Location = new System.Drawing.Point(356, 73);
            this.FeeCollectionsLabel.Name = "FeeCollectionsLabel";
            this.FeeCollectionsLabel.Size = new System.Drawing.Size(190, 20);
            this.FeeCollectionsLabel.TabIndex = 3;
            this.FeeCollectionsLabel.Text = "Fee Collections (by Term)";
            // 
            // NetworkInfoPanel
            // 
            this.NetworkInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.NetworkInfoPanel.Controls.Add(this.NetConStatusLabel);
            this.NetworkInfoPanel.Controls.Add(this.NetConLabel);
            this.NetworkInfoPanel.Location = new System.Drawing.Point(23, 190);
            this.NetworkInfoPanel.Name = "NetworkInfoPanel";
            this.NetworkInfoPanel.Size = new System.Drawing.Size(306, 55);
            this.NetworkInfoPanel.TabIndex = 3;
            // 
            // NetConStatusLabel
            // 
            this.NetConStatusLabel.AutoSize = true;
            this.NetConStatusLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetConStatusLabel.Location = new System.Drawing.Point(222, 19);
            this.NetConStatusLabel.Name = "NetConStatusLabel";
            this.NetConStatusLabel.Size = new System.Drawing.Size(67, 17);
            this.NetConStatusLabel.TabIndex = 7;
            this.NetConStatusLabel.Text = "netStatus";
            this.NetConStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // NetworkInfoLabel
            // 
            this.NetworkInfoLabel.AutoSize = true;
            this.NetworkInfoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetworkInfoLabel.Location = new System.Drawing.Point(19, 167);
            this.NetworkInfoLabel.Name = "NetworkInfoLabel";
            this.NetworkInfoLabel.Size = new System.Drawing.Size(160, 20);
            this.NetworkInfoLabel.TabIndex = 5;
            this.NetworkInfoLabel.Text = "Network Information";
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
            this.DBInfoPanel.Controls.Add(this.DBFileNameLabel);
            this.DBInfoPanel.Controls.Add(this.DBFileNameTitleLabel);
            this.DBInfoPanel.Location = new System.Drawing.Point(23, 99);
            this.DBInfoPanel.Name = "DBInfoPanel";
            this.DBInfoPanel.Size = new System.Drawing.Size(306, 54);
            this.DBInfoPanel.TabIndex = 6;
            // 
            // DBFileNameLabel
            // 
            this.DBFileNameLabel.AutoSize = true;
            this.DBFileNameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBFileNameLabel.Location = new System.Drawing.Point(203, 19);
            this.DBFileNameLabel.Name = "DBFileNameLabel";
            this.DBFileNameLabel.Size = new System.Drawing.Size(86, 17);
            this.DBFileNameLabel.TabIndex = 7;
            this.DBFileNameLabel.Text = "dbFileName";
            this.DBFileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.DBInfoLabel);
            this.Controls.Add(this.DBInfoPanel);
            this.Controls.Add(this.NetworkInfoLabel);
            this.Controls.Add(this.NetworkInfoPanel);
            this.Controls.Add(this.FeeCollectionsLabel);
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
        private System.Windows.Forms.Label FeeCollectionsLabel;
        private System.Windows.Forms.Panel NetworkInfoPanel;
        private System.Windows.Forms.Label NetworkInfoLabel;
        private System.Windows.Forms.Label NetConStatusLabel;
        private System.Windows.Forms.Label NetConLabel;
        private System.Windows.Forms.Label DBInfoLabel;
        private System.Windows.Forms.Panel DBInfoPanel;
        private System.Windows.Forms.Label DBFileNameLabel;
        private System.Windows.Forms.Label DBFileNameTitleLabel;
    }
}
