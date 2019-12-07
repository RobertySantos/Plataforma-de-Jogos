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
    public partial class Ganhou : Form
    {
        public Ganhou()
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
            this.Dispose();
            FormPrincipal fm = new FormPrincipal();
            fm.Show();
        }
    }
}
