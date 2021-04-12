using System;
using System.Windows.Forms;
using Financial_System.Utils;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Financial_System.Features;

namespace Financial_System.UserControls
{
    enum Month
    {
        January = 01,
        February = 02,
        March = 03,
        April = 04,
        May = 05,
        June = 06,
        July = 07,
        August = 08,
        September = 09,
        October = 10,
        November = 11,
        December = 12
    }

    public partial class ReportsControl : UserControl
    {
        SQLiteHandler sql = new SQLiteHandler();
        UIHandler ui = new UIHandler();
        GetTotalResult gtr = new GetTotalResult();
        Globals gb = new Globals();

        public ReportsControl()
        {
            InitializeComponent();
            ui.RoundButton(expToCSVButton);
            
            
        }

        private async void ReportsControl_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            LoadTransactions();
            dateLabel.Text = DateTime.Now.ToString("M/d/yyyy");
            await LoadList();
        }

        // Loads Transactions
        public async void LoadTransactions()
        {
            dataGridView1.Rows.Clear();
            sql.GetAllTransactions(sql.CreateConnection(), dataGridView1);
            await gtr.GetTotal(dataGridView1, 3, totalLabel);
        }

        // Exports Reports CSV file (as of now Daily Collections pa)
        private void expToCSVButton_Click(object sender, EventArgs e)
        {
            //todo csv exporter
            string current = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string path = Path.Combine(current, "REPORTS.csv");

            try
            {
                //Build the CSV file data as a Comma separated string.
                string csv = string.Empty;

                //Add the Header row for CSV file.
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    csv += column.HeaderText + ',';
                }
                //Add new line.
                csv += "\r\n";

                //Adding the Rows

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            //Add the Data rows.
                            csv += cell.Value.ToString().TrimEnd(',').Replace(",", ";") + ',';
                        }
                        // break;
                    }
                    //Add new line.
                    csv += "\r\n";
                }

                //Exporting to CSV.

                File.WriteAllText(path, csv);
                MessageBox.Show("Export saved to: \n" + path);
            }
            catch
            {
                MessageBox.Show("Something Happened...");
            }
        }

        // Refreshes Transaction DataGridView
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadTransactions();
        }

        // Loads MonthList
        private async Task LoadList()
        {
            await Task.Run(() =>
            {
                foreach (string month in gb.MonthList)
                {
                    MonthComboBox.Items.Add(month);
                }

                foreach (string day in gb.DayList)
                {
                    DayComboBox.Items.Add(day);
                }

                // filter settings
                foreach (string settings in gb.ReportFilterList)
                {
                    FilterSettingsCbox.Items.Add(settings);
                }
            });
        }

        private async void FilterButton_Click(object sender, EventArgs e)
        {
            
            if (FilterSettingsCbox.SelectedIndex == 0)
            {
                if(DayComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Something went wrong. Please enter the necessary data, otherwise contact your administrator.");
                }
                else
                {
                    try
                    {
                        switch (MonthComboBox.SelectedIndex)
                        {
                            case 0:
                                FilterReportsByDay(Month.January);
                                break;
                            case 1:
                                FilterReportsByDay(Month.February);
                                break;
                            case 2:
                                FilterReportsByDay(Month.March);
                                break;
                            case 3:
                                FilterReportsByDay(Month.April);
                                break;
                            case 4:
                                FilterReportsByDay(Month.May);
                                break;
                            case 5:
                                FilterReportsByDay(Month.June);
                                break;
                            case 6:
                                FilterReportsByDay(Month.July);
                                break;
                            case 7:
                                FilterReportsByDay(Month.August);
                                break;
                            case 8:
                                FilterReportsByDay(Month.September);
                                break;
                            case 9:
                                FilterReportsByDay(Month.October);
                                break;
                            case 10:
                                FilterReportsByDay(Month.November);
                                break;
                            case 11:
                                FilterReportsByDay(Month.December);
                                break;
                        }
                        await gtr.GetTotal(dataGridView1, 3, totalLabel);
                    }
                    catch
                    {
                        MessageBox.Show("Something went wrong. Please enter the necessary data, otherwise contact your administrator.");
                    }
                }
                
                
            }
            else
            {
                try
                {
                    switch (MonthComboBox.SelectedIndex)
                    {
                        case 0:
                            FilterReportsByMonth(Month.January);
                            break;
                        case 1:
                            FilterReportsByMonth(Month.February);
                            break;
                        case 2:
                            FilterReportsByMonth(Month.March);
                            break;
                        case 3:
                            FilterReportsByMonth(Month.April);
                            break;
                        case 4:
                            FilterReportsByMonth(Month.May);
                            break;
                        case 5:
                            FilterReportsByMonth(Month.June);
                            break;
                        case 6:
                            FilterReportsByMonth(Month.July);
                            break;
                        case 7:
                            FilterReportsByMonth(Month.August);
                            break;
                        case 8:
                            FilterReportsByMonth(Month.September);
                            break;
                        case 9:
                            FilterReportsByMonth(Month.October);
                            break;
                        case 10:
                            FilterReportsByMonth(Month.November);
                            break;
                        case 11:
                            FilterReportsByMonth(Month.December);
                            break;
                    }
                    await gtr.GetTotal(dataGridView1, 3, totalLabel);
                }
                catch
                {
                    MessageBox.Show("Something went wrong. Please enter the necessary data, otherwise contact your administrator.");
                }
            }

        }

        // Filters Reports by Day (Daily Reports).
        private void FilterReportsByDay(Month month)
        {
            try
            {
                switch (month)
                {
                    case Month.January:
                        sql.FilterTransactionsByDay(sql.CreateConnection(), dataGridView1, "01", DayComboBox.SelectedItem.ToString(), YearTextBox.Text);
                        break;
                    case Month.February:
                        sql.FilterTransactionsByDay(sql.CreateConnection(), dataGridView1, "02", DayComboBox.SelectedItem.ToString(), YearTextBox.Text);
                        break;
                    case Month.March:
                        sql.FilterTransactionsByDay(sql.CreateConnection(), dataGridView1, "03", DayComboBox.SelectedItem.ToString(), YearTextBox.Text);
                        break;
                    case Month.April:
                        sql.FilterTransactionsByDay(sql.CreateConnection(), dataGridView1, "04", DayComboBox.SelectedItem.ToString(), YearTextBox.Text);
                        break;
                    case Month.May:
                        sql.FilterTransactionsByDay(sql.CreateConnection(), dataGridView1, "05", DayComboBox.SelectedItem.ToString(), YearTextBox.Text);
                        break;
                    case Month.June:
                        sql.FilterTransactionsByDay(sql.CreateConnection(), dataGridView1, "06", DayComboBox.SelectedItem.ToString(), YearTextBox.Text);
                        break;
                    case Month.July:
                        sql.FilterTransactionsByDay(sql.CreateConnection(), dataGridView1, "07", DayComboBox.SelectedItem.ToString(), YearTextBox.Text);
                        break;
                    case Month.August:
                        sql.FilterTransactionsByDay(sql.CreateConnection(), dataGridView1, "08", DayComboBox.SelectedItem.ToString(), YearTextBox.Text);
                        break;
                    case Month.September:
                        sql.FilterTransactionsByDay(sql.CreateConnection(), dataGridView1, "09", DayComboBox.SelectedItem.ToString(), YearTextBox.Text);
                        break;
                    case Month.October:
                        sql.FilterTransactionsByDay(sql.CreateConnection(), dataGridView1, "10", DayComboBox.SelectedItem.ToString(), YearTextBox.Text);
                        break;
                    case Month.November:
                        sql.FilterTransactionsByDay(sql.CreateConnection(), dataGridView1, "11", DayComboBox.SelectedItem.ToString(), YearTextBox.Text);
                        break;
                    case Month.December:
                        sql.FilterTransactionsByDay(sql.CreateConnection(), dataGridView1, "12", DayComboBox.SelectedItem.ToString(), YearTextBox.Text);
                        break;
                    default:
                        sql.GetAllTransactions(sql.CreateConnection(), dataGridView1);
                        break;

                }
            }
            catch
            {
                MessageBox.Show("Something went wrong. Please enter the necessary data, otherwise contact your administrator.");
            }
        }

        private void FilterReportsByMonth(Month month)
        {
            try
            {
                switch (month)
                {
                    case Month.January:
                        sql.FilterTransactionsByMonth(sql.CreateConnection(), dataGridView1, "01", YearTextBox.Text);
                        break;
                    case Month.February:
                        sql.FilterTransactionsByMonth(sql.CreateConnection(), dataGridView1, "02", YearTextBox.Text);
                        break;
                    case Month.March:
                        sql.FilterTransactionsByMonth(sql.CreateConnection(), dataGridView1, "03", YearTextBox.Text);
                        break;
                    case Month.April:
                        sql.FilterTransactionsByMonth(sql.CreateConnection(), dataGridView1, "04", YearTextBox.Text);
                        break;
                    case Month.May:
                        sql.FilterTransactionsByMonth(sql.CreateConnection(), dataGridView1, "05", YearTextBox.Text);
                        break;
                    case Month.June:
                        sql.FilterTransactionsByMonth(sql.CreateConnection(), dataGridView1, "06", YearTextBox.Text);
                        break;
                    case Month.July:
                        sql.FilterTransactionsByMonth(sql.CreateConnection(), dataGridView1, "07", YearTextBox.Text);
                        break;
                    case Month.August:
                        sql.FilterTransactionsByMonth(sql.CreateConnection(), dataGridView1, "08", YearTextBox.Text);
                        break;
                    case Month.September:
                        sql.FilterTransactionsByMonth(sql.CreateConnection(), dataGridView1, "09", YearTextBox.Text);
                        break;
                    case Month.October:
                        sql.FilterTransactionsByMonth(sql.CreateConnection(), dataGridView1, "10", YearTextBox.Text);
                        break;
                    case Month.November:
                        sql.FilterTransactionsByMonth(sql.CreateConnection(), dataGridView1, "11", YearTextBox.Text);
                        break;
                    case Month.December:
                        sql.FilterTransactionsByMonth(sql.CreateConnection(), dataGridView1, "12", YearTextBox.Text);
                        break;
                    default:
                        sql.GetAllTransactions(sql.CreateConnection(), dataGridView1);
                        break;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void FilterSettingsCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterSettingsCbox.SelectedIndex == 0)
            {
                DayComboBox.Enabled = true;     
            }
            else
            {
                DayComboBox.Enabled = false;
            }
        }
    }

    #region Custom Separator

    class Separator : Control
    { //this is a custom control. It appears as a horizontal line just like <hr> tag in html. It does nothing
        private int thickness = 1;
        private bool isVertical;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var size = isVertical ? Height / 2 : Width / 2;
            e.Graphics.TranslateTransform(Width / 2f, Height / 2f);

            using (var pen = new Pen(ForeColor, thickness))
            {
                if (!isVertical)
                {
                    e.Graphics.DrawLine(pen, -size + Padding.Left, 0, size - Padding.Right, 0);
                }
                else
                {
                    e.Graphics.DrawLine(pen, 0, -size + Padding.Top, 0, size - Padding.Bottom);
                }
            }
        }
        protected override void OnPaddingChanged(EventArgs e)
        {
            base.OnPaddingChanged(e);
            Invalidate();
        }
        public bool IsVertical
        {
            get => isVertical;
            set
            {
                isVertical = value;
                Invalidate();
            }
        }
        public int Thickness
        {
            get => thickness;
            set
            {
                thickness = value;
                if (Height < thickness)
                {
                    Height = thickness;
                }
                else
                {
                    Invalidate();
                }
            }
        }
    }

    #endregion
}
