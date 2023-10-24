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
    public partial class Manzana : Form
    {
        public Manzana()
        {
            InitializeComponent();
        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            string Manzana = "C:\\Users\\jwest\\Videos\\VideoManzana.mp4";
            asWMPA.URL = Manzana;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
