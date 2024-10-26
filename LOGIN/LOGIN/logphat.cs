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

namespace LOGIN
{
    public partial class logphat: Form
    {
        public logphat()
        {
            InitializeComponent();

            string mysqlCon = "server=127.0.0.1; user=root; database=qlqn; password=;";
            using (MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon))
            {
                try
                {
                    mySqlConnection.Open();
                    string sql = "SELECT thoigiandoi, taikhoan, ma, qua FROM log_phat ";
                    MySqlCommand command = new MySqlCommand(sql, mySqlConnection);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                    dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    dataGridView1.Columns[0].HeaderText = "Thời Gian Đổi";
                    dataGridView1.Columns[1].HeaderText = "Tài Khoản";
                    dataGridView1.Columns[2].HeaderText = "Mã";
                    dataGridView1.Columns[3].HeaderText = "Quà";
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("An error occurred while connecting to the database: " + ex.Message);
                }
                finally
                {
                    mySqlConnection.Close();
                }
            }
        }
    }
}
