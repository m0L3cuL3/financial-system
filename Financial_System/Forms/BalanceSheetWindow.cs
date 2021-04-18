using Financial_System.Features;
using Financial_System.Utils;
using System;
using System.Windows.Forms;
using IronXL;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using ClosedXML.Excel;
using System.Drawing;

namespace Financial_System.Forms
{
    public partial class BalanceSheetWindow : Form
    {
        UIHandler ui = new UIHandler();
        GetTotalResult gtr = new GetTotalResult();

        // Month & Year
        private string month;
        private string year;

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

        public BalanceSheetWindow(string month, string year)
        {
            InitializeComponent();
            ui.RoundWindow(this);

            this.month = month;
            this.year = year;
            MonthYearLabel.Text = $"{month} - {year}";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            TotalAsset = 0;
            TotalLiabilityEquity = 0;
            Close();
        }

        private void TopBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            ui.DragWindow(Handle, e);
        }

        // Add Current Assets
        private async void AddCurrAsset_Btn_Click(object sender, EventArgs e)
        {
            if(CurrAssetDesc_txtBox.Text == "" || CurrAssetAmount_txtBox.Text == "")
            {
                // do nothing if null. or do something idk.
            }
            else
            {
                CurrAsset_DGV.Rows.Add(CurrAssetDesc_txtBox.Text, CurrAssetAmount_txtBox.Text); // add to row
                CurrentAssetAmount = await gtr.GetTotal(CurrAsset_DGV, 1); // stores total current assets
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
        private async void AddFixedAsset_Btn_Click(object sender, EventArgs e)
        {
            if (FixedAssetDesc_txtBox.Text == "" || FixedAssetAmount_txtBox.Text == "")
            {
                // do nothing if null. or do something idk.
            }
            else
            {
                FixedAsset_DGV.Rows.Add(FixedAssetDesc_txtBox.Text, FixedAssetAmount_txtBox.Text); // add to row
                FixedAssetAmount = await gtr.GetTotal(FixedAsset_DGV, 1); // stores total fixed assets
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
        private async void AddCurrLiability_Btn_Click(object sender, EventArgs e)
        {
            if (CurrLiabilityDesc_txtBox.Text == "" || CurrLiabilityAmount_txtBox.Text == "")
            {
                // do nothing if null. or do something idk.
            }
            else
            {
                CurrLiability_DGV.Rows.Add(CurrLiabilityDesc_txtBox.Text, CurrLiabilityAmount_txtBox.Text); // add to row
                CurrentLiabilityAmount = await gtr.GetTotal(CurrLiability_DGV, 1); // stores total current liabilities
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
        private async void AddNonCurrLiability_Btn_Click(object sender, EventArgs e)
        {
            if (NonCurrLiabilityDesc_txtBox.Text == "" || NonCurrLiabilityAmount_txtBox.Text == "")
            {
                // do nothing if null. or do something idk.
            }
            else
            {
                NonCurrLiability_DGV.Rows.Add(NonCurrLiabilityDesc_txtBox.Text, NonCurrLiabilityAmount_txtBox.Text); // add to row
                NonCurrentLiabilityAmount = await gtr.GetTotal(NonCurrLiability_DGV, 1); // stores total current liabilities
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
        private async void AddEquity_Btn_Click(object sender, EventArgs e)
        {
            if (EquityDesc_txtBox.Text == "" || EquityAmount_txtBox.Text == "")
            {
                // do nothing if null. or do something idk.
            }
            else
            {
                Equity_DGV.Rows.Add(EquityDesc_txtBox.Text, EquityAmount_txtBox.Text); // add to row
                TotalEquityAmount = await gtr.GetTotal(Equity_DGV, 1); // stores total current liabilities
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
            Export();
        }

        // Export to Excel
        private void Export()
        {
            try
            {
                Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\PCHS Finance\\Financial Statements");
                string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\PCHS Finance\\Financial Statements\\Balance Sheet {month} - {year}.xlsx";

                if (File.Exists(path))
                {
                    MessageBox.Show($"File already exists at {path}", "XLSX Export Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    IXLWorkbook wb = new XLWorkbook();
                    IXLWorksheet ws = wb.Worksheets.Add($"{month} - {year}");

                    ws.Cell("A1").Value = $"Balance Sheet {month} - {year}";
                    ws.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    ws.Cell("A1").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    ws.Range("A1:B1").Merge();

                    #region Current Assets

                    ws.Cell("A2").Value = "Current Assets";
                    ws.Cell("A2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    ws.Cell("A2").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    ws.Cell("A2").Style.Fill.BackgroundColor = XLColor.FromArgb(126, 160, 214);
                    ws.Cell("A2").Style.Font.FontColor = XLColor.FromArgb(242, 244, 245);
                    ws.Range("A2:B2").Merge();

                    ws.Cell("A3").Value = "Description";
                    ws.Cell("B3").Value = "Amount";
                    ws.Cell("A3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    ws.Cell("A3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    ws.Cell("B3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    ws.Cell("B3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    ws.Cell("A3").Style.Fill.BackgroundColor = XLColor.FromArgb(47, 117, 188);
                    ws.Cell("A3").Style.Font.FontColor = XLColor.FromArgb(242, 244, 245);
                    ws.Cell("B3").Style.Fill.BackgroundColor = XLColor.FromArgb(47, 117, 188);
                    ws.Cell("B3").Style.Font.FontColor = XLColor.FromArgb(242, 244, 245);

                    int currAssetIndex = 4;
                    for (int i = 0; i < CurrAsset_DGV.Rows.Count; i++)
                    {

                        ws.Cell($"A{currAssetIndex}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        ws.Cell($"A{currAssetIndex}").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        ws.Cell($"B{currAssetIndex}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        ws.Cell($"B{currAssetIndex}").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                        ws.Cell($"A{currAssetIndex}").Value = CurrAsset_DGV.Rows[i].Cells[0].Value; // description;
                        ws.Cell($"B{currAssetIndex}").Value = Convert.ToInt32(CurrAsset_DGV.Rows[i].Cells[1].Value); // amount

                        currAssetIndex = currAssetIndex + 1;
                    }

                    ws.Column(1).AdjustToContents();
                    ws.Column(2).AdjustToContents();

                    #endregion

                    #region Fixed Assets

                    ws.Cell("D2").Value = "Fixed Assets";
                    ws.Cell("D2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    ws.Cell("D2").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    ws.Cell("D2").Style.Fill.BackgroundColor = XLColor.FromArgb(126, 160, 214);
                    ws.Cell("D2").Style.Font.FontColor = XLColor.FromArgb(242, 244, 245);
                    ws.Range("D2:E2").Merge();

                    ws.Cell("D3").Value = "Description";
                    ws.Cell("E3").Value = "Amount";

                    ws.Cell("D3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    ws.Cell("D3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    ws.Cell("E3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    ws.Cell("E3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                    ws.Cell("D3").Style.Fill.BackgroundColor = XLColor.FromArgb(47, 117, 188);
                    ws.Cell("D3").Style.Font.FontColor = XLColor.FromArgb(242, 244, 245);
                    ws.Cell("E3").Style.Fill.BackgroundColor = XLColor.FromArgb(47, 117, 188);
                    ws.Cell("E3").Style.Font.FontColor = XLColor.FromArgb(242, 244, 245);

                    int fixedAssetIndex = 4;
                    for (int i = 0; i < FixedAsset_DGV.Rows.Count; i++)
                    {

                        ws.Cell($"D{fixedAssetIndex}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        ws.Cell($"D{fixedAssetIndex}").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        ws.Cell($"E{fixedAssetIndex}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        ws.Cell($"E{fixedAssetIndex}").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                        ws.Cell($"D{fixedAssetIndex}").Value = FixedAsset_DGV.Rows[i].Cells[0].Value; // description;
                        ws.Cell($"E{fixedAssetIndex}").Value = Convert.ToInt32(FixedAsset_DGV.Rows[i].Cells[1].Value); // amount

                        fixedAssetIndex = fixedAssetIndex + 1;
                    }

                    ws.Column(4).AdjustToContents();
                    ws.Column(5).AdjustToContents();

                    #endregion

                    #region Current Liabilities

                    ws.Cell("G2").Value = "Current Liabilities";
                    ws.Cell("G2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    ws.Cell("G2").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    ws.Cell("G2").Style.Fill.BackgroundColor = XLColor.FromArgb(126, 160, 214);
                    ws.Cell("G2").Style.Font.FontColor = XLColor.FromArgb(242, 244, 245);
                    ws.Range("G2:H2").Merge();

                    ws.Cell("G3").Value = "Description";
                    ws.Cell("H3").Value = "Amount";

                    ws.Cell("G3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    ws.Cell("G3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    ws.Cell("H3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    ws.Cell("H3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                    ws.Cell("G3").Style.Fill.BackgroundColor = XLColor.FromArgb(47, 117, 188);
                    ws.Cell("G3").Style.Font.FontColor = XLColor.FromArgb(242, 244, 245);
                    ws.Cell("H3").Style.Fill.BackgroundColor = XLColor.FromArgb(47, 117, 188);
                    ws.Cell("H3").Style.Font.FontColor = XLColor.FromArgb(242, 244, 245);

                    int currLiabilityIndex = 4;
                    for (int i = 0; i < CurrLiability_DGV.Rows.Count; i++)
                    {

                        ws.Cell($"G{currLiabilityIndex}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        ws.Cell($"G{currLiabilityIndex}").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        ws.Cell($"H{currLiabilityIndex}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        ws.Cell($"H{currLiabilityIndex}").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                        ws.Cell($"G{currLiabilityIndex}").Value = CurrLiability_DGV.Rows[i].Cells[0].Value; // description;
                        ws.Cell($"H{currLiabilityIndex}").Value = Convert.ToInt32(CurrLiability_DGV.Rows[i].Cells[1].Value); // amount

                        currLiabilityIndex = currLiabilityIndex + 1;
                    }

                    ws.Column(7).AdjustToContents();
                    ws.Column(8).AdjustToContents();

                    #endregion

                    #region Non-Current Liabilities

                    ws.Cell("J2").Value = "Non-Current Liabilities";
                    ws.Cell("J2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    ws.Cell("J2").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    ws.Cell("J2").Style.Fill.BackgroundColor = XLColor.FromArgb(126, 160, 214);
                    ws.Cell("J2").Style.Font.FontColor = XLColor.FromArgb(242, 244, 245);
                    ws.Range("J2:K2").Merge();

                    ws.Cell("J3").Value = "Description";
                    ws.Cell("K3").Value = "Amount";

                    ws.Cell("J3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    ws.Cell("J3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    ws.Cell("K3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    ws.Cell("K3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                    ws.Cell("J3").Style.Fill.BackgroundColor = XLColor.FromArgb(47, 117, 188);
                    ws.Cell("J3").Style.Font.FontColor = XLColor.FromArgb(242, 244, 245);
                    ws.Cell("K3").Style.Fill.BackgroundColor = XLColor.FromArgb(47, 117, 188);
                    ws.Cell("K3").Style.Font.FontColor = XLColor.FromArgb(242, 244, 245);

                    int NonCurrLiabilityIndex = 4;
                    for (int i = 0; i < NonCurrLiability_DGV.Rows.Count; i++)
                    {

                        ws.Cell($"J{NonCurrLiabilityIndex}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        ws.Cell($"J{NonCurrLiabilityIndex}").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        ws.Cell($"K{NonCurrLiabilityIndex}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        ws.Cell($"K{NonCurrLiabilityIndex}").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                        ws.Cell($"J{NonCurrLiabilityIndex}").Value = NonCurrLiability_DGV.Rows[i].Cells[0].Value; // description;
                        ws.Cell($"K{NonCurrLiabilityIndex}").Value = Convert.ToInt32(NonCurrLiability_DGV.Rows[i].Cells[1].Value); // amount

                        NonCurrLiabilityIndex = NonCurrLiabilityIndex + 1;
                    }

                    ws.Column(10).AdjustToContents();
                    ws.Column(11).AdjustToContents();

                    #endregion

                    #region Equity

                    ws.Cell("M2").Value = "Equity";
                    ws.Cell("M2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    ws.Cell("M2").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    ws.Cell("M2").Style.Fill.BackgroundColor = XLColor.FromArgb(126, 160, 214);
                    ws.Cell("M2").Style.Font.FontColor = XLColor.FromArgb(242, 244, 245);
                    ws.Range("M2:N2").Merge();

                    ws.Cell("M3").Value = "Description";
                    ws.Cell("N3").Value = "Amount";

                    ws.Cell("M3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    ws.Cell("M3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    ws.Cell("N3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    ws.Cell("N3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                    ws.Cell("M3").Style.Fill.BackgroundColor = XLColor.FromArgb(47, 117, 188);
                    ws.Cell("M3").Style.Font.FontColor = XLColor.FromArgb(242, 244, 245);
                    ws.Cell("N3").Style.Fill.BackgroundColor = XLColor.FromArgb(47, 117, 188);
                    ws.Cell("N3").Style.Font.FontColor = XLColor.FromArgb(242, 244, 245);

                    int TotalEquityIndex = 4;
                    for (int i = 0; i < Equity_DGV.Rows.Count; i++)
                    {

                        ws.Cell($"M{TotalEquityIndex}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        ws.Cell($"M{TotalEquityIndex}").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        ws.Cell($"N{TotalEquityIndex}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        ws.Cell($"N{TotalEquityIndex}").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                        ws.Cell($"M{TotalEquityIndex}").Value = Equity_DGV.Rows[i].Cells[0].Value; // description;
                        ws.Cell($"N{TotalEquityIndex}").Value = Convert.ToInt32(Equity_DGV.Rows[i].Cells[1].Value); // amount

                        TotalEquityIndex = TotalEquityIndex + 1;
                    }

                    ws.Column(13).AdjustToContents();
                    ws.Column(14).AdjustToContents();

                    #endregion

                    #region Total

                    ws.Cell("P2").Value = "Total Assets";
                    ws.Cell("P2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    ws.Cell("P2").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    ws.Cell("P2").Style.Fill.SetBackgroundColor(XLColor.FromHtml("#002C74"));
                    ws.Cell("P2").Style.Font.SetFontColor(XLColor.FromHtml("#F2F4F5"));
                    ws.Range("P2:Q2").Merge();

                    ws.Cell("P3").Value = TotalAsset;
                    ws.Cell("P3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    ws.Cell("P3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    ws.Cell("P3").Style.Font.Bold = true;
                    ws.Range("P3:Q3").Merge();

                    ws.Cell("P4").Value = "Total Liabilities and Equity";
                    ws.Cell("P4").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    ws.Cell("P4").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    ws.Cell("P4").Style.Fill.SetBackgroundColor(XLColor.FromHtml("#002C74"));
                    ws.Cell("P4").Style.Font.SetFontColor(XLColor.FromHtml("#F2F4F5"));
                    ws.Range("P4:Q4").Merge();

                    ws.Cell("P5").Value = TotalAsset;
                    ws.Cell("P5").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    ws.Cell("P5").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    ws.Cell("P5").Style.Font.Bold = true;
                    ws.Range("P5:Q5").Merge();

                    ws.Column(16).AdjustToContents();
                    ws.Column(17).AdjustToContents();

                    #endregion

                    wb.SaveAs(path);
                    MessageBox.Show($"File saved at {path}", "XLSX Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
            }
            catch
            {
                MessageBox.Show("Something went wrong. Please contact your administrator.", "XLSX Export Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }

}
