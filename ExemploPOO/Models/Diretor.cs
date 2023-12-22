using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public sealed class Diretor : Pessoa
    {
        public override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é: {Nome} tenho {Idade} anos e sou um Diretor");
        }
    }
}