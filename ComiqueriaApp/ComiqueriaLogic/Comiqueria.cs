﻿using System;
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
                Guid codigoDelProducto;

                foreach (Producto producto in productos)
                {

                    codigoDelProducto = (Guid)producto;
                    if (codigoDelProducto == codigo)
                    {
                        return producto;
                    }
                }
                return null;
            }
        }
        public Comiqueria()
        {
            productos = new List<Producto>();
            ventas = new List<Venta>(); 
        }
        public void Vender (Producto p, int cant)
        {
            Venta ventaNueva = new Venta(p, cant);
            ventas.Add(ventaNueva);
        }
        public void Vender(Producto p)
        {
            Vender(p, 1);
        }
        public string ListarVentas()
        {
            string retorno = string.Empty;
            this.ventas.OrderByDescending(x => x.Fecha);

            foreach (Venta venta in this.ventas)
            {
                retorno += venta.ObtenerDescripcionBreve();
            }
            return retorno;
        }
        public Dictionary<Guid, string> ListarProductos()
        {
            Dictionary<Guid, string> diccionario = new Dictionary<Guid, string>();
            foreach (Producto producto in this.productos)
            {
                diccionario[(Guid)producto] = producto.Descripcion;
            }

            return diccionario;
        }
        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            foreach (Producto productoEnComiqueria in comiqueria.productos)
            {
                if (productoEnComiqueria.Descripcion == producto.Descripcion)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto);
        }
        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            if(comiqueria!=producto)
            {
                comiqueria.productos.Add(producto);
            }
            return comiqueria;  
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

