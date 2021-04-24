using Financial_System.Features;
using Financial_System.Utils;
using IronXL;
using System;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Financial_System.Forms
{
    public partial class StudentLedgerWindow : Form
    {
        UIHandler ui = new UIHandler();
        SQLiteHandler sql = new SQLiteHandler();
        Globals gb = new Globals();
        GetTotalResult gtr = new GetTotalResult();

        //string sid;
        string name;
        string section;
        string level;
        string lrn;

        public StudentLedgerWindow(string lrn, string name, string section, string level)
        {
            InitializeComponent();
            //this.sid = sid;
            this.lrn = lrn;
            this.name = name;
            this.section = section;
            this.level = level;

            // UIHandler
            ui.RoundWindow(this); // makes the window round.
            ui.RoundButton(PostPaymentButton);
            ui.RoundButton(exportBtn);
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
            StudentNameLabel.Text = name;
            StudentSectionLevelLabel.Text = $"{section} - {level}";
            StudentLRNLabel.Text = lrn;

            sql.GetStudentTransactions(sql.CreateConnection(), dataGridView1, lrn);

            await sql.GetTerm(sql.CreateConnection(), TermComboBox);
            await gtr.GetList(TypeCmBox, gb.PaymentList);
            totalcalc();
        }

        // post payment
        private void PostPaymentButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (amountBox.Text == string.Empty || TypeCmBox.SelectedItem.ToString() == string.Empty || ReceiptBox.Text == string.Empty)
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
                        sql.InsertTransaction(sql.CreateConnection(), null ,Convert.ToInt32(amountBox.Text), TypeCmBox.Text, lrn ,ReceiptBox.Text); //TermComboBox.SelectedIndex
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
            sql.GetStudentTransactions(sql.CreateConnection(), dataGridView1, lrn);
            dataGridView1.Refresh();
            totalcalc();
        }

        // export ledger
        private void exportBtn_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void ExportToExcel()
        {
            Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\PCHS Finance\\Student Ledgers");
            string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\PCHS Finance\\Student Ledgers\\{name}.xlsx";

            WorkBook wb;
            WorkSheet xlsSheet;

            if (!File.Exists(path))
            {
                wb = WorkBook.Create(ExcelFileFormat.XLSX);
                wb.Metadata.Author = "PCHS";
                xlsSheet = wb.CreateWorkSheet($"{section} - {level}");
            }
            else
            {
                wb = WorkBook.Load(path);
                xlsSheet = wb.GetWorkSheet($"{section} - {level}");
            }

            // Current Assets
            xlsSheet.Merge("A1:F1");
            xlsSheet["A1:F1"].Value = name;
            xlsSheet["A1:F1"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
            xlsSheet["A1:F1"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
            xlsSheet["A1:F1"].Style.SetBackgroundColor("#7EA0D6");
            xlsSheet["A1:F1"].Style.Font.SetColor("#F2F4F5");
            xlsSheet["A1:F1"].Style.Font.Height = 16;

            xlsSheet["A2:F2"].Style.Font.Height = 12;
            xlsSheet["A2:F2"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Thin;
            xlsSheet["A2:F2"].Style.LeftBorder.Type = IronXL.Styles.BorderType.Thin;
            xlsSheet["A2:F2"].Style.RightBorder.Type = IronXL.Styles.BorderType.Thin;
            xlsSheet["A2:F2"].Style.TopBorder.Type = IronXL.Styles.BorderType.Thin;
            xlsSheet["A2:F2"].Style.BottomBorder.SetColor("#000000");
            xlsSheet["A2:F2"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
            xlsSheet["A2:F2"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
            xlsSheet["A2:F2"].Style.SetBackgroundColor("#2F75B5");
            xlsSheet["A2:F2"].Style.Font.SetColor("#F2F4F5");
            xlsSheet["A2"].Value = "Transaction ID";
            xlsSheet["B2"].Value = "Amount";
            xlsSheet["C2"].Value = "Type";
            xlsSheet["D2"].Value = "Term";
            xlsSheet["E2"].Value = "Receipt #";
            xlsSheet["F2"].Value = "Date Recorded";

            int currIndex = 3;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                xlsSheet[$"A{currIndex}"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
                xlsSheet[$"B{currIndex}"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;

                xlsSheet[$"A{currIndex}"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                xlsSheet[$"B{currIndex}"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;

                xlsSheet[$"A{currIndex}"].Value = dataGridView1.Rows[i].Cells[0].Value; // transaction id
                xlsSheet[$"B{currIndex}"].Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value); // amount
                xlsSheet[$"C{currIndex}"].Value = dataGridView1.Rows[i].Cells[2].Value; // type
                xlsSheet[$"D{currIndex}"].Value = dataGridView1.Rows[i].Cells[3].Value; // term
                xlsSheet[$"E{currIndex}"].Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value); // receipt #
                xlsSheet[$"F{currIndex}"].Value = dataGridView1.Rows[i].Cells[5].Value; // date recorded
                currIndex = currIndex + 1;
            }

            wb.SaveAs(path);
            MessageBox.Show($"File saved at {path}", "XLSX Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void totalcalc()
        {
            int paymenttotal = dataGridView1.Rows.Cast<DataGridViewRow>().Sum(t => t.Cells[2].Value.Equals(DBNull.Value) ? 0 : Convert.ToInt32(t.Cells[2].Value));
            int feestotal = dataGridView1.Rows.Cast<DataGridViewRow>().Sum(t => t.Cells[1].Value.Equals(DBNull.Value) ? 0 : Convert.ToInt32(t.Cells[1].Value));
            //paymentlbl.Text = paymenttotal.ToString();
            //amountlbl.Text = feestotal.ToString();

            if ((feestotal - paymenttotal) > 0)
            {
                balORcredit.Text = "Balance";
                balancelbl.Text = "₱  " + Math.Abs(feestotal - paymenttotal).ToString();
                balancelbl.ForeColor = System.Drawing.Color.Red;

            }
            else
            {
                balancelbl.ForeColor = System.Drawing.Color.Green;
                balORcredit.Text = "Credit";
                balancelbl.Text = "₱  " + Math.Abs(feestotal - paymenttotal).ToString();

            }

        }
    }
}
