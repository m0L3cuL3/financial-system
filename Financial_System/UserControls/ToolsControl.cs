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
    }
}
