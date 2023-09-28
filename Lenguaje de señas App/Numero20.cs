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
    public partial class Numero20 : Form
    {
        public Numero20()
        {
            InitializeComponent();
        }

        private void btnSiguiente20_Click(object sender, EventArgs e)
        {
            Numeros30 numero30 = new Numeros30();
            numero30.Show();
            this.Hide();
        }

        private void btnRegresar20_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtras20_Click(object sender, EventArgs e)
        {
            Numero10 numero10 = new Numero10();
            numero10.Show();
            this.Close();
        }
    }
}
