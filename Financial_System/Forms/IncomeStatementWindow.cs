using Financial_System.Features;
using Financial_System.Utils;
using IronXL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            ExportToExcel();
        }

        private void ExportToExcel()
        {
            try
            {
                Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\PCHS Finance\\Financial Statements");
                string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\PCHS Finance\\Financial Statements\\Income Statement.xlsx";

                WorkBook wb;
                WorkSheet xlsSheet;

                if (!File.Exists(path))
                {
                    wb = WorkBook.Create(ExcelFileFormat.XLSX);
                    wb.Metadata.Author = "PCHS";
                }
                else
                {
                    wb = WorkBook.Load(path);
                }

                xlsSheet = wb.CreateWorkSheet($"{month} - {year}");

                xlsSheet.Merge("A1:E1");
                xlsSheet["A1:E1"].Value = $"Income Statement";
                xlsSheet["A1:E1"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
                xlsSheet["A1:E1"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                xlsSheet["A1:E1"].Style.SetBackgroundColor("#2F75B5");
                xlsSheet["A1:E1"].Style.Font.SetColor("#F2F4F5");
                xlsSheet["A1:E1"].Style.TopBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["A1:E1"].Style.LeftBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["A1:E1"].Style.RightBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["A1:E1"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["A1:E1"].Style.Font.Height = 16;

                xlsSheet["A2:B2"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
                xlsSheet["A2:B2"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                xlsSheet["A2:B2"].Style.SetBackgroundColor("#7EA0D6");
                xlsSheet["A2:B2"].Style.Font.SetColor("#F2F4F5");
                xlsSheet["A2:B2"].Style.TopBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["A2:B2"].Style.LeftBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["A2:B2"].Style.RightBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["A2:B2"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["A2"].Value = "Period";
                xlsSheet["B2"].Value = $"{year}";

                #region Gross Profit

                xlsSheet.Merge("D2:E2");
                xlsSheet["D2:E2"].Value = $"Gross Profit";
                xlsSheet["D2:E2"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
                xlsSheet["D2:E2"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                xlsSheet["D2:E2"].Style.SetBackgroundColor("#002C74");
                xlsSheet["D2:E2"].Style.Font.SetColor("#F2F4F5");
                xlsSheet["D2:E2"].Style.TopBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["D2:E2"].Style.LeftBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["D2:E2"].Style.RightBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["D2:E2"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Thin;

                xlsSheet.Merge("D3:E3");
                xlsSheet["D3:E3"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
                xlsSheet["D3:E3"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                xlsSheet["D3:E3"].Style.SetBackgroundColor("#2F75B5");
                xlsSheet["D3:E3"].Style.Font.SetColor("#F2F4F5");
                xlsSheet["D3:E3"].Style.TopBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["D3:E3"].Style.LeftBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["D3:E3"].Style.RightBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["D3:E3"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["D3:E3"].Value = Convert.ToDecimal(TotalGrossProfit_Lbl.Text);

                #endregion

                #region Operating Income

                xlsSheet.Merge("D4:E4");
                xlsSheet["D4:E4"].Value = $"Operating Income";
                xlsSheet["D4:E4"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
                xlsSheet["D4:E4"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                xlsSheet["D4:E4"].Style.SetBackgroundColor("#002C74");
                xlsSheet["D4:E4"].Style.Font.SetColor("#F2F4F5");
                xlsSheet["D4:E4"].Style.TopBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["D4:E4"].Style.LeftBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["D4:E4"].Style.RightBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["D4:E4"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Thin;

                xlsSheet.Merge("D5:E5");
                xlsSheet["D5:E5"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
                xlsSheet["D5:E5"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                xlsSheet["D5:E5"].Style.SetBackgroundColor("#2F75B5");
                xlsSheet["D5:E5"].Style.Font.SetColor("#F2F4F5");
                xlsSheet["D5:E5"].Style.TopBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["D5:E5"].Style.LeftBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["D5:E5"].Style.RightBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["D5:E5"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["D5:E5"].Value = Convert.ToDecimal(TotalOperatingIncome_Lbl.Text);

                #endregion

                #region Net Income

                xlsSheet.Merge("D6:E6");
                xlsSheet["D6:E6"].Value = $"Net Income";
                xlsSheet["D6:E6"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
                xlsSheet["D6:E6"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                xlsSheet["D6:E6"].Style.SetBackgroundColor("#002C74");
                xlsSheet["D6:E6"].Style.Font.SetColor("#F2F4F5");
                xlsSheet["D6:E6"].Style.TopBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["D6:E6"].Style.LeftBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["D6:E6"].Style.RightBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["D6:E6"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Thin;

                xlsSheet.Merge("D7:E7");
                xlsSheet["D7:E7"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
                xlsSheet["D7:E7"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                xlsSheet["D7:E7"].Style.SetBackgroundColor("#2F75B5");
                xlsSheet["D7:E7"].Style.Font.SetColor("#F2F4F5");
                xlsSheet["D7:E7"].Style.TopBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["D7:E7"].Style.LeftBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["D7:E7"].Style.RightBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["D7:E7"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["D7:E7"].Value = Convert.ToDecimal(TotalNetIncome_Lbl.Text);

                #endregion

                xlsSheet["A3:A11"].Style.SetBackgroundColor("#2F75B5");
                xlsSheet["A3:A11"].Style.Font.SetColor("#F2F4F5");
                xlsSheet["A3:A11"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
                xlsSheet["A3:A11"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                xlsSheet["A3:A11"].Style.TopBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["A3:A11"].Style.LeftBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["A3:A11"].Style.RightBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["A3:A11"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Thin;

                xlsSheet["B3:B11"].Style.SetBackgroundColor("#2F75B5");
                xlsSheet["B3:B11"].Style.Font.SetColor("#F2F4F5");
                xlsSheet["B3:B11"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
                xlsSheet["B3:B11"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                xlsSheet["B3:B11"].Style.TopBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["B3:B11"].Style.LeftBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["B3:B11"].Style.RightBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["B3:B11"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Thin;

                xlsSheet["A3"].Value = "Revenue";
                xlsSheet["A4"].Value = "Cost of Goods Sold";
                xlsSheet["A5"].Value = "Research and Development";
                xlsSheet["A6"].Value = "Sales, General & Admin";
                xlsSheet["A7"].Value = "Additional Income/Expense";
                xlsSheet["A8"].Value = "Earnings Before Interest & Tax";
                xlsSheet["A9"].Value = "Interest Expense";
                xlsSheet["A10"].Value = "Earning Before Tax";
                xlsSheet["A11"].Value = "Income Tax";

                xlsSheet["B3"].Value = Convert.ToDecimal(Revenue_txtBox.Text);
                xlsSheet["B4"].Value = Convert.ToDecimal(Cgs_txtBox.Text);
                xlsSheet["B5"].Value = Convert.ToDecimal(RnD_txtBox.Text);
                xlsSheet["B6"].Value = Convert.ToDecimal(Sga_txtBox.Text);
                xlsSheet["B7"].Value = Convert.ToDecimal(AddInEx_txtBox.Text);
                xlsSheet["B8"].Value = Convert.ToDecimal(Ebit_txtBox.Text);
                xlsSheet["B9"].Value = Convert.ToDecimal(IntExp_Lbl.Text);
                xlsSheet["B10"].Value = Convert.ToDecimal(Ebt_txtBox.Text);
                xlsSheet["B11"].Value = Convert.ToDecimal(InTax_txtBox.Text);

                wb.SaveAs(path);
                MessageBox.Show($"File saved at {path}", "XLSX Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show($"{month} - {year} already exists! Please contact your administrator.", "Duplicate worksheets.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
