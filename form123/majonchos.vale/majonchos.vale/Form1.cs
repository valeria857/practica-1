using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace majonchos.vale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double majonchoscost;
        int cantidadmajonchos;
        double totalmajonchoscost;

        private void button1_Click(object sender, EventArgs e)
        {
            majonchoscost = Convert.ToDouble(textBox2.Text);
            cantidadmajonchos = Convert.ToInt32(textBox1.Text);
            totalmajonchoscost =  majonchoscost * cantidadmajonchos;
               textBox3.Text  = totalmajonchoscost.ToString();
        }
    }
}
