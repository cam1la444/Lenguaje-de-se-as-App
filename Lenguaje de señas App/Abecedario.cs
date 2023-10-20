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
    public partial class Abecedario : Form
    {
        public Abecedario()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Incicio inicio = new Incicio();
            this.Hide();
            inicio.Show();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            LetraA letraa = new LetraA();
            letraa.ShowDialog();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            LetraB letrab = new LetraB();
            letrab.ShowDialog();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            LetraC letrac = new LetraC();
            letrac.ShowDialog();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            LetraD letrad = new LetraD();
            letrad.ShowDialog();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            LetraE letrae = new LetraE();
            letrae.ShowDialog();
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            LetraF letraf = new LetraF();
            letraf.ShowDialog();
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            LetraG letrag = new LetraG();
            letrag.ShowDialog();
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            LetraH letrah = new LetraH();
            letrah.ShowDialog();
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            LetraI letrai = new LetraI();
            letrai.ShowDialog();
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            LetraJ letraj = new LetraJ();
            letraj.ShowDialog();
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            LetraK letrak = new LetraK();
            letrak.ShowDialog();
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            LetraL letral = new LetraL();
            letral.ShowDialog();
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            LetraM letram = new LetraM();
            letram.ShowDialog();
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            LetraN letran = new LetraN();
            letran.ShowDialog();
        }

        private void btnÑ_Click(object sender, EventArgs e)
        {
            LetraÑ letrañ = new LetraÑ();
            letrañ.ShowDialog();
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            LetraO letrao = new LetraO();
            letrao.ShowDialog();
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            LetraP letrap = new LetraP();
            letrap.ShowDialog();
        }

        private void Q_Click(object sender, EventArgs e)
        {
            LetraQ letraq = new LetraQ();
            letraq.ShowDialog();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            LetraR letrar = new LetraR();
            letrar.ShowDialog();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            LetraS letras = new LetraS();
            letras.ShowDialog();
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            LetraT letrat = new LetraT();
            letrat.ShowDialog();
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            LetraU letrau = new LetraU();
            letrau.ShowDialog();
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            LetraV letrav = new LetraV();
            letrav.ShowDialog();
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            LetraW letraw = new LetraW();
            letraw.ShowDialog();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            LetraX letrax = new LetraX();
            letrax.ShowDialog();
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            LetraY letray = new LetraY();
            letray.ShowDialog();
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            LetraZ letraz = new LetraZ();
            letraz.ShowDialog();
        }

        private void btnLecciones_Click(object sender, EventArgs e)
        {
            Incicio inicio = new Incicio();
            this.Close();
            inicio.Show();
        }
    }
}
