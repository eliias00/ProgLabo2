using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int respuesta;
            double ladoCuadrado;
            double baseTriangulo;
            double alturaTriangulo;
            double radioCirculo;
            double areaCuadrado;
            double areaTriangulo;
            double areaCirculo;

            Console.Write("Seleccione que calculo desea realizar: \n");
            Console.Write("1 - Calcular Area del Cuadrado  \n");
            Console.Write("2 - Calcular Area del Triangulo \n");
            Console.Write("3 - Calcular Area del Circulo   \n");
            respuesta = Convert.ToInt32( Console.ReadLine());

            switch(respuesta)
                {
                case 1:
                    Console.WriteLine("AREA CUADRADO\n");
                    Console.Write("Ingrese lado del cuadrado: ");
                    ladoCuadrado = Convert.ToDouble(Console.ReadLine());
                    areaCuadrado = CalculoDeArea.CalcularCuadrado(ladoCuadrado);
                    Console.WriteLine("Area del cuadrado: {0}", areaCuadrado);  
                    break;

                case 2:
                    Console.WriteLine("AREA TRIANGULO\n");
                    Console.Write("Ingrese base del triangulo: ");
                    baseTriangulo = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Ingrese altura del triangulo: ");
                    alturaTriangulo = Convert.ToDouble(Console.ReadLine());


                    areaTriangulo = CalculoDeArea.CalcularTriangulo(baseTriangulo, alturaTriangulo);
                    Console.WriteLine("Area del cuadrado: {0}", areaTriangulo);
                    break;

                case 3:
                    Console.WriteLine("AREA CIRCULO\n");
                    Console.Write("Ingrese el radio del circulo: ");
                    radioCirculo = Convert.ToDouble(Console.ReadLine());
                    areaCirculo = CalculoDeArea.CalcularCuadrado(radioCirculo);
                    Console.WriteLine("Area del cuadrado: {0}", areaCirculo);
                    break;
                default:
                    Console.WriteLine("opcion invalida");
                    break;

            }
            Console.ReadKey();
        }
    }
}
