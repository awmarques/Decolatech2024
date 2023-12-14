using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        
        public string NomeCurso { get; set; }

        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        public int ObterQuantidadeDeAlunosMatriculados()
        {
           int quantidade = Alunos.Count;
           return quantidade;
        }
        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            
            for (int i = 0; i < Alunos.Count; i++){
                //string texto = "Nº " + (i+1) + " - " + Alunos[i].NomeCompleto;
                string texto = $"Nº {i+1} - {Alunos[i].NomeCompleto} ";
                Console.WriteLine(texto);
            }
            // foreach (Pessoa aluno in Alunos)
            // {
            //     Console.WriteLine(aluno.NomePessoa);
            // }
        }
    }
}