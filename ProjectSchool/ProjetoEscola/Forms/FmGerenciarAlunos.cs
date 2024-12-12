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
    public partial class FmGerenciarAlunos : Form
    {
        public FmGerenciarAlunos()
        {
            InitializeComponent();
        }

        // Carrega os dados da lista de alunos no grid
        private void CarregarGridAlunos()
        {
            foreach (Classes.Alunos alunos in Classes.Controle.ListaAlunos)
            {

                dgtalunos.Rows.Add(alunos.Matricula, alunos.Nome, alunos.Curso, alunos.Nota);

            }
        } // fim CarregarGridAlunos()
 
        // Exibi todos os dados dos alunos no grid
        private void rbtodosalunos_CheckedChanged(object sender, EventArgs e)
        {
            dgtalunos.Rows.Clear();
            CarregarGridAlunos();
        }

        private void dgtalunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // botão Pesquisar por nome na lista de alunos 
        private void btpesquisarnome_Click(object sender, EventArgs e)
        {
           string nome;

            nome = txtnome.Text;

            if (nome == "" || !CarregarGridALunos(nome))
            {
                MessageBox.Show("Nome incorreto ou não existente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CarregarGridALunos(nome);
            }
        } // fim btpesquisarnome

        // Verifica de o Aluno pesquisado existe
        private bool CarregarGridALunos(string nome)
        {
            bool achou = false;
            dgtalunos.Rows.Clear();
            foreach (Classes.Alunos alunos in Classes.Controle.ListaAlunos)
            {
                if (alunos.Nome == nome)
                {
                    achou = true;
                    dgtalunos.Rows.Add(alunos.Matricula, alunos.Nome, alunos.Curso, alunos.Nota);
                }
            }
            return achou;
        }

        private void txtpesquisarcurso_TextChanged(object sender, EventArgs e)
        {

        }

        // botão Pesquisar por curso na lista de alunos
        private void btpesquisarcurso_Click(object sender, EventArgs e)
        {
            string curso;

            curso = txtpesquisarcurso.Text;

            if (curso == "" || !pesquisarcurso(curso))
            {
                MessageBox.Show("Curso incorreto ou não existente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pesquisarcurso(curso);
            }
        }

        // Pesquisar por nome na lista de alunos
        private bool pesquisarcurso(string curso)
        {
            bool achou = false;
            dgtalunos.Rows.Clear();
            foreach (Classes.Alunos alunos in Classes.Controle.ListaAlunos)
            {
                if (alunos.Curso == curso)
                {
                    achou = true;
                    dgtalunos.Rows.Add(alunos.Matricula, alunos.Nome, alunos.Curso, alunos.Nota);
                }
            }
            return achou;
        }

        // botão voltar
        private void btvoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Excluir um aluno da lista 
        private void btexcluiraluno_Click(object sender, EventArgs e)
        {
            int matricula;

            bool achou = false;

            try
            {
                if (txtexcluiraluno.Text == "")
                { // Verifica se os campos estão inseridos corretamente
                    MessageBox.Show("Insira todos os dados necessários corretamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    matricula = int.Parse(txtexcluiraluno.Text);

                    foreach (Classes.Alunos alunos in Classes.Controle.ListaAlunos.ToList())
                    { // Percorre a lista de Alunos
                        if (alunos.Matricula == matricula)
                        {
                            achou = true;
                            Classes.Controle.ListaAlunos.Remove(alunos);
                            dgtalunos.Rows.Clear(); //Limpa o grid
                            CarregarGridAlunos();
                            LimparCampos(); //Limpa os campos
                            MessageBox.Show("Aluno excluido com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    } // fim foreach
                    if (achou == false) MessageBox.Show("Registro de aluno não encontrado, verifique e tente novamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } // fim else
            }
            catch (NullReferenceException)
            { //Exceção para caso não ache o aluno
                MessageBox.Show("Registro de aluno não encontrado, verifique e tente novamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // limpa os campos do quandro de texto excluir alunos 
        private void LimparCampos()
        {
            txtexcluiraluno.Clear();
        }

        // edita e atualiza as notas dos alunos
        private void btatualizarNota_Click(object sender, EventArgs e)
        {
            FmAtualizarNota atualizarnota = new FmAtualizarNota();
            atualizarnota.ShowDialog();
            dgtalunos.Rows.Clear();
            CarregarGridAlunos();
        }
    }  // fim class
}
