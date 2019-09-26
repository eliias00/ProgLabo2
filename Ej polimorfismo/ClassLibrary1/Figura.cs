using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public abstract class Figura
    {
        public virtual string  Dibujar()
        {
            return "Dibujando forma...";
        }
        public abstract double CalcularSuperficie();
        public abstract double CalcularPerimetro();

    }
}
