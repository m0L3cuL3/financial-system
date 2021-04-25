using System.Windows.Forms;
using Financial_System.Utils;
using System.Data.SQLite;
using System;
using System.Threading.Tasks;

namespace Financial_System.UserControls
{
    enum Filter
    {
        All,
        LRN,
        Name,
        Section,
        Level
    }

    public partial class StudentLedgerControl : UserControl
    {
        UIHandler ui = new UIHandler();
        SQLiteHandler sql = new SQLiteHandler();
        StudentItemControl sc;

        public StudentLedgerControl()
        {
            InitializeComponent();
            ui.RoundButton(FilterButton);
            ui.RoundPanel(FilterPanel);
            StudentFlowPanel.Controls.IndexOf(sc);
        }

        // Loads All Ledger data (this is public)
        public void LoadStudentLedger(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;

            sqlite_cmd = new SQLiteCommand("SELECT * FROM Student_tbl", conn); //
            SQLiteDataReader read = sqlite_cmd.ExecuteReader();

            StudentFlowPanel.SuspendLayout();
            StudentFlowPanel.Controls.Clear();

            while (read.Read())
            {
                sc = new StudentItemControl();
                sc.StudentLrn = read.GetInt64(0).ToString(); // LRN
                sc.StudentName = read.GetString(1) + " " + read.GetString(2) + " " + read.GetString(3); // fullname
                sc.StudentIDLabel.Text = read.GetInt64(0).ToString(); // LRN
                sc.StudentNameLabel.Text = read.GetString(1) + " " + read.GetString(2) + " " + read.GetString(3); // fullname
                sc.StudentSectionLabel.Text = "Section: " + read.GetString(5); // section  
                sc.StudentLevelLabel.Text = "Level: " + read.GetInt32(6).ToString(); // level

                StudentFlowPanel.Controls.Add(sc);
            }

            StudentFlowPanel.ResumeLayout();
        }

        public void LoadStudentLedgerFromEnrolmentTable(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;

            sqlite_cmd = new SQLiteCommand("SELECT * FROM Enrolment_tbl", conn);
            SQLiteDataReader read = sqlite_cmd.ExecuteReader();

            StudentFlowPanel.SuspendLayout();
            StudentFlowPanel.Controls.Clear();

            while (read.Read())
            {
                sc = new StudentItemControl();
                sc.StudentLrn = read.GetInt64(read.GetOrdinal("lrn")).ToString(); // LRN
                sc.StudentName = read.GetString(read.GetOrdinal("first_name")) + " " + read.GetString(read.GetOrdinal("middle_name")) + " " + read.GetString(read.GetOrdinal("surname")); // fullname
                sc.StudentIDLabel.Text = read.GetInt64(read.GetOrdinal("lrn")).ToString(); // LRN
                sc.StudentNameLabel.Text = read.GetString(read.GetOrdinal("first_name")) + " " + read.GetString(read.GetOrdinal("middle_name")) + " " + read.GetString(read.GetOrdinal("surname")); // fullname
                sc.StudentSectionLabel.Text = "Section: " + read.GetString(read.GetOrdinal("section")); // section  
                sc.StudentLevelLabel.Text = "Level: " + read.GetInt32(read.GetOrdinal("level")).ToString(); // level
                sc.StudentSection = read.GetString(read.GetOrdinal("section")); // section  gettersetter
                sc.StudentLevel = read.GetInt32(read.GetOrdinal("level")).ToString(); // level gettersetter

                StudentFlowPanel.Controls.Add(sc);
            }

            StudentFlowPanel.ResumeLayout();
        }

        // Filters Ledgers by LRN (uses student_id for testing purposes -> change this to LRN later)
        private void LoadStudentLedgerByLRN(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;

            sqlite_cmd = new SQLiteCommand("SELECT * FROM Enrolment_tbl WHERE lrn = @lrn", conn);

            sqlite_cmd.Parameters.AddWithValue("@lrn", FilterTextBox.Text);

            SQLiteDataReader read = sqlite_cmd.ExecuteReader();

            StudentFlowPanel.SuspendLayout();
            StudentFlowPanel.Controls.Clear();

            while (read.Read())
            {
                sc = new StudentItemControl();
                sc.StudentLrn = read.GetInt64(read.GetOrdinal("lrn")).ToString(); // LRN
                sc.StudentName = read.GetString(read.GetOrdinal("first_name")) + " " + read.GetString(read.GetOrdinal("middle_name")) + " " + read.GetString(read.GetOrdinal("surname")); // fullname
                sc.StudentIDLabel.Text = read.GetInt64(read.GetOrdinal("lrn")).ToString(); // LRN
                sc.StudentNameLabel.Text = read.GetString(read.GetOrdinal("first_name")) + " " + read.GetString(read.GetOrdinal("middle_name")) + " " + read.GetString(read.GetOrdinal("surname")); // fullname
                sc.StudentSectionLabel.Text = "Section: " + read.GetString(read.GetOrdinal("section")); // section  
                sc.StudentLevelLabel.Text = "Level: " + read.GetInt32(read.GetOrdinal("level")).ToString(); // level
                sc.StudentSection = read.GetString(read.GetOrdinal("section")); // section  gettersetter
                sc.StudentLevel = read.GetInt32(read.GetOrdinal("level")).ToString(); // level gettersetter

                StudentFlowPanel.Controls.Add(sc);
            }

            StudentFlowPanel.ResumeLayout();
        }

        // Filters Ledgers by Name (as of now, only supports surname)
        private void LoadStudentLedgerByName(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;

            sqlite_cmd = new SQLiteCommand("SELECT * FROM Enrolment_tbl WHERE surname LIKE @surname COLLATE NOCASE", conn);

            sqlite_cmd.Parameters.AddWithValue("@surname", "%" + FilterTextBox.Text + "%");

            SQLiteDataReader read = sqlite_cmd.ExecuteReader();

            StudentFlowPanel.SuspendLayout();
            StudentFlowPanel.Controls.Clear();

            while (read.Read())
            {
                sc = new StudentItemControl();
                sc.StudentLrn = read.GetInt64(read.GetOrdinal("lrn")).ToString(); // LRN
                sc.StudentName = read.GetString(read.GetOrdinal("first_name")) + " " + read.GetString(read.GetOrdinal("middle_name")) + " " + read.GetString(read.GetOrdinal("surname")); // fullname
                sc.StudentIDLabel.Text = read.GetInt64(read.GetOrdinal("lrn")).ToString(); // LRN
                sc.StudentNameLabel.Text = read.GetString(read.GetOrdinal("first_name")) + " " + read.GetString(read.GetOrdinal("middle_name")) + " " + read.GetString(read.GetOrdinal("surname")); // fullname
                sc.StudentSectionLabel.Text = "Section: " + read.GetString(read.GetOrdinal("section")); // section  
                sc.StudentLevelLabel.Text = "Level: " + read.GetInt32(read.GetOrdinal("level")).ToString(); // level
                sc.StudentSection = read.GetString(read.GetOrdinal("section")); // section  gettersetter
                sc.StudentLevel = read.GetInt32(read.GetOrdinal("level")).ToString(); // level gettersetter

                StudentFlowPanel.Controls.Add(sc);
            }

            StudentFlowPanel.ResumeLayout();
        }

        // Filters Ledgers by Section
        private void LoadStudentLedgerBySection(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;

            sqlite_cmd = new SQLiteCommand("SELECT * FROM Enrolment_tbl WHERE section LIKE @section", conn);

            sqlite_cmd.Parameters.AddWithValue("@section","%"+ FilterTextBox.Text+ "%");

            SQLiteDataReader read = sqlite_cmd.ExecuteReader();

            StudentFlowPanel.SuspendLayout();
            StudentFlowPanel.Controls.Clear();

            while (read.Read())
            {
                sc = new StudentItemControl();
                sc.StudentLrn = read.GetInt64(read.GetOrdinal("lrn")).ToString(); // LRN
                sc.StudentName = read.GetString(read.GetOrdinal("first_name")) + " " + read.GetString(read.GetOrdinal("middle_name")) + " " + read.GetString(read.GetOrdinal("surname")); // fullname
                sc.StudentIDLabel.Text = read.GetInt64(read.GetOrdinal("lrn")).ToString(); // LRN
                sc.StudentNameLabel.Text = read.GetString(read.GetOrdinal("first_name")) + " " + read.GetString(read.GetOrdinal("middle_name")) + " " + read.GetString(read.GetOrdinal("surname")); // fullname
                sc.StudentSectionLabel.Text = "Section: " + read.GetString(read.GetOrdinal("section")); // section  
                sc.StudentLevelLabel.Text = "Level: " + read.GetInt32(read.GetOrdinal("level")).ToString(); // level
                sc.StudentSection = read.GetString(read.GetOrdinal("section")); // section  gettersetter
                sc.StudentLevel = read.GetInt32(read.GetOrdinal("level")).ToString(); // level gettersetter

                StudentFlowPanel.Controls.Add(sc);
            }

            StudentFlowPanel.ResumeLayout();
        }

        // Filters Ledger by Level
        private void LoadStudentLedgerByLevel(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;

            sqlite_cmd = new SQLiteCommand("SELECT * FROM Enrolment_tbl WHERE level LIKE @level", conn);

            sqlite_cmd.Parameters.AddWithValue("@level","%" +  FilterTextBox.Text + "%");

            SQLiteDataReader read = sqlite_cmd.ExecuteReader();

            StudentFlowPanel.SuspendLayout();
            StudentFlowPanel.Controls.Clear();

            while (read.Read())
            {
                sc = new StudentItemControl();
                sc.StudentLrn = read.GetInt64(read.GetOrdinal("lrn")).ToString(); // LRN
                sc.StudentName = read.GetString(read.GetOrdinal("first_name")) + " " + read.GetString(read.GetOrdinal("middle_name")) + " " + read.GetString(read.GetOrdinal("surname")); // fullname
                sc.StudentIDLabel.Text = read.GetInt64(read.GetOrdinal("lrn")).ToString(); // LRN
                sc.StudentNameLabel.Text = read.GetString(read.GetOrdinal("first_name")) + " " + read.GetString(read.GetOrdinal("middle_name")) + " " + read.GetString(read.GetOrdinal("surname")); // fullname
                sc.StudentSectionLabel.Text = "Section: " + read.GetString(read.GetOrdinal("section")); // section  
                sc.StudentLevelLabel.Text = "Level: " + read.GetInt32(read.GetOrdinal("level")).ToString(); // level
                sc.StudentSection = read.GetString(read.GetOrdinal("section")); // section  gettersetter
                sc.StudentLevel = read.GetInt32(read.GetOrdinal("level")).ToString(); // level gettersetter

                StudentFlowPanel.Controls.Add(sc);
            }

            StudentFlowPanel.ResumeLayout();
        }

        // FilterList
        private void FilterList(Filter filter)
        {
            try
            {
                switch (filter)
                {
                    case Filter.All:
                        LoadStudentLedgerFromEnrolmentTable(sql.CreateConnection());
                        break;
                    case Filter.LRN:
                        LoadStudentLedgerByLRN(sql.CreateConnection());
                        break;
                    case Filter.Name:
                        LoadStudentLedgerByName(sql.CreateConnection());
                        break;
                    case Filter.Section:
                        LoadStudentLedgerBySection(sql.CreateConnection());
                        break;
                    case Filter.Level:
                        LoadStudentLedgerByLevel(sql.CreateConnection());
                        break;
                    default:
                        LoadStudentLedgerFromEnrolmentTable(sql.CreateConnection()); // filter all by default
                        break;
                }
            }
            catch (Exception)
            {
                // do nothing
            }
            
        }

        // OnClick Filters Ledgers
        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (ShowAllRadioButton.Checked)
            {
                FilterList(Filter.All);
            }
            else if (LRNRadioButton.Checked)
            {
                FilterList(Filter.LRN);
            }
            else if (NameRadioButton.Checked)
            {
                FilterList(Filter.Name);
            }
            else if (SectionRadioButton.Checked)
            {
                FilterList(Filter.Section);
            } 
            else if (LevelRadioButton.Checked)
            {
                FilterList(Filter.Level);
            }
            
        }

    }
}
