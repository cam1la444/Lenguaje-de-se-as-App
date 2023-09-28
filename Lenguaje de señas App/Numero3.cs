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
    public partial class Numero3 : Form
    {
        public Numero3()
        {
            InitializeComponent();
        }

        private void btnRegresar30_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtras30_Click(object sender, EventArgs e)
        {
            Numero2 numero2 = new Numero2();
            numero2.Show();
            this.Close();
        }

        private void btnSiguiente30_Click(object sender, EventArgs e)
        {
            Numero4 numero4 = new Numero4();
            numero4.Show();
            this.Close();
        }
    }
}
