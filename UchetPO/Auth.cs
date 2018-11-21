using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.Data.Sql;
using md5Crypt;
using praktikaProject.Presenter;

namespace UchetPO
{
    public partial class Auth : Form
    {
        string pdkl = @"Data Source=" + Program.Server + ";Initial Catalog = " + Program.Catalog + ";Persist Security Info=True;User ID=sa; Password =12345678";
        SqlConnection connect;
        string ServerInfo = string.Empty;
        public Auth()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            Form registr = new Reg(); 
            registr.Show();
            Hide();
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

        private void EnterApp_Click(object sender, EventArgs e)
        {
            try
            {
                var shifr = new Shifr();
                string md5_hash = shifr.SetHashString(PasswordBox.Text);
                string cryptpass;
                cryptpass = PasswordBox.Text;
                cryptpass = md5_hash;
                string connect = @"Data Source=" + Program.Server + ";Initial Catalog =" + Program.Catalog + ";Persist Security Info=True;User ID=sa; Password =12345678";
                SqlConnection con = new SqlConnection(connect);
                SqlDataAdapter sd = new SqlDataAdapter(@"Select Count (*) From Account where Login = '" + LoginBox.Text + "' and Password = '" + cryptpass + "'", con);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("Select Name From Account where Login = '" + LoginBox.Text + "' and Password = '" + cryptpass + "'", con);
                    string namesotr = command.ExecuteScalar().ToString();
                    SqlCommand id_account = new SqlCommand("Select Id From Account where Login = '" + LoginBox.Text + "' and Password = '" + cryptpass + "'", con);
                    string id_acc = id_account.ExecuteScalar().ToString();
                    Program.Name = namesotr;
                    Program.Id_Acc = id_acc;
                    con.Close();
                    Form Main = new MainMenu();
                    Main.Show();
                    Hide();
                    if (RememberUser.Value == true)
                    {
                        var SaveMeHalper = new SaveMeHelper();
                        SaveMeHalper.RememberUser(LoginBox.Text, PasswordBox.Text);
                    }
                    else
                    {
                        var SaveMeHalper = new SaveMeHelper();
                        SaveMeHalper.EraseUser();
                    }
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль!");
                    PasswordBox.Text = null;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                PasswordBox.Text = null;
            }
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            var SaveMeHalper = new SaveMeHelper();
            SaveMeHalper.ReadPass(out string login, out string password);
            LoginBox.Text = login;
            PasswordBox.Text = password;

            if (!string.IsNullOrEmpty(LoginBox.Text) && !string.IsNullOrEmpty(PasswordBox.Text))
            {
                RememberUser.Value = true;
            }
            else
            {
                RememberUser.Value = false;
            }
        }
    }
}
