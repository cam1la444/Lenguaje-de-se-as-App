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
    public partial class Numero80 : Form
    {
        public Numero80()
        {
            InitializeComponent();
        }

        private void btnRegresar80_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSiguiente80_Click(object sender, EventArgs e)
        {
            Numero90 numero90 = new Numero90();
            numero90.Show();
            this.Hide();
        }

        private void btnAtras80_Click(object sender, EventArgs e)
        {
            Numero70 numero70 = new Numero70();
            numero70.Show();
            this.Close();
        }
    }
}
