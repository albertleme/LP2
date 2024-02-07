using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteMetodos
{
    public partial class FrmExercicio4 : Form
    {
        public FrmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCaracteresNumericos_Click(object sender, EventArgs e)
        {
            int i = 0;
            int tamanho = rtxtFrase.Text.Length;
            int totalNumeros = 0;
            char c;
            string frase = rtxtFrase.Text;

            for (i = 0; i < tamanho; i++)
            {
                c = frase[i];
                if (Char.IsNumber(c))
                {
                    totalNumeros += 1;
                }
            }

            MessageBox.Show("Há " + totalNumeros + " números no texto");
        }

        private void btnPrimeiroBranco_Click(object sender, EventArgs e)
        {
            int i = 0;
            int posicao = 0;
            int temEspaco = 0;
            int tamanho = rtxtFrase.Text.Length;
            string frase = rtxtFrase.Text;

            while (i<tamanho)
            {
                posicao = i;

                if (Char.IsWhiteSpace(frase[i]))
                {
                    MessageBox.Show("O primeiro espaço em branco ocorre na posição " + (posicao + 1));
                    temEspaco = 1;
                    break;
                }
                i += 1;
            }

            if (temEspaco == 0)
                MessageBox.Show("Não há espaços no texto");
        }

        private void btnCaracteresAlfabeticos_Click(object sender, EventArgs e)
        {
            string frase = rtxtFrase.Text;
            int i = 0;
            int totalLetras = 0;

            foreach(char letra in frase)
            {
                if (Char.IsLetter(frase[i]))
                {
                    totalLetras += 1;
                }

                i += i;
            }

            MessageBox.Show("Há um total de " + totalLetras + " letras na frase");
        }
    }
}
