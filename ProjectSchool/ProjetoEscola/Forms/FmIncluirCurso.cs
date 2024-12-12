using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjetoEscola.Forms
{
    public partial class FmIncluirCurso : Form
    {
        public FmIncluirCurso()
        {
            InitializeComponent();
        }

        private void txtnomecurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttarefas_TextChanged(object sender, EventArgs e)
        {

        }

        // Limpa os campos 
        private void LimparCampos()
        {
            txtnomecurso.Clear();
            txttarefas.Clear();
        }

        // Botao para incluir cursos
        private void btcadastrarcurso_Click(object sender, EventArgs e)
        {
            string nome, tarefas;
            Classes.Cursos resultadocurso = null;

            if (txtnomecurso.Text == "" || txttarefas.Text == "")
            { //Verifica se os campos foram inseridos corretamente
                MessageBox.Show("Insira todos os dados necessários corretamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    nome = txtnomecurso.Text;
                    tarefas = txttarefas.Text;

                    resultadocurso = Classes.Controle.ListaCursos.Find(x => x.Nome == nome); // Verifica se o curso já existe

                    if (resultadocurso == null)
                    {
                        Classes.Cursos curso = new Classes.Cursos(nome, tarefas); // Cadastrar novo curso
                        Classes.Controle.ListaCursos.Add(curso); // Adiciona o curso na lista
                        LimparCampos();
                        MessageBox.Show("Curso criado com sucesso.\n\n|----------------Dados----------------|\nNome: " + nome + "\nTarefa: " + tarefas, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Curso já cadastrado no sistema.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            } // fim else
            Close();
        } // fim btcadastrarcurso_Click()
    } // fim class
}
