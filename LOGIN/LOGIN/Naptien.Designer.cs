namespace LOGIN
{
    partial class Naptien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnXacNhan = new Button();
            txtTen = new TextBox();
            txtTien = new TextBox();
            txtThuong = new TextBox();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(73, 45);
            label1.Name = "label1";
            label1.Size = new Size(94, 28);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(73, 123);
            label2.Name = "label2";
            label2.Size = new Size(87, 28);
            label2.TabIndex = 1;
            label2.Text = "Nạp tiền";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(73, 201);
            label3.Name = "label3";
            label3.Size = new Size(80, 28);
            label3.TabIndex = 2;
            label3.Text = "Thưởng";
            // 
            // btnXacNhan
            // 
            btnXacNhan.Font = new Font("Segoe UI", 12F);
            btnXacNhan.Location = new Point(233, 331);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(149, 64);
            btnXacNhan.TabIndex = 3;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 12F);
            txtTen.Location = new Point(216, 42);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(349, 34);
            txtTen.TabIndex = 4;
            // 
            // txtTien
            // 
            txtTien.Font = new Font("Segoe UI", 12F);
            txtTien.Location = new Point(216, 120);
            txtTien.Name = "txtTien";
            txtTien.Size = new Size(349, 34);
            txtTien.TabIndex = 5;
            txtTien.TextChanged += txtTien_TextChanged;
            // 
            // txtThuong
            // 
            txtThuong.Font = new Font("Segoe UI", 12F);
            txtThuong.Location = new Point(216, 198);
            txtThuong.Name = "txtThuong";
            txtThuong.ReadOnly = true;
            txtThuong.Size = new Size(349, 34);
            txtThuong.TabIndex = 6;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(216, 262);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(225, 32);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Lần này không có quà";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Naptien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 438);
            Controls.Add(checkBox1);
            Controls.Add(txtThuong);
            Controls.Add(txtTien);
            Controls.Add(txtTen);
            Controls.Add(btnXacNhan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Naptien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Naptien";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnXacNhan;
        private TextBox txtTen;
        private TextBox txtTien;
        private TextBox txtThuong;
        private CheckBox checkBox1;
    }
}