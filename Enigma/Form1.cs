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
    public partial class Enigma : Form
    {
        public Enigma()
        {
            InitializeComponent();
        }

        private void Rot(string btnText)
        {
            int r1 = textBox1.Text != String.Empty ? Convert.ToInt32(textBox1.Text) : 0;
            int r2 = textBox2.Text != String.Empty ? Convert.ToInt32(textBox2.Text) : 0;
            int r3 = textBox3.Text != String.Empty ? Convert.ToInt32(textBox3.Text) : 0;
            int r11 = Program.GetRot(1, r1);
            int r22 = Program.GetRot(2, r2);
            int r33 = Program.GetRot(3, r3);
            int shift = r11 + r22 + r33;
            string Al;
            if (!checkBox1.Checked)
            {
                Al = Program.Coding(Array.IndexOf(Program.alphabet, btnText), shift);
            }
            else
            {
                Al = Program.Decoding(Array.IndexOf(Program.alphabet, btnText), shift);
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
            Rot(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rot(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rot(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rot(button4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Rot(button5.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Rot(button6.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Rot(button7.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Rot(button8.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Rot(button9.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Rot(button10.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Rot(button11.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Rot(button12.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Rot(button13.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Rot(button14.Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Rot(button15.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Rot(button16.Text);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Rot(button17.Text);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Rot(button18.Text);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Rot(button19.Text);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Rot(button20.Text);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Rot(button21.Text);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Rot(button22.Text);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Rot(button23.Text);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Rot(button24.Text);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Rot(button25.Text);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Rot(button26.Text);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Rot(button27.Text);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Rot(button28.Text);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Rot(button29.Text);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Rot(button30.Text);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Rot(button31.Text);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Rot(button32.Text);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Rot(button33.Text);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 && number != 2)
            {
                e.Handled = true;
            }
        }
    }
}
