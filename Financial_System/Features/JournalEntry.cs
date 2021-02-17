using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financial_System.Features
{
    interface IJournalEntry
    {
        void GetDebitTotal(DataGridView dgv, Label lbl);
        void GetCreditTotal(DataGridView dgv, Label lbl);
        void BalanceTotal(DataGridView dgv, Label lbl);
    }

    class JournalEntry : IJournalEntry
    {
        double debitTotal = 0;
        double creditTotal = 0;
        public void GetDebitTotal(DataGridView dgv, Label lbl)
        {
            debitTotal = 0;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                debitTotal += Convert.ToDouble(dgv.Rows[i].Cells[4].Value);
            }
            lbl.Text = $"Debit: {debitTotal}";
        }

        public void GetCreditTotal(DataGridView dgv, Label lbl)
        {
            creditTotal = 0;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                creditTotal += Convert.ToDouble(dgv.Rows[i].Cells[5].Value);
            }
            lbl.Text = $"Credit: {creditTotal}";
        }

        public void BalanceTotal(DataGridView dgv, Label lbl)
        {
            debitTotal = 0;
            creditTotal = 0;

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                debitTotal += Convert.ToDouble(dgv.Rows[i].Cells[4].Value);
            }

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                creditTotal += Convert.ToDouble(dgv.Rows[i].Cells[5].Value);
            }

            if(debitTotal == creditTotal && creditTotal == debitTotal)
            {
                lbl.Text = "Balanced";
            }
            else
            {
                lbl.Text = "Not Balanced";
            }
        }
            
    }
}
