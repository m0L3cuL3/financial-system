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

        public async Task<decimal> GetTotal(DataGridView dgv, int rIndex)
        {
            return await Task.Run(() =>
            {
                int i = 0;

                foreach (DataGridViewRow r in dgv.Rows)
                {
                    i += Convert.ToInt32(r.Cells[rIndex].Value);
                }

                return i;
            });
        }

        public async Task GetTotal(DataGridView dgv, int rIndex, Label lbl)
        {
            await Task.Run(() =>
            {
                int i = 0;

                foreach (DataGridViewRow r in dgv.Rows)
                {
                    i += Convert.ToInt32(r.Cells[rIndex].Value);
                }

                lbl.Text = i.ToString();
            });
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

        // 
        public async Task GetList(ComboBox cb, string[] arr)
        {
            await Task.Run(() =>
            {
                for(int i = 0; i < arr.Length; i++)
                {
                    cb.Items.Add(arr[i]);
                }
            });
        }
    }
}
