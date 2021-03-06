﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaHectorSala
{
    /// <summary>
    /// Clase que representa una aplicacion con cuatro botones que abren un formulario cada uno.
    /// </summary>
    public partial class Principal : Form
    {
        /// <summary>
        /// Constructor de la clase Principal.
        /// </summary>
        public Principal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que lanza el formulario Factorial.
        /// </summary>
        /// <param name="sender">Lanza el evento en el boton button1_Click.</param>
        /// <param name="e">Si uso.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Introduce un numero y devuelve su factorial. Por ejemplo: introduces 5. 5*4*3*2*1=120");
            NavajaHectorSala.Factorial.Factorial Formulario = new NavajaHectorSala.Factorial.Factorial();
            Formulario.ShowDialog();
        }

        /// <summary>
        /// Evento que lanza el formulario Fibonacci.
        /// </summary>
        /// <param name="sender">Lanza el evento en el boton button2_Click.</param>
        /// <param name="e">Si uso.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Introduces un numero y te devuelve los numeros de la sucesion de fibonacci tantas veces como el numero que has introducido. Por ejemplo: Introduces 5. 1+1+2+3+5");
            NavajaHectorSala.Fibonacci.Fibonacci Formulario = new NavajaHectorSala.Fibonacci.Fibonacci();
            Formulario.ShowDialog();
        }

        /// <summary>
        /// Evento que lanza el formulario Primos.
        /// </summary>
        /// <param name="sender">Lanza el evento en el boton button3_Click.</param>
        /// <param name="e">Si uso.</param>
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Introduces dos numeros y te devuelve los primos que se encuentran dentro de ese rango. Por ejemplo: Introduces 5 y 10. 5, 7");
            NavajaHectorSala.Primos.Primos Formulario = new NavajaHectorSala.Primos.Primos();
            Formulario.ShowDialog();
        }

        /// <summary>
        /// Evento que lanza el formulario Palindromo.
        /// </summary>
        /// <param name="sender">Lanza el evento en el boton button4_Click.</param>
        /// <param name="e">Si uso.</param>
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Introduces una frase y te devuelve si es palindroma o no. Por ejemplo: Introduces abccba. Palindromica.");
            NavajaHectorSala.Palindromo.Palindromo Formulario = new NavajaHectorSala.Palindromo.Palindromo();
            Formulario.ShowDialog();
        }
    }
}
