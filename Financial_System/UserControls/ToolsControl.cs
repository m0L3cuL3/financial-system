using Financial_System.Forms;
using Financial_System.Utils;
using System.Windows.Forms;

namespace Financial_System.UserControls
{
    public partial class ToolsControl : UserControl
    {
        UIHandler ui = new UIHandler();
        public ToolsControl()
        {
            InitializeComponent();
            ui.RoundPanel(FinancialPanel);
            ui.RoundPanel(GeneralPanel);
        }

        private void AddStudButton_Click(object sender, System.EventArgs e)
        {
            AddStudentWindow asw = new AddStudentWindow();
            asw.Show();
        }

        private void BalSheetButton_Click(object sender, System.EventArgs e)
        {
            BalanceSheetWindow bsw = new BalanceSheetWindow();
            bsw.Show();
        }
    }
}
