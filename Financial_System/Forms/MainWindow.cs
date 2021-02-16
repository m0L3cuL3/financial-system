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
using System.Data.SQLite;

namespace Financial_System
{
    public partial class mainWindow : MaterialForm
    {
        // Handlers
        SQLiteHandler sqlh = new SQLiteHandler();
        public mainWindow()
        {
            InitializeComponent();

            //statusTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //statusTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;

            /*SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true); 
            SetStyle(ControlStyles.SupportsTransparentBackColor, false); 
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);*/ // Assign our buffer context. backbufferContext = BufferedGraphicsManager. Current; 
            var msm = MaterialSkinManager.Instance;
            msm.AddFormToManage(this);
            msm.Theme = MaterialSkinManager.Themes.LIGHT;
            msm.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }


        private void mainWindow_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            statusTable.Rows.Add(12341, "Sample Student 0", "Section A", 3, 1, "pending");
            statusTable.Rows.Add(12341, "Sample Student 0", null, 3, 1, "pending");
        }

        private void TestBtn_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn;
            conn = sqlh.CreateConnection();
            sqlh.CreateTable(conn);
        }
    }
}
