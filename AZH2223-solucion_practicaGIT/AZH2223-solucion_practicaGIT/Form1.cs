using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AZH2223_solucion_practicaGIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bCalcular_Click_1(object sender, EventArgs e)
        {
            // Práctica realizada por AZH2223
            string textoTelegrama;
            char tipoTelegrama = 'o';
            int numPalabras = 0;
            double coste;

            // Práctica realizada por AZH2223
            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;

            // telegrama urgente?
            if (cbUrgente.Checked)
                tipoTelegrama = 'u';

            // Práctica realizada por AZH2223
            //Obtengo el número de palabras que forma el telegrama
            numPalabras = textoTelegrama.Split(' ', ',', '.', ':', ';').Length - 1;

            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 2.5 + 0.5 * (numPalabras - 10);
            else

            // Práctica realizada por AZH2223
            //Si el telegrama es urgente
            if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}
