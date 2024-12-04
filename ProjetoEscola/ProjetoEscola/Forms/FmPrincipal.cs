using ProjetoEscola.Forms;
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

namespace ProjetoEscola
{
    public partial class FmPrincipal : Form
    {
        public FmPrincipal()
        {
            InitializeComponent();
            Classes.Controle.VerificarArquivos(); // Verifica os arquivos para que realize a leitura corretamente
            Classes.Controle.leArquivosAlunos(); // Le os arquivos na propria inicialização do sistema
            Classes.Controle.leArquivosCursos(); // Le os arquivos na propria inicialização do sistema
        } 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // botao cadastrar aluno ou curso
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            FmCadastrar fmcadastrar = new FmCadastrar();
            fmcadastrar.ShowDialog();
        }

        // botao gerenciar
        private void btgerenciar_Click(object sender, EventArgs e)
        {
            FmGerenciar fmgerenciar = new FmGerenciar();
            fmgerenciar.ShowDialog();
        }

        // botao emitir certificado
        private void btemitircertificado_Click(object sender, EventArgs e)
        {
            FmEmitirCertificado emitircertificado = new FmEmitirCertificado();
            emitircertificado.ShowDialog();
        }

        // botao salvar, para atualizar os dados no arquivo txt
        private void btsalvar_Click(object sender, EventArgs e)
        {
            Classes.Controle.gravarArquivos(); // Grava as informações nos arquivos antes de sair
            MessageBox.Show("Arquivos salvos com sucesso.\n", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Fecha o programa
        }
    } // fim class
}