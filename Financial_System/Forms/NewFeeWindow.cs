﻿using Financial_System.Utils;
using System;
using System.Windows.Forms;

namespace Financial_System.Forms
{
    public partial class NewFeeWindow : Form
    {
        SQLiteHandler sql = new SQLiteHandler();
        UIHandler ui = new UIHandler();

        public NewFeeWindow()
        {
            InitializeComponent();
            ui.RoundWindow(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text != "" && desc.Text != "" && amount.Text != "")
            {
                try
                {
                    sql.NewFeeTemplate(sql.CreateConnection(), name.Text, desc.Text, int.Parse(amount.Text));
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

        private void amount_KeyPress(object sender, KeyPressEventArgs e)
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
