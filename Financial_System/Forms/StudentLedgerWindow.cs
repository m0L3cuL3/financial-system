using Financial_System.UserControls;
using Financial_System.Utils;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Financial_System.Forms
{
    public partial class StudentLedgerWindow : Form
    {
        UIHandler ui = new UIHandler();
        DataHandler dh = new DataHandler();
        SQLiteHandler sql = new SQLiteHandler();
        ReportsControl reportsControl = new ReportsControl();
        string sid;

        public StudentLedgerWindow(string sid)
        {
            InitializeComponent();
            this.sid = sid; 
            // UIHandler
            ui.RoundWindow(this); // makes the window round.
            //sql.GetStudentTransactions(sql.CreateConnection(), dataGridView1, this.sid);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TopBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            ui.DragWindow(Handle, e);
        }

        private void StudentLedgerWindow_Load(object sender, EventArgs e)
        {
            sql.GetStudentTransactions(sql.CreateConnection(), dataGridView1, this.sid);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //todo double click on transaction to pull up transaction details
        }

        // post payment
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (amountBox.Text == "" || TypeCmBox.SelectedItem == "" || ReceiptBox.Text == "")
                {
                    MessageBox.Show("Something went wrong. Make sure to fill all the requirements.");
                }
                else
                {
                    var confirmResult = MessageBox.Show("Add this transaction?",
                                     "Confirm Transaction Insertion",
                                     MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {
                        sql.InsertTransaction(sql.CreateConnection(), Convert.ToInt32(amountBox.Text), TypeCmBox.Text, sid, ReceiptBox.Text);
                        MessageBox.Show("Transaction Added");
                    }
                    else
                    {
                        MessageBox.Show("Nothing was added");// If 'No', do something here.
                    }
                }              
            }
            catch (Exception)
            {
                MessageBox.Show("Exception Error!");// If 'No', do something here.
            }
            
            reportsControl.LoadTransactions(sql.CreateConnection()); // auto load in reports.
            sql.GetStudentTransactions(sql.CreateConnection(), dataGridView1, sid);
            dataGridView1.Refresh();
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            //todo csv exporter
            string current = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string path = Path.Combine(current, "LEDGER.csv");
           
            try
            {
                //Build the CSV file data as a Comma separated string.
                string csv = string.Empty;

                //Add the Header row for CSV file.
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    csv += column.HeaderText + ',';
                }
                //Add new line.
                csv += "\r\n";

                //Adding the Rows

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            //Add the Data rows.
                            csv += cell.Value.ToString().TrimEnd(',').Replace(",", ";") + ',';
                        }
                        // break;
                    }
                    //Add new line.
                    csv += "\r\n";
                }

                //Exporting to CSV.
                
                File.WriteAllText(path, csv);
                MessageBox.Show("Export saved to: \n" + path);
            }
            catch
            {
                MessageBox.Show("Something Happened...");
            }

        }
    }
}
