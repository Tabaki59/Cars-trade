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
    public partial class Password_form : Form
    {
        protected string Pass_employee = null;
        protected string Pass_admin = null;
        public string pass_enter = null;
        public Password_form()
        {
            InitializeComponent();
        }

        private void Otmena_Click(object sender, EventArgs e)//закрытие формы
        {
            Close();
        }

        private void Enter_button_Click(object sender, EventArgs e)//Ввод пароля, проверка его на верность

        {
            switch(Program.Entrr_fr.choose)
            {
                case 2:
                    {
                        //pass_enter = Password.Text;
                        if (pass_enter == Pass_employee)
                        {
                            Employee_Form employee = new Employee_Form();
                            employee.Show();
                            Close();
                        }
                        else
                            MessageBox.Show("Пароль введен неверно");
                    }
                    break;
                case 3:
                    {
                        //pass_enter = Password.Text;
                        if (pass_enter == Pass_admin)
                        {
                            Admin_Form admin = new Admin_Form();
                            admin.Show();
                            Close();
                        }
                        else
                            MessageBox.Show("Пароль введен неверно");
                    }
                    break;
            }
        }
    }
}
