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
    public partial class Nivel1 : Form
    {
        public Nivel1()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Nivel n2 = new Nivel();
            this.Hide();
            n2.ShowDialog();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
