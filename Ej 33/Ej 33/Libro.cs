using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_33
{
    public class Libro
    {
        private List<string> paginas= new List<string>();
        public string this[int ind]
        {
            get
                {
                string retAux="";
                if(ind >= 0 && ind < paginas.Count)
                {
                    retAux = paginas[ind];
                }
                return retAux;
            }
            set
                {
                if (ind >= 0 && ind < paginas.Count)
                {
                    paginas[ind] = value;
                }
                else
                {
                    paginas.Add(value);
                }
            }
        }
    }
}
