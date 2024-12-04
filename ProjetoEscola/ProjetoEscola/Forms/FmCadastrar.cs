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
    public partial class FmCadastrar : Form
    {
        public FmCadastrar()
        {
            InitializeComponent();
        }

        private void CadastrarAluno_Load(object sender, EventArgs e)
        {


        }

        // Chama o form para inserir o aluno na lista
        private void btCadastrarAlunos_Click(object sender, EventArgs e)
        {
           FmIncluirAluno incluiraluno = new FmIncluirAluno();
           incluiraluno.ShowDialog();
        }

        // Chama o form para inserir o curso na lista
        private void btCadastrarCursos_Click(object sender, EventArgs e)
        {
            FmIncluirCurso incluircurso = new FmIncluirCurso();
            incluircurso.ShowDialog();
        }
    } // fim class
}