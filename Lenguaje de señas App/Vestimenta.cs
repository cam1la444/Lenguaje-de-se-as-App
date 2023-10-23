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

        private void btnCalcetines_Click(object sender, EventArgs e)
        {
            Calcetines calcetines = new Calcetines();
            calcetines.ShowDialog();
        }

        private void btnGorra_Click(object sender, EventArgs e)
        {
            Gorra gorra = new Gorra();
            gorra.ShowDialog();
        }

        private void btnCincho_Click(object sender, EventArgs e)
        {
            Cincho cincho = new Cincho();
            cincho.ShowDialog();
        }

        private void btnUniforme_Click(object sender, EventArgs e)
        {
            Uniforme uniforme = new Uniforme();
            uniforme.ShowDialog();
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

        private void btnCorbata_Click(object sender, EventArgs e)
        {
            Corbata corbata = new Corbata();
            corbata.ShowDialog();
        }

        private void btnSombrero_Click(object sender, EventArgs e)
        {
            Sombrero sombrero = new Sombrero();
            sombrero.ShowDialog();
        }
    }
}
