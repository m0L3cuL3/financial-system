﻿using System;
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

        // Unloads Controls
        public void UnloadControls(Panel panel)
        {
            panel.Controls.Clear();
        }

        // Loads Controls
        public void LoadControl(Panel panel, UserControl userControl)
        {
            panel.Controls.Add(userControl);
        }
    }
}
