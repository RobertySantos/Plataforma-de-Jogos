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
    public partial class TelaJogo4x4 : Form
    {
        int contador = 0;
        int barc = 0;
        int dest = 1;
        int sub = 3;
        int frag = 2;
        int cruz = 1;

        int pont = 0;
        Random rm = new Random();
        Embarcações emb = new Embarcações();
        int chances = 0;
        public TelaJogo4x4(String nome)
        {
            InitializeComponent();
            label1.Text = nome;
            iniciar();    
        }

        public void iniciar(){
            contador = 0;
            chances = 0;
            barc = 0;
            dest = 1;
            sub = 3;
            frag = 2;
            cruz = 1;
            pictureBox1.ImageLocation = "";
            pictureBox2.ImageLocation = "";
            pictureBox3.ImageLocation = "";
            pictureBox4.ImageLocation = "";
            pictureBox5.ImageLocation = "";
            pictureBox6.ImageLocation = "";
            pictureBox7.ImageLocation = "";
            pictureBox8.ImageLocation = "";
            pictureBox9.ImageLocation = "";
            pictureBox10.ImageLocation = "";
            pictureBox11.ImageLocation = "";
            pictureBox12.ImageLocation = "";
            pictureBox13.ImageLocation = "";
            pictureBox14.ImageLocation = "";
            pictureBox15.ImageLocation = "";
            pictureBox16.ImageLocation = "";
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
            pictureBox10.Enabled = true;
            pictureBox11.Enabled = true;
            pictureBox12.Enabled = true;
            pictureBox13.Enabled = true;
            pictureBox14.Enabled = true;
            pictureBox15.Enabled = true;
            pictureBox16.Enabled = true;
            button1.Enabled = false;
            while (contador != 16)
            {

                sorteio(rm.Next(1, 5));
            }
            chances = chances+Convert.ToInt32(Math.Ceiling(chances * 0.10));
            if (chances > 15)
              chances = 15;

            label3.Text = Convert.ToString(chances);
            label5.Text = Convert.ToString(pont);


        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;

            pic.ImageLocation = emb.End[Convert.ToInt32(pic.Tag)];
            pic.Enabled = false;
            chances--;
            label3.Text = Convert.ToString(chances);
            if (pic.ImageLocation != @"Imagens\bomba.png")
            {
                barc--;
            }
            if (barc == 0)
            {
                MessageBox.Show("Parabens você ganhou");
                button1.Enabled = true;
                pont++;
                label5.Text = Convert.ToString(pont); 
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                pictureBox9.Enabled = false;
                pictureBox10.Enabled = false;
                pictureBox11.Enabled = false;
                pictureBox12.Enabled = false;
                pictureBox13.Enabled = false;
                pictureBox14.Enabled = false;
                pictureBox15.Enabled = false;
                pictureBox16.Enabled = false;

            }
            else
            {
                if (Convert.ToInt32(label3.Text) == 0)
                {
                    MessageBox.Show("Você perdeu");
                    button1.Enabled = true;
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;
                    pictureBox9.Enabled = false;
                    pictureBox10.Enabled = false;
                    pictureBox11.Enabled = false;
                    pictureBox12.Enabled = false;
                    pictureBox13.Enabled = false;
                    pictureBox14.Enabled = false;
                    pictureBox15.Enabled = false;
                    pictureBox16.Enabled = false;
                }
            }
            
            
            


        }

        private void pictureBox1_Click(object sender, MouseEventArgs e)
        {

        }

        public void sorteio(int i)
        {
            //BOMBA COMEÇO
            if (i == 1)
            {
                emb.End[contador] = @"Imagens\bomba.png";
                contador++;
            }
            //BOMBA FIM


            //SUBMARINO COMEÇO
            if (i == 2 && sub>0)
            {
                emb.End[contador] = @"Imagens\Submarino.jpg";
                contador++;
                chances++;
                barc++;
                sub--;

            }//FIM SUBMARINO


            //COMEÇO FRAGATA
            if (i == 3 && frag > 0)
            {
                if (contador == 0)
                {
                    emb.End[contador] = @"Imagens\Fragatapt1.png";
                    emb.End[contador+1] = @"Imagens\Fragatapt2.png";
                    // 1 e 2
                    contador += 2;
                    chances += 2;
                    barc+=2;
                }
                else
                {
                    if (contador == 1)
                    { 
                    emb.End[contador] = @"Imagens\Fragatapt1.png";
                    emb.End[contador+1] = @"Imagens\Fragatapt2.png";
                        //2 e 3
                    contador += 2;
                    chances += 2;
                    barc += 2;
                    }
                    else
                    {
                        if (contador == 2)
                        {
                    emb.End[contador] = @"Imagens\Fragatapt1.png";
                    emb.End[contador+1] = @"Imagens\Fragatapt2.png";
                            //3 e 4
                    contador += 2;
                    chances += 2;
                    barc += 2;
                        }
                            else
                            {
                                if (contador == 4)
                                {
                    emb.End[contador] = @"Imagens\Fragatapt1.png";
                    emb.End[contador+1] = @"Imagens\Fragatapt2.png";
                                    //5 e 6
                    contador += 2;
                    chances += 2;
                    barc += 2;
                                }
                                else
                                {
                                    if (contador == 5)
                                    {
                    emb.End[contador] = @"Imagens\Fragatapt1.png";
                    emb.End[contador+1] = @"Imagens\Fragatapt2.png";
                                        //6 e 7
                    contador += 2;
                    chances += 2;
                    barc += 2;
                                    }
                                    else
                                    {
                                        if (contador == 6)
                                        {
                    emb.End[contador] = @"Imagens\Fragatapt1.png";
                    emb.End[contador+1] = @"Imagens\Fragatapt2.png";
                                            //7 e 8
                    contador += 2;
                    chances += 2;
                    barc += 2;
                                        }
                                      
                                            else
                                            {
                                                if (contador == 8)
                                                {
                    emb.End[contador] = @"Imagens\Fragatapt1.png";
                    emb.End[contador+1] = @"Imagens\Fragatapt2.png";
                                                    //9 e 10
                    contador += 2;
                    chances += 2;
                    barc += 2;
                                                }
                                                else
                                                {
                                                    if (contador == 9)
                                                    {
                    emb.End[contador] = @"Imagens\Fragatapt1.png";
                    emb.End[contador+1] = @"Imagens\Fragatapt2.png";
                                                        //10 e 11
                    contador += 2;
                    chances += 2;
                    barc += 2;
                                                    }
                                                    else
                                                    {
                                                        if (contador == 10)
                                                        {
                    emb.End[contador] = @"Imagens\Fragatapt1.png";
                    emb.End[contador+1] = @"Imagens\Fragatapt2.png";
                                                            //11 e 12
                    contador += 2;
                    chances += 2;
                    barc += 2;
                                                        }
                                                       
                                                            else
                                                            {
                                                                if (contador == 12)
                                                                {
                    emb.End[contador] = @"Imagens\Fragatapt1.png";
                    emb.End[contador+1] = @"Imagens\Fragatapt2.png";
                                                                    //13 e 14
                    contador += 2;
                    chances += 2;
                    barc += 2;
                                                                }
                                                                else
                                                                {
                                                                    if (contador == 13)
                                                                    {
                    emb.End[contador] = @"Imagens\Fragatapt1.png";
                    emb.End[contador+1] = @"Imagens\Fragatapt2.png";
                                                                        //14 e 15
                    contador += 2;
                    chances += 2;
                    barc += 2;
                                                                    }
                                                                    else
                                                                    {
                                                                        if (contador == 14)
                                                                        {
                    emb.End[contador] = @"Imagens\Fragatapt1.png";
                    emb.End[contador+1] = @"Imagens\Fragatapt2.png";
                                                                            //15 e 16
                    contador += 2;
                    chances += 2;
                    barc += 2;
                                                                        }
                                                                    }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                frag--;
            }
            //FIM FRAGATA

            //COMEÇO CRUZADOR
            if (i == 3 && cruz == 1)
            {
                if (contador == 0)
                {
                    emb.End[contador] = @"Imagens\Cruzadorpt1.png";
                    emb.End[contador + 1] = @"Imagens\Cruzadorpt2.png";
                    emb.End[contador + 2] = @"Imagens\Cruzadorpt3.png";
                    //1,2 e 3
                    contador += 3;
                    chances += 3;
                    barc += 3;
                }
                else
                {
                    if (contador == 1)
                    {
                        emb.End[contador] = @"Imagens\Cruzadorpt1.png";
                    emb.End[contador + 1] = @"Imagens\Cruzadorpt2.png";
                    emb.End[contador + 2] = @"Imagens\Cruzadorpt3.png";
                        //2,3 e 4
                    contador += 3;
                    chances += 3;
                    barc += 3;
                    }
                        else
                        {
                           
                                if (contador == 4)
                                {
                    emb.End[contador] = @"Imagens\Cruzadorpt1.png";
                    emb.End[contador + 1] = @"Imagens\Cruzadorpt2.png";
                    emb.End[contador + 2] = @"Imagens\Cruzadorpt3.png";
                                    //5,6 e 7
                    contador += 3;
                    chances += 3;
                    barc += 3;
                                }
                                else
                                {
                                    if (contador == 5)
                                    {
                                        emb.End[contador] = @"Imagens\Cruzadorpt1.png";
                    emb.End[contador + 1] = @"Imagens\Cruzadorpt2.png";
                    emb.End[contador + 2] = @"Imagens\Cruzadorpt3.png";
                                        //6,7 e 8
                    contador += 3;
                    chances += 3;
                    barc += 3;
                                    }
                                        else
                                        {
                                                if (contador == 8)
                                                {
                                                    emb.End[contador] = @"Imagens\Cruzadorpt1.png";
                    emb.End[contador + 1] = @"Imagens\Cruzadorpt2.png";
                    emb.End[contador + 2] = @"Imagens\Cruzadorpt3.png";
                                                    //9,10 e 11
                    contador += 3;
                    chances += 3;
                    barc += 3;
                                                }
                                                else
                                                {
                                                    if (contador == 9)
                                                    {
                                                        emb.End[contador] = @"Imagens\Cruzadorpt1.png";
                    emb.End[contador + 1] = @"Imagens\Cruzadorpt2.png";
                    emb.End[contador + 2] = @"Imagens\Cruzadorpt3.png";
                                                        //10,11 e 12
                    contador += 3;
                    chances += 3;
                    barc += 3;
                                                    } 
                                                            else
                                                            {
                                                                if (contador == 12)
                                                                {
                                                                    emb.End[contador] = @"Imagens\Cruzadorpt1.png";
                    emb.End[contador + 1] = @"Imagens\Cruzadorpt2.png";
                    emb.End[contador + 2] = @"Imagens\Cruzadorpt3.png";
                                                                    //13,14 e 15
                    contador += 3;
                    chances += 3;
                    barc += 3;
                                                                }
                                                                else
                                                                {
                                                                    if (contador == 13)
                                                                    {
                                                                        emb.End[contador] = @"Imagens\Cruzadorpt1.png";
                    emb.End[contador + 1] = @"Imagens\Cruzadorpt2.png";
                    emb.End[contador + 2] = @"Imagens\Cruzadorpt3.png";
                                                                        //14,15 e 16
                    contador += 3;
                    chances += 3;
                    barc += 3;
                                                                    }          
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                cruz++;
                }//FIM CRUZADOR

            //COMEÇO Destroyer
            if (i == 4 && dest == 1)
            {
                if (contador == 0)
                {
                    emb.End[contador] = @"Imagens\Destroyerpt1.png";
                    emb.End[contador + 1] = @"Imagens\Destroyerpt2.png";
                    emb.End[contador + 2] = @"Imagens\Destroyerpt3.png";
                    emb.End[contador + 3] = @"Imagens\Destroyerpt4.png";
                    //1,2,3 e 4
                    contador += 4;
                    chances += 4;
                    barc += 4;
                }
                else
                {
                    if (contador == 4)
                    {
                        emb.End[contador] = @"Imagens\Destroyerpt1.png";
                        emb.End[contador + 1] = @"Imagens\Destroyerpt2.png";
                        emb.End[contador + 2] = @"Imagens\Destroyerpt3.png";
                        emb.End[contador + 3] = @"Imagens\Destroyerpt4.png";
                        //5,6,7 e 8
                        contador += 4;
                        chances += 4;
                        barc += 4;
                    }
                    else

                        if (contador == 8)
                        {
                            emb.End[contador] = @"Imagens\Destroyerpt1.png";
                            emb.End[contador + 1] = @"Imagens\Destroyerpt2.png";
                            emb.End[contador + 2] = @"Imagens\Destroyerpt3.png";
                            emb.End[contador + 3] = @"Imagens\Destroyerpt4.png";
                            //9,10,11 e 12
                            contador += 4;
                            chances += 4;
                            barc += 4;
                        }
                        else
                        {
                            if (contador == 12)
                            {
                                emb.End[contador] = @"Imagens\Destroyerpt1.png";
                                emb.End[contador + 1] = @"Imagens\Destroyerpt2.png";
                                emb.End[contador + 2] = @"Imagens\Destroyerpt3.png";
                                emb.End[contador + 3] = @"Imagens\Destroyerpt4.png";
                                //13,14,15 e 16
                                contador += 4;
                                chances += 4;
                                barc += 4;
                            }

                        }


                }
                dest--;
            }//FIM Destroyer
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            iniciar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            TelaInicial tl = new TelaInicial();
            tl.Show();
        }
    }
}
