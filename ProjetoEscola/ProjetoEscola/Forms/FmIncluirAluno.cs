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
    public partial class FmIncluirAluno : Form
    {
        public FmIncluirAluno()
        {
            InitializeComponent();
            ComboboxCursos(); // carrega todos os cursos cadastrados no combobox
        }

        private void txtmatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnota_TextChanged(object sender, EventArgs e)
        {

        }
       
        // limpa os campos matricula e nome
        private void LimparCampos()
        {
            txtmatricula.Clear();
            txtnome.Clear();
        }

        // botao cadastrar aluno
        private void btcadastraraluno_Click(object sender, EventArgs e)
        {
            int matricula;
            string nome, curso;
            double nota;

            Classes.Alunos resultadoAlunos = null;

            if (txtmatricula.Text == "" || txtnome.Text == "")
            { //Verifica se os campos foram inseridos corretamente
                MessageBox.Show("Insira todos os dados necessários corretamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    matricula = int.Parse(txtmatricula.Text);
                    nome = txtnome.Text;
                    curso = cbcurso.Text;
                    nota = 0;

                    resultadoAlunos = Classes.Controle.ListaAlunos.Find(x => x.Matricula == matricula); // Verifica se o aluno já existe

                    if (resultadoAlunos == null)
                    {
                        Classes.Alunos alunos = new Classes.Alunos(matricula, nome, curso, nota); // Cadastrar novo aluno
                        Classes.Controle.ListaAlunos.Add(alunos); // Adiciona o aluno na lista
                        LimparCampos();
                        MessageBox.Show("Aluno criado com sucesso.\n\n|----------------Dados----------------|\nMatricula: " + matricula + "\nNome: " + nome + "\nCurso: " + curso + "\nNota: " + nota, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Aluno já cadastrado no sistema.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (FormatException)
                { //Caso algum valor seja inserido incorretamente
                    MessageBox.Show("Insira apenas valores válidos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                { //Caso algum erro inesperado ocorra o programa não irá interromper
                    MessageBox.Show("Ocorreu um erro inesperado.\n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Close();
            } // fim else
        }

        // botao gerar matricula
        private void btgerarmatricula_Click(object sender, EventArgs e)
        {
            GerarmatriculaRandom();
        }

        // Gera uma matricula random disponivel
        private void GerarmatriculaRandom()
        { 
            Random randNum = new Random();
            Classes.Alunos aluno1;

            int matricula = 000;

            do
            {
                aluno1 = null;
                matricula = 000;

                for (int i = 0; i < 3; i++)
                {
                    matricula += randNum.Next(0, 9);
                }

                foreach (Classes.Alunos alunos in Classes.Controle.ListaAlunos)
                {
                    aluno1 = Classes.Controle.ListaAlunos.Find(x => x.Matricula == matricula);
                }

            } while (aluno1 != null);

            txtmatricula.Text = matricula.ToString();
      
        } // fim GerarmatriculaRandom()

        // carrega todos os cursos cadastrados no combobox
        public void ComboboxCursos()
        {
            cbcurso.Items.Clear();

            foreach (Classes.Cursos curso in Classes.Controle.ListaCursos)
            {
                cbcurso.Items.Add(curso.Nome);
            }
        }

        private void cbcurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    } // fim class
}