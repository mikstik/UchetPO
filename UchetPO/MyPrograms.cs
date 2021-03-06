﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.Data.Sql;
using System.Threading;
using System.Globalization;

namespace UchetPO
{

    public partial class MyPrograms : Form
    {
        string background;
        SqlConnection connect;
        //string pdkl = @"Data Source=" + Program.Server + Program.Version + ";Initial Catalog = " + Program.Catalog + ";Persist Security Info=True;User ID=sa; Password =12345678";
        string pdkl = "Data Source=" + Program.Server + "\\" + Program.Version + ";Initial Catalog=" + Program.Catalog + ";Integrated Security=True";
        string Current_id;
        public MyPrograms()
        {
            InitializeComponent();
            LoadData();

        }

        private void LoadData()
        {
            try
            {
                SqlConnection connect = new SqlConnection(pdkl);
                string podkl = @"SELECT * FROM Programms WHERE Id_Acc = " + Program.Id_Acc;
                SqlCommand com = new SqlCommand(podkl, connect);
                connect.Open();
                SqlDataReader read = com.ExecuteReader();
                DataTable datetable = new DataTable();
                datetable.Load(read);
                Table.DataSource = datetable;
                Table.Columns[0].Visible = false;
                Table.Columns[1].HeaderText = "Название программы";
                Table.Columns[1].Visible = true;
                Table.Columns[2].HeaderText = "Описание";
                Table.Columns[2].Visible = true;
                Table.Columns[3].HeaderText = "Лицензионный ключ";
                Table.Columns[3].Visible = true;
                Table.Columns[4].HeaderText = "Дата окончания";
                Table.Columns[4].Visible = true;
                Table.Columns[5].HeaderText = "Код пользователя";
                Table.Columns[5].Visible = false;
                Table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                connect.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка сервера!");
            }
        }

        private async void MyPrograms_Load(object sender, EventArgs e)
        {
            try
            {
                RegistryKey currentUserKey = Registry.CurrentUser;
                RegistryKey RK = currentUserKey.CreateSubKey("Design");
                background = RK.GetValue("BackColor").ToString();
                BackColor = ColorTranslator.FromHtml(background);
                RK.Close();
                AdditionalPanel.BackColor = ColorTranslator.FromHtml(background);
                RightPanel.BackColor = ColorTranslator.FromHtml(background);
                DescriptionBox.BackColor = ColorTranslator.FromHtml(background);
                NameBox.BackColor = ColorTranslator.FromHtml(background);
                KeyBox.BackColor = ColorTranslator.FromHtml(background);
                Cancel.BackColor = ColorTranslator.FromHtml(background);
                Delete.BackColor = ColorTranslator.FromHtml(background);
                Change.BackColor = ColorTranslator.FromHtml(background);
                Add.BackColor = ColorTranslator.FromHtml(background);
                Refresh.BackColor = ColorTranslator.FromHtml(background);
                Delete.BackColor = ColorTranslator.FromHtml(background);
                ChangesCancel.BackColor = ColorTranslator.FromHtml(background);
                SaveChanges.BackColor = ColorTranslator.FromHtml(background);
                ResetSearch.BackColor = ColorTranslator.FromHtml(background);
                Search.BackColor = ColorTranslator.FromHtml(background);
            }
            catch
            {

            }

            try
            {
                DescriptionBox.Hide();
                connect = new SqlConnection(pdkl);
                await connect.OpenAsync();
                Table.BorderStyle = BorderStyle.None;
                Table.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
                Table.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                Table.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
                Table.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                Table.BackgroundColor = Color.White;
                Table.EnableHeadersVisualStyles = false;
                Table.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                Table.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(background);
                Table.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            }
            catch
            {

            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch
            {

            }
        }

        private async void SaveChanges_Click(object sender, EventArgs e)
        {
            Current_id = Table.CurrentRow.Cells[0].Value.ToString();
            try
            {
                if (!string.IsNullOrEmpty(NameBox.Text) && !string.IsNullOrWhiteSpace(NameBox.Text) &&
                   !string.IsNullOrEmpty(KeyBox.Text) && !string.IsNullOrWhiteSpace(KeyBox.Text) &&
                   !string.IsNullOrEmpty(DaysBox.Text) && !string.IsNullOrWhiteSpace(DaysBox.Text))
                {
                    SqlCommand command = new SqlCommand("UPDATE [Programms] SET NameProgramm=@NameProgramm, DescriptionProgramm=@DescriptionProgramm, LicenseKeyProgramm=@LicenseKeyProgramm, KeyEnd=@KeyEnd, Id_Acc=@Id_Acc where Id=@Id", connect);
                    command.Parameters.AddWithValue("Id", Current_id);
                    command.Parameters.AddWithValue("NameProgramm", NameBox.Text);
                    command.Parameters.AddWithValue("DescriptionProgramm", DescriptionBox.Text);
                    command.Parameters.AddWithValue("LicenseKeyProgramm", KeyBox.Text);
                    command.Parameters.AddWithValue("KeyEnd", DaysBox.Text);
                    command.Parameters.AddWithValue("Id_Acc", Program.Id_Acc);

                    await command.ExecuteNonQueryAsync();
                    AdditionalPanel.Hide();

                    MessageBox.Show("Успешно изменена программа: " + NameBox.Text + "!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Все поля должны быть заполнены!");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка обновления данных!");
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AdditionalPanel.Show();
            Reset();
            Create.Show();
        }

        public void Reset()
        {
            DescriptionBox.ResetText();
            NameBox.ResetText();
            DaysBox.ResetText();
            KeyBox.ResetText();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Create.Hide();
            AdditionalPanel.Hide();
            ResetText();
        }

        private async void Create_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(NameBox.Text) && !string.IsNullOrWhiteSpace(NameBox.Text) &&
                   !string.IsNullOrEmpty(KeyBox.Text) && !string.IsNullOrWhiteSpace(KeyBox.Text) &&
                   !string.IsNullOrEmpty(DaysBox.Text) && !string.IsNullOrWhiteSpace(DaysBox.Text))
                {
                    SqlCommand command = new SqlCommand("INSERT INTO [Programms] (NameProgramm, DescriptionProgramm, LicenseKeyProgramm, KeyEnd, Id_Acc) " +
                        "                                VALUES (@NameProgramm, @DescriptionProgramm, @LicenseKeyProgramm, @KeyEnd, @Id_Acc)", connect);
                    command.Parameters.AddWithValue("NameProgramm", NameBox.Text);
                    command.Parameters.AddWithValue("DescriptionProgramm", DescriptionBox.Text);
                    command.Parameters.AddWithValue("LicenseKeyProgramm", KeyBox.Text);
                    command.Parameters.AddWithValue("KeyEnd", DaysBox.Value.ToString());
                    command.Parameters.AddWithValue("Id_Acc", Program.Id_Acc);
                    await command.ExecuteNonQueryAsync();
                    AdditionalPanel.Visible = false;
                    LoadData();
                    MessageBox.Show("Успешно добавлена новая программа: " + NameBox.Text + "!");
                    AdditionalPanel.Hide();
                }
                else
                {
                    MessageBox.Show("Все поля должны быть заполнены!");

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при добавлении новой программы: " + NameBox.Text + "!");
            }
        }

        private async void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("DELETE FROM Programms WHERE Id=@Id", connect);
                command.Parameters.AddWithValue("Id", Current_id);
                await command.ExecuteNonQueryAsync();
                MessageBox.Show("Успешно удалена программа: " + NameBox.Text + "!");
                LoadData();
                AdditionalPanel.Hide();
            }
            catch
            {
                MessageBox.Show("Не удалось удалить программу: " + NameBox.Text + "!");
            }
            AdditionalPanel.Hide();
            ResetText();
        }

        private void Table_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Current_id = Table.CurrentRow.Cells[0].Value.ToString();
                NameBox.Text = Table.CurrentRow.Cells[1].Value.ToString();
                DescriptionBox.Text = Table.CurrentRow.Cells[2].Value.ToString();
                KeyBox.Text = Table.CurrentRow.Cells[3].Value.ToString();
                DataGridViewRow row = Table.Rows[e.RowIndex];
                DaysBox.Value = Convert.ToDateTime(row.Cells[4].Value.ToString());
                AdditionalPanel.Show();
                SaveChanges.Show();
            }
            catch { }
        }

        private void Table_Click(object sender, EventArgs e)
        {
            try
            {
                Current_id = Table.CurrentRow.Cells[0].Value.ToString();
                DaysBox.Value = Convert.ToDateTime(Table.CurrentRow.Cells[4].Value);
            }
            catch{ }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            try
            {
                Current_id = Table.CurrentRow.Cells[0].Value.ToString();
                NameBox.Text = Table.CurrentRow.Cells[1].Value.ToString();
                DescriptionBox.Text = Table.CurrentRow.Cells[2].Value.ToString();
                KeyBox.Text = Table.CurrentRow.Cells[3].Value.ToString();
                DaysBox.Value = Convert.ToDateTime(Table.CurrentRow.Cells[4].Value);
                AdditionalPanel.Show();
                SaveChanges.Show();
            }
            catch
            {

            }
        }

        private void Switcher_OnValueChange(object sender, EventArgs e)
        {
            if (Switcher.Value)
            {
                DescriptionLabel.Text = "Скрыть описание";
                DescriptionBox.Enabled = true;
                DescriptionBox.Visible = true;
            }
            else
            {
                DescriptionLabel.Text = "Добавить описание";
                DescriptionBox.Enabled = true;
                DescriptionBox.Visible = false;
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (SearchBox.Text != "Поиск" && !string.IsNullOrEmpty(SearchBox.Text) && !string.IsNullOrWhiteSpace(SearchBox.Text))
                {
                    SqlConnection connect = new SqlConnection(pdkl);
                    string podkl = @"SELECT * FROM Programms WHERE NameProgramm LIKE '%" + SearchBox.Text + "%' AND Id_Acc=" + Program.Id_Acc;
                    SqlCommand com = new SqlCommand(podkl, connect);
                    connect.Open();
                    SqlDataReader read = com.ExecuteReader();
                    DataTable datetable = new DataTable();
                    datetable.Load(read);
                    Table.DataSource = datetable;
                    Table.Columns[0].Visible = false;
                    Table.Columns[1].HeaderText = "Название программы";
                    Table.Columns[1].Visible = true;
                    Table.Columns[2].HeaderText = "Описание";
                    Table.Columns[2].Visible = true;
                    Table.Columns[3].HeaderText = "Лицензионный ключ";
                    Table.Columns[3].Visible = true;
                    Table.Columns[4].HeaderText = "Дата окончания";
                    Table.Columns[4].Visible = true;
                    Table.Columns[5].HeaderText = "Код пользователя";
                    Table.Columns[5].Visible = false;
                    Table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    connect.Close();
                }
                else
                {
                    MessageBox.Show("По вышему запросу ничего не найдено!");
                    LoadData();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка поиска!");
            }
        }

        private void ResetSearch_Click(object sender, EventArgs e)
        {
            SearchBox.Text = "Поиск";
        }
    }
}

