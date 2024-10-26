namespace LOGIN
{
    partial class xoathanhvien
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
            label2 = new Label();
            txtTK = new TextBox();
            btnDELETE = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 35);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 12;
            label2.Text = "Tên đăng nhập";
            // 
            // txtTK
            // 
            txtTK.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTK.Location = new Point(12, 58);
            txtTK.Multiline = true;
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(297, 52);
            txtTK.TabIndex = 11;
            // 
            // btnDELETE
            // 
            btnDELETE.BackColor = Color.Aqua;
            btnDELETE.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDELETE.ForeColor = Color.Black;
            btnDELETE.Location = new Point(13, 304);
            btnDELETE.Name = "btnDELETE";
            btnDELETE.Size = new Size(296, 48);
            btnDELETE.TabIndex = 13;
            btnDELETE.Text = "Xóa";
            btnDELETE.UseVisualStyleBackColor = false;
            btnDELETE.Click += btnDELETE_Click;
            // 
            // xoathanhvien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 491);
            Controls.Add(btnDELETE);
            Controls.Add(label2);
            Controls.Add(txtTK);
            Name = "xoathanhvien";
            Text = "xoathanhvien";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtTK;
        private Button btnDELETE;
    }
}