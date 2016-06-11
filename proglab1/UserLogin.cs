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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text;
            string pass = PasswordTextBox.Text;

            string con = "Data Source=localhost;User Id=" + login + ";Password=" + pass;
            MySqlConnection myConnection = new MySqlConnection(con);

            try
            {
                myConnection.Open();
                myConnection.Close();
                MainForm MyForm = new MainForm(login, pass);
                MyForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
