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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbecedario_Click(object sender, EventArgs e)
        {
            Abecedario abc = new Abecedario();
            abc.ShowDialog();
            this.Close();
        }

        private void btnNumeros_Click(object sender, EventArgs e)
        {
            Numeros numeros = new Numeros();
            numeros.ShowDialog();
            this.Close();
        }

        private void btnComida_Click(object sender, EventArgs e)
        {

        }

        private void btnColores_Click(object sender, EventArgs e)
        {
            Colores colores = new Colores();
            colores.ShowDialog();
            this.Close();
        }

        private void btnTiempo_Click(object sender, EventArgs e)
        {

        }

        private void btnFamilia_Click(object sender, EventArgs e)
        {

        }

        private void btnAnimales_Click(object sender, EventArgs e)
        {
            Animales animales = new Animales();
            animales.ShowDialog();
            this.Close();
        }

        private void btnVestuario_Click(object sender, EventArgs e)
        {

        }

        private void btnPronombres_Click(object sender, EventArgs e)
        {

        }

        private void btnAdjetivos_Click(object sender, EventArgs e)
        {

        }

        private void btnVerbos_Click(object sender, EventArgs e)
        {

        }

        private void btnFrases_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnHistorias_Click(object sender, EventArgs e)
        {

        }

        private void btnMasInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {

        }
    }
}
