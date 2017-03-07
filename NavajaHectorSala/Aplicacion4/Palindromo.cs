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
    public partial class Palindromo : Form
    {
        public Palindromo()
        {
            InitializeComponent();
        }

        bool comprobarPalindromo(string texto)
        {
            
            int numLetras, i = 0;
            bool palindromica = true;

            
            numLetras = texto.Length - 1;

            while (i <= numLetras && palindromica)//i < texto.Length/2
            {
                if (texto[i] == ' ')
                {
                    i++;
                }
                if (texto[numLetras] == ' ')
                {
                    numLetras--;
                }
                if (texto[i] != texto[numLetras])
                {
                    palindromica = false;
                }
                i++;
                numLetras--;
            }
            return palindromica;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto;
            texto = tTexto.Text;

            if (comprobarPalindromo(texto))
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
