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
    public partial class IncomeStatementWindow : Form
    {
        UIHandler ui = new UIHandler();
        FinanceFunctions ff = new FinanceFunctions();

        public IncomeStatementWindow()
        {
            InitializeComponent();

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
    }
}
