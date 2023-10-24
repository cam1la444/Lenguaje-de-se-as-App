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
    public partial class Vestimenta : Form
    {
        public Vestimenta()
        {
            InitializeComponent();
        }

        private void btnLecciones_Click(object sender, EventArgs e)
        {
            Incicio inicio = new Incicio();
            this.Close();
            inicio.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Incicio inicio = new Incicio();
            this.Hide();
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

        private void btnGorra_Click(object sender, EventArgs e)
        {
            Gorra gorra = new Gorra();
            gorra.ShowDialog();
        }

        private void btnVestido_Click(object sender, EventArgs e)
        {
            Vestido vestido = new Vestido();
            vestido.ShowDialog();
        }

        private void btnPantalon_Click(object sender, EventArgs e)
        {
            Pantalon pantalon = new Pantalon();
            pantalon.ShowDialog();
        }

        private void btnCamisa_Click(object sender, EventArgs e)
        {
            Camisa camisa = new Camisa();
            camisa.ShowDialog();
        }

        private void btnPijama_Click(object sender, EventArgs e)
        {
            Pijama pijama = new Pijama();
            pijama.ShowDialog();
        }
    }
}
