using System.Windows.Forms;
using Financial_System.Utils;
using System.Data.SQLite;
using System.Collections.Generic;

namespace Financial_System.UserControls
{
    public partial class StudentLedgerControl : UserControl
    {
        UIHandler ui = new UIHandler();
        StudentControl sc;

        public StudentLedgerControl()
        {
            InitializeComponent();
            ui.RoundButton(FilterButton);
            
        }

        // Loads Ledger with fake data -> change this later to load actual data!

        public void ReadStudentData(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;

            sqlite_cmd = new SQLiteCommand("SELECT * FROM Student", conn);
            SQLiteDataReader read = sqlite_cmd.ExecuteReader();

            StudentFlowPanel.SuspendLayout();
            StudentFlowPanel.Controls.Clear();

            while (read.Read())
            {
                sc = new StudentControl();
                sc.StudentId = "Student ID: " + read.GetInt32(0).ToString(); // id
                sc.StudentName = read.GetString(1) + " " + read.GetString(2) + " " + read.GetString(3); // fullname
                sc.StudentSection = "Section: " + read.GetString(4); // section  
                sc.StudentLevel = "Level: " + read.GetInt32(5).ToString(); // level
                StudentFlowPanel.Controls.Add(sc);
            }
            
            
            StudentFlowPanel.ResumeLayout();  
        }
    }
}
