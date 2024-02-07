using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtividade9
{
    using Microsoft.VisualBasic;
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[,] matriz = new double[20,3];
            double[] notaFinal = new double[20];
            int x, y;
            string auxiliar;

            for (x = 0; x < 20; x++)
            {
                for (y = 0; y < 3; y++)
                {
                    auxiliar = Interaction.InputBox("Digite a nota " + (y + 1) + " do aluno " + (x + 1));
                    if (!double.TryParse(auxiliar, out matriz[x,y]))
                    {
                        MessageBox.Show("Valor inválido");
                        y -= 1;
                    }
                    else
                    {
                        if ((matriz[x, y] < 0)||(matriz[x,y]>10))
                        {
                            MessageBox.Show("Valor inválido");
                            y -= 1;
                        }
                    }
                }
            }
            for (x = 0; x < 20; x++)
            {
                for (y = 0; y < 3; y++)
                {
                    notaFinal[x] += matriz[x, y];
                }
            }
            for (x = 0; x < 20; x++)
            {
                notaFinal[x] = notaFinal[x] / 3;
            }

            auxiliar = "";

            for (x = 0;x < 20;x++)
            {
                auxiliar = auxiliar + "\n Nota Aluno " + x + ": " + notaFinal[x];
            }
            MessageBox.Show(auxiliar);
        }
    }
}
