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
    public partial class FmEmitirCertificado : Form
    {
        public FmEmitirCertificado()
        {
            InitializeComponent();
        }

        // Carrega todos os dados da lista de alunos para o grid
        private void CarregarGridAlunos()
        {
            foreach (Classes.Alunos alunos in Classes.Controle.ListaAlunos)
            {

                dgtalunos.Rows.Add(alunos.Matricula, alunos.Nome, alunos.Curso, alunos.Nota);

            }
        } // fim CarregarGridAlunos()

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dgtalunos.Rows.Clear(); // limpa o grid
            CarregarGridAlunos(); 
        }

        // Emiti o certificado 
        private void btemitircertificado_Click(object sender, EventArgs e)
        {
            int matricula;

            try
            {
                matricula = int.Parse(txtmatricula.Text);

                if (matricula < 0 || !verificarmatricula(matricula))
                {
                    MessageBox.Show("Matricula incorreto ou não existente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CarregarGridALunos(matricula);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Informe uma Matricula.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        } // fim btemitircertificado_Click()

        // Verirfica se a matricula existe na lista
        private bool verificarmatricula(int matricula) {
            bool achou = false;
            foreach (Classes.Alunos alunos in Classes.Controle.ListaAlunos)
            {
                if (alunos.Matricula == matricula)
                {
                    achou = true;
                }
            }
            return achou;
        }

        private void dgtalunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // verifica a nota do aluno e chama o metodo para gerar o certificado
        private void CarregarGridALunos(int matricula)
        {
            dgtalunos.Rows.Clear();
            foreach (Classes.Alunos alunos in Classes.Controle.ListaAlunos)
            {
                if (alunos.Matricula == matricula)
                {
                   dgtalunos.Rows.Add(alunos.Matricula, alunos.Nome, alunos.Curso, alunos.Nota);

                    if (alunos.Nota >= 60)
                    {
                        gerarcertificado(matricula);
                        MessageBox.Show("Certificado foi gerado com sucesso.", "Certificado Emitido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else
                    {
                        MessageBox.Show("Aluno apresenta nota menor que a média.", "Certificado não emitido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
        } // fim CarregarGridALunos(int matricula)

        // botão volrar
        private void btvoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Gera Certificado
        public void gerarcertificado(int matricula)
        {

            StreamWriter escrevercertificadoAluno = new StreamWriter("Certificado.txt"); //abrir o arquivo
            string linha;

            foreach (Classes.Alunos alunos in Classes.Controle.ListaAlunos) {
                if (alunos.Matricula == matricula)
                {
                    linha = "Certificado\n\nCertificamos que o aluno " + alunos.Nome + " participou do curso de " + alunos.Curso + " com o aproveitamento de " + alunos.Nota + " pontos.";
                    escrevercertificadoAluno.WriteLine(linha); //Escreve as informações dos Alunos no arquivo
                }
            }
            escrevercertificadoAluno.Close(); //fecha o arquivo
        }
    } // fim class
}
