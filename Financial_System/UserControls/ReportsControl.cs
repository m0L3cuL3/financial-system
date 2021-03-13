using System;
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
                    read.GetValue(read.GetOrdinal("amount")),
                    read.GetValue(read.GetOrdinal("receipt_number")),
                    read.GetValue(read.GetOrdinal("date_recorded"))
                });
            }

        }
    }
}
