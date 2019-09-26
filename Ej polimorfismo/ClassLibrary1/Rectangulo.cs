using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Rectangulo : Figura 
    {
        private float Altura;
        private float Base;

        public Rectangulo(float a, float b)
        {
            this.Altura = a;
            this.Base = b;
        }
    }
}
