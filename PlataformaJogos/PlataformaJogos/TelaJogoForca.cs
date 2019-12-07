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
    public partial class TelaJogoForca : Form
    {
        public TelaJogoForca()
        {
            InitializeComponent();
        }

        String palavraSelecionada;
        String letraClicada = "";

        int errou = 0, acertou=0;

        private void TelaJogoForca_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap("imagens/forca1.png");

            //Gerando Palavra com random
            if (GerarNumero(1, 10) == 1)
            {
                palavraSelecionada = "algorithm";
                dica.Text = "Série de instruções de procedimento para a solução de um problema";
            }
            else if (GerarNumero(1, 10) == 2)
            {
                palavraSelecionada = "caption";
                lbl8.Visible = false;
                lbl9.Visible = false;
                dica.Text = "Legenda, título ou cabeçalho";
            }
            else if (GerarNumero(1, 10) == 3)
            {
                palavraSelecionada = "altkey";
                lbl4.Visible = false;
                lbl8.Visible = false;
                lbl9.Visible = false;
                dica.Text = "Tecla especial de teclado de PC para ativar funções especiais  ";
            }
            else if (GerarNumero(1, 10) == 4)
            {
                palavraSelecionada = "chart";
                lbl6.Visible = false;
                lbl7.Visible = false;
                lbl8.Visible = false;
                lbl9.Visible = false;
                dica.Text = "Gráfico, diagrama que mostra informações de uma série de linhas ou blocos";

            }
            else if (GerarNumero(1, 10) == 5)
            {
                palavraSelecionada = "amplifier";
                dica.Text = "Amplificador";
            }
            else if (GerarNumero(1, 10) == 6)
            {
                palavraSelecionada = "analog";
                lbl7.Visible = false;
                lbl8.Visible = false;
                lbl9.Visible = false;
                dica.Text = "conversor analógico";
            }
            else if (GerarNumero(1, 10) == 7)
            {
                palavraSelecionada = "bug";
                lbl4.Visible = false;
                lbl5.Visible = false;
                lbl6.Visible = false;
                lbl7.Visible = false;
                lbl8.Visible = false;
                lbl9.Visible = false;
                dica.Text = "erro ou falha em programa de computador";
            }
            else if (GerarNumero(1, 10) == 8)
            {
                palavraSelecionada = "server";
                lbl7.Visible = false;
                lbl8.Visible = false;
                lbl9.Visible = false;
                dica.Text = "servidor";
            }
            else if (GerarNumero(1, 10) == 9)
            {
                palavraSelecionada = "byte";
                lbl5.Visible = false;
                lbl6.Visible = false;
                lbl7.Visible = false;
                lbl8.Visible = false;
                lbl9.Visible = false;
                dica.Text = "Grupo de bits ou dígitos binários";
            }
            else {
                palavraSelecionada = "reset";
                lbl6.Visible = false;
                lbl7.Visible = false;
                lbl8.Visible = false;
                lbl9.Visible = false;
                dica.Text = "Restaurar ou inicializar";
            }
        }
       
        //métordo random
        private int GerarNumero(int min, int max) {
            Random rd = new Random();
            return rd.Next(min, max);
        }
        //método verificarLetra
        private String VerificarLetra(String palavra) {
            switch (palavra)
            {
                case "algorithm":

                    if (letraClicada == btnA.Text) {
                        lbl1.Text = "A";
                        letraClicada = "";
                        acertou++;
                    } else if (letraClicada == btnL.Text) {
                        lbl2.Text = "L";
                        letraClicada = "";
                        acertou++;
                    } else if (letraClicada == btnG.Text) {
                        lbl3.Text = "G";
                        letraClicada = "";
                        acertou++;
                    } else if (letraClicada == btnO.Text) {
                        lbl4.Text = "O";
                        letraClicada = "";
                        acertou++;
                    } else if (letraClicada == btnR.Text) {
                        lbl5.Text = "R";
                        letraClicada = "";
                        acertou++;
                    } else if (letraClicada == btnI.Text) {
                        lbl6.Text = "I";
                        letraClicada = "";
                        acertou++;
                    } else if (letraClicada == btnT.Text) {
                        lbl7.Text = "T";
                        letraClicada = "";
                        acertou++;
                    } else if (letraClicada == btnH.Text) {
                        lbl8.Text = "H";
                        letraClicada = "";
                        acertou++;
                    } else if (letraClicada == btnM.Text) {
                        lbl9.Text = "M";
                        letraClicada = "";
                        acertou++;
                    } else {
                        errou++;
                        if (errou == 6) {
                            TrocarImagemForca(errou);
                            ErrouPalavra t = new ErrouPalavra();
                            t.Show();
                            this.Dispose();
                        } else {
                            TrocarImagemForca(errou);
                        }
                    }
                    if (acertou == 9) {
                        AcertouPalavra t = new AcertouPalavra();
                        t.Show();
                        this.Dispose();
                    }
                    
                    break;
                case "caption":
                    if (letraClicada == btnC.Text) {
                        lbl1.Text = "C";
                        letraClicada = "";
                        acertou++;
                    } else if (letraClicada == btnA.Text) {
                        lbl2.Text = "A";
                        letraClicada = "";
                        acertou++;
                    } else if (letraClicada == btnP.Text) {
                        lbl3.Text = "P";
                        letraClicada = "";
                        acertou++;
                    } else if (letraClicada == btnT.Text) {
                        lbl4.Text = "T";
                        letraClicada = "";
                        acertou++;
                    } else if (letraClicada == btnI.Text) {
                        lbl5.Text = "I";
                        letraClicada = "";
                        acertou++;
                    } else if (letraClicada == btnO.Text) {
                        lbl6.Text = "O";
                        letraClicada = "";
                        acertou++;
                    } else if (letraClicada == btnN.Text) {
                        lbl7.Text = "N";
                        letraClicada = "";
                        acertou++;
                    }else {
                        errou++;
                        if (errou == 6)
                        {
                            TrocarImagemForca(errou);
                            ErrouPalavra t = new ErrouPalavra();
                            t.Show();
                            this.Dispose();
                        }else {
                            TrocarImagemForca(errou);
                        }
                    }
                    if (acertou == 7){
                        AcertouPalavra t = new AcertouPalavra();
                        t.Show();
                        this.Dispose();
                    }

                    break;
                case "altkey":
                    if (letraClicada == btnA.Text) {
                        lbl1.Text = "A";
                        letraClicada = "";
                        acertou++;
                    } else if (letraClicada == btnL.Text) {
                        lbl2.Text = "L";
                        letraClicada = "";
                        acertou++;
                    } else if (letraClicada == btnT.Text) {
                        lbl3.Text = "T";
                        letraClicada = "";
                        acertou++;
                    } else if (letraClicada == btnK.Text) {
                        lbl5.Text = "K";
                        letraClicada = "";
                        acertou++;
                    } else if (letraClicada == btnE.Text) {
                        lbl6.Text = "E";
                        letraClicada = "";
                        acertou++;
                    } else if (letraClicada == btnY.Text) {
                        lbl7.Text = "Y";
                        letraClicada = "";
                        acertou++;
                    } else {
                        errou++;
                        if (errou == 6){
                            TrocarImagemForca(errou);
                            ErrouPalavra t = new ErrouPalavra();
                            t.Show();
                            this.Dispose();

                        }else{
                            TrocarImagemForca(errou);
                        }
                    }
                    if (acertou == 6){
                        AcertouPalavra t = new AcertouPalavra();
                        t.Show();
                        this.Dispose();
                    }
                    break;
                case "chart":
                    if (letraClicada == btnC.Text) {
                        lbl1.Text = "C";
                        letraClicada = "";
                        acertou++;
                    } else if (letraClicada == btnH.Text) {
                        lbl2.Text = "H";
                        letraClicada = "";
                        acertou++;
                    } else if (letraClicada == btnA.Text) {
                        lbl3.Text = "A";
                        letraClicada = "";
                        acertou++;
                    } else if (letraClicada == btnR.Text) {
                        lbl4.Text = "R";
                        letraClicada = "";
                        acertou++;
                    } else if (letraClicada == btnT.Text) {
                        lbl5.Text = "T";
                        letraClicada = "";
                        acertou++;
                    } else {
                        errou++;
                        if (errou == 6)
                        {
                            TrocarImagemForca(errou);
                            ErrouPalavra t = new ErrouPalavra();
                            t.Show();
                            this.Dispose();
                        }
                        else
                        {
                            TrocarImagemForca(errou);
                        }
                    }
                    if (acertou == 5){
                        AcertouPalavra t = new AcertouPalavra();
                        t.Show();
                        this.Dispose();
                    }
                    break;
                case "amplifier":
                    if (letraClicada == btnA.Text) {
                        lbl1.Text = "A";
                        letraClicada = "";
                        acertou++;
                    } else if (letraClicada == btnM.Text) {
                        lbl2.Text = "M";
                        letraClicada = "";
                        acertou++;
                    } else if (letraClicada == btnP.Text) {
                        lbl3.Text = "P";
                        letraClicada = "";
                        acertou++;
                    } else if (letraClicada == btnL.Text) {
                        lbl4.Text = "L";
                        letraClicada = "";
                        acertou++;
                    } else if (letraClicada == btnI.Text) {
                        lbl5.Text = "I";
                        lbl7.Text = "I";
                        letraClicada = "";
                        acertou=acertou+2;
                    } else if (letraClicada == btnF.Text) {
                        lbl6.Text = "F";
                        letraClicada = "";
                        acertou++;
                    } else if (letraClicada == btnE.Text) {
                        lbl8.Text = "E";
                        letraClicada = "";
                        acertou++;
                    } else if (letraClicada == btnR.Text) {
                        lbl9.Text = "R";
                        letraClicada = "";
                        acertou++;
                    } else {
                        errou++;
                        if (errou == 6)
                        {
                            TrocarImagemForca(errou);
                            ErrouPalavra t = new ErrouPalavra();
                            t.Show();
                            this.Dispose();
                        }
                        else
                        {
                            TrocarImagemForca(errou);
                        }
                    }
                    if (acertou == 9){
                        AcertouPalavra t = new AcertouPalavra();
                        t.Show();
                        this.Dispose();
                    }
                    break;
                case "analog":
                    if (letraClicada == btnA.Text) {
                        lbl1.Text = "A";
                        lbl3.Text = "A";
                        letraClicada = "";
                        acertou=acertou+2;
                    }else if (letraClicada == btnN.Text){
                        lbl2.Text = "N";
                        letraClicada = "";
                        acertou++;
                    }else if (letraClicada == btnL.Text){
                        lbl4.Text = "L";
                        letraClicada = "";
                        acertou++;
                    }else if (letraClicada == btnO.Text){
                        lbl5.Text = "O";
                        letraClicada = "";
                        acertou++;
                    } else if (letraClicada == btnG.Text){
                        lbl6.Text = "G";
                        letraClicada = "";
                        acertou++;
                    }else{
                        errou++;
                        if (errou == 6)
                        {
                            TrocarImagemForca(errou);
                            ErrouPalavra t = new ErrouPalavra();
                            t.Show();
                            this.Dispose();
                        }else{
                            TrocarImagemForca(errou);
                        }
                    }
                    if (acertou == 6) {
                        AcertouPalavra t = new AcertouPalavra();
                        t.Show();
                        this.Dispose();
                    }
                    break;
                case "bug":
                    if (letraClicada == btnB.Text){
                        lbl1.Text = "B";
                        letraClicada = "";
                        acertou++;
                    }else if (letraClicada == btnU.Text){
                        lbl2.Text = "U";
                        letraClicada = "";
                        acertou++;
                    }else if(letraClicada == btnG.Text){
                        lbl3.Text = "G";
                        letraClicada = "";
                        acertou++;
                    }else{
                        errou++;
                        if (errou == 6)
                        {
                            TrocarImagemForca(errou);
                            ErrouPalavra t = new ErrouPalavra();
                            t.Show();
                            this.Dispose();
                        }else{
                            TrocarImagemForca(errou);
                        }
                    }
                    if (acertou == 3){
                        AcertouPalavra t = new AcertouPalavra();
                        t.Show();
                        this.Dispose();
                    }
                    break;
                case "server":
                    if (letraClicada == btnS.Text){
                        lbl1.Text = "S";
                        letraClicada = "";
                        acertou++;
                    }else if (letraClicada == btnE.Text){
                        lbl2.Text = "E";
                        lbl5.Text = "E";
                        letraClicada = "";
                        acertou=acertou+2;
                    }
                    else if (letraClicada == btnR.Text){
                        lbl3.Text = "R";
                        lbl6.Text = "R";
                        letraClicada = "";
                        acertou = acertou + 2;
                    }else if (letraClicada == btnV.Text){
                        lbl4.Text = "V";
                        letraClicada = "";
                        acertou++;
                    }else {
                        errou++;
                        if (errou == 6)
                        {
                            TrocarImagemForca(errou);
                            ErrouPalavra t = new ErrouPalavra();
                            t.Show();
                            this.Dispose();
                        } else{
                            TrocarImagemForca(errou);
                        }
                    }
                    if (acertou == 6){
                        AcertouPalavra t = new AcertouPalavra();
                        t.Show();
                        this.Dispose();
                    }
                    break;
                case "byte":
                    if (letraClicada == btnB.Text){
                        lbl1.Text = "B";
                        letraClicada = "";
                        acertou++;
                    }else if (letraClicada == btnY.Text){
                        lbl2.Text = "Y";
                        letraClicada = "";
                        acertou++;
                    }else if (letraClicada == btnT.Text){
                        lbl3.Text = "T";
                        letraClicada = "";
                        acertou++;
                    }else if (letraClicada == btnE.Text){
                        lbl4.Text = "E";
                        letraClicada = "";
                        acertou++;
                    }else{
                        errou++;
                        if (errou == 6)
                        {
                            TrocarImagemForca(errou);
                            ErrouPalavra t = new ErrouPalavra();
                            t.Show();
                            this.Dispose();
                        }else{
                            TrocarImagemForca(errou);
                        }
                    }
                    if (acertou == 4){
                        AcertouPalavra t = new AcertouPalavra();
                        t.Show();
                        this.Dispose();
                    }
                    break;
                case "reset":
                    if (letraClicada == btnR.Text){
                        lbl1.Text = "R";
                        letraClicada = "";
                        acertou++;
                    }else if (letraClicada == btnE.Text){
                        lbl2.Text = "E";
                        lbl4.Text = "E";
                        letraClicada = "";
                        acertou=acertou+2;
                    }else if (letraClicada == btnS.Text){
                        lbl3.Text = "S";
                        letraClicada = "";
                        acertou++;
                    }else if (letraClicada == btnT.Text){
                        lbl5.Text = "T";
                        letraClicada = "";
                        acertou++;
                    }else{
                        errou++;
                        if (errou == 6)
                        {
                            TrocarImagemForca(errou);
                            ErrouPalavra t = new ErrouPalavra();
                            t.Show();
                            this.Dispose();
                        } else{
                            TrocarImagemForca(errou);
                        }
                    }
                    if (acertou == 5) {
                       AcertouPalavra t = new AcertouPalavra();
                        t.Show();
                        this.Dispose();
                    }
                    break;
            default:
                    MessageBox.Show("deu errado");
            break;
        } 
            return null;
        }

        //método de Trocar imagem da forca
        private int TrocarImagemForca(int n)
        {
            if (errou == 1)
            {
                pictureBox1.Image = new Bitmap("imagens/forca2.png");
            }
            else if (errou == 2)
            {
                pictureBox1.Image = new Bitmap("imagens/forca3.png");
            }
            else if (errou == 3)
            {
                pictureBox1.Image = new Bitmap("imagens/forca4.png");
            }
            else if (errou == 4)
            {
                pictureBox1.Image = new Bitmap("imagens/forca5.png");
            }
            else if (errou == 5)
            {
                pictureBox1.Image = new Bitmap("imagens/forca6.png");
            }
            else if (errou == 6)
            {
                pictureBox1.Image = new Bitmap("imagens/forca7.png");
            }
            return n;
        }

   
        private void btnA_Click(object sender, EventArgs e)
            {
                letraClicada = btnA.Text;
                VerificarLetra(palavraSelecionada);
                btnA.Enabled=false;
            }
            private void btnB_Click(object sender, EventArgs e)
            {
                letraClicada = btnB.Text;
                VerificarLetra(palavraSelecionada);
                btnB.Enabled = false;
            }
            private void btnC_Click(object sender, EventArgs e)
            {
                letraClicada = btnC.Text;
                VerificarLetra(palavraSelecionada);
                btnC.Enabled = false;
            }
            private void btnD_Click(object sender, EventArgs e)
            {
                letraClicada = btnD.Text;
                VerificarLetra(palavraSelecionada);
                btnD.Enabled = false;
            }
            private void btnE_Click(object sender, EventArgs e)
            {
                letraClicada = btnE.Text;
                VerificarLetra(palavraSelecionada);
                btnE.Enabled = false;
            }
            private void btnF_Click(object sender, EventArgs e)
            {
                letraClicada = btnF.Text;
                VerificarLetra(palavraSelecionada);
                btnF.Enabled = false;
            }
            private void btnG_Click(object sender, EventArgs e)
            {
                letraClicada = btnG.Text;
                VerificarLetra(palavraSelecionada);
                btnG.Enabled = false;
            }
            private void btnH_Click(object sender, EventArgs e)
            {
                letraClicada = btnH.Text;
                VerificarLetra(palavraSelecionada);
                btnH.Enabled = false;
            }
            private void btnI_Click(object sender, EventArgs e)
            {
                letraClicada = btnI.Text;
                VerificarLetra(palavraSelecionada);
                btnI.Enabled = false;
            }
            private void btnJ_Click(object sender, EventArgs e)
            {
                letraClicada = btnJ.Text;
                VerificarLetra(palavraSelecionada);
                btnJ.Enabled = false;
            }
            private void btnK_Click(object sender, EventArgs e)
            {
                letraClicada = btnK.Text;
                VerificarLetra(palavraSelecionada);
                btnK.Enabled = false;
            }
            private void btnL_Click(object sender, EventArgs e)
            {
                letraClicada = btnL.Text;
                VerificarLetra(palavraSelecionada);
                btnL.Enabled = false;
            }
            private void btnM_Click(object sender, EventArgs e)
            {
                letraClicada = btnM.Text;
                VerificarLetra(palavraSelecionada);
                btnM.Enabled = false;
            }
            private void btnN_Click(object sender, EventArgs e)
            {
                letraClicada = btnN.Text;
                VerificarLetra(palavraSelecionada);
                btnN.Enabled = false;
            }
            private void btnO_Click(object sender, EventArgs e)
            {
                letraClicada = btnO.Text;
                VerificarLetra(palavraSelecionada);
                btnO.Enabled = false;
            }
            private void btnP_Click(object sender, EventArgs e)
            {
                letraClicada = btnP.Text;
                VerificarLetra(palavraSelecionada);
                btnP.Enabled = false;
            }
            private void btnQ_Click(object sender, EventArgs e)
            {
                letraClicada = btnQ.Text;
                VerificarLetra(palavraSelecionada);
                btnQ.Enabled = false;
            }
            private void btnR_Click(object sender, EventArgs e)
            {
                letraClicada = btnR.Text;
                VerificarLetra(palavraSelecionada);
                btnR.Enabled = false;
            }
            private void btnS_Click(object sender, EventArgs e)
            {
                letraClicada = btnS.Text;
                VerificarLetra(palavraSelecionada);
                btnS.Enabled = false;
            }
            private void btnT_Click(object sender, EventArgs e)
            {
                letraClicada = btnT.Text;
                VerificarLetra(palavraSelecionada);
                btnT.Enabled = false;
            }
            private void btnU_Click(object sender, EventArgs e)
            {
                letraClicada = btnU.Text;
                VerificarLetra(palavraSelecionada);
                btnU.Enabled = false;
            }
            private void btnV_Click(object sender, EventArgs e)
            {
                letraClicada = btnV.Text;
                VerificarLetra(palavraSelecionada);
                btnV.Enabled = false;
            }
            private void btnW_Click(object sender, EventArgs e)
            {
                letraClicada = btnW.Text;
                VerificarLetra(palavraSelecionada);
                btnW.Enabled = false;
            }
            private void btnX_Click(object sender, EventArgs e)
            {
                letraClicada = btnX.Text;
                VerificarLetra(palavraSelecionada);
                btnX.Enabled = false;
            }
            private void btnY_Click(object sender, EventArgs e)
            {
                letraClicada = btnY.Text;
                VerificarLetra(palavraSelecionada);
                btnY.Enabled = false;
            }

      
        private void btnZ_Click(object sender, EventArgs e)
            {
                letraClicada = btnZ.Text;
                VerificarLetra(palavraSelecionada);
                btnZ.Enabled = false;
            }
    }
    }
