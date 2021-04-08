using System;
using System.Drawing;
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

        private static bool _exiting;

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
        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsAdminCheckBox.Checked) // if admin
                {

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
                }
                else // if regular user
                {

                    if (sql.GetUserCreds(sql.CreateConnection(), userTextBox.Text, passTextBox.Text))
                    {
                        Hide();
                        MainWindow mw = new MainWindow(userTextBox.Text);
                        mw.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Input | Try Again.");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong. Please contact your administrator.");
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
            if (IsAdminCheckBox.Checked)
            {
                userLabel.Text = "Administrator";
            }
            else
            {
                userLabel.Text = "Username";
            }
        }

        private void InitializeDB(string dbFilename)
        {
            if (File.Exists(dbFilename))
            {

            }
            else
            {
                var CreateFile = MessageBox.Show($"Do you want to create {dbFilename}?", "Database Not Found!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (CreateFile == DialogResult.Yes)
                {
                    sql.CreateTable(sql.CreateConnection());
                }
                else
                {
                    MessageBox.Show("Database not created, Please contact your administrator.", "Activity Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
