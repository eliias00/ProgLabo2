using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerPgm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejercicio 1";
            
            int numero;
            int min = 0;
            int max = 0;
            float acum = 0;

            for(int i=0;i<5;i++)
            {
                Console.WriteLine("ingrese numero");
                numero= Convert.ToInt32(Console.ReadLine());

                acum += numero;
                if(i==0)
                {
                    max = numero;
                    min = numero;

                }
                else if (numero > max)
                {
                    max = numero;
                }
                else if (numero < min)
                {
                    min = numero;
                }

            }
                Console.WriteLine("minimo: {0} maximo: {1} resultado: {2}", min,max,acum/5);
            Console.ReadKey();           
        }
    }
}
