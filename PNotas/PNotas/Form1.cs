using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PNotas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            lbxAlunos.Items.Clear();
            //RA Albert: 003482123001
            int i, j;
            string auxiliar;
            double[,] notas = new double[1, 10];
            string[] gabarito = new string[10] { "A", "B", "C", "D", "A", "B", "C", "D", "A", "B" };
            string[] respostas = new string[10];

            //Recebimento das respostas dos alunos
            for (i = 0; i < 1; i++)
            {
                for ( j= 0; j < 10; j++)
                {
                    respostas[j] = Interaction.InputBox("Resposta da questão " + (j + 1) + " do aluno " + (i + 1));
                    if (!((respostas[j] == "A") || (respostas[j] == "B") || (respostas[j] == "C") || (respostas[j] == "D") || (respostas[j] == "E")))
                    {
                        MessageBox.Show("Valor inválido");
                        j -= 1;
                    }
                }
            }

            //Comparação respostas e gabarito
            for (i = 0; i < 1; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    if (respostas[j] == gabarito[j])
                    {
                        lbxAlunos.Items.Add("Aluno " + (i + 1) + " acertou questão " + (j + 1) + " era " + (gabarito[j]) + " escolheu " + (respostas[j]) + "\n");
                    }
                    else
                    {
                        lbxAlunos.Items.Add("Aluno " + (i + 1) + " errou questão " + (j + 1) + " era " + (gabarito[j]) + " escolheu " + (respostas[j]) + "\n");
                    }

                }
            }
        }
    }
}
