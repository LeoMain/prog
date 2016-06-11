using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proglab1
{
    public partial class AddMovieForm : Form
    {
        string ConnectionString;
        SortedList<string, int> directors, genres;

        public AddMovieForm(string connectionString)
        {
            ConnectionString = connectionString;
            directors = new SortedList<string, int>();
            genres = new SortedList<string, int>();
            InitializeComponent();
            using (var con = new MySqlConnection(ConnectionString))
            {
                MySqlCommand sqlCmdDirs = new MySqlCommand("SELECT id, name FROM director", con);
                MySqlCommand sqlCmdGenres = new MySqlCommand("SELECT id, name FROM genre", con);
                con.Open();
                MySqlDataReader sqlReader = sqlCmdDirs.ExecuteReader();

                while (sqlReader.Read())
                    directors.Add(sqlReader["name"].ToString(), Convert.ToInt32(sqlReader["id"]));

                sqlReader.Close();

                sqlReader = sqlCmdGenres.ExecuteReader();

                while (sqlReader.Read())
                    genres.Add(sqlReader["name"].ToString(), Convert.ToInt32(sqlReader["id"]));

                sqlReader.Close();
            }

            if (directors.Count != 0)
            {
                foreach (string name in directors.Keys)
                    DirectorComboBox.Items.Add(name);

                DirectorComboBox.SelectedIndex = 0;
            }

            if (genres.Count != 0)
            {
                foreach (string name in genres.Keys)
                    GenreComboBox.Items.Add(name);

                GenreComboBox.SelectedIndex = 0;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string year = YearTextBox.Text.Trim();
                
                if (String.IsNullOrEmpty(NameTextBox.Text.Trim()))
                    throw new Exception("Не введено название фильма");
                if (String.IsNullOrEmpty(year) ||
                    Convert.ToInt32(year) < 1895 ||
                    Convert.ToInt32(year) > DateTime.Now.Year)
                    throw new Exception("Неверно введен год");

                int id_genre = genres[GenreComboBox.Text];
                int id_director = directors[DirectorComboBox.Text];

                using (var con = new MySqlConnection(ConnectionString))
                {
                    MySqlCommand command = new MySqlCommand();
                    string SQL = "INSERT INTO `movie` (`name`, `year`, `id_genre`, `id_director`) VALUES (@name, @year, @idgenre, @iddirector)";
                    command.CommandText = SQL;
                    command.Parameters.AddWithValue("@name", NameTextBox.Text.Trim());
                    command.Parameters.AddWithValue("@year", YearTextBox.Text.Trim());
                    command.Parameters.AddWithValue("@idgenre", id_genre);
                    command.Parameters.AddWithValue("@iddirector", id_director);
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
