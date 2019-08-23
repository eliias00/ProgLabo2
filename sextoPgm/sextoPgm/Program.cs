using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sextoPgm
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int anioInicio;
                int anioFin;
                int flag = 0;

                Console.Write("Ingrese anio de inicio: ");
                anioInicio = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese anio final: ");
                anioFin = Convert.ToInt32(Console.ReadLine());

                    for (int i = anioInicio; i <= anioFin; i++)
                    {
                        if (i % 100 == 0 && i % 400 != 0)
                        {
                            continue;
                        }
                        else
                        {
                            if (i % 4 == 0)
                            {
                                flag = 1;
                                Console.WriteLine("El anio {0} es bisiesto.", i);
                            }
                        }
                    }
                if (flag == 0)
                {
                    Console.WriteLine("No se han hallado anios bisiestos en el rango otorgado");
                }
                Console.ReadKey();
            }
        }
    }
}
