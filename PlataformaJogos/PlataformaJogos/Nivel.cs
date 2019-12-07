using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PlataformaJogos
{
    public partial class Nivel : Form
    {
        public Nivel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Instrucoes n1 = new Instrucoes();
            this.Hide();
            n1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nivel2 n4 = new Nivel2();
            this.Hide();
            n4.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nivel1 n6 = new Nivel1();
            this.Hide();
            n6.ShowDialog();
        }
    }
}
