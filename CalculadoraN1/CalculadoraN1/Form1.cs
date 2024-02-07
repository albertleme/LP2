using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraN1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Botão fechar
        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Validação Número 1
        private void textBox1_Validated(object sender, EventArgs e)
        {
            double numero1;

            if(!Double.TryParse(textBox1.Text, out numero1))
            {
                MessageBox.Show("Digite um valor válido");
                //textBox1.Focus();
            }
        }

        //Validação Número 2
        private void textBox2_Validated(object sender, EventArgs e)
        {
            double numero2;

            if(!Double.TryParse(textBox2.Text, out numero2))
            {
                MessageBox.Show("Digite um valor válido");
                //textBox2.Focus();
            }
        }

        //Botão adição
        private void button1_Click(object sender, EventArgs e)
        {
            double numero1;

            if (!Double.TryParse(textBox1.Text, out numero1))
            {
                MessageBox.Show("Digite um valor válido");
                textBox1.Focus();
            }
            else
            {
                double numero2;

                if (!Double.TryParse(textBox2.Text, out numero2))
                {
                    MessageBox.Show("Digite um valor válido");
                    textBox2.Focus();
                }
                else
                {
                    double resultado;

                    resultado = numero1 + numero2;

                    textBox3.Text = resultado.ToString();
                }
            }
        }

        //Botão subtração
        private void button2_Click(object sender, EventArgs e)
        {
            double numero1;

            if (!Double.TryParse(textBox1.Text, out numero1))
            {
                MessageBox.Show("Digite um valor válido");
                textBox1.Focus();
            }
            else
            {
                double numero2;

                if (!Double.TryParse(textBox2.Text, out numero2))
                {
                    MessageBox.Show("Digite um valor válido");
                    textBox2.Focus();
                }
                else
                {
                    double resultado;

                    resultado = numero1 - numero2;

                    textBox3.Text = resultado.ToString();
                }
            }
        }

        //Botão multiplicação
        private void button3_Click(object sender, EventArgs e)
        {
            double numero1;

            if (!Double.TryParse(textBox1.Text, out numero1))
            {
                MessageBox.Show("Digite um valor válido");
                textBox1.Focus();
            }
            else
            {
                double numero2;

                if (!Double.TryParse(textBox2.Text, out numero2))
                {
                    MessageBox.Show("Digite um valor válido");
                    textBox2.Focus();
                }
                else
                {
                    double resultado;

                    resultado = numero1 * numero2;

                    textBox3.Text = resultado.ToString();
                }
            }
        }

        //Botão divisão
        private void button4_Click(object sender, EventArgs e)
        {
            double numero1;

            if (!Double.TryParse(textBox1.Text, out numero1))
            {
                MessageBox.Show("Digite um valor válido");
                textBox1.Focus();
            }
            else
            {
                double numero2;

                if (!Double.TryParse(textBox2.Text, out numero2))
                {
                    MessageBox.Show("Digite um valor válido");
                    textBox2.Focus();
                }
                else
                {
                    if(numero2 == 0)
                    {
                        MessageBox.Show("O divisor não pode ser 0");
                        textBox2.Focus();
                    }
                    else
                    {
                        double resultado;

                        resultado = numero1 / numero2;

                        textBox3.Text = resultado.ToString();
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Botão Limpar
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
