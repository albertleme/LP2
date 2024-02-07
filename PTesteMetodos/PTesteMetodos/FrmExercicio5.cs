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
    public partial class FrmExercicio5 : Form
    {
        public FrmExercicio5()
        {
            InitializeComponent();
        }

        private void FrmExercicio5_Load(object sender, EventArgs e)
        {

        }

        private void btnSorteador_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;

            if(!int.TryParse(txtNumero1.Text, out numero1))
            {
                MessageBox.Show("Digite apenas números");
                txtNumero1.Clear();
                txtNumero1.Focus();
            }
            else
            {
                if (!int.TryParse(txtNumero2.Text, out numero2))
                {
                    MessageBox.Show("Digite apenas números");
                    txtNumero2.Clear();
                    txtNumero2.Focus();
                }
                else
                {
                    if (numero1 > numero2)
                    {
                        MessageBox.Show("Insira um intervalo válido!");
                        txtNumero1.Clear();
                        txtNumero2.Clear();
                        txtNumero1.Focus();
                    }
                    else
                    {
                        Random random = new Random();
                        int numero = random.Next(numero1, numero2);

                        MessageBox.Show("O número sorteado entre " + numero1 + " e " + numero2 + " foi " + numero);
                    }
                }
                
            }
        }
    }
}
