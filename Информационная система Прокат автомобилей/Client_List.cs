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
    public partial class Client_List : Form
    {
        public Client_List()
        {
            InitializeComponent();
            Program.Client_List = this;
            Program.commander = new Commander();
            Program.commander.Load_Clients_List();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
