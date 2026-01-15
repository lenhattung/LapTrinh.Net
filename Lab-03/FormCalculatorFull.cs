using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_03
{
    public partial class FormCalculatorFull : Form
    {
        double so1 = 0, so2 = 0;
        double kq = 0;
        char pt;
        char error = 'E';
        public FormCalculatorFull()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            pt = '+';
            so1 = double.Parse(textBoxHT.Text);
            textBoxHT.Text = "";
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            textBoxHT.Text += "7";
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            textBoxHT.Text += "0";
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            textBoxHT.Text += "1";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            textBoxHT.Text += "2";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            textBoxHT.Text += "3";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            textBoxHT.Text += "4";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            textBoxHT.Text += "5";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            textBoxHT.Text += "6";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            textBoxHT.Text += "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            textBoxHT.Text += "9";
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            pt = '-';
            so1 = double.Parse(textBoxHT.Text);
            textBoxHT.Text = "";
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            pt = '*';
            so1 = double.Parse(textBoxHT.Text);
            textBoxHT.Text = "";
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            pt = '/';
            so1 = double.Parse(textBoxHT.Text);
            textBoxHT.Text = "";
        }


        public void Tinh(double n1, double n2, char pt)
        {
            double kq = 0;
            switch (pt)
            {
                case '+':
                    kq = n1 + n2;
                    break;
                case '-':
                    kq = n1 - n2;
                    break;
                case '*':
                    kq = n1 * n2;
                    break;
                case '/':
                    if (n2 == 0)
                    {
                        MessageBox.Show("Không thể thực hiện phép chia cho 0!");
                    }
                    else
                    {
                        kq = n1 / n2;
                    }
                    break;
            }
            textBoxHT.Text = kq.ToString();
        }
        private void btBang_Click(object sender, EventArgs e)
        {
           so2 = double.Parse(textBoxHT.Text);
            Tinh(so1, so2, pt);
        }

        private void btCongTru_Click(object sender, EventArgs e)
        {
            so1 = double.Parse(textBoxHT.Text);
            so1 *= -1;
            textBoxHT.Text = so1.ToString();
        }

        private void btC_Click(object sender, EventArgs e)
        {
            textBoxHT.Text = "";
        }
    }
}
