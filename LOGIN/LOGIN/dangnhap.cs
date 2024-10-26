using MySql.Data.MySqlClient;

namespace LOGIN
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=qlqn; password=;";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mySqlConnection.Open();
                string sql = "SELECT * FROM dangki WHERE tendangnhap = @tendangnhap AND matkhau = @matkhau";
                MySqlCommand command = new MySqlCommand(sql, mySqlConnection);
                command.Parameters.AddWithValue("@tendangnhap", txtTK.Text);
                command.Parameters.AddWithValue("@matkhau", txtMK.Text);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int role = Convert.ToInt32(reader["role"]);

                    if (role == 0)
                    {
                        MessageBox.Show("Đăng nhập thành công với tư cách Admin", "Thông báo", MessageBoxButtons.OK);
                        TRANGCHU tql = new TRANGCHU();
                        tql.Show();
                    }
                    else if (role == 1)
                    {
                        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK);
                        Client tql = new Client();
                        tql.Show();
                    }
                    this.Hide();
                }
                else if (txtTK.Text == "" || txtMK.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tài khoản hoặc mật khẩu!");
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (mySqlConnection.State == System.Data.ConnectionState.Open)
                {
                    mySqlConnection.Close();
                }
            }

            try
            {
                mySqlConnection.Open();
                string sql = "INSERT INTO dangnhap VALUES (@tendangnhap , @matkhau)";
                MySqlCommand command = new MySqlCommand(sql, mySqlConnection);
                command.Parameters.AddWithValue("@tendangnhap", txtTK.Text);
                command.Parameters.AddWithValue("@matkhau", txtMK.Text);
                MySqlDataReader reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (mySqlConnection.State == System.Data.ConnectionState.Open)
                {
                    mySqlConnection.Close();
                }
            }
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnREGISTER_Click(object sender, EventArgs e)
        {
            //dangki dk = new dangki();
            //dk.ShowDialog();
        }
    }
}
