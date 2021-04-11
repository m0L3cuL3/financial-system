using Financial_System.Features;
using Financial_System.Utils;
using System;
using System.Windows.Forms;
using IronXL;
using System.Linq;

namespace Financial_System.Forms
{
    public partial class BalanceSheetWindow : Form
    {
        UIHandler ui = new UIHandler();
        GetTotalResult gtr = new GetTotalResult();

        // Asset Amount
        private static decimal TotalAsset = 0;
        private static decimal CurrentAssetAmount = 0;
        private static decimal FixedAssetAmount = 0;

        // Liability Amount
        private static decimal TotalLiability = 0;
        private static decimal CurrentLiabilityAmount = 0;
        private static decimal NonCurrentLiabilityAmount = 0;

        // Equity Amount
        private static decimal TotalEquityAmount = 0;

        // Liability and Equity
        private static decimal TotalLiabilityEquity = 0;

        public BalanceSheetWindow()
        {
            InitializeComponent();
            ui.RoundWindow(this);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TopBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            ui.DragWindow(Handle, e);
        }

        // Add Current Assets
        private void AddCurrAsset_Btn_Click(object sender, EventArgs e)
        {
            if(CurrAssetDesc_txtBox.Text == "" || CurrAssetAmount_txtBox.Text == "")
            {
                // do nothing if null. or do something idk.
            }
            else
            {
                CurrAsset_DGV.Rows.Add(CurrAssetDesc_txtBox.Text, CurrAssetAmount_txtBox.Text); // add to row
                CurrentAssetAmount = gtr.GetTotal(CurrAsset_DGV); // stores total current assets
                TotalCurrAssets_Lbl.Text = $"Total Current Assets: {CurrentAssetAmount}"; // get total current assets
                
                // CLEAR TEXTBOX
                CurrAssetDesc_txtBox.Text = "";
                CurrAssetAmount_txtBox.Text = "";

                // Add Current and Fixed Assets
                TotalAsset = CurrentAssetAmount + FixedAssetAmount;
                TotalAssets_Lbl.Text = $"Total Assets: {TotalAsset}";

                // Check if overall is balance
                gtr.IsBalanced(IsBalanced_Lbl, TotalAsset, TotalLiabilityEquity);
            }  
        }

        // Add Fixed Assets
        private void AddFixedAsset_Btn_Click(object sender, EventArgs e)
        {
            if (FixedAssetDesc_txtBox.Text == "" || FixedAssetAmount_txtBox.Text == "")
            {
                // do nothing if null. or do something idk.
            }
            else
            {
                FixedAsset_DGV.Rows.Add(FixedAssetDesc_txtBox.Text, FixedAssetAmount_txtBox.Text); // add to row
                FixedAssetAmount = gtr.GetTotal(FixedAsset_DGV); // stores total fixed assets
                TotalFixedAssets_Lbl.Text = $"Total Fixed Assets: {FixedAssetAmount}"; // get total fixed assets

                // CLEAR TEXTBOX
                FixedAssetDesc_txtBox.Text = "";
                FixedAssetAmount_txtBox.Text = "";

                // Add Current and Fixed Assets
                TotalAsset = CurrentAssetAmount + FixedAssetAmount;
                TotalAssets_Lbl.Text = $"Total Assets: {TotalAsset}";

                // Check if overall is balance
                gtr.IsBalanced(IsBalanced_Lbl, TotalAsset, TotalLiabilityEquity);
            }
        }

        // Add Current Liabilities
        private void AddCurrLiability_Btn_Click(object sender, EventArgs e)
        {
            if (CurrLiabilityDesc_txtBox.Text == "" || CurrLiabilityAmount_txtBox.Text == "")
            {
                // do nothing if null. or do something idk.
            }
            else
            {
                CurrLiability_DGV.Rows.Add(CurrLiabilityDesc_txtBox.Text, CurrLiabilityAmount_txtBox.Text); // add to row
                CurrentLiabilityAmount = gtr.GetTotal(CurrLiability_DGV); // stores total current liabilities
                TotalCurrLiability_Lbl.Text = $"Total Current Liabilities: {CurrentLiabilityAmount}"; // get total current liabilities

                // CLEAR TEXTBOX
                CurrLiabilityDesc_txtBox.Text = "";
                CurrLiabilityAmount_txtBox.Text = "";

                // Add Current and Non-Current Liabilities
                TotalLiability = CurrentLiabilityAmount + NonCurrentLiabilityAmount;
                TotalLiabilityEquity = TotalLiability + TotalEquityAmount;
                TotalLiabilityEquity_Lbl.Text = $"Total Liabilities and Equity: {TotalLiabilityEquity}";

                // Check if overall is balance
                gtr.IsBalanced(IsBalanced_Lbl, TotalAsset, TotalLiabilityEquity);
            }
        }

        // Add Non-Current Liabilities
        private void AddNonCurrLiability_Btn_Click(object sender, EventArgs e)
        {
            if (NonCurrLiabilityDesc_txtBox.Text == "" || NonCurrLiabilityAmount_txtBox.Text == "")
            {
                // do nothing if null. or do something idk.
            }
            else
            {
                NonCurrLiability_DGV.Rows.Add(NonCurrLiabilityDesc_txtBox.Text, NonCurrLiabilityAmount_txtBox.Text); // add to row
                NonCurrentLiabilityAmount = gtr.GetTotal(NonCurrLiability_DGV); // stores total current liabilities
                TotalNonCurrLiability_Lbl.Text = $"Total Non-Current Liabilities: {NonCurrentLiabilityAmount}"; // get total current liabilities

                // CLEAR TEXTBOX
                NonCurrLiabilityDesc_txtBox.Text = "";
                NonCurrLiabilityAmount_txtBox.Text = "";

                // Add Current and Non-Current Liabilities
                TotalLiability = CurrentLiabilityAmount + NonCurrentLiabilityAmount;
                TotalLiabilityEquity = TotalLiability + TotalEquityAmount;
                TotalLiabilityEquity_Lbl.Text = $"Total Liabilities and Equity: {TotalLiabilityEquity}";

                // Check if overall is balance
                gtr.IsBalanced(IsBalanced_Lbl, TotalAsset, TotalLiabilityEquity);
            }
        }

        // Add Equity
        private void AddEquity_Btn_Click(object sender, EventArgs e)
        {
            if (EquityDesc_txtBox.Text == "" || EquityAmount_txtBox.Text == "")
            {
                // do nothing if null. or do something idk.
            }
            else
            {
                Equity_DGV.Rows.Add(EquityDesc_txtBox.Text, EquityAmount_txtBox.Text); // add to row
                TotalEquityAmount = gtr.GetTotal(Equity_DGV); // stores total current liabilities
                TotalEquity_Lbl.Text = $"Total Equity: {TotalEquityAmount}"; // get total current liabilities

                // CLEAR TEXTBOX
                EquityDesc_txtBox.Text = "";
                EquityAmount_txtBox.Text = "";

                // Add Current and Non-Current Liabilities
                TotalLiability = CurrentLiabilityAmount + NonCurrentLiabilityAmount;
                TotalLiabilityEquity = TotalLiability + TotalEquityAmount;
                TotalLiabilityEquity_Lbl.Text = $"Total Liabilities and Equity: {TotalLiabilityEquity}";

                // Check if overall is balance
                gtr.IsBalanced(IsBalanced_Lbl, TotalAsset, TotalLiabilityEquity);
            }
        }

        // Export to Excel on click
        private void ExportToPdf_Btn_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        // Export to Excel
        private void ExportToExcel()
        {

            WorkBook wb = WorkBook.Create(ExcelFileFormat.XLSX);
            wb.Metadata.Author = "PCHS";

            WorkSheet xlsSheet = wb.CreateWorkSheet("Balance Sheet");
            WorkSheet getWs = wb.GetWorkSheet("Balance Sheet");

            int RowCount = getWs.Rows.Count() + 1;

            #region Current Assets
            // Current Assets
            xlsSheet.Merge("A1:B1");
            xlsSheet["A1:B1"].Value = "Current Assets";
            xlsSheet["A1:B1"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
            xlsSheet["A1:B1"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
            xlsSheet["A1:B1"].Style.SetBackgroundColor("#7EA0D6");
            xlsSheet["A1:B1"].Style.Font.SetColor("#F2F4F5");

            xlsSheet["A2:B2"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
            xlsSheet["A2:B2"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
            xlsSheet["A2:B2"].Style.SetBackgroundColor("#2F75B5");
            xlsSheet["A2:B2"].Style.Font.SetColor("#F2F4F5");
            xlsSheet["A2"].Value = "Description";
            xlsSheet["B2"].Value = "Amount";

            int currAssetIndex = 3;
            for (int i = 0; i < CurrAsset_DGV.Rows.Count; i++)
            {

                xlsSheet[$"A{currAssetIndex}"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
                xlsSheet[$"B{currAssetIndex}"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;

                xlsSheet[$"A{currAssetIndex}"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                xlsSheet[$"B{currAssetIndex}"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;

                xlsSheet[$"A{currAssetIndex}"].Value = CurrAsset_DGV.Rows[i].Cells[0].Value; // description
                xlsSheet[$"B{currAssetIndex}"].Value = Convert.ToInt32(CurrAsset_DGV.Rows[i].Cells[1].Value); // amount
                currAssetIndex = currAssetIndex + 1;
            }           

            getWs[$"B{RowCount}"].Style.Font.Bold = true;
            getWs[$"B{RowCount}"].Value = CurrentAssetAmount;

            #endregion

            #region Fixed Assets

            // Fixed Assets
            xlsSheet.Merge($"D1:E1");
            xlsSheet["D1:E1"].Value = "Fixed Assets";
            xlsSheet["D1:E1"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
            xlsSheet["D1:E1"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
            xlsSheet["D1:E1"].Style.SetBackgroundColor("#7EA0D6");
            xlsSheet["D1:E1"].Style.Font.SetColor("#F2F4F5");

            xlsSheet["D2:E2"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
            xlsSheet["D2:E2"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
            xlsSheet["D2:E2"].Style.SetBackgroundColor("#2F75B5");
            xlsSheet["D2:E2"].Style.Font.SetColor("#F2F4F5");
            xlsSheet["D2"].Value = "Description";
            xlsSheet["E2"].Value = "Amount";

            int fixedAssetIndex = 3;
            for (int i = 0; i < FixedAsset_DGV.Rows.Count; i++)
            {

                xlsSheet[$"D{fixedAssetIndex}"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
                xlsSheet[$"E{fixedAssetIndex}"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;

                xlsSheet[$"D{fixedAssetIndex}"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                xlsSheet[$"E{fixedAssetIndex}"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;

                xlsSheet[$"D{fixedAssetIndex}"].Value = FixedAsset_DGV.Rows[i].Cells[0].Value; // description
                xlsSheet[$"E{fixedAssetIndex}"].Value = Convert.ToInt32(FixedAsset_DGV.Rows[i].Cells[1].Value); // amount
                fixedAssetIndex = fixedAssetIndex + 1;
            }

            getWs[$"E{RowCount}"].Style.Font.Bold = true;
            getWs[$"E{RowCount}"].Value = FixedAssetAmount;

            #endregion

            #region Current Liabilities

            // Current Liabilities
            xlsSheet.Merge($"G1:H1");
            xlsSheet["G1:H1"].Value = "Current Liabilities";
            xlsSheet["G1:H1"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
            xlsSheet["G1:H1"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
            xlsSheet["G1:H1"].Style.SetBackgroundColor("#7EA0D6");
            xlsSheet["G1:H1"].Style.Font.SetColor("#F2F4F5");

            xlsSheet["G2:H2"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
            xlsSheet["G2:H2"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
            xlsSheet["G2:H2"].Style.SetBackgroundColor("#2F75B5");
            xlsSheet["G2:H2"].Style.Font.SetColor("#F2F4F5");
            xlsSheet["G2"].Value = "Description";
            xlsSheet["H2"].Value = "Amount";

            int currLiabilityIndex = 3;
            for (int i = 0; i < CurrLiability_DGV.Rows.Count; i++)
            {

                xlsSheet[$"G{currLiabilityIndex}"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
                xlsSheet[$"H{currLiabilityIndex}"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;

                xlsSheet[$"G{currLiabilityIndex}"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                xlsSheet[$"H{currLiabilityIndex}"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;

                xlsSheet[$"G{currLiabilityIndex}"].Value = CurrLiability_DGV.Rows[i].Cells[0].Value; // description
                xlsSheet[$"H{currLiabilityIndex}"].Value = Convert.ToInt32(CurrLiability_DGV.Rows[i].Cells[1].Value); // amount
                currLiabilityIndex = currLiabilityIndex + 1;
            }

            getWs[$"H{RowCount}"].Style.Font.Bold = true;
            getWs[$"H{RowCount}"].Value = CurrentLiabilityAmount;

            #endregion

            #region Non-Current Liabilities

            // Current Liabilities
            xlsSheet.Merge($"J1:K1");
            xlsSheet["J1:K1"].Value = "Non-Current Liabilities";
            xlsSheet["J1:K1"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
            xlsSheet["J1:K1"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
            xlsSheet["J1:K1"].Style.SetBackgroundColor("#7EA0D6");
            xlsSheet["J1:K1"].Style.Font.SetColor("#F2F4F5");

            xlsSheet["J2:K2"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
            xlsSheet["J2:K2"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
            xlsSheet["J2:K2"].Style.SetBackgroundColor("#2F75B5");
            xlsSheet["J2:K2"].Style.Font.SetColor("#F2F4F5");
            xlsSheet["J2"].Value = "Description";
            xlsSheet["K2"].Value = "Amount";

            int NonCurrLiabilityIndex = 3;
            for (int i = 0; i < NonCurrLiability_DGV.Rows.Count; i++)
            {

                xlsSheet[$"J{NonCurrLiabilityIndex}"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
                xlsSheet[$"K{NonCurrLiabilityIndex}"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;

                xlsSheet[$"J{NonCurrLiabilityIndex}"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                xlsSheet[$"K{NonCurrLiabilityIndex}"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;

                xlsSheet[$"J{NonCurrLiabilityIndex}"].Value = NonCurrLiability_DGV.Rows[i].Cells[0].Value; // description
                xlsSheet[$"K{NonCurrLiabilityIndex}"].Value = Convert.ToInt32(NonCurrLiability_DGV.Rows[i].Cells[1].Value); // amount
                NonCurrLiabilityIndex = NonCurrLiabilityIndex + 1;
            }

            getWs[$"K{RowCount}"].Style.Font.Bold = true;
            getWs[$"K{RowCount}"].Value = NonCurrentLiabilityAmount;

            #endregion

            #region Equity

            // Equity
            xlsSheet.Merge($"M1:N1");
            xlsSheet["M1:N1"].Value = "Equity";
            xlsSheet["M1:N1"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
            xlsSheet["M1:N1"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
            xlsSheet["M1:N1"].Style.SetBackgroundColor("#7EA0D6");
            xlsSheet["M1:N1"].Style.Font.SetColor("#F2F4F5");

            xlsSheet["M2:N2"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
            xlsSheet["M2:N2"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
            xlsSheet["M2:N2"].Style.SetBackgroundColor("#2F75B5");
            xlsSheet["M2:N2"].Style.Font.SetColor("#F2F4F5");
            xlsSheet["M2"].Value = "Description";
            xlsSheet["N2"].Value = "Amount";

            int TotalEquityIndex = 3;
            for (int i = 0; i < Equity_DGV.Rows.Count; i++)
            {

                xlsSheet[$"M{TotalEquityIndex}"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
                xlsSheet[$"N{TotalEquityIndex}"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;

                xlsSheet[$"M{TotalEquityIndex}"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                xlsSheet[$"N{TotalEquityIndex}"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;

                xlsSheet[$"M{TotalEquityIndex}"].Value = Equity_DGV.Rows[i].Cells[0].Value; // description
                xlsSheet[$"N{TotalEquityIndex}"].Value = Convert.ToInt32(Equity_DGV.Rows[i].Cells[1].Value); // amount
                
                TotalEquityIndex = TotalEquityIndex + 1;
            }

            getWs[$"N{RowCount}"].Style.Font.Bold = true;
            getWs[$"N{RowCount}"].Value = TotalEquityAmount;

            #endregion

            #region Total
            // Total Assets
            getWs.Merge("P1:Q1");
            getWs["P1:Q1"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
            getWs["P1:Q1"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
            getWs["P1:Q1"].Style.SetBackgroundColor("#002C74");
            getWs["P1:Q1"].Style.Font.SetColor("#F2F4F5");
            getWs["P1:Q1"].Value = "Total Assets";
            getWs.Merge("P2:Q2");
            getWs["P2:Q2"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
            getWs["P2:Q2"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
            getWs["P2:Q2"].Style.Font.Bold = true;
            getWs["P2:Q2"].Value = TotalAsset;

            // Total Liability and Equity
            getWs.Merge("P3:Q3");
            getWs["P3:Q3"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
            getWs["P3:Q3"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
            getWs["P3:Q3"].Style.SetBackgroundColor("#002C74");
            getWs["P3:Q3"].Style.Font.SetColor("#F2F4F5");
            getWs["P3:Q3"].Value = "Total Liabilities and Equity";
            getWs.Merge("P4:Q4");
            getWs["P4:Q4"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
            getWs["P4:Q4"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
            getWs["P4:Q4"].Style.Font.Bold = true;
            getWs["P4:Q4"].Value = TotalLiabilityEquity;
            #endregion

            // Save the excel file -> make this so that the user can choose a filepath.
            ///
            /// If you create a file as a regular user in C: drive
            /// It will throw an UnauthorizedAccessException.
            /// Either login as admin or save the file in another drive.
            ///
            

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"C:\";      
            saveFileDialog.Title = "Save Excel Sheet";
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.DefaultExt = "xlsx";
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;
                wb.SaveAs(filename);
            }
        }
    }

}
