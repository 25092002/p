﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTOSPP.Clases
{
    class Clpromedio5
    {
        //campos         //nombre
        private double calificacion1;
        private double calificacion2;
        private double calificacion3;
        private double calificacion4;
        private double calificacion5;
        //generar constructor
        public Clpromedio5(double calificacion1, double calificacion2, double calificacion3, double calificacion4, double calificacion5)
        {
            this.calificacion1 = calificacion1;
            this.calificacion2 = calificacion2;
            this.calificacion3 = calificacion3;
            this.calificacion4 = calificacion4;
            this.calificacion5 = calificacion5;
        }
        public double calcularpromedio()
        {
            return ((calificacion1 + calificacion2 + calificacion3 + calificacion4 + calificacion5) / 5);
        }

       
    }
}
