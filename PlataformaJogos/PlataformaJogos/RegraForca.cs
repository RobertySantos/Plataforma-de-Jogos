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
    public partial class RegraForca : Form
    {
        public RegraForca()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaJogoForca t = new TelaJogoForca();
            t.Show();
            this.Dispose();
        }

    }
}
