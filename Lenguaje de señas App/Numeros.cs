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
    public partial class Numeros : Form
    {
        public Numeros()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Numero0 numero0 = new Numero0();
            numero0.ShowDialog();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Numero1 numero1 = new Numero1();
            numero1.ShowDialog();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Numero2 numero2 = new Numero2();
            numero2.ShowDialog();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Numero3 numero3 = new Numero3();
            numero3.ShowDialog();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Numero4 numero4 = new Numero4();
            numero4.ShowDialog();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Numero5 numero5 = new Numero5();
            numero5.ShowDialog();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Numero6 numero6 = new Numero6();
            numero6.ShowDialog();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Numero7 numero7 = new Numero7();
            numero7.ShowDialog();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Numero8 numero8 = new Numero8();
            numero8.ShowDialog();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Numero9 numero9 = new Numero9();
            numero9.ShowDialog();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            Numero10 numero10 = new Numero10();
            numero10.ShowDialog();
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            Numero20 numero20 = new Numero20();
            numero20.ShowDialog();
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            Numeros30 numero30 = new Numeros30();
            numero30.ShowDialog();
        }

        private void btn40_Click(object sender, EventArgs e)
        {
            Numero40 numero40 = new Numero40();
            numero40.ShowDialog();
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            Numero50 numero50 = new Numero50();
            numero50.ShowDialog();
        }

        private void btn60_Click(object sender, EventArgs e)
        {
            Numero60 numero60 = new Numero60();
            numero60.ShowDialog();

        }

        private void btn70_Click(object sender, EventArgs e)
        {
            Numero70 numero70 = new Numero70();
            numero70.ShowDialog();
        }

        private void btn80_Click(object sender, EventArgs e)
        {
            Numero80 numero80 = new Numero80();
            numero80.ShowDialog();
        }

        private void btn90_Click(object sender, EventArgs e)
        {
            Numero90 numero90 = new Numero90();
            numero90.ShowDialog();
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            Numero100 numero100 = new Numero100();
            numero100.ShowDialog();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Incicio inicio = new Incicio();
            this.Hide();
            inicio.Show();
        }

        private void btnLecciones_Click(object sender, EventArgs e)
        {
            Incicio inicio = new Incicio();
            this.Close();
            inicio.Show();
        }
    }
}
