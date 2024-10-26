namespace LOGIN
{
    partial class Trutien
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
            txtTienGoc = new TextBox();
            txtTen = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnXacNhan = new Button();
            label4 = new Label();
            txtTruTienGoc = new TextBox();
            label5 = new Label();
            txtTruTienThuong = new TextBox();
            txtThuong = new TextBox();
            SuspendLayout();
            // 
            // txtTienGoc
            // 
            txtTienGoc.Font = new Font("Segoe UI", 12F);
            txtTienGoc.Location = new Point(216, 120);
            txtTienGoc.Name = "txtTienGoc";
            txtTienGoc.Size = new Size(112, 34);
            txtTienGoc.TabIndex = 11;
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 12F);
            txtTen.Location = new Point(216, 42);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(349, 34);
            txtTen.TabIndex = 10;
            txtTen.TextChanged += txtTen_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(73, 201);
            label3.Name = "label3";
            label3.Size = new Size(80, 28);
            label3.TabIndex = 9;
            label3.Text = "Thưởng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(73, 123);
            label2.Name = "label2";
            label2.Size = new Size(86, 28);
            label2.TabIndex = 8;
            label2.Text = "Tiền gốc";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(73, 45);
            label1.Name = "label1";
            label1.Size = new Size(94, 28);
            label1.TabIndex = 7;
            label1.Text = "Tài khoản";
            // 
            // btnXacNhan
            // 
            btnXacNhan.Font = new Font("Segoe UI", 12F);
            btnXacNhan.Location = new Point(233, 331);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(149, 64);
            btnXacNhan.TabIndex = 13;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(374, 123);
            label4.Name = "label4";
            label4.Size = new Size(39, 28);
            label4.TabIndex = 14;
            label4.Text = "Trừ";
            // 
            // txtTruTienGoc
            // 
            txtTruTienGoc.Font = new Font("Segoe UI", 12F);
            txtTruTienGoc.Location = new Point(453, 120);
            txtTruTienGoc.Name = "txtTruTienGoc";
            txtTruTienGoc.Size = new Size(112, 34);
            txtTruTienGoc.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(374, 201);
            label5.Name = "label5";
            label5.Size = new Size(39, 28);
            label5.TabIndex = 16;
            label5.Text = "Trừ";
            // 
            // txtTruTienThuong
            // 
            txtTruTienThuong.Font = new Font("Segoe UI", 12F);
            txtTruTienThuong.Location = new Point(453, 202);
            txtTruTienThuong.Name = "txtTruTienThuong";
            txtTruTienThuong.Size = new Size(112, 34);
            txtTruTienThuong.TabIndex = 18;
            // 
            // txtThuong
            // 
            txtThuong.Font = new Font("Segoe UI", 12F);
            txtThuong.Location = new Point(216, 202);
            txtThuong.Name = "txtThuong";
            txtThuong.Size = new Size(112, 34);
            txtThuong.TabIndex = 17;
            // 
            // Trutien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 438);
            Controls.Add(txtTruTienThuong);
            Controls.Add(txtThuong);
            Controls.Add(label5);
            Controls.Add(txtTruTienGoc);
            Controls.Add(label4);
            Controls.Add(btnXacNhan);
            Controls.Add(txtTienGoc);
            Controls.Add(txtTen);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Trutien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trutien";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTienGoc;
        private TextBox txtTen;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnXacNhan;
        private Label label4;
        private TextBox txtTruTienGoc;
        private Label label5;
        private TextBox txtTruTienThuong;
        private TextBox txtThuong;
    }
}