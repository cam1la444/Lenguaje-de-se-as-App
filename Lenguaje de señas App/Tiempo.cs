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

        private void btnViernes_Click(object sender, EventArgs e)
        {
            Viernes viernes = new Viernes();
            viernes.ShowDialog();
        }

        private void btnSabado_Click(object sender, EventArgs e)
        {
            Sabado sabado = new Sabado();
            sabado.ShowDialog();
        }

        private void btnDomingo_Click(object sender, EventArgs e)
        {
            Domingo domingo = new Domingo();
            domingo.ShowDialog();
        }

        private void btnMañana_Click(object sender, EventArgs e)
        {
            Mañana mañana = new Mañana();
            mañana.ShowDialog();
        }

        private void btnAyer_Click(object sender, EventArgs e)
        {
            Ayer ayer = new Ayer();
            ayer.ShowDialog();
        }

        private void btnThisWeek_Click(object sender, EventArgs e)
        {
            Esta_Semana estasemana = new Esta_Semana();
            estasemana.ShowDialog();
        }

        private void btnThisTarde_Click(object sender, EventArgs e)
        {
            Esta_Tarde estatarde = new Esta_Tarde();
            estatarde.ShowDialog();
        }

        private void btnNextWeek_Click(object sender, EventArgs e)
        {
            Proxima_Semana proximasemana = new Proxima_Semana();
            proximasemana.ShowDialog();
        }

        private void btnWeekAgo_Click(object sender, EventArgs e)
        {
            Semana_Pasada semanapasada = new Semana_Pasada();
            semanapasada.ShowDialog();
        }
    }
}
