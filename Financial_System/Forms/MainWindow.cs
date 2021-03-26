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

            sql.CreateTable(sql.CreateConnection());
            uc.StudLedgerControl.LoadStudentLedger(sql.CreateConnection());
        }

        // MOVING BORDERLESS WINDOW
        private void TopBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            ui.DragWindow(Handle, e);
        }

        // DROP DOWN
        private void CollectionsButton_Click(object sender, EventArgs e)
        {
            //ui.DropDown(CollectionPanel, 27, 86);
            uc.UnloadControls(DisplayControlPanel);
            uc.LoadControl(DisplayControlPanel, uc.StudLedgerControl);
        }

        // CLOSE
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Get Started Tab
        private void GetStartedButton_Click(object sender, EventArgs e)
        {
            uc.UnloadControls(DisplayControlPanel);
            uc.LoadControl(DisplayControlPanel, uc.GsControl);
        }

        // Dashboard Tab
        private void DashboardButton_Click(object sender, EventArgs e)
        {
            uc.UnloadControls(DisplayControlPanel);
            uc.LoadControl(DisplayControlPanel, uc.DashControl);
            uc.DashControl.LoadChartData();
        }

        // Insert Student Test Button
        private void TestButton2_Click(object sender, EventArgs e)
        {
            sql.InsertStudentData(sql.CreateConnection());
            uc.StudLedgerControl.LoadStudentLedger(sql.CreateConnection());
            MessageBox.Show("Student Inserted!");
        }

        // Report Tab
        private void ReportButton_Click(object sender, EventArgs e)
        {
            uc.UnloadControls(DisplayControlPanel);
            uc.LoadControl(DisplayControlPanel, uc.ReportsControl);
            uc.ReportsControl.LoadTransactions();
        }

        // idk what this is lmao.
        private void PCHS_logo_picbox_Click(object sender, EventArgs e)
        {
            //don't delete
            uc.UnloadControls(DisplayControlPanel);
            DisplayControlPanel.Controls.Add(TestButton2);
        }

        // idk what this is lmao.
        private void button1_Click(object sender, EventArgs e)
        {
            sql.TermInit(sql.CreateConnection());
        }

        private void ToolsButton_Click(object sender, EventArgs e)
        {
            uc.UnloadControls(DisplayControlPanel);
            uc.LoadControl(DisplayControlPanel, uc.ToolsControl);
        }
    }
}
