namespace LOGIN
{
    partial class Thanhvien
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
            panel_Body = new Panel();
            button1 = new Button();
            groupBox2 = new GroupBox();
            panel_Body1 = new Panel();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel_Body);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(329, 654);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // panel_Body
            // 
            panel_Body.Dock = DockStyle.Fill;
            panel_Body.Location = new Point(3, 94);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(323, 557);
            panel_Body.TabIndex = 1;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(3, 23);
            button1.Name = "button1";
            button1.Size = new Size(323, 71);
            button1.TabIndex = 0;
            button1.Text = "Thêm thành viên";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel_Body1);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(347, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(329, 654);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // panel_Body1
            // 
            panel_Body1.Dock = DockStyle.Fill;
            panel_Body1.Location = new Point(3, 94);
            panel_Body1.Name = "panel_Body1";
            panel_Body1.Size = new Size(323, 557);
            panel_Body1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.Location = new Point(3, 23);
            button2.Name = "button2";
            button2.Size = new Size(323, 71);
            button2.TabIndex = 0;
            button2.Text = "Xóa thành viên";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Thanhvien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1306, 678);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Thanhvien";
            Text = "Thành viên";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Panel panel_Body;
        private GroupBox groupBox2;
        private Panel panel_Body1;
        private Button button2;
    }
}