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
    public partial class TelaEscolha : Form
    {
        String nome;
        public TelaEscolha(String nome)
        {
            InitializeComponent();
            this.nome = nome;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            TelaJogo4x4 tl = new TelaJogo4x4(this.nome);
            tl.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            TelaInicial tl = new TelaInicial();
            tl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            TelaJogo6x6 tl = new TelaJogo6x6(this.nome);
            tl.Show();
        }

        private void TelaEscolha_Load(object sender, EventArgs e)
        {

        }
    }
}
