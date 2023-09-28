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
    public partial class Numero50 : Form
    {
        public Numero50()
        {
            InitializeComponent();
        }

        private void btnRegresar50_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtras50_Click(object sender, EventArgs e)
        {
            Numero40 numero40 = new Numero40();
            numero40.Show();
            this.Close();
        }

        private void btnSiguiente50_Click(object sender, EventArgs e)
        {
            Numero60 numero60 = new Numero60();
            numero60.Show();
            this.Hide();
        }
    }
}
