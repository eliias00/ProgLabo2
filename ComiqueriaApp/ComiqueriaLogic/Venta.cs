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
        internal Venta(Producto p ,int cant)
        {
            this.producto = p;
        }
        private void Vender(int cantidad )
        {
            this.producto.Stock = this.producto.Stock - cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = Venta.CalcularPrecioFinal(producto.Precio, producto.Stock);
        }
        public static double  CalcularPrecioFinal(double precioUnidad,int cantidad)
        {
            double precioFinal = (precioUnidad * cantidad) + (precioUnidad * cantidad) * porcentajelva/100;
            return precioFinal;
        }
        public string ObtenerDescripcionBreve()
        {
            string retorno = string.Empty;
            retorno = string.Format("fecha {0} – descripción {1} –precioFinal {2: 0.00}", this.fecha, producto.Descripcion, this.precioFinal);
            return retorno;
        }
    }
}
