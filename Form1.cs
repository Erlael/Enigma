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
}

