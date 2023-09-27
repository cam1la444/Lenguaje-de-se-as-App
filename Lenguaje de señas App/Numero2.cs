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
    public partial class Numero2 : Form
    {
        public Numero2()
        {
            InitializeComponent();
        }

        private void btnAtras1_Click(object sender, EventArgs e)
        {
            Numero1 numero1 = new Numero1();
            numero1.ShowDialog();
        }

        private void btnSiguiente3_Click(object sender, EventArgs e)
        {
            Numero2 numero2 = new Numero2();
            numero2.ShowDialog();
        }
    }
}
