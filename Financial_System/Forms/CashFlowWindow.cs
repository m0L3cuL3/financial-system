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

            ui.RoundWindow(this);
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

        private void ExportToExcel()
        {
            Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\PCHS Finance\\Financial Statements");
            string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\PCHS Finance\\Financial Statements\\Cash Flow Statement.xlsx";

            WorkBook wb;


            if (!File.Exists(path))
            {
                wb = WorkBook.Create(ExcelFileFormat.XLSX);
                wb.Metadata.Author = "PCHS";
            }
            else
            {
                wb = WorkBook.Load(path);
            }

            WorkSheet xlsSheet = wb.CreateWorkSheet($"{month} - {year}");
            WorkSheet getWs = wb.GetWorkSheet($"{month} - {year}");

            xlsSheet.Merge("A1:B1");
            xlsSheet["A1:B1"].Value = "PCHS Cash Flow";
            xlsSheet["A1:B1"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
            xlsSheet["A1:B1"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
            xlsSheet["A1:B1"].Style.SetBackgroundColor("#7EA0D6");
            xlsSheet["A1:B1"].Style.Font.SetColor("#F2F4F5");
            xlsSheet["A1:B1"].Style.Font.Height = 16;

            #region Operating Cash Flow

            xlsSheet.Merge("A2:B2");
            xlsSheet["A2:B2"].Value = "Operating Cash Flow";
            xlsSheet["A2:B2"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
            xlsSheet["A2:B2"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
            xlsSheet["A2:B2"].Style.SetBackgroundColor("#7EA0D6");
            xlsSheet["A2:B2"].Style.Font.SetColor("#F2F4F5");

            xlsSheet["A3:B3"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
            xlsSheet["A3:B3"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
            xlsSheet["A3:B3"].Style.SetBackgroundColor("#2F75B5");
            xlsSheet["A3:B3"].Style.Font.SetColor("#F2F4F5");
            xlsSheet["A3"].Value = "Description";
            xlsSheet["B3"].Value = "Amount";

            int currIndex = 4;
            for (int i = 0; i < AddC_DGV.Rows.Count; i++)
            {
                if (Convert.ToInt32(AddC_DGV.Rows[i].Cells[1].Value) != 0)
                {
                    xlsSheet[$"A{currIndex}"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
                    xlsSheet[$"B{currIndex}"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;

                    xlsSheet[$"A{currIndex}"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                    xlsSheet[$"B{currIndex}"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;

                    xlsSheet[$"A{currIndex}"].Value = AddC_DGV.Rows[i].Cells[0].Value; // description
                    xlsSheet[$"B{currIndex}"].Value = Convert.ToInt32(AddC_DGV.Rows[i].Cells[1].Value); // amount
                    currIndex = currIndex + 1;
                }
            }

            for (int i = 0; i < SubC_DGV.Rows.Count; i++)
            {
                if (Convert.ToInt32(SubC_DGV.Rows[i].Cells[1].Value) != 0)
                {
                    xlsSheet[$"A{currIndex}"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
                    xlsSheet[$"B{currIndex}"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;

                    xlsSheet[$"A{currIndex}"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                    xlsSheet[$"B{currIndex}"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;

                    xlsSheet[$"A{currIndex}"].Value = SubC_DGV.Rows[i].Cells[0].Value; // description
                    xlsSheet[$"B{currIndex}"].Value = Convert.ToInt32(SubC_DGV.Rows[i].Cells[1].Value) * -1; // amount
                    currIndex = currIndex + 1;
                }
            }

            #endregion

            #region Investing Cash Flow

            //TODO: ICF

            #endregion

            #region Financing Cash Flow
            
            //TODO: FCF

            #endregion

            wb.SaveAs(path);
            MessageBox.Show($"File saved at {path}", "XLSX Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
