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
    using System.Collections;
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            ArrayList alunos = new ArrayList();

            alunos.Add("Ana");
            alunos.Add("André");
            alunos.Add("Débora");
            alunos.Add("Fátima");
            alunos.Add("João");
            alunos.Add("Janete");
            alunos.Add("Otávio");
            alunos.Add("Marcelo");
            alunos.Add("Pedro");
            alunos.Add("Thais");

            alunos.Remove("Otávio");

            for(var i = 0; i < alunos.Count; i++)
            {
                Console.WriteLine(" " + alunos[i]);
            }

        }
    }
}
