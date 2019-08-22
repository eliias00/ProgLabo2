using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundoPgm
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            double cuadrado;
            double cubo;
            Console.Write("Ingrese un numero:");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero <= 0)
            {
                Console.Write("error, reingrese numero");
                Console.Write("reingrese un numero:");
                numero = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                cuadrado=Math.Pow(numero, 2);
                         Console.WriteLine("cuadrado: {0}",cuadrado);
                cubo=Math.Pow(numero, 3);
                     Console.WriteLine("cubo: {0}", cubo);
            }
            Console.ReadKey();
          
        }
    }
}
