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
    public partial class LetraE : Form
    {
        public LetraE()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            string f = "C:\\Users\\jwest\\Videos\\VideoE.mp4";
            axWMPE.URL = f;
        }
    }
}
