using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
     public sealed class Venta
    {
        private DateTime fecha;
        private static int porcentajelva;
        private double precioFinal;
        private Producto producto;

        internal DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
        }
         static Venta()
        {
            porcentajelva = 21;
        }
        private void Vender(int cantidad )
        {
           // fecha=
        }
        public static double  CalcularPrecioFinal(double precioUnidad,int cantidad)
        {
            double precioFinal = (precioUnidad * cantidad) + porcentajelva;
            return precioFinal;
        }
        public string ObtenerDescripcionBreve()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("fecha: {0} \ndescripcion: {1} \nprecioFinal: {2:N2}", fecha, producto.Descripcion, precioFinal);
            return sb.ToString();
        }
    }
}
