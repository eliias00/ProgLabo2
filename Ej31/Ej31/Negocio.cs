using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej31
{
    class Negocio
    {
        private string nombre;
        private Queue<Cliente> clientes;
        private PuestoAtencion caja;

        public Cliente Cliente
        {

            get
            {
                return this.clientes.Dequeue();
            }
            set
            {
                if (this != value)
                {
                    bool returnAux = this + value;
                }
            }
        }
        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count();
            }
        }
        private Negocio()
            {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.caja1);
            }
        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);   
        }
        public static bool operator ~(Negocio n)
        {
            bool returnAux = false;
            Cliente cliente;
            cliente = n.Cliente;
            returnAux = n.caja.Atender(cliente);
            return returnAux;
        }
        public static bool operator +(Negocio n,Cliente c)
        {
            bool seAgrego = false;

            if (n == c)
            {
                return seAgrego;
            }
            n.clientes.Enqueue(c);
            seAgrego = true;

            return seAgrego;
        }
        public static bool operator ==(Negocio n, Cliente c)
        {
            bool seEncontro = false;

            foreach (Cliente cliente in n.clientes)
            {
                if (cliente == c)
                {
                    seEncontro = true;
                    break;
                }
            }

            return seEncontro;
        }
    }
}
