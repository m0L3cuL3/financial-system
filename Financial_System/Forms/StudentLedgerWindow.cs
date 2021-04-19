using ClosedXML.Excel;
using Financial_System.Features;
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
        GetTotalResult gtr = new GetTotalResult();

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

            sql.GetStudentTransactions(sql.CreateConnection(), dataGridView1, sid);

            await sql.GetTerm(sql.CreateConnection(), TermComboBox);
            await gtr.GetList(TypeCmBox, gb.PaymentList);
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
            Export();
        }

        private void Export()
        {
            try
            {
                Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\PCHS Finance\\Student Ledgers");
                string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\PCHS Finance\\Student Ledgers\\{name}.xlsx";

                IXLWorkbook wb;
                IXLWorksheet ws;

                if (!File.Exists(path))
                {
                    wb = new XLWorkbook();
                    ws = wb.Worksheets.Add($"{section} - {level}");
                }
                else
                {
                    wb = new XLWorkbook(path);
                    ws = wb.Worksheet($"{section} - {level}");
                }

                #region Title
                // Title
                ws.Cell("A1").Value = name;
                ws.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Cell("A1").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                ws.Cell("A1").Style.Fill.SetBackgroundColor(XLColor.FromHtml("#7EA0D6"));
                ws.Cell("A1").Style.Font.SetFontColor(XLColor.FromHtml("#F2F4F5"));
                ws.Cell("A1").Style.Font.SetFontSize(16);
                ws.Range("A1:F1").Merge();
                #endregion

                #region Columns

                ws.Range("A2:F2").Style.Fill.SetBackgroundColor(XLColor.FromHtml("#2F75B5"));
                ws.Range("A2:F2").Style.Font.SetFontColor(XLColor.FromHtml("#F2F4F5"));
                ws.Cell("A2").Value = "Transaction ID";
                ws.Cell("B2").Value = "Amount";
                ws.Cell("C2").Value = "Type";
                ws.Cell("D2").Value = "Term";
                ws.Cell("E2").Value = "Receipt #";
                ws.Cell("F2").Value = "Date Recorded";

                int currIndex = 3;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    ws.Cell($"A{currIndex}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    ws.Cell($"A{currIndex}").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                    ws.Cell($"B{currIndex}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    ws.Cell($"B{currIndex}").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                    ws.Cell($"A{currIndex}").Value = dataGridView1.Rows[i].Cells[0].Value; // transaction id
                    ws.Cell($"B{currIndex}").Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value); // amount
                    ws.Cell($"C{currIndex}").Value = dataGridView1.Rows[i].Cells[2].Value; // type
                    ws.Cell($"D{currIndex}").Value = dataGridView1.Rows[i].Cells[3].Value; // term
                    ws.Cell($"E{currIndex}").Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value); // receipt #
                    ws.Cell($"F{currIndex}").Value = dataGridView1.Rows[i].Cells[5].Value; // date recorded
                    currIndex = currIndex + 1;
                }

                #endregion

                wb.SaveAs(path);
                MessageBox.Show($"File saved at {path}", "XLSX Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("An error occured.\n" + ex.Message, "XLSX Export Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
