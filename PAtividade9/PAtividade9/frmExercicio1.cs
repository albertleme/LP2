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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string auxiliar;
            int[] vetor = new int[20];
            int x = 0;

            for (x = 0; x < 20; x++)
            {
                auxiliar = Interaction.InputBox("Digite um número - Posição = " + (x + 1));
                if (!int.TryParse(auxiliar, out vetor[x]))
                {
                    MessageBox.Show("Valor inválido");
                    x -= 1;
                }
            }
            Array.Reverse(vetor);
            auxiliar = "";

            foreach(int i in vetor)
            {
                auxiliar = auxiliar + "\n" + i;
            }
            MessageBox.Show(auxiliar);
        }
    }
}
