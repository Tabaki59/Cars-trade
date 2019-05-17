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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
            Program.Search = this;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            Program.commander.Search();
            Close();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "прокат_автоDataSet.ID_типа_страховки". При необходимости она может быть перемещена или удалена.
            this.iD_типа_страховкиTableAdapter.Fill(this.прокат_автоDataSet.ID_типа_страховки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "прокат_автоDataSet.ID_класса_автомобиля". При необходимости она может быть перемещена или удалена.
            this.iD_класса_автомобиляTableAdapter.Fill(this.прокат_автоDataSet.ID_класса_автомобиля);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "прокат_автоDataSet.ID_типа_двигателя". При необходимости она может быть перемещена или удалена.
            this.iD_типа_двигателяTableAdapter.Fill(this.прокат_автоDataSet.ID_типа_двигателя);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "прокат_автоDataSet.ID_типа_топлива". При необходимости она может быть перемещена или удалена.
            this.iD_типа_топливаTableAdapter.Fill(this.прокат_автоDataSet.ID_типа_топлива);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "прокат_автоDataSet.ID_типа_привода". При необходимости она может быть перемещена или удалена.
            this.iD_типа_приводаTableAdapter.Fill(this.прокат_автоDataSet.ID_типа_привода);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "прокат_автоDataSet.ID_типа_коробки". При необходимости она может быть перемещена или удалена.
            this.iD_типа_коробкиTableAdapter.Fill(this.прокат_автоDataSet.ID_типа_коробки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "прокат_автоDataSet.ID_типа_кузова". При необходимости она может быть перемещена или удалена.
            this.iD_типа_кузоваTableAdapter.Fill(this.прокат_автоDataSet.ID_типа_кузова);
        }
    }
}
