using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monedas
{
  public class Euro
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Euro()
        {
            Euro.cotizRespectoDolar = (float)1.12;
        }

        public Euro(double cantidad)
            : this()
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizacion)
            : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }

        public static explicit operator Dolar(Euro e)
        {
            Dolar d = new Dolar(e.GetCantidad() * Euro.GetCotizacion());
            return d;
        }

        public static explicit operator Pesos(Euro e)
        {
            Dolar d = (Dolar)e;
            return (Pesos)d;
        }

        public static implicit operator Euro(double d)
        {
            Euro e = new Euro(d);
            return e;
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            bool returnAux = false;
            if(e.GetCantidad() == d.GetCantidad())
            {
                returnAux = true;
            }
            return returnAux;
        }
        
        public static bool operator ==(Euro e, Pesos p)
        {
            bool returnAux = false;
            if (e.GetCantidad() == p.GetCantidad())
            {
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            bool returnAux = false;
            if (e1.GetCantidad() == e2.GetCantidad())
            {
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return ((Euro)d).GetCantidad() + e.GetCantidad();
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            return ((Euro)p).GetCantidad() + p.GetCantidad();
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return ((Euro)d).GetCantidad() - e.GetCantidad();
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            return ((Euro)p).GetCantidad() - e.GetCantidad();
        }
    }
}
