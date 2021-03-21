using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace Financial_System.Utils
{
    class UIHandler
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse
        );

        // Makes the window round.
        public void RoundWindow(Form window)
        {
            window.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, window.Width, window.Height, 20, 20));
        }

        // Makes a UserControl round.
        public void RoundUserControl(UserControl userControl)
        {
            userControl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, userControl.Width, userControl.Height, 20, 20));
        }

        // Makes a panel round.
        public void RoundPanel(Panel panel)
        {
            panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 20, 20));
        }

        // Makes a button round.
        public void RoundButton(Button button)
        {
            button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button.Width, button.Height, 30, 30));
        }

        // Makes the window draggable.
        public void DragWindow(IntPtr windowHandle, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(windowHandle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Allows the panel to have a dropdown feature.
        public void DropDown(Panel panel, int min_height, int max_height)
        {
            // x, y
            // 171, 169 -> 171, 27
            if (panel.Height == max_height)
            {
                panel.Height = min_height;
            }
            else
            {
                panel.Height = max_height;
            }
        }

    }
}
