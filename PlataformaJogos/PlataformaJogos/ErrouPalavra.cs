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
    public partial class ErrouPalavra : Form
    {
        public ErrouPalavra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaJogoForca t = new TelaJogoForca();
            t.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPrincipal t = new FormPrincipal();
            t.Show();
            this.Dispose();
        }

      
    }
}
