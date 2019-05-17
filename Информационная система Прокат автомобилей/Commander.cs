using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Информационная_система_Прокат_автомобилей
{
    public class Commander
    {
        public Commander() => Program.commander = this;
        public SqlConnection myConnection = new SqlConnection(@"Data Source=COMPUTER;Initial Catalog=" + "Прокат авто" + ";Integrated Security=True");
        public List<string[]> data = new List<string[]>();
        public void LoadAuto_for_admin()//Выгрузка для админа
        {

            Program.Admin_Form.Tabel_auto_for_admin.Rows.Clear();
            myConnection.Open();
            SqlCommand com = new SqlCommand("SELECT Cars.[Госномер], Cars.Модель, [ID типа кузова].[Тип кузова], [ID типа коробки].[тип коробки], [ID типа привода].[Тип привода], Cars.[Объем двигателя], Cars.[Расход на 100 км], [ID состояния авто].[Состояние авто], Cars.[Год выпуска], Cars.[Количество мест], Cars.[Вместимость багажника], [ID типа топлива].[Тип топлива], [ID типа страховки].[Тип страховки], Cars.[Цена за сутки], [ID типа двигателя].[Тип двигателя], [ID класса автомобиля].[Класс автомобиля]" +
            "FROM[ID типа топлива] INNER JOIN([ID типа страховки] INNER JOIN([ID типа кузова] INNER JOIN([ID типа коробки] INNER JOIN([ID типа двигателя] INNER JOIN([ID состояния авто] INNER JOIN([ID типа привода] INNER JOIN([ID класса автомобиля] INNER JOIN Cars ON[ID класса автомобиля].[ID класса автомобиля] = Cars.[ID класса автомобиля]) ON[ID типа привода].[ID типа привода] = Cars.[ID типа привода]) ON[ID состояния авто].[ID состояния авто] = Cars.[ID состояния авто]) ON[ID типа двигателя].[ID типа двигателя] = Cars.[ID типа двигателя]) ON[ID типа коробки].[ID типа коробки] = Cars.[ID типа коробки]) ON[ID типа кузова].[ID Типа кузова] = Cars.[ID типа кузова]) ON[ID типа страховки].[ID типа страховки] = Cars.[ID типа страховки]) ON[ID типа топлива].[ID типа топлива] = Cars.[ID типа топлива]", myConnection);
            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                data.Add(new string[16]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();

                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();

                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();

                data[data.Count - 1][9] = reader[9].ToString();
                data[data.Count - 1][10] = reader[10].ToString();
                data[data.Count - 1][11] = reader[11].ToString();

                data[data.Count - 1][12] = reader[12].ToString();
                data[data.Count - 1][13] = reader[13].ToString();
                data[data.Count - 1][14] = reader[14].ToString();

                data[data.Count - 1][15] = reader[15].ToString();
            }

            reader.Close();

            myConnection.Close();

            foreach (string[] s in data)
                Program.Admin_Form.Tabel_auto_for_admin.Rows.Add(s);
            data.Clear();
        }
        public void Add_auto()//Добавление авто
        {
            myConnection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Cars(Госномер, Модель, [ID типа кузова], [ID типа коробки], [ID типа привода], [Объем двигателя], [Расход на 100 км], [ID состояния авто], [Год выпуска], [Количество мест], [Вместимость багажника], [ID типа топлива], [ID типа страховки], [Цена за сутки], [ID типа двигателя], [ID класса автомобиля])" +
                "VALUES(N'" + Program.add_Auto_Fr.Gosnomer.Text + "',N'" + Program.add_Auto_Fr.Model.Text + "','" + Program.add_Auto_Fr.Type_Cuzov.SelectedValue + "','" + Program.add_Auto_Fr.Type_KPP.SelectedValue + "','" + Program.add_Auto_Fr.Type_Privod.SelectedValue + "','" + Program.add_Auto_Fr.Engine_obyom.Value + "','" + Program.add_Auto_Fr.Rashod.Value + "','" + 1 + "','" + Program.add_Auto_Fr.Year.Value + "','" + Program.add_Auto_Fr.Places_for_pass.Value + "','" + Program.add_Auto_Fr.Bagage.Value + "','" + Program.add_Auto_Fr.Oil.SelectedValue + "','" + Program.add_Auto_Fr.Strahovka.SelectedValue + "','" + Program.add_Auto_Fr.Price.Value + "','" + Program.add_Auto_Fr.Engine_type.SelectedValue + "','" + Program.add_Auto_Fr.Type_auto.SelectedValue + "')", myConnection);
            command.ExecuteNonQuery();
            myConnection.Close();
        }
        public void Edit_auto()//Редактирование авто
        {
            myConnection.Open();
            SqlCommand command = new SqlCommand("UPDATE Cars SET "+
                    "Cars.[Модель] = '" + Program.Edit_Auto_Fr.Model.Text + "', "+
                    "Cars.[ID типа кузова] = '" + Program.Edit_Auto_Fr.Type_Cuzov.SelectedValue + "', " +
                    "Cars.[ID типа коробки] = '" + Program.Edit_Auto_Fr.Type_KPP.SelectedValue + "', " +
                    "Cars.[ID типа привода] = '" + Program.Edit_Auto_Fr.Type_Privod.SelectedValue + "', " +
                    "Cars.[Объем двигателя] = '" + Program.Edit_Auto_Fr.Engine_obyom.Value + "', " +
                    "Cars.[Расход на 100 км] = '" + Program.Edit_Auto_Fr.Rashod.Value + "', " +
                    "Cars.[Год выпуска] = '" + Program.Edit_Auto_Fr.Year.Value + "', " +
                    "Cars.[Количество мест] = '" + Program.Edit_Auto_Fr.Places_for_pass.Value + "', " +
                    "Cars.[Вместимость багажника] = '" + Program.Edit_Auto_Fr.Bagage.Value + "', " +
                    "Cars.[ID типа топлива] = '" + Program.Edit_Auto_Fr.Oil.SelectedValue + "', " +
                    "Cars.[ID типа страховки] = '" + Program.Edit_Auto_Fr.Strahovka.SelectedValue + "', " +
                    "Cars.[Цена за сутки] = '" + Program.Edit_Auto_Fr.Price.Value + "', " +
                    "Cars.[ID типа двигателя] = '" + Program.Edit_Auto_Fr.Engine_type.SelectedValue + "', " +
                    "Cars.[ID класса автомобиля] = '" + Program.Edit_Auto_Fr.Type_auto.SelectedValue + "'"+
                    "WHERE Cars.[Госномер]= '"+Program.Admin_Form.Tabel_auto_for_admin[0, Program.Admin_Form.Tabel_auto_for_admin.CurrentRow.Index].Value+"'", myConnection);
            command.ExecuteNonQuery();
            myConnection.Close();
        }
        public void Delete_auto()//Удаление авто
        {
            myConnection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM Cars WHERE Cars.Госномер='" + Program.Admin_Form.Tabel_auto_for_admin[0, Program.Admin_Form.Tabel_auto_for_admin.CurrentRow.Index].Value.ToString() + "'", myConnection);
            command.ExecuteNonQuery();
            myConnection.Close();
        }
        public void update_for_admin()//Вывод данных об изменяемом авто
        {
            Program.Edit_Auto_Fr.Gosnomer_old.Text = Program.Admin_Form.Tabel_auto_for_admin[0, Program.Admin_Form.Tabel_auto_for_admin.CurrentRow.Index].Value.ToString();
            Program.Edit_Auto_Fr.Model_old.Text = Program.Admin_Form.Tabel_auto_for_admin[1, Program.Admin_Form.Tabel_auto_for_admin.CurrentRow.Index].Value.ToString();
            Program.Edit_Auto_Fr.Kyzov_old.Text = Program.Admin_Form.Tabel_auto_for_admin[2, Program.Admin_Form.Tabel_auto_for_admin.CurrentRow.Index].Value.ToString();
            Program.Edit_Auto_Fr.KPP_old.Text = Program.Admin_Form.Tabel_auto_for_admin[3, Program.Admin_Form.Tabel_auto_for_admin.CurrentRow.Index].Value.ToString();
            Program.Edit_Auto_Fr.Privod_old.Text = Program.Admin_Form.Tabel_auto_for_admin[4, Program.Admin_Form.Tabel_auto_for_admin.CurrentRow.Index].Value.ToString();
            Program.Edit_Auto_Fr.Engine_obyom_old.Text = Program.Admin_Form.Tabel_auto_for_admin[5, Program.Admin_Form.Tabel_auto_for_admin.CurrentRow.Index].Value.ToString();
            Program.Edit_Auto_Fr.Rashod_old.Text = Program.Admin_Form.Tabel_auto_for_admin[6, Program.Admin_Form.Tabel_auto_for_admin.CurrentRow.Index].Value.ToString();
            Program.Edit_Auto_Fr.Year_old.Text = Program.Admin_Form.Tabel_auto_for_admin[8, Program.Admin_Form.Tabel_auto_for_admin.CurrentRow.Index].Value.ToString();
            Program.Edit_Auto_Fr.Places_old.Text = Program.Admin_Form.Tabel_auto_for_admin[9, Program.Admin_Form.Tabel_auto_for_admin.CurrentRow.Index].Value.ToString();
            Program.Edit_Auto_Fr.Bagage_old.Text = Program.Admin_Form.Tabel_auto_for_admin[10, Program.Admin_Form.Tabel_auto_for_admin.CurrentRow.Index].Value.ToString();
            Program.Edit_Auto_Fr.Type_Oil_old.Text = Program.Admin_Form.Tabel_auto_for_admin[11, Program.Admin_Form.Tabel_auto_for_admin.CurrentRow.Index].Value.ToString();
            Program.Edit_Auto_Fr.Strahovka_old.Text = Program.Admin_Form.Tabel_auto_for_admin[12, Program.Admin_Form.Tabel_auto_for_admin.CurrentRow.Index].Value.ToString();
            Program.Edit_Auto_Fr.Price_old.Text = Program.Admin_Form.Tabel_auto_for_admin[13, Program.Admin_Form.Tabel_auto_for_admin.CurrentRow.Index].Value.ToString();
            Program.Edit_Auto_Fr.Engine_type_old.Text = Program.Admin_Form.Tabel_auto_for_admin[14, Program.Admin_Form.Tabel_auto_for_admin.CurrentRow.Index].Value.ToString();
            Program.Edit_Auto_Fr.Auto_type_old.Text = Program.Admin_Form.Tabel_auto_for_admin[15, Program.Admin_Form.Tabel_auto_for_admin.CurrentRow.Index].Value.ToString();
        }
        public bool Check_add_auto()//Проверка данных при вводе авто
        {
            if (Program.add_Auto_Fr.Gosnomer.TextLength == 0 || Program.add_Auto_Fr.Gosnomer.TextLength < 9 || Program.add_Auto_Fr.Model.TextLength == 0)
                return false;
            else
                return true;
        }
        public bool Check_add_Client()//Проверка полей для клиента
        {
            if (Program.Add_Client_For_Trades.Pasport.TextLength == 0 || Program.Add_Client_For_Trades.Pasport.TextLength < 10 || Program.Add_Client_For_Trades.Phone.TextLength == 0 || Program.Add_Client_For_Trades.Phone.TextLength < 11 || Program.Add_Client_For_Trades.FIO.TextLength == 0)
                return false;
            else
                return true;
        }
        public void Load_For_client()//Выгрузка для клиента 
        {
            Program.Client_Form.Tabel_auto_for_others.Rows.Clear();
            myConnection.Open();
            SqlCommand com = new SqlCommand("SELECT Cars.[Госномер], Cars.Модель, [ID типа кузова].[Тип кузова], [ID типа коробки].[тип коробки], [ID типа привода].[Тип привода], Cars.[Объем двигателя], Cars.[Расход на 100 км], [ID состояния авто].[Состояние авто], Cars.[Год выпуска], Cars.[Количество мест], Cars.[Вместимость багажника], [ID типа топлива].[Тип топлива], [ID типа страховки].[Тип страховки], Cars.[Цена за сутки], [ID типа двигателя].[Тип двигателя], [ID класса автомобиля].[Класс автомобиля]" +
            "FROM[ID типа топлива] INNER JOIN([ID типа страховки] INNER JOIN([ID типа кузова] INNER JOIN([ID типа коробки] INNER JOIN([ID типа двигателя] INNER JOIN([ID состояния авто] INNER JOIN([ID типа привода] INNER JOIN([ID класса автомобиля] INNER JOIN Cars ON[ID класса автомобиля].[ID класса автомобиля] = Cars.[ID класса автомобиля]) ON[ID типа привода].[ID типа привода] = Cars.[ID типа привода]) ON[ID состояния авто].[ID состояния авто] = Cars.[ID состояния авто]) ON[ID типа двигателя].[ID типа двигателя] = Cars.[ID типа двигателя]) ON[ID типа коробки].[ID типа коробки] = Cars.[ID типа коробки]) ON[ID типа кузова].[ID Типа кузова] = Cars.[ID типа кузова]) ON[ID типа страховки].[ID типа страховки] = Cars.[ID типа страховки]) ON[ID типа топлива].[ID типа топлива] = Cars.[ID типа топлива]"+
            "WHERE Cars.[ID состояния авто] = 1",myConnection);
            SqlDataReader reader = com.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[16]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();

                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();

                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();

                data[data.Count - 1][9] = reader[9].ToString();
                data[data.Count - 1][10] = reader[10].ToString();
                data[data.Count - 1][11] = reader[11].ToString();

                data[data.Count - 1][12] = reader[12].ToString();
                data[data.Count - 1][13] = reader[13].ToString();
                data[data.Count - 1][14] = reader[14].ToString();

                data[data.Count - 1][15] = reader[15].ToString();
            }

            reader.Close();

            myConnection.Close();
            
            foreach (string[] s in data)
                Program.Client_Form.Tabel_auto_for_others.Rows.Add(s);
        }
        public void Load_For_employee()//Выгрузка для сотрудника
        {
            Program.Employee_Form.Tabel_auto_for_others.Rows.Clear();
            Program.Employee_Form.Rent_Table.Rows.Clear();
            myConnection.Open();
            SqlCommand com = new SqlCommand("SELECT Cars.[Госномер], Cars.Модель, [ID типа кузова].[Тип кузова], [ID типа коробки].[тип коробки], [ID типа привода].[Тип привода], Cars.[Объем двигателя], Cars.[Расход на 100 км], [ID состояния авто].[Состояние авто], Cars.[Год выпуска], Cars.[Количество мест], Cars.[Вместимость багажника], [ID типа топлива].[Тип топлива], [ID типа страховки].[Тип страховки], Cars.[Цена за сутки], [ID типа двигателя].[Тип двигателя], [ID класса автомобиля].[Класс автомобиля]" +
            "FROM[ID типа топлива] INNER JOIN([ID типа страховки] INNER JOIN([ID типа кузова] INNER JOIN([ID типа коробки] INNER JOIN([ID типа двигателя] INNER JOIN([ID состояния авто] INNER JOIN([ID типа привода] INNER JOIN([ID класса автомобиля] INNER JOIN Cars ON[ID класса автомобиля].[ID класса автомобиля] = Cars.[ID класса автомобиля]) ON[ID типа привода].[ID типа привода] = Cars.[ID типа привода]) ON[ID состояния авто].[ID состояния авто] = Cars.[ID состояния авто]) ON[ID типа двигателя].[ID типа двигателя] = Cars.[ID типа двигателя]) ON[ID типа коробки].[ID типа коробки] = Cars.[ID типа коробки]) ON[ID типа кузова].[ID Типа кузова] = Cars.[ID типа кузова]) ON[ID типа страховки].[ID типа страховки] = Cars.[ID типа страховки]) ON[ID типа топлива].[ID типа топлива] = Cars.[ID типа топлива]" +
            "WHERE Cars.[ID состояния авто] = 1", myConnection);
            SqlDataReader reader = com.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[16]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();

                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();

                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();

                data[data.Count - 1][9] = reader[9].ToString();
                data[data.Count - 1][10] = reader[10].ToString();
                data[data.Count - 1][11] = reader[11].ToString();

                data[data.Count - 1][12] = reader[12].ToString();
                data[data.Count - 1][13] = reader[13].ToString();
                data[data.Count - 1][14] = reader[14].ToString();

                data[data.Count - 1][15] = reader[15].ToString();
            }

            reader.Close();

            foreach (string[] s in data)
                Program.Employee_Form.Tabel_auto_for_others.Rows.Add(s);

          
            SqlCommand com1 = new SqlCommand("SELECT Trades.[Номер сделки], Trades.[Госномер], Trades.[Номер и серия паспорта], [ID статуса сделки].[Статус сделки], Trades.[Срок сделки], Trades.[Сумма сделки]" +
            "FROM[ID статуса сделки] INNER JOIN Trades ON[ID статуса сделки].[ID статуса сделки] = Trades.[ID статуса сделки] " +
            "WHERE Trades.[ID статуса сделки] = 2", myConnection);
            SqlDataReader reader1 = com1.ExecuteReader();

            List<string[]> data1 = new List<string[]>();

            while (reader1.Read())
            {
                data1.Add(new string[6]);

                data1[data1.Count - 1][0] = reader1[0].ToString();
                data1[data1.Count - 1][1] = reader1[1].ToString();
                data1[data1.Count - 1][2] = reader1[2].ToString();

                data1[data1.Count - 1][3] = reader1[3].ToString();
                data1[data1.Count - 1][4] = reader1[4].ToString();
                data1[data1.Count - 1][5] = reader1[5].ToString();
            }

            reader1.Close();

            myConnection.Close();

            foreach (string[] s in data1)
                Program.Employee_Form.Rent_Table.Rows.Add(s);
        }
        public void Load_Clients_List()//Выгрузка списка клиентов
        {
            myConnection.Open();
            SqlCommand com = new SqlCommand("SELECT * FROM Clients", myConnection);
            SqlDataReader reader = com.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }

            reader.Close();

            myConnection.Close();

            foreach (string[] s in data)
                Program.Client_List.Client_lists.Rows.Add(s);
        }
        public void Search ()//Запрос на поиск
        {
            switch(Program.Entrr_fr.choose)
            {
                case 1:
                    Program.Client_Form.Tabel_auto_for_others.Rows.Clear();
                    myConnection.Open();
                    SqlCommand com1 = new SqlCommand("SELECT * FROM Cars WHERE " +
                    "Cars.[Госномер] IS NOT NULL AND " +
                    "Cars.[Модель] IS NOT NULL AND " +
                    "Cars.[ID типа кузова] = '" + Program.Search.Type_Cuzov.SelectedValue + "'AND " +
                    "Cars.[ID типа коробки] = '" + Program.Search.Type_KPP.SelectedValue + "'AND " +
                    "Cars.[ID типа привода] = '" + Program.Search.Type_Privod.SelectedValue + "'AND " +
                    "Cars.[Объем двигателя] >= '" + Program.Search.Engine_obyom.Value + "'AND " +
                    "Cars.[Расход на 100 км] <= '" + Program.Search.Rashod.Value + "'AND " +
                    "Cars.[ID состояния авто] = 1 AND " +
                    "Cars.[Год выпуска] >= '" + Program.Search.Year.Value + "'AND " +
                    "Cars.[Количество мест] >= '" + Program.Search.Places_for_pass.Value + "'AND " +
                    "Cars.[Вместимость багажника] >= '" + Program.Search.Bagage.Value + "'AND " +
                    "Cars.[ID типа топлива] = '" + Program.Search.Oil.SelectedValue + "'AND " +
                    "Cars.[ID типа страховки] = '" + Program.Search.Strahovka.SelectedValue + "'AND " +
                    "Cars.[Цена за сутки] <= '" + Program.Search.Price.Value + "'AND " +
                    "Cars.[ID типа двигателя] = '" + Program.Search.Engine_type.SelectedValue + "'AND " +
                    "Cars.[ID класса автомобиля] = '" + Program.Search.Type_auto.SelectedValue + "'", myConnection);
                    SqlDataReader reader1 = com1.ExecuteReader();

                    while (reader1.Read())
                    {
                        data.Add(new string[16]);

                        data[data.Count - 1][0] = reader1[0].ToString();
                        data[data.Count - 1][1] = reader1[1].ToString();
                        data[data.Count - 1][2] = reader1[2].ToString();

                        data[data.Count - 1][3] = reader1[3].ToString();
                        data[data.Count - 1][4] = reader1[4].ToString();
                        data[data.Count - 1][5] = reader1[5].ToString();

                        data[data.Count - 1][6] = reader1[6].ToString();
                        data[data.Count - 1][7] = reader1[7].ToString();
                        data[data.Count - 1][8] = reader1[8].ToString();

                        data[data.Count - 1][9] = reader1[9].ToString();
                        data[data.Count - 1][10] = reader1[10].ToString();
                        data[data.Count - 1][11] = reader1[11].ToString();

                        data[data.Count - 1][12] = reader1[12].ToString();
                        data[data.Count - 1][13] = reader1[13].ToString();
                        data[data.Count - 1][14] = reader1[14].ToString();

                        data[data.Count - 1][15] = reader1[15].ToString();
                    }
                    reader1.Close();
                    myConnection.Close();
                        foreach (string[] s in data)
                            Program.Client_Form.Tabel_auto_for_others.Rows.Add(s);
                    data.Clear();
                    break;//Выгрузка в форму клиента
                case 2:
                    Program.Employee_Form.Tabel_auto_for_others.Rows.Clear();
                    myConnection.Open();
                    SqlCommand com2 = new SqlCommand("SELECT SELECT * FROM Cars WHERE " +
                    "Cars.[Госномер] IS NOT NULL AND " +
                    "Cars.[Модель] IS NOT NULL AND " +
                    "Cars.[ID типа кузова] = '" + Program.Search.Type_Cuzov.SelectedValue + "'AND " +
                    "Cars.[ID типа коробки] = '" + Program.Search.Type_KPP.SelectedValue + "'AND " +
                    "Cars.[ID типа привода] = '" + Program.Search.Type_Privod.SelectedValue + "'AND " +
                    "Cars.[Объем двигателя] >= '" + Program.Search.Engine_obyom.Value + "'AND " +
                    "Cars.[Расход на 100 км] <= '" + Program.Search.Rashod.Value + "'AND " +
                    "Cars.[ID состояния авто] = 1 AND" +
                    "Cars.[Год выпуска] >= '" + Program.Search.Year.Value + "'AND " +
                    "Cars.[Количество мест] >= '" + Program.Search.Places_for_pass.Value + "'AND " +
                    "Cars.[Вместимость багажника] >= '" + Program.Search.Bagage.Value + "'AND " +
                    "Cars.[ID типа топлива] = '" + Program.Search.Oil.SelectedValue + "'AND " +
                    "Cars.[ID типа страховки] = '" + Program.Search.Strahovka.SelectedValue + "'AND " +
                    "Cars.[Цена за сутки] <= '" + Program.Search.Price.Value + "'AND " +
                    "Cars.[ID типа двигателя] = '" + Program.Search.Engine_type.SelectedValue + "'AND " +
                    "Cars.[ID класса автомобиля] = '" + Program.Search.Type_auto.SelectedValue + "'", myConnection);
                    SqlDataReader reader2 = com2.ExecuteReader();

                    while (reader2.Read())
                    {
                        data.Add(new string[16]);

                        data[data.Count - 1][0] = reader2[0].ToString();
                        data[data.Count - 1][1] = reader2[1].ToString();
                        data[data.Count - 1][2] = reader2[2].ToString();

                        data[data.Count - 1][3] = reader2[3].ToString();
                        data[data.Count - 1][4] = reader2[4].ToString();
                        data[data.Count - 1][5] = reader2[5].ToString();

                        data[data.Count - 1][6] = reader2[6].ToString();
                        data[data.Count - 1][7] = reader2[7].ToString();
                        data[data.Count - 1][8] = reader2[8].ToString();

                        data[data.Count - 1][9] = reader2[9].ToString();
                        data[data.Count - 1][10] = reader2[10].ToString();
                        data[data.Count - 1][11] = reader2[11].ToString();

                        data[data.Count - 1][12] = reader2[12].ToString();
                        data[data.Count - 1][13] = reader2[13].ToString();
                        data[data.Count - 1][14] = reader2[14].ToString();

                        data[data.Count - 1][15] = reader2[15].ToString();
                    }
                    reader2.Close();
                    myConnection.Close();
                    foreach (string[] s in data)
                        Program.Employee_Form.Tabel_auto_for_others.Rows.Add(s);
                    data.Clear();
                    break;//Выгрузка в форму сотрудника
                case 3:
                    Program.Admin_Form.Tabel_auto_for_admin.Rows.Clear();
                    myConnection.Open();
                    SqlCommand com = new SqlCommand("SELECT * FROM Cars WHERE " +
                    "Cars.[Госномер] IS NOT NULL AND " +
                    "Cars.[Модель] IS NOT NULL AND " +
                    "Cars.[ID типа кузова] = '" + Program.Search.Type_Cuzov.SelectedValue + "'AND " +
                    "Cars.[ID типа коробки] = '" + Program.Search.Type_KPP.SelectedValue + "'AND " +
                    "Cars.[ID типа привода] = '" + Program.Search.Type_Privod.SelectedValue + "'AND " +
                    "Cars.[Объем двигателя] >= '" + Program.Search.Engine_obyom.Value + "'AND " +
                    "Cars.[Расход на 100 км] <= '" + Program.Search.Rashod.Value + "'AND " +
                    "Cars.[ID состояния авто] IS NOT NULL AND " +
                    "Cars.[Год выпуска] >= '" + Program.Search.Year.Value + "'AND " +
                    "Cars.[Количество мест] >= '" + Program.Search.Places_for_pass.Value + "'AND " +
                    "Cars.[Вместимость багажника] >= '" + Program.Search.Bagage.Value + "'AND " +
                    "Cars.[ID типа топлива] = '" + Program.Search.Oil.SelectedValue + "'AND " +
                    "Cars.[ID типа страховки] = '" + Program.Search.Strahovka.SelectedValue + "'AND " +
                    "Cars.[Цена за сутки] <= '" + Program.Search.Price.Value + "'AND " +
                    "Cars.[ID типа двигателя] = '" + Program.Search.Engine_type.SelectedValue + "'AND " +
                    "Cars.[ID класса автомобиля] = '" + Program.Search.Type_auto.SelectedValue + "'", myConnection);
                    SqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        data.Add(new string[16]);

                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();

                        data[data.Count - 1][3] = reader[3].ToString();
                        data[data.Count - 1][4] = reader[4].ToString();
                        data[data.Count - 1][5] = reader[5].ToString();

                        data[data.Count - 1][6] = reader[6].ToString();
                        data[data.Count - 1][7] = reader[7].ToString();
                        data[data.Count - 1][8] = reader[8].ToString();

                        data[data.Count - 1][9] = reader[9].ToString();
                        data[data.Count - 1][10] = reader[10].ToString();
                        data[data.Count - 1][11] = reader[11].ToString();

                        data[data.Count - 1][12] = reader[12].ToString();
                        data[data.Count - 1][13] = reader[13].ToString();
                        data[data.Count - 1][14] = reader[14].ToString();

                        data[data.Count - 1][15] = reader[15].ToString();
                    }
                    reader.Close();
                    myConnection.Close();
                    foreach (string[] s in data)
                        Program.Admin_Form.Tabel_auto_for_admin.Rows.Add(s);
                    data.Clear();
                    break;//Выгрузка в форму админа
            }
        }
        public void Create_trade_Сlient_not_exist()//Создание сделки для клиента не в базе
        {
            switch (Program.Entrr_fr.choose)

            {
                case 1://Ввод со стороны клиента
                    myConnection.Open();
                    SqlCommand client = new SqlCommand("INSERT INTO Clients([Номер и серия паспорта], [ФИО], [Номер телефона])" +
                        "VALUES('" + Program.Add_Client_For_Trades.Pasport.Text + "','" + Program.Add_Client_For_Trades.FIO.Text + "','" + Program.Add_Client_For_Trades.Phone.Text + "')", myConnection);
                    client.ExecuteNonQuery();
                    var price = Convert.ToInt32(Program.Client_Form.Tabel_auto_for_others[13, Program.Client_Form.Tabel_auto_for_others.CurrentRow.Index].Value.ToString());
                    var day = Convert.ToInt32(Program.Add_Client_For_Trades.Days.Value.ToString());
                    int sum = day * price;
                    SqlCommand num_trade = new SqlCommand("SELECT MAX ([Номер сделки]) FROM Trades", myConnection);
                    var num = Convert.ToInt16(num_trade.ExecuteScalar())+1;
                    SqlCommand trade = new SqlCommand("INSERT INTO Trades([Номер сделки],[Госномер],[Номер и серия паспорта],[ID статуса сделки],[Срок сделки],[Сумма сделки])" +
                        "VALUES ('"+num+"','" + Program.Client_Form.Tabel_auto_for_others[0, Program.Client_Form.Tabel_auto_for_others.CurrentRow.Index].Value + "','" + Program.Add_Client_For_Trades.Pasport.Text + "',2,'" + Program.Add_Client_For_Trades.Days.Value + "','" + sum + "')", myConnection);
                    trade.ExecuteNonQuery();
                    SqlCommand car = new SqlCommand("UPDATE Cars SET " +
                    "Cars.[ID состояния авто] = 2 " +
                    "WHERE Cars.[Госномер]= '" + Program.Client_Form.Tabel_auto_for_others[0, Program.Client_Form.Tabel_auto_for_others.CurrentRow.Index].Value + "'", myConnection);
                    car.ExecuteNonQuery();
                    myConnection.Close();
                    break;
                case 2://Ввод со стороны сотрудника
                    myConnection.Open();
                    SqlCommand client1 = new SqlCommand("INSERT INTO Clients([Номер и серия паспорта], [ФИО], [Номер телефона])" +
                        "VALUES('" + Program.Add_Client_For_Trades.Pasport.Text + "','" + Program.Add_Client_For_Trades.FIO.Text + "','" + Program.Add_Client_For_Trades.Phone.Text + "')", myConnection);
                    client1.ExecuteNonQuery();
                    var price1 = Convert.ToInt32(Program.Employee_Form.Tabel_auto_for_others[13, Program.Employee_Form.Tabel_auto_for_others.CurrentRow.Index].Value.ToString());
                    var day1 = Convert.ToInt32(Program.Add_Client_For_Trades.Days.Value.ToString());
                    int sum1= day1 * price1;
                    SqlCommand num_trade1 = new SqlCommand("SELECT MAX ([Номер сделки]) FROM Trades", myConnection);
                    var num1 = Convert.ToInt16(num_trade1.ExecuteScalar())+1;
                    SqlCommand trade1 = new SqlCommand("INSERT INTO Trades([Номер сделки],[Госномер],[Номер и серия паспорта],[ID статуса сделки],[Срок сделки],[Сумма сделки])" +
                        "VALUES ('" +num1  + "','" + Program.Employee_Form.Tabel_auto_for_others[0, Program.Employee_Form.Tabel_auto_for_others.CurrentRow.Index].Value + "','" + Program.Add_Client_For_Trades.Pasport.Text + "',1,'" + Program.Add_Client_For_Trades.Days.Value + "','" + sum1 + "')", myConnection);
                    trade1.ExecuteNonQuery();
                    SqlCommand car1 = new SqlCommand("UPDATE Cars SET " +
                    "Cars.[ID состояния авто] = 3 " +
                    "WHERE Cars.[Госномер]= '" + Program.Employee_Form.Tabel_auto_for_others[0, Program.Employee_Form.Tabel_auto_for_others.CurrentRow.Index].Value + "'", myConnection);
                    car1.ExecuteNonQuery();
                    myConnection.Close();
                    break;
            }
        }
        public void Create_trade_Сlient_exist()//Создание сделки для клиента в базе
        {
            switch (Program.Entrr_fr.choose)

            {
                case 1://Ввод со стороны клиента
                    myConnection.Open();
                    var price = Convert.ToInt32(Program.Client_Form.Tabel_auto_for_others[13, Program.Client_Form.Tabel_auto_for_others.CurrentRow.Index].Value.ToString());
                    var day = Convert.ToInt32(Program.Add_Client_For_Trades.Days.Value.ToString());
                    int sum = day * price;
                    SqlCommand num_trade = new SqlCommand("SELECT MAX ([Номер сделки]) FROM Trades", myConnection);
                    int num = Convert.ToInt16(num_trade.ExecuteScalar())+1;
                    SqlCommand trade = new SqlCommand("INSERT INTO Trades([Номер сделки],[Госномер],[Номер и серия паспорта],[ID статуса сделки],[Срок сделки],[Сумма сделки])" +
                        "VALUES ('"+num+"','" + Program.Client_Form.Tabel_auto_for_others[0, Program.Client_Form.Tabel_auto_for_others.CurrentRow.Index].Value + "','" + Program.Add_Client_For_Trades.Pasport.Text + "',2,'" + Program.Add_Client_For_Trades.Days.Value + "','" + sum + "')", myConnection);
                    trade.ExecuteNonQuery();
                    SqlCommand car = new SqlCommand("UPDATE Cars SET " +
                    "Cars.[ID состояния авто] = 2 " +
                    "WHERE Cars.[Госномер]= '" + Program.Client_Form.Tabel_auto_for_others[0, Program.Client_Form.Tabel_auto_for_others.CurrentRow.Index].Value + "'", myConnection);
                    car.ExecuteNonQuery();
                    myConnection.Close();
                    break;
                case 2://Ввод со стороны сотруника
                    myConnection.Open();
                    var price1 = Convert.ToInt32(Program.Employee_Form.Tabel_auto_for_others[13, Program.Employee_Form.Tabel_auto_for_others.CurrentRow.Index].Value.ToString());
                    var day1 = Convert.ToInt32(Program.Add_Client_For_Trades.Days.Value.ToString());
                    int sum1 = day1 * price1;
                    SqlCommand num_trade1 = new SqlCommand("SELECT MAX ([Номер сделки]) FROM Trades", myConnection);
                    int num1 = Convert.ToInt16(num_trade1.ExecuteScalar())+1;
                    SqlCommand trade1 = new SqlCommand("INSERT INTO Trades([Номер сделки],[Госномер],[Номер и серия паспорта],[ID статуса сделки],[Срок сделки],[Сумма сделки])" +
                        "VALUES ('" +num1  + "','" + Program.Employee_Form.Tabel_auto_for_others[0, Program.Employee_Form.Tabel_auto_for_others.CurrentRow.Index].Value + "','" + Program.Add_Client_For_Trades.Pasport.Text + "',1,'" + Program.Add_Client_For_Trades.Days.Value + "','" + sum1 + "')", myConnection);
                    trade1.ExecuteNonQuery();
                    SqlCommand car1 = new SqlCommand("UPDATE Cars SET " +
                    "Cars.[ID состояния авто] = 3 " +
                    "WHERE Cars.[Госномер]= '" + Program.Employee_Form.Tabel_auto_for_others[0, Program.Employee_Form.Tabel_auto_for_others.CurrentRow.Index].Value + "'", myConnection);
                    car1.ExecuteNonQuery();
                    myConnection.Close();
                    break;
            }
        }
        public void load_open_trades()//Выгрузка открытых сделок для одмена и сотрудника чтоб закрыть
        {
            Program.SalesTable.Rent_Table.Rows.Clear();
            switch (Program.Entrr_fr.choose)
            {
                case 2:
                    myConnection.Open();
                    SqlCommand com1 = new SqlCommand("SELECT Trades.[Номер сделки], Trades.[Госномер], Trades.[Номер и серия паспорта], [ID статуса сделки].[Статус сделки], Trades.[Срок сделки], Trades.[Сумма сделки]" +
                    "FROM[ID статуса сделки] INNER JOIN Trades ON[ID статуса сделки].[ID статуса сделки] = Trades.[ID статуса сделки]" +
                    "WHERE Trades.[ID статуса сделки] = 1", myConnection);
                    SqlDataReader reader1 = com1.ExecuteReader();

                    List<string[]> data1 = new List<string[]>();

                    while (reader1.Read())
                    {
                        data1.Add(new string[6]);

                        data1[data1.Count - 1][0] = reader1[0].ToString();
                        data1[data1.Count - 1][1] = reader1[1].ToString();
                        data1[data1.Count - 1][2] = reader1[2].ToString();

                        data1[data1.Count - 1][3] = reader1[3].ToString();
                        data1[data1.Count - 1][4] = reader1[4].ToString();
                        data1[data1.Count - 1][5] = reader1[5].ToString();
                    }

                    reader1.Close();

                    myConnection.Close();

                    foreach (string[] s in data1)
                        Program.SalesTable.Rent_Table.Rows.Add(s);
                    break;
                case 3:
                    myConnection.Open();
                    SqlCommand com = new SqlCommand("SELECT Trades.[Номер сделки], Trades.[Госномер], Trades.[Номер и серия паспорта], [ID статуса сделки].[Статус сделки], Trades.[Срок сделки], Trades.[Сумма сделки]" +
                    "FROM[ID статуса сделки] INNER JOIN Trades ON[ID статуса сделки].[ID статуса сделки] = Trades.[ID статуса сделки]", myConnection);
                    SqlDataReader reader = com.ExecuteReader();

                    List<string[]> data = new List<string[]>();

                    while (reader.Read())
                    {
                        data.Add(new string[6]);

                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();

                        data[data.Count - 1][3] = reader[3].ToString();
                        data[data.Count - 1][4] = reader[4].ToString();
                        data[data.Count - 1][5] = reader[5].ToString();
                    }

                    reader.Close();

                    myConnection.Close();

                    foreach (string[] s in data)
                        Program.SalesTable.Rent_Table.Rows.Add(s);
                    Program.SalesTable.End_sale.Enabled = false;
                    break;
            }
               
        }
        public void confirm_trade()//Подтверждение сделки
        {
            myConnection.Open();
            SqlCommand com = new SqlCommand("UPDATE Trades SET " +
                    "Trades.[ID статуса сделки] = 1 " +
                    "WHERE Trades.[Номер сделки]= '" + Program.Employee_Form.Rent_Table[0, Program.Employee_Form.Rent_Table.CurrentRow.Index].Value + "'", myConnection);
            com.ExecuteNonQuery();
            SqlCommand car = new SqlCommand("UPDATE Cars SET " +
                    "Cars.[ID состояния авто] = 3 " +
                    "WHERE Cars.[Госномер]= '" + Program.Employee_Form.Rent_Table[1, Program.Employee_Form.Rent_Table.CurrentRow.Index].Value + "'", myConnection);
            car.ExecuteNonQuery();
            myConnection.Close();
        }
        public void otmenatrade()//Закрытие сделки сотрудником
        {
            myConnection.Open();
            SqlCommand com = new SqlCommand("UPDATE Trades SET " +
            "Trades.[ID статуса сделки] = 3 " +
            "WHERE Trades.[Номер сделки]= '" + Program.Employee_Form.Rent_Table[0, Program.Employee_Form.Rent_Table.CurrentRow.Index].Value + "'", myConnection);
            com.ExecuteNonQuery();
            SqlCommand car = new SqlCommand("UPDATE Cars SET " +
                    "Cars.[ID состояния авто] = 1 " +
                    "WHERE Cars.[Госномер]= '" + Program.Employee_Form.Rent_Table[1, Program.Employee_Form.Rent_Table.CurrentRow.Index].Value + "'", myConnection);
            car.ExecuteNonQuery();
            myConnection.Close();
        }
        public void end_trade()//Закрытие сделки сотрудником
        {
            myConnection.Open();
                    SqlCommand com = new SqlCommand("UPDATE Trades SET " +
                    "Trades.[ID статуса сделки] = 3 " +
                    "WHERE Trades.[Номер сделки]= '" + Program.SalesTable.Rent_Table[0, Program.SalesTable.Rent_Table.CurrentRow.Index].Value + "'", myConnection);
                    com.ExecuteNonQuery();
            SqlCommand car = new SqlCommand("UPDATE Cars SET " +
                    "Cars.[ID состояния авто] = 1 " +
                    "WHERE Cars.[Госномер]= '" + Program.SalesTable.Rent_Table[1, Program.SalesTable.Rent_Table.CurrentRow.Index].Value + "'", myConnection);
            car.ExecuteNonQuery();
            myConnection.Close();
        }
        public DataTable GetData()//Выгрузка в DataTable
        {
            myConnection.Open();
            SqlCommand com = new SqlCommand("SELECT Trades.[Номер сделки], Trades.[Госномер], Trades.[Номер и серия паспорта], [ID статуса сделки].[Статус сделки], Trades.[Срок сделки], Trades.[Сумма сделки]" +
            "FROM[ID статуса сделки] INNER JOIN Trades ON[ID статуса сделки].[ID статуса сделки] = Trades.[ID статуса сделки]", myConnection);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            myConnection.Close();
            myConnection.Dispose();
            return dt;
        }
        public void Export()//Выгрузка данных в ексель
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Worksheet xlSheet;
            Microsoft.Office.Interop.Excel.Range xlSheetRange;
            xlApp = new Excel.Application();
            
                    //добавляем книгу
                    xlApp.Workbooks.Add(Type.Missing);

                    //делаем временно неактивным документ
                    xlApp.Interactive = false;
                    xlApp.EnableEvents = false;

                    //выбираем лист на котором будем работать (Лист 1)
                    xlSheet = (Excel.Worksheet)xlApp.Sheets[1];
                    //Название листа
                    xlSheet.Name = "Данные";

                    //Выгрузка данных
                    DataTable dt = GetData();

                    int collInd = 0;
                    int rowInd = 0;
                    string data = "";

                    //называем колонки
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        data = dt.Columns[i].ColumnName.ToString();
                        xlSheet.Cells[1, i + 1] = data;

                        //выделяем первую строку
                        xlSheetRange = xlSheet.get_Range("A1:Z1", Type.Missing);

                        //делаем полужирный текст и перенос слов
                        xlSheetRange.WrapText = true;
                        xlSheetRange.Font.Bold = true;
                    }

                    //заполняем строки
                    for (rowInd = 0; rowInd < dt.Rows.Count; rowInd++)
                    {
                        for (collInd = 0; collInd < dt.Columns.Count; collInd++)
                        {
                            data = dt.Rows[rowInd].ItemArray[collInd].ToString();
                            xlSheet.Cells[rowInd + 2, collInd + 1] = data;
                        }
                    }

                    //выбираем всю область данных
                    xlSheetRange = xlSheet.UsedRange;

                    //выравниваем строки и колонки по их содержимому
                    xlSheetRange.Columns.AutoFit();
                    xlSheetRange.Rows.AutoFit();
                
                    //Показываем ексель
                    xlApp.Visible = true;

                    xlApp.Interactive = true;
                    xlApp.ScreenUpdating = true;
                    xlApp.UserControl = true;

                    //Отсоединяемся от Excel
                    releaseObject(xlSheetRange);
                    releaseObject(xlSheet);
                    releaseObject(xlApp);
            
        }
        void releaseObject(object obj)
        {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
                GC.Collect();
        }//Освобождение ресурсов(Закрытие екселя)
    }
}
