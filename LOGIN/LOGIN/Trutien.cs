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
    public partial class Trutien : Form
    {
        string mysqlCon = "server=127.0.0.1; user=root; database=qlqn; password=;";
        public Trutien()
        {
            InitializeComponent();
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            mySqlConnection.Open();
            string sql = "SELECT * FROM tientaikhoan WHERE taikhoan = '" + txtTen.Text + "'";
            MySqlCommand command = new MySqlCommand(sql, mySqlConnection);
            command.Parameters.AddWithValue("@tiengoc", txtTienGoc.Text);
            command.Parameters.AddWithValue("@tienthuong", txtThuong.Text);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    txtTienGoc.Text = reader["tiengoc"].ToString();
                    txtThuong.Text = reader["tienthuong"].ToString();
                }
            }
            mySqlConnection.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            mySqlConnection.Open();

            string checkBalanceSql = "SELECT tiengoc, tienthuong FROM tientaikhoan WHERE taikhoan = @taikhoan";
            MySqlCommand checkBalanceCommand = new MySqlCommand(checkBalanceSql, mySqlConnection);
            checkBalanceCommand.Parameters.AddWithValue("@taikhoan", txtTen.Text);
            MySqlDataReader reader = checkBalanceCommand.ExecuteReader();

            long Tiengoc = 0;
            long Tienthuong = 0;

            if (reader.Read())
            {
                Tiengoc = reader.GetInt64("tiengoc");
                Tienthuong = reader.GetInt64("tienthuong");
            }
            reader.Close();

            if (txtTen.Text == "" && txtTienGoc.Text == "" && txtTruTienGoc.Text == "" && txtTruTienThuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                long sotrutiengoc = long.Parse(txtTruTienGoc.Text);
                long sotrutienthuong = long.Parse(txtTruTienThuong.Text);

                if (sotrutiengoc > Tiengoc)
                {
                    MessageBox.Show("Số tiền vượt quá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (sotrutienthuong > Tienthuong)
                {
                    MessageBox.Show("Số tiền vượt quá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string updateSql = "UPDATE tientaikhoan SET tiengoc = tiengoc - @trutiengoc, tienthuong = tienthuong - @trutienthuong WHERE taikhoan = @taikhoan";
                    MySqlCommand updateCommand = new MySqlCommand(updateSql, mySqlConnection);

                    updateCommand.Parameters.AddWithValue("@trutiengoc", sotrutiengoc);
                    updateCommand.Parameters.AddWithValue("@trutienthuong", sotrutienthuong);
                    updateCommand.Parameters.AddWithValue("@taikhoan", txtTen.Text);
                    updateCommand.ExecuteNonQuery();

                    MessageBox.Show("Trừ tiền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTen.Text = "";
                    txtTienGoc.Text = "";
                    txtThuong.Text = "";
                    txtTruTienGoc.Text = "";
                    txtTruTienThuong.Text = "";
                    txtTen.Focus();
                }
            }
            mySqlConnection.Close();
        }
    }
}
