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
    public partial class FmAtualizarNota : Form
    {
        public FmAtualizarNota()
        {
            InitializeComponent();
        }

        // Botão de voltar
        private void btvoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Botão de atualizar nota
        private void btatualizarnota_Click(object sender, EventArgs e)
        {
            int matricula, nota;

            bool achou = false;

            try
            {
                matricula = int.Parse(txtmatricula.Text);
                nota = int.Parse(txtnota.Text);

                if (txtmatricula.Text == "" || txtnota.Text == "" || nota < 0 || nota > 100)
                { // Verifica se os campos estão inseridos corretamente
                    MessageBox.Show("Insira todos os dados necessários corretamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (Classes.Alunos alunos in Classes.Controle.ListaAlunos.ToList())
                    { // Percorre a lista de Alunos
                        if (alunos.Matricula == matricula)
                        {
                            achou = true;
                            alunos.Nota = nota;
                            MessageBox.Show("Nota atualizada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                    } // fim foreach
                        if (achou == false) MessageBox.Show("Registro de aluno não encontrado, verifique e tente novamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } // fim else
            }
            catch (Exception)
            { //Exceção para caso não ache o aluno
                MessageBox.Show("Informe todos os dados e tente novamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } //fim btatualizarnota_Click 
    } // fim classe
}