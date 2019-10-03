using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;


        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
        }
        public double Precio
        {
            get
            {
                return precio;
            }
        }
        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if (value >=0)
                {
                this.stock = value;
                }
            }
        }
        protected Producto(string descripcion, double precio, int stock)
        {
            this.descripcion = Descripcion;
            this.precio = precio;
            this.stock = stock;
            this.codigo = Guid.NewGuid();
        }
        public static explicit operator Guid(Producto p )
            {
            return p.codigo;
            }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nDescripcion: {0}", this.Descripcion);
            sb.AppendFormat("\nCodigo : {0}", this.codigo);
            sb.AppendFormat("\nPrecio: {0}", this.Precio);
            sb.AppendFormat("\nStock: {0}", this.Stock);
            return sb.ToString(); 
        }
    }
}
