using MaterialSkin;
using MaterialSkin.Controls;
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
using Financial_System.Features;
using System.Data.SQLite;

namespace Financial_System
{

    public partial class mainWindow : MaterialForm
    {
        // Handlers
        SQLiteHandler sqlh = new SQLiteHandler();
        JournalEntry jeEntry = new JournalEntry();
        private string[] DC_LIST = { "DEBIT", "CREDIT" };


        public mainWindow()
        {
            InitializeComponent();


            LoadList();
            var msm = MaterialSkinManager.Instance;
            msm.AddFormToManage(this);
            msm.Theme = MaterialSkinManager.Themes.LIGHT;
            msm.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }


        private void mainWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadList()
        {
            for(int i = 0; i < DC_LIST.Length; i++)
            {
                debCredComboBox.Items.Add(DC_LIST[i]);
            }
        }

        private void TestBtn_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn;
            conn = sqlh.CreateConnection();
            sqlh.CreateTable(conn);
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void Insert()
        {

            switch (debCredComboBox.SelectedItem)
            {
                case "DEBIT":
                    JETable.Rows.Add(dateTextBox.Text, accountsComboBox.SelectedItem.ToString(), descTextbox.Text, refTypeComboBox.SelectedItem.ToString(), valueTextBox.Text, null);
                    break;
                case "CREDIT":
                    JETable.Rows.Add(dateTextBox.Text, accountsComboBox.SelectedItem.ToString(), descTextbox.Text, refTypeComboBox.SelectedItem.ToString(), null, valueTextBox.Text);
                    break;
                default:
                    break;
            }
            RefreshData();
        }

        private void Delete()
        {
            foreach (DataGridViewRow row in JETable.SelectedRows)
            {
                JETable.Rows.RemoveAt(row.Index);
            }

            RefreshData();
        }

        private void RefreshData()
        {
            jeEntry.GetDebitTotal(JETable, totalLbl);
            jeEntry.GetCreditTotal(JETable, creditLbl);
            jeEntry.BalanceTotal(JETable, balanceLbl);
        }
    }
}
