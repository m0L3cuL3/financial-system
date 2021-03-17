using System;
using System.Windows.Forms;
using System.Data.SQLite;
using Financial_System.Utils;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace Financial_System.UserControls
{
    public partial class ReportsControl : UserControl
    {
        SQLiteHandler sql = new SQLiteHandler();

        public ReportsControl()
        {
            InitializeComponent();
            
        }

        private void ReportsControl_Load(object sender, EventArgs e)
        {
            LoadTransactions(sql.CreateConnection());
        }

        public void LoadTransactions(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;

            sqlite_cmd = new SQLiteCommand("SELECT * FROM Transaction_tbl", conn);
            SQLiteDataReader read = sqlite_cmd.ExecuteReader();

            while (read.Read())
            {
                dataGridView1.Rows.Add(new object[]
                {
                    read.GetValue(0),
                    read.GetValue(read.GetOrdinal("student_id")),
                    read.GetValue(read.GetOrdinal("type")),
                    read.GetValue(read.GetOrdinal("amount")),
                    read.GetValue(read.GetOrdinal("receipt_number")),
                    read.GetValue(read.GetOrdinal("date_recorded"))
                });
            }

        }

        private void expToCSVButton_Click(object sender, EventArgs e)
        {
            //todo csv exporter
            string current = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string path = Path.Combine(current, "REPORTS.csv");

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

    #region Custom Separator

    class Separator : Control
    { //this is a custom control. It appears as a horizontal line just like <hr> tag in html. It does nothing
        private int thickness = 1;
        private bool isVertical;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var size = isVertical ? Height / 2 : Width / 2;
            e.Graphics.TranslateTransform(Width / 2f, Height / 2f);

            using (var pen = new Pen(ForeColor, thickness))
            {
                if (!isVertical)
                {
                    e.Graphics.DrawLine(pen, -size + Padding.Left, 0, size - Padding.Right, 0);
                }
                else
                {
                    e.Graphics.DrawLine(pen, 0, -size + Padding.Top, 0, size - Padding.Bottom);
                }
            }
        }
        protected override void OnPaddingChanged(EventArgs e)
        {
            base.OnPaddingChanged(e);
            Invalidate();
        }
        public bool IsVertical
        {
            get => isVertical;
            set
            {
                isVertical = value;
                Invalidate();
            }
        }
        public int Thickness
        {
            get => thickness;
            set
            {
                thickness = value;
                if (Height < thickness)
                {
                    Height = thickness;
                }
                else
                {
                    Invalidate();
                }
            }
        }
    }

    #endregion
}
