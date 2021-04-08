using Financial_System.Features;
using Financial_System.Utils;
using System;
using System.Windows.Forms;

namespace Financial_System.Forms
{
    public partial class BalanceSheetWindow : Form
    {
        UIHandler ui = new UIHandler();
        GetTotalResult gtr = new GetTotalResult();

        // Asset Amount
        decimal TotalAsset = 0;
        decimal CurrentAssetAmount = 0;
        decimal FixedAssetAmount = 0;

        // Liability Amount
        decimal TotalLiability = 0;
        decimal CurrentLiabilityAmount = 0;
        decimal NonCurrentLiabilityAmount = 0;

        // Equity Amount
        decimal TotalEquityAmount = 0;

        // Liability and Equity
        decimal TotalLiabilityEquity = 0;


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
    }
}
