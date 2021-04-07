using System;
using System.Windows.Forms;
using Financial_System.Utils;
using Financial_System.Forms;

namespace Financial_System.UserControls
{
    public partial class StudentItemControl : UserControl
    {
        // Handlers
        UIHandler ui = new UIHandler();
        StudentLedgerWindow slw;

        public string _StudentName;
        public string _StudentSection;
        public string _StudentLevel;
        public string _StudentId;
        public string _StudentLrn;

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

        public string StudentLrn
        {
            get { return _StudentLrn; }
            set { _StudentLrn = value; }
        }

        public StudentItemControl()
        {
            InitializeComponent();
            ui.RoundUserControl(this);
            ui.RoundButton(ViewLedgerButton);
            ui.RoundPanel(ProfilePanel);

            StudentNameLabel.Text = StudentName;
            StudentSectionLabel.Text = StudentSection;
            StudentLevelLabel.Text = StudentLevel;
            //StudentIDLabel.Text = StudentId;
            StudentIDLabel.Text = StudentLrn;
        }


        private void ViewLedgerButton_Click(object sender, EventArgs e)
        {
            // Once clicked, the data should show on StudentLedgerWindow
            slw = new StudentLedgerWindow(_StudentId, _StudentLrn, _StudentName, _StudentSection, _StudentLevel);

            slw.StudentNameLabel.Text = StudentName;
            slw.StudentSectionLabel.Text = StudentSection;
            slw.StudentLevelLabel.Text = StudentLevel;
            //slw.StudentIDLabel.Text = StudentId;
            slw.StudentIDLabel.Text = StudentLrn;

            slw.Show();
        }


    }
}
