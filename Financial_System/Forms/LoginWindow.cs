using System;
using System.Drawing;
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
            sql.CreateTable(sql.CreateConnection());
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            ui.DragWindow(Handle, e);
        }

        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        // todo: make login functional
        private void loginButton_Click(object sender, System.EventArgs e)
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

        private void LoginWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _exiting = true;
            Environment.Exit(1);
        }

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
    }
}
