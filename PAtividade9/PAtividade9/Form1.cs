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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["Exercicio1"];
            if (fc != null)
                fc.Close();
            frmExercicio1 frm1 = new frmExercicio1();
            frm1.MdiParent = this;
            frm1.WindowState = FormWindowState.Maximized;
            frm1.Show();
        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["Exercicio2"];
            if (fc != null)
                fc.Close();
            frmExercicio2 frm2 = new frmExercicio2();
            frm2.MdiParent = this;
            frm2.WindowState = FormWindowState.Maximized;
            frm2.Show();
        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["Exercicio3"];
            if (fc != null)
                fc.Close();
            frmExercicio3 frm3 = new frmExercicio3();
            frm3.MdiParent = this;
            frm3.WindowState = FormWindowState.Maximized;
            frm3.Show();
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["Exercicio4"];
            if (fc != null)
                fc.Close();
            frmExercicio4 frm4 = new frmExercicio4();
            frm4.MdiParent = this;
            frm4.WindowState = FormWindowState.Maximized;
            frm4.Show();
        }

        private void exercício5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["Exercicio5"];
            if (fc != null)
                fc.Close();
            frmExercicio5 frm5 = new frmExercicio5();
            frm5.MdiParent = this;
            frm5.WindowState = FormWindowState.Maximized;
            frm5.Show();
        }
    }
}
