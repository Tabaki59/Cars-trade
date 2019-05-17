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
    public partial class SalesTable : Form
    {
        public SalesTable()
        {
            InitializeComponent();
            Program.SalesTable = this;
            Program.commander = new Commander();
            Program.commander.load_open_trades();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void End_sale_Click(object sender, EventArgs e)
        {
            Program.commander.end_trade();
            Program.commander.load_open_trades();
        }
    }
}
