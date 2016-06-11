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
    public partial class EditGenreForm : Form
    {
        string ConnectionString;
        int ID;

        public EditGenreForm(string connectionString, DataGridViewRow datarow)
        {
            InitializeComponent();
            ConnectionString = connectionString;
            ID = Convert.ToInt32(datarow.Cells["ID"].Value);
            GenreTB.Text = datarow.Cells["Жанр"].Value.ToString();
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
                    string SQL = "UPDATE `genre` SET `name` = @name WHERE id = " + ID;
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
