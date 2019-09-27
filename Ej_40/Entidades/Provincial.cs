using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
        protected Franja franjaHoraia;

        public override float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }
        private float CalcularCosto()
        {
            float costo;

            switch (this.franjaHoraia)
            {
                case Franja.Franja_1:
                    costo = this.duracion * (float)0.99;
                    break;
                case Franja.Franja_2:
                    costo = this.duracion * (float)1.25;
                    break;
                case Franja.Franja_3:
                    costo = this.duracion * (float)0.66;
                    break;

                default:
                    costo = 0;
                    break;
            }
            return costo;
        }
        protected override string Mostrar()
        {
            StringBuilder texto = new StringBuilder(base.Mostrar());
            texto.Append("Franja Horaria:" + this.franjaHoraia);
            texto.Append("Costo Llamada:" + this.CostoLlamada);
            return texto.ToString();
        }
        public Provincial(Franja miFranja, Llamada llamada)
            : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraia = miFranja;
        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {

        }
        public bool Equals(object obj)
        {
            if (obj is Provincial)
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
