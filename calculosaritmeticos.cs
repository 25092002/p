using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOSPP
{
    public partial class calculosaritmeticos : Form
    { 
        public calculosaritmeticos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clcalculadoraa osuma= new Clcalculadoraa(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
            textBox3.Text=osuma.fsumar().ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clcalculadoraa oresta = new Clcalculadoraa(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
            textBox3.Text = oresta.fresta().ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clcalculadoraa omultiplicar = new Clcalculadoraa(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
            textBox3.Text = omultiplicar.fmultiplicar().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clcalculadoraa odividir = new Clcalculadoraa(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
            textBox3.Text = odividir.fdividir().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
