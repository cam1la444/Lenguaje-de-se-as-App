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
    public partial class Numero70 : Form
    {
        public Numero70()
        {
            InitializeComponent();
        }

        private void btnRegresar70_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtras70_Click(object sender, EventArgs e)
        {
            Numero60 numero60 = new Numero60();
            numero60.Show();
            this.Close();
        }

        private void btnSiguiente70_Click(object sender, EventArgs e)
        {
            Numero80 numero80 = new Numero80();
            numero80.Show();
            this.Hide();
        }
    }
}
