using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Financial_System.Utils;
using Financial_System.Features;
using System.Data.SQLite;

namespace Financial_System
{

    public partial class mainWindow : MaterialForm
    {
        // Handlers
        SQLiteHandler sqlh = new SQLiteHandler();
        AutoCompleteHandler ach = new AutoCompleteHandler();
        DataHandler dh = new DataHandler();
        SQLiteConnection conn;

        public mainWindow()
        {
            InitializeComponent();

            var msm = MaterialSkinManager.Instance;
            msm.AddFormToManage(this);
            msm.Theme = MaterialSkinManager.Themes.LIGHT;
            msm.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }


        private void mainWindow_Load(object sender, EventArgs e)
        {
            LedgerDgv.Rows.Add(100, 1, 422, "Test User");
            LedgerDgv.Rows.Add(101, 11, 112, "Test User");
            LedgerDgv.Rows.Add(104, 12, 21, "Test User");
            LedgerDgv.Rows.Add(105, 13, 23, "Test User");
            LedgerDgv.Rows.Add(106, 14, 12, "Test User");

            ach.AutoCompleteFunction(LIDTxtBox, TIDTxtBox, SIDTxtBox, FullnameTxtBox, LedgerDgv);
        }

        private void LedgerDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                //
                //TODO - OnClick Show Student Transactions.
                //
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dh.FilterLedgerID(LIDTxtBox, LedgerDgv); // fix this shit.
        }

        private void TestBtn_Click(object sender, EventArgs e)
        {
            CheckTable();
        }


        private void LoadStudentData()
        {
            StudentDgv.Rows.Clear();
            StudentDgv.Refresh();
            conn = sqlh.CreateConnection();
            sqlh.ReadStudentData(conn, StudentDgv);
        }

        private void CheckTable()
        {
            try
            {
                conn = sqlh.CreateConnection();
                sqlh.CreateTable(conn);

                MessageBox.Show("Database and Tables Created!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Database File Already Exists!");
            }
            
        }

        private void LoadStudentBtn_Click(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        private void InsertStudentBtn_Click(object sender, EventArgs e)
        {
            conn = sqlh.CreateConnection();
            sqlh.InsertStudentData(conn);
            LoadStudentData();
        }
    }
}
