using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using md5Crypt;

namespace UchetPO
{
    public partial class Reg : Form
    {
        SqlConnection connect;
        string pdkl = @"Data Source=" + Program.Server + ";Initial Catalog = " + Program.Catalog + ";Persist Security Info=True;User ID=sa; Password =12345678";
        public Reg()
        {
            InitializeComponent();
        }

        private void EnterApp_Click(object sender, EventArgs e)
        {
            Form Auth = new Auth();
            Close();
            Auth.Show();
        }

        private void PromptPass_Click(object sender, EventArgs e)
        {
            if (PasswordBox.PasswordChar == '•' && RepeatPassword.PasswordChar == '•')
            {
                PasswordBox.PasswordChar = '\0';
                RepeatPassword.PasswordChar = '\0';
            }
            else
            {
                PasswordBox.PasswordChar = '•';
                RepeatPassword.PasswordChar = '•';
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void Registration_Click(object sender, EventArgs e)
        {
            Program.Autolog = LoginBox.Text;
            Program.Autopass = PasswordBox.Text;
            string pdkl = @"Data Source=" + Program.Server + ";Initial Catalog = " + Program.Catalog + ";Persist Security Info=True;User ID=sa; Password =12345678";
            //MobilPanel.Show();
            //AuthPanel.Hide();
            try
            {
                if (!string.IsNullOrEmpty(LoginBox.Text) && !string.IsNullOrWhiteSpace(LoginBox.Text) &&
                   !string.IsNullOrEmpty(NameBox.Text) && !string.IsNullOrWhiteSpace(NameBox.Text) &&
                   !string.IsNullOrEmpty(MobilBox.Text) && !string.IsNullOrWhiteSpace(MobilBox.Text) &&
                   !string.IsNullOrEmpty(PasswordBox.Text) && !string.IsNullOrWhiteSpace(PasswordBox.Text))
                {
                    SqlCommand command = new SqlCommand("INSERT INTO [Account] (Login, Password, Name, Mobile) VALUES (@Login, @Password, @Name, @Mobile)", connect);
                    command.Parameters.AddWithValue("Login", LoginBox.Text);
                    var shifr = new Shifr();
                    string CryptPass = PasswordBox.Text;
                    string md5_hash = shifr.SetHashString(CryptPass);
                    command.Parameters.AddWithValue("Password", md5_hash);
                    command.Parameters.AddWithValue("Name", NameBox.Text);
                    command.Parameters.AddWithValue("Mobile", MobilBox.Text);
                    await command.ExecuteNonQueryAsync();
                    MessageBox.Show("Регистрация прошла успешно! Добро пожаловать, " + NameBox.Text + "!");

                    Form Auth = new Auth();
                    Close();
                    Auth.Show();
                }
                else
                {
                    MessageBox.Show("Все поля должны быть заполнены!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            SecondMessage.Show();
            SecondMessageText.Show();
            SecondMessageText.Text = "Код: " + CodeBox.Text;

            ThirstMessage.Show();
            ThirstMessageText.Show();
        }

        private void ExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RepeatPassword_TextChanged(object sender, EventArgs e)
        {
            if (RepeatPassword.Text == PasswordBox.Text)
            {
                RepeatPassLabel.ForeColor = Color.LimeGreen;
                RepeatPassLabel.Text = "Пароли совпали!";
                Registration.Enabled = true;
            }
            else
            {
                RepeatPassLabel.ForeColor = Color.Red;
                RepeatPassLabel.Text = "Пароли не совпадают!";
                Registration.Enabled = false;
            }
        }

        private async void Reg_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(pdkl);
            await connect.OpenAsync();
            SqlDataReader sqlReader = null;
        }
    }
}
