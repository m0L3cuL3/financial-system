using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Financial_System.UserControls;

namespace Financial_System.Utils
{
    class UCHandler
    {
        public GetStartedControl GsControl = new GetStartedControl();
        public DashboardControl DashControl = new DashboardControl();

        public void UnloadControls(Panel panel)
        {
            panel.Controls.Clear();
        }

        public void LoadControl(Panel panel, UserControl userControl)
        {
            panel.Controls.Add(userControl);
        }

    }
}
