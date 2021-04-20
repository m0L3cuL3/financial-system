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
        public StudentLedgerControl StudLedgerControl = new StudentLedgerControl();
        public StudentItemControl StudControl = new StudentItemControl();
        public ReportsControl ReportsControl = new ReportsControl();
        public ToolsControl ToolsControl = new ToolsControl();
        public BulkOperationsControl BulkControl = new BulkOperationsControl();


        // Unloads Controls
        public void UnloadControls(Panel panel)
        {
            panel.SuspendLayout();
            panel.Controls.Clear();
            panel.ResumeLayout();
        }

        // Loads Controls
        public void LoadControl(Panel panel, UserControl userControl)
        {
            panel.SuspendLayout();
            panel.Controls.Add(userControl);
            panel.ResumeLayout();
        }
    }
}
