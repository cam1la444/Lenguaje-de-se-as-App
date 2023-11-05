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
    public partial class FrmRegistrame : Form
    {
        public FrmRegistrame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text==txtConfirmacion.Text)
            {
                if (RegistroUsuarios.CrearCuentas(txtEmail.Text, txtContraseña.Text) > 0)
                {
                    MessageBox.Show("Cuenta Creada con Exito");
                }
                else
                    MessageBox.Show("No se pudo crear la cuenta");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
