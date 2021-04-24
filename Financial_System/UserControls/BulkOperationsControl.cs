using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Financial_System.Utils;
using Financial_System.Features;
using Financial_System.Forms;

namespace Financial_System.UserControls
{
    public partial class BulkOperationsControl : UserControl
    {

        SQLiteHandler sql = new SQLiteHandler();
        UIHandler ui = new UIHandler();
        GetTotalResult gtr = new GetTotalResult();
        Globals gb = new Globals();

        public string feeid = "";
        public string paymentid = "";
        public string groupid = "";
        public string dgv3selection = "";
        public string dgv5selection = "";



        public BulkOperationsControl()
        {
            InitializeComponent();
        }

        private void BulkOperationsControl_Load(object sender, EventArgs e)
        {
            refreshtables();
            sql.GetLists(sql.CreateConnection(),dataGridView5);
        }

        private void addFeebtn_Click(object sender, EventArgs e)
        {
            using (NewFeeWindow nfw = new NewFeeWindow())
            {
                nfw.ShowDialog(this.TopLevelControl);
            }
            refreshtables();
        }

        private void addPaymentbtn_Click(object sender, EventArgs e)
        {
            using (NewPaymentWindow npw = new NewPaymentWindow())
            {
                npw.ShowDialog(this.TopLevelControl);
            }
            refreshtables();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            refreshtables();
        }

        public void refreshtables()
        {
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            dataGridView3.ClearSelection();
            dataGridView4.ClearSelection();
            
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            dataGridView4.Rows.Clear();


            sql.GetFees(sql.CreateConnection(), dataGridView1);
            sql.GetPayments(sql.CreateConnection(), dataGridView2);
            sql.GetGroups(sql.CreateConnection(), dataGridView4);
            sql.GetLists(sql.CreateConnection(), dataGridView5);

            totalcalc();

        }

        private void newGroupbtn_Click(object sender, EventArgs e)
        {
            using (NewGroupWindow ngw = new NewGroupWindow())
            {
                ngw.ShowDialog(this.TopLevelControl);
            }
            refreshtables();
        }

        private void dataGridView1_Leave(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void dataGridView2_Leave(object sender, EventArgs e)
        {
            dataGridView2.ClearSelection();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                //string cellValue = Convert.ToString(selectedRow.Cells["enter column name"].Value);

                feeid = dataGridView1.Rows[selectedrowindex].Cells[0].Value.ToString();
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView2.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];
                //string cellValue = Convert.ToString(selectedRow.Cells["enter column name"].Value);

                paymentid = dataGridView2.Rows[selectedrowindex].Cells[0].Value.ToString();
            }
        }

        private void feeToGroup_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows != null)
            {
                sql.InsertFeeTOGroup(sql.CreateConnection(), groupid, feeid);
                sql.GetFeeGroupFeesMembers(sql.CreateConnection(), groupid, dataGridView3);
            }
            totalcalc();
        }

        private void dataGridView4_SelectionChanged(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView4.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridView4.Rows[selectedrowindex];
            //string cellValue = Convert.ToString(selectedRow.Cells["enter column name"].Value);

            groupid = dataGridView4.Rows[selectedrowindex].Cells[0].Value.ToString();
            //MessageBox.Show(groupid);

        }

        private void dataGridView4_Leave(object sender, EventArgs e)
        {
            dataGridView4.ClearSelection();

        }

        private void dataGridView3_Leave(object sender, EventArgs e)
        {
            dataGridView3.ClearSelection();

        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView4.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView4.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dataGridView4.Rows[selectedrowindex];
                //string cellValue = Convert.ToString(selectedRow.Cells["enter column name"].Value);

                groupid = dataGridView4.Rows[selectedrowindex].Cells[0].Value.ToString();
                sql.GetFeeGroupFeesMembers(sql.CreateConnection(), groupid, dataGridView3); // populate dgv3

            }
            totalcalc();
        }

        private void removeFeebtn_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedrowindex = dataGridView3.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dataGridView3.Rows[selectedrowindex];
                dgv3selection = dataGridView3.Rows[selectedrowindex].Cells[0].Value.ToString();
                sql.DELETEFeeFROMGroup(sql.CreateConnection(), groupid, dgv3selection); //DELETEFeeFROMGroup works for both payments and fees 
                sql.GetFeeGroupFeesMembers(sql.CreateConnection(), groupid, dataGridView3);
                totalcalc();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occured. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void paymenttoGroupbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows != null)
            {
                sql.InsertFeeTOGroup(sql.CreateConnection(), groupid, paymentid); //InsertFeeTOGroup works for both payments and fees 
                sql.GetFeeGroupFeesMembers(sql.CreateConnection(), groupid, dataGridView3);
                
            }
            totalcalc();
        }

        private void removePaymentbtn_Click(object sender, EventArgs e)
        {
            sql.DELETEFeeFROMGroup(sql.CreateConnection(), groupid, paymentid); //DELETEFeeFROMGroup works for both payments and fees 
            sql.GetFeeGroupFeesMembers(sql.CreateConnection(), groupid, dataGridView3);
            totalcalc();
        }

        private void totalcalc()
        {
            int paymenttotal = dataGridView3.Rows.Cast<DataGridViewRow>().Sum(t => t.Cells[2].Value.Equals(DBNull.Value) ? 0: Convert.ToInt32(t.Cells[2].Value));
            int feestotal = dataGridView3.Rows.Cast<DataGridViewRow>().Sum(t => t.Cells[3].Value.Equals(DBNull.Value) ? 0 : Convert.ToInt32(t.Cells[3].Value));
            paymentlbl.Text = paymenttotal.ToString();
            amountlbl.Text = feestotal.ToString();
            
           if((feestotal - paymenttotal) > 0)
           {
                totallbl.Text = "Total Fees: " + Math.Abs(feestotal - paymenttotal).ToString();
            }
            else
            {
                totallbl.Text = "Total Discount: " + Math.Abs(feestotal - paymenttotal).ToString();

            }

        }

        //execute button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> intlist = sql.GetListsMembers(sql.CreateConnection(), dgv5selection);
                sql.ExecuteFeeGroup(sql.CreateConnection(), Convert.ToInt32(groupid), intlist);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occured. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newList_Click(object sender, EventArgs e)
        {
            using (StudentListWindow slw = new StudentListWindow())
            {
                slw.ShowDialog(this.TopLevelControl);
            }
            refreshtables();
        }

        //fee dgv
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (EditFeeWindow efw = new EditFeeWindow(feeid, true))
            {
                efw.ShowDialog(this.TopLevelControl);
            }
            refreshtables();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (EditFeeWindow efw = new EditFeeWindow(paymentid, false))
            {
                efw.ShowDialog(this.TopLevelControl);
            }
            refreshtables();
        }

        private void dataGridView5_SelectionChanged(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView5.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridView5.Rows[selectedrowindex];
            dgv5selection = dataGridView5.Rows[selectedrowindex].Cells[0].Value.ToString();
        }
    }
}
