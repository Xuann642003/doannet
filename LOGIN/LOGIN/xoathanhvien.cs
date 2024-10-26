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
    public partial class xoathanhvien : Form
    {
        public xoathanhvien()
        {
            InitializeComponent();
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=qlqn; password=;";
            try
            {
                using (MySqlConnection con = new MySqlConnection(mysqlCon))
                {
                    con.Open();
                    string deleteQuery = "DELETE FROM tientaikhoan WHERE taikhoan = @taikhoan"; 
                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@taikhoan", txtTK.Text); 
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Thành viên đã được xóa thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thành viên cần xóa.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message);
            }
        }
    }
}
