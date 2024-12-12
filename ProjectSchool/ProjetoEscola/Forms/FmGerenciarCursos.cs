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
    public partial class FmGerenciarCursos : Form
    {
        public FmGerenciarCursos()
        {
            InitializeComponent();
        }

        // Carrega os dados dos Cursos no grid
        private void CarregarGridCursos()
        {
            foreach (Classes.Cursos cursos in Classes.Controle.ListaCursos)
            {

                dgtcarregarcursos.Rows.Add(cursos.Nome, cursos.Tarefas);

            }
        } // fim CarregarGridCursos()
 
        private void dgtcarregarcursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
       
        // exibi os dados de todos os cursos cadastrados
        private void rbtodoscursos_CheckedChanged(object sender, EventArgs e)
        {
            dgtcarregarcursos.Rows.Clear();
            CarregarGridCursos();
        }

        // botao de pesquisar para localizar um curso        
        private void btpesquisar_Click(object sender, EventArgs e)
        {
            string nome;

            nome = txcurso.Text;

            if (nome == "" || !CarregarGridCursos(nome))
            {
                MessageBox.Show("Curso incorreto ou não existente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                CarregarGridCursos(nome);
            }
        }

        private void txcurso_TextChanged(object sender, EventArgs e)
        {

        }

        // Verifica de o curso está cadastrado no sistema
        private bool CarregarGridCursos(string nome)
        {
            bool achou = false;
            dgtcarregarcursos.Rows.Clear();
            foreach (Classes.Cursos cursos in Classes.Controle.ListaCursos)
            {
                if (cursos.Nome == nome)
                {
                    achou = true;
                    dgtcarregarcursos.Rows.Add(cursos.Nome, cursos.Tarefas);
                }
            }
            return achou;
        }

        // botao voltar
        private void btvoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        // botao para excluir um curso da lista
        private void btexcluir_Click(object sender, EventArgs e)
        {
            string cursos1;

            bool achou = false;

            try
            {
                if (txtexcluir.Text == "") { // Verifica se os campos estão inseridos corretamente
                    MessageBox.Show("Insira todos os dados necessários corretamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    cursos1 = txtexcluir.Text;

                    foreach (Classes.Cursos cursos in Classes.Controle.ListaCursos.ToList()) { // Percorre a lista de cursos
                        if (cursos.Nome == cursos1) {
                            achou = true;
                            Classes.Controle.ListaCursos.Remove(cursos);
                            dgtcarregarcursos.Rows.Clear(); //Limpa o grid
                            CarregarGridCursos();
                            LimparCampos(); //Limpa os campos
                            MessageBox.Show("Curso excluido com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }                   
                    } // fim foreach
                    if (achou == false) MessageBox.Show("Registro de curso não encontrado, verifique e tente novamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } // fim else
            }
            catch (NullReferenceException)
            { //Exceção para caso não ache o Curso
                MessageBox.Show("Registro de curso não encontrado, verifique e tente novamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } // fim

        private void txtexcluir_TextChanged(object sender, EventArgs e)
        {
        }

        // limpa campos do campo excluir
        private void LimparCampos()
        {
            txtexcluir.Clear();
        }
    } // fim class
}

    