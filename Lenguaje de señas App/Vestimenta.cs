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
    public partial class Vestimenta : Form
    {
        public Vestimenta()
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

        private void btnGorra_Click(object sender, EventArgs e)
        {
            Gorra gorra = new Gorra();
            gorra.ShowDialog();
        }

        private void btnVestido_Click(object sender, EventArgs e)
        {
            Vestido vestido = new Vestido();
            vestido.ShowDialog();
        }

        private void btnPantalon_Click(object sender, EventArgs e)
        {
            Pantalon pantalon = new Pantalon();
            pantalon.ShowDialog();
        }

        private void btnCamisa_Click(object sender, EventArgs e)
        {
            Camisa camisa = new Camisa();
            camisa.ShowDialog();
        }

        private void btnPijama_Click(object sender, EventArgs e)
        {
            Pijama pijama = new Pijama();
            pijama.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bata bata = new Bata();
            bata.ShowDialog();
        }

        private void btnFalda_Click(object sender, EventArgs e)
        {
            Falda falda = new Falda();
            falda.ShowDialog();
        }

        private void btnZapato_Click(object sender, EventArgs e)
        {
            Zapato zapato = new Zapato();
            zapato.ShowDialog();
        }

        private void btnSueter_Click(object sender, EventArgs e)
        {
            Sueter sueter = new Sueter();
            sueter.ShowDialog();
        }

        private void btnGorro_Click(object sender, EventArgs e)
        {
            Gorro gorro = new Gorro();
            gorro.ShowDialog();
        }

        private void btnGuantes_Click(object sender, EventArgs e)
        {
            Guantes guantes = new Guantes();
            guantes.ShowDialog();
        }

        private void btnCamiseta_Click(object sender, EventArgs e)
        {
            Camiseta camiseta = new Camiseta();
            camiseta.ShowDialog();
        }
    }
}
