namespace LOGIN
{
    partial class Quanli2
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
            menuStrip1 = new MenuStrip();
            thêmThànhViênToolStripMenuItem = new ToolStripMenuItem();
            thànhViênToolStripMenuItem = new ToolStripMenuItem();
            tàiChínhToolStripMenuItem = new ToolStripMenuItem();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            panel_Body = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { thêmThànhViênToolStripMenuItem, thànhViênToolStripMenuItem, tàiChínhToolStripMenuItem, thốngKêToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1324, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // thêmThànhViênToolStripMenuItem
            // 
            thêmThànhViênToolStripMenuItem.Name = "thêmThànhViênToolStripMenuItem";
            thêmThànhViênToolStripMenuItem.Size = new Size(86, 24);
            thêmThànhViênToolStripMenuItem.Text = "Máy trạm";
            thêmThànhViênToolStripMenuItem.Click += thêmThànhViênToolStripMenuItem_Click;
            // 
            // thànhViênToolStripMenuItem
            // 
            thànhViênToolStripMenuItem.Name = "thànhViênToolStripMenuItem";
            thànhViênToolStripMenuItem.Size = new Size(94, 24);
            thànhViênToolStripMenuItem.Text = "Thành viên";
            thànhViênToolStripMenuItem.Click += thànhViênToolStripMenuItem_Click;
            // 
            // tàiChínhToolStripMenuItem
            // 
            tàiChínhToolStripMenuItem.Name = "tàiChínhToolStripMenuItem";
            tàiChínhToolStripMenuItem.Size = new Size(80, 24);
            tàiChínhToolStripMenuItem.Text = "Tài chính";
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(84, 24);
            thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // panel_Body
            // 
            panel_Body.Dock = DockStyle.Fill;
            panel_Body.Location = new Point(0, 28);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(1324, 725);
            panel_Body.TabIndex = 1;
            // 
            // Quanli2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 753);
            Controls.Add(panel_Body);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Quanli2";
            Text = "Themtv";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem thêmThànhViênToolStripMenuItem;
        private Panel panel_Body;
        private ToolStripMenuItem thànhViênToolStripMenuItem;
        private ToolStripMenuItem tàiChínhToolStripMenuItem;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
    }
}