using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NavajaHectorSala.Primos;

namespace PrimosTest
{
    /// <summary>
    /// Clase de prueba de la aplicacion Primos.
    /// </summary>
    [TestClass]
    public class PruebaPalindromo
    {
        /// <summary>
        /// Numeros primos entre 0 y 0
        /// </summary>
        [TestMethod]
        public void PrimosPositivoNum0()
        {
            int primerNumero = 0;
            int segundoNumero = 0;
            string mensajeResultado = "";

            string mensajeResultadoEsperado = "0, ";

            mensajeResultado = LogicaPrimos.sacarPrimos(primerNumero, segundoNumero);

            Assert.AreEqual(mensajeResultadoEsperado, mensajeResultado);
        }

        /// <summary>
        /// Numeros primos entre 10 y -5
        /// </summary>
        [TestMethod]
        public void PrimosPrimerNumeroPositivoSegundoNegativo()
        {
            int primerNumero = 10;
            int segundoNumero = -5;
            string mensajeResultado = "";

            string mensajeResultadoEsperado = "Has introducido un numero negativo";

            mensajeResultado = LogicaPrimos.sacarPrimos(primerNumero, segundoNumero);

            Assert.AreEqual(mensajeResultadoEsperado, mensajeResultado);
        }

        /// <summary>
        /// Numeros primos entre -5 y 10
        /// </summary>
        [TestMethod]
        public void PrimosPrimerNumeroNegativoSegundoPositivo()
        {
            int primerNumero = -5;
            int segundoNumero = 10;
            string mensajeResultado = "";

            string mensajeResultadoEsperado = "Has introducido un numero negativo";

            mensajeResultado = LogicaPrimos.sacarPrimos(primerNumero, segundoNumero);

            Assert.AreEqual(mensajeResultadoEsperado, mensajeResultado);
        }

        /// <summary>
        /// Numeros primos entre -1 y -1
        /// </summary>
        [TestMethod]
        public void PrimosNumerosNegativos()
        {
            int primerNumero = -1;
            int segundoNumero = -1;
            string mensajeResultado = "";

            string mensajeResultadoEsperado = "Has introducido un numero negativo";

            mensajeResultado = LogicaPrimos.sacarPrimos(primerNumero, segundoNumero);

            Assert.AreEqual(mensajeResultadoEsperado, mensajeResultado);
        }

        /// <summary>
        /// Numeros primos entre 5 y 15
        /// </summary>
        [TestMethod]
        public void PrimosPositivoPrimerNumero5Segundo15()
        {
            int primerNumero = 5;
            int segundoNumero = 15;
            string mensajeResultado = "";

            string mensajeResultadoEsperado = "5, 7, 11, 13, ";

            mensajeResultado = LogicaPrimos.sacarPrimos(primerNumero, segundoNumero);

            Assert.AreEqual(mensajeResultadoEsperado, mensajeResultado);
        }

        /// <summary>
        /// Numeros primos entre 5 y 15
        /// </summary>
        [TestMethod]
        public void PrimosPositivoPrimerNumero1Segundo1()
        {
            int primerNumero = 1;
            int segundoNumero = 1;
            string mensajeResultado = "";

            string mensajeResultadoEsperado = "1, ";

            mensajeResultado = LogicaPrimos.sacarPrimos(primerNumero, segundoNumero);

            Assert.AreEqual(mensajeResultadoEsperado, mensajeResultado);
        }
    }
}
