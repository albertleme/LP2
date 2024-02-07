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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        //Botão de Execução da opção SAIR
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Opção COPIAR do Exercício 2
        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teclou CTRL + C");
        }

        //Opção COLAR do Exercício 2
        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teclou CTRL + V");
        }

        //Botão de execução do EXERCÍCIO 2
        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio2"];
            if (fc != null)
                fc.Close();
            FrmExercicio2 frm2 = new FrmExercicio2(); //Criação de objeto
            frm2.MdiParent = this;
            frm2.WindowState = FormWindowState.Maximized;
            frm2.Show();
        }

        //Botão de execução do EXERCÍCIO 3
        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio3"];
            if (fc != null)
                fc.Close();
            FrmExercicio3 frm3 = new FrmExercicio3(); //Criação de objeto
            frm3.MdiParent = this;
            frm3.WindowState = FormWindowState.Maximized;
            frm3.Show();
        }

        //Botão de execução do EXERCÍCIO 4
        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio4"];
            if (fc != null)
                fc.Close();
            FrmExercicio4 frm4 = new FrmExercicio4(); //Criação de objeto
            frm4.MdiParent = this;
            frm4.WindowState = FormWindowState.Maximized;
            frm4.Show();
        }

        //Botão de execução do EXERCÍCIO 5
        private void exercício5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio5"];
            if (fc != null)
                fc.Close();
            FrmExercicio5 frm5 = new FrmExercicio5(); //Criação de objeto
            frm5.MdiParent = this;
            frm5.WindowState = FormWindowState.Maximized;
            frm5.Show();
        }
    }
}
