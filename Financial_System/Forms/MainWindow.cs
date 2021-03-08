using System;
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
            uc.UnloadControls(DisplayControlPanel);
            uc.LoadControl(DisplayControlPanel, uc.TransControl);
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

        private void TestButton_Click(object sender, EventArgs e)
        {
            sql.CreateTable(sql.CreateConnection());
            MessageBox.Show("Table Created!");    
        }
        private void TestButton2_Click(object sender, EventArgs e)
        {
            sql.InsertStudentData(sql.CreateConnection());
            MessageBox.Show("Student Inserted!");
        }

        /*private void label2_Click(object sender, EventArgs e)
        {
            uc.UnloadControls(DisplayControlPanel);
            //uc.LoadControl(DisplayControlPanel, uc.StudLedgerControl);
            DisplayControlPanel.Controls.Add(TestButton2);
            DisplayControlPanel.Controls.Add(TestButton);

            //DisplayControlPanel.Refresh();
        }*/

        private void ReportButton_Click(object sender, EventArgs e)
        {
            uc.UnloadControls(DisplayControlPanel);
            uc.LoadControl(DisplayControlPanel, uc.ReportsControl);
        }
    }
}
