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

            sqlite_cmd = new SQLiteCommand("SELECT * FROM Student_tbl", conn);
            SQLiteDataReader read = sqlite_cmd.ExecuteReader();

            StudentFlowPanel.SuspendLayout();
            StudentFlowPanel.Controls.Clear();

            while (read.Read())
            {
                sc = new StudentItemControl();
                sc.StudentId = read.GetInt32(0).ToString(); // id  
                sc.StudentLrn = read.GetInt64(1).ToString(); // LRN
                sc.StudentName = read.GetString(2) + " " + read.GetString(3) + " " + read.GetString(4); // fullname
                sc.StudentSection = read.GetString(5); // section  
                sc.StudentLevel = read.GetInt32(6).ToString(); // level

                //sc.StudentIDLabel.Text = "Student ID: " + read.GetInt32(0).ToString(); // id
                //sc.StudentIDLabel.Text = "Student LRN: " + read.GetInt64(1).ToString(); // LRN
                sc.StudentIDLabel.Text = read.GetInt64(1).ToString(); // LRN
                sc.StudentNameLabel.Text = read.GetString(2) + " " + read.GetString(3) + " " + read.GetString(4); // fullname
                sc.StudentSectionLabel.Text = "Section: " + read.GetString(5); // section  
                sc.StudentLevelLabel.Text = "Level: " + read.GetInt32(6).ToString(); // level

                StudentFlowPanel.Controls.Add(sc);
            }

            StudentFlowPanel.ResumeLayout();
        }

        // Filters Ledgers by LRN (uses student_id for testing purposes -> change this to LRN later)
        private void LoadStudentLedgerByLRN(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;

            sqlite_cmd = new SQLiteCommand("SELECT * FROM Student_tbl WHERE student_LRN = @lrn", conn);

            sqlite_cmd.Parameters.AddWithValue("@lrn", FilterTextBox.Text);

            SQLiteDataReader read = sqlite_cmd.ExecuteReader();

            StudentFlowPanel.SuspendLayout();
            StudentFlowPanel.Controls.Clear();

            while (read.Read())
            {
                sc = new StudentItemControl();
                sc.StudentId = read.GetInt32(0).ToString(); // id  
                sc.StudentLrn = read.GetInt32(1).ToString(); // LRN
                sc.StudentName = read.GetString(2) + " " + read.GetString(3) + " " + read.GetString(4); // fullname
                sc.StudentSection = read.GetString(5); // section  
                sc.StudentLevel = read.GetInt32(6).ToString(); // level

                //sc.StudentIDLabel.Text = "Student ID: " + read.GetInt32(0).ToString(); // id
                //sc.StudentIDLabel.Text = "Student LRN: " + read.GetInt64(1).ToString(); // LRN
                sc.StudentIDLabel.Text = read.GetInt64(1).ToString(); // LRN
                sc.StudentNameLabel.Text = read.GetString(2) + " " + read.GetString(3) + " " + read.GetString(4); // fullname
                sc.StudentSectionLabel.Text = "Section: " + read.GetString(5); // section  
                sc.StudentLevelLabel.Text = "Level: " + read.GetInt32(6).ToString(); // level

                StudentFlowPanel.Controls.Add(sc);
            }

            StudentFlowPanel.ResumeLayout();
        }

        // Filters Ledgers by Name (as of now, only supports surname)
        private void LoadStudentLedgerByName(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;

            sqlite_cmd = new SQLiteCommand("SELECT * FROM Student_tbl WHERE surname = @surname COLLATE NOCASE", conn);

            sqlite_cmd.Parameters.AddWithValue("@surname", FilterTextBox.Text);

            SQLiteDataReader read = sqlite_cmd.ExecuteReader();

            StudentFlowPanel.SuspendLayout();
            StudentFlowPanel.Controls.Clear();

            while (read.Read())
            {
                sc = new StudentItemControl();
                sc.StudentId = read.GetInt32(0).ToString(); // id  
                sc.StudentLrn = read.GetInt32(1).ToString(); // LRN
                sc.StudentName = read.GetString(2) + " " + read.GetString(3) + " " + read.GetString(4); // fullname
                sc.StudentSection = read.GetString(5); // section  
                sc.StudentLevel = read.GetInt32(6).ToString(); // level

                //sc.StudentIDLabel.Text = "Student ID: " + read.GetInt32(0).ToString(); // id
                //sc.StudentIDLabel.Text = "Student LRN: " + read.GetInt64(1).ToString(); // LRN
                sc.StudentIDLabel.Text = read.GetInt64(1).ToString(); // LRN
                sc.StudentNameLabel.Text = read.GetString(2) + " " + read.GetString(3) + " " + read.GetString(4); // fullname
                sc.StudentSectionLabel.Text = "Section: " + read.GetString(5); // section  
                sc.StudentLevelLabel.Text = "Level: " + read.GetInt32(6).ToString(); // level

                StudentFlowPanel.Controls.Add(sc);
            }

            StudentFlowPanel.ResumeLayout();
        }

        // Filters Ledgers by Section
        private void LoadStudentLedgerBySection(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;

            sqlite_cmd = new SQLiteCommand("SELECT * FROM Student_tbl WHERE section = @section", conn);

            sqlite_cmd.Parameters.AddWithValue("@section", FilterTextBox.Text);

            SQLiteDataReader read = sqlite_cmd.ExecuteReader();

            StudentFlowPanel.SuspendLayout();
            StudentFlowPanel.Controls.Clear();

            while (read.Read())
            {
                sc = new StudentItemControl();
                sc.StudentId = read.GetInt32(0).ToString(); // id  
                sc.StudentLrn = read.GetInt32(1).ToString(); // LRN
                sc.StudentName = read.GetString(2) + " " + read.GetString(3) + " " + read.GetString(4); // fullname
                sc.StudentSection = read.GetString(5); // section  
                sc.StudentLevel = read.GetInt32(6).ToString(); // level

                //sc.StudentIDLabel.Text = "Student ID: " + read.GetInt32(0).ToString(); // id
                //sc.StudentIDLabel.Text = "Student LRN: " + read.GetInt64(1).ToString(); // LRN
                sc.StudentIDLabel.Text = read.GetInt64(1).ToString(); // LRN
                sc.StudentNameLabel.Text = read.GetString(2) + " " + read.GetString(3) + " " + read.GetString(4); // fullname
                sc.StudentSectionLabel.Text = "Section: " + read.GetString(5); // section  
                sc.StudentLevelLabel.Text = "Level: " + read.GetInt32(6).ToString(); // level

                StudentFlowPanel.Controls.Add(sc);
            }

            StudentFlowPanel.ResumeLayout();
        }

        // Filters Ledger by Level
        private void LoadStudentLedgerByLevel(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;

            sqlite_cmd = new SQLiteCommand("SELECT * FROM Student_tbl WHERE level = @level", conn);

            sqlite_cmd.Parameters.AddWithValue("@level", FilterTextBox.Text);

            SQLiteDataReader read = sqlite_cmd.ExecuteReader();

            StudentFlowPanel.SuspendLayout();
            StudentFlowPanel.Controls.Clear();

            while (read.Read())
            {
                sc = new StudentItemControl();
                sc.StudentId = read.GetInt32(0).ToString(); // id  
                sc.StudentLrn = read.GetInt32(1).ToString(); // LRN
                sc.StudentName = read.GetString(2) + " " + read.GetString(3) + " " + read.GetString(4); // fullname
                sc.StudentSection = read.GetString(5); // section  
                sc.StudentLevel = read.GetInt32(6).ToString(); // level

                //sc.StudentIDLabel.Text = "Student ID: " + read.GetInt32(0).ToString(); // id
                //sc.StudentIDLabel.Text = "Student LRN: " + read.GetInt64(1).ToString(); // LRN
                sc.StudentIDLabel.Text = read.GetInt64(1).ToString(); // LRN
                sc.StudentNameLabel.Text = read.GetString(2) + " " + read.GetString(3) + " " + read.GetString(4); // fullname
                sc.StudentSectionLabel.Text = "Section: " + read.GetString(5); // section  
                sc.StudentLevelLabel.Text = "Level: " + read.GetInt32(6).ToString(); // level

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
                        LoadStudentLedger(sql.CreateConnection());
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
                        LoadStudentLedger(sql.CreateConnection()); // filter all by default
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
