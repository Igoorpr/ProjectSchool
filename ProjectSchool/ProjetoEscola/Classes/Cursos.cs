using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola.Classes
{
    class Cursos
    {
        // Atributos
        private string nome;
        private string tarefas;

        // Construtor
        public Cursos(string nome, string tarefas)
        {
            Nome = nome;
            Tarefas = tarefas;
        }

        // Getters e setters

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

        public string Tarefas
        {
            get
            {
                return tarefas;
            }

            set
            {
                tarefas = value;
            }
        }
    } // fim classe Cursos
} 
 