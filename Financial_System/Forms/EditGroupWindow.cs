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
    public partial class EditGroupWindow : Form
    {
        SQLiteHandler sql = new SQLiteHandler();
        UIHandler ui = new UIHandler();
        Globals gb = new Globals();
        List<string> list = new List<string>();

        string groupid;
        public EditGroupWindow(string groupid)
        {
            InitializeComponent();
            ui.RoundWindow(this);
            this.groupid = groupid;
            list = sql.GetFGroup(sql.CreateConnection(), Convert.ToInt32(groupid));
            name.Text = list[1];
            desc.Text = list[2];
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Update?",
                                     "Confirm Update",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                sql.UpdateFPGroup(sql.CreateConnection(),groupid ,name.Text, desc.Text);
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
                sql.DeleteFPGroup(sql.CreateConnection(), groupid);
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
