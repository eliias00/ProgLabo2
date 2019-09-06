using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pesos
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        public static explicit operator Dolar(Pesos p) 
        {
            Dolar d = new Dolar(p.GetCantidad() * Pesos.GetCotizacion());
            return d;
        }

        public static explicit operator Euro(Pesos p)  
        {
            Dolar d = (Dolar)p;
            return (Euro)d;
        }

        public double GetCantidad()
        {
            return this.GetCantidad;
        }
        public double GetCotizacion()
        {
            return this.GetCotizacion;
        }

        public static implicit operator Pesos(double d) 
        {
            Pesos temp = new Pesos(d);
            return temp;
        }    

        public static bool operator !=(Pesos p ,Dolar d )
        {
            return !(p == d);   
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }

        public static Pesos operator -(Pesos p,Dolar d)
        {
            return ((Pesos)d).GetCantidad() - p.GetCantidad;
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            return ((Pesos)e).GetCantidad() - p.GetCantidad;
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            return ((Pesos)d).GetCantidad() + p.GetCantidad;
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            return ((Pesos)e).GetCantidad() + p.GetCantidad;
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            if (p.GetCantidad == d.GetCantidad)
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            if (p.GetCantidad == e.GetCantidad)
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            if (p1.GetCantidad == p2.GetCantidad)
            {
                return true;
            }
            return false;
        }

        private Pesos()
        {
            Pesos.cotizRespectoDolar = 1 / (float)38.33;
        }

        public Pesos(double cantidad) : this()
        {
            this.cantidad = cantidad;

        }

        public Pesos(double cantidad,double cotizacion) : this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }   

    }

    public class Euro
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        public static explicit operator Dolar(Euro e)
        {   
            Dolar d = new Dolar(e.GetCantidad() * Euro.GetCotizacion());
            return d;
        }

        public static explicit operator Euro(Euro e)
        {
            Dolar d = (Dolar)e;
            return (Pesos)d;
        }

        public double GetCantidad()
        {
            return this.GetCantidad;
        }

        public double GetCotizacion()
        {
            return this.GetCotizacion;
        }

        public static implicit operator Euro(double d)
        {
            Euro e = new Euro(d);
            return e;
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return ((Euro)d).GetCantidad() - e.GetCantidad;
        }

        public static Euro operator -(Pesos p, Euro e)
        {
            return ((Euro)p).GetCantidad() - e.GetCantidad;
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return ((Euro)d).GetCantidad() + e.GetCantidad;
        }

        public static Euro operator +(Pesos p, Euro e)
        {
            return ((Euro)p).GetCantidad() + p.GetCantidad;
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            if (e.GetCantidad == d.GetCantidad)
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            if (p.GetCantidad == e.GetCantidad)
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            if (e1.GetCantidad == e2.GetCantidad)
            {
                return true;
            }
            return false;
        }

        private Euro()
        {
            Euro.cotizRespectoDolar = (float)1.12;
        }

        public Euro(double cantidad) : this()
        {
            this.cantidad = cantidad;

        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }
    }







    public class Dolar
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        public static explicit operator Euro(Dolar d)
        {
            Euro e = new Euro(d.GetCantidad() / Euro.GetCotizacion());
            return e;
        }
        public static explicit operator Pesos(Dolar d)
        {
            Pesos p = new Pesos(d.GetCantidad() * Pesos.GetCotizacion());
            return p;
        }
        public double GetCantidad()
        {
            return this.GetCantidad;
        }
        public double GetCotizacion()
        {
            return this.GetCotizacion;
        }
        public static implicit operator Dolar(double d)
        {
            Dolar  temp = new Dolar(temp);
            return temp;
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }
        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }
        public static Dolar operator -(Euro e, Dolar d)
        {
            return ((Dolar)e).GetCantidad() - d.GetCantidad;
        }
        public static Dolar operator -(Pesos p, Dolar d)
        {
            return ((Dolar)p).GetCantidad() - d.GetCantidad;
        }

        public static Dolar operator +(Euro e, Dolar d)
        {
            return ((Dolar)e).GetCantidad() + d.GetCantidad;
        }
        public static Dolar operator +(Pesos p, Dolar d)
        {
            return ((Dolar)p).GetCantidad() + d.GetCantidad;
        }
        public static bool operator ==(Euro e, Dolar d)
        {
            if (e.GetCantidad == d.GetCantidad)
            {
                return true;
            }
            return false;
        }
        public static bool operator ==(Dolar d, Pesos p)
        {
            if (d.GetCantidad == p.GetCantidad)
            {
                return true;
            }
            return false;
        }
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            if (d1.GetCantidad == d2.GetCantidad)
            {
                return true;
            }
            return false;
        }
        private Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }
        public Dolar(double cantidad) : this()
        {
            this.cantidad = cantidad;

        }
        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }       

    }
}
