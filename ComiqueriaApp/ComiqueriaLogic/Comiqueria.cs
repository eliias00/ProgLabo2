using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        private List<Producto> productos;
        private List<Venta> ventas;
            
    public Producto this[Guid codigo]
    {

        get
        {
            foreach (Producto producto in productos)
            {
                if (codigo == (Guid)producto)
                {
                    return producto;
                }
                else
                {
                    return null;
                }
            }
        }
    }
    public static bool operator ==(Comiqueria comiqueria ,Producto producto)
    {
            foreach ( producto.Descripcion in productos)
            {
                 return producto;
            }   
    }
        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            foreach (producto.Descripcion in productos)
            {
                return producto;
            }
        }
        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            foreach (producto.Descripcion in productos)
            {
                return producto;
            }
        }

    }
}

