using Financial_System.Features;
using Financial_System.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public CashFlowWindow()
        {
            InitializeComponent();
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
    }
}
