using System;
using System.Collections.Generic;
using System.Linq;  
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
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
        public string Mostrar()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendFormat("Duracion: {0} Nro Destino: {1} Nro Origen: {2}", this.duracion, this.nroDestino, this.nroOrigen);
            return texto.ToString();
        }
        public static int OrdenarPorDuracion(Llamada llamada1,Llamada llamada2)
        {
            return llamada1.duracion.CompareTo(llamada2.duracion);  
        }
    }
}
