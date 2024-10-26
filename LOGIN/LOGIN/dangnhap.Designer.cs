namespace LOGIN
{
    partial class dangnhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtTK = new TextBox();
            txtMK = new TextBox();
            ckbMK = new CheckBox();
            btnLOGIN = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(142, 49);
            label1.Name = "label1";
            label1.Size = new Size(198, 54);
            label1.TabIndex = 0;
            label1.Text = "YannaNET";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTK
            // 
            txtTK.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTK.Location = new Point(36, 142);
            txtTK.Multiline = true;
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(326, 60);
            txtTK.TabIndex = 1;
            txtTK.TextChanged += txtTK_TextChanged;
            // 
            // txtMK
            // 
            txtMK.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMK.Location = new Point(36, 238);
            txtMK.Multiline = true;
            txtMK.Name = "txtMK";
            txtMK.PasswordChar = '*';
            txtMK.Size = new Size(326, 60);
            txtMK.TabIndex = 2;
            // 
            // ckbMK
            // 
            ckbMK.AutoSize = true;
            ckbMK.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbMK.Location = new Point(36, 322);
            ckbMK.Name = "ckbMK";
            ckbMK.Size = new Size(142, 27);
            ckbMK.TabIndex = 3;
            ckbMK.Text = "Nhớ mật khẩu";
            ckbMK.UseVisualStyleBackColor = true;
            // 
            // btnLOGIN
            // 
            btnLOGIN.BackColor = Color.Indigo;
            btnLOGIN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLOGIN.ForeColor = SystemColors.ButtonHighlight;
            btnLOGIN.Location = new Point(36, 364);
            btnLOGIN.Name = "btnLOGIN";
            btnLOGIN.Size = new Size(326, 48);
            btnLOGIN.TabIndex = 4;
            btnLOGIN.Text = "LOGIN";
            btnLOGIN.UseVisualStyleBackColor = false;
            btnLOGIN.Click += btnLOGIN_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 119);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 5;
            label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 212);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 6;
            label3.Text = "Mật khẩu";
            // 
            // dangnhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumOrchid;
            ClientSize = new Size(399, 491);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLOGIN);
            Controls.Add(ckbMK);
            Controls.Add(txtMK);
            Controls.Add(txtTK);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "dangnhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTK;
        private TextBox txtMK;
        private CheckBox ckbMK;
        private Button btnLOGIN;
        private Label label2;
        private Label label3;
    }
}
