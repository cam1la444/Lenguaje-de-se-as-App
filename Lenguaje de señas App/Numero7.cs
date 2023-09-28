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
    public partial class Numero7 : Form
    {
        public Numero7()
        {
            InitializeComponent();
        }

        private void btnRegresar7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtras7_Click(object sender, EventArgs e)
        {
            Numero6 numero6 = new Numero6();
            numero6.Show();
            this.Close();
        }

        private void btnSiguiente7_Click(object sender, EventArgs e)
        {
            Numero8 numero8 = new Numero8();
            numero8.Show();
            this.Close();
        }
    }
}
