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
            :this("figura" + altura + "cm", stock, precio, altura)

        {
           
        }
        public Figura(string descripcion,int stock, double precio, double altura)
            :base(descripcion,precio,stock)
           
        {
          
        }
        public override string toString()
        {
            StringBuilder texto = new StringBuilder(base.ToString());
            texto.Append("Altura:" + this.altura);
            return texto.ToString();
        }

    }
}
