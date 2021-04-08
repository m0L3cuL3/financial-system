using Financial_System.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financial_System.Forms
{
    public partial class AdminWindow : Form
    {
        UIHandler ui = new UIHandler();
        SQLiteHandler sql = new SQLiteHandler();

        public AdminWindow()
        {
            InitializeComponent();
            ui.RoundWindow(this);
        }

        private void AdminWindow_Load(object sender, EventArgs e)
        {
            sql.GetAllUsers(sql.CreateConnection(), UserGridView);
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
                Close();
                LoginWindow lw = new LoginWindow();
                lw.Show();
            }
            else
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                sql.InsertUserCreds(sql.CreateConnection(), UserTextBox.Text, PassTextBox.Text);
                sql.GetAllUsers(sql.CreateConnection(), UserGridView);
                UserGridView.Refresh();
                UserTextBox.Text = "";
                PassTextBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Please try again.");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql.GetAllUsers(sql.CreateConnection(), UserGridView);
            UserGridView.Refresh();
        }
    }
}
