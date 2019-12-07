using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace PlataformaJogos
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            Thread t = new Thread(new ThreadStart(splashScreen));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }

        public void splashScreen() {
            Application.Run(new Splash());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            RegraForca t = new RegraForca();
            t.Show();
            this.Hide();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TelaInicial tl = new TelaInicial();
            tl.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form7 velha = new Form7();
            
            velha.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Instrucoes inst = new Instrucoes();
 
            inst.Show();
        }
    }
}
