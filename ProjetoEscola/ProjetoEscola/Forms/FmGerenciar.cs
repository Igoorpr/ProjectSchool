using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEscola.Forms
{
    public partial class FmGerenciar : Form
    {
        public FmGerenciar()
        {
            InitializeComponent();
        }

        // Chama o form para gerenciar os alunos
        private void btAlunos_Click(object sender, EventArgs e)
        {
            FmGerenciarAlunos fmalunos = new FmGerenciarAlunos();
            fmalunos.ShowDialog();
        }

        // Chama o form para gerenciar os cursos
        private void bnExcluirCursos_Click(object sender, EventArgs e)
        {
            FmGerenciarCursos fmcursos = new FmGerenciarCursos();
            fmcursos.ShowDialog();
        }
    }
}
