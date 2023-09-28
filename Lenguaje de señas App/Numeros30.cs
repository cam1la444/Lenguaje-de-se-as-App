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
    public partial class Numeros30 : Form
    {
        public Numeros30()
        {
            InitializeComponent();
        }

        private void btnRegresar30_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtras30_Click(object sender, EventArgs e)
        {
            Numero20 numero20 = new Numero20();
            numero20.Show();
            this.Close();
        }

        private void btnSiguiente30_Click(object sender, EventArgs e)
        {
            Numero40 numero40 = new Numero40();
            numero40.Show();
            this.Hide();
        }
    }
}
