using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ej31
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;
    public enum Puesto
    {
        caja1,
        caja2
    }
        public static int NumeroActual
        {
             get
             {
                PuestoAtencion.numeroActual++;
                return PuestoAtencion.numeroActual;
             }
        }
        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
        public bool Atender(Cliente cli)
        {
            Random r = new Random();
            Thread.Sleep(r.Next(1000, 3000));
            return true;
        }
    }
}
