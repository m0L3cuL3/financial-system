using Financial_System.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financial_System.Forms
{
    public partial class AddStudentWindow : Form
    {
        Globals gb = new Globals();
        UIHandler ui = new UIHandler();

        public AddStudentWindow()
        {
            InitializeComponent();

            ui.RoundWindow(this);
            ui.RoundButton(addStudButton);

            LoadList();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadList()
        {
            foreach (string level in gb.LevelList)
            {
                FilterComboBox.Items.Add(level);
            }
        }

        private void TopBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            ui.DragWindow(Handle, e);
        }
    }
}
