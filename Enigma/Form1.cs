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

        private void keyboard_button_Click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            Rot(clicked.Text);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }

        private void textBox_KeyCheck(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }


    }
}
