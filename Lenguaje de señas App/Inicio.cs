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
    public partial class Inicio : Form
    {
        public Inicio()
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
    }
}
