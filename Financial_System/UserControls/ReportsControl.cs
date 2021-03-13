using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Financial_System.Utils;

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

            sqlite_cmd = new SQLiteCommand("SELECT * FROM Student_Transaction", conn);
            SQLiteDataReader read = sqlite_cmd.ExecuteReader();

            while (read.Read())
            {
                dataGridView1.Rows.Add(new object[]
                {
                    read.GetValue(0),
                    read.GetValue(read.GetOrdinal("student_id")),
                    read.GetValue(read.GetOrdinal("type")),
                    read.GetValue(read.GetOrdinal("amount"))
                });
            }

        }
    }

    class Separator : Control { //this is horizontal line in the reports window. Its like the <hr> tag in html
        private int thickness = 1;
        private bool isVertical;

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            var size = isVertical ? Height / 2 : Width / 2;
            e.Graphics.TranslateTransform(Width / 2f, Height / 2f);

            using (var pen = new Pen(ForeColor, thickness)) {
                if (!isVertical) {
                    e.Graphics.DrawLine(pen, -size + Padding.Left, 0, size - Padding.Right, 0);
                } else {
                    e.Graphics.DrawLine(pen, 0, -size + Padding.Top, 0, size - Padding.Bottom);
                }
            }
        }

        protected override void OnPaddingChanged(EventArgs e) {
            base.OnPaddingChanged(e);
            Invalidate();
        }
        public bool IsVertical {
            get => isVertical;
            set {
                isVertical = value;
                Invalidate();
            }
        }
        public int Thickness {
            get => thickness;
            set {
                thickness = value;
                if(Height < thickness) {
                    Height = thickness;
                } else {
                    Invalidate();
                }
            }
        }
    }
}
