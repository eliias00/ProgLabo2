using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
   public class Comic : Producto
    {
        public enum TipoComic
        {
            occidental,
            oriental   
        }
        private string autor;
        private TipoComic tipoComic;

        public Comic(string autor,int stock,double precio,string descripcion,TipoComic tipoComic)
            :base(descripcion,precio,stock)
        {
            this.autor = autor;
            this.tipoComic = tipoComic;
        }
        public override string ToString()
        {
            StringBuilder texto = new StringBuilder(base.ToString());
            texto.Append("Autor:" + this.autor);
            texto.Append("Tipo Comic:" + this.tipoComic);
            return texto.ToString();
        }

    }
}
