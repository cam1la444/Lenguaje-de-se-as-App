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
    public partial class Tiempo : Form
    {
        public Tiempo()
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

        private void btnHoy_Click(object sender, EventArgs e)
        {
            Hoy hoy = new Hoy();
            hoy.ShowDialog();
        }

        private void btnLunes_Click(object sender, EventArgs e)
        {
            Lunes lunes = new Lunes();
            lunes.ShowDialog();
        }

        private void btnMartes_Click(object sender, EventArgs e)
        {
            Martes martes = new Martes();
            martes.ShowDialog();
        }

        private void btnMiercoles_Click(object sender, EventArgs e)
        {
            Miercoles miercoles = new Miercoles();
            miercoles.ShowDialog();
        }

        private void btnJueves_Click(object sender, EventArgs e)
        {
            Jueves jueves = new Jueves();
            jueves.ShowDialog();
        }
    }
}
