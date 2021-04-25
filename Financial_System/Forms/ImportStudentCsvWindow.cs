using Financial_System.Utils;
using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace Financial_System.Forms
{
    public partial class ImportStudentCsvWindow : Form
    {
        UIHandler ui = new UIHandler();
        SQLiteHandler sql = new SQLiteHandler();
        public ImportStudentCsvWindow()
        {
            InitializeComponent();
            ui.RoundWindow(this);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TopBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            ui.DragWindow(Handle, e);
        }

        private DataTable ReadCsv(string filename)
        {
            DataTable dt = new DataTable("Data");
            using (OleDbConnection cn = new OleDbConnection($@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={Path.GetDirectoryName(filename)}\; Extended Properties='text;HDR=yes;FMT=Delimited(,)';"))
            {
                using(OleDbCommand cmd = new OleDbCommand(string.Format("SELECT * FROM [{0}]", new FileInfo(filename).Name), cn))
                {
                    cn.Open();
                    using(OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        private void ImportCsv_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "csv|*.csv", ValidateNames = true, Multiselect = false })
                {
                    if(ofd.ShowDialog() == DialogResult.OK)
                    {
                        STUD_DGV.DataSource = ReadCsv(ofd.FileName);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occured. {ex.Message}", "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < STUD_DGV.Rows.Count; i++)
                {
                    var lrn = STUD_DGV.Rows[i].Cells["LRN"].Value;
                    var fullname = (string)STUD_DGV.Rows[i].Cells["STUDENT_NAME"].Value;
                    string[] name = fullname.Split(null);
                    var section = STUD_DGV.Rows[i].Cells["SECTION"].Value.ToString();
                    var fulllevel = (string)STUD_DGV.Rows[i].Cells["GRADE_LEVEL"].Value;
                    string[] level = fulllevel.Split(null);
                    var aycode = (string)STUD_DGV.Rows[i].Cells["AY_CODE"].Value;
                    sql.InsertImportData(sql.CreateConnection(), Convert.ToInt64(lrn), name[0], name[1], name[2], section, Convert.ToInt32(level[1]), Globals._term.ToString());
                    sql.InsertStudentData(sql.CreateConnection(), Convert.ToInt64(lrn), name[0], name[1], name[2]);
                }
                MessageBox.Show($"CSV Loaded", "Import Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured. {ex.Message}", "Save to Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
