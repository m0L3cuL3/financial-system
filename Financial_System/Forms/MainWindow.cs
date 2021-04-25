using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Financial_System.Utils;
using Squirrel;

namespace Financial_System.Forms
{
    public partial class MainWindow : Form
    {
        readonly UIHandler ui = new UIHandler();
        readonly UCHandler uc = new UCHandler();
        readonly SQLiteHandler sql = new SQLiteHandler();
        Globals gb = new Globals();

        public MainWindow(string currUser)
        {
            InitializeComponent();

            UsernameLabel.Text = currUser;

            // UIHandler
            ui.RoundWindow(this); // makes the window round.
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            gb._term = sql.GetCurrentTerm(sql.CreateConnection());
            termlbl.Text = $"Current Term: {gb._term}";
        }

        // MOVING BORDERLESS WINDOW
        private void TopBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            ui.DragWindow(Handle, e);
        }

        // Collections
        private void CollectionsButton_Click(object sender, EventArgs e)
        {
            //ui.DropDown(CollectionPanel, 27, 86);
            uc.UnloadControls(DisplayControlPanel);
            uc.LoadControl(DisplayControlPanel, uc.StudLedgerControl);
            uc.StudLedgerControl.LoadStudentLedgerFromEnrolmentTable(sql.CreateConnection());
        }

        // CLOSE
        private void CloseButton_Click(object sender, EventArgs e)
        {
            var confirmLogout = MessageBox.Show("Do you want to logout?", "Confirm logout.", MessageBoxButtons.YesNo);
            if(confirmLogout == DialogResult.Yes)
            {
                Hide();
                LoginWindow lw = new LoginWindow();
                lw.Show();
            }
            else
            {
                // do nothing...
            }    
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
        }

        // Tools
        private void ToolsButton_Click(object sender, EventArgs e)
        {
            uc.UnloadControls(DisplayControlPanel);
            uc.LoadControl(DisplayControlPanel, uc.ToolsControl);
        }

        // Edit Profile
        private void editProfButton_Click(object sender, EventArgs e)
        {
            ChangePasswordWindow cpw = new ChangePasswordWindow();
            cpw.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uc.UnloadControls(DisplayControlPanel);
            uc.LoadControl(DisplayControlPanel, uc.BulkControl);
        }
    }
}
