using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSalario
{
    public partial class frmSalario : Form
    {
        double descontoINSS;
        double descontoIRPF;
        double salarioFamilia;

        public frmSalario()
        {
            InitializeComponent();
        }

        private void frmSalario_Load(object sender, EventArgs e)
        {
            cbxNumeroFilhos.SelectedIndex = 0;
        }

        private void btnVerificadorDesconto_Click(object sender, EventArgs e)
        {
            double salarioBruto;
            double salarioLiquido;

            //Alíquota INSS
            if (txtNomeFuncionario.Text == ""){
                MessageBox.Show("Dados inválidos");
                txtNomeFuncionario.Focus();
            }
            else
            {
                if(double.TryParse(mskbxSalarioBruto.Text, out salarioBruto) && salarioBruto == 0){
                    MessageBox.Show("Dados inválidos");
                    mskbxSalarioBruto.Focus();
                }
                else
                {
                    if (salarioBruto <= 800.47)
                    {
                        txtAliquotaINSS.Text = "7,65%";
                        descontoINSS = Math.Round(salarioBruto * 0.0765,2);
                        txtDescontoINSS.Text = "R$" + descontoINSS;
                    }
                    else
                    {
                        if (salarioBruto <= 1050)
                        {
                            txtAliquotaINSS.Text = "8,65%";
                            descontoINSS = Math.Round(salarioBruto * 0.0865,2);
                            txtDescontoINSS.Text = "R$" + descontoINSS;
                        }
                        else
                        {
                            if (salarioBruto <= 1400.77)
                            {
                                txtAliquotaINSS.Text = "9,00%";
                                descontoINSS = Math.Round(salarioBruto * 0.09,2);
                                txtDescontoINSS.Text = "R$" + descontoINSS;
                            }
                            else
                            {
                                if (salarioBruto <= 2801.56)
                                {
                                    txtAliquotaINSS.Text = "11,00%";
                                    descontoINSS = Math.Round(salarioBruto * 0.11,2);
                                    txtDescontoINSS.Text = "R$" + descontoINSS;
                                }
                                else
                                {
                                    txtAliquotaINSS.Text = "R$308,17";
                                    descontoINSS = 308.17;
                                    txtDescontoINSS.Text = "R$" + descontoINSS;
                                }
                            }
                        }
                    }
                }
            }

            //Alíquota IRPF
            if (double.TryParse(mskbxSalarioBruto.Text, out salarioBruto) && salarioBruto == 0 || txtNomeFuncionario.Text == "")
            {
                //MessageBox.Show("Dados inválidos");
                mskbxSalarioBruto.Focus();
            }
            else
            {
                if (salarioBruto <= 1257.12)
                {
                    txtAliquotaIRPF.Text = "0%";
                    descontoIRPF = 0.00;
                    txtDescontoIRPF.Text = "R$" + descontoIRPF;
                }
                else
                {
                    if (salarioBruto <= 2512.08)
                    {
                        txtAliquotaIRPF.Text = "15,00%";
                        descontoIRPF = Math.Round(salarioBruto * 0.15,2);
                        txtDescontoIRPF.Text = "R$" + descontoIRPF;
                    }
                    else
                    {
                        txtAliquotaIRPF.Text = "27,50%";
                        descontoIRPF = Math.Round(salarioBruto * 0.275,2);
                        txtDescontoIRPF.Text = "R$" + descontoIRPF;
                    }
                }
            }

            //Salário Família
            if (double.TryParse(mskbxSalarioBruto.Text, out salarioBruto) && salarioBruto == 0 || txtNomeFuncionario.Text == "")
            {
                //MessageBox.Show("Dados inválidos");
                mskbxSalarioBruto.Focus();
            }
            else
            {
                if (salarioBruto <= 435.52)
                {
                    salarioFamilia = Math.Round(cbxNumeroFilhos.SelectedIndex * 22.33,2);
                    txtSalarioFamilia.Text = "R$"+salarioFamilia;
                }
                else
                {
                    if (salarioBruto <= 654.61)
                    {
                        salarioFamilia = Math.Round(cbxNumeroFilhos.SelectedIndex * 15.74,2);
                        txtSalarioFamilia.Text = "R$" + salarioFamilia;
                    }
                    else
                    {
                        salarioFamilia = 0;
                        txtSalarioFamilia.Text = "R$0";
                    }
                }
            }

            //Cálculo salário líquido
            if (double.TryParse(mskbxSalarioBruto.Text, out salarioBruto) && salarioBruto == 0 || txtNomeFuncionario.Text == "")
            {
                //MessageBox.Show("Dados inválidos");
                mskbxSalarioBruto.Focus();
            }
            else
            {
                salarioLiquido = salarioBruto - descontoINSS - descontoIRPF + salarioFamilia;
                txtSalarioLiquido.Text = "R$" + salarioLiquido;
            }

            if (double.TryParse(mskbxSalarioBruto.Text, out salarioBruto) && salarioBruto == 0 || txtNomeFuncionario.Text == "")
            {
                //MessageBox.Show("Dados inválidos");
                mskbxSalarioBruto.Focus();
            }
            else
            {
                if (rbtnSexoM.Checked)
                {
                    if (ckbxCasado.Checked)
                    {
                        lblDados.Text = "Os descontos do salário do Sr. " + txtNomeFuncionario.Text + " que é casado e que tem " + cbxNumeroFilhos.SelectedIndex + " filho(s) são";
                    }
                    else
                    {
                        lblDados.Text = "Os descontos do salário do Sr. " + txtNomeFuncionario.Text + " que é solteiro e que tem " + cbxNumeroFilhos.SelectedIndex + " filho(s) são";
                    }
                }
                else
                {
                    if (ckbxCasado.Checked)
                    {
                        lblDados.Text = "Os descontos do salário da Sra. " + txtNomeFuncionario.Text + " que é casada e que tem " + cbxNumeroFilhos.SelectedIndex + " filho(s) são";
                    }
                    else
                    {
                        lblDados.Text = "Os descontos do salário da Sra. " + txtNomeFuncionario.Text + " que é solteira e que tem " + cbxNumeroFilhos.SelectedIndex + " filho(s) são";
                    }
                }
            }
        }

        private void mskbxSalarioBruto_Validated(object sender, EventArgs e)
        {

        }
    }
}
