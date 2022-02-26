using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectosPP.CLASES
{
    class CLCALCULADORA
    {
        // Campos
        private double valor1;
        private double valor2;

        public CLCALCULADORA(double valor1, double valor2)
        {
            this.valor1 = valor1;
            this.valor2 = valor2;
        }
        public double suma()
        {
            return (valor1 + valor2);
        }
        public double resta()
        {
            return (valor1 - valor2);
        }
        public double multiplica()
        {
            return (valor1 * valor2);
        }
        public double divide()
        {
            return (valor1 / valor2);
        }
        public double raiz(double valor3)
        {
            return (Math.Sqrt(valor3));
        }
        public double porcentaje()
        {
            return (valor2 * (valor1 / 100));
        }
    }
}
