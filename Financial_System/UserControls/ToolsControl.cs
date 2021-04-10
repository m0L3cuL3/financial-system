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

        // Add Student
        private void AddStudButton_Click(object sender, System.EventArgs e)
        {
            AddStudentWindow asw = new AddStudentWindow();
            asw.Show();
        }

        // Create Balance Sheet
        private void BalSheetButton_Click(object sender, System.EventArgs e)
        {
            BalanceSheetWindow bsw = new BalanceSheetWindow();
            bsw.Show();
        }

        // Create Income Statement
        private void IncomeStmtButton_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Work in progress!");
        }

        // Create CashFlow Statement
        private void CFButton_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Work in progress!");
        }

        private void AddTermButton_Click(object sender, System.EventArgs e)
        {

        }
    }
}
