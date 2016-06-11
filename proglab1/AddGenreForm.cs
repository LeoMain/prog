using MySql.Data.MySqlClient;
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
    public partial class AddGenreForm : Form
    {
        string ConnectionString;

        public AddGenreForm(string connectionString)
        {
            InitializeComponent();
            ConnectionString = connectionString;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(GenreTB.Text.Trim()))
                    throw new Exception("Не введен жанр");

                using (var con = new MySqlConnection(ConnectionString))
                {
                    MySqlCommand command = new MySqlCommand();
                    string SQL = "INSERT INTO `genre` (`name`) VALUES (@name)";
                    command.CommandText = SQL;
                    command.Parameters.AddWithValue("@name", GenreTB.Text.Trim());
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
