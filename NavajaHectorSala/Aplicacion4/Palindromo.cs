using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaHectorSala.Palindromo
{
    /// <summary>
    /// Clase que representa una aplicacion que confirma si una cadena de texto es palindromica.
    /// </summary>
    public partial class Palindromo : Form
    {
        /// <summary>
        /// Constructor de la clase Palindromo.
        /// </summary>
        public Palindromo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Recorre la cadena posicion a posicion comparandolas desde el principio
        /// y el desde el final sucesivamente.
        /// </summary>
        /// <param name="cadena">Cadena de caracteres.</param>
        /// <returns>Devuelve true o false en funcion de si la cadena es palindromica
        /// o no</returns>
        bool comprobarPalindromo(string cadena)
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

        /// <summary>
        /// Evento que lanza un metodo de la clase Palindromo.
        /// </summary>
        /// <param name="sender">Lanza el evento en el boton button1_Click.</param>
        /// <param name="e">Si uso.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            string cadena;
            cadena = tTexto.Text;

            if (comprobarPalindromo(cadena))
            {
                MessageBox.Show("Palindromica");
            }
            else
            {
                MessageBox.Show("No Palindromica");
            }
        }
    }
}
