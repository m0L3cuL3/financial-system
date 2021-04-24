﻿using System;
using System.Windows.Forms;
using Financial_System.Utils;
using System.Drawing;
using System.IO;
using Financial_System.Features;
using ClosedXML.Excel;

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
            ui.RoundButton(exportButton); 
        }

        private async void ReportsControl_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            LoadTransactions();
            dateLabel.Text = DateTime.Now.ToString("M/d/yyyy");
            await gtr.GetList(MonthComboBox, gb.MonthList);
            await gtr.GetList(DayComboBox, gb.DayList);
            await gtr.GetList(FilterSettingsCbox, gb.ReportFilterList);
        }

        // Loads Transactions
        public async void LoadTransactions()
        {
            dataGridView1.Rows.Clear();
            sql.GetAllTransactions(sql.CreateConnection(), dataGridView1);
            await gtr.GetTotal(dataGridView1, 3, totalLabel);
        }

        // Exports Reports Excel file.
        private void expToCSVButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (FilterSettingsCbox.SelectedIndex)
                {
                    case 0:
                        if (MonthComboBox.SelectedItem == null || DayComboBox.SelectedItem == null || YearTextBox.Text == "")
                        {
                            MessageBox.Show("Something went wrong. Make sure to enter the necessary data.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            ExportDaily(MonthComboBox.SelectedItem.ToString(), DayComboBox.SelectedItem.ToString(), YearTextBox.Text);
                        }
                        break;
                    case 1:
                        if (MonthComboBox.SelectedItem == null || YearTextBox.Text == "")
                        {
                            MessageBox.Show("Something went wrong. Make sure to enter the necessary data.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            ExportMonthly(MonthComboBox.SelectedItem.ToString(), YearTextBox.Text);
                        }
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occured. {ex.Message}", "Export Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        // Refreshes Transaction DataGridView
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadTransactions();
        }

        // Filters Transaction
        private async void FilterButton_Click(object sender, EventArgs e)
        {
            
            if (FilterSettingsCbox.SelectedIndex == 0)
            {
                if(DayComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Incomplete data. Make sure to enter complete data.", "Incomplete Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    catch(Exception ex)
                    {
                        MessageBox.Show($"An error occured. {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                catch(Exception ex)
                {
                    MessageBox.Show($"An error occured. {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // Filters Reports by Month (Monthly Reports)
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
            catch
            {
                MessageBox.Show("Something went wrong. Please contact your administrator.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // Exports Daily Reports.
        private void ExportDaily(string month, string day, string year)
        {
            try
            {
                Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\PCHS Finance\\Reports");
                string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\PCHS Finance\\Reports\\Daily Collection Report.xlsx";

                IXLWorkbook wb;
                IXLWorksheet ws;

                if (!File.Exists(path))
                {
                    wb = new XLWorkbook();
                    ws = wb.Worksheets.Add($"{month} - {day} - {year}");
                }
                else
                {
                    wb = new XLWorkbook(path);
                    ws = wb.Worksheet($"{month} - {day} - {year}");
                }

                #region Title
                // Title
                ws.Cell("A1").Value = $"Daily Collection Report {month} - {day} - {year}";
                ws.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Cell("A1").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                ws.Cell("A1").Style.Fill.SetBackgroundColor(XLColor.FromHtml("#7EA0D6"));
                ws.Cell("A1").Style.Font.SetFontColor(XLColor.FromHtml("#F2F4F5"));
                ws.Cell("A1").Style.Font.SetFontSize(16);
                ws.Range("A1:G1").Merge();
                #endregion

                #region Columns

                ws.Range("A2:G2").Style.Fill.SetBackgroundColor(XLColor.FromHtml("#2F75B5"));
                ws.Range("A2:G2").Style.Font.SetFontColor(XLColor.FromHtml("#F2F4F5"));
                ws.Range("A2:G2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Range("A2:G2").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                ws.Cell("A2").Value = "Transaction ID";
                ws.Cell("B2").Value = "Student ID";
                ws.Cell("C2").Value = "Type";
                ws.Cell("D2").Value = "Amount";
                ws.Cell("E2").Value = "Reference";
                ws.Cell("F2").Value = "Term";
                ws.Cell("G2").Value = "Date Recorded";

                int currIndex = 3;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    ws.Cell($"A{currIndex}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    ws.Cell($"A{currIndex}").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                    ws.Cell($"B{currIndex}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    ws.Cell($"B{currIndex}").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                    ws.Cell($"A{currIndex}").Value = dataGridView1.Rows[i].Cells[0].Value; // transaction id
                    ws.Cell($"B{currIndex}").Value = dataGridView1.Rows[i].Cells[1].Value; // student id
                    ws.Cell($"C{currIndex}").Value = dataGridView1.Rows[i].Cells[2].Value; // type
                    ws.Cell($"D{currIndex}").Value = dataGridView1.Rows[i].Cells[3].Value; // amount
                    ws.Cell($"E{currIndex}").Value = dataGridView1.Rows[i].Cells[4].Value; // receipt #
                    ws.Cell($"F{currIndex}").Value = dataGridView1.Rows[i].Cells[5].Value; // term
                    ws.Cell($"G{currIndex}").Value = dataGridView1.Rows[i].Cells[6].Value; // date recorded
                    currIndex = currIndex + 1;
                }

                #endregion

                wb.SaveAs(path);
                MessageBox.Show($"File saved at {path}", "XLSX Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("An error occured.\n" + ex.Message, "XLSX Export Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Exports Monthly Reports.
        private void ExportMonthly(string month, string year)
        {
            Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\PCHS Finance\\Reports");
            string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\PCHS Finance\\Reports\\Monthly Collection Report.xlsx";

            IXLWorkbook wb;
            IXLWorksheet ws;

            if (!File.Exists(path))
            {
                wb = new XLWorkbook();
                ws = wb.Worksheets.Add($"{month} - {year}");
            }
            else
            {
                wb = new XLWorkbook(path);
                ws = wb.Worksheet($"{month} - {year}");
            }

            #region Title
            // Title
            ws.Cell("A1").Value = $"Monthly Collection Report {month} - {year}";
            ws.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            ws.Cell("A1").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            ws.Cell("A1").Style.Fill.SetBackgroundColor(XLColor.FromHtml("#7EA0D6"));
            ws.Cell("A1").Style.Font.SetFontColor(XLColor.FromHtml("#F2F4F5"));
            ws.Cell("A1").Style.Font.SetFontSize(16);
            ws.Range("A1:G1").Merge();
            #endregion

            #region Columns

            ws.Range("A2:G2").Style.Fill.SetBackgroundColor(XLColor.FromHtml("#2F75B5"));
            ws.Range("A2:G2").Style.Font.SetFontColor(XLColor.FromHtml("#F2F4F5"));
            ws.Range("A2:G2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            ws.Range("A2:G2").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            ws.Cell("A2").Value = "Transaction ID";
            ws.Cell("B2").Value = "Student ID";
            ws.Cell("C2").Value = "Type";
            ws.Cell("D2").Value = "Amount";
            ws.Cell("E2").Value = "Reference";
            ws.Cell("F2").Value = "Term";
            ws.Cell("G2").Value = "Date Recorded";

            int currIndex = 3;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                ws.Cell($"A{currIndex}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Cell($"A{currIndex}").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                ws.Cell($"B{currIndex}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Cell($"B{currIndex}").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                ws.Cell($"A{currIndex}").Value = dataGridView1.Rows[i].Cells[0].Value; // transaction id
                ws.Cell($"B{currIndex}").Value = dataGridView1.Rows[i].Cells[1].Value; // student id
                ws.Cell($"C{currIndex}").Value = dataGridView1.Rows[i].Cells[2].Value; // type
                ws.Cell($"D{currIndex}").Value = dataGridView1.Rows[i].Cells[3].Value; // amount
                ws.Cell($"E{currIndex}").Value = dataGridView1.Rows[i].Cells[4].Value; // receipt #
                ws.Cell($"F{currIndex}").Value = dataGridView1.Rows[i].Cells[5].Value; // term
                ws.Cell($"G{currIndex}").Value = dataGridView1.Rows[i].Cells[6].Value; // date recorded
                currIndex = currIndex + 1;
            }

            #endregion

            wb.SaveAs(path);
            MessageBox.Show($"File saved at {path}", "XLSX Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
