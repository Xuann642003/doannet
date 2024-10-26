using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LOGIN
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void form1_Load(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=qlqn; password=;";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            mySqlConnection.Open();
            string sql = "SELECT * FROM thong_tin_pb WHERE id = 1";
            MySqlCommand command = new MySqlCommand(sql, mySqlConnection);
            command.Parameters.AddWithValue("@so_may", so_may.Text);
            command.Parameters.AddWithValue("@thoi_gian", thoi_gian.Text);
            command.Parameters.AddWithValue("@phien_ban", phien_ban.Text);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read()) 
                {
                    so_may.Text = reader["so_may"].ToString();
                    thoi_gian.Text = reader["thoi_gian"].ToString();
                    phien_ban.Text = reader["phien_ban"].ToString();
                }
            }
        }
    }
}
