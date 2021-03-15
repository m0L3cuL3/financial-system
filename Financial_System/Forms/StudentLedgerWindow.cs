using Financial_System.Utils;
using System;
using System.Windows.Forms;

namespace Financial_System.Forms
{
    public partial class StudentLedgerWindow : Form
    {
        UIHandler ui = new UIHandler();
        DataHandler dh = new DataHandler();
        SQLiteHandler sql = new SQLiteHandler();
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

        }
    }
}
