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
    public partial class Numero6 : Form
    {
        public Numero6()
        {
            InitializeComponent();
        }

        private void btnRegresar6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtras6_Click(object sender, EventArgs e)
        {
            Numero5 numero5 = new Numero5();
            numero5.Show();
            this.Close();
        }

        private void btnSiguiente6_Click(object sender, EventArgs e)
        {
            Numero7 numero7 = new Numero7();
            numero7.Show();
            this.Hide();
        }
    }
}
