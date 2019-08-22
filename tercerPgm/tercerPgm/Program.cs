using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tercerPgm
{
    class Program
    {
        static void Main(string[] args)
        {
            int  i;
            int aux;
            Console.WriteLine("Ingrese el numero ");
            aux = Convert.ToInt32( Console.ReadLine());
            
            for (i = 2; i <= aux; i++)
            {
                if (i != 2 && i != 3)
                {
                    if ((i % 2 != 0) && (i % 3 != 0))
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
