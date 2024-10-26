namespace LOGIN
{
    partial class Quanli3
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel_Body = new Panel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(236, 753);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.Location = new Point(3, 230);
            button4.Name = "button4";
            button4.Size = new Size(230, 69);
            button4.TabIndex = 4;
            button4.Text = "Lịch sử";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.Location = new Point(3, 161);
            button3.Name = "button3";
            button3.Size = new Size(230, 69);
            button3.TabIndex = 3;
            button3.Text = "Thu ngân";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.Location = new Point(3, 92);
            button2.Name = "button2";
            button2.Size = new Size(230, 69);
            button2.TabIndex = 2;
            button2.Text = "Sản phẩm";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(3, 23);
            button1.Name = "button1";
            button1.Size = new Size(230, 69);
            button1.TabIndex = 1;
            button1.Text = "Đơn hàng";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel_Body
            // 
            panel_Body.Dock = DockStyle.Fill;
            panel_Body.Location = new Point(236, 0);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(1088, 753);
            panel_Body.TabIndex = 2;
            // 
            // Quanli3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 753);
            Controls.Add(panel_Body);
            Controls.Add(groupBox1);
            Name = "Quanli3";
            Text = "Quanli3";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel_Body;
    }
}