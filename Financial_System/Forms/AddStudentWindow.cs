using Financial_System.UserControls;
using Financial_System.Utils;
using System;
using System.Windows.Forms;

namespace Financial_System.Forms
{
    public partial class AddStudentWindow : Form
    {
        readonly Globals gb = new Globals();
        readonly SQLiteHandler sql = new SQLiteHandler();
        readonly UIHandler ui = new UIHandler();
        readonly StudentLedgerControl slc = new StudentLedgerControl();

        public AddStudentWindow()
        {
            InitializeComponent();

            ui.RoundWindow(this);
            ui.RoundButton(addStudButton);    
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Loads Level list.
        private void LoadList()
        {
            for(int i = 0; i < gb.LevelList.Length; i++)
            {
                LevelComboBox.Items.Add(gb.LevelList[i]);
            }
        }

        private void TopBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            ui.DragWindow(Handle, e);
        }

        // Add Student (in case there is no API from Enrollment Systems)
        private void addStudButton_Click(object sender, EventArgs e)
        {
            try
            {
                sql.InsertStudentData(sql.CreateConnection(), Convert.ToInt64(LRNTextBox.Text), FnameTextBox.Text, MidnameTextBox.Text, SurnameTextBox.Text, SectionTextBox.Text, LevelComboBox.SelectedIndex);
                slc.LoadStudentLedger(sql.CreateConnection());
                MessageBox.Show("Student Inserted!");
            }
            catch
            {
                MessageBox.Show("Something went wrong. Please try again.");
            }
            
        }

        // OnFormLoad
        private void AddStudentWindow_Load(object sender, EventArgs e)
        {
            LoadList();
        }
    }
}
