using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proglab1
{
    public class DBProvider
    {
        private static MySqlConnection connect = null;

        public static void OpenConnection(string connectionString)
        {
            connect = new MySqlConnection(connectionString);
            connect.Open();
        }

        public static void CloseConnection()
        {
            connect.Close();
        }

        public static bool ExecuteNonQuery(string sql)
        {
            using (MySqlCommand cmd = new MySqlCommand(sql, connect))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }

        public static DataTable ExecuteQuery(string sql)
        {
            DataTable dt = null;
            using (MySqlCommand cmd = new MySqlCommand(sql, connect))
            {
                try
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return dt;
        }

        public static int GetRowCount(string tableName, string condition = "")
        {
            int count = 0;
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.Connection = connect;
                    cmd.CommandText = String.Format("SELECT COUNT(*) FROM {0} {1}", tableName, condition);
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return count;
        }
    }
}
