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
    public partial class TermEditWindow : Form
    {
        SQLiteHandler sql = new SQLiteHandler();
        UIHandler ui = new UIHandler();
        string[] list;
        string termid;
        public TermEditWindow(string termid)
        {
            InitializeComponent();
            this.termid = termid;
            list = sql.GetTerm(sql.CreateConnection(), this.termid).ToArray();
            term.Text = list[0];
            desc.Text = list[1];
            checkBox1.Checked = Convert.ToBoolean(Convert.ToInt32(list[2]));

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //Convert.ToInt32(checkBox1.Checked)
            await sql.UpdateTerm(sql.CreateConnection(), term.Text, desc.Text, checkBox1.Checked);

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //delete

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
