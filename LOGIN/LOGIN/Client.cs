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
using THANHVIEN;

namespace LOGIN
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void btnNHANTHUONG_Click(object sender, EventArgs e)
        {

        }

        private void btnDANGNHAP_Click(object sender, EventArgs e)
        {
            //string randomString = GenerateRandomString(5);
            //MessageBox.Show(randomString, "Chuỗi ngẫu nhiên");
            

            string mysqlCon = "server=127.0.0.1; user=root; database=qlqn; password=;";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mySqlConnection.Open();
                string sql = "SELECT * FROM dangki WHERE tendangnhap = @tendangnhap AND matkhau = @matkhau";
                MySqlCommand command = new MySqlCommand(sql, mySqlConnection);
                command.Parameters.AddWithValue("@tendangnhap", txtTK.Text);
                command.Parameters.AddWithValue("@matkhau", txtMK.Text);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string tendangnhap = reader["tendangnhap"].ToString();
                        string matkhau = reader["matkhau"].ToString();

                        if (tendangnhap == txtTK.Text && matkhau == txtMK.Text)
                        {
                            MessageBox.Show("Đăng nhập thành công tài khoản" + tendangnhap, "Thông báo");
                            Client1 client1 = new Client1(tendangnhap);
                            client1.Show();
                        }
                        else
                        {
                            MessageBox.Show("Đăng nhập không thành công", "Thông báo");
                        }
                    }
                }
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
        //private string GenerateRandomString(int length)
        //{
        //    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        //    Random random = new Random();
        //    char[] stringChars = new char[length];
        //    for (int i = 0; i < length; i++)
        //    {
        //        stringChars[i] = chars[random.Next(chars.Length)];
        //    }
        //    return new string(stringChars);
        //}
    }
}
