using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavajaHectorSala.Factorial
{
    /// <summary>
    /// Clase que representa la logica de una aplicacion que realiza el factorial de un numero.
    /// </summary>
    public class LogicaFactorial
    {
        /// <summary>
        /// Realiza la factorizacion de un numero entero.
        /// </summary>
        /// <param name="numero">Numero a partir del cual se realiza el factorial</param>
        /// <param name="resultado">Resultado numerico obtenido de la factorizacion</param>
        /// <param name="mensajeResultado">Cadena de texto del resultado obtenido de la factorizacion</param>
        /// <returns>Devuelve el resultado de la factorizacion.</returns>
        public void iterativoFactorial(int numero, out int resultado, out string mensajeResultado)
        {
            resultado = 1;
            mensajeResultado = "";

            if (numero == 0)
            {
                resultado = 0;
                mensajeResultado = "El factorial de " + numero + " es: " + resultado;
            }
            else
            {
                if (numero < 0)
                {
                    mensajeResultado = "El numero introducido es negativo";
                }
                else
                {
                    for (int i = numero; i > 0; i--)
                    {
                        resultado = resultado * i;
                    }
                    mensajeResultado = "El factorial de " + numero + " es: " + resultado;
                }
            }
        }
    }
}
