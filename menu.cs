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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sumaDeDosNumerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calculosaritmeticos ca = new calculosaritmeticos();
            ca.Show();
        }

        private void salidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void promedioDeTresCalificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PROYECTOSPP.proyectospp.promediodetrescalificaciones promedio = new proyectospp.promediodetrescalificaciones();
            promedio.Show();

        }

        private void promedioDe5CalificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PROYECTOSPP.proyectospp.promediodecincocalificaciones opromedio = new proyectospp.promediodecincocalificaciones();
            opromedio.Show();
            //calculosaritmeticos ca = new calculosaritmeticos();
            //ca.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProyectosPP.PROYECTOSPOO.calculadora calculadora = new ProyectosPP.PROYECTOSPOO.calculadora();
            calculadora.Show();
        }
    }
}
