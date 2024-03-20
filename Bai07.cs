using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Bai07 : Form
    {
        public Bai07()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào TextBox.");
                return;
            }

            string[] parts = input.Split(',');

            if (parts.Length < 2)
            {
                MessageBox.Show("Đầu vào không hợp lệ. Vui lòng nhập lại theo đúng định dạng.");
                return;
            }

            string hoTen = parts[0].Trim();

            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Tên sinh viên không được để trống.");
                return;
            }

            List<double> diemList = new List<double>();
            for (int i = 1; i < parts.Length; i++)
            {
                string diemStr = parts[i].Trim();
                double diem;
                if (!double.TryParse(diemStr, out diem))
                {
                    MessageBox.Show("Điểm không hợp lệ. Vui lòng nhập lại theo đúng định dạng.");
                    return;
                }
                diemList.Add(diem);
            }

            listBox1.Items.Add("Họ và tên: " + hoTen);

            for (int i = 0; i < diemList.Count; i++)
            {
                string monHoc = $"Môn {i + 1}:";
                string diemStr = diemList[i].ToString();
                listBox1.Items.Add($"{monHoc,-10} {diemStr}");
            }

            double diemTrungBinh = diemList.Average();
            listBox1.Items.Add("Điểm trung bình: " + diemTrungBinh.ToString("0.##"));

            double diemCaoNhat = diemList.Max();
            double diemThapNhat = diemList.Min();
            listBox1.Items.Add("Môn điểm cao nhất: " + diemCaoNhat);
            listBox1.Items.Add("Môn điểm thấp nhất: " + diemThapNhat);

            int soMonDau = diemList.Count(diem => diem >= 5);
            int soMonRot = diemList.Count - soMonDau;
            listBox1.Items.Add("Số môn đậu: " + soMonDau);
            listBox1.Items.Add("Số môn không đậu: " + soMonRot);

            if (diemTrungBinh >= 8 && diemList.All(diem => diem >= 6.5))
                listBox1.Items.Add("Xếp loại: Giỏi");
            else if (diemTrungBinh >= 6.5 && diemList.All(diem => diem >= 5))
                listBox1.Items.Add("Xếp loại: Khá");
            else if (diemTrungBinh >= 5 && diemList.All(diem => diem >= 3.5))
                listBox1.Items.Add("Xếp loại: Trung bình");
            else if (diemTrungBinh >= 3.5 && diemList.All(diem => diem >= 2))
                listBox1.Items.Add("Xếp loại: Yếu");
            else
                listBox1.Items.Add("Xếp loại: Kém");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes(this);
        }
        private void ClearAllTextBoxes(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Text = string.Empty;
                }
                if (ctrl.Controls.Count > 0)
                {
                    ClearAllTextBoxes(ctrl);
                }
            }
        }
    }
}
