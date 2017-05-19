using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NavajaHectorSala.Palindromo;

namespace PalindromoTest
{
    /// <summary>
    /// Clase de prueba de la aplicacion Palindromo.
    /// </summary>
    [TestClass]
    public class PruebaPalindromo
    {
        /// <summary>
        /// Cadena con sucesion de caracteres palindromos.
        /// </summary>
        [TestMethod]
        public void PalindromoCorrecto()
        {
            string cadena = "9AA9";
            bool resultado;

            bool resultadoEsperado = true;

            resultado = LogicaPalindromo.comprobarPalindromo(cadena);

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        /// <summary>
        /// Cadena con sucesion de caracteres no palindromos.
        /// </summary>
        [TestMethod]
        public void PalindromoIncorrecto()
        {
            string cadena = "tt42";
            bool resultado;

            bool resultadoEsperado = false;

            resultado = LogicaPalindromo.comprobarPalindromo(cadena);

            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
