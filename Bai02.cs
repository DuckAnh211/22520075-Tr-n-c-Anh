using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using WinFormsApp = System.Windows.Forms;
namespace Lab1
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            int max = a;
            int min = a;

            if (b > max)
                max = b;
            else if (b < min)
                min = b;

            if (c > max)
                max = c;
            else if (c < min)
                min = c;
            textBox4.Text = max.ToString();
            textBox5.Text = min.ToString();

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

        private void button2_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes(this);
        }

        private void Bai02_Load(object sender, EventArgs e)
        {

        }

       

        private void button3_Click_1(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
