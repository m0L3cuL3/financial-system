using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Financial_System.Utils;
using Financial_System.UserControls;


namespace Financial_System.Forms
{
    public partial class StudentLedgerWindow : Form
    {
        UIHandler ui = new UIHandler();


        public StudentLedgerWindow()
        {
            InitializeComponent();
            ui.RoundWindow(this);
        }

        // DRAG WINDOW
        private void TopBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            ui.DragWindow(Handle, e);
        }

        // CLOSE WINDOW
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
