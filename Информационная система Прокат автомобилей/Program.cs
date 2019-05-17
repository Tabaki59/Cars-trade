using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Информационная_система_Прокат_автомобилей
{
    static class Program
    {
        public static Enter_Form Entrr_fr;
        public static Commander commander;
        public static Add_Auto_fr add_Auto_Fr;
        public static Add_Client_For_Trades Add_Client_For_Trades;
        public static Edit_auto_fr Edit_Auto_Fr;
        public static Admin_Form Admin_Form;
        public static Employee_Form Employee_Form;
        public static Client_Form Client_Form;
        public static SalesTable SalesTable;
        public static Search Search;
        public static Client_List Client_List;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Enter_Form());
        }
    }
}
