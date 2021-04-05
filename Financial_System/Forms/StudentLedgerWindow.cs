﻿using Financial_System.Utils;
using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Reflection;
using CsvHelper;
using System.Data;

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

        public StudentLedgerWindow(string sid, string name, string section, string level)
        {
            InitializeComponent();
            this.sid = sid;
            this.name = name;
            this.section = section;
            this.level = level;

            // UIHandler
            ui.RoundWindow(this); // makes the window round.

            LoadList();
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
            sql.GetStudentTransactions(sql.CreateConnection(), dataGridView1, sid);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //todo double click on transaction to pull up transaction details
        }

        // post payment
        private void PostPaymentButton_Click(object sender, EventArgs e)
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
                        sql.InsertTransaction(sql.CreateConnection(), Convert.ToInt32(amountBox.Text), TypeCmBox.Text, sid, ReceiptBox.Text, Convert.ToInt32(TermBox.Text));
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
            Directory.CreateDirectory(@".\Student_Ledgers");
            string path = $".\\Student_Ledgers\\LEDGER([{sid}]-[{name}]-[{section}]-[{level}]).csv";

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
