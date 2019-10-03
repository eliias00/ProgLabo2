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
             string descripcion;
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
                return this.precio;
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
                if (this.stock >=0)
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
        public explicit operator Guid(Producto p )
            {
          //    p.codigo
            }
        public string ToString()
        {
            StringBuilder texto = new StringBuilder();  
            texto.AppendFormat("Descripcion: {0}\nCodigo: {1}\nPrecio: {2}\nStock: {3}\n",
                                 this.descripcion, this.codigo, this.precio, this.stock);
            return texto.ToString();
        }
    }
}
