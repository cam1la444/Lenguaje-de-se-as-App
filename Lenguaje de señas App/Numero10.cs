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
    public partial class Numero10 : Form
    {
        public Numero10()
        {
            InitializeComponent();
        }

        private void btnRegresar10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtras10_Click(object sender, EventArgs e)
        {
            Numero9 numero9 = new Numero9();    
            numero9.Show();
            this.Close();
        }

        private void btnSiguiente10_Click(object sender, EventArgs e)
        {
            Numero20 numero20 = new Numero20();
            numero20.Show();
            this.Hide();

        }
    }
}
