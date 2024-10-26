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
    public partial class TRANGCHU : Form
    {
        public TRANGCHU()
        {
            InitializeComponent();
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
        private void TRANGCHU_Load(object sender, EventArgs e)
        {

        }

        private void btnTRANGCHU_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Quanli1());
        }

        private void btnTHEMTV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Quanli2());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Quanli3());
        }
    }
}
