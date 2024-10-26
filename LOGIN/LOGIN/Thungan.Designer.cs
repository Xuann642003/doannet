namespace LOGIN
{
    partial class Thungan
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            tấtCảToolStripMenuItem = new ToolStripMenuItem();
            nướcUốngToolStripMenuItem = new ToolStripMenuItem();
            đồĂnToolStripMenuItem = new ToolStripMenuItem();
            panel_Body = new Panel();
            groupBox1 = new GroupBox();
            txtTONGTIEN = new TextBox();
            dataGridView1 = new DataGridView();
            btnTHANHTOAN = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(134, 38);
            label1.TabIndex = 0;
            label1.Text = "Thu ngân";
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tấtCảToolStripMenuItem, nướcUốngToolStripMenuItem, đồĂnToolStripMenuItem });
            menuStrip1.Location = new Point(12, 64);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(231, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // tấtCảToolStripMenuItem
            // 
            tấtCảToolStripMenuItem.Name = "tấtCảToolStripMenuItem";
            tấtCảToolStripMenuItem.Size = new Size(63, 24);
            tấtCảToolStripMenuItem.Text = "Tất cả";
            tấtCảToolStripMenuItem.Click += tấtCảToolStripMenuItem_Click;
            // 
            // nướcUốngToolStripMenuItem
            // 
            nướcUốngToolStripMenuItem.Name = "nướcUốngToolStripMenuItem";
            nướcUốngToolStripMenuItem.Size = new Size(97, 24);
            nướcUốngToolStripMenuItem.Text = "Nước uống";
            // 
            // đồĂnToolStripMenuItem
            // 
            đồĂnToolStripMenuItem.Name = "đồĂnToolStripMenuItem";
            đồĂnToolStripMenuItem.Size = new Size(63, 24);
            đồĂnToolStripMenuItem.Text = "Đồ ăn";
            // 
            // panel_Body
            // 
            panel_Body.Location = new Point(0, 95);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(761, 613);
            panel_Body.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTONGTIEN);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(btnTHANHTOAN);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(777, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(310, 644);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giỏ hàng";
            // 
            // txtTONGTIEN
            // 
            txtTONGTIEN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTONGTIEN.Location = new Point(3, 520);
            txtTONGTIEN.Multiline = true;
            txtTONGTIEN.Name = "txtTONGTIEN";
            txtTONGTIEN.Size = new Size(304, 55);
            txtTONGTIEN.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(304, 549);
            dataGridView1.TabIndex = 2;
            // 
            // btnTHANHTOAN
            // 
            btnTHANHTOAN.BackColor = Color.Aqua;
            btnTHANHTOAN.Dock = DockStyle.Bottom;
            btnTHANHTOAN.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTHANHTOAN.Location = new Point(3, 575);
            btnTHANHTOAN.Name = "btnTHANHTOAN";
            btnTHANHTOAN.Size = new Size(304, 66);
            btnTHANHTOAN.TabIndex = 1;
            btnTHANHTOAN.Text = "Thanh toán";
            btnTHANHTOAN.UseVisualStyleBackColor = false;
            btnTHANHTOAN.Click += btnTHANHTOAN_Click;
            // 
            // Thungan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 706);
            Controls.Add(groupBox1);
            Controls.Add(panel_Body);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "Thungan";
            Text = "Thungan";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tấtCảToolStripMenuItem;
        private ToolStripMenuItem nướcUốngToolStripMenuItem;
        private ToolStripMenuItem đồĂnToolStripMenuItem;
        private Panel panel_Body;
        private GroupBox groupBox1;
        private Button btnTHANHTOAN;
        private DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private TextBox txtTONGTIEN;
    }
}