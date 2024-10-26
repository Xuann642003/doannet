namespace THANHVIEN
{
    partial class Maytram
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
            groupBox1 = new GroupBox();
            button2 = new Button();
            btnNAPTIEN = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Cyan;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btnNAPTIEN);
            groupBox1.Location = new Point(53, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(241, 122);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Image = LOGIN.Properties.Resources.money_add_icon_142987;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(122, 26);
            button2.Name = "button2";
            button2.Size = new Size(92, 73);
            button2.TabIndex = 1;
            button2.Text = "Trừ tiền";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnNAPTIEN
            // 
            btnNAPTIEN.Image = LOGIN.Properties.Resources.money_add_icon_142987;
            btnNAPTIEN.ImageAlign = ContentAlignment.TopCenter;
            btnNAPTIEN.Location = new Point(24, 26);
            btnNAPTIEN.Name = "btnNAPTIEN";
            btnNAPTIEN.Size = new Size(92, 73);
            btnNAPTIEN.TabIndex = 0;
            btnNAPTIEN.Text = "Nạp tiền";
            btnNAPTIEN.TextAlign = ContentAlignment.BottomCenter;
            btnNAPTIEN.UseVisualStyleBackColor = true;
            btnNAPTIEN.Click += btnNAPTIEN_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(53, 181);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1274, 604);
            dataGridView1.TabIndex = 1;
            // 
            // Maytram
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 806);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Maytram";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button2;
        private Button btnNAPTIEN;
        private DataGridView dataGridView1;
    }
}
