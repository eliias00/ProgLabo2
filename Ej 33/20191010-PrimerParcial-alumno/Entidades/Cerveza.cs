using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza : Botella
    {
        private const int MEDIDA = 330;
        private Tipo tipo;

        public Cerveza(int capacidadML, string marca, int contenidoML) :base(marca, capacidadML, contenidoML)
        {

        }
        public Cerveza(int capacidadML, string marca, Tipo tipo, int contenidoML) :this(capacidadML,marca,contenidoML)
        {
            if (this.tipo == null)
            {
                this.tipo = Vidrio;
            }
        }
        protected new string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Capacidad Mililitros: {0}\r\n", this.capacidadML);
            sb.AppendFormat("Contenido Mililitros: {0}\r\n", this.contenidoML);
            sb.AppendFormat("Marca: {0}\r\n", this.marca);
            sb.AppendFormat("Medida: {0}\r\n", MEDIDA);
            sb.AppendFormat("Tipo: {0}\r\n", tipo);
            sb.AppendLine("--------------------------------");

            return sb.ToString();
        }
       public implicit operator Botella.Tipo(Cerveza cerveza)
       {

       }
       public int ServirMedida()
       {

       }
    }
}
