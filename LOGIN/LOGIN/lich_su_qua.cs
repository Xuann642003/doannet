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
    public partial class lich_su_qua : Form
    {
        string connectionString = "server=127.0.0.1; user=root; database=qlqn; password=;";
        public lich_su_qua()
        {
            InitializeComponent();
        }
        private void lich_su_qua_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM lichsuqua";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;

                        dataGridView1.Columns[0].HeaderText = "Thời gian";
                        dataGridView1.Columns[1].HeaderText = "Tài khoản";
                        dataGridView1.Columns[2].HeaderText = "Cách nhận";
                        dataGridView1.Columns[3].HeaderText = "Quà thưởng";

                        dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnTIM_Click(object sender, EventArgs e)
        {
            string searchValue = txtTen.Text.Trim().ToLower();
            dataGridView1.ClearSelection(); 

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isMatch = false; 
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchValue))
                    {
                        isMatch = true; 
                        break; 
                    }
                }
                if (isMatch)
                {
                    row.Selected = true; 
                    dataGridView1.FirstDisplayedScrollingRowIndex = row.Index; 
                    return; 
                }
            }
            MessageBox.Show("Không tìm thấy kết quả nào khớp.");
        }
    }
}
   
