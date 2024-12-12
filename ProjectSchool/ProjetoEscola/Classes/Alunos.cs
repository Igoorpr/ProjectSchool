using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola.Classes
{
    class Alunos
    {
        // Atributos
        private int matricula;
        private string nome;
        private string curso;
        private double nota;

        // Construtor
        public Alunos (int matricula, string nome, string curso, double nota) {
            Matricula = matricula;
            Nome = nome;
            Curso = curso;
            Nota = nota;
        }

        // Getters e setters

        public int Matricula
        {
            get
            {
                return matricula;
            }

            set
            {
                matricula = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Curso
        {
            get
            {
                return curso;
            }

            set
            {
                curso = value;
            }
        }

        public double Nota
        {
            get
            {
                return nota;
            }

            set
            {
                nota = value;
            }
        }
    } // fim classe Alunos
}
