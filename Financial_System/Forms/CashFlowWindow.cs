using Financial_System.Features;
using Financial_System.Utils;
using IronXL;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            ExportToExcel();
        }

        private async void ExportToExcel()
        {
            try
            {
                Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\PCHS Finance\\Financial Statements");
                string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\PCHS Finance\\Financial Statements\\Cash Flow Statement.xlsx";

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

                xlsSheet.Merge("A1:H1");
                xlsSheet["A1:H1"].Value = $"Cash Flow on {month} - {year}";
                xlsSheet["A1:H1"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
                xlsSheet["A1:H1"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                xlsSheet["A1:H1"].Style.SetBackgroundColor("#2F75B5");
                xlsSheet["A1:H1"].Style.Font.SetColor("#F2F4F5");
                xlsSheet["A1:H1"].Style.TopBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["A1:H1"].Style.LeftBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["A1:H1"].Style.RightBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["A1:H1"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["A1:H1"].Style.Font.Height = 16;

                #region Operating Cash Flow

                xlsSheet.Merge("A2:B2");
                xlsSheet["A2:B2"].Value = "Operating Cash Flow";
                xlsSheet["A2:B2"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
                xlsSheet["A2:B2"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                xlsSheet["A2:B2"].Style.SetBackgroundColor("#7EA0D6");
                xlsSheet["A2:B2"].Style.Font.SetColor("#F2F4F5");
                xlsSheet["A2:B2"].Style.TopBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["A2:B2"].Style.LeftBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["A2:B2"].Style.RightBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["A2:B2"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Thin;

                xlsSheet["A3:B3"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
                xlsSheet["A3:B3"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                xlsSheet["A3:B3"].Style.SetBackgroundColor("#2F75B5");
                xlsSheet["A3:B3"].Style.Font.SetColor("#F2F4F5");
                xlsSheet["A3:B3"].Style.TopBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["A3:B3"].Style.LeftBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["A3:B3"].Style.RightBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["A3:B3"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["A3"].Value = "Description";
                xlsSheet["B3"].Value = "Amount";

                int currAddSubIndex = 4;
                for (int i = 0; i < AddC_DGV.Rows.Count; i++)
                {
                    if (Convert.ToInt32(AddC_DGV.Rows[i].Cells[1].Value) != 0)
                    {
                        xlsSheet[$"A{currAddSubIndex}"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
                        xlsSheet[$"B{currAddSubIndex}"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;

                        xlsSheet[$"A{currAddSubIndex}"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                        xlsSheet[$"B{currAddSubIndex}"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;

                        xlsSheet[$"A{currAddSubIndex}:B{currAddSubIndex}"].Style.SetBackgroundColor("#5A9AD4");
                        xlsSheet[$"A{currAddSubIndex}:B{currAddSubIndex}"].Style.TopBorder.Type = IronXL.Styles.BorderType.Thin;
                        xlsSheet[$"A{currAddSubIndex}:B{currAddSubIndex}"].Style.LeftBorder.Type = IronXL.Styles.BorderType.Thin;
                        xlsSheet[$"A{currAddSubIndex}:B{currAddSubIndex}"].Style.RightBorder.Type = IronXL.Styles.BorderType.Thin;
                        xlsSheet[$"A{currAddSubIndex}:B{currAddSubIndex}"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Thin;

                        xlsSheet[$"A{currAddSubIndex}"].Value = AddC_DGV.Rows[i].Cells[0].Value; // description
                        xlsSheet[$"B{currAddSubIndex}"].Value = Convert.ToInt32(AddC_DGV.Rows[i].Cells[1].Value); // amount
                        currAddSubIndex = currAddSubIndex + 1;
                    }
                }

                for (int i = 0; i < SubC_DGV.Rows.Count; i++)
                {
                    if (Convert.ToInt32(SubC_DGV.Rows[i].Cells[1].Value) != 0)
                    {
                        xlsSheet[$"A{currAddSubIndex}"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
                        xlsSheet[$"B{currAddSubIndex}"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;

                        xlsSheet[$"A{currAddSubIndex}"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                        xlsSheet[$"B{currAddSubIndex}"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;

                        xlsSheet[$"A{currAddSubIndex}:B{currAddSubIndex}"].Style.SetBackgroundColor("#5A9AD4");
                        xlsSheet[$"A{currAddSubIndex}:B{currAddSubIndex}"].Style.TopBorder.Type = IronXL.Styles.BorderType.Thin;
                        xlsSheet[$"A{currAddSubIndex}:B{currAddSubIndex}"].Style.LeftBorder.Type = IronXL.Styles.BorderType.Thin;
                        xlsSheet[$"A{currAddSubIndex}:B{currAddSubIndex}"].Style.RightBorder.Type = IronXL.Styles.BorderType.Thin;
                        xlsSheet[$"A{currAddSubIndex}:B{currAddSubIndex}"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Thin;

                        xlsSheet[$"A{currAddSubIndex}"].Value = SubC_DGV.Rows[i].Cells[0].Value; // description
                        xlsSheet[$"B{currAddSubIndex}"].Value = Convert.ToInt32(SubC_DGV.Rows[i].Cells[1].Value) * -1; // amount
                        currAddSubIndex = currAddSubIndex + 1;
                    }
                }

                #endregion

                #region Investing Cash Flow

                xlsSheet.Merge("D2:E2");
                xlsSheet["D2:E2"].Value = "Investing Cash Flow";
                xlsSheet["D2:E2"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
                xlsSheet["D2:E2"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                xlsSheet["D2:E2"].Style.SetBackgroundColor("#7EA0D6");
                xlsSheet["D2:E2"].Style.Font.SetColor("#F2F4F5");
                xlsSheet["D2:E2"].Style.TopBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["D2:E2"].Style.LeftBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["D2:E2"].Style.RightBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["D2:E2"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Thin;

                xlsSheet["D3:E3"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
                xlsSheet["D3:E3"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                xlsSheet["D3:E3"].Style.SetBackgroundColor("#2F75B5");
                xlsSheet["D3:E3"].Style.Font.SetColor("#F2F4F5");
                xlsSheet["D3:E3"].Style.TopBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["D3:E3"].Style.LeftBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["D3:E3"].Style.RightBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["D3:E3"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["D3"].Value = "Description";
                xlsSheet["E3"].Value = "Amount";

                int currICFIndex = 4;
                for (int i = 0; i < CFI_DGV.Rows.Count; i++)
                {
                    if (Convert.ToInt32(CFI_DGV.Rows[i].Cells[1].Value) != 0)
                    {
                        xlsSheet[$"D{currICFIndex}"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
                        xlsSheet[$"E{currICFIndex}"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;

                        xlsSheet[$"D{currICFIndex}"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                        xlsSheet[$"E{currICFIndex}"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;

                        xlsSheet[$"D{currICFIndex}:E{currICFIndex}"].Style.SetBackgroundColor("#5A9AD4");
                        xlsSheet[$"D{currICFIndex}:E{currICFIndex}"].Style.TopBorder.Type = IronXL.Styles.BorderType.Thin;
                        xlsSheet[$"D{currICFIndex}:E{currICFIndex}"].Style.LeftBorder.Type = IronXL.Styles.BorderType.Thin;
                        xlsSheet[$"D{currICFIndex}:E{currICFIndex}"].Style.RightBorder.Type = IronXL.Styles.BorderType.Thin;
                        xlsSheet[$"D{currICFIndex}:E{currICFIndex}"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Thin;

                        xlsSheet[$"D{currICFIndex}"].Value = CFI_DGV.Rows[i].Cells[0].Value; // description
                        xlsSheet[$"E{currICFIndex}"].Value = Convert.ToInt32(CFI_DGV.Rows[i].Cells[1].Value); // amount
                        currICFIndex = currICFIndex + 1;
                    }
                }

                #endregion

                #region Financing Cash Flow

                xlsSheet.Merge("G2:H2");
                xlsSheet["G2:H2"].Value = "Investing Cash Flow";
                xlsSheet["G2:H2"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
                xlsSheet["G2:H2"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                xlsSheet["G2:H2"].Style.SetBackgroundColor("#7EA0D6");
                xlsSheet["G2:H2"].Style.Font.SetColor("#F2F4F5");
                xlsSheet["G2:H2"].Style.TopBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["G2:H2"].Style.LeftBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["G2:H2"].Style.RightBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["G2:H2"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Thin;

                xlsSheet["G3:H3"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
                xlsSheet["G3:H3"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                xlsSheet["G3:H3"].Style.SetBackgroundColor("#2F75B5");
                xlsSheet["G3:H3"].Style.Font.SetColor("#F2F4F5");
                xlsSheet["G3:H3"].Style.TopBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["G3:H3"].Style.LeftBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["G3:H3"].Style.RightBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["G3:H3"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["G3"].Value = "Description";
                xlsSheet["H3"].Value = "Amount";

                int currFCFIndex = 4;
                for (int i = 0; i < FCF_DGV.Rows.Count; i++)
                {
                    if (Convert.ToInt32(FCF_DGV.Rows[i].Cells[1].Value) != 0)
                    {
                        xlsSheet[$"G{currFCFIndex}"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
                        xlsSheet[$"H{currFCFIndex}"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;

                        xlsSheet[$"G{currFCFIndex}"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                        xlsSheet[$"H{currFCFIndex}"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;

                        xlsSheet[$"G{currFCFIndex}:H{currFCFIndex}"].Style.SetBackgroundColor("#5A9AD4");
                        xlsSheet[$"G{currFCFIndex}:H{currFCFIndex}"].Style.TopBorder.Type = IronXL.Styles.BorderType.Thin;
                        xlsSheet[$"G{currFCFIndex}:H{currFCFIndex}"].Style.LeftBorder.Type = IronXL.Styles.BorderType.Thin;
                        xlsSheet[$"G{currFCFIndex}:H{currFCFIndex}"].Style.RightBorder.Type = IronXL.Styles.BorderType.Thin;
                        xlsSheet[$"G{currFCFIndex}:H{currFCFIndex}"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Thin;

                        xlsSheet[$"G{currFCFIndex}"].Value = FCF_DGV.Rows[i].Cells[0].Value; // description
                        xlsSheet[$"H{currFCFIndex}"].Value = Convert.ToInt32(FCF_DGV.Rows[i].Cells[1].Value); // amount
                        currFCFIndex = currFCFIndex + 1;
                    }
                }

                #endregion

                #region Total Cash Flow

                xlsSheet.Merge("J2:K2");
                xlsSheet["J2:K2"].Value = "Net Earnings";
                xlsSheet["J2:K2"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
                xlsSheet["J2:K2"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                xlsSheet["J2:K2"].Style.SetBackgroundColor("#002C74");
                xlsSheet["J2:K2"].Style.Font.SetColor("#F2F4F5");
                xlsSheet["J2:K2"].Style.TopBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["J2:K2"].Style.LeftBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["J2:K2"].Style.RightBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["J2:K2"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Thin;

                xlsSheet.Merge("J3:K3");
                xlsSheet["J3:K3"].Value = Convert.ToDecimal(NetEarnings_txtBox.Text);
                xlsSheet["J3:K3"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
                xlsSheet["J3:K3"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                xlsSheet["J3:K3"].Style.SetBackgroundColor("#2F75B5");
                xlsSheet["J3:K3"].Style.Font.SetColor("#F2F4F5");
                xlsSheet["J3:K3"].Style.TopBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["J3:K3"].Style.LeftBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["J3:K3"].Style.RightBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["J3:K3"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Thin;

                xlsSheet.Merge("J4:K4");
                xlsSheet["J4:K4"].Value = "Total Cash Flow";
                xlsSheet["J4:K4"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
                xlsSheet["J4:K4"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                xlsSheet["J4:K4"].Style.SetBackgroundColor("#002C74");
                xlsSheet["J4:K4"].Style.Font.SetColor("#F2F4F5");
                xlsSheet["J4:K4"].Style.TopBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["J4:K4"].Style.LeftBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["J4:K4"].Style.RightBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["J4:K4"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Thin;

                decimal totalOCF = await ff.CalcOCF(NetEarnings_txtBox, AddC_DGV, SubC_DGV);
                decimal totalICF = await ff.CalcICF(CFI_DGV, totalOCF);
                decimal totalFCF = await ff.CalcFCF(FCF_DGV, totalICF);

                xlsSheet.Merge("J5:K5");
                xlsSheet["J5:K5"].Value = totalFCF;
                xlsSheet["J5:K5"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
                xlsSheet["J5:K5"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                xlsSheet["J5:K5"].Style.SetBackgroundColor("#2F75B5");
                xlsSheet["J5:K5"].Style.Font.SetColor("#F2F4F5");
                xlsSheet["J5:K5"].Style.TopBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["J5:K5"].Style.LeftBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["J5:K5"].Style.RightBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet["J5:K5"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Thin;


                #endregion

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
