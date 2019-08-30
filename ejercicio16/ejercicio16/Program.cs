    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Martin", "Gayo", 00001);
            Alumno alumno2 = new Alumno("Sergio", "Torres", 00002);
            Alumno alumno3 = new Alumno("Raul", "Veredicto", 00003);

            alumno1.Estudiar(5, 3);
            alumno2.Estudiar(3, 9);
            alumno3.Estudiar(2, 7);

            alumno1.CalcularFinal();
            alumno2.CalcularFinal();
            alumno3.CalcularFinal();

            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine(alumno3.Mostrar());

            Console.ReadKey();
        }
    }
}
