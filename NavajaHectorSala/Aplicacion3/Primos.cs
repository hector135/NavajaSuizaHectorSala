using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaHectorSala.Primos
{
    /// <summary>
    /// Clase que representa una aplicacion que muestra los numeros primos dentro de un rango.
    /// </summary>
    public partial class Primos : Form
    {
        /// <summary>
        /// Constructor de la clase Primos.
        /// </summary>
        public Primos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Realiza la operacion para calcular y devolver los numeros
        /// primos que hay dentro de un rango de dos numeros.
        /// </summary>
        /// <param name="num1">Numero inicial del rango.</param>
        /// <param name="num2">Numero final del rango.</param>
        /// <returns>Devuelve una cadena de numeros primos.</returns>
        string sacarPrimos(int num1, int num2)
        {
            int n, contador;
            bool primo;
            string cadenaPrimos;

            n = 2;
            contador = 0;
            primo = true;
            cadenaPrimos = "";

            for (int i = num1; i <= num2; i++)
            {
                while (n < i && primo)
                {
                    if (i % n == 0)
                    {
                        primo = false;
                    }
                    n++;
                }
                n = 2;
                if (primo)
                {
                    contador++;
                    cadenaPrimos = cadenaPrimos + i + ", ";
                }
                primo = true;
            }
            return cadenaPrimos;
        }

        /// <summary>
        /// Evento que lanza un metodo de la clase Primos.
        /// </summary>
        /// <remarks>Se debe introducir el numero más pequeño en el primer textbox y el mas grande en el segundo.</remarks>
        /// <param name="sender">Lanza el evento en el boton button1_Click.</param>
        /// <param name="e">Si uso.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            bool correcto, correcto2;

            correcto = int.TryParse(tNum1.Text, out num1);
            correcto2 = int.TryParse(tNum2.Text, out num2);

            if (correcto && correcto2)
            {
                MessageBox.Show(sacarPrimos(num1, num2));
            }
            else
            {
                MessageBox.Show("No es un numero");
            }
        }

        private void tNum2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
