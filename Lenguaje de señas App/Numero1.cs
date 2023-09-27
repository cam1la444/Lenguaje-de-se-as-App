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
    public partial class Numero1 : Form
    {
        public Numero1()
        {
            InitializeComponent();
        }

        private void btnAtras0_Click(object sender, EventArgs e)
        {
            Numero0 numero0 = new Numero0();
            numero0.ShowDialog();
            this.Close();
        }

        private void btnSiguiente2_Click(object sender, EventArgs e)
        {
            Numero2 numero2 = new Numero2();
            numero2.Show();
            this.Hide();
        }

        private void btnRegresar1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
