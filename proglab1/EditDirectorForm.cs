﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proglab1
{
    public partial class EditDirectorForm : Form
    {
        string ConnectionString;
        DateTime date;
        int ID;

        public EditDirectorForm(string connectionString, DataGridViewRow datarow)
        {
            InitializeComponent();
            ConnectionString = connectionString;
            date = Convert.ToDateTime(datarow.Cells["День рождения"].Value);
            ID = Convert.ToInt32(datarow.Cells["ID"].Value);
            NameTB.Text = datarow.Cells["Имя"].Value.ToString();
            YearTextBox.Text = date.Year.ToString();
            MonthTextBox.Text = date.Month.ToString();
            DayTextBox.Text = date.Day.ToString();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(NameTB.Text.Trim()))
                    throw new Exception("Не введено имя");

                if (String.IsNullOrEmpty(YearTextBox.Text.Trim()) ||
                    String.IsNullOrEmpty(MonthTextBox.Text.Trim()) ||
                    String.IsNullOrEmpty(DayTextBox.Text.Trim()))
                    throw new Exception("Не заполнен день рождения");

                int year = Convert.ToInt32(YearTextBox.Text.Trim());
                int month = Convert.ToInt32(MonthTextBox.Text.Trim());
                int day = Convert.ToInt32(DayTextBox.Text.Trim());

                if (year < 1800 || year > DateTime.Now.Year)
                    throw new Exception("Неверно введен год");

                if (month < 1 || month > 12)
                    throw new Exception("Неверно введен месяц");

                if (day < 1 || day > 31)
                    throw new Exception("Неверно введен день");

                DateTime date = new DateTime(year, month, day);
                string sqlDate = date.ToString("yyyy-MM-dd");

                using (var con = new MySqlConnection(ConnectionString))
                {
                    MySqlCommand command = new MySqlCommand();
                    string SQL = "UPDATE `director` SET `name` = @name, `birthday` = @birthday WHERE id = " + ID;
                    command.CommandText = SQL;
                    command.Parameters.AddWithValue("@name", NameTB.Text.Trim());
                    command.Parameters.AddWithValue("@birthday", sqlDate);
                    command.Connection = con;
                    con.Open();
                    command.ExecuteNonQuery();
                }

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
