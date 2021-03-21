using System;
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
        UIHandler ui = new UIHandler();

        public DashboardControl()
        {
            InitializeComponent();
            ui.RoundPanel(CollectablesPanel);
            ui.RoundPanel(InfoPanel);
            CheckNetworkConnection();
            CheckDatabaseStatus();
            LoadSampleData();    
        }

        Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);
        
        // make this load actual data, next time.
        private void LoadSampleData()
        {
            SeriesCollection series = new SeriesCollection();

            // fake data -> change this to show real data.
            series.Add(new PieSeries() { Title = "2020-2021", Values = new ChartValues<int> { 100000 }, DataLabels = true, LabelPoint = labelPoint });
            series.Add(new PieSeries() { Title = "2021-2022", Values = new ChartValues<int> { 125000 }, DataLabels = true, LabelPoint = labelPoint });
            series.Add(new PieSeries() { Title = "2022-2023", Values = new ChartValues<int> { 95000 }, DataLabels = true, LabelPoint = labelPoint });
            series.Add(new PieSeries() { Title = "2023-2024", Values = new ChartValues<int> { 100000 }, DataLabels = true, LabelPoint = labelPoint });
            series.Add(new PieSeries() { Title = "2024-2025", Values = new ChartValues<int> { 125000 }, DataLabels = true, LabelPoint = labelPoint });
            series.Add(new PieSeries() { Title = "2025-2026", Values = new ChartValues<int> { 95000 }, DataLabels = true, LabelPoint = labelPoint });
            CollectablesPieChart.Series = series;

            //CollectablesPieChart.LegendLocation = LegendLocation.Bottom;

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
