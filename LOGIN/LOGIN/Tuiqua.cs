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
    public partial class Tuiqua : Form
    {
        private string _tendangnhap;
        public Tuiqua(string tendangnhap)
        {
            InitializeComponent();
            _tendangnhap = tendangnhap;
        }

        private void Tuiqua_Load(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=qlqn; password=;";
            using (MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon))
            {
                try
                {
                    mySqlConnection.Open();
                    string sql = "SELECT ma,qua FROM maqua WHERE taikhoan = @taikhoan";
                    MySqlCommand command = new MySqlCommand(sql, mySqlConnection);
                    command.Parameters.AddWithValue("@taikhoan", _tendangnhap);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable); 

                    dataGridView1.DataSource = dataTable;

                    dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    
                    dataGridView1.Columns[0].HeaderText = "Mã";
                    dataGridView1.Columns[1].HeaderText = "Quà";
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
