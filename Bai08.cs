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
    public partial class Bai08 : Form
    {
        public Bai08()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Them_Click(object sender, EventArgs e)
        {
            string currentText = textBox1.Text;

            textBox2.Text += currentText + Environment.NewLine;

            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] strings = textBox2.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            if (strings.Length > 0)
            {
                Random rand = new Random();

                int randomIndex = rand.Next(0, strings.Length);

                string randomString = strings[randomIndex];

                textBox3.Text = randomString;
            }
        }
    }
}
