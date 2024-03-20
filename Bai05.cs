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
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
            comboBox1.Items.Add("Bảng cửu chương");
            comboBox1.Items.Add("Tính các giá trị");
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Bai05_Load(object sender, EventArgs e)
        {

        }

        private void Tinh_Click(object sender, EventArgs e)
        {
            int A = int.Parse(textBox1.Text);
            int B = int.Parse(textBox2.Text);

            if (comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Clear();
                if (A > B)
                {
                    MessageBox.Show("A không thể lớn hơn B khi chọn phép tính này.");
                    return;
                }
                for (int i = A; i <= B; i++)
                {
                    listBox1.Items.Add($"Bảng cửu chương của {i}:");
                    for (int j = 1; j <= 10; j++)
                    {
                        listBox1.Items.Add($"{i} x {j} = {i * j}");
                    }
                    listBox1.Items.Add("");
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Clear();
                if (A <= B)
                {
                    MessageBox.Show("A phải lớn hơn B khi chọn phép tính này.");
                    return;
                }
                long factorialResult = Factorial(A - B);
                listBox1.Items.Add($"(A - B)! = {factorialResult}");

                double sum = 0;
                for (int i = 1; i <= B; i++)
                {
                    sum += Math.Pow(A, i);
                }
                listBox1.Items.Add($"Tổng S = {sum}");
            }
        }

        private long Factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        private void Xoa_Click(object sender, EventArgs e)
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

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
