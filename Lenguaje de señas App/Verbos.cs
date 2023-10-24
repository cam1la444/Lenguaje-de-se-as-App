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
    public partial class Verbos : Form
    {
        public Verbos()
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

        private void btnComer_Click(object sender, EventArgs e)
        {
            Comer comer = new Comer();
            comer.ShowDialog();
        }

        private void btnDormir_Click(object sender, EventArgs e)
        {
            Dormir dormir = new Dormir();
            dormir.ShowDialog();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            Leer leer = new Leer();
            leer.ShowDialog();
        }

        private void btnBailar_Click(object sender, EventArgs e)
        {
            Bailar bailar = new Bailar();
            bailar.ShowDialog();
        }

        private void btnEstudiar_Click(object sender, EventArgs e)
        {
            Estudiar estudiar = new Estudiar();
            estudiar.ShowDialog();
        }

        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            Trabajar trabajar = new Trabajar();
            trabajar.ShowDialog();
        }

        private void btnAyudar_Click(object sender, EventArgs e)
        {
            Ayudar ayudar = new Ayudar();
            ayudar.ShowDialog();
        }

        private void btnPintar_Click(object sender, EventArgs e)
        {
            Pintar pintar = new Pintar();
            pintar.ShowDialog();
        }

        private void btnConocer_Click(object sender, EventArgs e)
        {
            Conocer conocer = new Conocer();
            conocer.ShowDialog();
        }

        private void btnCocinar_Click(object sender, EventArgs e)
        {
            Cocinar cocinar = new Cocinar();
            cocinar.ShowDialog();
        }
    }
}
