using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cantina
    {
        private List<Botella> botellas;
        private int espaciosTotales;
        private Cantina singleton;

        public List<Botella> Botellas
        {
            get
            {
                return this.botellas;
            }
        }
        private Cantina (int espacios)
        {
            this.botellas = botellas;
        }
    }
}
