using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            int min=0;
            int max=0;
            float acum = 0;
            int i;

            for (i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un numero:");
                valor = Convert.ToInt32(Console.ReadLine());

                if (Validacion.Validar(valor, -100, 100))
                {
                    acum += valor;
                    if (i == 0)
                    {
                        max = valor;
                        min = valor;

                    }
                    else if (valor > max)
                    {
                        max = valor;
                    }
                    else if (valor < min)
                    {
                        min = valor;
                    }
                }
                else
                {
                    Console.WriteLine("ingrese un numero entre -100 y 100");
                }
            }
            Console.WriteLine("minimo: {0} maximo: {1} resultado: {2}", min, max, acum / 10);
            Console.ReadKey();  
        }
    }
}
