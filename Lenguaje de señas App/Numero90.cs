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
    public partial class Numero90 : Form
    {
        public Numero90()
        {
            InitializeComponent();
        }

        private void btnRegresar90_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtras90_Click(object sender, EventArgs e)
        {
            Numero80 numero80 = new Numero80();
            numero80.Show();
            this.Close();
        }

        private void btnSiguiente90_Click(object sender, EventArgs e)
        {
            Numero100 numero100 = new Numero100();
            numero100.Show();
            this.Hide();
        }
    }
}
