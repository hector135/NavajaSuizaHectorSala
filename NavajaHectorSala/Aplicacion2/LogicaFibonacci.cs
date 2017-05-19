using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavajaHectorSala.Fibonacci
{
    /// <summary>
    /// Clase que representa la logica de una aplicacion que muestra la sucesion de fibonacci.
    /// </summary>
    public class LogicaFibonacci
    {
        /// <summary>
        /// Realiza la operacion de sumas sucesivas que conforman fibonacci devolviendo
        /// tantos numeros de la sucesión como le indicamos por parametro.
        /// </summary>
        /// <remarks>No se han de utilizar numeros negativos.</remarks>
        /// <param name="numeroSucesiones">Numero de sucesiones de fibonacci que debe mostrar la aplicacion</param>
        /// <param name="resultado">Cadena de texto con las sucesiones de fibonacci</param>
        /// <returns>Devuelve una cadena con los numeros de la sucesion de Fibonacci.</returns>
        public void fibonacci(int numeroSucesiones, out string resultado)
        {
            int numeroAnterior, numeroSiguiente, numeroSuma;

            numeroAnterior = 1;
            numeroSiguiente = 1;
            numeroSuma = 0;
            resultado = "";

            if (numeroSucesiones == 0)
            {
                resultado = "Introduce un numero distinto a cero";
            }
            else
            {
                if (numeroSucesiones < 0)
                {
                    resultado = "El numero introducido es negativo";
                }
                else
                {
                    for (int i = 0; i < numeroSucesiones; i++)
                    {
                        numeroAnterior = numeroSiguiente;
                        numeroSiguiente = numeroSuma;
                        numeroSuma = numeroAnterior + numeroSiguiente;
                        resultado = resultado + numeroSuma + " + ";
                    }
                }
            }
        }
    }
}
