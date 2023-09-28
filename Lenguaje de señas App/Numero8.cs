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
    public partial class Numero8 : Form
    {
        public Numero8()
        {
            InitializeComponent();
        }

        private void btnRegresar8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtras8_Click(object sender, EventArgs e)
        {
            Numero7 numero7 = new Numero7();
            numero7.Show();
            this.Close();
        }

        private void btnSiguiente8_Click(object sender, EventArgs e)
        {
            Numero9 numero9 = new Numero9();
            numero9.Show();
            this.Hide();
        }
    }
}
