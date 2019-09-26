using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    sealed public class Circulo : Figura
    {
         double radio;

        public Circulo(double r)
        {
            this.radio = r;
        }
        public override string Dibujar()
        {
            return "Dibujando circulo...";
        }

        public override double CalcularSuperficie()
        {
            return (Math.PI * Math.Pow(radio, 2));
        }

        public override double CalcularPerimetro()
        {
            return (Math.PI * 2 * radio);
        }
    }
}
