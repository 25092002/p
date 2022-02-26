using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOSPP.proyectospp
{
    public partial class promediodecincocalificaciones : Form
    {
        public promediodecincocalificaciones()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            Clases.Clpromedio5 opromedio = new Clases.Clpromedio5(double.Parse(tex1.Text), double.Parse(text2.Text), double.Parse(text3.Text), double.Parse(tex4.Text), double.Parse(tex5.Text));
            texresultado.Text = opromedio.calcularpromedio().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
