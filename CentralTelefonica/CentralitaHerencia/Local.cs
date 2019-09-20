using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        public new string Mostrar()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendFormat("Llamda Local\nDuracion: {0}\nNumero Destino: {1}\nNumero Origen: {2}\nCosto: {3}", this.Duracion, this.NroDestino, this.NroOrigen, this.CostoLlamada);
            return texto.ToString();
        }
        private float CalcularCosto()
        {
            return (this.duracion * this.costo);
        }
        public Local(Llamada llamada,float costo) 
            :base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.costo = costo;
        }
        public Local(string origen,float duracion,string destino,float costo) 
            :this(new Llamada(duracion,destino,origen),costo)
        {

        }
    }
}
