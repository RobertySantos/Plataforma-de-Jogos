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
    public partial class TelaJogo6x6 : Form
    {
        int contador = 0;
        int barc = 0;
        int dest = 5;
        int sub = 15;
        int frag = 8;
        int cruz = 3;
        int port = 2;

        int pont = 0;
        Random rm = new Random();
        EmbarcaçõesHard emb = new EmbarcaçõesHard();
        int chances = 0;
        public TelaJogo6x6(String nome)
        {
            InitializeComponent();
            label1.Text = nome;
            iniciar();  
        }

        public void iniciar()
        {
            contador = 0;
            chances = 0;
            barc = 0;
            dest = 1;
            sub = 3;
            frag = 2;
            cruz = 1;
            port = 1;
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
            pictureBox17.ImageLocation = "";
            pictureBox18.ImageLocation = "";
            pictureBox19.ImageLocation = "";
            pictureBox20.ImageLocation = "";
            pictureBox21.ImageLocation = "";
            pictureBox22.ImageLocation = "";
            pictureBox23.ImageLocation = "";
            pictureBox24.ImageLocation = "";
            pictureBox25.ImageLocation = "";
            pictureBox26.ImageLocation = "";
            pictureBox27.ImageLocation = "";
            pictureBox28.ImageLocation = "";
            pictureBox29.ImageLocation = ""; 
            pictureBox30.ImageLocation = "";
            pictureBox31.ImageLocation = "";
            pictureBox32.ImageLocation = "";
            pictureBox33.ImageLocation = "";
            pictureBox34.ImageLocation = "";
            pictureBox35.ImageLocation = "";
            pictureBox36.ImageLocation = "";


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
            pictureBox17.Enabled = true;
            pictureBox18.Enabled = true;
            pictureBox19.Enabled = true;
            pictureBox20.Enabled = true;
            pictureBox21.Enabled = true;
            pictureBox22.Enabled = true;
            pictureBox23.Enabled = true;
            pictureBox24.Enabled = true;
            pictureBox25.Enabled = true;
            pictureBox26.Enabled = true;
            pictureBox27.Enabled = true;
            pictureBox28.Enabled = true;
            pictureBox29.Enabled = true;
            pictureBox30.Enabled = true;
            pictureBox31.Enabled = true;
            pictureBox32.Enabled = true;
            pictureBox33.Enabled = true;
            pictureBox34.Enabled = true;
            pictureBox35.Enabled = true;
            pictureBox36.Enabled = true;

            button1.Enabled = false;
            while (contador != 36)
            {

               sorteio(rm.Next(1, 7));
            }
            chances = chances + Convert.ToInt32(Math.Ceiling(chances * 0.10));
            if (chances > 35)
                chances = 35;

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
                pictureBox17.Enabled = false;
                pictureBox18.Enabled = false;
                pictureBox19.Enabled = false;
                pictureBox20.Enabled = false;
                pictureBox21.Enabled = false;
                pictureBox22.Enabled = false;
                pictureBox23.Enabled = false;
                pictureBox24.Enabled = false;
                pictureBox25.Enabled = false;
                pictureBox26.Enabled = false;
                pictureBox27.Enabled = false;
                pictureBox28.Enabled = false;
                pictureBox29.Enabled = false;
                pictureBox30.Enabled = false;
                pictureBox31.Enabled = false;
                pictureBox32.Enabled = false;
                pictureBox33.Enabled = false;
                pictureBox34.Enabled = false;
                pictureBox35.Enabled = false;
                pictureBox36.Enabled = false;

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
                    pictureBox17.Enabled = false;
                    pictureBox18.Enabled = false;
                    pictureBox19.Enabled = false; 
                    pictureBox20.Enabled = false;
                    pictureBox21.Enabled = false;
                    pictureBox22.Enabled = false;
                    pictureBox23.Enabled = false;
                    pictureBox24.Enabled = false;
                    pictureBox25.Enabled = false;
                    pictureBox26.Enabled = false;
                    pictureBox27.Enabled = false;
                    pictureBox28.Enabled = false;
                    pictureBox29.Enabled = false; 
                    pictureBox30.Enabled = false;
                    pictureBox31.Enabled = false;
                    pictureBox32.Enabled = false;
                    pictureBox33.Enabled = false;
                    pictureBox34.Enabled = false;
                    pictureBox35.Enabled = false;
                    pictureBox36.Enabled = false;

                }
            }
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
                    emb.End[contador + 1] = @"Imagens\Fragatapt2.png";
                    // 1 e 2
                    contador += 2;
                    chances += 2;
                    barc += 2;
                    frag--;
                }
                else
                {
                    if (contador == 1)
                    {
                        emb.End[contador] = @"Imagens\Fragatapt1.png";
                        emb.End[contador + 1] = @"Imagens\Fragatapt2.png";
                        //2 e 3
                        contador += 2;
                        chances += 2;
                        barc += 2;
                        frag--;
                    }
                    else
                    {
                        if (contador == 2)
                        {
                            emb.End[contador] = @"Imagens\Fragatapt1.png";
                            emb.End[contador + 1] = @"Imagens\Fragatapt2.png";
                            //3 e 4
                            contador += 2;
                            chances += 2;
                            barc += 2;
                            frag--;
                        }

                        else
                        {
                            if (contador == 3)
                            {
                                emb.End[contador] = @"Imagens\Fragatapt1.png";
                                emb.End[contador + 1] = @"Imagens\Fragatapt2.png";
                                //4 e 5
                                contador += 2;
                                chances += 2;
                                barc += 2;
                                frag--;
                            }
                            else
                            {
                                if (contador == 4)
                                {
                                    emb.End[contador] = @"Imagens\Fragatapt1.png";
                                    emb.End[contador + 1] = @"Imagens\Fragatapt2.png";
                                    //5 e 6
                                    contador += 2;
                                    chances += 2;
                                    barc += 2;
                                    frag--;
                                }
                                else
                                {
                                    if (contador == 6)
                                    {
                                        emb.End[contador] = @"Imagens\Fragatapt1.png";
                                        emb.End[contador + 1] = @"Imagens\Fragatapt2.png";
                                        //7 e 8
                                        contador += 2;
                                        chances += 2;
                                        barc += 2;
                                        frag--;
                                    }
                                    else
                                    {
                                        if (contador == 7)
                                        {
                                            emb.End[contador] = @"Imagens\Fragatapt1.png";
                                            emb.End[contador + 1] = @"Imagens\Fragatapt2.png";
                                            //8 e 9
                                            contador += 2;
                                            chances += 2;
                                            barc += 2;
                                            frag--;
                                        }

                                        else
                                        {
                                            if (contador == 8)
                                            {
                                                emb.End[contador] = @"Imagens\Fragatapt1.png";
                                                emb.End[contador + 1] = @"Imagens\Fragatapt2.png";
                                                //9 e 10
                                                contador += 2;
                                                chances += 2;
                                                barc += 2;
                                                frag--;
                                            }
                                            else
                                            {
                                                if (contador == 9)
                                                {
                                                    emb.End[contador] = @"Imagens\Fragatapt1.png";
                                                    emb.End[contador + 1] = @"Imagens\Fragatapt2.png";
                                                    //10 e 11
                                                    contador += 2;
                                                    chances += 2;
                                                    barc += 2;
                                                    frag--;
                                                }
                                                else
                                                {
                                                    if (contador == 10)
                                                    {
                                                        emb.End[contador] = @"Imagens\Fragatapt1.png";
                                                        emb.End[contador + 1] = @"Imagens\Fragatapt2.png";
                                                        //11 e 12
                                                        contador += 2;
                                                        chances += 2;
                                                        barc += 2;
                                                        frag--;
                                                    }

                                                    else
                                                    {
                                                        if (contador == 12)
                                                        {
                                                            emb.End[contador] = @"Imagens\Fragatapt1.png";
                                                            emb.End[contador + 1] = @"Imagens\Fragatapt2.png";
                                                            //13 e 14
                                                            contador += 2;
                                                            chances += 2;
                                                            barc += 2;
                                                            frag--;
                                                        }
                                                        else
                                                        {
                                                            if (contador == 13)
                                                            {
                                                                emb.End[contador] = @"Imagens\Fragatapt1.png";
                                                                emb.End[contador + 1] = @"Imagens\Fragatapt2.png";
                                                                //14 e 15
                                                                contador += 2;
                                                                chances += 2;
                                                                barc += 2;
                                                                frag--;
                                                            }
                                                            else
                                                            {
                                                                if (contador == 14)
                                                                {
                                                                    emb.End[contador] = @"Imagens\Fragatapt1.png";
                                                                    emb.End[contador + 1] = @"Imagens\Fragatapt2.png";
                                                                    //15 e 16
                                                                    contador += 2;
                                                                    chances += 2;
                                                                    barc += 2;
                                                                    frag--;
                                                                }
                                                                else
                                                                {
                                                                    if (contador == 15)
                                                                    {
                                                                        emb.End[contador] = @"Imagens\Fragatapt1.png";
                                                                        emb.End[contador + 1] = @"Imagens\Fragatapt2.png";
                                                                        //16 e 17
                                                                        contador += 2;
                                                                        chances += 2;
                                                                        barc += 2;
                                                                        frag--;
                                                                    }
                                                                    else
                                                                    {
                                                                        if (contador == 16)
                                                                        {
                                                                            emb.End[contador] = @"Imagens\Fragatapt1.png";
                                                                            emb.End[contador + 1] = @"Imagens\Fragatapt2.png";
                                                                            //17 e 18
                                                                            contador += 2;
                                                                            chances += 2;
                                                                            barc += 2;
                                                                            frag--;
                                                                        }
                                                                        else
                                                                        {
                                                                            if (contador == 18)
                                                                            {
                                                                                emb.End[contador] = @"Imagens\Fragatapt1.png";
                                                                                emb.End[contador + 1] = @"Imagens\Fragatapt2.png";
                                                                                //19 e 20
                                                                                contador += 2;
                                                                                chances += 2;
                                                                                barc += 2;
                                                                                frag--;
                                                                            }
                                                                            else
                                                                            {
                                                                                if (contador == 19)
                                                                                {
                                                                                    emb.End[contador] = @"Imagens\Fragatapt1.png";
                                                                                    emb.End[contador + 1] = @"Imagens\Fragatapt2.png";
                                                                                    //20 e 21
                                                                                    contador += 2;
                                                                                    chances += 2;
                                                                                    barc += 2;
                                                                                    frag--;
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (contador == 20)
                                                                                    {
                                                                                        emb.End[contador] = @"Imagens\Fragatapt1.png";
                                                                                        emb.End[contador + 1] = @"Imagens\Fragatapt2.png";
                                                                                        //21 e 22
                                                                                        contador += 2;
                                                                                        chances += 2;
                                                                                        barc += 2;
                                                                                        frag--;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        if (contador == 21)
                                                                                        {
                                                                                            emb.End[contador] = @"Imagens\Fragatapt1.png";
                                                                                            emb.End[contador + 1] = @"Imagens\Fragatapt2.png";
                                                                                            //22 e 23
                                                                                            contador += 2;
                                                                                            chances += 2;
                                                                                            barc += 2;
                                                                                            frag--;
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            if (contador == 22)
                                                                                            {
                                                                                                emb.End[contador] = @"Imagens\Fragatapt1.png";
                                                                                                emb.End[contador + 1] = @"Imagens\Fragatapt2.png";
                                                                                                //23 e 24
                                                                                                contador += 2;
                                                                                                chances += 2;
                                                                                                barc += 2;
                                                                                                frag--;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                if (contador == 24)
                                                                                                {
                                                                                                    emb.End[contador] = @"Imagens\Fragatapt1.png";
                                                                                                    emb.End[contador + 1] = @"Imagens\Fragatapt2.png";
                                                                                                    //25 e 26
                                                                                                    contador += 2;
                                                                                                    chances += 2;
                                                                                                    barc += 2;
                                                                                                    frag--;
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    if (contador == 25)
                                                                                                    {
                                                                                                        emb.End[contador] = @"Imagens\Fragatapt1.png";
                                                                                                        emb.End[contador + 1] = @"Imagens\Fragatapt2.png";
                                                                                                        //26 e 27
                                                                                                        contador += 2;
                                                                                                        chances += 2;
                                                                                                        barc += 2;
                                                                                                        frag--;
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        if (contador == 26)
                                                                                                        {
                                                                                                            emb.End[contador] = @"Imagens\Fragatapt1.png";
                                                                                                            emb.End[contador + 1] = @"Imagens\Fragatapt2.png";
                                                                                                            //27 e 28
                                                                                                            contador += 2;
                                                                                                            chances += 2;
                                                                                                            barc += 2;
                                                                                                            frag--;
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            if (contador == 27)
                                                                                                            {
                                                                                                                emb.End[contador] = @"Imagens\Fragatapt1.png";
                                                                                                                emb.End[contador + 1] = @"Imagens\Fragatapt2.png";
                                                                                                                //28 e 29
                                                                                                                contador += 2;
                                                                                                                chances += 2;
                                                                                                                barc += 2;
                                                                                                                frag--;
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                if (contador == 28)
                                                                                                                {
                                                                                                                    emb.End[contador] = @"Imagens\Fragatapt1.png";
                                                                                                                    emb.End[contador + 1] = @"Imagens\Fragatapt2.png";
                                                                                                                    //29 e 30
                                                                                                                    contador += 2;
                                                                                                                    chances += 2;
                                                                                                                    barc += 2;
                                                                                                                    frag--;
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    if (contador == 30)
                                                                                                                    {
                                                                                                                        emb.End[contador] = @"Imagens\Fragatapt1.png";
                                                                                                                        emb.End[contador + 1] = @"Imagens\Fragatapt2.png";
                                                                                                                        //31 e 32
                                                                                                                        contador += 2;
                                                                                                                        chances += 2;
                                                                                                                        barc += 2;
                                                                                                                        frag--;
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        if (contador == 31)
                                                                                                                        {
                                                                                                                            emb.End[contador] = @"Imagens\Fragatapt1.png";
                                                                                                                            emb.End[contador + 1] = @"Imagens\Fragatapt2.png";
                                                                                                                            //32 e 33
                                                                                                                            contador += 2;
                                                                                                                            chances += 2;
                                                                                                                            barc += 2;
                                                                                                                            frag--;
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            if (contador == 32)
                                                                                                                            {
                                                                                                                                emb.End[contador] = @"Imagens\Fragatapt1.png";
                                                                                                                                emb.End[contador + 1] = @"Imagens\Fragatapt2.png";
                                                                                                                                //33 e 34
                                                                                                                                contador += 2;
                                                                                                                                chances += 2;
                                                                                                                                barc += 2;
                                                                                                                                frag--;
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                if (contador == 33)
                                                                                                                                {
                                                                                                                                    emb.End[contador] = @"Imagens\Fragatapt1.png";
                                                                                                                                    emb.End[contador + 1] = @"Imagens\Fragatapt2.png";
                                                                                                                                    //34 e 35
                                                                                                                                    contador += 2;
                                                                                                                                    chances += 2;
                                                                                                                                    barc += 2;
                                                                                                                                    frag--;
                                                                                                                                }
                                                                                                                                else
                                                                                                                                {
                                                                                                                                    if (contador == 34)
                                                                                                                                    {
                                                                                                                                        emb.End[contador] = @"Imagens\Fragatapt1.png";
                                                                                                                                        emb.End[contador + 1] = @"Imagens\Fragatapt2.png";
                                                                                                                                        //35 e 36
                                                                                                                                        contador += 2;
                                                                                                                                        chances += 2;
                                                                                                                                        barc += 2;
                                                                                                                                        frag--;
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
            if (i == 3 && cruz > 0)
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
                    cruz--;
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
                        cruz--;
                    }
                    else
                    {
                        if (contador == 2)
                        {
                            emb.End[contador] = @"Imagens\Cruzadorpt1.png";
                            emb.End[contador + 1] = @"Imagens\Cruzadorpt2.png";
                            emb.End[contador + 2] = @"Imagens\Cruzadorpt3.png";
                            //3,4 e 5
                            contador += 3;
                            chances += 3;
                            barc += 3;
                            cruz--;
                        }
                        else
                        {
                            if (contador == 3)
                            {
                                emb.End[contador] = @"Imagens\Cruzadorpt1.png";
                                emb.End[contador + 1] = @"Imagens\Cruzadorpt2.png";
                                emb.End[contador + 2] = @"Imagens\Cruzadorpt3.png";
                                //4,5 e 6
                                contador += 3;
                                chances += 3;
                                barc += 3;
                                cruz--;
                            }
                            else
                            {
                                if (contador == 6)
                                {
                                    emb.End[contador] = @"Imagens\Cruzadorpt1.png";
                                    emb.End[contador + 1] = @"Imagens\Cruzadorpt2.png";
                                    emb.End[contador + 2] = @"Imagens\Cruzadorpt3.png";
                                    //7,8 e 9
                                    contador += 3;
                                    chances += 3;
                                    barc += 3;
                                    cruz--;
                                }
                                else
                                {
                                    if (contador == 7)
                                    {
                                        emb.End[contador] = @"Imagens\Cruzadorpt1.png";
                                        emb.End[contador + 1] = @"Imagens\Cruzadorpt2.png";
                                        emb.End[contador + 2] = @"Imagens\Cruzadorpt3.png";
                                        //8,9 e 10
                                        contador += 3;
                                        chances += 3;
                                        barc += 3;
                                        cruz--;
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
                                            cruz--;
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
                                                cruz--;
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
                                                    cruz--;
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
                                                        cruz--;
                                                    }
                                                    else
                                                    {
                                                        if (contador == 14)
                                                        {
                                                            emb.End[contador] = @"Imagens\Cruzadorpt1.png";
                                                            emb.End[contador + 1] = @"Imagens\Cruzadorpt2.png";
                                                            emb.End[contador + 2] = @"Imagens\Cruzadorpt3.png";
                                                            //15,16 e 17
                                                            contador += 3;
                                                            chances += 3;
                                                            barc += 3;
                                                            cruz--;
                                                        }
                                                        else
                                                        {
                                                            if (contador == 15)
                                                            {
                                                                emb.End[contador] = @"Imagens\Cruzadorpt1.png";
                                                                emb.End[contador + 1] = @"Imagens\Cruzadorpt2.png";
                                                                emb.End[contador + 2] = @"Imagens\Cruzadorpt3.png";
                                                                //16,17 e 18
                                                                contador += 3;
                                                                chances += 3;
                                                                barc += 3;
                                                                cruz--;
                                                            }
                                                            else
                                                            {
                                                                if (contador == 18)
                                                                {
                                                                    emb.End[contador] = @"Imagens\Cruzadorpt1.png";
                                                                    emb.End[contador + 1] = @"Imagens\Cruzadorpt2.png";
                                                                    emb.End[contador + 2] = @"Imagens\Cruzadorpt3.png";
                                                                    //19,20 e 21
                                                                    contador += 3;
                                                                    chances += 3;
                                                                    barc += 3;
                                                                    cruz--;
                                                                }
                                                                else
                                                                {
                                                                    if (contador == 19)
                                                                    {
                                                                        emb.End[contador] = @"Imagens\Cruzadorpt1.png";
                                                                        emb.End[contador + 1] = @"Imagens\Cruzadorpt2.png";
                                                                        emb.End[contador + 2] = @"Imagens\Cruzadorpt3.png";
                                                                        //20,21 e 22
                                                                        contador += 3;
                                                                        chances += 3;
                                                                        barc += 3;
                                                                        cruz--;
                                                                    }
                                                                    else
                                                                    {
                                                                        if (contador == 20)
                                                                        {
                                                                            emb.End[contador] = @"Imagens\Cruzadorpt1.png";
                                                                            emb.End[contador + 1] = @"Imagens\Cruzadorpt2.png";
                                                                            emb.End[contador + 2] = @"Imagens\Cruzadorpt3.png";
                                                                            //21,22 e 23
                                                                            contador += 3;
                                                                            chances += 3;
                                                                            barc += 3;
                                                                            cruz--;
                                                                        }
                                                                        else
                                                                        {
                                                                            if (contador == 21)
                                                                            {
                                                                                emb.End[contador] = @"Imagens\Cruzadorpt1.png";
                                                                                emb.End[contador + 1] = @"Imagens\Cruzadorpt2.png";
                                                                                emb.End[contador + 2] = @"Imagens\Cruzadorpt3.png";
                                                                                //22,23 e 24
                                                                                contador += 3;
                                                                                chances += 3;
                                                                                barc += 3;
                                                                                cruz--;
                                                                            }
                                                                            else
                                                                            {
                                                                                if (contador == 24)
                                                                                {
                                                                                    emb.End[contador] = @"Imagens\Cruzadorpt1.png";
                                                                                    emb.End[contador + 1] = @"Imagens\Cruzadorpt2.png";
                                                                                    emb.End[contador + 2] = @"Imagens\Cruzadorpt3.png";
                                                                                    //25,26 e 27
                                                                                    contador += 3;
                                                                                    chances += 3;
                                                                                    barc += 3;
                                                                                    cruz--;
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (contador == 25)
                                                                                    {
                                                                                        emb.End[contador] = @"Imagens\Cruzadorpt1.png";
                                                                                        emb.End[contador + 1] = @"Imagens\Cruzadorpt2.png";
                                                                                        emb.End[contador + 2] = @"Imagens\Cruzadorpt3.png";
                                                                                        //26,27 e 28
                                                                                        contador += 3;
                                                                                        chances += 3;
                                                                                        barc += 3;
                                                                                        cruz--;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        if (contador == 26)
                                                                                        {
                                                                                            emb.End[contador] = @"Imagens\Cruzadorpt1.png";
                                                                                            emb.End[contador + 1] = @"Imagens\Cruzadorpt2.png";
                                                                                            emb.End[contador + 2] = @"Imagens\Cruzadorpt3.png";
                                                                                            //27,28 e 29
                                                                                            contador += 3;
                                                                                            chances += 3;
                                                                                            barc += 3;
                                                                                            cruz--;
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            if (contador == 27)
                                                                                            {
                                                                                                emb.End[contador] = @"Imagens\Cruzadorpt1.png";
                                                                                                emb.End[contador + 1] = @"Imagens\Cruzadorpt2.png";
                                                                                                emb.End[contador + 2] = @"Imagens\Cruzadorpt3.png";
                                                                                                //28,29 e 30
                                                                                                contador += 3;
                                                                                                chances += 3;
                                                                                                barc += 3;
                                                                                                cruz--;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                if (contador == 30)
                                                                                                {
                                                                                                    emb.End[contador] = @"Imagens\Cruzadorpt1.png";
                                                                                                    emb.End[contador + 1] = @"Imagens\Cruzadorpt2.png";
                                                                                                    emb.End[contador + 2] = @"Imagens\Cruzadorpt3.png";
                                                                                                    //31,32 e 33
                                                                                                    contador += 3;
                                                                                                    chances += 3;
                                                                                                    barc += 3;
                                                                                                    cruz--;
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    if (contador == 31)
                                                                                                    {
                                                                                                        emb.End[contador] = @"Imagens\Cruzadorpt1.png";
                                                                                                        emb.End[contador + 1] = @"Imagens\Cruzadorpt2.png";
                                                                                                        emb.End[contador + 2] = @"Imagens\Cruzadorpt3.png";
                                                                                                        //32,33 e 34
                                                                                                        contador += 3;
                                                                                                        chances += 3;
                                                                                                        barc += 3;
                                                                                                        cruz--;
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        if (contador == 32)
                                                                                                        {
                                                                                                            emb.End[contador] = @"Imagens\Cruzadorpt1.png";
                                                                                                            emb.End[contador + 1] = @"Imagens\Cruzadorpt2.png";
                                                                                                            emb.End[contador + 2] = @"Imagens\Cruzadorpt3.png";
                                                                                                            //33,34 e 35
                                                                                                            contador += 3;
                                                                                                            chances += 3;
                                                                                                            barc += 3;
                                                                                                            cruz--;
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            if (contador == 33)
                                                                                                            {
                                                                                                                emb.End[contador] = @"Imagens\Cruzadorpt1.png";
                                                                                                                emb.End[contador + 1] = @"Imagens\Cruzadorpt2.png";
                                                                                                                emb.End[contador + 2] = @"Imagens\Cruzadorpt3.png";
                                                                                                                //34,35 e 36
                                                                                                                contador += 3;
                                                                                                                chances += 3;
                                                                                                                barc += 3;
                                                                                                                cruz--;
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
                cruz++;
                }//FIM CRUZADOR

            //COMEÇO Destroyer
            if (i == 4 && dest > 0)
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
                    dest--;
                }
                else
                {
                    if (contador == 1)
                    {
                        emb.End[contador] = @"Imagens\Destroyerpt1.png";
                        emb.End[contador + 1] = @"Imagens\Destroyerpt2.png";
                        emb.End[contador + 2] = @"Imagens\Destroyerpt3.png";
                        emb.End[contador + 3] = @"Imagens\Destroyerpt4.png";
                        //2,3,4 e 5
                        contador += 4;
                        chances += 4;
                        barc += 4;
                        dest--;
                    }
                    else

                        if (contador == 2)
                        {
                            emb.End[contador] = @"Imagens\Destroyerpt1.png";
                            emb.End[contador + 1] = @"Imagens\Destroyerpt2.png";
                            emb.End[contador + 2] = @"Imagens\Destroyerpt3.png";
                            emb.End[contador + 3] = @"Imagens\Destroyerpt4.png";
                            //3,4,5 e 6
                            contador += 4;
                            chances += 4;
                            barc += 4;
                            dest--;
                        }
                        else
                        {
                            if (contador == 6)
                            {
                                emb.End[contador] = @"Imagens\Destroyerpt1.png";
                                emb.End[contador + 1] = @"Imagens\Destroyerpt2.png";
                                emb.End[contador + 2] = @"Imagens\Destroyerpt3.png";
                                emb.End[contador + 3] = @"Imagens\Destroyerpt4.png";
                                //7,8,9 e 10
                                contador += 4;
                                chances += 4;
                                barc += 4;
                                dest--;
                            }
                            else
                            {
                                if (contador == 7)
                                {
                                    emb.End[contador] = @"Imagens\Destroyerpt1.png";
                                    emb.End[contador + 1] = @"Imagens\Destroyerpt2.png";
                                    emb.End[contador + 2] = @"Imagens\Destroyerpt3.png";
                                    emb.End[contador + 3] = @"Imagens\Destroyerpt4.png";
                                    //8,9,10 e 11
                                    contador += 4;
                                    chances += 4;
                                    barc += 4;
                                    dest--;
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
                                        dest--;
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
                                            dest--;
                                        }
                                        else
                                        {
                                            if (contador == 13)
                                            {
                                                emb.End[contador] = @"Imagens\Destroyerpt1.png";
                                                emb.End[contador + 1] = @"Imagens\Destroyerpt2.png";
                                                emb.End[contador + 2] = @"Imagens\Destroyerpt3.png";
                                                emb.End[contador + 3] = @"Imagens\Destroyerpt4.png";
                                                //14,15,16 e 17
                                                contador += 4;
                                                chances += 4;
                                                barc += 4;
                                                dest--;
                                            }
                                            else

                                                if (contador == 14)
                                                {
                                                    emb.End[contador] = @"Imagens\Destroyerpt1.png";
                                                    emb.End[contador + 1] = @"Imagens\Destroyerpt2.png";
                                                    emb.End[contador + 2] = @"Imagens\Destroyerpt3.png";
                                                    emb.End[contador + 3] = @"Imagens\Destroyerpt4.png";
                                                    //15,16,17 e 18
                                                    contador += 4;
                                                    chances += 4;
                                                    barc += 4;
                                                    dest--;
                                                }
                                                else
                                                {
                                                    if (contador == 18)
                                                    {
                                                        emb.End[contador] = @"Imagens\Destroyerpt1.png";
                                                        emb.End[contador + 1] = @"Imagens\Destroyerpt2.png";
                                                        emb.End[contador + 2] = @"Imagens\Destroyerpt3.png";
                                                        emb.End[contador + 3] = @"Imagens\Destroyerpt4.png";
                                                        //19,20,21 e 22
                                                        contador += 4;
                                                        chances += 4;
                                                        barc += 4;
                                                        dest--;
                                                    }
                                                    else
                                                    {
                                                        if (contador == 19)
                                                        {
                                                            emb.End[contador] = @"Imagens\Destroyerpt1.png";
                                                            emb.End[contador + 1] = @"Imagens\Destroyerpt2.png";
                                                            emb.End[contador + 2] = @"Imagens\Destroyerpt3.png";
                                                            emb.End[contador + 3] = @"Imagens\Destroyerpt4.png";
                                                            //20,21,22 e 23
                                                            contador += 4;
                                                            chances += 4;
                                                            barc += 4;
                                                            dest--;
                                                        }
                                                        else

                                                            if (contador == 20)
                                                            {
                                                                emb.End[contador] = @"Imagens\Destroyerpt1.png";
                                                                emb.End[contador + 1] = @"Imagens\Destroyerpt2.png";
                                                                emb.End[contador + 2] = @"Imagens\Destroyerpt3.png";
                                                                emb.End[contador + 3] = @"Imagens\Destroyerpt4.png";
                                                                //21,22,23 e 24
                                                                contador += 4;
                                                                chances += 4;
                                                                barc += 4;
                                                                dest--;
                                                            }
                                                            else
                                                            {
                                                                if (contador == 24)
                                                                {
                                                                    emb.End[contador] = @"Imagens\Destroyerpt1.png";
                                                                    emb.End[contador + 1] = @"Imagens\Destroyerpt2.png";
                                                                    emb.End[contador + 2] = @"Imagens\Destroyerpt3.png";
                                                                    emb.End[contador + 3] = @"Imagens\Destroyerpt4.png";
                                                                    //25,26,27 e 28
                                                                    contador += 4;
                                                                    chances += 4;
                                                                    barc += 4;
                                                                    dest--;
                                                                }
                                                                else
                                                                {
                                                                    if (contador == 25)
                                                                    {
                                                                        emb.End[contador] = @"Imagens\Destroyerpt1.png";
                                                                        emb.End[contador + 1] = @"Imagens\Destroyerpt2.png";
                                                                        emb.End[contador + 2] = @"Imagens\Destroyerpt3.png";
                                                                        emb.End[contador + 3] = @"Imagens\Destroyerpt4.png";
                                                                        //26,27,28 e 29
                                                                        contador += 4;
                                                                        chances += 4;
                                                                        barc += 4;
                                                                        dest--;
                                                                    }
                                                                    else

                                                                        if (contador == 26)
                                                                        {
                                                                            emb.End[contador] = @"Imagens\Destroyerpt1.png";
                                                                            emb.End[contador + 1] = @"Imagens\Destroyerpt2.png";
                                                                            emb.End[contador + 2] = @"Imagens\Destroyerpt3.png";
                                                                            emb.End[contador + 3] = @"Imagens\Destroyerpt4.png";
                                                                            //27,28,29 e 30
                                                                            contador += 4;
                                                                            chances += 4;
                                                                            barc += 4;
                                                                            dest--;
                                                                        }
                                                                        else
                                                                        {
                                                                            if (contador == 30)
                                                                            {
                                                                                emb.End[contador] = @"Imagens\Destroyerpt1.png";
                                                                                emb.End[contador + 1] = @"Imagens\Destroyerpt2.png";
                                                                                emb.End[contador + 2] = @"Imagens\Destroyerpt3.png";
                                                                                emb.End[contador + 3] = @"Imagens\Destroyerpt4.png";
                                                                                //31,32,33 e 34
                                                                                contador += 4;
                                                                                chances += 4;
                                                                                barc += 4;
                                                                                dest--;
                                                                            }
                                                                            else
                                                                            {
                                                                                if (contador == 31)
                                                                                {
                                                                                    emb.End[contador] = @"Imagens\Destroyerpt1.png";
                                                                                    emb.End[contador + 1] = @"Imagens\Destroyerpt2.png";
                                                                                    emb.End[contador + 2] = @"Imagens\Destroyerpt3.png";
                                                                                    emb.End[contador + 3] = @"Imagens\Destroyerpt4.png";
                                                                                    //32,33,34 e 35
                                                                                    contador += 4;
                                                                                    chances += 4;
                                                                                    barc += 4;
                                                                                    dest--;
                                                                                }
                                                                                else

                                                                                    if (contador == 32)
                                                                                    {
                                                                                        emb.End[contador] = @"Imagens\Destroyerpt1.png";
                                                                                        emb.End[contador + 1] = @"Imagens\Destroyerpt2.png";
                                                                                        emb.End[contador + 2] = @"Imagens\Destroyerpt3.png";
                                                                                        emb.End[contador + 3] = @"Imagens\Destroyerpt4.png";
                                                                                        //33,34,35 e 36
                                                                                        contador += 4;
                                                                                        chances += 4;
                                                                                        barc += 4;
                                                                                        dest--;
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
                dest--;
            }//FIM Destroyer

            //COMEÇO PORTA-AVIOES
            if(i==5 && port>0){

                if (contador == 0)
                {
                    emb.End[contador] = @"Imagens\PortaAvioespt1.png";
                    emb.End[contador + 1] = @"Imagens\PortaAvioespt2.png";
                    emb.End[contador + 2] = @"Imagens\PortaAvioespt3.png";
                    emb.End[contador + 3] = @"Imagens\PortaAvioespt4.png";
                    emb.End[contador + 4] = @"Imagens\PortaAvioespt5.png";
                    //1,2,3,4 e 5
                    contador += 5;
                    chances += 5;
                    barc += 5;
                    port--;
                }
                else
                {
                    if (contador == 1)
                    {
                        emb.End[contador] = @"Imagens\PortaAvioespt1.png";
                        emb.End[contador + 1] = @"Imagens\PortaAvioespt2.png";
                        emb.End[contador + 2] = @"Imagens\PortaAvioespt3.png";
                        emb.End[contador + 3] = @"Imagens\PortaAvioespt4.png";
                        emb.End[contador + 4] = @"Imagens\PortaAvioespt5.png";
                        //2,3,4,5 e 6
                        contador += 5;
                        chances += 5;
                        barc += 5;
                        port--;
                    }
                    else
                    {
                        if (contador == 6)
                        {
                            emb.End[contador] = @"Imagens\PortaAvioespt1.png";
                            emb.End[contador + 1] = @"Imagens\PortaAvioespt2.png";
                            emb.End[contador + 2] = @"Imagens\PortaAvioespt3.png";
                            emb.End[contador + 3] = @"Imagens\PortaAvioespt4.png";
                            emb.End[contador + 4] = @"Imagens\PortaAvioespt5.png";
                            //7,8,9,10 e 11
                            contador += 5;
                            chances += 5;
                            barc += 5;
                            port--;
                        }
                        else
                        {
                            if (contador == 7)
                            {
                                emb.End[contador] = @"Imagens\PortaAvioespt1.png";
                                emb.End[contador + 1] = @"Imagens\PortaAvioespt2.png";
                                emb.End[contador + 2] = @"Imagens\PortaAvioespt3.png";
                                emb.End[contador + 3] = @"Imagens\PortaAvioespt4.png";
                                emb.End[contador + 4] = @"Imagens\PortaAvioespt5.png";
                                //8,9,10,11 e 12
                                contador += 5;
                                chances += 5;
                                barc += 5;
                                port--;
                            }
                            else
                            {
                                if (contador == 12)
                                {
                                    emb.End[contador] = @"Imagens\PortaAvioespt1.png";
                                    emb.End[contador + 1] = @"Imagens\PortaAvioespt2.png";
                                    emb.End[contador + 2] = @"Imagens\PortaAvioespt3.png";
                                    emb.End[contador + 3] = @"Imagens\PortaAvioespt4.png";
                                    emb.End[contador + 4] = @"Imagens\PortaAvioespt5.png";
                                    //13,14,15,16 e 17
                                    contador += 5;
                                    chances += 5;
                                    barc += 5;
                                    port--;
                                }
                                else
                                {
                                    if (contador == 13)
                                    {
                                        emb.End[contador] = @"Imagens\PortaAvioespt1.png";
                                        emb.End[contador + 1] = @"Imagens\PortaAvioespt2.png";
                                        emb.End[contador + 2] = @"Imagens\PortaAvioespt3.png";
                                        emb.End[contador + 3] = @"Imagens\PortaAvioespt4.png";
                                        emb.End[contador + 4] = @"Imagens\PortaAvioespt5.png";
                                        //14,15,16,17 e 18
                                        contador += 5;
                                        chances += 5;
                                        barc += 5;
                                        port--;
                                    }
                                    else
                                    {
                                        if (contador == 18)
                                        {
                                            emb.End[contador] = @"Imagens\PortaAvioespt1.png";
                                            emb.End[contador + 1] = @"Imagens\PortaAvioespt2.png";
                                            emb.End[contador + 2] = @"Imagens\PortaAvioespt3.png";
                                            emb.End[contador + 3] = @"Imagens\PortaAvioespt4.png";
                                            emb.End[contador + 4] = @"Imagens\PortaAvioespt5.png";
                                            //19,20,21,22 e 23
                                            contador += 5;
                                            chances += 5;
                                            barc += 5;
                                            port--;
                                        }
                                        else
                                        {
                                            if (contador == 19)
                                            {
                                                emb.End[contador] = @"Imagens\PortaAvioespt1.png";
                                                emb.End[contador + 1] = @"Imagens\PortaAvioespt2.png";
                                                emb.End[contador + 2] = @"Imagens\PortaAvioespt3.png";
                                                emb.End[contador + 3] = @"Imagens\PortaAvioespt4.png";
                                                emb.End[contador + 4] = @"Imagens\PortaAvioespt5.png";
                                                //20,21,22,23 e 24
                                                contador += 5;
                                                chances += 5;
                                                barc += 5;
                                                port--;
                                            }
                                            else
                                            {
                                                if (contador == 24)
                                                {
                                                    emb.End[contador] = @"Imagens\PortaAvioespt1.png";
                                                    emb.End[contador + 1] = @"Imagens\PortaAvioespt2.png";
                                                    emb.End[contador + 2] = @"Imagens\PortaAvioespt3.png";
                                                    emb.End[contador + 3] = @"Imagens\PortaAvioespt4.png";
                                                    emb.End[contador + 4] = @"Imagens\PortaAvioespt5.png";
                                                    //25,26,27,28 e 29
                                                    contador += 5;
                                                    chances += 5;
                                                    barc += 5;
                                                    port--;
                                                }
                                                else
                                                {
                                                    if (contador == 25)
                                                    {
                                                        emb.End[contador] = @"Imagens\PortaAvioespt1.png";
                                                        emb.End[contador + 1] = @"Imagens\PortaAvioespt2.png";
                                                        emb.End[contador + 2] = @"Imagens\PortaAvioespt3.png";
                                                        emb.End[contador + 3] = @"Imagens\PortaAvioespt4.png";
                                                        emb.End[contador + 4] = @"Imagens\PortaAvioespt5.png";
                                                        //26,27,28,29 e 30
                                                        contador += 5;
                                                        chances += 5;
                                                        barc += 5;
                                                        port--;
                                                    }
                                                    else
                                                    {
                                                        if (contador == 30)
                                                        {
                                                            emb.End[contador] = @"Imagens\PortaAvioespt1.png";
                                                            emb.End[contador + 1] = @"Imagens\PortaAvioespt2.png";
                                                            emb.End[contador + 2] = @"Imagens\PortaAvioespt3.png";
                                                            emb.End[contador + 3] = @"Imagens\PortaAvioespt4.png";
                                                            emb.End[contador + 4] = @"Imagens\PortaAvioespt5.png";
                                                            //31,32,33,34 e 35
                                                            contador += 5;
                                                            chances += 5;
                                                            barc += 5;
                                                            port--;
                                                        }
                                                        else
                                                        {
                                                            if (contador == 31)
                                                            {
                                                                emb.End[contador] = @"Imagens\PortaAvioespt1.png";
                                                                emb.End[contador + 1] = @"Imagens\PortaAvioespt2.png";
                                                                emb.End[contador + 2] = @"Imagens\PortaAvioespt3.png";
                                                                emb.End[contador + 3] = @"Imagens\PortaAvioespt4.png";
                                                                emb.End[contador + 4] = @"Imagens\PortaAvioespt5.png";
                                                                //32,33,34,35 e 36
                                                                contador += 5;
                                                                chances += 5;
                                                                barc += 5;
                                                                port--;
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

            
            }//FIM PORTA-AVIOES


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
    

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TelaJogo5x5_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            iniciar();
        }

       
    }
}
