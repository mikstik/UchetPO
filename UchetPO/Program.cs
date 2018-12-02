using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchetPO
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Auth());
        }

        public static string Name;
        public static string Catalog = "UchetPO";
        public static string Server;
        public static string Version;
        public static string Id_Acc;
        public static string Acc_Pass;
       // public static string pdkl = "Data Source=" + Server + "\\" + Version + ";Initial Catalog=" + Catalog + ";Integrated Security=True";
        //public static string pdkl = @"Data Source=DESKTOP-2CITAU1\SQLEXPRESS;Initial Catalog=UchetPO;Persist Security Info=True";

    }
}
