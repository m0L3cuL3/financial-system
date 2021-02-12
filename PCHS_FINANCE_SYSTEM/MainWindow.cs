using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCHS_FINANCE_SYSTEM
{
    public partial class btnDisplayDrives : Form
    {
        Excel excel = new Excel();

        public btnDisplayDrives()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            excel.CreateNewWorkbook(workBooktxtBox.Text);
        }

    }
}
