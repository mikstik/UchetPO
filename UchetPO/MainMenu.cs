using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchetPO
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form Auth = new Auth();
            Close();
            Auth.Show();
        }

        private void Home_MouseClick(object sender, MouseEventArgs e)
        {
            SelecterRight.Height = (sender as Button).Height;
            SelecterRight.Top = (sender as Button).Top;
            SelecterLeft.Height = (sender as Button).Height;
            SelecterLeft.Top = (sender as Button).Top;
        }

        private void CloseWindows_Click(object sender, EventArgs e)
        {
            foreach (Form AllForm in MdiChildren)
            AllForm.Close();
            HomePanel.Show();
        }

        private void MyPrograms_MouseDown(object sender, MouseEventArgs e)
        {
            HomePanel.Hide();
        }

        private void Home_MouseDown(object sender, MouseEventArgs e)
        {
            HomePanel.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            WelcomeText.Text = "Добро пожаловать, " + Program.Name + "!";
        }

        private void Account_Click(object sender, EventArgs e)
        {
            Form Acc = new Account();
            Acc.MdiParent = this;
            Acc.AutoScroll = false;
            Acc.Show();
            Acc.Dock = DockStyle.Fill;
        }

        private void MyProgram_Click(object sender, EventArgs e)
        {
            Form My = new MyPrograms();
            My.MdiParent = this;
            My.AutoScroll = false;
            My.Show();
            My.Dock = DockStyle.Fill;
        }

        private void Setting_Click(object sender, EventArgs e)
        {
            Form Set = new Setting();
            Set.MdiParent = this;
            Set.AutoScroll = false;
            Set.Dock = DockStyle.Fill;
            Set.Show();
        }

        private void AllProgram_Click(object sender, EventArgs e)
        {
            Form AllF = new AllPrograms();
            AllF.MdiParent = this;
            AllF.AutoScroll = false;
            AllF.Dock = DockStyle.Fill;
            AllF.Show();
        }

        private void LisenceButton_Click(object sender, EventArgs e)
        {
            Form Buy = new BuyLicense();
            Buy.MdiParent = this;
            Buy.AutoScroll = false;
            Buy.Dock = DockStyle.Fill;
            Buy.Show();
        }

        private void About_Click(object sender, EventArgs e)
        {
            Form About = new AboutProgram();
            About.MdiParent = this;
            About.AutoScroll = false;
            About.Dock = DockStyle.Fill;
            About.Show();
        }
    }
}
