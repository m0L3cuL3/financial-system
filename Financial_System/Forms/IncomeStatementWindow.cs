using Financial_System.Features;
using Financial_System.Utils;
using System;
using System.IO;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace Financial_System.Forms
{
    public partial class IncomeStatementWindow : Form
    {
        UIHandler ui = new UIHandler();
        FinanceFunctions ff = new FinanceFunctions();

        string month;
        string year;

        public IncomeStatementWindow(string month, string year)
        {
            InitializeComponent();

            this.month = month;
            this.year = year;

            ui.RoundWindow(this);
            ui.RoundButton(CalcIncState_Btn);
            ui.RoundPanel(ListPanel);
            ui.RoundPanel(ListPanel2);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TopBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            ui.DragWindow(Handle, e);
        }

        #region Textbox Changed

        private void Revenue_txtBox_TextChanged(object sender, EventArgs e)
        {
            Revenue_Lbl.Text = Revenue_txtBox.Text;
        }

        private void Cgs_txtBox_TextChanged(object sender, EventArgs e)
        {
            Cgs_Lbl.Text = Cgs_txtBox.Text;
        }

        private void RnD_txtBox_TextChanged(object sender, EventArgs e)
        {
            RnD_Lbl.Text = RnD_txtBox.Text;
        }

        private void Sga_txtBox_TextChanged(object sender, EventArgs e)
        {
            Sga_Lbl.Text = Sga_txtBox.Text;
        }

        private void AddInEx_txtBox_TextChanged(object sender, EventArgs e)
        {
            AddInEx_Lbl.Text = AddInEx_txtBox.Text;
        }

        private void Ebit_txtBox_TextChanged(object sender, EventArgs e)
        {
            Ebit_Lbl.Text = Ebit_txtBox.Text;
        }

        private void IntEx_txtBox_TextChanged(object sender, EventArgs e)
        {
            IntExp_Lbl.Text = IntEx_txtBox.Text;
        }

        private void Ebt_txtBox_TextChanged(object sender, EventArgs e)
        {
            Ebt_Lbl.Text = Ebt_txtBox.Text;
        }

        private void InTax_txtBox_TextChanged(object sender, EventArgs e)
        {
            InTax_Lbl.Text = InTax_txtBox.Text;
        }


        #endregion

        private async void CalcIncState_Btn_Click(object sender, EventArgs e)
        {
            foreach(Control c in GroupBox.Controls)
            {
                if(c is TextBox)
                {
                    TextBox txtBox = c as TextBox;
                    if(txtBox.Text == string.Empty)
                    {
                        MessageBox.Show("Please fill in all the needed data.", "Incomplete data.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else
                    {
                        decimal GrossProfit = await ff.CalcGrossProfit(Convert.ToDecimal(Revenue_txtBox.Text), Convert.ToDecimal(Cgs_txtBox.Text));
                        TotalGrossProfit_Lbl.Text = $"{GrossProfit}";

                        decimal OperatingIncome = await ff.CalcOperatingIncome(GrossProfit, CalcOpEx(RnD_txtBox, Sga_txtBox));
                        TotalOperatingIncome_Lbl.Text = $"{OperatingIncome}";

                        decimal NetIncome = await ff.CalcNetIncome(OperatingIncome, CalcNonOpItems(AddInEx_txtBox, InTax_txtBox));
                        TotalNetIncome_Lbl.Text = $"{NetIncome}";
                        break;
                    }
                }
            }
        }

        // calculate operating EXPENSES.
        private decimal CalcOpEx(TextBox tb1, TextBox tb2)
        {
            decimal result = Convert.ToDecimal(tb1.Text) + Convert.ToDecimal(tb2.Text);
            return result;
        }

        // calculate non-operating items.
        private decimal CalcNonOpItems(TextBox tb1, TextBox tb2)
        {
            decimal result = Convert.ToDecimal(tb1.Text) - Convert.ToDecimal(tb2.Text);
            return result;
        }

        private void ExportToExcel_Click(object sender, EventArgs e)
        {
            Export();
        }

        private void Export()
        {
            try
            {
                Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\PCHS Finance\\Financial Statements");
                string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\PCHS Finance\\Financial Statements\\Income Statement.xlsx";

                IXLWorkbook wb;
                IXLWorksheet ws;

                if (!File.Exists(path))
                {
                    wb = new XLWorkbook();
                }
                else
                {
                    wb = new XLWorkbook(path);
                }

                ws = wb.Worksheets.Add($"{month} - {year}");

                #region Title

                // Title
                ws.Cell("A1").Value = $"Income Statement {month} - {year}";
                ws.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Cell("A1").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                ws.Cell("A1").Style.Fill.SetBackgroundColor(XLColor.FromHtml("#2F75B5"));
                ws.Cell("A1").Style.Font.SetFontColor(XLColor.FromHtml("#F2F4F5"));
                ws.Cell("A1").Style.Font.SetFontSize(16);
                ws.Range("A1:E1").Merge();

                #endregion

                #region Period & Year Columns

                // Period & Year Columns
                ws.Cell("A2").Value = "Period";
                ws.Cell("B2").Value = $"{year}";
                ws.Cell("A2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Cell("A2").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                ws.Cell("B2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Cell("B2").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                ws.Cell("A2").Style.Fill.SetBackgroundColor(XLColor.FromHtml("#7EA0D6"));
                ws.Cell("A2").Style.Font.SetFontColor(XLColor.FromHtml("#F2F4F5"));
                ws.Cell("B2").Style.Fill.SetBackgroundColor(XLColor.FromHtml("#7EA0D6"));
                ws.Cell("B2").Style.Font.SetFontColor(XLColor.FromHtml("#F2F4F5"));

                #endregion

                #region Gross Profit

                // Header
                ws.Cell("D2").Value = "Gross Profit";
                ws.Cell("D2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Cell("D2").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                ws.Cell("D2").Style.Fill.SetBackgroundColor(XLColor.FromHtml("#002C74"));
                ws.Cell("D2").Style.Font.SetFontColor(XLColor.FromHtml("#F2F4F5"));
                ws.Range("D2:E2").Merge();

                // Result
                ws.Cell("D3").Value = Convert.ToDecimal(TotalGrossProfit_Lbl.Text);
                ws.Cell("D3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Cell("D3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                ws.Cell("D3").Style.Fill.SetBackgroundColor(XLColor.FromHtml("#2F75B5"));
                ws.Cell("D3").Style.Font.SetFontColor(XLColor.FromHtml("#F2F4F5"));
                ws.Range("D3:E3").Merge();

                #endregion

                #region Operating Income

                // Header
                ws.Cell("D4").Value = "Operating Income";
                ws.Cell("D4").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Cell("D4").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                ws.Cell("D4").Style.Fill.SetBackgroundColor(XLColor.FromHtml("#002C74"));
                ws.Cell("D4").Style.Font.SetFontColor(XLColor.FromHtml("#F2F4F5"));
                ws.Range("D4:E4").Merge();

                // Result
                ws.Cell("D5").Value = Convert.ToDecimal(TotalOperatingIncome_Lbl.Text);
                ws.Cell("D5").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Cell("D5").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                ws.Cell("D5").Style.Fill.SetBackgroundColor(XLColor.FromHtml("#2F75B5"));
                ws.Cell("D5").Style.Font.SetFontColor(XLColor.FromHtml("#F2F4F5"));
                ws.Range("D5:E5").Merge();

                #endregion

                #region Net Income

                // Header
                ws.Cell("D6").Value = "Net Income";
                ws.Cell("D6").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Cell("D6").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                ws.Cell("D6").Style.Fill.SetBackgroundColor(XLColor.FromHtml("#002C74"));
                ws.Cell("D6").Style.Font.SetFontColor(XLColor.FromHtml("#F2F4F5"));
                ws.Range("D6:E6").Merge();

                // Result
                ws.Cell("D7").Value = Convert.ToDecimal(TotalNetIncome_Lbl.Text);
                ws.Cell("D7").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Cell("D7").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                ws.Cell("D7").Style.Fill.SetBackgroundColor(XLColor.FromHtml("#2F75B5"));
                ws.Cell("D7").Style.Font.SetFontColor(XLColor.FromHtml("#F2F4F5"));
                ws.Range("D7:E7").Merge();

                #endregion

                #region Column A
                ws.Cell("A3").Value = "Revenue";
                ws.Cell("A4").Value = "Cost of Goods Sold";
                ws.Cell("A5").Value = "Research and Development";
                ws.Cell("A6").Value = "Sales, General & Admin";
                ws.Cell("A7").Value = "Additional Income/Expense";
                ws.Cell("A8").Value = "Earnings Before Interest & Tax";
                ws.Cell("A9").Value = "Interest Expense";
                ws.Cell("A10").Value = "Earning Before Tax";
                ws.Cell("A11").Value = "Income Tax";
                #endregion

                #region Column B
                ws.Cell("B3").Value = Convert.ToDecimal(Revenue_txtBox.Text);
                ws.Cell("B4").Value = Convert.ToDecimal(Cgs_txtBox.Text);
                ws.Cell("B5").Value = Convert.ToDecimal(RnD_txtBox.Text);
                ws.Cell("B6").Value = Convert.ToDecimal(Sga_txtBox.Text);
                ws.Cell("B7").Value = Convert.ToDecimal(AddInEx_txtBox.Text);
                ws.Cell("B8").Value = Convert.ToDecimal(Ebit_txtBox.Text);
                ws.Cell("B9").Value = Convert.ToDecimal(IntExp_Lbl.Text);
                ws.Cell("B10").Value = Convert.ToDecimal(Ebt_txtBox.Text);
                ws.Cell("B11").Value = Convert.ToDecimal(InTax_txtBox.Text);
                #endregion

                wb.SaveAs(path);
                MessageBox.Show($"File saved at {path}", "XLSX Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("An error occured.\n" + ex.Message, "XLSX Export Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
