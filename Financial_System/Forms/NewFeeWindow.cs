﻿using Financial_System.Features;
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
    public partial class NewFeeWindow : Form
    {
        SQLiteHandler sql = new SQLiteHandler();
        UIHandler ui = new UIHandler();
        GetTotalResult gtr = new GetTotalResult();
        Globals gb = new Globals();

        public NewFeeWindow()
        {
            InitializeComponent();
            ui.RoundWindow(this);
        }

        private void amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;         //Just Digits
            if (e.KeyChar == (char)8) e.Handled = false;            //Allow Backspace
            if (e.KeyChar == (char)13) Create_Btn_Click(sender, e);  //Allow Enter  
        }

        private void Create_Btn_Click(object sender, EventArgs e)
        {
            if (!IsEmpty())
            {
                try
                {
                    sql.NewFeeTemplate(sql.CreateConnection(), name.Text, desc.Text, int.Parse(amount.Text));
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