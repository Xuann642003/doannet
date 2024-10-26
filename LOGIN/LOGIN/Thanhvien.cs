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
    public partial class Thanhvien : Form
    {
        public Thanhvien()
        {
            InitializeComponent();
        }

        private Form currentFormChild;
        private Form currentFormChild1;
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
        private void OpenChildForm1(Form childForm1)
        {
            if (currentFormChild1 != null)
            {
                currentFormChild1.Close();
            }
            currentFormChild1 = childForm1;
            childForm1.TopLevel = false;
            childForm1.FormBorderStyle = FormBorderStyle.None;
            childForm1.Dock = DockStyle.Fill;
            panel_Body1.Controls.Add(childForm1);
            panel_Body1.Tag = childForm1;
            childForm1.BringToFront();
            childForm1.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new themthanhvien());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm1(new xoathanhvien());
        }
    }
}
