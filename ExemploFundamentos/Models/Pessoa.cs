using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }


        public void Apresentar()
        {
            Console.WriteLine ($"Olá, meu nome é: {nome} \n Tenho {idade} anos");

        }
    }
}