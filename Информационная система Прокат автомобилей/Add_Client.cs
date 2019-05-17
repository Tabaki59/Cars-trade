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
    public partial class Add_Client_For_Trades : Form
    {
        public Add_Client_For_Trades()
        {
            InitializeComponent();
            Program.Add_Client_For_Trades = this;
            Program.commander = new Commander();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Enter_button_Click(object sender, EventArgs e)
        {
            switch(Program.Entrr_fr.choose)

            {
                case 1:
                    if (Program.commander.Check_add_Client())
                    {
                        Program.commander.myConnection.Open();
                        SqlCommand com = new SqlCommand("SELECT Clients.[Номер и серия паспорта] FROM Clients", Program.commander.myConnection);
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
                            if (s.Contains(Program.Add_Client_For_Trades.Pasport.Text))
                            {
                                check = true;
                            }
                        }//Проверяем наличие добавляемого номера ибо ай яй яй вводить такойже ключ
                        Program.commander.myConnection.Close();
                        if (check == false)
                        {
                            Program.commander.Create_trade_Сlient_not_exist();
                            Program.commander.Load_For_client();
                            Close();
                        }
                        else
                        {
                            Program.commander.Create_trade_Сlient_exist();
                            Program.commander.Load_For_client();
                            Close();
                        }
                    }
                    else
                        MessageBox.Show("Вы ввели данные неверно или не полностью");
                    break;
                case 2:
                    if (Program.commander.Check_add_Client())
                    {
                        Program.commander.myConnection.Open();
                        SqlCommand com = new SqlCommand("SELECT Clients.[Номер и серия паспорта] FROM Clients", Program.commander.myConnection);
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
                            if (s.Contains(Program.Add_Client_For_Trades.Pasport.Text))
                            {
                                check = true;
                            }
                        }//Проверяем наличие добавляемого номера ибо ай яй яй вводить такойже ключ
                        Program.commander.myConnection.Close();
                        if (check == false)
                        {
                            Program.commander.Create_trade_Сlient_not_exist();
                            Program.commander.Load_For_employee();
                            Close();
                        }
                        else
                        {
                            Program.commander.Create_trade_Сlient_exist();
                            Program.commander.Load_For_employee();
                            Close();
                        }
                    }
                    else
                        MessageBox.Show("Вы ввели данные неверно или не полностью");
                    break;
            }
        }
        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && e.KeyChar != (int)Keys.Space)
            {
                e.Handled = true;
            }
        }//Проверка букв
        private void number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }//Проверка на ввод цифр
    }
}
