namespace LOGIN
{
    partial class Client1
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
            label7 = new Label();
            label8 = new Label();
            btnSHUTDOWN = new Button();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnVQ = new Button();
            btnDD = new Button();
            btnTUIQUA = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTUIQUA);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnSHUTDOWN);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(24, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 437);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin máy";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(122, 209);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 8;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label8.Location = new Point(21, 209);
            label8.Name = "label8";
            label8.Size = new Size(64, 20);
            label8.TabIndex = 7;
            label8.Text = "Điểm số";
            // 
            // btnSHUTDOWN
            // 
            btnSHUTDOWN.Dock = DockStyle.Bottom;
            btnSHUTDOWN.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSHUTDOWN.Location = new Point(3, 384);
            btnSHUTDOWN.Name = "btnSHUTDOWN";
            btnSHUTDOWN.Size = new Size(294, 50);
            btnSHUTDOWN.TabIndex = 6;
            btnSHUTDOWN.Text = "Tắt máy";
            btnSHUTDOWN.UseVisualStyleBackColor = true;
            btnSHUTDOWN.Click += btnSHUTDOWN_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(122, 158);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 5;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 158);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 4;
            label6.Text = "Tiền thưởng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 104);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 104);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 2;
            label4.Text = "Tiền gốc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 50);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 50);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnVQ);
            groupBox2.Controls.Add(btnDD);
            groupBox2.Location = new Point(353, 33);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(202, 434);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Quà";
            // 
            // btnVQ
            // 
            btnVQ.Location = new Point(6, 85);
            btnVQ.Name = "btnVQ";
            btnVQ.Size = new Size(190, 53);
            btnVQ.TabIndex = 1;
            btnVQ.Text = "Vòng quay may mắn";
            btnVQ.UseVisualStyleBackColor = true;
            btnVQ.Click += btnVQ_Click;
            // 
            // btnDD
            // 
            btnDD.Location = new Point(6, 26);
            btnDD.Name = "btnDD";
            btnDD.Size = new Size(190, 53);
            btnDD.TabIndex = 0;
            btnDD.Text = "Quà điểm danh";
            btnDD.UseVisualStyleBackColor = true;
            btnDD.Click += btnDD_Click;
            // 
            // btnTUIQUA
            // 
            btnTUIQUA.Dock = DockStyle.Bottom;
            btnTUIQUA.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTUIQUA.Location = new Point(3, 334);
            btnTUIQUA.Name = "btnTUIQUA";
            btnTUIQUA.Size = new Size(294, 50);
            btnTUIQUA.TabIndex = 9;
            btnTUIQUA.Text = "Mã quà đã nhận";
            btnTUIQUA.UseVisualStyleBackColor = true;
            btnTUIQUA.Click += btnTUIQUA_Click;
            // 
            // Client1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 511);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Client1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client1";
            Activated += Client1_Activated;
            FormClosing += Client1_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button btnSHUTDOWN;
        private GroupBox groupBox2;
        private Button btnDD;
        private Label label7;
        private Label label8;
        private Button btnVQ;
        private Button btnTUIQUA;
    }
}