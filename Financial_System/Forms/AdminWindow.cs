using Financial_System.Utils;
using System;
using System.Windows.Forms;

namespace Financial_System.Forms
{
    public partial class AdminWindow : Form
    {
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
                    await sql.InsertTerm(sql.CreateConnection(), TermId_txtBox.Text, TermDesc_txtBox.Text);
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

    }
}
