using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace LOGIN
{
    static class DataAccess
    {
        private static string connectionString = "server=127.0.0.1;user=root;database=qlktx;password=;";

        private static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public static DataTable GetTable(string sql)
        {
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    using (MySqlDataAdapter ad = new MySqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        ad.Fill(dt);
                        return dt;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    return null;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public static void ThemSuaXoa(string sql)
        {
            MySqlConnection con = GetConnection();
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }
        public static ArrayList GetList(string sql)
        {
            DataTable tb = GetTable(sql);
            ArrayList kq = new ArrayList();

            for (int i = 0; i < tb.Rows.Count; i++)
            {
                string key = tb.Rows[i][0].ToString();
                if (kq.IndexOf(key) < 0)
                    kq.Add(key);
            }
            return kq;
        }
        public static string getAValue(string sql)
        {
            MySqlConnection con = GetConnection();
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            object rs = cmd.ExecuteScalar();
            con.Close();
            cmd.Dispose();
            if (rs == null)
                return "";
            else
                return rs.ToString();
        }
    }
}

