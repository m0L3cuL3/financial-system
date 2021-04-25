using System;
using System.IO;
using System.Windows.Forms;
using Financial_System.Utils;

namespace Financial_System.Forms
{
    public partial class LoginWindow : Form
    {
        UIHandler ui = new UIHandler();
        SQLiteHandler sql = new SQLiteHandler();
        Globals gb = new Globals();

#pragma warning disable IDE0052 // Remove unread private members
        private static bool _exiting;
#pragma warning restore IDE0052 // Remove unread private members

        public LoginWindow()
        {
            InitializeComponent();
            ui.RoundWindow(this);
            ui.RoundButton(loginButton);
            //sql.CreateTable(sql.CreateConnection());
            InitializeDB("database.db");
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            ui.DragWindow(Handle, e);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Login
        private async void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (IsAdminCheckBox.Checked)
                {
                    case true:
                        if (userTextBox.Text == gb.USER_NAME && passTextBox.Text == gb.USER_PASS)
                        {
                            Hide();
                            AdminWindow aw = new AdminWindow();
                            aw.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Input | Try Again.");
                        }
                        break;
                    case false:
                        if (sql.CountCurrentTerm(sql.CreateConnection()) == 0)
                        {
                            MessageBox.Show("Please create a Term in the Admin Panel and Make sure its set as the 'Current' Term");
                            return;
                        }
                        if (await sql.GetUserCreds(sql.CreateConnection(), userTextBox.Text, passTextBox.Text))
                        {
                            Hide();
                            MainWindow mw = new MainWindow(userTextBox.Text);
                            mw.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Input | Try Again.");
                        }
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong. Please contact your administrator.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Close
        private void LoginWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _exiting = true;
            Environment.Exit(1);
        }

        // Checks if the user is going to login as a admin or a regular user.
        private void IsAdminCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            switch (IsAdminCheckBox.Checked)
            {
                case true:
                    userLabel.Text = "Administrator";
                    break;
                case false:
                    userLabel.Text = "Username";
                    break;
            }
        }

        private async void InitializeDB(string dbFilename)
        {
            if (File.Exists(dbFilename))
            {
                // do nothing
            }
            else
            {
                await sql.CreateTable(sql.CreateConnection());
            }
        }

        private void passTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) loginButton_Click(sender, e);  //Allow Enter  
        }
    }
}
