using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Financial_System.Utils;
using Financial_System.UserControls;

namespace Financial_System.UserControls
{
    public partial class InsertTestTransactionControl : UserControl
    {
        SQLiteHandler sql = new SQLiteHandler();
        ReportsControl reportsControl = new ReportsControl();
        public InsertTestTransactionControl()
        {
            InitializeComponent();
        }

        private void postpaymentbtn_Click(object sender, EventArgs e)
        {

            if(StudentIDTextBox.Text == "")
            {
                MessageBox.Show("Please Select A Student.");
            }
            else
            {
                var confirmResult = MessageBox.Show("Add this transaction?",
                                     "Confirm Transaction Insertion",
                                     MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    sql.InsertTransaction(sql.CreateConnection(), Convert.ToInt32(Math.Round(AmountNumericBox.Value, 0)), TypeTextBox.Text, StudentIDTextBox.Text, ReceiptNumTextBox.Text);
                    MessageBox.Show("Transaction Added");
                    
                }
                else
                {
                    MessageBox.Show("Nothing was added");// If 'No', do something here.
                }
            }
            reportsControl.LoadTransactions(sql.CreateConnection());
        }

        private void StudentDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = StudentDataGridView.Rows[e.RowIndex];
                StudentIDTextBox.Text = row.Cells[0].Value.ToString();
            }
                
        }

        private void InsertTestTransactionControl_Load(object sender, EventArgs e)
        {
            sql.GetStudentData(sql.CreateConnection(), StudentDataGridView);
            reportsControl.LoadTransactions(sql.CreateConnection());
        }
    }
}
