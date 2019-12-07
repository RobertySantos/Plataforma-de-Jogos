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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaRegras tl = new TelaRegras(textBox1.Text);
            tl.Show();
            this.SetVisibleCore(false);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormPrincipal fm = new FormPrincipal();
            fm.Show();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }
    }
}
