using System;
using System.Drawing;
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
            ui.RoundPanel(NetworkInfoPanel);
            ui.RoundPanel(DBInfoPanel);
            CheckNetworkConnection();
            //FilterList(); -> dont use this yet, quite confusing on development.
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

            CollectablesPieChart.LegendLocation = LegendLocation.Bottom;

            // fix for Negative/Black PieChart (Sean Baang)
            CollectablesPieChart.Hide();
            CollectablesPieChart.Show();
        }

        // again, for testing purposes only!
        private void LoadSampleDataByFilter(string title, int value)
        {
            SeriesCollection series = new SeriesCollection();
            series.Add(new PieSeries() { Title = title, Values = new ChartValues<int> { value }, DataLabels = true, LabelPoint = labelPoint });
            CollectablesPieChart.Series = series;

            CollectablesPieChart.LegendLocation = LegendLocation.Bottom;

            // fix for Negative/Black PieChart (Sean Baang)
            CollectablesPieChart.Hide();
            CollectablesPieChart.Show();
        }

        // for testing purpose only -> find a way to create list efficiently!
        private void FilterList() //FilterList(string start, string end) -> make it accept params.
        {
            // dont hardcode this shit! -> probably use SELECT start, end FROM TERM -> then concat start, end (ex. 2020 + "-" + 2021)(cont. start + "-" + end)
            FilterComboBox.Items.Add("Show all");
            FilterComboBox.Items.Add("2020-2021");
            FilterComboBox.Items.Add("2021-2022");
            FilterComboBox.Items.Add("2022-2023");
            FilterComboBox.Items.Add("2023-2024");
            FilterComboBox.Items.Add("2024-2025");
            FilterComboBox.Items.Add("2025-2026");
        }

        // Bad way of filtering -> DO NOT USE THIS SHIT!
        private void FilterComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // note: using switch case is probably the best way to filter this shit. (probably use SQL queries)
            switch (FilterComboBox.SelectedItem)
            {
                case "Show all":
                    LoadSampleData();
                    break;
                case "2020-2021":
                    LoadSampleDataByFilter("2020-2021", 100000);
                    break;
                case "2021-2022":
                    LoadSampleDataByFilter("2021-2022", 125000);
                    break;
                case "2022-2023":
                    LoadSampleDataByFilter("2022-2023", 95000);
                    break;
                case "2023-2024":
                    LoadSampleDataByFilter("2023-2024", 100000);
                    break;
                case "2024-2025":
                    LoadSampleDataByFilter("2024-2025", 125000);
                    break;
                case "2025-2026":
                    LoadSampleDataByFilter("2025-2026", 95000);
                    break;

            }
        }

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
    }
}
