using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion.valeria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
        }
        double N1, N2, N3, N4, N5, N6;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        double promedio;

        private void button1_Click(object sender, EventArgs e)
        {
            N1 = Convert.ToInt32(textBox1.Text);
            N2 = Convert.ToInt32(textBox2.Text);
            N3 = Convert.ToInt32(textBox3.Text);
            N4 = Convert.ToInt32(textBox4.Text);
            N5 = Convert.ToInt32(textBox5.Text);
            N6 = Convert.ToInt32(textBox6.Text);
            promedio = (N1 + N2 + N3 + N4 + N5 + N6) / 6 ;
            textBox7.Text = promedio.ToString();
            


            if (promedio >= 7 && promedio <= 10)
            {
                textBox8.Text = "Aprobado".ToString();
                textBox9.Text = "Grandioso, Excelente... continúa así... ".ToString();
                pictureBox1.Image = Properties.Resources.uno;
                pictureBox1.Visible = true;

            }
            else if (promedio >= 6 && promedio <=6.99) 
            {
                textBox8.Text = "Aprobado".ToString();
                textBox9.Text = "Muy bien... pero trata de mejorar tu promedio en las siguientes materias.".ToString();
                pictureBox1.Image = Properties.Resources.dos;
                pictureBox1.Visible = true;
            }

            else if (promedio >= 3 && promedio <= 5.99) 
            {
                textBox8.Text = "Reprobado".ToString();
                textBox9.Text = "Más dedicación estudiate, debe mejorar sus notas... ".ToString();
                pictureBox1.Image = Properties.Resources.tres;
                pictureBox1.Visible = true;
            }
            else if (promedio <= 2.99) 
            {
                textBox8.Text = "Reprobado".ToString();
                textBox9.Text = "Pongase las pilas mi hijito, ya no esta en el kinder...".ToString();
                pictureBox1.Image = Properties.Resources.cuatro;
                pictureBox1.Visible = true;
            }



        }
    }
}
