using Financial_System.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financial_System.Forms
{
    public partial class StudentListWindow : Form
    {
        SQLiteHandler sql = new SQLiteHandler();
        UIHandler ui = new UIHandler();

        string studentLRN;
        string tobelistid;
        public StudentListWindow()
        {
            InitializeComponent();
            ui.RoundWindow(this);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)13) loginButton_Click(sender, e);  //Allow Enter  
        }

        private void StudentListWindow_Load(object sender, EventArgs e)
        {
            sql.GetStudents(sql.CreateConnection(), dataGridView1, false);
            tobelistid = (sql.GetListCount(sql.CreateConnection()) + 1).ToString();
            listidlbl.Text = "List ID: " + (sql.GetListCount(sql.CreateConnection()) + 1);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                this.studentLRN = dataGridView1.Rows[selectedrowindex].Cells[0].Value.ToString();
                //MessageBox.Show("rowindex: " + selectedrowindex.ToString() + "\n row: " + row.ToString());

            }
        }

        //add student to list
        private void button1_Click(object sender, EventArgs e)
        { // >>
            /*if (dataGridView1.SelectedRows != null)
            {
                int selectedrowindex = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[selectedrowindex];
                DataGridViewRow clonedRow = (DataGridViewRow)row.Clone();
                for (Int32 index = 0; index < row.Cells.Count; index++)
                {
                    clonedRow.Cells[index].Value = row.Cells[index].Value;
                }
                dataGridView2.Rows.Add(clonedRow);

                //sql.InsertLRNtoList();
                //sql.GetFeeGroupFeesMembers(sql.CreateConnection(), groupid, dataGridView2);
            }*/

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                DataGridViewRow clonedRow = (DataGridViewRow)row.Clone();
                for (Int32 index = 0; index < row.Cells.Count; index++)
                {
                    clonedRow.Cells[index].Value = row.Cells[index].Value;
                }
                dataGridView2.Rows.Add(clonedRow);
            }
        }

        //inserts it to the database
        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                //insert the LRNs to make up the list
                int i = 0;
                List<string> list = new List<string>();
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    list.Add(row.Cells[0].Value.ToString());
                    i++;
                }
                var message = string.Join(Environment.NewLine, list);

                var confirmResult = MessageBox.Show("Inserted " + i + "Students to a list named: " + name.Text + "?",
                                         "Confirm",
                                         MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    sql.InsertNewList(sql.CreateConnection(), name.Text, desc.Text, tobelistid);//insert a list to the list table 
                    sql.InsertLRNTOList(sql.CreateConnection(), list, tobelistid);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occured. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // <<

            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                dataGridView2.Rows.RemoveAt(row.Index);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            sql.FilterStudentsBySurname(sql.CreateConnection(), dataGridView1, familynamebx.Text);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TopBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            ui.DragWindow(Handle, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sql.FilterStudentsByLRN(sql.CreateConnection(), dataGridView1, lrnBox.Text);
        }
    }
}
