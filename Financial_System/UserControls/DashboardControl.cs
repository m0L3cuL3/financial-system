using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
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
        public DashboardControl()
        {
            InitializeComponent();
            ui.RoundPanel(CollectablesPanel);
            ui.RoundPanel(InfoPanel);
            CheckNetworkConnection();
            CheckDatabaseStatus();
            LoadChartData();
        }

        Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);

        // make this load actual data, next time.
        public void LoadChartData()
        {
            SeriesCollection series = new SeriesCollection();

            

            series.Add(new PieSeries() { Title = gb.MonthList[0], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[0]) }, DataLabels = true, LabelPoint = labelPoint });
            series.Add(new PieSeries() { Title = gb.MonthList[1], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[1]) }, DataLabels = true, LabelPoint = labelPoint });
            series.Add(new PieSeries() { Title = gb.MonthList[2], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[2]) }, DataLabels = true, LabelPoint = labelPoint });
            series.Add(new PieSeries() { Title = gb.MonthList[3], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[3]) }, DataLabels = true, LabelPoint = labelPoint });
            series.Add(new PieSeries() { Title = gb.MonthList[4], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[4]) }, DataLabels = true, LabelPoint = labelPoint });
            series.Add(new PieSeries() { Title = gb.MonthList[5], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[5]) }, DataLabels = true, LabelPoint = labelPoint });
            series.Add(new PieSeries() { Title = gb.MonthList[6], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[6]) }, DataLabels = true, LabelPoint = labelPoint });
            series.Add(new PieSeries() { Title = gb.MonthList[7], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[7]) }, DataLabels = true, LabelPoint = labelPoint });
            series.Add(new PieSeries() { Title = gb.MonthList[8], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[8]) }, DataLabels = true, LabelPoint = labelPoint });
            series.Add(new PieSeries() { Title = gb.MonthList[9], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[9]) }, DataLabels = true, LabelPoint = labelPoint });
            series.Add(new PieSeries() { Title = gb.MonthList[10], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[10]) }, DataLabels = true, LabelPoint = labelPoint });
            series.Add(new PieSeries() { Title = gb.MonthList[11], Values = new ChartValues<int> { sql.GetTotalTransByMonth(sql.CreateConnection(), gb.MonthIndex[11]) }, DataLabels = true, LabelPoint = labelPoint });

            CollectablesPieChart.Series = series;

            CollectablesPieChart.LegendLocation = LegendLocation.Bottom;

            // fix for Negative/Black PieChart (Sean Baang)
            CollectablesPieChart.Hide();
            CollectablesPieChart.Show();
        }

        // checks network connection.
        private void CheckNetworkConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com"))
                NetConStatusLabel.ForeColor = Color.DodgerBlue;
                NetConStatusLabel.Text = "online";
            }
            catch
            {
                NetConStatusLabel.ForeColor = Color.Red;
                NetConStatusLabel.Text = "offline";
            }
        }

        // checks database status. (as of now, it displays only the file)
        private void CheckDatabaseStatus()
        {
            string dbName = "database.db";
            DirectoryInfo path = new DirectoryInfo(@"\");
            string filename = null;

            filename = Path.GetFileName(path + dbName);

            DBFileNameLabel.ForeColor = Color.DodgerBlue;
            DBFileNameLabel.Text = filename;
        }
    }
}
