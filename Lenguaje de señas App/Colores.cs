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
    public partial class Colores : Form
    {
        public Colores()
        {
            InitializeComponent();
        }

        private void btnLecciones_Click(object sender, EventArgs e)
        {
            Incicio inicio = new Incicio();
            this.Close();
            inicio.Show();
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Incicio inicio = new Incicio();
            this.Hide();
            inicio.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void btnRojo_Click(object sender, EventArgs e)
        {
            Rojo rojo = new Rojo();
            rojo.ShowDialog();
        }
    }
}
