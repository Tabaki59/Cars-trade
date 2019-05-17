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
    public partial class Edit_auto_fr : Form
    {
        public Edit_auto_fr()
        {
            Program.Edit_Auto_Fr = this;
            InitializeComponent();
            Program.commander = new Commander();
            Program.commander.update_for_admin();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Enter_button_Click(object sender, EventArgs e)
        {
            if (Program.Edit_Auto_Fr.Model.TextLength != 0)
            {
                Program.commander.Edit_auto();
                Program.commander.LoadAuto_for_admin();
                Close();
            }
            else
                MessageBox.Show("Введите или исправьте название модели, проверьте остальны данные");
        }

        private void Edit_auto_fr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "прокат_автоDataSet.ID_класса_автомобиля". При необходимости она может быть перемещена или удалена.
            this.iD_класса_автомобиляTableAdapter.Fill(this.прокат_автоDataSet.ID_класса_автомобиля);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "прокат_автоDataSet.ID_типа_страховки". При необходимости она может быть перемещена или удалена.
            this.iD_типа_страховкиTableAdapter.Fill(this.прокат_автоDataSet.ID_типа_страховки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "прокат_автоDataSet.ID_типа_топлива". При необходимости она может быть перемещена или удалена.
            this.iD_типа_топливаTableAdapter.Fill(this.прокат_автоDataSet.ID_типа_топлива);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "прокат_автоDataSet.ID_типа_двигателя". При необходимости она может быть перемещена или удалена.
            this.iD_типа_двигателяTableAdapter.Fill(this.прокат_автоDataSet.ID_типа_двигателя);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "прокат_автоDataSet.ID_типа_привода". При необходимости она может быть перемещена или удалена.
            this.iD_типа_приводаTableAdapter.Fill(this.прокат_автоDataSet.ID_типа_привода);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "прокат_автоDataSet.ID_типа_коробки". При необходимости она может быть перемещена или удалена.
            this.iD_типа_коробкиTableAdapter.Fill(this.прокат_автоDataSet.ID_типа_коробки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "прокат_автоDataSet.ID_типа_кузова". При необходимости она может быть перемещена или удалена.
            this.iD_типа_кузоваTableAdapter.Fill(this.прокат_автоDataSet.ID_типа_кузова);
        }
        private void model_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (!Char.IsLetter(l) && !Char.IsNumber(l) && l != '\b' && e.KeyChar != (int)Keys.Space)
            {
                e.Handled = true;
            }
        }//Проверка букв
    }
}
