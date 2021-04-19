using ClosedXML.Excel;
using Financial_System.Features;
using Financial_System.Utils;
using System;
using System.IO;

using System.Windows.Forms;

namespace Financial_System.Forms
{
    public partial class CashFlowWindow : Form
    {
        GetTotalResult gtr = new GetTotalResult();
        FinanceFunctions ff = new FinanceFunctions();
        UIHandler ui = new UIHandler();

        string month;
        string year;

        public CashFlowWindow(string month, string year)
        {
            InitializeComponent();

            this.month = month;
            this.year = year;

            MonthYearLabel.Text = $"{month} - {year}";

            // UIHandler
            ui.RoundWindow(this);
            ui.RoundButton(ExportToExcel_Btn);
            ui.RoundButton(CalcOCF_Btn);
            ui.RoundButton(CalcICF_Btn);
            ui.RoundButton(CalcFCF_Btn);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void TopBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            ui.DragWindow(Handle, e);
        }

        // Calculate OCF
        private void CalcOCF_Btn_Click(object sender, EventArgs e)
        {
            CalcOCF();
        }

        // Calculate ICF
        private void CalcICF_Btn_Click(object sender, EventArgs e)
        {
            CalcICF();
        }


        // Calculate FCF
        private void CalcFCF_Btn_Click(object sender, EventArgs e)
        {
            CalcFCF();
        }

        private void LockComboBox_CheckedChanged(object sender, EventArgs e)
        {
            switch (LockCheckBox.Checked)
            {
                case true:
                    NetEarnings_txtBox.Enabled = false;
                    break;
                case false:
                    NetEarnings_txtBox.Enabled = true;
                    break;
            }
        }
                
        private async void CalcOCF()
        {
            try
            {
                if (NetEarnings_txtBox.Text == "")
                {
                    MessageBox.Show("Please enter Net Earnings.", "Incomplete data.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    decimal total = await ff.CalcOCF(NetEarnings_txtBox, AddC_DGV, SubC_DGV);

                    TotalOCF_Lbl.Text = total.ToString();

                    CalcCashFlow();
                }
            }
            catch
            {
                MessageBox.Show("Please enter number only.", "Invalid data type.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CalcICF()
        {
            try
            {
                if (NetEarnings_txtBox.Text == "")
                {
                    MessageBox.Show("Please enter Net Earnings.", "Incomplete data.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    decimal total = await gtr.GetTotal(CFI_DGV, 1);
                    TotalICF_Lbl.Text = total.ToString();

                    CalcCashFlow();
                }
            }
            catch
            {
                MessageBox.Show("Please enter number only.", "Invalid data type.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private async void CalcFCF()
        {
            try
            {
                if (NetEarnings_txtBox.Text == "")
                {
                    MessageBox.Show("Please enter Net Earnings.", "Incomplete data.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    decimal total = await gtr.GetTotal(FCF_DGV, 1);

                    TotalFCF_Lbl.Text = total.ToString();

                    CalcCashFlow();
                }
            }
            catch
            {
                MessageBox.Show("Please enter number only.", "Invalid data type.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CalcCashFlow()
        {
            try
            {
                if (NetEarnings_txtBox.Text == "")
                {
                    MessageBox.Show("Please enter Net Earnings.", "Incomplete data.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    decimal totalOCF = await ff.CalcOCF(NetEarnings_txtBox, AddC_DGV, SubC_DGV);
                    decimal totalICF = await ff.CalcICF(CFI_DGV, totalOCF);
                    decimal totalFCF = await ff.CalcFCF(FCF_DGV, totalICF);

                    TotalCashFlow_Lbl.Text = totalFCF.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Please enter number only.", "Invalid data type.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToExcel_Btn_Click(object sender, EventArgs e)
        {
            Export();
        }

        private async void Export()
        {
            try
            {
                Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\PCHS Finance\\Financial Statements");
                string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\PCHS Finance\\Financial Statements\\Cash Flow Statement.xlsx";

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
                    ws = wb.Worksheets.Add($"{month} - {year}");
                    ws = wb.Worksheet($"{month} - {year}");
                }

                #region Title
                // Title
                ws.Cell("A1").Value = $"Cash Flow {month} - {year}";
                ws.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Cell("A1").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                ws.Cell("A1").Style.Fill.SetBackgroundColor(XLColor.FromHtml("#2F75B5"));
                ws.Cell("A1").Style.Font.SetFontColor(XLColor.FromHtml("#F2F4F5"));
                ws.Cell("A1").Style.Font.SetFontSize(16);
                ws.Range("A1:H1").Merge();
                #endregion

                #region Operating Cash Flow (OCF)

                ws.Range("A2:B3").Style.Border.SetBottomBorder(XLBorderStyleValues.Thin);
                ws.Range("A2:B3").Style.Border.SetTopBorder(XLBorderStyleValues.Thin);
                ws.Range("A2:B3").Style.Border.SetLeftBorder(XLBorderStyleValues.Thin);
                ws.Range("A2:B3").Style.Border.SetRightBorder(XLBorderStyleValues.Thin);

                ws.Cell("A2").Value = "Operating Cash Flow";
                ws.Range("A2:B2").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                ws.Range("A2:B2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Range("A2:B2").Style.Fill.SetBackgroundColor(XLColor.FromHtml("#7EA0D6"));
                ws.Range("A2:B2").Style.Font.SetFontColor(XLColor.FromHtml("#F2F4F5"));
                ws.Range("A2:B2").Merge();

                ws.Cell("A3").Value = "Description";
                ws.Cell("B3").Value = "Amount";
                ws.Range("A3:B3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                ws.Range("A3:B3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Range("A3:B3").Style.Fill.SetBackgroundColor(XLColor.FromHtml("#2F75B5"));
                ws.Range("A3:B3").Style.Font.SetFontColor(XLColor.FromHtml("#F2F4F5"));

                int currAddSubIndex = 4;
                for (int i = 0; i < AddC_DGV.Rows.Count; i++)
                {
                    if (Convert.ToInt32(AddC_DGV.Rows[i].Cells[1].Value) != 0)
                    {
                        ws.Range($"A{currAddSubIndex}:B{currAddSubIndex}").Style.Border.SetBottomBorder(XLBorderStyleValues.Thin);
                        ws.Range($"A{currAddSubIndex}:B{currAddSubIndex}").Style.Border.SetTopBorder(XLBorderStyleValues.Thin);
                        ws.Range($"A{currAddSubIndex}:B{currAddSubIndex}").Style.Border.SetLeftBorder(XLBorderStyleValues.Thin);
                        ws.Range($"A{currAddSubIndex}:B{currAddSubIndex}").Style.Border.SetRightBorder(XLBorderStyleValues.Thin);

                        ws.Range($"A{currAddSubIndex}:B{currAddSubIndex}").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        ws.Range($"A{currAddSubIndex}:B{currAddSubIndex}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        ws.Range($"A{currAddSubIndex}:B{currAddSubIndex}").Style.Fill.SetBackgroundColor(XLColor.FromHtml("#5A9AD4"));

                        ws.Cell($"A{currAddSubIndex}").Value = AddC_DGV.Rows[i].Cells[0].Value; // description
                        ws.Cell($"B{currAddSubIndex}").Value = Convert.ToInt32(AddC_DGV.Rows[i].Cells[1].Value); // amount
                        currAddSubIndex = currAddSubIndex + 1;
                    }
                }

                for (int i = 0; i < SubC_DGV.Rows.Count; i++)
                {
                    if (Convert.ToInt32(SubC_DGV.Rows[i].Cells[1].Value) != 0)
                    {
                        ws.Range($"A{currAddSubIndex}:B{currAddSubIndex}").Style.Border.SetBottomBorder(XLBorderStyleValues.Thin);
                        ws.Range($"A{currAddSubIndex}:B{currAddSubIndex}").Style.Border.SetTopBorder(XLBorderStyleValues.Thin);
                        ws.Range($"A{currAddSubIndex}:B{currAddSubIndex}").Style.Border.SetLeftBorder(XLBorderStyleValues.Thin);
                        ws.Range($"A{currAddSubIndex}:B{currAddSubIndex}").Style.Border.SetRightBorder(XLBorderStyleValues.Thin);

                        ws.Range($"A{currAddSubIndex}:B{currAddSubIndex}").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        ws.Range($"A{currAddSubIndex}:B{currAddSubIndex}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        ws.Range($"A{currAddSubIndex}:B{currAddSubIndex}").Style.Fill.SetBackgroundColor(XLColor.FromHtml("#5A9AD4"));

                        ws.Cell($"A{currAddSubIndex}").Value = SubC_DGV.Rows[i].Cells[0].Value; // description
                        ws.Cell($"B{currAddSubIndex}").Value = Convert.ToInt32(SubC_DGV.Rows[i].Cells[1].Value); // amount
                        currAddSubIndex = currAddSubIndex + 1;
                    }
                }

                #endregion

                #region Investing Cash Flow (ICF)

                ws.Range("D2:E3").Style.Border.SetBottomBorder(XLBorderStyleValues.Thin);
                ws.Range("D2:E3").Style.Border.SetTopBorder(XLBorderStyleValues.Thin);
                ws.Range("D2:E3").Style.Border.SetLeftBorder(XLBorderStyleValues.Thin);
                ws.Range("D2:E3").Style.Border.SetRightBorder(XLBorderStyleValues.Thin);

                ws.Cell("D2").Value = "Investing Cash Flow";
                ws.Range("D2:E2").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                ws.Range("D2:E2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Range("D2:E2").Style.Fill.SetBackgroundColor(XLColor.FromHtml("#7EA0D6"));
                ws.Range("D2:E2").Style.Font.SetFontColor(XLColor.FromHtml("#F2F4F5"));
                ws.Range("D2:E2").Merge();

                ws.Cell("D3").Value = "Description";
                ws.Cell("E3").Value = "Amount";
                ws.Range("D3:E3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                ws.Range("D3:E3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Range("D3:E3").Style.Fill.SetBackgroundColor(XLColor.FromHtml("#2F75B5"));
                ws.Range("D3:E3").Style.Font.SetFontColor(XLColor.FromHtml("#F2F4F5"));

                int currICFIndex = 4;
                for (int i = 0; i < CFI_DGV.Rows.Count; i++)
                {
                    if (Convert.ToInt32(CFI_DGV.Rows[i].Cells[1].Value) != 0)
                    {
                        ws.Range($"D{currICFIndex}:E{currICFIndex}").Style.Border.SetBottomBorder(XLBorderStyleValues.Thin);
                        ws.Range($"D{currICFIndex}:E{currICFIndex}").Style.Border.SetTopBorder(XLBorderStyleValues.Thin);
                        ws.Range($"D{currICFIndex}:E{currICFIndex}").Style.Border.SetLeftBorder(XLBorderStyleValues.Thin);
                        ws.Range($"D{currICFIndex}:E{currICFIndex}").Style.Border.SetRightBorder(XLBorderStyleValues.Thin);

                        ws.Range($"D{currICFIndex}:E{currICFIndex}").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        ws.Range($"D{currICFIndex}:E{currICFIndex}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        ws.Range($"D{currICFIndex}:E{currICFIndex}").Style.Fill.SetBackgroundColor(XLColor.FromHtml("#5A9AD4"));

                        ws.Cell($"D{currICFIndex}").Value = CFI_DGV.Rows[i].Cells[0].Value; // description
                        ws.Cell($"E{currICFIndex}").Value = Convert.ToInt32(CFI_DGV.Rows[i].Cells[1].Value); // amount
                        currICFIndex = currICFIndex + 1;
                    }
                }

                #endregion

                #region Financing Cash Flow (FCF)

                ws.Range("G2:H3").Style.Border.SetBottomBorder(XLBorderStyleValues.Thin);
                ws.Range("G2:H3").Style.Border.SetTopBorder(XLBorderStyleValues.Thin);
                ws.Range("G2:H3").Style.Border.SetLeftBorder(XLBorderStyleValues.Thin);
                ws.Range("G2:H3").Style.Border.SetRightBorder(XLBorderStyleValues.Thin);

                ws.Cell("G2").Value = "Financing Cash Flow";
                ws.Range("G2:H2").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                ws.Range("G2:H2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Range("G2:H2").Style.Fill.SetBackgroundColor(XLColor.FromHtml("#7EA0D6"));
                ws.Range("G2:H2").Style.Font.SetFontColor(XLColor.FromHtml("#F2F4F5"));
                ws.Range("G2:H2").Merge();

                ws.Cell("G3").Value = "Description";
                ws.Cell("H3").Value = "Amount";
                ws.Range("G3:H3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                ws.Range("G3:H3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Range("G3:H3").Style.Fill.SetBackgroundColor(XLColor.FromHtml("#2F75B5"));
                ws.Range("G3:H3").Style.Font.SetFontColor(XLColor.FromHtml("#F2F4F5"));

                int currFCFIndex = 4;
                for (int i = 0; i < FCF_DGV.Rows.Count; i++)
                {
                    if (Convert.ToInt32(FCF_DGV.Rows[i].Cells[1].Value) != 0)
                    {
                        ws.Range($"G{currFCFIndex}:H{currFCFIndex}").Style.Border.SetBottomBorder(XLBorderStyleValues.Thin);
                        ws.Range($"G{currFCFIndex}:H{currFCFIndex}").Style.Border.SetTopBorder(XLBorderStyleValues.Thin);
                        ws.Range($"G{currFCFIndex}:H{currFCFIndex}").Style.Border.SetLeftBorder(XLBorderStyleValues.Thin);
                        ws.Range($"G{currFCFIndex}:H{currFCFIndex}").Style.Border.SetRightBorder(XLBorderStyleValues.Thin);

                        ws.Range($"G{currFCFIndex}:H{currFCFIndex}").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        ws.Range($"G{currFCFIndex}:H{currFCFIndex}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        ws.Range($"G{currFCFIndex}:H{currFCFIndex}").Style.Fill.SetBackgroundColor(XLColor.FromHtml("#5A9AD4"));

                        ws.Cell($"G{currFCFIndex}").Value = FCF_DGV.Rows[i].Cells[0].Value; // description
                        ws.Cell($"H{currFCFIndex}").Value = Convert.ToInt32(FCF_DGV.Rows[i].Cells[1].Value); // amount
                        currFCFIndex = currFCFIndex + 1;
                    }
                }

                #endregion

                #region Total Cash Flow

                // Net Earnings
                ws.Cell("J2").Value = "Net Earnings";
                ws.Range("J2:K2").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                ws.Range("J2:K2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Range("J2:K2").Style.Fill.SetBackgroundColor(XLColor.FromHtml("#002C74"));
                ws.Range("J2:K2").Style.Font.SetFontColor(XLColor.FromHtml("#F2F4F5"));
                ws.Range("J2:K2").Merge();

                ws.Cell("J3").Value = Convert.ToDecimal(NetEarnings_txtBox.Text);
                ws.Range("J3:K3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                ws.Range("J3:K3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Range("J3:K3").Style.Fill.SetBackgroundColor(XLColor.FromHtml("#2F75B5"));
                ws.Range("J3:K3").Style.Font.SetFontColor(XLColor.FromHtml("#F2F4F5"));
                ws.Range("J3:K3").Merge();

                // Total Cash Flow
                ws.Cell("J4").Value = "Total Cash Flow";
                ws.Range("J4:K4").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                ws.Range("J4:K4").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Range("J4:K4").Style.Fill.SetBackgroundColor(XLColor.FromHtml("#002C74"));
                ws.Range("J4:K4").Style.Font.SetFontColor(XLColor.FromHtml("#F2F4F5"));
                ws.Range("J4:K4").Merge();

                decimal totalOCF = await ff.CalcOCF(NetEarnings_txtBox, AddC_DGV, SubC_DGV);
                decimal totalICF = await ff.CalcICF(CFI_DGV, totalOCF);
                decimal totalFCF = await ff.CalcFCF(FCF_DGV, totalICF);

                ws.Cell("J5").Value = totalFCF;
                ws.Range("J5:K5").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                ws.Range("J5:K5").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Range("J5:K5").Style.Fill.SetBackgroundColor(XLColor.FromHtml("#2F75B5"));
                ws.Range("J5:K5").Style.Font.SetFontColor(XLColor.FromHtml("#F2F4F5"));
                ws.Range("J5:K5").Merge();

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
