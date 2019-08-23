using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quintoPgm
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero; 
            int flag = 0;
            int acum = 0;
            int suma = 0;
            int aux = 0;

            Console.Write("Ingrese un tope de rango de busqueda: ");
            numero = Convert.ToInt32(Console.ReadLine());

                for (int i = 2; i < numero; i++)
                {
                    acum = acum + (i - 1);
                    suma = i + 1;
                    aux = suma + 1;

                    while (suma <= acum)
                    {
                        suma = suma + aux;

                        if (suma == acum)
                        {
                            flag = 1;
                            Console.WriteLine("{0} es centro numerico grupo 1: {1} grupo 2: {2}", i, acum, suma);
                        }
                        aux++;
                    }
                }
            if (flag == 0)
            {
                Console.WriteLine("No se han podido encontrar centros numericos en el rango otorgado");
            }
            Console.ReadKey();
        }
    }
}
