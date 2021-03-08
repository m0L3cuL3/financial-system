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

namespace Financial_System.UserControls
{
    public partial class InsertTestTransactionControl : UserControl
    {
        DataHandler dh = new DataHandler();
        SQLiteHandler sql = new SQLiteHandler();
        public InsertTestTransactionControl()
        {
            InitializeComponent();
        }

        private void postpaymentbtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Add this transaction?",
                                     "Confirm Transaction Insertion",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                sql.InsertTransaction(sql.CreateConnection(),amount.Text,type.Text,sid.Text,receipt.Text);
                // If 'Yes', do something here.
            }
            else
            {
                MessageBox.Show("Nothing was added");// If 'No', do something here.
            }
        }
    }
}
