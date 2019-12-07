using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PlataformaJogos
{
    public partial class Instrucoes : Form
    {
        Image[] img = new Image[8];
        int tag, cliques, cartasEncontradas, minuto = 1, segundo = 00;
        List<string> lista = new List<string>();
        int[] tags = new int[2];
        string[] carta = new string[2];
        

        public Instrucoes()
        {
            InitializeComponent();
            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                item.Visible = false;
            }   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio();
        }

        private void Inicio()
        {
            Sortear();
            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                tag = int.Parse(String.Format("{0}", item.Tag));
                img[tag] = item.Image;
                item.Visible = true;
                item.Enabled = true;
            }
            Thread.Sleep(3000);
            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                //item.Image = Properties.Resources.question;
            }
            timer1.Enabled = true;
        }

        private void Sortear()
        {
            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                Random r = new Random();

                int[] xp = { 372, 483, 594, 705 };
                int[] yp = { 28, 148, 268, 388 };
                
                Repete:
                var X = xp[r.Next(0, xp.Length)];
                var Y = yp[r.Next(0, yp.Length)];

                string verificacao = X.ToString() + Y.ToString();

                if (lista.Contains(verificacao))
                {
                    goto Repete;
                }
                else
                {
                    item.Location = new Point(X, Y);
                    lista.Add(verificacao);
                }

            }
        }

        private void ImagensClick_Click(object sender, EventArgs e)
        {
            bool parEncontrado = false;

            PictureBox pic = (PictureBox)sender;
            cliques++;

            tag = int.Parse(String.Format("{0}", pic.Tag));
            pic.Image = img[tag];
            pic.Refresh();

            if(cliques == 1)
            {
                tags[0] = int.Parse(String.Format("{0}", pic.Tag));
                carta[0] = pic.Name;
            }
            else if (cliques == 2)
            {
                tags[1] = int.Parse(String.Format("{0}", pic.Tag));
                carta[1] = pic.Name;
                parEncontrado = Verificar();
                Desvirar(parEncontrado);
            } 
        }

        private bool Verificar()
        {
            cliques = 0;

            if (tags[0] == tags[1] && carta[0] != carta[1] )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Desvirar(bool check)
        {
            Thread.Sleep(500);

            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                if(int.Parse(String.Format("{0}", item.Tag)) == tags[0] || int.Parse(String.Format("{0}", item.Tag)) == tags[1])
                {
                    if(check == true)
                    {
                        item.Enabled = false;
                        cartasEncontradas++;
                    }
                    else
                    {
                       // item.Image = Properties.Resources.question;
                        item.Refresh();
                    }
                }
            }

            Ganhou();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Nivel n2 = new Nivel();
            this.Hide();
            n2.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundo--;
            if(minuto > 0)
            {
                if(segundo < 0)
                {
                    segundo = 59;
                    minuto--;
                }
            }
            label2.Text = "0" + minuto + ":" + segundo; 
            if(minuto ==0 && segundo == 0)
            {
                timer1.Enabled = false;
                Perdeu n5 = new Perdeu();
                n5.ShowDialog();
                this.Dispose();
            }
        }

        private void Ganhou()
        {
            if (cartasEncontradas ==(img.Length * 2))
            {
                timer1.Enabled = false;
                Ganhou n3 = new Ganhou();
                n3.ShowDialog();
                this.Dispose();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Instrucoes n1 = new Instrucoes();
            this.Hide();
            n1.ShowDialog();
        }
    }
}
