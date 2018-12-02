using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace UchetPO
{
    public partial class Setting : Form
    {
        string background;
        public Setting()
        {
            InitializeComponent();
        }

        private void SetUp_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey currentUserKey = Registry.CurrentUser; //директори реестра текущего пользователя
                RegistryKey key = Registry.CurrentUser.CreateSubKey("Design"); //создание папку с именем "Design"
                key.SetValue("BackColor", PanelColor.BackColor.Name.ToString()); //создание ключа, который хранит в себе цвет фона приложения
                key.Close(); //закрытие записи
                AdviceLabel.Show(); //подсказка пользователю
            }
            catch
            {
                PanelColor.BackColor = ColorTranslator.FromHtml(background); //при ошибке записи цвета приложения, читаем ранее записанный
            }
        }

        private void Setting_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                RegistryKey currentUserKey = Registry.CurrentUser;
                RegistryKey RK = currentUserKey.CreateSubKey("Design");
                background = RK.GetValue("BackColor").ToString();
                BackColor = ColorTranslator.FromHtml(background);
                RK.Close();
                PanelColor.BackColor = ColorTranslator.FromHtml(background);
            }
            catch
            {

            }
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            PanelColor.BackColor = ColorTranslator.FromHtml(background);
            AdviceLabel.Hide();
        }

        private void Orange_Click(object sender, EventArgs e)
        {
            PanelColor.BackColor = (sender as Button).BackColor;
        }
    }
}
