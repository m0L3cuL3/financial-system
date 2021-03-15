using System;
using System.IO;
using System.Windows.Forms;
using Financial_System.Utils;

namespace Financial_System.Forms
{
    public partial class MainWindow : Form
    {
        UIHandler ui = new UIHandler();
        UCHandler uc = new UCHandler();
        SQLiteHandler sql = new SQLiteHandler();

        public MainWindow()
        {
            InitializeComponent();

            // UIHandler
            ui.RoundWindow(this); // makes the window round.

            // DropDown (min-height only!)
            CollectionPanel.Height = 27; // min-height of collection panel

            sql.CreateTable(sql.CreateConnection());
            uc.StudLedgerControl.LoadStudentLedger(sql.CreateConnection());
        }

        // MOVING BORDERLESS WINDOW
        private void TopBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            ui.DragWindow(Handle, e);
        }

        // DROP DOWN
        private void CollectionsBtn_Click(object sender, EventArgs e)
        {
            ui.DropDown(CollectionPanel, 27, 86);
        }

        // CLOSE
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GetStartedButton_Click(object sender, EventArgs e)
        {
            uc.UnloadControls(DisplayControlPanel);
            uc.LoadControl(DisplayControlPanel, uc.GsControl);
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            uc.UnloadControls(DisplayControlPanel);
            uc.LoadControl(DisplayControlPanel, uc.DashControl);
        }

        private void StudentLedgerButton_Click(object sender, EventArgs e)
        {
            
            uc.UnloadControls(DisplayControlPanel);
            uc.LoadControl(DisplayControlPanel, uc.StudLedgerControl);
        }

        private void TestButton2_Click(object sender, EventArgs e)
        {
            sql.InsertStudentData(sql.CreateConnection());
            uc.StudLedgerControl.LoadStudentLedger(sql.CreateConnection());
            MessageBox.Show("Student Inserted!");
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            uc.UnloadControls(DisplayControlPanel);
            uc.LoadControl(DisplayControlPanel, uc.ReportsControl);
        }

        private void TransactionButton_Click(object sender, EventArgs e)
        {
            uc.UnloadControls(DisplayControlPanel);
            uc.LoadControl(DisplayControlPanel, uc.TransControl);
        }

        private void PCHS_logo_picbox_Click(object sender, EventArgs e)
        {
            //don't delete
            uc.UnloadControls(DisplayControlPanel);
            DisplayControlPanel.Controls.Add(TestButton2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql.TermInit(sql.CreateConnection());
        }
    }
}
