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
            Occidental,
            Oriental   
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
            StringBuilder texto = new StringBuilder();
            texto.Append(base.ToString());
            texto.AppendFormat("Autor: {0}" , this.autor);
            texto.AppendFormat("Tipo Comic: {0}" , this.tipoComic);
            return texto.ToString();
        }

    }
}
