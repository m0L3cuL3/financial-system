using System;
using System.Windows.Forms;
using Financial_System.Utils;
using Financial_System.Forms;
using Financial_System.UserControls;
using System.Data.SQLite;


namespace Financial_System.UserControls
{
    public partial class StudentControl : UserControl
    {
        // Handlers
        UIHandler ui = new UIHandler();
        DataHandler dh = new DataHandler();
        SQLiteHandler sql = new SQLiteHandler();
        StudentLedgerWindow slw;

        public string _StudentName;
        public string _StudentSection;
        public string _StudentLevel;
        public string _StudentId;

        public string StudentName
        {
            get { return _StudentName; }
            set { _StudentName = value; }
        }
        public string StudentSection
        {
            get { return _StudentSection; }
            set { _StudentSection = value; }
        }
        public string StudentLevel
        {
            get { return _StudentLevel; }
            set { _StudentLevel = value; }
        }
        public string StudentId
        {
            get { return _StudentId; }
            set { _StudentId = value; }
        }

        public StudentControl()
        {
            InitializeComponent();
            ui.RoundUserControl(this);
            ui.RoundButton(ViewLedgerButton);

            StudentNameLabel.Text = StudentName;
            StudentSectionLabel.Text = StudentSection;
            StudentLevelLabel.Text = StudentLevel;
            StudentIDLabel.Text = StudentId;
        }


        private void ViewLedgerButton_Click(object sender, EventArgs e)
        {
            // Once clicked, the data should show on StudentLedgerWindow
            slw = new StudentLedgerWindow();

            slw.StudentNameLabel.Text = StudentName;
            slw.StudentSectionLabel.Text = StudentSection;
            slw.StudentLevelLabel.Text = StudentLevel;
            slw.StudentIDLabel.Text = StudentId;
       
            slw.Show();
        }


    }
}
