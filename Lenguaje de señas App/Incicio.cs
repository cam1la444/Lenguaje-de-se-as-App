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
            this.Hide();
            abecedario.Show();
        }

        private void btnNumeros_Click(object sender, EventArgs e)
        {
            Numeros numeros = new Numeros();
            this.Hide();
            numeros.Show();
        }

        private void btnColores_Click(object sender, EventArgs e)
        {
            Colores colores = new Colores();
            this.Hide();
            colores.Show();
        }

        private void btnTiempo_Click(object sender, EventArgs e)
        {
            Tiempo tiempo = new Tiempo();
            this.Hide();
            tiempo.Show();
        }

        private void btnComida_Click(object sender, EventArgs e)
        {
            Comida comida = new Comida();
            this.Hide();
            comida.Show();
        }

        private void btnFamilia_Click(object sender, EventArgs e)
        {
            Familia familia = new Familia();
            this.Hide();
            familia.Show();
        }

        private void btnAnimales_Click(object sender, EventArgs e)
        {
            Animales animales = new Animales();
            this.Hide();
            animales.Show();
        }

        private void btnVestimenta_Click(object sender, EventArgs e)
        {
            Vestimenta vestimenta = new Vestimenta();
            this.Hide();
            vestimenta.Show();
        }

        private void btnPronombres_Click(object sender, EventArgs e)
        {
            Pronombres pronombres = new Pronombres();
            this.Hide();
            pronombres.Show();
        }

        private void btnVerbos_Click(object sender, EventArgs e)
        {
            Verbos verbos = new Verbos();  
            this.Hide();
            verbos.Show();
        }

        private void btnSaludos_Click(object sender, EventArgs e)
        {
            Saludos saludos = new Saludos();
            this.Hide();
            saludos.Show();
        }

        private void btnAdjetivos_Click(object sender, EventArgs e)
        {
            Adjetivos adjetivos = new Adjetivos();
            this.Hide();
            adjetivos.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMasInforms_Click(object sender, EventArgs e)
        {
            MasInformacion masinfo = new MasInformacion();
            this.Close();
            masinfo.Show();
        }

        private void btnAcercade_Click(object sender, EventArgs e)
        {
            Acercade acercade = new Acercade();
            this.Close();
            acercade.Show();
        }
    }
}
