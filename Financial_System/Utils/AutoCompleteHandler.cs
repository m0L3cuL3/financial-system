using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financial_System.Utils
{
    class AutoCompleteHandler
    {

        public void AutoCompleteFunction(TextBox tb1, TextBox tb2, TextBox tb3, TextBox tb4, DataGridView dgv)
        {
            AutoCompleteStringCollection LedgerIDCollection = new AutoCompleteStringCollection();
            AutoCompleteStringCollection TransactionIDCollection = new AutoCompleteStringCollection();
            AutoCompleteStringCollection StudentIDCollection = new AutoCompleteStringCollection();
            AutoCompleteStringCollection FullnameCollection = new AutoCompleteStringCollection();

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                LedgerIDCollection.Add(dgv.Rows[i].Cells[0].Value.ToString());
            }

           
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                TransactionIDCollection.Add(dgv.Rows[i].Cells[1].Value.ToString());
            }
            
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                StudentIDCollection.Add(dgv.Rows[i].Cells[2].Value.ToString());
            }
            
            
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                FullnameCollection.Add(dgv.Rows[i].Cells[3].Value.ToString());
            }

            tb1.AutoCompleteMode = AutoCompleteMode.Suggest;
            tb1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tb1.AutoCompleteCustomSource = LedgerIDCollection;

            tb2.AutoCompleteMode = AutoCompleteMode.Suggest;
            tb2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tb2.AutoCompleteCustomSource = TransactionIDCollection;

            tb3.AutoCompleteMode = AutoCompleteMode.Suggest;
            tb3.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tb3.AutoCompleteCustomSource = StudentIDCollection;

            tb4.AutoCompleteMode = AutoCompleteMode.Suggest;
            tb4.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tb4.AutoCompleteCustomSource = FullnameCollection;
        }

        public void AutoCompleteList()
        {

        }
    }
}
