﻿using System;
using System.Windows.Forms;
using Financial_System.Utils;
using System.Drawing;
using System.IO;
using System.Reflection;

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
        Globals gb = new Globals();

        public ReportsControl()
        {
            InitializeComponent();
            ui.RoundButton(expToCSVButton);
            ui.RoundButton(printButton);
            LoadList();
            
        }

        private void ReportsControl_Load(object sender, EventArgs e)
        {
            LoadTransactions();
            dateLabel.Text = DateTime.Now.ToString("M/d/yyyy");
        }

        // Loads Transactions
        public void LoadTransactions()
        {
            dataGridView1.Rows.Clear();
            sql.GetAllTransactions(sql.CreateConnection(), dataGridView1);
            GetTotal();
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

        // Get Total Sum of Reports (as of now Daily Collections pa)
        private void GetTotal()
        {
            int i = 0;

            foreach(DataGridViewRow r in dataGridView1.Rows)
            {
                i += Convert.ToInt32(r.Cells[3].Value);
            }

            totalLabel.Text = i.ToString();
        }

        // Refreshes Transaction DataGridView
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadTransactions();
        }

        // Loads MonthList
        private void LoadList()
        {
            foreach(string month in gb.MonthList)
            {
                FilterComboBox.Items.Add(month);
            }
            
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            switch (FilterComboBox.SelectedIndex)
            {
                case 0:
                    FilterReports(Month.January);
                    break;
                case 1:
                    FilterReports(Month.February);
                    break;
                case 2:
                    FilterReports(Month.March);
                    break;
                case 3:
                    FilterReports(Month.April);
                    break;
                case 4:
                    FilterReports(Month.May);
                    break;
                case 5:
                    FilterReports(Month.June);
                    break;
                case 6:
                    FilterReports(Month.July);
                    break;
                case 7:
                    FilterReports(Month.August);
                    break;
                case 8:
                    FilterReports(Month.September);
                    break;
                case 9:
                    FilterReports(Month.October);
                    break;
                case 10:
                    FilterReports(Month.November);
                    break;
                case 11:
                    FilterReports(Month.December);
                    break;
            }
            GetTotal();
        }

        // Filters Reports by Month.
        private void FilterReports(Month month)
        {
            try
            {
                switch (month)
                {
                    case Month.January:
                        sql.FilterTransactionsByMonth(sql.CreateConnection(), dataGridView1, "01");
                        break;
                    case Month.February:
                        sql.FilterTransactionsByMonth(sql.CreateConnection(), dataGridView1, "02");
                        break;
                    case Month.March:
                        sql.FilterTransactionsByMonth(sql.CreateConnection(), dataGridView1, "03");
                        break;
                    case Month.April:
                        sql.FilterTransactionsByMonth(sql.CreateConnection(), dataGridView1, "04");
                        break;
                    case Month.May:
                        sql.FilterTransactionsByMonth(sql.CreateConnection(), dataGridView1, "05");
                        break;
                    case Month.June:
                        sql.FilterTransactionsByMonth(sql.CreateConnection(), dataGridView1, "06");
                        break;
                    case Month.July:
                        sql.FilterTransactionsByMonth(sql.CreateConnection(), dataGridView1, "07");
                        break;
                    case Month.August:
                        sql.FilterTransactionsByMonth(sql.CreateConnection(), dataGridView1, "08");
                        break;
                    case Month.September:
                        sql.FilterTransactionsByMonth(sql.CreateConnection(), dataGridView1, "09");
                        break;
                    case Month.October:
                        sql.FilterTransactionsByMonth(sql.CreateConnection(), dataGridView1, "10");
                        break;
                    case Month.November:
                        sql.FilterTransactionsByMonth(sql.CreateConnection(), dataGridView1, "11");
                        break;
                    case Month.December:
                        sql.FilterTransactionsByMonth(sql.CreateConnection(), dataGridView1, "12");
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
