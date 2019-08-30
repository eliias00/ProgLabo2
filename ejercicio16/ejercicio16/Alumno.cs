using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio16
{
    class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        private int legajo;
        private string apellido;
        private string nombre;

        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        public void CalcularFinal()
        {
            Random random = new Random();
            this.notaFinal = -1;
            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                this.notaFinal = random.Next(1, 10);
            }
        }
        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;

        }
        public string Mostrar()
        {
            StringBuilder cadena = new StringBuilder(); 

            if(this.notaFinal == -1)
            {
                            
                cadena.AppendFormat("{0} {1}\nLegajo: {2}\nNota 1: {3} Nota 2: {4}\nNota Final: {5}", this.nombre, this.apellido, this.legajo, this.nota1, this.nota2, "Alumno desaprobado");
            }
            else
            {
                cadena.AppendFormat("{0} {1}\nLegajo: {2}\nNota 1: {3} Nota 2: {4}\nNota Final: {5}", this.nombre, this.apellido, this.legajo, this.nota1, this.nota2, this.notaFinal);
            }
            return cadena.ToString();
        }
    }
}
 