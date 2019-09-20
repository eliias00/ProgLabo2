using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
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

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        private float CalcularCosto()
        {
            float costo;

            switch(this.franjaHoraia)
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
        public new string Mostrar()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendFormat("Llamda Provincial \nDuracion: {0}\nNumero Destino: {1}\nNumero Origen: {2}\nCosto: {3} \nFranaja Horaria: {4} ", this.Duracion, this.NroDestino, this.NroOrigen, this.CostoLlamada,this.franjaHoraia);
            return texto.ToString();
        }
        public Provincial(Franja miFranja, Llamada llamada) 
            :base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraia= miFranja;
        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino ) 
            :this(miFranja,new Llamada(duracion, destino, origen))
        {

        }
    }
}
