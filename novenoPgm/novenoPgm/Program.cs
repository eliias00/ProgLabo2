using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novenoPgm
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("ingrese numero para la piramide: ");
            numero = Convert.ToInt32(Console.ReadLine());

           if(numero==0)
            {
                Console.WriteLine("ingresar numero mayor a 0");
            }
           else
            {
                for(int i=0;i<=(numero*2);i=i+2)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("*");
                }
                Console.ReadKey();
            }
        }
    }
}
