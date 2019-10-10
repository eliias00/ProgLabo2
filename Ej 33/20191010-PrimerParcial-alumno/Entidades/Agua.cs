using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Agua : Botella
    {
        const int MEDIDA = 400;
        public Agua(int capacidadML,string marca , int contenidoML) : base(marca, capacidadML, contenidoML)
        {

        }
        protected new string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Capacidad Mililitros: {0}\r\n", this.capacidadML);
            sb.AppendFormat("Contenido Mililitros: {0}\r\n", this.contenidoML);
            sb.AppendFormat("Marca: {0}\r\n", this.marca);
            sb.AppendFormat("Medida: {0}\r\n", MEDIDA);
            sb.AppendLine("--------------------------------");

            return sb.ToString();
        }

    }
}
