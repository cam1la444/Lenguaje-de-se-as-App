using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lenguaje_de_señas_App
{
    public partial class Incicio : Form
    {
        public Incicio()
        {
            InitializeComponent();
        }

        private void btnAbecedario_Click(object sender, EventArgs e)
        {
            Abecedario abecedario = new Abecedario();
            abecedario.ShowDialog();
        }

        private void btnNumeros_Click(object sender, EventArgs e)
        {
            Numeros numeros = new Numeros();
            numeros.ShowDialog();
        }

        private void btnColores_Click(object sender, EventArgs e)
        {
            Colores colores = new Colores();
            colores.ShowDialog();
        }

        private void btnTiempo_Click(object sender, EventArgs e)
        {
            Tiempo tiempo = new Tiempo();
            tiempo.ShowDialog();
        }

        private void btnComida_Click(object sender, EventArgs e)
        {
            Comida comida = new Comida();
            comida.ShowDialog();
        }

        private void btnFamilia_Click(object sender, EventArgs e)
        {
            Familia familia = new Familia();
            familia.ShowDialog();
        }
    }
}
