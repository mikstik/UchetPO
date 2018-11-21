using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace praktikaProject.Presenter
{
    class SaveMeHelper
    {
        public void ReadPass(out string login, out string password)
        {
            //Чтение логина с паролем из реестра
            login = null;
            password = null;

            try
            {
                using (RegistryKey logPas = Registry.CurrentUser.OpenSubKey("UchetPO"))
                {
                    if (logPas != null)
                    {
                        login = logPas.GetValue("login").ToString();
                        password = logPas.GetValue("password").ToString();
                        logPas.Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка чтения данных из рееста", "Ошибка", MessageBoxButtons.OK);
                return;
            }
        }

        public void RememberUser(string login, string password)
        {
            //Запись логина с паролем в реестр
            try
            {
                using (RegistryKey logPas = Registry.CurrentUser.CreateSubKey("UchetPO"))
                {
                    logPas.SetValue("login", login);
                    logPas.SetValue("password", password);
                    logPas.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось записать пользователя в реестр", "Ошибка", MessageBoxButtons.OK);
                return;
            }
        }

        public void EraseUser()
        {
            //Удаление логина с паролем из реестра
            try
            {
                Registry.CurrentUser.DeleteSubKey("UchetPO", true);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка удаления даных пользователя из реестра", "Ошибка", MessageBoxButtons.OK);
                return;
            }
        }
    }
}