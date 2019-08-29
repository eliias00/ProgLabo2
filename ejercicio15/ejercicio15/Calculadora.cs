using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio15
{
    class Calculadora
    {
        public static float Calcular(float num1,float num2,char signo)
        {
            float resul=0;

            switch(signo)
            {
                case '+':
                    resul = num1 + num2;
                    break;
                case '-':
                    resul = num1 - num2;
                    break;
                case '*':
                    resul = num1 * num2;
                    break;
                case '/':
                    if(Calculadora.Validar(num2)==1)
                    {
                    resul = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("segundo numero no puede ser 0 para la divicion");
                    }
                    break;
                default:
                    
                    Console.WriteLine("signo no comprendido");
                    break;
            }
            return resul; 
        }
         static float Validar(float num2)
        {
            float retorno = 0;

            if(num2!=0)
            {
                retorno = 1;
            }
            return retorno;
        }
    }
}
