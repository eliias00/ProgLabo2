using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public enum TipoLlamada
        {
            Local,
            Provincia,
            Todas

        }
        public abstract float CostoLlamada { get; }
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return llamada1.duracion.CompareTo(llamada2.duracion);
        }
        protected virtual string Mostrar()
        {
            string strDuracion = Convert.ToString(this.duracion);
            StringBuilder formato = new StringBuilder();
            formato.AppendFormat("\nDuracion: {0} \nNro Destino: {1} \nNro Origen: {2}"
            ,strDuracion, this.nroDestino,this.nroOrigen);

            return strDuracion.ToString();
        }
        public static bool operator ==(Llamada l1, Llamada l2)
        {
            if (l1.nroDestino == l2.nroDestino && l1.nroOrigen == l2.nroOrigen)
            {
                return true;
            }
            return false;   
        }
        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }
    }
}
