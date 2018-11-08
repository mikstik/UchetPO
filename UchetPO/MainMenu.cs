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

        private void AllPrograms_Click(object sender, EventArgs e)
        {
            Form All = new AllPrograms();
            All.MdiParent = this;
            All.AutoScroll = false;
            All.Dock = DockStyle.Fill;
            All.Show();
        }

        private void MyPrograms_MouseDown(object sender, MouseEventArgs e)
        {
            HomePanel.Visible = false;
        }

        private void Home_MouseDown(object sender, MouseEventArgs e)
        {
            HomePanel.Visible = true;
        }

        private void MyPrograms_Click(object sender, EventArgs e)
        {
            Form My = new MyPrograms();
            My.MdiParent = this;
            My.AutoScroll = false;
            My.Dock = DockStyle.Fill;
            My.Show();
        }

        private void About_Click(object sender, EventArgs e)
        {
            Form About = new AboutProgram();
            About.MdiParent = this;
            About.AutoScroll = false;
            About.Dock = DockStyle.Fill;
            About.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            WelcomeText.Text = "Добро пожаловать, " + Program.Name + "!";
        }
    }
}
