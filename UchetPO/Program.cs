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
        public static string Catalog = @"UchetPO";
        public static string Server = "DESKTOP-2CITAU1\\SQLEXPRESS";
        public static string Autolog;
        public static string Autopass;
        public static string Id_Acc;
        private static MainMenu MainMenu;

    }
}
