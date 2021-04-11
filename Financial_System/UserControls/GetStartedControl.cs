using Financial_System.Utils;
using System.Diagnostics;
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

        private void GithubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/m0L3cuL3/financial-system/wiki");
        }
    }
}
