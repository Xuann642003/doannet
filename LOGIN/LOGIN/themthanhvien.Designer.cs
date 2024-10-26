namespace LOGIN
{
    partial class themthanhvien
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
            label3 = new Label();
            label2 = new Label();
            btnREGISTER = new Button();
            txtMK = new TextBox();
            txtTK = new TextBox();
            btnRESET = new Button();
            label1 = new Label();
            txtMK1 = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 128);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 11;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 35);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 10;
            label2.Text = "Tên đăng nhập";
            // 
            // btnREGISTER
            // 
            btnREGISTER.BackColor = Color.Aqua;
            btnREGISTER.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnREGISTER.ForeColor = Color.Black;
            btnREGISTER.Location = new Point(13, 304);
            btnREGISTER.Name = "btnREGISTER";
            btnREGISTER.Size = new Size(296, 48);
            btnREGISTER.TabIndex = 9;
            btnREGISTER.Text = "Thêm";
            btnREGISTER.UseVisualStyleBackColor = false;
            btnREGISTER.Click += btnREGISTER_Click;
            // 
            // txtMK
            // 
            txtMK.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMK.Location = new Point(12, 154);
            txtMK.Multiline = true;
            txtMK.Name = "txtMK";
            txtMK.PasswordChar = '*';
            txtMK.Size = new Size(297, 52);
            txtMK.TabIndex = 8;
            // 
            // txtTK
            // 
            txtTK.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTK.Location = new Point(12, 58);
            txtTK.Multiline = true;
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(297, 52);
            txtTK.TabIndex = 7;
            // 
            // btnRESET
            // 
            btnRESET.BackColor = Color.Aqua;
            btnRESET.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRESET.ForeColor = Color.Black;
            btnRESET.Location = new Point(13, 358);
            btnRESET.Name = "btnRESET";
            btnRESET.Size = new Size(296, 48);
            btnRESET.TabIndex = 12;
            btnRESET.Text = "Nhập lại";
            btnRESET.UseVisualStyleBackColor = false;
            btnRESET.Click += btnRESET_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 220);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 14;
            label1.Text = "Nhập lại mật khẩu";
            // 
            // txtMK1
            // 
            txtMK1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMK1.Location = new Point(12, 246);
            txtMK1.Multiline = true;
            txtMK1.Name = "txtMK1";
            txtMK1.PasswordChar = '*';
            txtMK1.Size = new Size(297, 52);
            txtMK1.TabIndex = 13;
            // 
            // themthanhvien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(399, 491);
            Controls.Add(label1);
            Controls.Add(txtMK1);
            Controls.Add(btnRESET);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnREGISTER);
            Controls.Add(txtMK);
            Controls.Add(txtTK);
            Name = "themthanhvien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTER";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Button btnREGISTER;
        private TextBox txtMK;
        private TextBox txtTK;
        private Button btnRESET;
        private Label label1;
        private TextBox txtMK1;
    }
}