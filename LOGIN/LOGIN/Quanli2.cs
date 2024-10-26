﻿using System;
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
    public partial class Quanli2 : Form
    {
        public Quanli2()
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
        private void thêmThànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Maytram());
        }

        private void thànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Thanhvien());
        }
    }
}
