using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavajaHectorSala.Palindromo
{
    /// <summary>
    /// Clase que representa la logica de una aplicacion que confirma si una cadena de texto es palindromica.
    /// </summary>
    public static class LogicaPalindromo
    {
        /// <summary>
        /// Recorre la cadena posicion a posicion comparandolas desde el principio
        /// y el desde el final sucesivamente.
        /// </summary>
        /// <param name="cadena">Cadena de caracteres.</param>
        /// <returns>Devuelve true o false en funcion de si la cadena es palindromica
        /// o no</returns>
        public static bool comprobarPalindromo(string cadena)
        {
            int numLetras, i = 0;
            bool palindromica = true;

            numLetras = cadena.Length - 1;

            while (i <= numLetras && palindromica)//i < texto.Length/2
            {
                if (cadena[i] == ' ')
                {
                    i++;
                }
                if (cadena[numLetras] == ' ')
                {
                    numLetras--;
                }
                if (cadena[i] != cadena[numLetras])
                {
                    palindromica = false;
                }
                i++;
                numLetras--;
            }

            return palindromica;
        }
    }
}
