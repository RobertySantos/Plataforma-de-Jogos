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

    public partial class Form1 : Form
    {
        dados j = new dados();
        
        Random r = new Random();
        Random r1 = new Random();
       
        int jogadas = 0, rodadas = 0, pontosjogador = 0, pontoscpu = 0, pontosempate = 0;
        Boolean vez = false, ganhou=false,empate = true;
        String[] valores = new String[9];
        public Form1(String nome)
        {
           
            InitializeComponent();
            label1.Text = nome;
           

        }

        public Form1(String jog1, String jog2)
        {
            //j.setNome();

            //InitializeComponent();

            //jogad1.Text = j.getNome();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void campo1_Click(object sender, EventArgs e)
        {
            rodadas++;
            PictureBox campos = (PictureBox)sender;
            if (campos.Image == null)
            {
                String index = campos.Tag.ToString();
            int indexvetor = Convert.ToInt32(index);
            jogadas++;
               
                if (jogadas == 5)
                {
                    campos.Image = new Bitmap("img/x.png");
                    valores[indexvetor] = "x";
                    jogadas = 0;
                    checagem(1);
                }
                else
                {
                    campos.Image = new Bitmap("img/x.png");
                    valores[indexvetor] = "x";
                    checagem(1);
                    if (ganhou == false) {
                       
                        verifica();
                    }
                    
                }
               
               
            }
        }

        public void aleatorio()
        {
            
            Boolean marcar = false;
            if (vez == false)
            {
                while (marcar == false)
                {
                    int a = 0;

                    a = r.Next(0, 9);

                    
                    foreach (var pc in Controls.OfType<PictureBox>())
                    {
                        if (pc.Image == null && pc.Tag.Equals(a.ToString()))
                        {
                            marcar = true;
                            valores[a] = "o";
                           
                           
                                cpu(a);
                                
                            checagem(2);
                        }
                    }
                }
                
            }
        }
        public void verifica()
        {
            
            if (valores[0] == "o" && valores[1] == null && valores[2] == "o")
            {
                rodadas++;
                campo2.Image = new Bitmap("img/o.png");
                valores[1] = "o";
                checagem(2);
            }
            else if (valores[0] == null && valores[1] == "o" && valores[2] == "o")
            {
                rodadas++;
                campo1.Image = new Bitmap("img/o.png");
                valores[0] = "o";
                checagem(2);
            }
            else if (valores[0] == "o" && valores[1] == "o" && valores[2] == null)
            {
                rodadas++;
                campo3.Image = new Bitmap("img/o.png");
                valores[2] = "o";
                checagem(2);
            }
            else if (valores[3] == null && valores[4] == "o" && valores[5] == "o")
            {
                rodadas++;
                campo4.Image = new Bitmap("img/o.png");
                valores[3] = "o";
                checagem(2);
            }
            else if (valores[3] == "o" && valores[4] == null && valores[5] == "o")
            {
                rodadas++;
                campo5.Image = new Bitmap("img/o.png");
                valores[4] = "o";
                checagem(2);
            }

            else if (valores[3] == "o" && valores[4] == "o" && valores[5] == null)
            {
                rodadas++;
                campo6.Image = new Bitmap("img/o.png");
                valores[5] = "o";
                checagem(2);
            }
            else if (valores[6] == null && valores[7] == "o" && valores[8] == "o")
            {
                rodadas++;
                campo7.Image = new Bitmap("img/o.png");
                valores[6] = "o";
                checagem(2);
            }
            else if (valores[6] == "o" && valores[7] == null && valores[8] == "o")
            {
                rodadas++;
                campo8.Image = new Bitmap("img/o.png");
                valores[7] = "o";
                checagem(2);
            }
            else if (valores[6] == "o" && valores[7] == "o" && valores[8] == null)
            {
                rodadas++;
                campo9.Image = new Bitmap("img/o.png");
                valores[8] = "o";
                checagem(2);
            }
            else if (valores[0] == "o" && valores[3] == null && valores[6] == "o")
            {
                rodadas++;
                campo4.Image = new Bitmap("img/o.png");
                valores[3] = "o";
                checagem(2);
            }
            else if (valores[0] == null && valores[3] == "o" && valores[6] == "o")
            {
                rodadas++;
                campo1.Image = new Bitmap("img/o.png");
                valores[0] = "o";
                checagem(2);
            }
            else if (valores[0] == "o" && valores[3] == "o" && valores[6] == null)
            {
                rodadas++;
                campo7.Image = new Bitmap("img/o.png");
                valores[6] = "o";
                checagem(2);
            }
            else if (valores[1] == "o" && valores[4] == null && valores[7] == "o")
            {
                rodadas++;
                campo5.Image = new Bitmap("img/o.png");
                valores[4] = "o";
                checagem(2);
            }
            else if (valores[1] == null && valores[4] == "o" && valores[7] == "o")
            {
                rodadas++;
                campo2.Image = new Bitmap("img/o.png");
                valores[1] = "o";
                checagem(2);
            }
            else if (valores[1] == "o" && valores[4] == "o" && valores[7] == null)
            {
                rodadas++;
                campo8.Image = new Bitmap("img/o.png");
                valores[7] = "o";
                checagem(2);
            }
            else if (valores[2] == "o" && valores[5] == null && valores[8] == "o")
            {
                rodadas++;
                campo6.Image = new Bitmap("img/o.png");
                valores[5] = "o";
                checagem(2);
            }
            else if (valores[2] == null && valores[5] == "o" && valores[8] == "o")
            {
                rodadas++;
                campo3.Image = new Bitmap("img/o.png");
                valores[2] = "o";
                checagem(2);
            }
            else if (valores[2] == "o" && valores[5] == "o" && valores[8] == null)
            {
                rodadas++;
                campo9.Image = new Bitmap("img/o.png");
                valores[8] = "o";
                checagem(2);
            }

            else if (valores[0] == "o" && valores[4] == null && valores[8] == "o")
            {
                rodadas++;
                campo5.Image = new Bitmap("img/o.png");
                valores[4] = "o";
                checagem(2);
            }
            else if (valores[0] == null && valores[4] == "o" && valores[8] == "o")
            {
                rodadas++;
                campo1.Image = new Bitmap("img/o.png");
                valores[0] = "o";
                checagem(2);
            }
            else if (valores[0] == "o" && valores[4] == "o" && valores[8] == null)
            {
                rodadas++;
                campo9.Image = new Bitmap("img/o.png");
                valores[8] = "o";
                checagem(2);
            }

            else if (valores[2] == "o" && valores[4] == null && valores[6] == "o")
            {
                rodadas++;
                campo5.Image = new Bitmap("img/o.png");
                valores[4] = "o";
                checagem(2);
            }
            else if (valores[2] == null && valores[4] == "o" && valores[6] == "o")
            {
                rodadas++;
                campo3.Image = new Bitmap("img/o.png");
                valores[2] = "o";
                checagem(2);
            }
            else if (valores[2] == "o" && valores[4] == "o" && valores[6] == null)
            {
                rodadas++;
                campo7.Image = new Bitmap("img/o.png");
                valores[6] = "o";
                checagem(2);
            }
            else if (valores[0] == "x" && valores[1] == null && valores[2] == "x")
            {
                rodadas++;
                campo2.Image = new Bitmap("img/o.png");
                valores[1] = "o";
            }
            else if (valores[0] == null && valores[1] == "x" && valores[2] == "x")
            {
                rodadas++;
                campo1.Image = new Bitmap("img/o.png");
                valores[0] = "o";
            }

            else if (valores[0] == "x" && valores[1] == "x" && valores[2] == null)
            {
                rodadas++;
                campo3.Image = new Bitmap("img/o.png");
                valores[2] = "o";
            }
            else if (valores[3] == null && valores[4] == "x" && valores[5] == "x")
            {
                rodadas++;
                campo4.Image = new Bitmap("img/o.png");
                valores[3] = "o";
            }
            else if (valores[3] == "x" && valores[4] == null && valores[5] == "x")
            {
                rodadas++;
                campo5.Image = new Bitmap("img/o.png");
                valores[4] = "o";
            }

            else if (valores[3] == "x" && valores[4] == "x" && valores[5] == null)
            {
                rodadas++;
                campo6.Image = new Bitmap("img/o.png");
                valores[5] = "o";
            }
            else if (valores[6] == null && valores[7] == "x" && valores[8] == "x")
            {
                rodadas++;
                campo7.Image = new Bitmap("img/o.png");
                valores[6] = "o";
            }
            else if (valores[6] == "x" && valores[7] == null && valores[8] == "x")
            {
                rodadas++;
                campo8.Image = new Bitmap("img/o.png");
                valores[7] = "o";
            }
            else if (valores[6] == "x" && valores[7] == "x" && valores[8] == null)
            {
                rodadas++;
                campo9.Image = new Bitmap("img/o.png");
                valores[8] = "o";
            }
            else if (valores[0] == "x" && valores[3] == null && valores[6] == "x")
            {
                rodadas++;
                campo4.Image = new Bitmap("img/o.png");
                valores[3] = "o";
            }
            else if (valores[0] == null && valores[3] == "x" && valores[6] == "x")
            {
                rodadas++;
                campo1.Image = new Bitmap("img/o.png");
                valores[0] = "o";
            }
            else if (valores[0] == "x" && valores[3] == "x" && valores[6] == null)
            {
                rodadas++;
                campo7.Image = new Bitmap("img/o.png");
                valores[6] = "o";
            }
            else if (valores[1] == "x" && valores[4] == null && valores[7] == "x")
            {
                rodadas++;
                campo5.Image = new Bitmap("img/o.png");
                valores[4] = "o";
            }
            else if (valores[1] == null && valores[4] == "x" && valores[7] == "x")
            {
                rodadas++;
                campo2.Image = new Bitmap("img/o.png");
                valores[1] = "o";
            }
            else if (valores[1] == "x" && valores[4] == "x" && valores[7] == null)
            {
                rodadas++;
                campo8.Image = new Bitmap("img/o.png");
                valores[7] = "o";
            }
            else if (valores[2] == "x" && valores[5] == null && valores[8] == "x")
            {
                rodadas++;
                campo6.Image = new Bitmap("img/o.png");
                valores[5] = "o";
            }
            else if (valores[2] == null && valores[5] == "x" && valores[8] == "x")
            {
                rodadas++;
                campo3.Image = new Bitmap("img/o.png");
                valores[2] = "o";
            }
            else if (valores[2] == "x" && valores[5] == "x" && valores[8] == null)
            {
                rodadas++;
                campo9.Image = new Bitmap("img/o.png");
                valores[8] = "o";
            }

            else if (valores[0] == "x" && valores[4] == null && valores[8] == "x")
            {
                rodadas++;
                campo5.Image = new Bitmap("img/o.png");
                valores[4] = "o";
            }
            else if (valores[0] == null && valores[4] == "x" && valores[8] == "x")
            {
                rodadas++;
                campo1.Image = new Bitmap("img/o.png");
                valores[0] = "o";
            }
            else if (valores[0] == "x" && valores[4] == "x" && valores[8] == null)
            {
                rodadas++;
                campo9.Image = new Bitmap("img/o.png");
                valores[8] = "o";
            }

            else if (valores[2] == "x" && valores[4] == null && valores[6] == "x")
            {
                rodadas++;
                campo5.Image = new Bitmap("img/o.png");
                valores[4] = "o";
            }
            else if (valores[2] == null && valores[4] == "x" && valores[6] == "x")
            {
                rodadas++;
                campo3.Image = new Bitmap("img/o.png");
                valores[2] = "o";
            }
            else if (valores[2] == "x" && valores[4] == "x" && valores[6] == null)
            {
                rodadas++;
                campo7.Image = new Bitmap("img/o.png");
                valores[6] = "o";
            }
            else
            {
                rodadas++;
                aleatorio();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            reiniciar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormPrincipal fm = new FormPrincipal();
            fm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        public void cpu(int tag)
        {

         
            foreach (var pc in Controls.OfType<PictureBox>())
            {    
                if (pc.Tag.Equals(tag.ToString()) && vez == false && pc.Image == null)
                {
                    pc.Image = new Bitmap("img/o.png");
                    
                }
              
            }
            
        }
        public void checagem(int checagem)
        {
            string aux;
           
            if (checagem == 1)
            {
                aux = "x";
            }
            else
            {
                aux = "o";
            }
            for (int h = 0; h < 9; h += 3)
            {
                if (aux == valores[h])
                {
                    if (valores[h] == valores[h + 1] && valores[h] == valores[h + 2])
                    {
                        switch (checagem)
                        {
                            case 1:
                                empate = false;
                                ganhou = true;
                                MessageBox.Show("Você ganhou");
                                desabilitar();
                                pontosjogador++;
                                label4.Text = pontosjogador.ToString();
                                break;
                                
                            case 2:
                                empate = false;
                                MessageBox.Show("Computador ganhou");
                                desabilitar();
                                pontoscpu++;
                                label6.Text = pontoscpu.ToString();
                                break;
                        }
                    }
                  
                }
            }
            for (int v = 0; v < 3; v ++)
            {
                if (aux == valores[v])
                {
                    if (valores[v] == valores[v + 3] && valores[v] == valores[v + 6])
                    {
                        switch (checagem)
                        {
                            case 1:
                                empate = false;
                                ganhou = true;
                                MessageBox.Show("Você ganhou");
                                desabilitar();
                                pontosjogador++;
                                label4.Text = pontosjogador.ToString();
                                break;
                            case 2:
                                empate = false;
                                MessageBox.Show("Computador ganhou");
                                desabilitar();
                                pontoscpu++;
                                label6.Text = pontoscpu.ToString();
                                break;
                        }
                    
                    
                    }

                }
            }
            if (aux == valores[0])
            {
                if (valores[0] == valores[4] && valores[0] == valores[8])
                {
                      switch (checagem)
                        {
                            case 1:
                            empate = false;
                            ganhou = true;
                            MessageBox.Show("Você ganhou");
                            desabilitar();
                            pontosjogador++;
                            label4.Text = pontosjogador.ToString();
                            break;
                            case 2:
                            empate = false;
                            MessageBox.Show("Computador ganhou");
                            desabilitar();
                            pontoscpu++;
                            label6.Text = pontoscpu.ToString();
                            break;
                        }
                }
            }
            if (aux == valores[2])
            {
                if (valores[2] == valores[4] && valores[2] == valores[6])
                {
                    switch (checagem)
                    {
                        case 1:
                            empate = false;
                            ganhou = true;
                            MessageBox.Show("Você ganhou");
                            desabilitar();
                            pontosjogador++;
                            label4.Text = pontosjogador.ToString();
                            break;
                        case 2:
                            empate = false;
                            MessageBox.Show("Computador ganhou");
                            desabilitar();
                            pontoscpu++;
                            label6.Text = pontoscpu.ToString();
                            break;
                    }
                }
            }
            if (rodadas == 9 && empate == true)
            {
                MessageBox.Show("Empate");
                pontosempate++;
                label5.Text = pontosempate.ToString();
            }

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
            rodadas = 0;
            jogadas = 0;
            empate = true;
            ganhou = false;
            vez = false;
            for(int i = 0;i < 9; i++)
            {
                valores[i] = null;
            }
        }
        public void desabilitar()
        {
            campo1.Enabled = false;
            campo2.Enabled = false;
            campo3.Enabled = false;
            campo4.Enabled = false;
            campo5.Enabled = false;
            campo6.Enabled = false;
            campo9.Enabled = false;
            campo8.Enabled = false;
            campo7.Enabled = false;
        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}