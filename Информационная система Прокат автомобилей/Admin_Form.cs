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
    public partial class Admin_Form : Form
    {
        public Admin_Form()
        {
            InitializeComponent();
            Program.Admin_Form = this;
            Program.commander = new Commander();
            Program.commander.LoadAuto_for_admin();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Sprav_button_Click(object sender, EventArgs e)
        {
            Guide_Form guide_ = new Guide_Form();
            guide_.Show();
        }

        private void Open_Sdel_Table_Click(object sender, EventArgs e)
        {
            SalesTable sales = new SalesTable();
            sales.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
        }

        private void Add_Auto_Click(object sender, EventArgs e)
        {
            Add_Auto_fr adding = new Add_Auto_fr();
            adding.Show();
        }

        private void Change_auto_Click(object sender, EventArgs e)
        {
            if (Program.Admin_Form.Tabel_auto_for_admin[7, Program.Admin_Form.Tabel_auto_for_admin.CurrentRow.Index].Value.ToString() == "В наличии           ")
            {
                Edit_auto_fr edit = new Edit_auto_fr();
                edit.Show();
            }
            else
                MessageBox.Show("Ай яй яй, пытаемся изменить авто не в наличии? Нельзя!");
        }

        private void Open_Client_table_Click(object sender, EventArgs e)
        {
            Client_List client_List = new Client_List();
            client_List.Show();
        }

        private void Del_filters_Click(object sender, EventArgs e)
        {
            Program.commander.LoadAuto_for_admin();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (Program.Admin_Form.Tabel_auto_for_admin[7, Program.Admin_Form.Tabel_auto_for_admin.CurrentRow.Index].Value.ToString() == "В наличии           ")
            {
                Program.commander.Delete_auto();
                Program.commander.LoadAuto_for_admin();
            }
            else
                MessageBox.Show("Ай яй яй, пытаемся удалить авто не в наличии? Нельзя!");
        }

        private void Import_Click(object sender, EventArgs e)
        {
            Program.commander.Export();
        }
    }
}
