using Financial_System.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Financial_System.Forms
{
    public partial class ChangePasswordWindow : Form
    {
        SQLiteHandler sql = new SQLiteHandler();
        UIHandler ui = new UIHandler();

        public ChangePasswordWindow()
        {
            InitializeComponent();
            ui.RoundWindow(this);
            ui.RoundButton(UpdatePassButton);
        }

        private void UpdatePassButton_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Do you want to change your password?", "Confirm password update.", MessageBoxButtons.YesNoCancel);
                if (confirmResult == DialogResult.Yes)
                {
                    sql.UpdateUserCreds(sql.CreateConnection(), CurrUserTextBox.Text, CurrPassTextBox.Text, NewUserTextBox.Text, NewPassTextBox.Text);
                    ((MainWindow)this.Owner).LabelText = NewUserTextBox.Text;
                    CurrUserTextBox.Text = "";
                    CurrPassTextBox.Text = "";
                    NewUserTextBox.Text = "";
                    NewPassTextBox.Text = "";

                }
                else
                {
                    MessageBox.Show("Nothing was changed.");// If 'No', do something here.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TopBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            ui.DragWindow(Handle, e);
        }
    }
}
