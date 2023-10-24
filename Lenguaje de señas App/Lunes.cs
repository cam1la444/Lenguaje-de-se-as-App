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
    public partial class Lunes : Form
    {
        public Lunes()
        {
            InitializeComponent();
        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            string Lunes = "C:\\Users\\jwest\\Videos\\VideoLunes.mp4";
            asWMPA.URL = Lunes;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
