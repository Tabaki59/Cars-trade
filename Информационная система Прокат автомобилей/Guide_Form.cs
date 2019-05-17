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
    public partial class Guide_Form : Form
    {
        public Guide_Form()
        {
            InitializeComponent();
        }

        private void Close_guide_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
