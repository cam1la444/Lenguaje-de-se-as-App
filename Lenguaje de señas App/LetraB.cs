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
    public partial class LetraB : Form
    {
        public LetraB()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            string b = "C:\\Users\\jwest\\Videos\\VideoB.mp4";
            axWMPB.URL = b;
        }
    }
}
