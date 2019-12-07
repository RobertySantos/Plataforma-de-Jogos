using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PlataformaJogos
{
    class Class1
    {
        public String vez(int rodada) {
            String retorno = "";

            if (rodada % 2 != 0)
            {
                retorno = "p1";
            }
            else {
                retorno = "p2";
            }
            return retorno;
        }

        public String verifica(String[] valores) {
            String acabou = "";

            // verificacao do x
                //horizontal
            if (valores[0] == "x" && valores[1] == "x" && valores[2] == "x") {
                acabou = "p1";
            }
            if (valores[3] == "x" && valores[4] == "x" && valores[5] == "x")
            {
                acabou = "p1";
            }
            if (valores[6] == "x" && valores[7] == "x" && valores[8] == "x")
            {
                acabou = "p1";
            }

                //vertical
            if (valores[0] == "x" && valores[3] == "x" && valores[6] == "x")
            {
                acabou = "p1";
            }
            if (valores[1] == "x" && valores[4] == "x" && valores[7] == "x")
            {
                acabou = "p1";
            }
            if (valores[2] == "x" && valores[5] == "x" && valores[8] == "x")
            {
                acabou = "p1";
            }

                //diagonal
            if (valores[0] == "x" && valores[4] == "x" && valores[8] == "x")
            {
                acabou = "p1";
            }
            if (valores[2] == "x" && valores[4] == "x" && valores[6] == "x")
            {
                acabou = "p1";
            }





            // verificacao do o
                //horizontal
            if (valores[0] == "o" && valores[1] == "o" && valores[2] == "o")
            {
                acabou = "p2";
            }
            if (valores[3] == "o" && valores[4] == "o" && valores[5] == "o")
            {
                acabou = "p2";
            }
            if (valores[6] == "o" && valores[7] == "o" && valores[8] == "o")
            {
                acabou = "p2";
            }

                //vertical
            if (valores[0] == "o" && valores[3] == "o" && valores[6] == "o")
            {
                acabou = "p2";
            }
            if (valores[1] == "o" && valores[4] == "o" && valores[7] == "o")
            {
                acabou = "p2";
            }
            if (valores[2] == "o" && valores[5] == "o" && valores[8] == "o")
            {
                acabou = "p2";
            }

                //diagonal
            if (valores[0] == "o" && valores[4] == "o" && valores[8] == "o")
            {
                acabou = "p2";
            }
            if (valores[2] == "o" && valores[4] == "o" && valores[6] == "o")
            {
                acabou = "p2";
            }
            return acabou;
        }
    }
}
