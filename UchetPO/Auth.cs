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
        public string pdkl = "Data Source="+Program.Server+"\\"
                             +Program.Version+
                             ";Initial Catalog="+
                             Program.Catalog+";Integrated Security=True";
        string background;
        //string pdkl = "Data Source=" + Program.Version + ";Initial Catalog = " + Program.Catalog + ";Persist Security Info=True";
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
                string connect = pdkl;
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
                con.Close();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка подключения!");
                PasswordBox.Text = null;
            }
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            Program.Server = System.Net.Dns.GetHostName();
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
            try
            {
                RegistryKey currentUserKey = Registry.CurrentUser;
                RegistryKey RK = currentUserKey.CreateSubKey("Design");
                background = RK.GetValue("BackColor").ToString();
                BackColor = ColorTranslator.FromHtml(background);
                RK.Close();
                AuthPanel.BackColor = ColorTranslator.FromHtml(background);
                LoginBox.BackColor = ColorTranslator.FromHtml(background);
                PasswordBox.BackColor = ColorTranslator.FromHtml(background);
            }
            catch
            {

            }
        }

        private async void GetServerList_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(pdkl))
                {
                    sqlConn.Open();

                    SqlCommand sqlCmd = new SqlCommand(@"Server=" + Program.Server + ";Integrated Security=true");
                    sqlCmd.Connection = sqlConn;
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.CommandText = "sp_helpdb";

                    SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    ServersList.Items.Clear();
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        ServersList.Items.Add(row["name"].ToString());
                    }
                    await sqlCmd.ExecuteNonQueryAsync();
                }
            }
            catch
            {
                MessageBox.Show("При получении списка баз данных произошла ошибка. Проверьте правильность указанного сервера и необходимости использования префикса СУБД.");
                
            }
        }

        private void Setting_Click(object sender, EventArgs e)
        {
            if (SettingPanel.Visible == true)
            {
                SettingPanel.Visible = false;
            }
            else
            {
                SettingPanel.Visible = true;
            }
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            Program.Server = ServerBox.Text;
            Program.Version = SQLBox.Text;
            if (Switcher.Value)
            {
                Program.Version = SQLBox.Text;
            }
            else
            {
                Program.Version = "";
            }
            pdkl = "Data Source=" + Program.Server + "\\" + Program.Version + ";Initial Catalog=" + Program.Catalog + ";Integrated Security=True";
        }

        private void Auto_Click(object sender, EventArgs e)
        {
            Program.Server = System.Net.Dns.GetHostName();
            Program.Catalog = "UchetPO";
            ServerBox.Text = Program.Server;
            SQLBox.Text = "SQLEXPRESS";
        }

        private void AcceptCatalog_Click(object sender, EventArgs e)
        {
            Program.Catalog = ServersList.SelectedItem.ToString();
        }

        private void Switcher_OnValueChange(object sender, EventArgs e)
        {
            if (Switcher.Value)
            {
                SQLBox.Enabled = true;
            }
            else
            {
                SQLBox.Enabled = false;
            }
        }

    }
}
