
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
            this.components = new System.ComponentModel.Container();
            this.network_timer = new System.Windows.Forms.Timer(this.components);
            this.ShowReportsButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.CollectablesPieChart = new LiveCharts.WinForms.PieChart();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.pingStatusLabel = new System.Windows.Forms.Label();
            this.NetConLabel = new System.Windows.Forms.Label();
            this.conStatusLabel = new System.Windows.Forms.Label();
            this.NetLatencyLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.OverallReportLabel = new System.Windows.Forms.Label();
            this.total_timer = new System.Windows.Forms.Timer(this.components);
            this.TitleLabel = new System.Windows.Forms.Label();
            this.FeeCollectionsLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.InfoPanel = new Financial_System.CustomUI.GradientPanel();
            this.CollectablesPanel = new Financial_System.CustomUI.GradientPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.InfoPanel2 = new Financial_System.CustomUI.GradientPanel();
            this.InfoPanel.SuspendLayout();
            this.CollectablesPanel.SuspendLayout();
            this.InfoPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // network_timer
            // 
            this.network_timer.Interval = 500;
            this.network_timer.Tick += new System.EventHandler(this.network_timer_Tick);
            // 
            // ShowReportsButton
            // 
            this.ShowReportsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.ShowReportsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowReportsButton.FlatAppearance.BorderSize = 0;
            this.ShowReportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowReportsButton.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.ShowReportsButton.ForeColor = System.Drawing.Color.White;
            this.ShowReportsButton.Location = new System.Drawing.Point(115, 245);
            this.ShowReportsButton.Name = "ShowReportsButton";
            this.ShowReportsButton.Size = new System.Drawing.Size(97, 26);
            this.ShowReportsButton.TabIndex = 18;
            this.ShowReportsButton.Text = "Show Reports";
            this.ShowReportsButton.UseVisualStyleBackColor = false;
            this.ShowReportsButton.Click += new System.EventHandler(this.ShowReportsButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(12, 230);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 15);
            this.label15.TabIndex = 44;
            this.label15.Text = "Year";
            // 
            // CollectablesPieChart
            // 
            this.CollectablesPieChart.BackColor = System.Drawing.Color.Transparent;
            this.CollectablesPieChart.BackColorTransparent = true;
            this.CollectablesPieChart.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollectablesPieChart.ForeColor = System.Drawing.Color.White;
            this.CollectablesPieChart.Location = new System.Drawing.Point(12, 12);
            this.CollectablesPieChart.Name = "CollectablesPieChart";
            this.CollectablesPieChart.Size = new System.Drawing.Size(271, 219);
            this.CollectablesPieChart.TabIndex = 0;
            // 
            // YearTextBox
            // 
            this.YearTextBox.BackColor = System.Drawing.Color.White;
            this.YearTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YearTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.YearTextBox.Location = new System.Drawing.Point(12, 248);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(97, 21);
            this.YearTextBox.TabIndex = 17;
            // 
            // pingStatusLabel
            // 
            this.pingStatusLabel.AutoSize = true;
            this.pingStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.pingStatusLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pingStatusLabel.Location = new System.Drawing.Point(224, 41);
            this.pingStatusLabel.Name = "pingStatusLabel";
            this.pingStatusLabel.Size = new System.Drawing.Size(33, 17);
            this.pingStatusLabel.TabIndex = 10;
            this.pingStatusLabel.Text = "N/A";
            // 
            // NetConLabel
            // 
            this.NetConLabel.AutoSize = true;
            this.NetConLabel.BackColor = System.Drawing.Color.Transparent;
            this.NetConLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetConLabel.ForeColor = System.Drawing.Color.White;
            this.NetConLabel.Location = new System.Drawing.Point(17, 15);
            this.NetConLabel.Name = "NetConLabel";
            this.NetConLabel.Size = new System.Drawing.Size(148, 17);
            this.NetConLabel.TabIndex = 6;
            this.NetConLabel.Text = "Network Connection:";
            // 
            // conStatusLabel
            // 
            this.conStatusLabel.AutoSize = true;
            this.conStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.conStatusLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conStatusLabel.Location = new System.Drawing.Point(224, 15);
            this.conStatusLabel.Name = "conStatusLabel";
            this.conStatusLabel.Size = new System.Drawing.Size(33, 17);
            this.conStatusLabel.TabIndex = 9;
            this.conStatusLabel.Text = "N/A";
            // 
            // NetLatencyLabel
            // 
            this.NetLatencyLabel.AutoSize = true;
            this.NetLatencyLabel.BackColor = System.Drawing.Color.Transparent;
            this.NetLatencyLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetLatencyLabel.ForeColor = System.Drawing.Color.White;
            this.NetLatencyLabel.Location = new System.Drawing.Point(17, 41);
            this.NetLatencyLabel.Name = "NetLatencyLabel";
            this.NetLatencyLabel.Size = new System.Drawing.Size(121, 17);
            this.NetLatencyLabel.TabIndex = 8;
            this.NetLatencyLabel.Text = "Network Latency:";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.ForeColor = System.Drawing.Color.White;
            this.TotalLabel.Location = new System.Drawing.Point(17, 16);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(43, 17);
            this.TotalLabel.TabIndex = 11;
            this.TotalLabel.Text = "Total:";
            // 
            // OverallReportLabel
            // 
            this.OverallReportLabel.AutoSize = true;
            this.OverallReportLabel.BackColor = System.Drawing.Color.Transparent;
            this.OverallReportLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverallReportLabel.ForeColor = System.Drawing.Color.Chartreuse;
            this.OverallReportLabel.Location = new System.Drawing.Point(224, 16);
            this.OverallReportLabel.Name = "OverallReportLabel";
            this.OverallReportLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OverallReportLabel.Size = new System.Drawing.Size(33, 17);
            this.OverallReportLabel.TabIndex = 6;
            this.OverallReportLabel.Text = "N/A";
            // 
            // total_timer
            // 
            this.total_timer.Interval = 1500;
            this.total_timer.Tick += new System.EventHandler(this.total_timer_Tick);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(18, 16);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(113, 22);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Dashboard";
            // 
            // FeeCollectionsLabel
            // 
            this.FeeCollectionsLabel.AutoSize = true;
            this.FeeCollectionsLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeeCollectionsLabel.Location = new System.Drawing.Point(19, 64);
            this.FeeCollectionsLabel.Name = "FeeCollectionsLabel";
            this.FeeCollectionsLabel.Size = new System.Drawing.Size(194, 20);
            this.FeeCollectionsLabel.TabIndex = 3;
            this.FeeCollectionsLabel.Text = "Collection Report (Yearly)";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.InfoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.Location = new System.Drawing.Point(324, 67);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(160, 20);
            this.InfoLabel.TabIndex = 7;
            this.InfoLabel.Text = "Network Information";
            // 
            // InfoPanel
            // 
            this.InfoPanel.Angle = 45F;
            this.InfoPanel.BottomColor = System.Drawing.Color.SteelBlue;
            this.InfoPanel.Controls.Add(this.NetConLabel);
            this.InfoPanel.Controls.Add(this.NetLatencyLabel);
            this.InfoPanel.Controls.Add(this.conStatusLabel);
            this.InfoPanel.Controls.Add(this.pingStatusLabel);
            this.InfoPanel.Location = new System.Drawing.Point(328, 90);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(288, 75);
            this.InfoPanel.TabIndex = 8;
            this.InfoPanel.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            // 
            // CollectablesPanel
            // 
            this.CollectablesPanel.Angle = 45F;
            this.CollectablesPanel.BottomColor = System.Drawing.Color.SteelBlue;
            this.CollectablesPanel.Controls.Add(this.CollectablesPieChart);
            this.CollectablesPanel.Controls.Add(this.YearTextBox);
            this.CollectablesPanel.Controls.Add(this.ShowReportsButton);
            this.CollectablesPanel.Location = new System.Drawing.Point(23, 90);
            this.CollectablesPanel.Name = "CollectablesPanel";
            this.CollectablesPanel.Size = new System.Drawing.Size(295, 283);
            this.CollectablesPanel.TabIndex = 9;
            this.CollectablesPanel.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(324, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Overall Collection Report";
            // 
            // InfoPanel2
            // 
            this.InfoPanel2.Angle = 45F;
            this.InfoPanel2.BottomColor = System.Drawing.Color.SteelBlue;
            this.InfoPanel2.Controls.Add(this.TotalLabel);
            this.InfoPanel2.Controls.Add(this.OverallReportLabel);
            this.InfoPanel2.Location = new System.Drawing.Point(328, 199);
            this.InfoPanel2.Name = "InfoPanel2";
            this.InfoPanel2.Size = new System.Drawing.Size(288, 47);
            this.InfoPanel2.TabIndex = 11;
            this.InfoPanel2.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.CollectablesPanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InfoPanel2);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.FeeCollectionsLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(848, 478);
            this.Load += new System.EventHandler(this.DashboardControl_Load);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.CollectablesPanel.ResumeLayout(false);
            this.CollectablesPanel.PerformLayout();
            this.InfoPanel2.ResumeLayout(false);
            this.InfoPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LiveCharts.WinForms.PieChart CollectablesPieChart;
        private System.Windows.Forms.Label NetConLabel;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Button ShowReportsButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label NetLatencyLabel;
        private System.Windows.Forms.Label pingStatusLabel;
        private System.Windows.Forms.Label conStatusLabel;
        private System.Windows.Forms.Label OverallReportLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Timer network_timer;
        private System.Windows.Forms.Timer total_timer;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label FeeCollectionsLabel;
        private System.Windows.Forms.Label InfoLabel;
        private CustomUI.GradientPanel InfoPanel;
        private CustomUI.GradientPanel CollectablesPanel;
        private System.Windows.Forms.Label label5;
        private CustomUI.GradientPanel InfoPanel2;
    }
}
