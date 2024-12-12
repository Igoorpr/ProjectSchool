using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjetoEscola.Classes
{
    class Controle
    {
        public static List<Alunos> ListaAlunos = new List<Alunos>();
        public static List<Cursos> ListaCursos = new List<Cursos>();

        // Verifica se os arquivos existem, caso falta algum ele cria antes do form iniciar
        public static void VerificarArquivos() {

            // Caso algum arquivo não tenha sido criado, ele cria.
            if (!File.Exists("alunos.txt") || !File.Exists("cursos.txt")) { 
                if (!File.Exists("alunos.txt"))
                {
                    FileStream fs = File.Create("alunos.txt");
                    fs.Close();
                }
                if (!File.Exists("cursos.txt"))
                {
                    FileStream fs = File.Create("cursos.txt");
                    fs.Close();
                }
                MessageBox.Show("Um ou mais arquivos estão faltando.\nOs arquivos que estão faltando foram criados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        } // fim VerificarArquivos()

        // Lê os dados do Arquivo Alunos
        public static void leArquivosAlunos() {

            StreamReader lerAlunos = new StreamReader("alunos.txt"); // abre o arquivo                          

            string linhaAlunos;     
            string[] auxSeparador;  // separar dados de cada linha por strings

            Alunos aluno;

            // dados dos alunos
            int matricula;
            string nome, curso;
            double nota;

            linhaAlunos = lerAlunos.ReadLine(); // faz a primeira leitura (1a linha)

            // enquanto houver informações..
            while (linhaAlunos != null)
            {
                // separa a string linha em um vetor de varias strings (separadas pelo ';')
                auxSeparador = linhaAlunos.Split(';'); 

                matricula = int.Parse(auxSeparador[0]);
                nome = auxSeparador[1];
                curso = auxSeparador[2];
                nota = double.Parse(auxSeparador[3]);

                aluno = new Alunos (matricula, nome, curso, nota); // Cria um Aluno

                Controle.ListaAlunos.Add(aluno); // Adiciona o Aluno na lista de Alunos   
                linhaAlunos = lerAlunos.ReadLine();
            } // fim while
            lerAlunos.Close(); // fecha o arquivo               
        } // fim leArquivosAlunos()

        // Lê os dados do Arquivo Cursos com suas tarefas
        public static void leArquivosCursos() {

            StreamReader lerCursos = new StreamReader("cursos.txt"); // abre o arquivo                          

            string linhaCursos;    
            string[] auxSeparador;  //separar dados de cada linha por strings

            Cursos cursos;

            // dados dos cursos
            string nome, tarefas;

            linhaCursos = lerCursos.ReadLine(); // faz a primeira leitura (1a linha)

            // enquanto houver informações..
            while (linhaCursos != null)
            {
                // separa a string linha em um vetor de varias strings (separadas pelo ';')
                auxSeparador = linhaCursos.Split(';'); 

                nome = auxSeparador[0];
                tarefas = auxSeparador[1];
            
                cursos = new Cursos (nome, tarefas); // Cria um Curso

                Controle.ListaCursos.Add(cursos); // Adiciona o Curso e as taredas na lista de cursos   
                linhaCursos = lerCursos.ReadLine();
            } // fim while
            lerCursos.Close(); // fecha o arquivo               
        } // fim leArquivosCursos()

        // Gravar Dados nos Arquivos
        public static void gravarArquivos() {
            StreamWriter escreverAluno = new StreamWriter("alunos.txt"); //abre o arquivo
            StreamWriter escreverCursos = new StreamWriter("cursos.txt"); //abre o arquivo           
 
            string linha;

            foreach (Alunos alunos in Controle.ListaAlunos)
            { // Percorre a lista de Alunos
                linha = alunos.Matricula + ";" + alunos.Nome + ";" + alunos.Curso + ";" + alunos.Nota;
                escreverAluno.WriteLine(linha); //Escreve as informações dos Alunos no arquivo
            }
                foreach (Cursos curso in Controle.ListaCursos) { // Percorre a lista de cursos
                    linha = curso.Nome + ";" + curso.Tarefas;
                    escreverCursos.WriteLine(linha); //Escreve as informações dos cursos no arquivo
                }
            escreverAluno.Close(); //fecha o arquivo
            escreverCursos.Close(); //fecha o arquivo                      
        } // fim gravarArquivos()
    } // fim classe Controle
}
