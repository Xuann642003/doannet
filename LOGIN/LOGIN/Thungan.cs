using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LOGIN
{  
    public partial class Thungan : Form
    {
        private tatca tatcaForm;
        public Thungan()
        {
            InitializeComponent();
            LoadGioHangData();
            ClearGioHangData();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void tấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tatcaForm = new tatca(this);  
            OpenChildForm(tatcaForm);
        }
        public void LoadGioHangData()
        {
            string connectionString = "server=127.0.0.1; user=root; database=qlqn; password=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT giohang.tenhang, giohang.soluong, tatca.gia 
                    FROM giohang 
                    INNER JOIN tatca ON giohang.tenhang = tatca.ten";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            CalculateTotalAmount(); 
        }
        private void ClearGioHangData()
        {
            string connectionString = "server=127.0.0.1; user=root; database=qlqn; password=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM giohang";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
        }
        private void CalculateTotalAmount()
        {
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["soluong"].Value != null && row.Cells["gia"].Value != null)
                {
                    int quantity = Convert.ToInt32(row.Cells["soluong"].Value);
                    decimal price = Convert.ToDecimal(row.Cells["gia"].Value);

                    totalAmount += quantity * price;
                }
            }
            txtTONGTIEN.Text = "Tổng tiền " + totalAmount.ToString("N0"); 
        }
        private void btnTHANHTOAN_Click(object sender, EventArgs e)
        {
            string connectionString = "server=127.0.0.1; user=root; database=qlqn; password=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells["tenhang"].Value != null && row.Cells["soluong"].Value != null)
                        {
                            string tenhang = row.Cells["tenhang"].Value.ToString();
                            int soluongMua = Convert.ToInt32(row.Cells["soluong"].Value);
                            string updateTatcaQuery = "UPDATE tatca SET soluong = soluong - @soluongMua WHERE ten = @tenhang";
                            MySqlCommand updateTatcaCommand = new MySqlCommand(updateTatcaQuery, connection, transaction);
                            updateTatcaCommand.Parameters.AddWithValue("@soluongMua", soluongMua);
                            updateTatcaCommand.Parameters.AddWithValue("@tenhang", tenhang);
                            updateTatcaCommand.ExecuteNonQuery();
                            string insertLichsuQuery = @"
                                INSERT INTO lichsumuahang (thoigian, tenhang, soluong) 
                                VALUES (NOW(), @tenhang, @soluongMua)";
                            MySqlCommand insertLichsuCommand = new MySqlCommand(insertLichsuQuery, connection, transaction);
                            insertLichsuCommand.Parameters.AddWithValue("@tenhang", tenhang);
                            insertLichsuCommand.Parameters.AddWithValue("@soluongMua", soluongMua);
                            insertLichsuCommand.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();
                    ClearGioHangData();
                    LoadGioHangData();
                    MessageBox.Show("Thanh toán thành công!");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Có lỗi xảy ra trong quá trình thanh toán: " + ex.Message);
                }
            }
        }
        private void UpdateSoLuongSanPham(string tenSanPham, int soLuongMua)
        {
            string connectionString = "server=127.0.0.1; user=root; database=qlqn; password=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string querySelect = "SELECT soluong FROM tatca WHERE ten = @tenSanPham";
                MySqlCommand cmdSelect = new MySqlCommand(querySelect, connection);
                cmdSelect.Parameters.AddWithValue("@tenSanPham", tenSanPham);
                int currentSoLuong = Convert.ToInt32(cmdSelect.ExecuteScalar());
                int newSoLuong = currentSoLuong - soLuongMua;
                string queryUpdate = "UPDATE tatca SET soluong = @newSoLuong WHERE ten = @tenSanPham";
                MySqlCommand cmdUpdate = new MySqlCommand(queryUpdate, connection);
                cmdUpdate.Parameters.AddWithValue("@newSoLuong", newSoLuong);
                cmdUpdate.Parameters.AddWithValue("@tenSanPham", tenSanPham);

                cmdUpdate.ExecuteNonQuery();
            }
        }
    }
}
