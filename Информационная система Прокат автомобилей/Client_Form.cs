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
    public partial class Client_Form : Form
    {
        public Client_Form()
        {
            InitializeComponent();
            Program.Client_Form = this;
            Program.commander = new Commander();
            Program.commander.Load_For_client();
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

        private void Zabron_Click(object sender, EventArgs e)
        {
            if (Program.Client_Form.Tabel_auto_for_others.SelectedCells != null)
            {
                Add_Client_For_Trades add_Client = new Add_Client_For_Trades();
                add_Client.Show();
            }
            else
                MessageBox.Show("Выберите авто для бронирования");
        }

        private void Del_filters_Click(object sender, EventArgs e)
        {
            Program.commander.Load_For_client();
        }
    }
}
