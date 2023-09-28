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
    public partial class Numero60 : Form
    {
        public Numero60()
        {
            InitializeComponent();
        }

        private void btnRegresar60_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtras60_Click(object sender, EventArgs e)
        {
            Numero50 numero50 = new Numero50();
            numero50.Show();
            this.Close();
        }

        private void btnSiguiente60_Click(object sender, EventArgs e)
        {
            Numero70 numero70 = new Numero70();
            numero70.Show();
            this.Hide();
        }
    }
}
