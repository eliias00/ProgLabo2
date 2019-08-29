using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero1;
            float numero2;
            char signo;
            float resultado;


            Console.WriteLine("ingrese numero 1: ");
            numero1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("ingrese signo: ");
            signo =Convert.ToChar(Console.ReadLine());

            Console.WriteLine("ingrese numero 2: ");
            numero2 = Convert.ToSingle(Console.ReadLine());
            
            resultado = Calculadora.Calcular(numero1, numero2, signo);
            Console.WriteLine("resultado: {0}", resultado);

            Console.ReadKey();
        }
    }
}
