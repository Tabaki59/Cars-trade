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
    public partial class Enter_Form : Form
    {
        public int choose = 0;
        public Enter_Form()
        {
            Program.Entrr_fr = this;
            InitializeComponent();
        }

        private void Guide_Click(object sender, EventArgs e)
        {
            Guide_Form guide_ = new Guide_Form();
            guide_.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Client_Enter_Click(object sender, EventArgs e)//Вход как клиент
        {
            choose = 1;
            Client_Form Client = new Client_Form();
            Client.Show();
        }

        private void Sot_Enter_Click(object sender, EventArgs e)//Вход как сотрудник
        {
            choose = 2;
            Password_form pass = new Password_form();
            pass.Show();
        }

        private void Admin_enter_Click(object sender, EventArgs e)//Вход как администратор
        {
            choose = 3;
            Password_form pass = new Password_form();
            pass.Show();
        }
    }
}
