using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavajaHectorSala.Primos
{

    /// <summary>
    /// Clase que representa la logica de una aplicacion que muestra los numeros primos dentro de un rango.
    /// </summary>
    public static class LogicaPrimos
    {
        /// <summary>
        /// Realiza la operacion para calcular y devolver los numeros
        /// primos que hay dentro de un rango de dos numeros.
        /// </summary>
        /// <param name="num1">Numero inicial del rango.</param>
        /// <param name="num2">Numero final del rango.</param>
        /// <returns>Devuelve una cadena de numeros primos.</returns>
        public static string sacarPrimos(int num1, int num2)
        {
            int divisor, contador;
            bool primo;
            string resultado;

            divisor = 2;
            contador = 0;
            primo = true;
            resultado = "";

            
            if (num1 < 0 || num2 < 0)
            {
                resultado = "Has introducido un numero negativo";
            }
            else
            {
                for (int i = num1; i <= num2; i++)
                {
                    while (divisor < i && primo)
                    {
                        if (i % divisor == 0)
                        {
                            primo = false;
                        }
                        divisor++;
                    }
                    divisor = 2;
                    if (primo)
                    {
                        contador++;
                        resultado = resultado + i + ", ";
                    }
                    primo = true;
                }
            }            
            return resultado;
        }
    }
}
