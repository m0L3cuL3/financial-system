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
    public partial class NewPaymentWindow : Form
    {

        SQLiteHandler sql = new SQLiteHandler();
        UIHandler ui = new UIHandler();
        GetTotalResult gtr = new GetTotalResult();
        Globals gb = new Globals();

        public NewPaymentWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text != "" && desc.Text != "" && payment.Text != "") 
            { 
                try
                {
                    sql.NewPaymentTemplate(sql.CreateConnection(), name.Text, desc.Text, int.Parse(payment.Text));
                    this.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                MessageBox.Show("Please fill out all fields.");
            }
        }

        private void payment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;         //Just Digits
            if (e.KeyChar == (char)8) e.Handled = false;            //Allow Backspace
            if (e.KeyChar == (char)13) button1_Click(sender, e);  //Allow Enter  
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
