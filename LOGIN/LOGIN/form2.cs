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
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
            this.Location = new Point(100, 100);
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void lịchSửQuàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new lich_su_qua());
        }
        private void btnPHAT_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=qlqn; password=;";
            using (MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon))
            {
                try
                {
                    mySqlConnection.Open();
                    string maInput = txtMa.Text.Trim();
                    string checkSql = "SELECT taikhoan, qua FROM maqua WHERE ma = @ma";
                    using (MySqlCommand checkCommand = new MySqlCommand(checkSql, mySqlConnection))
                    {
                        checkCommand.Parameters.AddWithValue("@ma", maInput);
                        using (MySqlDataReader reader = checkCommand.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                string taikhoan = reader["taikhoan"].ToString();
                                string qua = reader["qua"].ToString();

                                reader.Close(); 
                                string deleteSql = "DELETE FROM maqua WHERE ma = @ma";
                                using (MySqlCommand deleteCommand = new MySqlCommand(deleteSql, mySqlConnection))
                                {
                                    deleteCommand.Parameters.AddWithValue("@ma", maInput);
                                    deleteCommand.ExecuteNonQuery();
                                }

                                string logSql = "INSERT INTO log_phat VALUES (NOW(), @taikhoan, @ma , @quathuong)";
                                using (MySqlCommand logCommand = new MySqlCommand(logSql, mySqlConnection))
                                {
                                    logCommand.Parameters.AddWithValue("@taikhoan", taikhoan);
                                    logCommand.Parameters.AddWithValue("@ma", maInput); 
                                    logCommand.Parameters.AddWithValue("@quathuong", qua);
                                    logCommand.ExecuteNonQuery();
                                }

                                MessageBox.Show("Đã nhận: " + qua, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtMa.Text = "";
                                txtMa.Focus();
                            }
                            else
                            {
                                MessageBox.Show("Mã không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("An error occurred while accessing the database: " + ex.Message);
                }
                finally
                {
                    mySqlConnection.Close();
                }
            }
        }
        private void logsPhátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new logphat());
        }
    }
}
