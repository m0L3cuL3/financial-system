using Financial_System.Features;
using Financial_System.Forms;
using Financial_System.Utils;
using System.Windows.Forms;

namespace Financial_System.UserControls
{
    public partial class ToolsControl : UserControl
    {
        UIHandler ui = new UIHandler();
        GetTotalResult gtr = new GetTotalResult();
        Globals gb = new Globals();

        public ToolsControl()
        {
            InitializeComponent();
            ui.RoundPanel(FinancialPanel);
            ui.RoundPanel(GeneralPanel);
        }

        private async void ToolsControl_Load(object sender, System.EventArgs e)
        {
            await gtr.GetList(MonthComboBox, gb.MonthList);
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
            if(MonthComboBox.SelectedIndex == -1 || YearTextBox.Text == "")
            {
                MessageBox.Show("Something went wrong.");
            }
            else
            {
                BalanceSheetWindow bsw = new BalanceSheetWindow(MonthComboBox.SelectedItem.ToString(), YearTextBox.Text);
                bsw.Show();
            }
            
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
    }
}
