﻿using System;
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
            
        }

        private void btnAtras2_Click(object sender, EventArgs e)
        {
            Numero1 numero1 = new Numero1();
            numero1.Show();
            this.Close();
        }

        private void btnRegresar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSiguiente2_Click(object sender, EventArgs e)
        {
            Numero3 numero3 = new Numero3();
            numero3.Show();
            this.Close();
        }
    }
}
