using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient; 

namespace LOGIN
{
    public partial class vongquay : Form
    {
        private System.Windows.Forms.Timer timer;
        private List<ListView> listViews;
        private int currentIndex = 0;
        private Random random;
        private int selectedIndex;
        private int loopCount = 0; 
        private const int totalLoops = 3;
        private string _tendangnhap;

        public vongquay(string tendangnhap)
        {
            InitializeComponent();
            listViews = new List<ListView>
            {
                listView1, listView2, listView3, listView4, listView5, listView6,
                listView7, listView8, listView9, listView10, listView11, listView12
            };

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 200;
            timer.Tick += Timer_Tick;

            random = new Random();
            LoadDataFromDatabase();

            _tendangnhap = tendangnhap;
        }

        private void LoadDataFromDatabase()
        {
            string connectionString = "server=127.0.0.1; user=root; database=qlqn; password=;";
            string query = "SELECT id, giatriqua FROM vongquay";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int i = 0;
                while (reader.Read() && i < listViews.Count)
                {
                    listViews[i].Items.Add($"{reader["giatriqua"]}");
                    i++;
                }
                reader.Close();
            }
        }

        private void btnQUAY_Click(object sender, EventArgs e)
        {
            foreach (var listView in listViews)
            {
                listView.BackColor = SystemColors.Window;
            }
            currentIndex = 0;
            loopCount = 0;
            selectedIndex = random.Next(listViews.Count);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                listViews[currentIndex - 1].BackColor = SystemColors.Window;
            }
            else
            {
                listViews[listViews.Count - 1].BackColor = SystemColors.Window;
            }
            listViews[currentIndex].BackColor = Color.Aqua;
            if (loopCount < totalLoops)
            {
                if (currentIndex == listViews.Count - 1)
                {
                    loopCount++; 
                }
            }
            else
            {
                if (currentIndex == selectedIndex)
                {
                    timer.Stop();
                    ShowMessageForSelectedIndex(selectedIndex); 
                    string randomCode = GenerateRandomCode();
                    InsertIntoMaqua(selectedIndex, randomCode); 
                }
            }
            currentIndex = (currentIndex + 1) % listViews.Count;
        }

        private void ShowMessageForSelectedIndex(int index)
        {
            string message = listViews[index].Items[0].Text;
            MessageBox.Show("Bạn đã trúng giải: " + message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GenerateRandomCode()
        {
            List<int> numbers = Enumerable.Range(0, 10).OrderBy(x => random.Next()).Take(6).ToList();
            return string.Join("", numbers);
        }

        private void InsertIntoMaqua(int prizeIndex, string randomCode)
        {
            string prizeName = listViews[prizeIndex].Items[0].Text;
            int prizeId = GetPrizeIdFromIndex(prizeIndex);

            if (prizeId == 10)
            {
                MessageBox.Show($"Chúc bạn may mắn lần sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string connectionString = "server=127.0.0.1; user=root; database=qlqn; password=;";
                string queryMaqua = "INSERT INTO maqua (taikhoan, ma, qua) VALUES (@taikhoan, @ma, @qua)";
                string queryLichSuQua = "INSERT INTO lichsuqua (thoigian, taikhoan, cachnhan, qua) VALUES (NOW(), @taikhoan, @cachnhan, @qua)";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand commandMaqua = new MySqlCommand(queryMaqua, connection))
                    {
                        commandMaqua.Parameters.AddWithValue("@taikhoan", _tendangnhap);
                        commandMaqua.Parameters.AddWithValue("@ma", randomCode);
                        commandMaqua.Parameters.AddWithValue("@qua", prizeName);
                        commandMaqua.ExecuteNonQuery();
                    }
                    using (MySqlCommand commandLichSuQua = new MySqlCommand(queryLichSuQua, connection))
                    {
                        commandLichSuQua.Parameters.AddWithValue("@taikhoan", _tendangnhap);
                        commandLichSuQua.Parameters.AddWithValue("@cachnhan", "Vòng quay may mắn");
                        commandLichSuQua.Parameters.AddWithValue("@qua", prizeName);
                        commandLichSuQua.ExecuteNonQuery();
                    }
                }
                MessageBox.Show($"Mã quà: {randomCode} đã được lưu cho giải: {prizeName}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int GetPrizeIdFromIndex(int prizeIndex)
        {
            string connectionString = "server=127.0.0.1; user=root; database=qlqn; password=;";
            string query = "SELECT id FROM vongquay LIMIT @index, 1";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@index", prizeIndex);

                connection.Open();
                object result = command.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }

    }
}
