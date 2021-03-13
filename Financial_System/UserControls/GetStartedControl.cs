using Financial_System.Utils;
using System.Windows.Forms;

namespace Financial_System.UserControls
{
    public partial class GetStartedControl : UserControl
    {
        UIHandler ui = new UIHandler();
        public GetStartedControl()
        {
            InitializeComponent();
            ui.RoundPanel(WikiPanel);
        }
    }
}
