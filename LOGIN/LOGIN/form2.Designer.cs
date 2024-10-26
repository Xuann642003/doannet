namespace LOGIN
{
    partial class form2
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
            label8 = new Label();
            label1 = new Label();
            txtMa = new TextBox();
            btnPHAT = new Button();
            groupBox1 = new GroupBox();
            panel_Body = new Panel();
            menuStrip1 = new MenuStrip();
            lịchSửQuàToolStripMenuItem = new ToolStripMenuItem();
            logsPhátToolStripMenuItem = new ToolStripMenuItem();
            hếtHạnToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(50, 46);
            label8.Name = "label8";
            label8.Size = new Size(152, 46);
            label8.TabIndex = 3;
            label8.Text = "Phát quà";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(82, 133);
            label1.Name = "label1";
            label1.Size = new Size(168, 31);
            label1.TabIndex = 4;
            label1.Text = "Mã đổi thưởng";
            // 
            // txtMa
            // 
            txtMa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMa.Location = new Point(277, 123);
            txtMa.Multiline = true;
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(417, 50);
            txtMa.TabIndex = 5;
            // 
            // btnPHAT
            // 
            btnPHAT.BackColor = Color.BlueViolet;
            btnPHAT.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPHAT.ForeColor = SystemColors.Control;
            btnPHAT.Location = new Point(715, 123);
            btnPHAT.Name = "btnPHAT";
            btnPHAT.Size = new Size(94, 50);
            btnPHAT.TabIndex = 6;
            btnPHAT.Text = "Phát";
            btnPHAT.UseVisualStyleBackColor = false;
            btnPHAT.Click += btnPHAT_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel_Body);
            groupBox1.Controls.Add(menuStrip1);
            groupBox1.Location = new Point(82, 195);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1301, 611);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // panel_Body
            // 
            panel_Body.Dock = DockStyle.Fill;
            panel_Body.Location = new Point(3, 51);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(1295, 557);
            panel_Body.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { lịchSửQuàToolStripMenuItem, logsPhátToolStripMenuItem, hếtHạnToolStripMenuItem });
            menuStrip1.Location = new Point(3, 23);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1295, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // lịchSửQuàToolStripMenuItem
            // 
            lịchSửQuàToolStripMenuItem.Name = "lịchSửQuàToolStripMenuItem";
            lịchSửQuàToolStripMenuItem.Size = new Size(97, 24);
            lịchSửQuàToolStripMenuItem.Text = "Lịch sử quà";
            lịchSửQuàToolStripMenuItem.Click += lịchSửQuàToolStripMenuItem_Click;
            // 
            // logsPhátToolStripMenuItem
            // 
            logsPhátToolStripMenuItem.Name = "logsPhátToolStripMenuItem";
            logsPhátToolStripMenuItem.Size = new Size(88, 24);
            logsPhátToolStripMenuItem.Text = "Logs phát";
            logsPhátToolStripMenuItem.Click += logsPhátToolStripMenuItem_Click;
            // 
            // hếtHạnToolStripMenuItem
            // 
            hếtHạnToolStripMenuItem.Name = "hếtHạnToolStripMenuItem";
            hếtHạnToolStripMenuItem.Size = new Size(75, 24);
            hếtHạnToolStripMenuItem.Text = "Hết hạn";
            // 
            // form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 806);
            Controls.Add(groupBox1);
            Controls.Add(btnPHAT);
            Controls.Add(txtMa);
            Controls.Add(label1);
            Controls.Add(label8);
            Name = "form2";
            StartPosition = FormStartPosition.Manual;
            Text = "form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label1;
        private TextBox txtMa;
        private Button btnPHAT;
        private GroupBox groupBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem lịchSửQuàToolStripMenuItem;
        private ToolStripMenuItem logsPhátToolStripMenuItem;
        private ToolStripMenuItem hếtHạnToolStripMenuItem;
        private Panel panel_Body;
    }
}