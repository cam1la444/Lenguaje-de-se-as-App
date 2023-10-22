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
    public partial class Familia : Form
    {
        public Familia()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Incicio inicio = new Incicio();
            this.Hide();
            inicio.Show();
        }

        private void btnLecciones_Click(object sender, EventArgs e)
        {
            Incicio inicio = new Incicio();
            this.Close();
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

        private void btnMama_Click(object sender, EventArgs e)
        {
            Mama mama = new Mama();
            mama.ShowDialog();
        }

        private void btnPapa_Click(object sender, EventArgs e)
        {
            Papa papa = new Papa();
            papa.ShowDialog();
        }

        private void btnAbuela_Click(object sender, EventArgs e)
        {
            Abuela abuela = new Abuela();
            abuela.ShowDialog();
        }

        private void btnAbuelo_Click(object sender, EventArgs e)
        {
            Abuelo abuelo = new Abuelo();
            abuelo.ShowDialog();
        }

        private void btnHermano_Click(object sender, EventArgs e)
        {
            Hermano hermano = new Hermano();
            hermano.ShowDialog();
        }

        private void btnHermana_Click(object sender, EventArgs e)
        {
            Hermana hermana = new Hermana();
            hermana.ShowDialog();
        }

        private void btnPrima_Click(object sender, EventArgs e)
        {
           
        }
    }
}
