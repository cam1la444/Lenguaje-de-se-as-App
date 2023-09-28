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
    public partial class Numero0 : Form
    {
        public Numero0()
        {
            InitializeComponent();
        }

        private void btnRegresar0_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSiguiente0_Click(object sender, EventArgs e)
        {
            Numero1 numero1 = new Numero1();
            numero1.Show();
            this.Close();
        }
    }
}
