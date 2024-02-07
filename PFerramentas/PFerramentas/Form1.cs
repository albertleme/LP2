using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace PFerramentas
{
    public partial class Form1 : Form
    {
        public static SqlConnection conexao;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source=Apolo;Initial Catalog=LP2;User ID=BD2013011; Password=camila*otaria123");
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados =/" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Outros erros =/" + ex.Message);
            }
        }

        private void caixaDeFerramentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FrmFerramentas"];
            if (fc != null)
                fc.Close();
            FrmFerramentas frm1 = new FrmFerramentas();
            frm1.MdiParent = this;
            frm1.WindowState = FormWindowState.Maximized;
            frm1.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmSobre"];
            if (fc != null)
                fc.Close();
            frmSobre frm1 = new frmSobre();
            frm1.MdiParent = this;
            frm1.WindowState = FormWindowState.Maximized;
            frm1.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
