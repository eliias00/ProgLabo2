using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    sealed public class Cuadrado : Rectangulo
    {
        public Cuadrado(double lado) : base(lado,lado)
        {

        }
    }
}
