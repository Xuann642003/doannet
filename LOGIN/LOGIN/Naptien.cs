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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace LOGIN
{
    public partial class Naptien : Form
    {
        string mysqlCon = "server=127.0.0.1; user=root; database=qlqn; password=;";
        public Naptien()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                MessageBox.Show("Vui lòng nhập đúng giá trị", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            mySqlConnection.Open();

            long tien = long.Parse(txtTien.Text);
            long thuong = long.Parse(txtThuong.Text);

            string updateSql = "UPDATE tientaikhoan SET tiengoc = tiengoc + @tien , tienthuong = tienthuong + @thuong WHERE  taikhoan = '" + txtTen.Text + "'";
            MySqlCommand updateCommand = new MySqlCommand(updateSql, mySqlConnection);
            updateCommand.Parameters.AddWithValue("@tien", tien);
            updateCommand.Parameters.AddWithValue("@thuong", thuong);

            updateCommand.ExecuteNonQuery();
            mySqlConnection.Close();

            MessageBox.Show("Nạp tiền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtTien_TextChanged(object sender, EventArgs e)
        {
            long tien = long.Parse(txtTien.Text);
            if (50000 <= tien && tien < 100000)
            {
                txtThuong.Text = 15000.ToString();
            }
            else if (100000 <= tien && tien < 200000)
            {
                txtThuong.Text = 50000.ToString();
            }
            else if (200000 <= tien && tien < 500000)
            {
                txtThuong.Text = 100000.ToString();
            }
            else if (50000 <= tien)
            {
                txtThuong.Text = 500000.ToString();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtThuong.Text = 0.ToString();
        }

        private bool ValidateInputs()
        {
            long tien, thuong;
            if (!long.TryParse(txtTien.Text, out tien) || tien <= 0)
            {
                MessageBox.Show("Vui lòng nhập số", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!long.TryParse(txtThuong.Text, out thuong) || thuong < 0)
            {
                MessageBox.Show("Vui lòng nhập số", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true; 
        }
    }
}
