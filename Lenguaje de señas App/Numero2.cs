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

        private void btnSiguiente2_Click(object sender, EventArgs e)
        {
            Numero3 numero3= new Numero3();
            numero3.Show();
            this.Hide();
        }

        private void btnAtras2_Click(object sender, EventArgs e)
        {
            Numero1 numer1 = new Numero1();
            numer1.Show();
            this.Close();
        }

        private void btnRegresar2_Click(object sender, EventArgs e)
        {
            string Dos = "C:\\Users\\jwest\\Videos\\VideoDos.mp4";
            asWMPA.URL = Dos;
        }
    }
}
