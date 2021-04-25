using Financial_System.Utils;
using System;
using System.Windows.Forms;

namespace Financial_System.Forms
{
    public partial class AdminWindow : Form
    {

        public string termid = "";
        UIHandler ui = new UIHandler();
        static SQLiteHandler sql = new SQLiteHandler();

        public AdminWindow()
        {
            InitializeComponent();
            ui.RoundWindow(this);
        }

        private async void AdminWindow_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            await sql.GetTerm(sql.CreateConnection(), TermDGV);
            LoadUsers();
        }

        private void TopBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            ui.DragWindow(Handle, e);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            var confirmLogout = MessageBox.Show("Do you want to logout?", "Confirm logout.", MessageBoxButtons.YesNo);
            if (confirmLogout == DialogResult.Yes)
            {
                Hide();
                LoginWindow lw = new LoginWindow();
                lw.Show();
            }
            else
            {
                // do nothing...
            }
        }

        // Adds User
        private async void addUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserTextBox.Text == "" || PassTextBox.Text == "")
                {
                    MessageBox.Show("Blank fields. Please enter data.");
                }
                else
                {
                    UserGridView.Rows.Clear();
                    await sql.InsertUserCreds(sql.CreateConnection(), UserTextBox.Text, PassTextBox.Text);
                    await sql.GetAllUsers(sql.CreateConnection(), UserGridView);
                    UserTextBox.Text = "";
                    PassTextBox.Text = "";
                }             
            }
            catch
            {
                MessageBox.Show("Something went wrong. Please try again.");
            }
            
        }

        // Loads all users.
        private async void button1_Click(object sender, EventArgs e)
        {
            UserGridView.Rows.Clear();
            await sql.GetAllUsers(sql.CreateConnection(), UserGridView);
        }

        // Initialize DB onClick
        private void InitializeDb_Btn_Click(object sender, EventArgs e)
        {
            InitializeDB();
            MessageBox.Show("Database initialized!");
        }

        // Load Users
        private async void LoadUsers()
        {
            try
            {
                await sql.GetAllUsers(sql.CreateConnection(), UserGridView);
            }
            catch
            {
                MessageBox.Show("Something went wrong, make sure the database is initialized.");
            }
        }

        // Initializes Database
        private async void InitializeDB()
        {
            await sql.CreateTable(sql.CreateConnection());
        }

        // Adds Academic Term
        private async void AddTerm_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if(TermId_txtBox.Text == "" || TermDesc_txtBox.Text == "")
                {
                    MessageBox.Show("Blank fields. Please enter data.");
                }
                else
                {
                    TermDGV.Rows.Clear();
                    await sql.InsertTerm(sql.CreateConnection(), TermId_txtBox.Text, TermDesc_txtBox.Text, checkBox1.Checked);
                    await sql.GetTerm(sql.CreateConnection(), TermDGV);
                    TermId_txtBox.Text = "";
                    TermDesc_txtBox.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong.");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private async void TermDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = TermDGV.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = TermDGV.Rows[selectedrowindex];
            //string cellValue = Convert.ToString(selectedRow.Cells["enter column name"].Value);

            termid = TermDGV.Rows[selectedrowindex].Cells[0].Value.ToString();

            using (TermEditWindow tew = new TermEditWindow(termid))
            {
                tew.ShowDialog(this.TopLevelControl);
            }
            await sql.GetTerm(sql.CreateConnection(), TermDGV);


        }

        private void makeCurrentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedrowindex = TermDGV.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = TermDGV.Rows[selectedrowindex];
            //string cellValue = Convert.ToString(selectedRow.Cells["enter column name"].Value);

            termid = TermDGV.Rows[selectedrowindex].Cells[0].Value.ToString();

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                await sql.CreateParticulars(sql.CreateConnection());
            }
            catch (Exception)
            {
                MessageBox.Show("Error! Particulars already in database!");
                throw;
            }
        }
    }
}
