using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Информационная_система_Прокат_автомобилей
{
    public partial class Employee_Form : Form
    {
        public Employee_Form()
        {
            InitializeComponent();
            Program.Employee_Form = this;
            Program.commander = new Commander();
            Program.commander.Load_For_employee();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Sprav_button_Click(object sender, EventArgs e)
        {
            Guide_Form guide_ = new Guide_Form();
            guide_.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
        }

        private void Open_List_Click(object sender, EventArgs e)
        {
            SalesTable sales = new SalesTable();
            sales.Show();
        }

        private void Automobl_Click(object sender, EventArgs e)
        {
            if (Program.Employee_Form.Tabel_auto_for_others.SelectedCells != null)
            {
                Add_Client_For_Trades add_Client = new Add_Client_For_Trades();
                add_Client.Show();
            }
            else
                MessageBox.Show("Выберите авто для выдачи");
        }

        private void Del_filters_Click(object sender, EventArgs e)
        {
            Program.commander.Load_For_employee();
        }

        private void Confirm_trade_Click(object sender, EventArgs e)
        {
            Program.commander.confirm_trade();
            Program.commander.Load_For_employee();
        }

        private void Otmena_trade_Click(object sender, EventArgs e)
        {
            Program.commander.otmenatrade();
            Program.commander.Load_For_employee();
        }
    }
}
