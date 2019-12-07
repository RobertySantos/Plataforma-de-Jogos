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
    public partial class FormJogadorForca : Form
    {
        public FormJogadorForca()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jogador j = new Jogador();
            j.Nome = nomeJogador.Text;

            TelaJogoForca t = new TelaJogoForca();
            t.Show();
        }

        private void FormJogadorForca_Load(object sender, EventArgs e)
        {

        }


    }
}
