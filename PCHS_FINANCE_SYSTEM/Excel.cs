using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronXL;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace PCHS_FINANCE_SYSTEM
{
    

    enum Storage
    {
        //DRIVE_C, --> Will cause UnauthorizedAccessException if used.
        DRIVE_D,
        DRIVE_E,
        DRIVE_F,
        DRIVE_G,
        DRIVE_O,
        DRIVE_P,
    }

    interface IExcel
    {
        void CreateNewWorkbook(string filename);
    }

    class Excel : IExcel
    {

        public void CreateNewWorkbook(string filename)
        {
            WorkBook wb = WorkBook.Create(ExcelFileFormat.XLSX);
            wb.Metadata.Author = "PCHS";

            #region Workbook Sheets
            WorkSheet wsGeneralLedger = wb.CreateWorkSheet("General Ledger");
            #endregion


            #region Workbook Header
            wsGeneralLedger.Merge("A1:F1");
            wsGeneralLedger["A1:F1"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
            wsGeneralLedger["A1:F1"].Value = "PCHS General Ledger";
            wsGeneralLedger["A1:F1"].Style.Font.SetColor("#F0F0F0");
            wsGeneralLedger["A1:F1"].Style.SetBackgroundColor("#125EA5");
            //wsGeneralLedger["A1:F1"].Style.TopBorder.SetColor("#ff6600");
            //wsGeneralLedger["A1:F1"].Style.TopBorder.Type = IronXL.Styles.BorderType.Double;
            #endregion

            #region Workbook Column
            wsGeneralLedger["A2:F2"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
            wsGeneralLedger["A2:F2"].Style.ShrinkToFit = true;

            wsGeneralLedger["A2"].Value = "Date";
            wsGeneralLedger["A2"].Style.Font.SetColor("#F0F0F0");
            wsGeneralLedger["A2"].Style.SetBackgroundColor("#125EA5");
            wsGeneralLedger["A2"].Style.BottomBorder.SetColor("#ff6600");
            wsGeneralLedger["A2"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Double;
            wsGeneralLedger["A2"].Style.TopBorder.SetColor("#ff6600");
            wsGeneralLedger["A2"].Style.TopBorder.Type = IronXL.Styles.BorderType.Double;

            wsGeneralLedger["B2"].Value = "Journal Entry #";
            wsGeneralLedger["B2"].Style.Font.SetColor("#F0F0F0");
            wsGeneralLedger["B2"].Style.SetBackgroundColor("#125EA5");
            wsGeneralLedger["B2"].Style.BottomBorder.SetColor("#ff6600");
            wsGeneralLedger["B2"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Double;
            wsGeneralLedger["B2"].Style.TopBorder.SetColor("#ff6600");
            wsGeneralLedger["B2"].Style.TopBorder.Type = IronXL.Styles.BorderType.Double;

            wsGeneralLedger["C2"].Value = "Description";
            wsGeneralLedger["C2"].Style.Font.SetColor("#F0F0F0");
            wsGeneralLedger["C2"].Style.SetBackgroundColor("#125EA5");
            wsGeneralLedger["C2"].Style.BottomBorder.SetColor("#ff6600");
            wsGeneralLedger["C2"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Double;
            wsGeneralLedger["C2"].Style.TopBorder.SetColor("#ff6600");
            wsGeneralLedger["C2"].Style.TopBorder.Type = IronXL.Styles.BorderType.Double;

            wsGeneralLedger["D2"].Value = "Debit";
            wsGeneralLedger["D2"].Style.Font.SetColor("#F0F0F0");
            wsGeneralLedger["D2"].Style.SetBackgroundColor("#125EA5");
            wsGeneralLedger["D2"].Style.BottomBorder.SetColor("#ff6600");
            wsGeneralLedger["D2"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Double;
            wsGeneralLedger["D2"].Style.TopBorder.SetColor("#ff6600");
            wsGeneralLedger["D2"].Style.TopBorder.Type = IronXL.Styles.BorderType.Double;

            wsGeneralLedger["E2"].Value = "Credit";
            wsGeneralLedger["E2"].Style.Font.SetColor("#F0F0F0");
            wsGeneralLedger["E2"].Style.SetBackgroundColor("#125EA5");
            wsGeneralLedger["E2"].Style.BottomBorder.SetColor("#ff6600");
            wsGeneralLedger["E2"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Double;
            wsGeneralLedger["E2"].Style.TopBorder.SetColor("#ff6600");
            wsGeneralLedger["E2"].Style.TopBorder.Type = IronXL.Styles.BorderType.Double;

            wsGeneralLedger["F2"].Value = "Balance";
            wsGeneralLedger["F2"].Style.Font.SetColor("#F0F0F0");
            wsGeneralLedger["F2"].Style.SetBackgroundColor("#125EA5");
            wsGeneralLedger["F2"].Style.BottomBorder.SetColor("#ff6600");
            wsGeneralLedger["F2"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Double;
            wsGeneralLedger["F2"].Style.TopBorder.SetColor("#ff6600");
            wsGeneralLedger["F2"].Style.TopBorder.Type = IronXL.Styles.BorderType.Double;

            #endregion

            if (Directory.Exists(@".\Workbooks"))
            {
                wb.SaveAs($@".\Workbooks\{filename}.xlsx");
                MessageBox.Show("File Created!");
            }
            else
            {
                string path = Directory.GetCurrentDirectory();
                DialogResult dr = MessageBox.Show($@"{path} directory does not exists! \n\nDo you want me to create a directory?", "Directory Does Not Exist!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Directory.CreateDirectory(@".\Workbooks");
                    wb.SaveAs($@".\Workbooks\{filename}.xlsx");
                    MessageBox.Show($@"Directory and {filename}.xlsx Created!");
                }
                else
                {
                    // do nothing
                }
            }
            
        }

        public bool CheckFileExists(string filename)
        {
            if (File.Exists(filename))
            {
                return true;
            }
            return false;
        }
    }
}
