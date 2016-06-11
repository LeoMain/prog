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
    public partial class MainForm : Form
    {
        public string ConnectionString;
        static string DBName = "prog1";
        int pageCount = 10;
        int index = 0;
        int[] page;
        int[] rowCount;
        string[] names, fields, joins, countConditions;
        DataGridView[] grids;

        public MainForm(string login, string pass)
        {
            InitializeComponent();
            ConnectionString = String.Format("Server=localhost;user id={0};password={1};Database={2};", login, pass, DBName);
            names = new string[] { "movie m", "director d", "genre g" };
            page = new int[3] { 1, 1, 1 };
            rowCount = new int[3] { 0, 0, 0 };  
            fields = new string[] {
                "m.id as 'ID', m.name as 'Название', m.year as 'Год', d.name as 'Режиссер', g.name as 'Жанр'",
                "d.id as 'ID', d.name as 'Имя', d.birthday as 'День рождения'",
                "g.id as 'ID', g.name as 'Жанр'"
            };
            joins = new string[] {
                "INNER JOIN director d on m.id_director = d.id INNER JOIN genre g on m.id_genre = g.id WHERE is_del = 0", "ORDER BY id", "ORDER BY id"
            };
            grids = new DataGridView[] { DataGVMovie, DataGVDirector, DataGVGenre };
            countConditions = new string[] { "WHERE is_del = 0", String.Empty, String.Empty };
            tabControl_SelectedIndexChanged(tabControl, new EventArgs());
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = tabControl.SelectedIndex;

            DBProvider.OpenConnection(ConnectionString);
            string sql = String.Format("SELECT {0} FROM {1} {2} LIMIT {3},{4}", fields[index], names[index], joins[index], (page[index]-1) * pageCount, pageCount);

            grids[index].DataSource = DBProvider.ExecuteQuery(sql);
            rowCount[index] = DBProvider.GetRowCount(names[index], countConditions[index]);
            DBProvider.CloseConnection();

            if (((DataTable)(grids[index].DataSource)).Rows.Count == 0 && page[index] != 1)
            {
                page[index]--;
                tabControl_SelectedIndexChanged(tabControl, new EventArgs());
            }

            grids[index].Columns[0].Visible = false; // hide ID column
            PageHandler();
        }

        private void AddMenuItem_Click(object sender, EventArgs e)
        {
            if (index == 0 && (new AddMovieForm(ConnectionString)).ShowDialog() == DialogResult.OK)
            {
                tabControl_SelectedIndexChanged(this, new EventArgs());
            }

            if (index == 1 && (new AddDirectorForm(ConnectionString)).ShowDialog() == DialogResult.OK)
            {
                tabControl_SelectedIndexChanged(this, new EventArgs());
            }

            if (index == 2 && (new AddGenreForm(ConnectionString)).ShowDialog() == DialogResult.OK)
            {
                tabControl_SelectedIndexChanged(this, new EventArgs());
            }
        }

        private void EditMenuItem_Click(object sender, EventArgs e)
        {
            string pk, pkval;

            try
            {
                if (grids[index].SelectedRows.Count != 1) throw new Exception("Нужно выбрать одну строку для редактирования");
                pk = ((DataTable)(grids[index].DataSource)).PrimaryKey[0].ColumnName;
                pkval = (string)grids[index].SelectedRows[0].Cells[pk].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (index == 0 && (new EditMovieForm(ConnectionString, grids[index].SelectedRows[0])).ShowDialog() == DialogResult.OK)
            {
                tabControl_SelectedIndexChanged(this, new EventArgs());
            }

            if (index == 1 && (new EditDirectorForm(ConnectionString, grids[index].SelectedRows[0])).ShowDialog() == DialogResult.OK)
            {
                tabControl_SelectedIndexChanged(this, new EventArgs());
            }

            if (index == 2 && (new EditGenreForm(ConnectionString, grids[index].SelectedRows[0])).ShowDialog() == DialogResult.OK)
            {
                tabControl_SelectedIndexChanged(this, new EventArgs());
            }
        }

        private void DelMenuItem_Click(object sender, EventArgs e)
        {            
            string pk;
            List<string> pkval = new List<string>();

            try
            {
                if (index == 1 || index == 2) throw new Exception("Можно удалять только фильмы");
                if (grids[index].SelectedRows.Count < 1) throw new Exception("Нужно выбрать хотя бы одну строку");
                pk = ((DataTable)(grids[index].DataSource)).PrimaryKey[0].ColumnName;

                foreach (DataGridViewRow SelectedRow in grids[index].SelectedRows)
                    pkval.Add(SelectedRow.Cells[pk].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (MessageBox.Show("Вы уверены, что хотите удалить выбранные записи?", "Удаление", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                using (var con = new MySqlConnection(ConnectionString))
                {
                    MySqlCommand command = new MySqlCommand();
                    string SQL = "UPDATE `movie` SET `is_del` = 1 WHERE id IN (" + String.Join(", ", pkval) + ")";
                    command.CommandText = SQL;
                    command.Connection = con;
                    con.Open();
                    command.ExecuteNonQuery();
                    tabControl_SelectedIndexChanged(this, new EventArgs());
                }
            }
        }

        private void PageHandler()
        {
            int rightSide = (page[index] - 1) * pageCount + pageCount < rowCount[index] ? (page[index] - 1) * pageCount + pageCount : rowCount[index];
            pageLabel.Text = String.Format("{0}-{1} / {2}", (page[index] - 1) * pageCount + 1, rightSide, rowCount[index]);

            if (page[index] == 1)
            {
                prevButton.Enabled = false;
                prevStartButton.Enabled = false;
            }
            else
            {
                prevButton.Enabled = true;
                prevStartButton.Enabled = true;
            }

            if (rightSide == rowCount[index])
            {
                nextButton.Enabled = false;
                nextEndButton.Enabled = false;
            }
            else
            {
                nextButton.Enabled = true;
                nextEndButton.Enabled = true;
            }            
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            page[index]++;
            PageHandler();
            tabControl_SelectedIndexChanged(this, new EventArgs());
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            page[index]--;
            PageHandler();
            tabControl_SelectedIndexChanged(this, new EventArgs());
        }

        private void prevStartButton_Click(object sender, EventArgs e)
        {
            page[index] = 1;
            PageHandler();
            tabControl_SelectedIndexChanged(this, new EventArgs());
        }

        private void nextEndButton_Click(object sender, EventArgs e)
        {
            page[index] = (rowCount[index] % pageCount == 0) ? rowCount[index] / pageCount : rowCount[index] / pageCount + 1;
            PageHandler();
            tabControl_SelectedIndexChanged(this, new EventArgs());
        }
    }
}
