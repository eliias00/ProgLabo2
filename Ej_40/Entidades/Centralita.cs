using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;

        protected string razonSocial;

        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincia);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float valorRecaudado = 0;

            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    foreach (Llamada llamada in this.listaDeLlamadas)
                    {
                        if (llamada is Local)
                        {
                            valorRecaudado += ((Local)llamada).CostoLlamada;
                        }
                    }
                    break;
                case Llamada.TipoLlamada.Provincia:
                    foreach (Llamada llamada in this.listaDeLlamadas)
                    {
                        if (llamada is Provincial)
                        {
                            valorRecaudado += ((Provincial)llamada).CostoLlamada;
                        }
                    }
                    break;
                case Llamada.TipoLlamada.Todas:
                    foreach (Llamada llamada in this.listaDeLlamadas)
                    {
                        if (llamada is Provincial)
                        {
                            valorRecaudado += ((Provincial)llamada).CostoLlamada;
                        }
                        if (llamada is Local)
                        {
                            valorRecaudado += ((Local)llamada).CostoLlamada;
                        }
                    }
                    break;
                default:
                    break;
            }
            return valorRecaudado;
        }
        public override string ToString ()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendFormat("Razon Social: {0}\nGanancia Total: {1}\nGanancia Locales: {2}\nGanancia Provinciales: {3}\n", this.razonSocial, this.GananciasPorTotal, this.GananciasPorLocal, this.GananciasPorProvincial);

            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                texto.AppendLine("Detalle de llamadas:" + llamada.ToString());
            }
            return texto.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        private void AgregarLlamada(Llamada nuevaLlamda)
        {
            listaDeLlamadas.Add(nuevaLlamda);
        }
        public static bool operator ==(Centralita c, Llamada llamada)
        {
            foreach (Llamada llamAux in c.listaDeLlamadas)
            {
                if (llamada == llamAux)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Centralita c1, Llamada l1)
        {
            return !(c1 == l1);
        }
        public static Centralita operator +(Centralita c1, Llamada l1)
        {

            if (c1 != l1)
            {
                c1.AgregarLlamada(l1);
            }
            return c1;
        }
    }
}
