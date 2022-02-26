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
    public partial class promediodetrescalificaciones : Form
    {
        public promediodetrescalificaciones()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text =((double.Parse(textBox1.Text) + double.Parse(textBox2.Text) + double.Parse(textBox3.Text)) / 3).ToString();
        }

        private void promediodetrescalificaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
