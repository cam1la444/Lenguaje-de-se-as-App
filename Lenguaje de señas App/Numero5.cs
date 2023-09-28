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
    public partial class Numero5 : Form
    {
        public Numero5()
        {
            InitializeComponent();
        }

        private void btnRegresar5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtras5_Click(object sender, EventArgs e)
        {
            Numero4 numero4 = new Numero4();
            numero4.Show();
            this.Close();
        }

        private void btnSiguiente5_Click(object sender, EventArgs e)
        {
            Numero6 numero6 = new Numero6();
            numero6.Show();
            this.Hide();
        }
    }
}
