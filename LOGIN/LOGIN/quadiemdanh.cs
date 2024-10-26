using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace LOGIN
{
    public partial class quadiemdanh : Form
    {
        private string tendangnhap;
        public quadiemdanh(string tendangnhap)
        {
            InitializeComponent();
            ShowDays();
            this.tendangnhap = tendangnhap;

            for (int i = 1; i <= 30; i++)
            {
                Button btn = this.Controls.Find("button" + i, true).FirstOrDefault() as Button;
                if (btn != null)
                {
                    btn.Click += button_Click; 
                }
            }
        }
        private int GetDiemByNgay(int ngay)
        {
            int diem = 0;
            string mysqlCon = "server=127.0.0.1; user=root; database=qlqn; password=;";
            using (var connection = new MySqlConnection(mysqlCon))
            {
                connection.Open();
                string query = "SELECT diem FROM diemdanh WHERE ngay = @ngay";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ngay", ngay);
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        diem = Convert.ToInt32(result);
                    }
                }
            }
            return diem;
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                int buttonNumber;
                if (int.TryParse(clickedButton.Name.Replace("button", ""), out buttonNumber))
                {
                    int diemthuong = GetDiemByNgay(buttonNumber); 
                    UpdateDiem(diemthuong);  
                }
            }
        }
        private void UpdateDiem(int diemthuong)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=qlqn; password=;";
            using (var connection = new MySqlConnection(mysqlCon))
            {
                connection.Open();
                string query = "UPDATE tientaikhoan SET diem = diem + @diemthuong WHERE taikhoan = @tendangnhap";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@diemthuong", diemthuong);
                    command.Parameters.AddWithValue("@tendangnhap", tendangnhap);
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Bạn đã nhận được " + diemthuong + " điểm!");
        }

        private void ShowDays()
        {
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            int daysInMonth = DateTime.DaysInMonth(year, month);

            for (int i = 1; i <= 31; i++)
            {
                Control[] controls = this.Controls.Find("button" + i, true);
                if (controls.Length > 0 && controls[0] is Button btn)
                {
                    btn.Visible = false;
                }
            }
            for (int i = 1; i <= daysInMonth; i++)
            {
                Control[] controls = this.Controls.Find("button" + i, true);
                if (controls.Length > 0 && controls[0] is Button btn)
                {
                    btn.Visible = true;
                    btn.Text = "Ngày " + i;
                }
            }
        }

    }
}
