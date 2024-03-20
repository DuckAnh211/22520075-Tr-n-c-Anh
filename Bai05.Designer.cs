namespace Lab1
{
    partial class Bai05
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
            comboBox1 = new ComboBox();
            Tinh = new Button();
            Xoa = new Button();
            Thoat = new Button();
            NhapA = new Label();
            NhapB = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(735, 218);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(418, 54);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Tinh
            // 
            Tinh.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Tinh.Location = new Point(305, 358);
            Tinh.Name = "Tinh";
            Tinh.Size = new Size(352, 58);
            Tinh.TabIndex = 1;
            Tinh.Text = "Tính các giá trị";
            Tinh.UseVisualStyleBackColor = true;
            Tinh.Click += Tinh_Click;
            // 
            // Xoa
            // 
            Xoa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Xoa.Location = new Point(848, 358);
            Xoa.Name = "Xoa";
            Xoa.Size = new Size(188, 58);
            Xoa.TabIndex = 2;
            Xoa.Text = "Xóa";
            Xoa.UseVisualStyleBackColor = true;
            Xoa.Click += Xoa_Click;
            // 
            // Thoat
            // 
            Thoat.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Thoat.Location = new Point(1315, 358);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(188, 58);
            Thoat.TabIndex = 3;
            Thoat.Text = "Thoát";
            Thoat.UseVisualStyleBackColor = true;
            Thoat.Click += Thoat_Click;
            // 
            // NhapA
            // 
            NhapA.AutoSize = true;
            NhapA.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NhapA.Location = new Point(143, 79);
            NhapA.Name = "NhapA";
            NhapA.Size = new Size(144, 46);
            NhapA.TabIndex = 4;
            NhapA.Text = "Nhập A";
            // 
            // NhapB
            // 
            NhapB.AutoSize = true;
            NhapB.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NhapB.Location = new Point(1195, 82);
            NhapB.Name = "NhapB";
            NhapB.Size = new Size(143, 46);
            NhapB.TabIndex = 5;
            NhapB.Text = "Nhập B";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(362, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 47);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1374, 76);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 47);
            textBox2.TabIndex = 7;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 46;
            listBox1.Location = new Point(305, 555);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1198, 326);
            listBox1.TabIndex = 9;
            // 
            // Bai05
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1806, 938);
            Controls.Add(listBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(NhapB);
            Controls.Add(NhapA);
            Controls.Add(Thoat);
            Controls.Add(Xoa);
            Controls.Add(Tinh);
            Controls.Add(comboBox1);
            Name = "Bai05";
            Text = "Bai05";
            Load += Bai05_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button Tinh;
        private Button Xoa;
        private Button Thoat;
        private Label NhapA;
        private Label NhapB;
        private TextBox textBox1;
        private TextBox textBox2;
        private ListBox listBox1;
    }
}