namespace LOGIN
{
    partial class form1
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
            groupBox2 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            phien_ban = new Label();
            thoi_gian = new Label();
            so_may = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLight;
            groupBox2.Location = new Point(838, 153);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(272, 557);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(108, 100);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 1;
            label1.Text = "Tên cyber";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(108, 183);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 2;
            label2.Text = "Khu vực";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.Location = new Point(272, 100);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 3;
            label4.Text = "YannaNET";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.Location = new Point(272, 183);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 4;
            label3.Text = "Việt Nam";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Aqua;
            panel1.Controls.Add(phien_ban);
            panel1.Controls.Add(thoi_gian);
            panel1.Controls.Add(so_may);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(48, 278);
            panel1.Name = "panel1";
            panel1.Size = new Size(587, 203);
            panel1.TabIndex = 5;
            // 
            // phien_ban
            // 
            phien_ban.AutoSize = true;
            phien_ban.Location = new Point(385, 105);
            phien_ban.Name = "phien_ban";
            phien_ban.Size = new Size(18, 20);
            phien_ban.TabIndex = 11;
            phien_ban.Text = "X";
            // 
            // thoi_gian
            // 
            thoi_gian.AutoSize = true;
            thoi_gian.Location = new Point(187, 105);
            thoi_gian.Name = "thoi_gian";
            thoi_gian.Size = new Size(18, 20);
            thoi_gian.TabIndex = 10;
            thoi_gian.Text = "X";
            // 
            // so_may
            // 
            so_may.AutoSize = true;
            so_may.Location = new Point(44, 105);
            so_may.Name = "so_may";
            so_may.Size = new Size(18, 20);
            so_may.TabIndex = 9;
            so_may.Text = "X";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(385, 27);
            label7.Name = "label7";
            label7.Size = new Size(149, 20);
            label7.TabIndex = 8;
            label7.Text = "Phiên bản phần mềm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(187, 27);
            label6.Name = "label6";
            label6.Size = new Size(134, 20);
            label6.TabIndex = 7;
            label6.Text = "Thời gian qua đêm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(44, 27);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 6;
            label5.Text = "Số lượng máy";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(99, 153);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(683, 557);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(50, 46);
            label8.Name = "label8";
            label8.Size = new Size(268, 46);
            label8.TabIndex = 2;
            label8.Text = "Quản lí quán net";
            // 
            // button1
            // 
            button1.BackColor = Color.Aqua;
            button1.Image = Properties.Resources.computerscreen_102708;
            button1.Location = new Point(24, 85);
            button1.Name = "button1";
            button1.Size = new Size(78, 55);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Aqua;
            button2.Image = Properties.Resources._1491254387_pindestinationmaplocation_82942;
            button2.Location = new Point(24, 168);
            button2.Name = "button2";
            button2.Size = new Size(78, 55);
            button2.TabIndex = 7;
            button2.UseVisualStyleBackColor = false;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1383, 806);
            Controls.Add(label8);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "form1";
            Text = "form1";
            Load += form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private Label phien_ban;
        private Label thoi_gian;
        private Label so_may;
        private Label label7;
        private Label label6;
        private Label label5;
        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private Label label8;
    }
}