using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace LOGIN
{
    public partial class Client1 : Form
    {
        private string _tendangnhap;
        private System.Windows.Forms.Timer timer;

        public Client1(string tendangnhap)
        {
            InitializeComponent();
            _tendangnhap = tendangnhap;
            LoadUserData();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            LoadUserData();
            ReduceMoneyAndUpdateData();
        }

        private void LoadUserData()
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=qlqn; password=;";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mySqlConnection.Open();
                string sql = "SELECT * FROM tientaikhoan WHERE taikhoan = @taikhoan";
                MySqlCommand command = new MySqlCommand(sql, mySqlConnection);
                command.Parameters.AddWithValue("@taikhoan", _tendangnhap);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        label2.Text = reader["taikhoan"].ToString();
                        label3.Text = reader["tiengoc"].ToString();
                        label5.Text = reader["tienthuong"].ToString();
                        label7.Text = reader["diem"].ToString();
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

        private void ReduceMoneyAndUpdateData()
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=qlqn; password=;";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            int giaTien = 0;

            try
            {
                mySqlConnection.Open();
                string sqlGiaTien = "SELECT giatien FROM giatien WHERE id = 1";
                MySqlCommand commandGiaTien = new MySqlCommand(sqlGiaTien, mySqlConnection);

                object result = commandGiaTien.ExecuteScalar();

                if (result != null)
                {
                    giaTien = Convert.ToInt32(result);
                }
                int tienGoc = int.Parse(label3.Text);
                int tienThuong = int.Parse(label5.Text);

                if (tienGoc > 0)
                {
                    tienGoc -= (giaTien / 3600);
                    if (tienGoc < 0)
                    {
                        tienGoc = 0;
                    }
                    label3.Text = tienGoc.ToString();
                }
                else if (tienGoc == 0 && tienThuong > 0)
                {
                    tienThuong -= (giaTien / 3600);
                    if (tienThuong < 0)
                    {
                        tienThuong = 0;
                    }
                    label5.Text = tienThuong.ToString();
                }

                UpdateMoney(tienGoc, tienThuong);
                LoadUserData();
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

        private void UpdateMoney(int tienGoc, int tienThuong)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=qlqn; password=;";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mySqlConnection.Open();
                string sql = "UPDATE tientaikhoan SET tiengoc = @tiengoc, tienthuong = @tienthuong WHERE taikhoan = @taikhoan";
                MySqlCommand command = new MySqlCommand(sql, mySqlConnection);
                command.Parameters.AddWithValue("@tiengoc", tienGoc);
                command.Parameters.AddWithValue("@tienthuong", tienThuong);
                command.Parameters.AddWithValue("@taikhoan", _tendangnhap);

                command.ExecuteNonQuery();
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

        private void btnSHUTDOWN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDD_Click(object sender, EventArgs e)
        {
            quadiemdanh qdd = new quadiemdanh(_tendangnhap);
            qdd.Show();
        }

        private void Client1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
            }
        }

        private void Client1_Activated(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void btnVQ_Click(object sender, EventArgs e)
        {
            vongquay vq = new vongquay(_tendangnhap);
            vq.Show();
        }

        private void btnTUIQUA_Click(object sender, EventArgs e)
        {
            Tuiqua tq = new Tuiqua(_tendangnhap);
            tq.Show();
        }
    }
}
