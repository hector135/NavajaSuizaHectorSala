﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaHectorSala.Factorial
{
    /// <summary>
    /// Clase que representa una aplicacion que realiza el factorial de un numero.
    /// </summary>
    public partial class Factorial : Form
    {
        /// <summary>
        /// Constructor de la clase Factorial.
        /// </summary>
        public Factorial()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que lanza un metodo de la clase Factorial.
        /// </summary>
        /// <param name="sender">Lanza el evento en el boton button1_Click.</param>
        /// <param name="e">Si uso.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            LogicaFactorial factorial = new LogicaFactorial();
            int numero, resultado;
            string mensajeResultado;
            bool correcto;

            correcto = int.TryParse(tNum.Text, out numero);

            try
            {
                if (correcto)
                {
                    factorial.iterativoFactorial(numero, out resultado, out mensajeResultado);
                    MessageBox.Show(mensajeResultado);
                }
                else
                {
                    MessageBox.Show("No es un numero");
                }
            }
            catch (Exception Exception)
            {
                MessageBox.Show("Se ha producido un error" + Exception.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
