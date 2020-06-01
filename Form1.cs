using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Rot(string btnText, int b)
        {
            int r1 = Convert.ToInt32(textBox1.Text);
            int r2 = Convert.ToInt32(textBox2.Text);
            int r3 = Convert.ToInt32(textBox3.Text);
            int r11 = Program.GetRot(1, r1);
            int r22 = Program.GetRot(2, r2);
            int r33 = Program.GetRot(3, r3);
            int shift = r11 + r22 + r33;
            string Al;
            if (b == 0)
            {
                Al = Program.Coding(Array.IndexOf(alphabet, btnText), shift, r1, r2, r3);
            }
            else
            {
                Al = Program.Decoding(Array.IndexOf(alphabet, btnText), shift, r1, r2, r3);
            }
            textBox4.Text += Al + " ";
            r3 = Program.Roters3(r3);
            r2 = Program.Roters2(r2, r3);
            r1 = Program.Roters1(r1, r2, r3);
            textBox1.Text = r1.ToString();
            textBox2.Text = r2.ToString();
            textBox3.Text = r3.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int b = 0;

            if (checkBox1.Checked)
            {
                b = 1;
            }
            Rot(button1.Text, b);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b = 0;

            if (checkBox1.Checked)
            {
                b = 1;
            }
            Rot(button2.Text, b);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int b = 0;

            if (checkBox1.Checked)
            {
                b = 1;
            }
            Rot(button3.Text, b);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int b = 0;

            if (checkBox1.Checked)
            {
                b = 1;
            }
            Rot(button4.Text, b);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int b = 0;

            if (checkBox1.Checked)
            {
                b = 1;
            }
            Rot(button5.Text, b);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int b = 0;

            if (checkBox1.Checked)
            {
                b = 1;
            }
            Rot(button6.Text, b);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int b = 0;

            if (checkBox1.Checked)
            {
                b = 1;
            }
            Rot(button7.Text, b);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int b = 0;

            if (checkBox1.Checked)
            {
                b = 1;
            }
            Rot(button8.Text, b);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int b = 0;

            if (checkBox1.Checked)
            {
                b = 1;
            }
            Rot(button9.Text, b);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int b = 0;

            if (checkBox1.Checked)
            {
                b = 1;
            }
            Rot(button10.Text, b);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int b = 0;

            if (checkBox1.Checked)
            {
                b = 1;
            }
            Rot(button11.Text, b);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int b = 0;

            if (checkBox1.Checked)
            {
                b = 1;
            }
            Rot(button12.Text, b);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int b = 0;

            if (checkBox1.Checked)
            {
                b = 1;
            }
            Rot(button13.Text, b);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int b = 0;

            if (checkBox1.Checked)
            {
                b = 1;
            }
            Rot(button14.Text, b);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int b = 0;

            if (checkBox1.Checked)
            {
                b = 1;
            }
            Rot(button15.Text, b);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int b = 0;

            if (checkBox1.Checked)
            {
                b = 1;
            }
            Rot(button16.Text, b);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int b = 0;

            if (checkBox1.Checked)
            {
                b = 1;
            }
            Rot(button17.Text, b);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int b = 0;

            if (checkBox1.Checked)
            {
                b = 1;
            }
            Rot(button18.Text, b);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int b = 0;

            if (checkBox1.Checked)
            {
                b = 1;
            }
            Rot(button19.Text, b);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int b = 0;

            if (checkBox1.Checked)
            {
                b = 1;
            }
            Rot(button20.Text, b);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int b = 0;

            if (checkBox1.Checked)
            {
                b = 1;
            }
            Rot(button21.Text, b);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int b = 0;

            if (checkBox1.Checked)
            {
                b = 1;
            }
            Rot(button22.Text, b);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            int b = 0;

            if (checkBox1.Checked)
            {
                b = 1;
            }
            Rot(button23.Text, b);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            int b = 0;

            if (checkBox1.Checked)
            {
                b = 1;
            }
            Rot(button24.Text, b);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            int b = 0;

            if (checkBox1.Checked)
            {
                b = 1;
            }
            Rot(button25.Text, b);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int b = 0;

            if (checkBox1.Checked)
            {
                b = 1;
            }
            Rot(button26.Text, b);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            int b = 0;

            if (checkBox1.Checked)
            {
                b = 1;
            }
            Rot(button27.Text, b);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            int b = 0;

            if (checkBox1.Checked)
            {
                b = 1;
            }
            Rot(button28.Text, b);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            int b = 0;

            if (checkBox1.Checked)
            {
                b = 1;
            }
            Rot(button29.Text, b);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            int b = 0;

            if (checkBox1.Checked)
            {
                b = 1;
            }
            Rot(button30.Text, b);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            int b = 0;

            if (checkBox1.Checked)
            {
                b = 1;
            }
            Rot(button31.Text, b);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            int b = 0;

            if (checkBox1.Checked)
            {
                b = 1;
            }
            Rot(button32.Text, b);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            int b = 0;

            if (checkBox1.Checked)
            {
                b = 1;
            }
            Rot(button33.Text, b);
        }

        private void button34_Click(object sender, EventArgs e)
        {

        }
    }

    


}

