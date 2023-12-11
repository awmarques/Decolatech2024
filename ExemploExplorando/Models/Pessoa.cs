using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        private string _nome;


        public string nomePessoa 
        { 
            get => _nome.ToUpper();
            //expressao acima faz a mesma coisa que o get com chaves abaixo
            /*get
            {
                return _nome.ToUpper();
            } */

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio!");
                }
                _nome=value;
            } 
        }
        private int _idade;
        public int idadePessoa { 
            get => _idade;
            set
            {
                if (value < 0){
                    throw new ArgumentOutOfRangeException("Idade inválida");
                }
                _idade = value;
            }
        }

        public void Apresentar (){
            Console.WriteLine($"Olá, sou uma Pessoa. Meu nome é: {nomePessoa} e tenho {idadePessoa} anos de idade!");

        }
    }
}