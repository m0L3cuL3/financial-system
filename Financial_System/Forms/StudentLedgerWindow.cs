using Financial_System.Utils;
using System;
using System.Windows.Forms;

namespace Financial_System.Forms
{
    public partial class StudentLedgerWindow : Form
    {
        UIHandler ui = new UIHandler();
        DataHandler dh = new DataHandler();

        public StudentLedgerWindow()
        {
            InitializeComponent();

            // UIHandler
            ui.RoundWindow(this); // makes the window round.
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TopBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            ui.DragWindow(Handle, e);
        }

        private void StudentLedgerWindow_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Student Name is " + StudentNameLabel.Text); // -> testing purposes only
        }
    }
}
