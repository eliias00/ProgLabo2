    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Local : Llamada
    {
        protected float costo;

        public override float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }
        protected override string Mostrar()
        {
            StringBuilder texto = new StringBuilder(base.Mostrar());
            texto.Append("\ncosto llamada: " + this.CostoLlamada);
            return texto.ToString();
        }
        private float CalcularCosto()
        {
            return (this.duracion * this.costo);
        }
        public Local(Llamada llamada, float costo)
            : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }
        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {

        }
        public bool Equals(object obj)
        {
            if(obj is Local)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return Mostrar();
        }
    }
}
