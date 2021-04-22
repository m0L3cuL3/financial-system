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
        Globals gb = new Globals();

        public BulkOperationsControl()
        {
            InitializeComponent();
        }

        private void BulkOperationsControl_Load(object sender, EventArgs e)
        {
            refreshtables();
        }

        private void addFeebtn_Click(object sender, EventArgs e)
        {
            using (NewFeeWindow nfw = new NewFeeWindow())
            {
                nfw.ShowDialog(TopLevelControl);
            }
            refreshtables();
        }

        private void addPaymentbtn_Click(object sender, EventArgs e)
        {
            using (NewPaymentWindow npw = new NewPaymentWindow())
            {
                npw.ShowDialog(TopLevelControl);
            }
            refreshtables();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            refreshtables();
        }

        public void refreshtables()
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            sql.GetFees(sql.CreateConnection(), dataGridView1);
            sql.GetPayments(sql.CreateConnection(), dataGridView2);
        }

        private void newGroupbtn_Click(object sender, EventArgs e)
        {
            using (NewGroupWindow ngw = new NewGroupWindow())
            {
                ngw.ShowDialog(TopLevelControl);
            }
            refreshtables();
        }
    }
}
