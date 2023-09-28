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
    public partial class Numero9 : Form
    {
        public Numero9()
        {
            InitializeComponent();
        }

        private void btnRegresar9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtras9_Click(object sender, EventArgs e)
        {
            Numero8 numero8 = new Numero8();
            numero8.Show();
            this.Close();
        }

        private void btnSiguiente9_Click(object sender, EventArgs e)
        {
            Numero10 numero10 = new Numero10();
            numero10.Show();
            this.Hide();
        }
    }
}
