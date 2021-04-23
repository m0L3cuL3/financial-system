using Financial_System.Features;
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
    public partial class NewGroupWindow : Form
    {
        SQLiteHandler sql = new SQLiteHandler();
        UIHandler ui = new UIHandler();

        public NewGroupWindow()
        {
            InitializeComponent();
            ui.RoundWindow(this);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TopBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            ui.DragWindow(Handle, e);
        }

        private void Create_Btn_Click(object sender, EventArgs e)
        {
            if (!IsEmpty())
            {
                try
                {
                    sql.NewGroup(sql.CreateConnection(), name.Text, desc.Text);
                    Close();
                }
                catch (FormatException fe)
                {
                    MessageBox.Show($"An error occured. {fe.Message}", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill out all fields.", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsEmpty()
        {
            bool status = false;
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    TextBox txtBox = c as TextBox;
                    if (txtBox.Text == string.Empty)
                    {
                        status = true;
                    }
                    else
                    {
                        status = false;
                    }
                }
            }
            return status;
        }
    }
}
