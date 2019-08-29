using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
   internal class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool ret = false;
            if(valor>min && valor <max)
            {
                ret = true;
            }
                return ret;
        }
    }
}
