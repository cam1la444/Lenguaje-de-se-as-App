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
    public partial class Numero4 : Form
    {
        public Numero4()
        {
            InitializeComponent();
        }

        private void btnRegresar4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtras4_Click(object sender, EventArgs e)
        {
            Numero3 numero3 = new Numero3();
            numero3.Show();
            this.Close();
        }

        private void btnSiguiente4_Click(object sender, EventArgs e)
        {
            Numero5 numero5 = new Numero5();
            numero5.Show();
            this.Close();
        }
    }
}
