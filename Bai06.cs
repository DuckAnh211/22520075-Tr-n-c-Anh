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
    public partial class Bai06 : Form
    {
        public Bai06()
        {
            InitializeComponent();
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] ngayThangNam = textBox1.Text.Split('/');

            int ngay = int.Parse(ngayThangNam[0]);

            int thang = int.Parse(ngayThangNam[1]);

            int nam = int.Parse(ngayThangNam[2]);

            string cungHoangDao = XacDinhCungHoangDao(ngay, thang);

            textBox2.Text = cungHoangDao;
        }
        private string XacDinhCungHoangDao(int ngay, int thang)
        {
            switch (thang)
            {
                case 1:
                    if (ngay >= 20)
                        return "cung Bảo Bình";
                    else
                        return "cung Ma Kết";
                case 2:
                    if (ngay <= 19)
                        return "cung Bảo Bình";
                    else
                        return "cung Song Ngư";
                case 3:
                    if (ngay <= 20)
                        return "cung Song Ngư";
                    else
                        return "cung Bạch Dương";
                case 4:
                    if (ngay <= 20)
                        return "cung Bạch Dương";
                    else
                        return "cung Kim Ngưu";
                case 5:
                    if (ngay <= 21)
                        return "cung Kim Ngưu";
                    else
                        return "cung Song Tử";
                case 6:
                    if (ngay <= 21)
                        return "cung Song Tử";
                    else
                        return "cung Cự Giải";
                case 7:
                    if (ngay <= 22)
                        return "cung Cự Giải";
                    else
                        return "cung Sư Tử";
                case 8:
                    if (ngay <= 23)
                        return "cung Sư Tử";
                    else
                        return "cung Xử Nữ";
                case 9:
                    if (ngay <= 23)
                        return "cung Xử Nữ";
                    else
                        return "cung Thiên Bình";
                case 10:
                    if (ngay <= 23)
                        return "cung Thiên Bình";
                    else
                        return "cung Thần Nông";
                case 11:
                    if (ngay <= 22)
                        return "cung Thần Nông";
                    else
                        return "cung Nhân Mã";
                case 12:
                    if (ngay <= 21)
                        return "cung Nhân Mã";
                    else
                        return "cung Ma Kết";
                default:
                    return "Không xác định";
            }


        }
    }
}
