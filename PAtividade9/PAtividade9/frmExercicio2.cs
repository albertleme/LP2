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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string auxiliar;
            int x;
            int[] quantidade = new int[10];
            double[] preco = new double[10];
            double faturamento = 0;

            for (x = 0; x < 10; x++)
            {
                auxiliar = Interaction.InputBox("Digite a quantidade do produto " + (x + 1)+": ");
                if (!int.TryParse(auxiliar, out quantidade[x]))
                {
                    MessageBox.Show("Valor inválido");
                    x -= 1;
                }
                else
                {
                    auxiliar = Interaction.InputBox("Digite o preço do produto " + (x + 1) + ": ");
                    if (!double.TryParse(auxiliar, out preco[x]))
                    {
                        MessageBox.Show("Valor inválido");
                        x -= 1;
                    }
                }
            }
            for (x = 0; x < 10; x++)
            {
                faturamento = faturamento + (quantidade[x] * preco[x]);
            }
            MessageBox.Show("O faturamento mensal foi de: R$" + faturamento);
        }
    }
}
