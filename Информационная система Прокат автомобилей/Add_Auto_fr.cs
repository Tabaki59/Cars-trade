using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Информационная_система_Прокат_автомобилей
{
    public partial class Add_Auto_fr : Form
    {
        public Add_Auto_fr()
        {
            InitializeComponent();
            Program.add_Auto_Fr = this;
            Program.commander = new Commander();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Enter_button_Click(object sender, EventArgs e)
        {
            Program.commander.myConnection.Open();
            SqlCommand com = new SqlCommand("SELECT Cars.[Госномер] FROM Cars", Program.commander.myConnection);
            SqlDataReader reader = com.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[1]);

                data[data.Count - 1][0] = reader[0].ToString();
            }
            bool check = false;
            foreach (string[] s in data)
            {
                if (s.Contains(Program.add_Auto_Fr.Gosnomer.Text))
                {
                    MessageBox.Show("Авто с таким госномером уже есть");
                    check = true;
                }
            }//Проверяем наличие добавляемого номера ибо ай яй яй вводить такойже ключ
            Program.commander.myConnection.Close();
            if (Program.commander.Check_add_auto()&&check==false)
            {
                Program.commander.Add_auto();
                Program.commander.LoadAuto_for_admin();
                Close();
            }
            else
            {
                MessageBox.Show("Вы ввели данные неверно или не полностью или авто с таким госномером уже существует");
            }
        }

        private void Add_Auto_fr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "прокат_автоDataSet.ID_класса_автомобиля". При необходимости она может быть перемещена или удалена.
            this.iD_класса_автомобиляTableAdapter.Fill(this.прокат_автоDataSet.ID_класса_автомобиля);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "прокат_автоDataSet.ID_типа_страховки". При необходимости она может быть перемещена или удалена.
            this.iD_типа_страховкиTableAdapter.Fill(this.прокат_автоDataSet.ID_типа_страховки);
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
        private void Gosnomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((!Char.IsDigit(l) && l != 8)&& (l < 'А' || l > 'я') && l != '\b') // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
        private void model_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (!Char.IsLetter(l)&& !Char.IsNumber(l) && l != '\b' && e.KeyChar != (int)Keys.Space)
            {
                e.Handled = true;
            }
        }//Проверка букв
    }
}
