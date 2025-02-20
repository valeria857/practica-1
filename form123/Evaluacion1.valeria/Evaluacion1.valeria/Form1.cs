using System;

using System.Windows.Forms;

namespace Evaluacion1.valeria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double R, FQ, Q, C, A, M, CF, CL, CLT, CH, V;

        private void label7_Click(object sender, EventArgs e)
        {

        }

        double total; 

        private void button1_Click(object sender, EventArgs e)
        {
            R = Convert.ToDouble(textBox1.Text) * 0.50;
            FQ = Convert.ToDouble(textBox2.Text) * 0.50;
            Q = Convert.ToDouble(textBox3.Text) * 0.70;
            C = Convert.ToDouble(textBox4.Text) * 1.25;
            A = Convert.ToDouble(textBox5.Text) * 0.75;
            M = Convert.ToDouble(textBox6.Text) * 0.75;
            CF = Convert.ToDouble(textBox7.Text) * 0.25;
            CL = Convert.ToDouble(textBox8.Text) * 0.75;
            CLT = Convert.ToDouble(textBox9.Text) * 1.25;
            CH = Convert.ToDouble(textBox10.Text) * 0.35;
            V = Convert.ToDouble(textBox11.Text) * 1.50;

            total = A + FQ + Q + C + CL + CLT + CH + V;
            textBox12.Text = total.ToString();
        }
    }
}
