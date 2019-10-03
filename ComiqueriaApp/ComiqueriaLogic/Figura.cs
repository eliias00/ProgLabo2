using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
   public class Figura : Producto
    {
        private double altura;

        public Figura (int stock, double precio, double altura) 
            :this("figura " + altura + "cm ", stock, precio, altura)
        {
        }
        public Figura(string descripcion,int stock, double precio, double altura)
            :base(descripcion,precio,stock)
        {
            this.altura = altura;
        }
        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();
            texto.Append(base.ToString());
            texto.AppendFormat("Altura: {0}" , this.altura);
            return texto.ToString();
        }
    }
}
