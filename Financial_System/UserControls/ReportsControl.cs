using System;
using System.Windows.Forms;
using Financial_System.Utils;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace Financial_System.UserControls
{
    public partial class ReportsControl : UserControl
    {
        SQLiteHandler sql = new SQLiteHandler();
        UIHandler ui = new UIHandler();

        public ReportsControl()
        {
            InitializeComponent();
            ui.RoundButton(expToCSVButton);
            ui.RoundButton(printButton);
        }

        private void ReportsControl_Load(object sender, EventArgs e)
        {
            LoadTransactions();
            dateLabel.Text = DateTime.Now.ToString("M/d/yyyy");
        }

        public void LoadTransactions()
        {
            dataGridView1.Rows.Clear();
            sql.GetAllTransactions(sql.CreateConnection(), dataGridView1);
            GetTotal();
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

        private void GetTotal()
        {
            int i = 0;

            foreach(DataGridViewRow r in dataGridView1.Rows)
            {
                i += Convert.ToInt32(r.Cells[3].Value);
            }

            totalLabel.Text = i.ToString();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadTransactions();
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
