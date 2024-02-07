using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerificaTriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtValorA_Validated(object sender, EventArgs e)
        {
            double valorA;
            if (!double.TryParse(txtValorA.Text, out valorA))
            {
                MessageBox.Show("Digite um valor válido");
                txtValorA.Focus();
            }
            else
            {
                if(valorA <= 0)
                {
                    MessageBox.Show("O lado A do triângulo precisa ser maior que 0");
                    txtValorA.Focus();
                }
            }
        }

        private void txtValorB_Validated(object sender, EventArgs e)
        {
            double valorB;
            if (!double.TryParse(txtValorB.Text, out valorB))
            {
                MessageBox.Show("Digite um valor válido");
                txtValorB.Focus();
            }
            else
            {
                if (valorB <= 0)
                {
                    MessageBox.Show("O lado B do triângulo precisa ser maior que 0");
                    txtValorB.Focus();
                }
            }
        }

        private void txtValorC_Validated(object sender, EventArgs e)
        {
            double valorC;
            if (!double.TryParse(txtValorC.Text, out valorC))
            {
                MessageBox.Show("Digite um valor válido");
                txtValorC.Focus();
            }
            else
            {
                if (valorC <= 0)
                {
                    MessageBox.Show("O lado C do triângulo precisa ser maior que 0");
                    txtValorC.Focus();
                }
            }
        }

        private void btnVerificador_Click(object sender, EventArgs e)
        {
            double valorA, valorB, valorC;

            if (!double.TryParse(txtValorA.Text, out valorA))
            {
                MessageBox.Show("Digite um valor válido");
                txtValorA.Focus();
            }
            else
            {
                if (!double.TryParse(txtValorB.Text, out valorB))
                {
                    MessageBox.Show("Digite um valor válido");
                    txtValorB.Focus();
                }
                else
                {
                    if (!double.TryParse(txtValorC.Text, out valorC))
                    {
                        MessageBox.Show("Digite um valor válido");
                        txtValorC.Focus();
                    }
                    else
                    {
                        if(Math.Abs(valorB-valorC)<valorA && valorA < valorB + valorC && Math.Abs(valorA - valorC) < valorB && valorB < valorA + valorC && Math.Abs(valorA - valorB) < valorC && valorC < valorA + valorB)
                        {
                            if(valorA == valorB && valorB == valorC)
                            {
                                MessageBox.Show("Triângulo Equilátero");
                            }
                            else
                            {
                                if(valorA == valorB || valorB == valorC || valorA == valorC)
                                {
                                    MessageBox.Show("Triângulo Isósceles");
                                }
                                else
                                {
                                    MessageBox.Show("Triângulo Escaleno");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Triangulo inválido");
                            txtValorA.Clear();
                            txtValorB.Clear();
                            txtValorC.Clear();
                            txtValorA.Focus();
                        }
                    }
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValorA.Clear();
            txtValorB.Clear();
            txtValorC.Clear();
            txtValorA.Focus();
        }
    }
}
