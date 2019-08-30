using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio17
{
    class boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;
        /// <summary>
        /// asigna los valores 
        /// </summary>
        /// <param name="tinta"></param>
        /// <param name="color"></param>
        public boligrafo(short tinta,ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }
        public ConsoleColor getColor()
        {
            return this.color;
        }
        public short getTinta()
        {
            return this.tinta;
        }
        public bool pintar(short gasto, out string dibujo)
        {
            bool returnAux = false;
            dibujo = "";
            int resto;
            resto=this.GetTinta() - (short)gasto;
            if (resto > 0)
            {
                this.SetTinta((short)resto);
                returnAux = true;

                for (int i = 1; i <= gasto; i++)
                {
                    dibujo += '*';
                }
            }
            return returnAux;
        }
        public void recargar()
        {
        this.setTinta(cantidadTintaMaxima);
        }
        private void setTinta(short tinta)
        {
            if(tinta>=0 && tinta <=cantidadTintaMaxima)
            {
                this.tinta = tinta;
            }
        }
    }
}
