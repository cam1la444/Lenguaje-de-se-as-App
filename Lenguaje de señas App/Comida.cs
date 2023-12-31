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
    public partial class Comida : Form
    {
        public Comida()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Incicio inicio = new Incicio();
            this.Hide();
            inicio.Show();
        }

        private void btnMasInfo_Click(object sender, EventArgs e)
        {
            Incicio inicio = new Incicio();
            this.Close();
            inicio.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAcercade_Click(object sender, EventArgs e)
        {
            Acercade acercade = new Acercade();
            this.Close();
            acercade.Show();
        }

        private void btnManzana_Click(object sender, EventArgs e)
        {
            Manzana manzana =new Manzana();
            manzana.ShowDialog();
        }

        private void btnFresa_Click(object sender, EventArgs e)
        {
            Fresa fresa = new Fresa();
            fresa.ShowDialog();
        }
        private void btnMandarina_Click(object sender, EventArgs e)
        {
            Mandarina mandarina = new Mandarina();
            mandarina.ShowDialog();
        }

        private void btnDurazno_Click(object sender, EventArgs e)
        {
            Durazno durazno = new Durazno();
            durazno.ShowDialog();
        }

        private void btnSandia_Click(object sender, EventArgs e)
        {
            Sandia sandia = new Sandia();
            sandia.ShowDialog();
        }

        private void btnPiña_Click(object sender, EventArgs e)
        {
            Piña piña = new Piña();
            piña.ShowDialog();
        }

        private void btnNaranja_Click(object sender, EventArgs e)
        {
            Naranjas naranjas = new Naranjas();
            naranjas.ShowDialog();
        }
    }
}
