using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace septimoPgm
{
    class Program
    {
        static void Main(string[] args)
        {
            int diaActuaL;
            int mesActual;
            int anioActual;
            int diasVividos;
            int mesesVividos;
            int aniosVividos;
            int valiDia;
            int valiMes;
            int valiAnio;
            int diasBisiesto;
            int flag = 0;

            DateTime fechaActual = DateTime.Now;
            anioActual = fechaActual.Year;
            mesActual = fechaActual.Month;
            diaActual = fechaActual.Day;

            Console.WriteLine("ingrese dia: ");
            valiDia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese mes: ");
            valiMes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese anio: ");
            valiAnio = Convert.ToInt32(Console.ReadLine());

                if (valiMes <= 0 || valiMes >= 13)
                {
                    flag = 1;
                    Console.WriteLine("Mes no valido");
                }
                else if ((valiAnio % 4 == 0 && valiMes == 2) && (valiDia <= 0 || valiDia > 29))
                {
                    flag = 1;
                    Console.WriteLine("Dia no valido");
                }
                else if ((valiAnio % 4 != 0 && valiMes == 2) && (valiDia <= 0 || valiDia > 28))
                {
                    flag = 1;
                    Console.WriteLine("Dia no valido");
                }
                else if ((valiMes == 4 || valiMes == 6 || valiMes == 9 || valiMes == 11) && (valiDia <= 0 || valiDia > 30))
                {
                    flag = 1;
                    Console.WriteLine("Dia no valido");
                }
                else if ((valiMes == 1 || valiMes == 3 || valiMes == 5 || valiMes == 7 || valiMes == 8 || valiMes == 10 || valiMes == 12) && (valiDia <= 0 || valiDia > 31))
                {
                    flag = 1;
                    Console.WriteLine("Dia no valido");
                }
                if (flag == 0)
                {
                    Console.WriteLine(fechaActual);
                    Console.WriteLine("Fecha de Nacimiento: {0}/{1}/{2}", valiDia, valiMes, valiAnio);
                    aniosVividos = anioActual - valiAnio;
                    diasBisiesto = (aniosVividos / 4);
                    mesesVividos = mesActual - valiMes;
                    diasVividos = (aniosVividos * 365) + ((mesesVividos * 30) - valiDia) + diasBisiesto + diaActual;
                    Console.WriteLine("Dias vividos a la fecha actual: {0}", diasVividos);
                 }
                    Console.ReadKey();
        }
    }
}
