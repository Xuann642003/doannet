using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LOGIN
{
    public partial class tatca : Form
    {
        ImageList imageList = new ImageList();
        private Thungan thunganForm; 

        public tatca(Thungan thungan)
        {
            InitializeComponent();
            thunganForm = thungan; 
            SetupListView();
            LoadSanPhamFromDatabase();
        }
        public tatca()
        {
            InitializeComponent();
            SetupListView();
            LoadSanPhamFromDatabase();
        }

        private void SetupListView()
        {
            imageList.ImageSize = new Size(100, 100);
            listView1.View = View.Tile;
            listView1.TileSize = new Size(200, 130);
            listView1.Columns.Add("Tên sản phẩm", 150);
            listView1.Columns.Add("Số lượng", 100);
            listView1.LargeImageList = imageList;
        }

        private void LoadSanPhamFromDatabase()
        {
            string connectionString = "server=127.0.0.1; user=root; database=qlqn; password=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT anh, ten, soluong FROM tatca";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    int imageIndex = 0;

                    while (reader.Read())
                    {
                        string tenSanPham = reader.GetString("ten");
                        int soLuong = reader.GetInt32("soluong");
                        string anh = reader.GetString("anh");

                        // Try to load the image from the file path
                        Image img = null;
                        try
                        {
                            img = Image.FromFile(anh);
                            imageList.Images.Add(img);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error loading image for product {tenSanPham}: {ex.Message}");
                            continue;  // Skip this item if the image failed to load
                        }

                        // Create a ListViewItem with the product name and quantity
                        ListViewItem item = new ListViewItem(tenSanPham);
                        item.SubItems.Add(soLuong.ToString());

                        // Assign the image index to the ListViewItem (since the image was added to the ImageList)
                        item.ImageIndex = imageIndex++;

                        // Add the item to the ListView
                        listView1.Items.Add(item);
                    }
                }
            }
        }



        private void listView1_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string tenSanPham = selectedItem.Text;  // Get the product name
                int soLuong = int.Parse(selectedItem.SubItems[1].Text);  // Get the product quantity

                if (soLuong > 0)
                {
                    // Assuming each click adds 1 product to the cart
                    int soLuongMua = 1;

                    // Insert selected product into 'giohang' table
                    InsertSanPhamGioHang(tenSanPham, soLuongMua);

                    // Update 'tatca' product quantity in the database
                    //UpdateSoLuongSanPham(tenSanPham, soLuongMua);
                    thunganForm.LoadGioHangData();
                }
                else
                {
                    MessageBox.Show("Sản phẩm này đã hết hàng.");
                }
            }
        }
        private void InsertSanPhamGioHang(string tenSanPham, int soLuong)
        {
            string connectionString = "server=127.0.0.1; user=root; database=qlqn; password=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Check if the product already exists in the 'giohang' table
                string checkQuery = "SELECT soluong FROM giohang WHERE tenhang = @tenhang";
                MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@tenhang", tenSanPham);

                object result = checkCommand.ExecuteScalar();

                if (result != null) // If product exists
                {
                    int currentQuantity = Convert.ToInt32(result);
                    int newQuantity = currentQuantity + soLuong;

                    // Update the existing product quantity
                    string updateQuery = "UPDATE giohang SET soluong = @newSoluong WHERE tenhang = @tenhang";
                    MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@newSoluong", newQuantity);
                    updateCommand.Parameters.AddWithValue("@tenhang", tenSanPham);

                    updateCommand.ExecuteNonQuery();
                }
                else // If product does not exist
                {
                    // Insert the product as a new entry
                    string insertQuery = "INSERT INTO giohang (tenhang, soluong) VALUES (@tenhang, @soluong)";
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@tenhang", tenSanPham);
                    insertCommand.Parameters.AddWithValue("@soluong", soLuong);

                    insertCommand.ExecuteNonQuery();
                }
            }
        }

    }
}
