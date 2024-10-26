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
    public partial class themthanhvien : Form
    {
        string mysqlCon = "server=127.0.0.1; user=root; database=qlqn; password=;";
        public themthanhvien()
        {
            InitializeComponent();
            txtTK.Focus();
        }

        private void btnREGISTER_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mySqlConnection.Open();

                string tendangnhap = "";
                string sql1 = "SELECT tendangnhap FROM dangki WHERE tendangnhap = @tendangnhap";
                MySqlCommand command1 = new MySqlCommand(sql1, mySqlConnection);
                command1.Parameters.AddWithValue("@tendangnhap", txtTK.Text); 

                MySqlDataReader reader = command1.ExecuteReader();
                bool isExisting = false;

                if (reader.Read())
                {
                    isExisting = true; 
                }

                reader.Close();

                if (isExisting)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông báo");
                    txtTK.Focus();
                }
                else
                {
                    if (!string.IsNullOrEmpty(txtTK.Text) && !string.IsNullOrEmpty(txtMK.Text))
                    {
                        if (txtMK.Text == txtMK1.Text)
                        {
                            string sql = "INSERT INTO dangki (tendangnhap, matkhau, role) VALUES (@tendangnhap, @matkhau, @role)";
                            MySqlCommand command = new MySqlCommand(sql, mySqlConnection);
                            command.Parameters.AddWithValue("@tendangnhap", txtTK.Text);
                            command.Parameters.AddWithValue("@matkhau", txtMK.Text);
                            command.Parameters.AddWithValue("@role", "1");

                            int result = command.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Đăng kí thành công", "Thông báo");
                                txtTK.Text = "";
                                txtMK.Text = "";
                                txtMK1.Text = "";
                                txtTK.Focus();
                            }
                            else
                            {
                                MessageBox.Show("Đăng kí thất bại", "Thông báo");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không trùng khớp", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống", "Thông báo");
                    }
                }

                string sql2 = "INSERT INTO tientaikhoan (taikhoan, tiengoc, tienthuong, diem) VALUES (@taikhoan, @tiengoc, @tienthuong, @diem)";
                MySqlCommand command2 = new MySqlCommand(sql2, mySqlConnection);
                command2.Parameters.AddWithValue("@taikhoan", txtTK.Text);
                command2.Parameters.AddWithValue("@tiengoc", "0");
                command2.Parameters.AddWithValue("@tienthuong", "0");
                command2.Parameters.AddWithValue("@diem", "0");
                command2.ExecuteNonQuery();
                mySqlConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void btnRESET_Click(object sender, EventArgs e)
        {
            txtTK.Text = "";
            txtMK.Text = "";
            txtMK1.Text = "";
            txtTK.Focus();
        }
    }
}
