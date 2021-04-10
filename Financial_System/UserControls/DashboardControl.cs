using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using Financial_System.Utils;
using LiveCharts;
using LiveCharts.Wpf;

namespace Financial_System.UserControls
{
    public partial class DashboardControl : UserControl
    {
        SQLiteHandler sql = new SQLiteHandler();
        UIHandler ui = new UIHandler();
        Globals gb = new Globals();

        string currYear = DateTime.Now.Year.ToString();
        string currMonth = DateTime.Now.Month.ToString();

        public DashboardControl()
        {
            InitializeComponent();
            ui.RoundPanel(CollectablesPanel);
            ui.RoundPanel(InfoPanel);
            CheckNetworkConnection();
        }


        Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);

        // Load Current Year Collection Reports
        public void LoadCurrReports()
        {
            
            try
            {
                SeriesCollection series = new SeriesCollection();

                series.Add(new PieSeries() { Title = gb.MonthList[0], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[0], currYear) }, DataLabels = true, LabelPoint = labelPoint });
                series.Add(new PieSeries() { Title = gb.MonthList[1], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[1], currYear) }, DataLabels = true, LabelPoint = labelPoint });
                series.Add(new PieSeries() { Title = gb.MonthList[2], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[2], currYear) }, DataLabels = true, LabelPoint = labelPoint });
                series.Add(new PieSeries() { Title = gb.MonthList[3], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[3], currYear) }, DataLabels = true, LabelPoint = labelPoint });
                series.Add(new PieSeries() { Title = gb.MonthList[4], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[4], currYear) }, DataLabels = true, LabelPoint = labelPoint });
                series.Add(new PieSeries() { Title = gb.MonthList[5], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[5], currYear) }, DataLabels = true, LabelPoint = labelPoint });
                series.Add(new PieSeries() { Title = gb.MonthList[6], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[6], currYear) }, DataLabels = true, LabelPoint = labelPoint });
                series.Add(new PieSeries() { Title = gb.MonthList[7], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[7], currYear) }, DataLabels = true, LabelPoint = labelPoint });
                series.Add(new PieSeries() { Title = gb.MonthList[8], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[8], currYear) }, DataLabels = true, LabelPoint = labelPoint });
                series.Add(new PieSeries() { Title = gb.MonthList[9], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[9], currYear) }, DataLabels = true, LabelPoint = labelPoint });
                series.Add(new PieSeries() { Title = gb.MonthList[10], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[10], currYear) }, DataLabels = true, LabelPoint = labelPoint });
                series.Add(new PieSeries() { Title = gb.MonthList[11], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[11], currYear) }, DataLabels = true, LabelPoint = labelPoint });

                CollectablesPieChart.Series = series;

                CollectablesPieChart.LegendLocation = LegendLocation.Bottom;

                // fix for Negative/Black PieChart (Sean Baang)
                CollectablesPieChart.Hide();
                CollectablesPieChart.Show();
            }
            catch
            {
                //TODO: Make exception output.
            }   
        }

        // Load Specific Year Collection Reports
        private void LoadReports()
        {
            try
            {
                SeriesCollection series = new SeriesCollection();

                series.Add(new PieSeries() { Title = gb.MonthList[0], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[0], YearTextBox.Text) }, DataLabels = true, LabelPoint = labelPoint });
                series.Add(new PieSeries() { Title = gb.MonthList[1], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[1], YearTextBox.Text) }, DataLabels = true, LabelPoint = labelPoint });
                series.Add(new PieSeries() { Title = gb.MonthList[2], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[2], YearTextBox.Text) }, DataLabels = true, LabelPoint = labelPoint });
                series.Add(new PieSeries() { Title = gb.MonthList[3], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[3], YearTextBox.Text) }, DataLabels = true, LabelPoint = labelPoint });
                series.Add(new PieSeries() { Title = gb.MonthList[4], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[4], YearTextBox.Text) }, DataLabels = true, LabelPoint = labelPoint });
                series.Add(new PieSeries() { Title = gb.MonthList[5], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[5], YearTextBox.Text) }, DataLabels = true, LabelPoint = labelPoint });
                series.Add(new PieSeries() { Title = gb.MonthList[6], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[6], YearTextBox.Text) }, DataLabels = true, LabelPoint = labelPoint });
                series.Add(new PieSeries() { Title = gb.MonthList[7], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[7], YearTextBox.Text) }, DataLabels = true, LabelPoint = labelPoint });
                series.Add(new PieSeries() { Title = gb.MonthList[8], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[8], YearTextBox.Text) }, DataLabels = true, LabelPoint = labelPoint });
                series.Add(new PieSeries() { Title = gb.MonthList[9], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[9], YearTextBox.Text) }, DataLabels = true, LabelPoint = labelPoint });
                series.Add(new PieSeries() { Title = gb.MonthList[10], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[10], YearTextBox.Text) }, DataLabels = true, LabelPoint = labelPoint });
                series.Add(new PieSeries() { Title = gb.MonthList[11], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[11], YearTextBox.Text) }, DataLabels = true, LabelPoint = labelPoint });

                CollectablesPieChart.Series = series;

                CollectablesPieChart.LegendLocation = LegendLocation.Bottom;

                // fix for Negative/Black PieChart (Sean Baang)
                CollectablesPieChart.Hide();
                CollectablesPieChart.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        // checks network connection.
        private void CheckNetworkConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com"))
                conStatusLabel.ForeColor = Color.DodgerBlue;
                conStatusLabel.Text = "online";
                network_timer.Start();
            }
            catch
            {
                conStatusLabel.ForeColor = Color.Red;
                conStatusLabel.Text = "offline";
            }
        }

        private void ShowReportsButton_Click(object sender, EventArgs e)
        {
            LoadReports();
        }

        private void network_timer_Tick(object sender, EventArgs e)
        {
            Ping pc = new Ping();
            PingReply pr = pc.Send("www.google.com");
            pingStatusLabel.ForeColor = Color.DodgerBlue;
            pingStatusLabel.Text = $"{pr.RoundtripTime} ms";
        }
    }
}
