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
        GetTotalResult gtr = new GetTotalResult();
        Globals gb = new Globals();

        public NewGroupWindow()
        {
            InitializeComponent();
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            if (name.Text != "" && desc.Text != "")
            {
                try
                {
                    sql.NewGroup(sql.CreateConnection(), name.Text, desc.Text);
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
