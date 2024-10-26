namespace LOGIN
{
    partial class lich_su_qua
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
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            btnTIM = new Button();
            txtTen = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1277, 397);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTIM);
            groupBox2.Controls.Add(txtTen);
            groupBox2.Controls.Add(label2);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1277, 107);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // btnTIM
            // 
            btnTIM.BackColor = Color.BlueViolet;
            btnTIM.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTIM.ForeColor = SystemColors.Control;
            btnTIM.Location = new Point(714, 39);
            btnTIM.Name = "btnTIM";
            btnTIM.Size = new Size(135, 50);
            btnTIM.TabIndex = 10;
            btnTIM.Text = "Tìm kiếm";
            btnTIM.UseVisualStyleBackColor = false;
            btnTIM.Click += btnTIM_Click;
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTen.Location = new Point(223, 39);
            txtTen.Multiline = true;
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(470, 50);
            txtTen.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(81, 49);
            label2.Name = "label2";
            label2.Size = new Size(109, 31);
            label2.TabIndex = 8;
            label2.Text = "Tài khoản";
            // 
            // lich_su_qua
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 510);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            Name = "lich_su_qua";
            Text = "lich_su_qua";
            Load += lich_su_qua_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Button btnTIM;
        private TextBox txtTen;
        private Label label2;
    }
}