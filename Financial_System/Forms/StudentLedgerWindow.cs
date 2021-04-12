using Financial_System.Utils;
using System;
using System.IO;
using System.Windows.Forms;

namespace Financial_System.Forms
{
    public partial class StudentLedgerWindow : Form
    {
        UIHandler ui = new UIHandler();
        SQLiteHandler sql = new SQLiteHandler();
        Globals gb = new Globals();
        string sid;
        string name;
        string section;
        string level;
        string lrn;

        public StudentLedgerWindow(string sid, string lrn, string name, string section, string level)
        {
            InitializeComponent();
            this.sid = sid;
            this.lrn = lrn;
            this.name = name;
            this.section = section;
            this.level = level;

            // UIHandler
            ui.RoundWindow(this); // makes the window round.
            ui.RoundButton(PostPaymentButton);
            ui.RoundButton(exportBtn);
            ui.RoundButton(printBtn);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TopBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            ui.DragWindow(Handle, e);
        }

        private async void StudentLedgerWindow_Load(object sender, EventArgs e)
        {
            LoadList();
            StudentNameLabel.Text = name;
            StudentSectionLevelLabel.Text = $"{section} - {level}";
            StudentLRNLabel.Text = lrn;
            sql.GetStudentTransactions(sql.CreateConnection(), dataGridView1, sid);
            await sql.GetTerm(sql.CreateConnection(), TermComboBox);
        }

        // post payment
        private void PostPaymentButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (amountBox.Text == "" || TypeCmBox.SelectedItem.ToString() == "" || ReceiptBox.Text == "")
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
                        sql.InsertTransaction(sql.CreateConnection(), Convert.ToInt32(amountBox.Text), TypeCmBox.Text, sid, ReceiptBox.Text, TermComboBox.SelectedIndex);
                        MessageBox.Show("Transaction Added");
                        TypeCmBox.Text = "";
                        amountBox.Text = "";
                        ReceiptBox.Text = "";
                        TermComboBox.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Nothing was added");// If 'No', do something here.
                    }
                }   
            }
            catch (Exception)
            {
                MessageBox.Show("Exception Error!");
            }

            //reportsControl.RefreshDGV(); // auto load in reports.
            sql.GetStudentTransactions(sql.CreateConnection(), dataGridView1, sid);
            dataGridView1.Refresh();
        }

        // export ledger
        private void exportBtn_Click(object sender, EventArgs e)
        {
            //todo csv exporter
            Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\PCHS Finance\\Student Ledgers");
            string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\PCHS Finance\\Student Ledgers\\LEDGER([{lrn}]-[{name}]-[{section}]-[{level}]).csv";

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void LoadList()
        {
            foreach (string payment in gb.PaymentList)
            {
                TypeCmBox.Items.Add(payment);
            }
        }
    }
}
