using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace octavoPgm
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorHora;
            string nombre;
            int anios;
            int cantDeHorasTrabajadas;
            string respuesta;
            int total;
            int porcentaje;

            do
            {
                Console.WriteLine("ingrese el valor de la hora: ");
                valorHora = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("ingrese el nombre: ");
                nombre = Console.ReadLine();

                Console.WriteLine("ingrese la antiguedad(anios): ");
                anios = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("ingrese la cantidad de horas: ");
                cantDeHorasTrabajadas = Convert.ToInt32(Console.ReadLine());

                total = (valorHora * cantDeHorasTrabajadas) + (anios * 150);
                porcentaje = total*0.13;

                Console.WriteLine("nombre: {0} antiguedad: {1} valor hora: {2} total: {3} total con descuento: {4}", nombre, anios, valorHora, total, total - porcentaje);

                Console.WriteLine("quiere seguir agregando gente? s para si/n para no.");
                respuesta = Console.ReadLine();
            } while (respuesta == "s");

            Console.ReadKey();
        }
    }
}
