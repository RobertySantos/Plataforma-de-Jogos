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
    public partial class TelaRegras : Form
    {
        String nome;
        public TelaRegras(String nome)
        {
            InitializeComponent();
            this.nome = nome;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            TelaEscolha tl = new TelaEscolha(nome);
            tl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            TelaInicial tl = new TelaInicial();
            tl.Show();
        }

        private void TelaRegras_Load(object sender, EventArgs e)
        {

        }
    }
}
