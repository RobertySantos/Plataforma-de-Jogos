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
    public partial class Form5 : Form
    {
        dados j = new dados();
        public String nome;
        public Form5()
        {
            InitializeComponent();
        }
        dados dados = new dados();
      
        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //j.setNome(textBox1.Text);
            Form1 f1 = new Form1(textBox1.Text); //(j.getNome());
            this.Hide();
            f1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.Show();
        }
    }
}
