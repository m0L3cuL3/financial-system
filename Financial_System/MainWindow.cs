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

namespace Financial_System
{
    public partial class mainWindow : MaterialForm
    {
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
            // sample data. ERASE AFTER DEVELOPMENT
            for(int i = 0; i<10; i++)
            {
                invoiceFlowPanel.Controls.Add(new InvoiceItemHolder());
            }         
        }
    }
}
