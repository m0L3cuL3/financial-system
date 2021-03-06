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
using Financial_System.UserControls;

namespace Financial_System.UserControls
{
    public partial class StudentLedgerControl : UserControl
    {
        UIHandler ui = new UIHandler();

        public StudentLedgerControl()
        {
            InitializeComponent();
            ui.RoundButton(FilterButton);
            Populate(10);
        }

        // Loads Ledger with fake data -> change this later to load actual data!
        public void Populate(int num)
        {
            StudentFlowPanel.SuspendLayout();
            StudentFlowPanel.Controls.Clear();
            for(int i=0; i<num; i++)
            {
                StudentFlowPanel.Controls.Add(new StudentControl());
            }
            StudentFlowPanel.ResumeLayout();
        }

    }
}
