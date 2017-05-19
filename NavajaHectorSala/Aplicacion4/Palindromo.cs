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
    /// <remarks>Pese a llamarlo palindromo podemos introducir todo tipo de caracteres ademas de letras.</remarks>
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
        /// Evento que lanza un metodo de la clase Palindromo.
        /// </summary>
        /// <param name="sender">Lanza el evento en el boton button1_Click.</param>
        /// <param name="e">Si uso.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            string cadenaTexto;
            cadenaTexto = tTexto.Text;

            try
            {
                if (cadenaTexto == "")
                {
                    MessageBox.Show("La cadena está vacia");
                }
                else
                {
                    if (LogicaPalindromo.comprobarPalindromo(cadenaTexto))
                    {
                        MessageBox.Show("Palindromica");
                    }
                    else
                    {
                        MessageBox.Show("No Palindromica");
                    }
                }
            }
            catch (Exception Exception)
            {
                MessageBox.Show("Se ha producido un error" + Exception.Message);
            }
        }
    }
}
