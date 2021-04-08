using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financial_System.Features
{
    public class GetTotalResult
    {
        // Use this for calculating DGV rows.
        public decimal GetTotal(DataGridView dgv)
        {
            int i = 0;

            foreach (DataGridViewRow r in dgv.Rows)
            {
                i += Convert.ToInt32(r.Cells[1].Value);
            }

            return i;
        }

        // Check if balanced.
        /**
         * Note: didn't use bool because im chad af.
         */
        public void IsBalanced(Label isBalanceLabel, decimal TotalAssets, decimal TotalLiabilityEquity)
        {
            if(TotalAssets == TotalLiabilityEquity)
            {
                isBalanceLabel.ForeColor = Color.LimeGreen;
                isBalanceLabel.Text = "TRUE"; // if balanced return TRUE.
            }
            else
            {
                isBalanceLabel.ForeColor = Color.Red;
                isBalanceLabel.Text = "FALSE"; // if not balanced return FALSE.
            }
        }
    }
}
