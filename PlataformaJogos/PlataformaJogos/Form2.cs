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
    public partial class Form2 : Form
    {
        dados j = new dados();
        dados j2 = new dados();

        public Form2(String nome,String nome2)
        {
            InitializeComponent();
            label1.Text = nome;
            label3.Text = nome2;
        }
        int rodada = 1, vp1 = 0, vp2 = 0;
        String[] valores = new string[9];
        Class1 regras = new Class1();

    
           

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void campo1_Click(object sender, EventArgs e)
        {
            
            if (regras.vez(rodada) == "p1")
            {
                campo1.Image = new Bitmap("img/x.png");
                valores[0] = "x";
                campo1.Enabled = false;
            }
            else {
                campo1.Image = new Bitmap("img/o.png");
                valores[0] = "o";
                campo1.Enabled = false;
            }
            if (rodada >= 5) {
                if (regras.verifica(valores) == "p1") {
                    MessageBox.Show("O jogador 1 ganhou!");
                    vp1++;
                    label2.Text = vp1.ToString();
                    campo1.Enabled = false;
                    campo2.Enabled = false;
                    campo3.Enabled = false;
                    campo4.Enabled = false;
                    campo5.Enabled = false;
                    campo6.Enabled = false;
                    campo7.Enabled = false;
                    campo8.Enabled = false;
                    campo9.Enabled = false;
                }
                if (regras.verifica(valores) == "p2")
                {
                    MessageBox.Show("O jogador 2 ganhou!");
                    vp2++;
                    label4.Text = vp2.ToString();
                    campo1.Enabled = false;
                    campo2.Enabled = false;
                    campo3.Enabled = false;
                    campo4.Enabled = false;
                    campo5.Enabled = false;
                    campo6.Enabled = false;
                    campo7.Enabled = false;
                    campo8.Enabled = false;
                    campo9.Enabled = false;

                }
            }
            if (rodada == 9) {
                if (regras.verifica(valores) == "") {
                    MessageBox.Show("Deu velha!");
                }
            }
            rodada++;
        }

        private void campo2_Click(object sender, EventArgs e)
        {
            if (regras.vez(rodada) == "p1")
            {
                campo2.Image = new Bitmap("img/x.png");
                valores[1] = "x";
                campo2.Enabled = false;
            }
            else
            {
                campo2.Image = new Bitmap("img/o.png");
                valores[1] = "o";
                campo2.Enabled = false;
            }
            if (rodada >= 5)
            {
                if (regras.verifica(valores) == "p1")
                {
                    MessageBox.Show("O jogador 1 ganhou!");
                    vp1++;
                    label2.Text = vp1.ToString();
                    campo1.Enabled = false;
                    campo2.Enabled = false;
                    campo3.Enabled = false;
                    campo4.Enabled = false;
                    campo5.Enabled = false;
                    campo6.Enabled = false;
                    campo7.Enabled = false;
                    campo8.Enabled = false;
                    campo9.Enabled = false;
                }
                if (regras.verifica(valores) == "p2")
                {
                    MessageBox.Show("O jogador 2 ganhou!");
                    vp2++;
                    label4.Text = vp2.ToString();
                    campo1.Enabled = false;
                    campo2.Enabled = false;
                    campo3.Enabled = false;
                    campo4.Enabled = false;
                    campo5.Enabled = false;
                    campo6.Enabled = false;
                    campo7.Enabled = false;
                    campo8.Enabled = false;
                    campo9.Enabled = false;
                }
            }
            if (rodada == 9)
            {
                if (regras.verifica(valores) == "")
                {
                    MessageBox.Show("Deu velha!");
                }
            }
            rodada++;
        }

        private void campo3_Click(object sender, EventArgs e)
        {
            if (regras.vez(rodada) == "p1")
            {
                campo3.Image = new Bitmap("img/x.png");
                valores[2] = "x";
                campo3.Enabled = false;
            }
            else
            {
                campo3.Image = new Bitmap("img/o.png");
                valores[2] = "o";
                campo3.Enabled = false;
            }
            if (rodada >= 5)
            {
                if (regras.verifica(valores) == "p1")
                {
                    MessageBox.Show("O jogador 1 ganhou!");
                    vp1++;
                    label2.Text = vp1.ToString();
                    campo1.Enabled = false;
                    campo2.Enabled = false;
                    campo3.Enabled = false;
                    campo4.Enabled = false;
                    campo5.Enabled = false;
                    campo6.Enabled = false;
                    campo7.Enabled = false;
                    campo8.Enabled = false;
                    campo9.Enabled = false;
                }
                if (regras.verifica(valores) == "p2")
                {
                    MessageBox.Show("O jogador 2 ganhou!");
                    vp2++;
                    label4.Text = vp2.ToString();
                    campo1.Enabled = false;
                    campo2.Enabled = false;
                    campo3.Enabled = false;
                    campo4.Enabled = false;
                    campo5.Enabled = false;
                    campo6.Enabled = false;
                    campo7.Enabled = false;
                    campo8.Enabled = false;
                    campo9.Enabled = false;
                }
            }
            if (rodada == 9)
            {
                if (regras.verifica(valores) == "")
                {
                    MessageBox.Show("Deu velha!");
                }
            }
            rodada++;
        }

        private void campo4_Click(object sender, EventArgs e)
        {
            if (regras.vez(rodada) == "p1")
            {
                campo4.Image = new Bitmap("img/x.png");
                valores[3] = "x";
                campo4.Enabled = false;
            }
            else
            {
                campo4.Image = new Bitmap("img/o.png");
                valores[3] = "o";
                campo4.Enabled = false;
            }
            if (rodada >= 5)
            {
                if (regras.verifica(valores) == "p1")
                {
                    MessageBox.Show("O jogador 1 ganhou!");
                    vp1++;
                    label2.Text = vp1.ToString();
                    campo1.Enabled = false;
                    campo2.Enabled = false;
                    campo3.Enabled = false;
                    campo4.Enabled = false;
                    campo5.Enabled = false;
                    campo6.Enabled = false;
                    campo7.Enabled = false;
                    campo8.Enabled = false;
                    campo9.Enabled = false;
                }
                if (regras.verifica(valores) == "p2")
                {
                    MessageBox.Show("O jogador 2 ganhou!");
                    vp2++;
                    label4.Text = vp2.ToString();
                    campo1.Enabled = false;
                    campo2.Enabled = false;
                    campo3.Enabled = false;
                    campo4.Enabled = false;
                    campo5.Enabled = false;
                    campo6.Enabled = false;
                    campo7.Enabled = false;
                    campo8.Enabled = false;
                    campo9.Enabled = false;
                }
            }
            if (rodada == 9)
            {
                if (regras.verifica(valores) == "")
                {
                    MessageBox.Show("Deu velha!");
                }
            }
            rodada++;
        }

        private void campo5_Click(object sender, EventArgs e)
        {
            if (regras.vez(rodada) == "p1")
            {
                campo5.Image = new Bitmap("img/x.png");
                valores[4] = "x";
                campo5.Enabled = false;
            }
            else
            {
                campo5.Image = new Bitmap("img/o.png");
                valores[4] = "o";
                campo5.Enabled = false;
            }
            if (rodada >= 5)
            {
                if (regras.verifica(valores) == "p1")
                {
                    MessageBox.Show("O jogador 1 ganhou!");
                    vp1++;
                    label2.Text = vp1.ToString();
                    campo1.Enabled = false;
                    campo2.Enabled = false;
                    campo3.Enabled = false;
                    campo4.Enabled = false;
                    campo5.Enabled = false;
                    campo6.Enabled = false;
                    campo7.Enabled = false;
                    campo8.Enabled = false;
                    campo9.Enabled = false;
                }
                if (regras.verifica(valores) == "p2")
                {
                    MessageBox.Show("O jogador 2 ganhou!");
                    vp2++;
                    label4.Text = vp2.ToString();
                    campo1.Enabled = false;
                    campo2.Enabled = false;
                    campo3.Enabled = false;
                    campo4.Enabled = false;
                    campo5.Enabled = false;
                    campo6.Enabled = false;
                    campo7.Enabled = false;
                    campo8.Enabled = false;
                    campo9.Enabled = false;
                }
            }
            if (rodada == 9)
            {
                if (regras.verifica(valores) == "")
                {
                    MessageBox.Show("Deu velha!");
                }
            }
            rodada++;
        }

        private void campo6_Click(object sender, EventArgs e)
        {
            if (regras.vez(rodada) == "p1")
            {
                campo6.Image = new Bitmap("img/x.png");
                valores[5] = "x";
                campo6.Enabled = false;
            }
            else
            {
                campo6.Image = new Bitmap("img/o.png");
                valores[5] = "o";
                campo6.Enabled = false;
            }
            if (rodada >= 5)
            {
                if (regras.verifica(valores) == "p1")
                {
                    MessageBox.Show("O jogador 1 ganhou!");
                    vp1++;
                    label2.Text = vp1.ToString();
                    campo1.Enabled = false;
                    campo2.Enabled = false;
                    campo3.Enabled = false;
                    campo4.Enabled = false;
                    campo5.Enabled = false;
                    campo6.Enabled = false;
                    campo7.Enabled = false;
                    campo8.Enabled = false;
                    campo9.Enabled = false;
                }
                if (regras.verifica(valores) == "p2")
                {
                    MessageBox.Show("O jogador 2 ganhou!");
                    vp2++;
                    label4.Text = vp2.ToString();
                    campo1.Enabled = false;
                    campo2.Enabled = false;
                    campo3.Enabled = false;
                    campo4.Enabled = false;
                    campo5.Enabled = false;
                    campo6.Enabled = false;
                    campo7.Enabled = false;
                    campo8.Enabled = false;
                    campo9.Enabled = false;
                }
            }
            if (rodada == 9)
            {
                if (regras.verifica(valores) == "")
                {
                    MessageBox.Show("Deu velha!");
                }
            }
            rodada++;
        }

        private void campo7_Click(object sender, EventArgs e)
        {
            if (regras.vez(rodada) == "p1")
            {
                campo7.Image = new Bitmap("img/x.png");
                valores[6] = "x";
                campo7.Enabled = false;
            }
            else
            {
                campo7.Image = new Bitmap("img/o.png");
                valores[6] = "o";
                campo7.Enabled = false;
            }
            if (rodada >= 5)
            {
                if (regras.verifica(valores) == "p1")
                {
                    MessageBox.Show("O jogador 1 ganhou!");
                    vp1++;
                    label2.Text = vp1.ToString();
                    campo1.Enabled = false;
                    campo2.Enabled = false;
                    campo3.Enabled = false;
                    campo4.Enabled = false;
                    campo5.Enabled = false;
                    campo6.Enabled = false;
                    campo7.Enabled = false;
                    campo8.Enabled = false;
                    campo9.Enabled = false;
                }
                if (regras.verifica(valores) == "p2")
                {
                    MessageBox.Show("O jogador 2 ganhou!");
                    vp2++;
                    label4.Text = vp2.ToString();
                    campo1.Enabled = false;
                    campo2.Enabled = false;
                    campo3.Enabled = false;
                    campo4.Enabled = false;
                    campo5.Enabled = false;
                    campo6.Enabled = false;
                    campo7.Enabled = false;
                    campo8.Enabled = false;
                    campo9.Enabled = false;
                }
            }
            if (rodada == 9)
            {
                if (regras.verifica(valores) == "")
                {
                    MessageBox.Show("Deu velha!");
                }
            }
            rodada++;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            reiniciar();
        }

        private void campo8_Click(object sender, EventArgs e)
        {
            if (regras.vez(rodada) == "p1")
            {
                campo8.Image = new Bitmap("img/x.png");
                valores[7] = "x";
                campo8.Enabled = false;
            }
            else
            {
                campo8.Image = new Bitmap("img/o.png");
                valores[7] = "o";
                campo8.Enabled = false;
            }
            if (rodada >= 5)
            {
                if (regras.verifica(valores) == "p1")
                {
                    MessageBox.Show("O jogador 1 ganhou!");
                    vp1++;
                    label2.Text = vp1.ToString();
                    campo1.Enabled = false;
                    campo2.Enabled = false;
                    campo3.Enabled = false;
                    campo4.Enabled = false;
                    campo5.Enabled = false;
                    campo6.Enabled = false;
                    campo7.Enabled = false;
                    campo8.Enabled = false;
                    campo9.Enabled = false;
                }
                if (regras.verifica(valores) == "p2")
                {
                    MessageBox.Show("O jogador 2 ganhou!");
                    vp2++;
                    label4.Text = vp2.ToString();
                    campo1.Enabled = false;
                    campo2.Enabled = false;
                    campo3.Enabled = false;
                    campo4.Enabled = false;
                    campo5.Enabled = false;
                    campo6.Enabled = false;
                    campo7.Enabled = false;
                    campo8.Enabled = false;
                    campo9.Enabled = false;
                }
            }
            if (rodada == 9)
            {
                if (regras.verifica(valores) == "")
                {
                    MessageBox.Show("Deu velha!");
                }
            }
            rodada++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormPrincipal fm = new FormPrincipal();
            fm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.Show();
        }

        private void campo9_Click(object sender, EventArgs e)
        {
            if (regras.vez(rodada) == "p1")
            {
                campo9.Image = new Bitmap("img/x.png");
                valores[8] = "x";
                campo9.Enabled = false;
            }
            else
            {
                campo9.Image = new Bitmap("img/o.png");
                valores[8] = "o";
                campo9.Enabled = false;
            }
            if (rodada >= 5)
            {
                if (regras.verifica(valores) == "p1")
                {
                    MessageBox.Show("O jogador 1 ganhou!");
                    vp1++;
                    label2.Text = vp1.ToString();
                    campo1.Enabled = false;
                    campo2.Enabled = false;
                    campo3.Enabled = false;
                    campo4.Enabled = false;
                    campo5.Enabled = false;
                    campo6.Enabled = false;
                    campo7.Enabled = false;
                    campo8.Enabled = false;
                    campo9.Enabled = false;
                }
                if (regras.verifica(valores) == "p2")
                {
                    MessageBox.Show("O jogador 2 ganhou!");
                    vp2++;
                    label4.Text = vp2.ToString();
                    campo1.Enabled = false;
                    campo2.Enabled = false;
                    campo3.Enabled = false;
                    campo4.Enabled = false;
                    campo5.Enabled = false;
                    campo6.Enabled = false;
                    campo7.Enabled = false;
                    campo8.Enabled = false;
                    campo9.Enabled = false;
                }
            }
            if (rodada == 9)
            {
                if (regras.verifica(valores) == "")
                {
                    MessageBox.Show("Deu velha!");
                }
            }
            rodada++;
        }
        public void reiniciar()
        {

            campo1.Enabled = true;
            campo2.Enabled = true;
            campo3.Enabled = true;
            campo4.Enabled = true;
            campo5.Enabled = true;
            campo6.Enabled = true;
            campo9.Enabled = true;
            campo8.Enabled = true;
            campo7.Enabled = true;
            campo1.Image = null;
            campo2.Image = null;
            campo3.Image = null;
            campo4.Image = null;
            campo5.Image = null;
            campo6.Image = null;
            campo9.Image = null;
            campo8.Image = null;
            campo7.Image = null;

            rodada = 1;
            vp1 = 0;
            vp2 = 0;

            for (int i = 0; i < 9; i++)
            {
                valores[i] = null;
            }
        }
    }
}
