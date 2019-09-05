using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5CAMPUS
{
   public class Estante
    {
        private int ubicacionEstante;
        private Producto[] productos;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad,int ubicacion) :this(capacidad)
        {
           this.ubicacionEstante = ubicacion;
        } 
        
        public Producto[] GetProductos()
        {
            return this.productos;
        }
        public String MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("======================ESTANTE======================");
            sb.AppendLine("UBICACION: " + e.ubicacionEstante);
            sb.AppendLine("CAPACIDAD: " + e.productos.Length);
            sb.AppendLine("PRODUCTOS:");
            foreach (Producto p in e.productos)
            {
                sb.AppendLine(Producto.MostrarProducto(p));
            }

            return sb.ToString();
        }
        public static bool operator ==(Estante e, Producto p)
        {
            // Recorro la lista de productos del estante...
            foreach (Producto aux in e.productos)
            {
                // Valido que la posición del Array no sea null
                if (!object.ReferenceEquals(aux, null))
                {
                    // Utilizo la sobrecarga del == de Producto
                    if (p == aux)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            // Si el Estante no contiene el Producto...
            if (e != p)
            {
                // Recorro la lista de productos del estante...
                for (int i = 0; i < e.productos.Length; i++)
                {
                    // Busco un espacio vacio
                    if (object.ReferenceEquals(e.productos[i], null))
                    {
                        e.productos[i] = p;
                        // Si agregué, rompo el lazo para no volver a agregarlo.
                        return true;
                    }
                }
            }
            // Si no salió hasta acá es porque no agregó el ítem
            return false;
        }
        public static Estante operator -(Estante e, Producto p)
        {
            // Recorro la lista de productos del estante...
            for (int i = 0; i < e.productos.Length; i++)
            {
                // Valido que la posición del Array no sea null
                if (!object.ReferenceEquals(e.productos[i], null))
                {
                    // Utilizo la sobrecarga del == de Producto
                    if (p == e.productos[i])
                    {
                        // Vacio el espacio que ocupaba dicho Producto
                        e.productos[i] = null;
                        // Rompo el lazo
                        break;
                    }
                }
            }
            return e;
        }
    }
}
