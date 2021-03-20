
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
            this.NetConStatusLabel = new System.Windows.Forms.Label();
            this.NetConLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.DBFileNameLabel = new System.Windows.Forms.Label();
            this.DBFileNameTitleLabel = new System.Windows.Forms.Label();
            this.CollectablesPanel.SuspendLayout();
            this.InfoPanel.SuspendLayout();
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
            this.CollectablesPieChart.Size = new System.Drawing.Size(279, 227);
            this.CollectablesPieChart.TabIndex = 0;
            // 
            // CollectablesPanel
            // 
            this.CollectablesPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CollectablesPanel.Controls.Add(this.CollectablesPieChart);
            this.CollectablesPanel.Location = new System.Drawing.Point(23, 90);
            this.CollectablesPanel.Name = "CollectablesPanel";
            this.CollectablesPanel.Size = new System.Drawing.Size(306, 262);
            this.CollectablesPanel.TabIndex = 2;
            // 
            // FeeCollectionsLabel
            // 
            this.FeeCollectionsLabel.AutoSize = true;
            this.FeeCollectionsLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeeCollectionsLabel.Location = new System.Drawing.Point(19, 64);
            this.FeeCollectionsLabel.Name = "FeeCollectionsLabel";
            this.FeeCollectionsLabel.Size = new System.Drawing.Size(270, 20);
            this.FeeCollectionsLabel.TabIndex = 3;
            this.FeeCollectionsLabel.Text = "Fee Collections (by Academic Year)";
            // 
            // NetConStatusLabel
            // 
            this.NetConStatusLabel.AutoSize = true;
            this.NetConStatusLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetConStatusLabel.Location = new System.Drawing.Point(224, 31);
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
            this.NetConLabel.Location = new System.Drawing.Point(15, 31);
            this.NetConLabel.Name = "NetConLabel";
            this.NetConLabel.Size = new System.Drawing.Size(148, 17);
            this.NetConLabel.TabIndex = 6;
            this.NetConLabel.Text = "Network Connection:";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.Location = new System.Drawing.Point(19, 368);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(157, 20);
            this.InfoLabel.TabIndex = 7;
            this.InfoLabel.Text = "General Information";
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.InfoPanel.Controls.Add(this.NetConStatusLabel);
            this.InfoPanel.Controls.Add(this.DBFileNameLabel);
            this.InfoPanel.Controls.Add(this.NetConLabel);
            this.InfoPanel.Controls.Add(this.DBFileNameTitleLabel);
            this.InfoPanel.Location = new System.Drawing.Point(23, 391);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(306, 65);
            this.InfoPanel.TabIndex = 6;
            // 
            // DBFileNameLabel
            // 
            this.DBFileNameLabel.AutoSize = true;
            this.DBFileNameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBFileNameLabel.Location = new System.Drawing.Point(205, 14);
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
            this.DBFileNameTitleLabel.Location = new System.Drawing.Point(15, 14);
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
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.FeeCollectionsLabel);
            this.Controls.Add(this.CollectablesPanel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(848, 478);
            this.CollectablesPanel.ResumeLayout(false);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private LiveCharts.WinForms.PieChart CollectablesPieChart;
        private System.Windows.Forms.Panel CollectablesPanel;
        private System.Windows.Forms.Label FeeCollectionsLabel;
        private System.Windows.Forms.Label NetConStatusLabel;
        private System.Windows.Forms.Label NetConLabel;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Label DBFileNameLabel;
        private System.Windows.Forms.Label DBFileNameTitleLabel;
    }
}
