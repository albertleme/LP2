using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculaIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            double peso;
            if (!Double.TryParse(txtPeso.Text, out peso))
            {
                MessageBox.Show("Digite um valor válido");
                txtPeso.Focus();
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            double altura;
            if (!Double.TryParse(txtAltura.Text, out altura))
            {
                MessageBox.Show("Digite um valor válido");
                txtAltura.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double peso, altura, imc;

            if (!Double.TryParse(txtPeso.Text, out peso))
            {
                MessageBox.Show("Digite um valor válido");
                txtPeso.Focus();
            }
            else
            {
                if (!Double.TryParse(txtAltura.Text, out altura))
                {
                    MessageBox.Show("Digite um valor válido");
                    txtAltura.Focus();
                }
                else
                {
                    if (altura == 0)
                    {
                        MessageBox.Show("Valor da altura não pode ser 0");
                        txtAltura.Focus();
                    }
                    else
                    {
                        imc = peso / (Math.Pow(altura, 2));
                        txtIMC.Text = imc.ToString("N2");

                        if (imc < 18.5)
                        {
                            MessageBox.Show("IMC menor que 18,5 - Magreza");
                        }
                        else
                        {
                            if (imc <= 24.9)
                            {
                                MessageBox.Show("IMC Entre 18,5 e 24,9 - Normal");
                            }
                            else
                            {
                                if (imc <= 29.9)
                                {
                                    MessageBox.Show("IMC entre 25,0 e 29,9 - Sobrepeso");
                                }
                                else
                                {
                                    if (imc <= 39.9)
                                    {
                                        MessageBox.Show("IMC entre 30,0 e 39,9 - Obesidade");
                                    }
                                    else
                                    {
                                        MessageBox.Show("IMC maior que 40,0 - Obesidade grave");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPeso.Clear();
            txtAltura.Clear();
            txtIMC.Clear();
        }
    }
}
