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
    public partial class Numero40 : Form
    {
        public Numero40()
        {
            InitializeComponent();
        }

        private void btnRegresar40_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSiguiente40_Click(object sender, EventArgs e)
        {
            Numero50 numero50 = new Numero50();
            numero50.Show();
            this.Hide();
        }

        private void btnAtras40_Click(object sender, EventArgs e)
        {
            Numeros30 numeros30 = new Numeros30();
            numeros30.Show();
            this.Close();
        }
    }
}
