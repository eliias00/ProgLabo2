using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
   public sealed class Circulo : Figura
    {
        private float radio;

        public Circulo(float r)
        {
            this.radio = r;
        }
    }
}
