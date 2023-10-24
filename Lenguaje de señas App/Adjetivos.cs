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
    public partial class Adjetivos : Form
    {
        public Adjetivos()
        {
            InitializeComponent();
        }

        private void btnLecciones_Click(object sender, EventArgs e)
        {
            Incicio inicio = new Incicio();
            this.Close();
            inicio.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Incicio inicio = new Incicio();
            this.Hide();
            inicio.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAcercade_Click(object sender, EventArgs e)
        {
            Acercade acercade = new Acercade();
            this.Close();
            acercade.Show();
        }

        private void btnMasInforms_Click(object sender, EventArgs e)
        {
            MasInformacion masinfo  = new MasInformacion();
            this.Close();
            masinfo.Show();
        }

        private void btnFeo_Click(object sender, EventArgs e)
        {
            Feo feo = new Feo();
            feo.ShowDialog();
        }

        private void btnBonito_Click(object sender, EventArgs e)
        {
            Bonito bonito = new Bonito();
            bonito.ShowDialog();
        }

        private void btnGordo_Click(object sender, EventArgs e)
        {
            Gordo gordo = new Gordo();
            gordo.ShowDialog();
        }

        private void btnDelgado_Click(object sender, EventArgs e)
        {
            Delgado delgado = new Delgado();
            delgado.ShowDialog();
        }

        private void btnAlto_Click(object sender, EventArgs e)
        {
            Alto alto = new Alto();
            alto.ShowDialog();
        }

        private void btnBajo_Click(object sender, EventArgs e)
        {
            Bajo bajo = new Bajo();
            bajo.ShowDialog();
        }

        private void btnAlegre_Click(object sender, EventArgs e)
        {
            Alegre alegre = new Alegre();
            alegre.ShowDialog();
        }

        private void btnEnojado_Click(object sender, EventArgs e)
        {
            Enojado enojado = new Enojado();
            enojado.ShowDialog();
        }

        private void btntriste_Click(object sender, EventArgs e)
        {
            Triste triste = new Triste();
            triste.ShowDialog();
        }

        private void btnInteligente_Click(object sender, EventArgs e)
        {
            Inteligente inteligente = new Inteligente();
            inteligente.ShowDialog();
        }

        private void btnFuerte_Click(object sender, EventArgs e)
        {
            Fuerte fuerte = new Fuerte();
            fuerte.ShowDialog();
        }

        private void btnDebil_Click(object sender, EventArgs e)
        {
            Debil debil = new Debil();
            debil.ShowDialog();
        }
    }
}
