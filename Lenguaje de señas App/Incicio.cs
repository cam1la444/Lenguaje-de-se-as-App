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
    public partial class Incicio : Form
    {
        public Incicio()
        {
            InitializeComponent();
        }

        private void btnAbecedario_Click(object sender, EventArgs e)
        {
            Abecedario abecedario = new Abecedario();
            this.Hide();
            abecedario.Show();
        }

        private void btnNumeros_Click(object sender, EventArgs e)
        {
            Numeros numeros = new Numeros();
            this.Hide();
            numeros.Show();
        }

        private void btnColores_Click(object sender, EventArgs e)
        {
            Colores colores = new Colores();
            this.Hide();
            colores.Show();
        }

        private void btnTiempo_Click(object sender, EventArgs e)
        {
            Tiempo tiempo = new Tiempo();
            this.Hide();
            tiempo.Show();
        }

        private void btnComida_Click(object sender, EventArgs e)
        {
            Comida comida = new Comida();
            this.Hide();
            comida.Show();
        }

        private void btnFamilia_Click(object sender, EventArgs e)
        {
            Familia familia = new Familia();
            this.Hide();
            familia.Show();
        }

        private void btnAnimales_Click(object sender, EventArgs e)
        {
            Animales animales = new Animales();
            this.Hide();
            animales.Show();
        }
    }
}
