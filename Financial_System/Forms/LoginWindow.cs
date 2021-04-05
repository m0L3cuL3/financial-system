using System;
using System.Drawing;
using System.Windows.Forms;
using Financial_System.Utils;

namespace Financial_System.Forms
{
    public partial class LoginWindow : Form
    {
        UIHandler ui = new UIHandler();

        private static bool _exiting;

        public LoginWindow()
        {
            InitializeComponent();
            ui.RoundWindow(this);
            ui.RoundButton(loginButton);
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
            if(userTextBox.Text == "admin" && passTextBox.Text == "1234")
            {
                Hide();
                MainWindow mw = new MainWindow(userTextBox.Text);
                mw.Show();  
            }
            else
            {
                MessageBox.Show("nope lmao!");
            }
        }

        private void LoginWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _exiting = true;
            Environment.Exit(1);
        }
    }
}
