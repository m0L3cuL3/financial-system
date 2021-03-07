using System;
using System.Windows.Forms;
using Financial_System.Utils;
using Financial_System.Forms;

namespace Financial_System.UserControls
{
    public partial class StudentControl : UserControl
    {
        // Handlers
        UIHandler ui = new UIHandler();

        // Getters & Setters.
        public string StudentName 
        {
            get { return NameLabel.Text; }
            set { NameLabel.Text = value; }
        }
        public string StudentSection
        {
            get { return SectionLabel.Text; }
            set { SectionLabel.Text = value; }
        }

        public string StudentId
        {
            get { return StudentIDLabel.Text; }
            set { StudentIDLabel.Text = value; }
        }

        public string StudentLevel
        {
            get { return StudentLevelLabel.Text; }
            set { StudentLevelLabel.Text = value; }
        }

        public StudentControl()
        {
            InitializeComponent();
            ui.RoundUserControl(this);
            ui.RoundButton(ViewLedgerButton);
        }


        private void ViewLedgerButton_Click(object sender, EventArgs e)
        {

            StudentLedgerWindow form = new StudentLedgerWindow();

            form.StudentNameLabel.Text = StudentName;
            form.StudentSectionLabel.Text = StudentSection;
            form.StudentLevelLabel.Text = StudentLevel;
            form.StudentIDLabel.Text = StudentId;

            form.Show();
        }

        
    }
}
