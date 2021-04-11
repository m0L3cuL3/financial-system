﻿using Financial_System.UserControls;
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
    public partial class AddStudentWindow : Form
    {
        Globals gb = new Globals();
        SQLiteHandler sql = new SQLiteHandler();
        UIHandler ui = new UIHandler();
        StudentLedgerControl slc = new StudentLedgerControl();

        public AddStudentWindow()
        {
            InitializeComponent();

            ui.RoundWindow(this);
            ui.RoundButton(addStudButton);    
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Loads Level list.
        private void LoadList()
        {
            foreach (string level in gb.LevelList)
            {
                LevelComboBox.Items.Add(level);
            }
        }

        private void TopBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            ui.DragWindow(Handle, e);
        }

        // Add Student (in case there is no API from Enrollment Systems)
        private void addStudButton_Click(object sender, EventArgs e)
        {
            try
            {
                sql.InsertStudentData(sql.CreateConnection(), Convert.ToInt64(LRNTextBox.Text), FnameTextBox.Text, MidnameTextBox.Text, SurnameTextBox.Text, SectionTextBox.Text, LevelComboBox.SelectedIndex);
                slc.LoadStudentLedger(sql.CreateConnection());
                MessageBox.Show("Student Inserted!");
            }
            catch
            {

            }
            
        }

        // OnFormLoad
        private void AddStudentWindow_Load(object sender, EventArgs e)
        {
            LoadList();
        }
    }
}
