using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public abstract class Botella
    {
        public enum Tipo
        {
            Plastico,
            Vidrio
        }
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;

        public int CapacidadLitros
        {
            get
            {
                return this.capacidadML/1000;
            }
        }
        public int Contenido
        {
            get
            {
                return this.contenidoML;
            }
            set
            {
                this.contenidoML = value;
            }
        }
        public int PorcentajeContenido
        {
            get
            {
                return (this.contenidoML * this.capacidadML) / 100;
            }
        }
        protected Botella(string marca,int capacidadML,int contenidoML)
        {
            this.marca = marca;
            if (capacidadML < contenidoML)
            {
                this.contenidoML = capacidadML;
            }
            this.contenidoML = contenidoML;
            this.capacidadML = capacidadML;
        }
        public override string ToString()
        {
            return GenerarInforme();
        }
        protected string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Capacidad Mililitros: {0}\r\n", this.capacidadML);
            sb.AppendFormat("Contenido Mililitros: {0}\r\n", this.contenidoML);
            sb.AppendFormat("Marca: {0}\r\n", this.marca);
            sb.AppendLine("--------------------------------");

            return sb.ToString();
        }   
        public abstract int ServirMedida()
        {
         
        }
    }
}
