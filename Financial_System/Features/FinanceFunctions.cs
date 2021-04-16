using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financial_System.Features
{
    class FinanceFunctions
    {
        GetTotalResult gtr = new GetTotalResult();

        #region Cash Flow Statement

        public async Task<decimal> CalcOCF(TextBox txtBox, DataGridView dgv1, DataGridView dgv2)
        {
            decimal NetEarnings = Convert.ToDecimal(txtBox.Text);
            decimal AC_Total = await gtr.GetTotal(dgv1, 1); // add
            decimal SC_Total = await gtr.GetTotal(dgv2, 1); // sub
            decimal Total = NetEarnings + AC_Total - SC_Total;

            return Total;
        }

        public async Task<decimal> CalcICF(DataGridView dgv1, decimal totalOCF)
        {
            decimal ICF_Total = await gtr.GetTotal(dgv1, 1);
            decimal Total = totalOCF - ICF_Total;

            return Total;
        }

        public async Task<decimal> CalcFCF(DataGridView dgv1, decimal totalICF)
        {
            decimal FCF_Total = await gtr.GetTotal(dgv1, 1);
            decimal Total = FCF_Total + totalICF;

            return Total;
        }

        #endregion
    }
}
