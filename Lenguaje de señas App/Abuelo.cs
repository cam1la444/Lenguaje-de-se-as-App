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
    public partial class Abuelo : Form
    {
        public Abuelo()
        {
            InitializeComponent();
        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            string Abuelo = "C:\\Users\\jwest\\Videos\\VideoAbuelo.mp4";
            asWMPA.URL = Abuelo;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
