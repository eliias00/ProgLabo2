using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rectangulo : Figura
    {
        private double Altura;
        private double Base;

        public Rectangulo(double a, double b)
        {
            this.Altura = a;
            this.Base = b;
        }
        public override string Dibujar()
        {
            return "Dibujando rectangulo..";
        }
        public override double CalcularSuperficie()
        {
            return Base * Altura;
        }

        public override double CalcularPerimetro()
        {
            return Base + Altura;
        }
    }
}
