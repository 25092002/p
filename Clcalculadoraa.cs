using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTOSPP
{
    class Clcalculadoraa
    {
        private double num1;
        private double num2;
        
        //public double resultado;
        //constructor

        public Clcalculadoraa(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        //public double Num1 { get => num1; set => num1 = value; }
        //public double Num2 { get => num2; set => num2 = value; }
        public double fsumar()
        {
            return (num1 + num2);
        }
        public double fresta()
        {
            return (num1 - num2);
        }
        public double fmultiplicar()
        {
            return (num1 * num2);
        }
        public double fdividir()
        {
            return (num1 / num2);
        }


        //public void poperador()
        //{
        //    resultado = num1 + num2;
        //}
    }
}
