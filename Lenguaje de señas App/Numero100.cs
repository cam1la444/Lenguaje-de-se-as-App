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
    public partial class Numero100 : Form
    {
        public Numero100()
        {
            InitializeComponent();
        }

        private void btnRegresar100_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtras100_Click(object sender, EventArgs e)
        {
            Numero90 numero90 = new Numero90();
            numero90.Show();
            this.Close();
        }
    }
}
