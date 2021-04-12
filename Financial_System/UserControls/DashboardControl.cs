using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Financial_System.Features;
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
        SeriesCollection series;

        string currYear = DateTime.Now.Year.ToString();

        Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);

        public DashboardControl()
        {
            InitializeComponent();
            ui.RoundPanel(CollectablesPanel);
            ui.RoundPanel(InfoPanel);
            ui.RoundPanel(InfoPanel2);
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {
            CheckNetworkConnection();
            LoadCurrReportsAsync();
            total_timer.Start();
        }

        // Load Current Year Collection Reports
        public void LoadCurrReportsAsync()
        {
            try
            {
                series = new SeriesCollection();

                int mIndex = 0;
                for(int i = 0; i < gb.MonthList.Length; i++)
                {
                    series.Add(new PieSeries() { Title = gb.MonthList[i], Values = new ChartValues<int> { sql.GetTotalTransByMonthAsync(sql.CreateConnection(), gb.MonthIndex[mIndex], currYear) }, DataLabels = true, LabelPoint = labelPoint });
                    mIndex += 1;

                    CollectablesPieChart.Series = series;
                    CollectablesPieChart.LegendLocation = LegendLocation.Bottom;

                    // fix for Negative/Black PieChart (Sean Baang)
                    CollectablesPieChart.Hide();
                    CollectablesPieChart.Show();
                }
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
                series = new SeriesCollection();

                int mIndex = 0;
                for (int i = 0; i < gb.MonthList.Length; i++)
                {
                    series.Add(new PieSeries() { Title = gb.MonthList[i], Values = new ChartValues<int> { sql.GetTotalTransByMonthAsync(sql.CreateConnection(), gb.MonthIndex[mIndex], YearTextBox.Text) }, DataLabels = true, LabelPoint = labelPoint });
                    mIndex += 1;

                    CollectablesPieChart.Series = series;
                    CollectablesPieChart.LegendLocation = LegendLocation.Bottom;

                    // fix for Negative/Black PieChart (Sean Baang)
                    CollectablesPieChart.Hide();
                    CollectablesPieChart.Show();
                }
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
                conStatusLabel.ForeColor = Color.LimeGreen;
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
            if (pr.RoundtripTime <= 100)
            {
                pingStatusLabel.ForeColor = Color.LimeGreen;
                pingStatusLabel.Text = $"{pr.RoundtripTime} ms";
            }
            else if (pr.RoundtripTime >= 200)
            {
                pingStatusLabel.ForeColor = Color.FromArgb(235, 183, 87);
                pingStatusLabel.Text = $"{pr.RoundtripTime} ms";
            }
            else if (pr.RoundtripTime >= 300)
            {
                pingStatusLabel.ForeColor = Color.FromArgb(235, 87, 87);
                pingStatusLabel.Text = $"{pr.RoundtripTime} ms";
            }
        }

        private async void total_timer_Tick(object sender, EventArgs e)
        {
            OverallReportLabel.Text = await sql.GetTotalTransaction(sql.CreateConnection());
        }
    }
}
