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
    public partial class EditFeeWindow : Form
    {

        SQLiteHandler sql = new SQLiteHandler();
        UIHandler ui = new UIHandler();
        Globals gb = new Globals();
        List<string> list = new List<string>();

        string feeid;
        bool isFee;
        public EditFeeWindow(string feeid, bool isFee)
        {
            InitializeComponent();
            this.feeid = feeid;
            list = sql.GetFeesPayments(sql.CreateConnection(), Convert.ToInt32(feeid));
            name.Text = list[1];
            desc.Text = list[4];
            amount.Text = list[2];
            this.isFee = isFee;

            if(!isFee)
            {
                namelbl.Text = "Payment (Discount) Name";
                amountlbl.Text = "Payment/Discount";
                this.Text = "Edit Payment";
                amount.Text = list[3];
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Update?",
                                     "Confirm Update",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                if(isFee)
                { 
                    sql.UpdateFP(sql.CreateConnection(), feeid, name.Text, desc.Text, Convert.ToInt32(amount.Text), null);
                } else
                {
                    sql.UpdateFP(sql.CreateConnection(), feeid, name.Text, desc.Text, null, Convert.ToInt32(amount.Text));
                }

            }
            this.Close();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Confirm Delete?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                if(isFee)
                {
                    sql.DeleteFP(sql.CreateConnection(), feeid);

                }else
                {
                    sql.DeleteFP(sql.CreateConnection(), feeid);

                }
            }
            this.Close();
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
