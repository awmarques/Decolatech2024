using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        public string nomePessoa { get; set; }
        public int idadePessoa { get; set; }

        public void Apresentar (){
            Console.WriteLine($"Olá, sou uma Pessoa. Meu nome é: {nomePessoa} e tenho {idadePessoa} anos de idade!");

        }
    }
}