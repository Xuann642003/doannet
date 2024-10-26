namespace LOGIN
{
    partial class Client
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
            groupBox1 = new GroupBox();
            btnDANGNHAP = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            txtTK = new TextBox();
            txtMK = new TextBox();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 696);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Client1";
            // 
            // btnDANGNHAP
            // 
            btnDANGNHAP.Dock = DockStyle.Bottom;
            btnDANGNHAP.Location = new Point(3, 131);
            btnDANGNHAP.Name = "btnDANGNHAP";
            btnDANGNHAP.Size = new Size(288, 65);
            btnDANGNHAP.TabIndex = 0;
            btnDANGNHAP.Text = "Đăng nhập";
            btnDANGNHAP.UseVisualStyleBackColor = true;
            btnDANGNHAP.Click += btnDANGNHAP_Click;
            // 
            // groupBox2
            // 
            groupBox2.Dock = DockStyle.Left;
            groupBox2.Location = new Point(300, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 696);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Client2";
            // 
            // groupBox3
            // 
            groupBox3.Dock = DockStyle.Left;
            groupBox3.Location = new Point(600, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(300, 696);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Client3";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtMK);
            groupBox4.Controls.Add(txtTK);
            groupBox4.Controls.Add(btnDANGNHAP);
            groupBox4.Dock = DockStyle.Top;
            groupBox4.Location = new Point(3, 23);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(294, 199);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "ĐĂNG NHẬP";
            // 
            // txtTK
            // 
            txtTK.Dock = DockStyle.Top;
            txtTK.Location = new Point(3, 23);
            txtTK.Multiline = true;
            txtTK.Name = "txtTK";
            txtTK.PlaceholderText = "Tên đăng nhập";
            txtTK.Size = new Size(288, 45);
            txtTK.TabIndex = 1;
            // 
            // txtMK
            // 
            txtMK.Dock = DockStyle.Top;
            txtMK.Location = new Point(3, 68);
            txtMK.Multiline = true;
            txtMK.Name = "txtMK";
            txtMK.PasswordChar = '*';
            txtMK.PlaceholderText = "Mật khẩu";
            txtMK.Size = new Size(288, 45);
            txtMK.TabIndex = 2;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1369, 696);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Client";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client";
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnDANGNHAP;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private TextBox txtMK;
        private TextBox txtTK;
    }
}