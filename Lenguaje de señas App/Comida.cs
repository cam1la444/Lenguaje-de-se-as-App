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
    public partial class Comida : Form
    {
        public Comida()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Incicio inicio = new Incicio();
            this.Hide();
            inicio.Show();
        }

        private void btnMasInfo_Click(object sender, EventArgs e)
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

        private void btnManzana_Click(object sender, EventArgs e)
        {
            Manzana manzana =new Manzana();
            manzana.ShowDialog();
        }

        private void btnFresa_Click(object sender, EventArgs e)
        {
            Fresa fresa = new Fresa();
            fresa.ShowDialog();
        }

        private void btnMelon_Click(object sender, EventArgs e)
        {
            Melon melon = new Melon();
            melon.ShowDialog();
        }

        private void btnPera_Click(object sender, EventArgs e)
        {
            Pera pera = new Pera();
            pera.ShowDialog();
        }

        private void btnMandarina_Click(object sender, EventArgs e)
        {
            Mandarina mandarina = new Mandarina();
            mandarina.ShowDialog();
        }

        private void btnDurazno_Click(object sender, EventArgs e)
        {
            Durazno durazno = new Durazno();
            durazno.ShowDialog();
        }

        private void btnSandia_Click(object sender, EventArgs e)
        {
            Sandia sandia = new Sandia();
            sandia.ShowDialog();
        }

        private void btnLimon_Click(object sender, EventArgs e)
        {
            Limon limon = new Limon();
            limon.ShowDialog();
        }

        private void btnCereza_Click(object sender, EventArgs e)
        {
            Cereza cereza = new Cereza();
            cereza.ShowDialog();
        }

        private void btnPapaya_Click(object sender, EventArgs e)
        {
            Papaya papaya = new Papaya();
            papaya.ShowDialog();
        }

        private void btnPiña_Click(object sender, EventArgs e)
        {
            Piña piña = new Piña();
            piña.ShowDialog();
        }

        private void btnGuineo_Click(object sender, EventArgs e)
        {
            Guineo guineo = new Guineo();
            guineo.ShowDialog();
        }

        private void btnCiruela_Click(object sender, EventArgs e)
        {
            Ciruela ciruela = new Ciruela();
            ciruela.ShowDialog();
        }

        private void btnCoco_Click(object sender, EventArgs e)
        {
            Coco coco = new Coco();
            coco.ShowDialog();
        }

        private void btnNance_Click(object sender, EventArgs e)
        {
            Nance nance = new Nance();
            nance.ShowDialog();
        }

        private void btnNaranja_Click(object sender, EventArgs e)
        {
            Naranjas naranjas = new Naranjas();
            naranjas.ShowDialog();
        }

        private void btnMarañon_Click(object sender, EventArgs e)
        {
            Marañon marañon = new Marañon();
            marañon.ShowDialog();
        }

        private void btnJocote_Click(object sender, EventArgs e)
        {
            Jocote jocote = new Jocote();
            jocote.ShowDialog();
        }

        private void btnAnona_Click(object sender, EventArgs e)
        {
            Anona anona = new Anona();
            anona.ShowDialog();
        }

        private void btnZapote_Click(object sender, EventArgs e)
        {
            Zapote zapote = new Zapote();
            zapote.ShowDialog();
        }

        private void btnMamey_Click(object sender, EventArgs e)
        {
            Mamey mamey = new Mamey();
            mamey.ShowDialog();
        }
    }
}
