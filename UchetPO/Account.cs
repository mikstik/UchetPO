using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using md5Crypt;
using praktikaProject.Presenter;
using Microsoft.Win32;

namespace UchetPO
{
    public partial class Account : Form
    {
        string background;
        SqlConnection connect;
        //string pdkl = @"Data Source=" + Program.Server + Program.Version + ";Initial Catalog = " + Program.Catalog + ";Persist Security Info=True;User ID=sa; Password =12345678";
        string pdkl = "Data Source=" + Program.Server + "\\" + Program.Version + ";Initial Catalog=" + Program.Catalog + ";Integrated Security=True";
        public Account()
        {
            InitializeComponent();
        }

        private void ChangesCancel_Click(object sender, EventArgs e)
        {
            SaveChanges.Show();
            On();
        }

        private void On()
        {
            NameBox.Enabled = true;
            MobilBox.Enabled = true;
        }

        private void Off()
        {
            NameBox.Enabled = false;
            MobilBox.Enabled = false;
        }

        private async void SaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(NameBox.Text) && !string.IsNullOrWhiteSpace(NameBox.Text) &&
                   !string.IsNullOrEmpty(MobilBox.Text) && !string.IsNullOrWhiteSpace(MobilBox.Text) &&
                   (MobilBox.MaskFull) && PasswordBox.TextLength < 8)
                {
                    connect = new SqlConnection(pdkl);
                    connect.Open();
                    SqlCommand command = new SqlCommand("UPDATE Account SET Password=@Password, Name=@Name, Mobile=@Mobile WHERE Id=" + Program.Id_Acc, connect);
                    var shifr = new Shifr();
                    string CryptPass = PasswordBox.Text;
                    string md5_hash = shifr.SetHashString(CryptPass);
                    if (Switcher.Value == true)
                    {
                        command.Parameters.AddWithValue("Password", md5_hash);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("Password", Program.Acc_Pass);
                    }
                    command.Parameters.AddWithValue("Name", NameBox.Text);
                    command.Parameters.AddWithValue("Mobile", MobilBox.Text);
                    await command.ExecuteNonQueryAsync();
                    MessageBox.Show("Обновление данных прошло успешно!");
                    var SaveMeHalper = new SaveMeHelper();
                    SaveMeHalper.RememberUser(LoginBox.Text, PasswordBox.Text);
                    Get_Acc_Date();
                    connect.Close();
                    Off();
                }
                else
                {
                    MessageBox.Show("Все поля должны быть заполнены! Логин должен быть не менее 6 символов. Пароль должен быть не менее 8 символов.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Account_Load(object sender, EventArgs e)
        {
            On();
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey RK = currentUserKey.CreateSubKey("Design");
            background = RK.GetValue("BackColor").ToString();
            BackColor = ColorTranslator.FromHtml(background);
            RK.Close();
            BackColor = ColorTranslator.FromHtml(background);
            LoginBox.BackColor = ColorTranslator.FromHtml(background);
            PasswordBox.BackColor = ColorTranslator.FromHtml(background);
            NameBox.BackColor = ColorTranslator.FromHtml(background);
            MobilBox.BackColor = ColorTranslator.FromHtml(background);
            Get_Acc_Date();
           
        }

        public async void Get_Acc_Date()
        {
            try
            {
                SqlConnection ThisConnection = new SqlConnection(pdkl);
                ThisConnection.Open();
                SqlCommand thisCommand = ThisConnection.CreateCommand();
                string podkl = @"SELECT Login, Password, Name, Mobile FROM Account WHERE Id=" + Program.Id_Acc;
                thisCommand.CommandText = podkl;
                SqlDataReader read = thisCommand.ExecuteReader();
                while (read.Read())
                {
                    LoginBox.Text = read[0].ToString();
                    PasswordBox.Text = read[1].ToString();
                    NameBox.Text = read[2].ToString();
                    MobilBox.Text = read[3].ToString();
                    Program.Acc_Pass = read[1].ToString();
                }
                read.Close();
                ThisConnection.Close();
                Off();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PromptPass_Click(object sender, EventArgs e)
        {
            if (PasswordBox.PasswordChar == '•')
            {
                PasswordBox.PasswordChar = '\0';
            }
            else
            {
                PasswordBox.PasswordChar = '•';
            }
        }

        private void Switcher_OnValueChange(object sender, EventArgs e)
        {
            if (Switcher.Value)
            {
                PasswordBox.Enabled = true;
                PassLabel.Text = "Изменить пароль";
            }
            else
            {
                PasswordBox.Enabled = false;
                PassLabel.Text = "Не изменять пароль";
            }
        }

        private void NameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!Char.IsDigit(e.KeyChar)) return;
                else
                    e.Handled = true;
            }
        }
    }
}
