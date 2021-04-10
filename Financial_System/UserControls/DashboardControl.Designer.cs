
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CollectablesPieChart = new LiveCharts.WinForms.PieChart();
            this.CollectablesPanel = new System.Windows.Forms.Panel();
            this.FeeCollectionsLabel = new System.Windows.Forms.Label();
            this.NetConLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.ShowReportsButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.NetLatencyLabel = new System.Windows.Forms.Label();
            this.network_timer = new System.Windows.Forms.Timer(this.components);
            this.conStatusLabel = new System.Windows.Forms.Label();
            this.pingStatusLabel = new System.Windows.Forms.Label();
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
            this.CollectablesPieChart.Size = new System.Drawing.Size(258, 227);
            this.CollectablesPieChart.TabIndex = 0;
            // 
            // CollectablesPanel
            // 
            this.CollectablesPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CollectablesPanel.Controls.Add(this.label15);
            this.CollectablesPanel.Controls.Add(this.ShowReportsButton);
            this.CollectablesPanel.Controls.Add(this.YearTextBox);
            this.CollectablesPanel.Controls.Add(this.CollectablesPieChart);
            this.CollectablesPanel.Location = new System.Drawing.Point(23, 90);
            this.CollectablesPanel.Name = "CollectablesPanel";
            this.CollectablesPanel.Size = new System.Drawing.Size(384, 255);
            this.CollectablesPanel.TabIndex = 2;
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
            // NetConLabel
            // 
            this.NetConLabel.AutoSize = true;
            this.NetConLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetConLabel.Location = new System.Drawing.Point(9, 16);
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
            this.InfoLabel.Size = new System.Drawing.Size(160, 20);
            this.InfoLabel.TabIndex = 7;
            this.InfoLabel.Text = "Network Information";
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.InfoPanel.Controls.Add(this.pingStatusLabel);
            this.InfoPanel.Controls.Add(this.conStatusLabel);
            this.InfoPanel.Controls.Add(this.NetLatencyLabel);
            this.InfoPanel.Controls.Add(this.NetConLabel);
            this.InfoPanel.Location = new System.Drawing.Point(23, 391);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(248, 65);
            this.InfoPanel.TabIndex = 6;
            // 
            // YearTextBox
            // 
            this.YearTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.YearTextBox.Location = new System.Drawing.Point(276, 32);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(97, 21);
            this.YearTextBox.TabIndex = 17;
            // 
            // ShowReportsButton
            // 
            this.ShowReportsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.ShowReportsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowReportsButton.FlatAppearance.BorderSize = 0;
            this.ShowReportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowReportsButton.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.ShowReportsButton.ForeColor = System.Drawing.Color.White;
            this.ShowReportsButton.Location = new System.Drawing.Point(276, 215);
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
            this.label15.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(276, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 15);
            this.label15.TabIndex = 44;
            this.label15.Text = "Year";
            // 
            // NetLatencyLabel
            // 
            this.NetLatencyLabel.AutoSize = true;
            this.NetLatencyLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetLatencyLabel.Location = new System.Drawing.Point(9, 36);
            this.NetLatencyLabel.Name = "NetLatencyLabel";
            this.NetLatencyLabel.Size = new System.Drawing.Size(121, 17);
            this.NetLatencyLabel.TabIndex = 8;
            this.NetLatencyLabel.Text = "Network Latency:";
            // 
            // network_timer
            // 
            this.network_timer.Interval = 1000;
            this.network_timer.Tick += new System.EventHandler(this.network_timer_Tick);
            // 
            // conStatusLabel
            // 
            this.conStatusLabel.AutoSize = true;
            this.conStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.conStatusLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conStatusLabel.Location = new System.Drawing.Point(176, 16);
            this.conStatusLabel.Name = "conStatusLabel";
            this.conStatusLabel.Size = new System.Drawing.Size(33, 17);
            this.conStatusLabel.TabIndex = 9;
            this.conStatusLabel.Text = "N/A";
            // 
            // pingStatusLabel
            // 
            this.pingStatusLabel.AutoSize = true;
            this.pingStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.pingStatusLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pingStatusLabel.Location = new System.Drawing.Point(176, 36);
            this.pingStatusLabel.Name = "pingStatusLabel";
            this.pingStatusLabel.Size = new System.Drawing.Size(33, 17);
            this.pingStatusLabel.TabIndex = 10;
            this.pingStatusLabel.Text = "N/A";
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
            this.CollectablesPanel.PerformLayout();
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
        private System.Windows.Forms.Label NetConLabel;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Button ShowReportsButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label NetLatencyLabel;
        private System.Windows.Forms.Timer network_timer;
        private System.Windows.Forms.Label pingStatusLabel;
        private System.Windows.Forms.Label conStatusLabel;
    }
}
