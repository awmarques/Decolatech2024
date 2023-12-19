using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente (int numeroConta, decimal saldoInicial){
            Numero = numeroConta;
            saldo = saldoInicial;
        }

        public int Numero { get; set; }
        private decimal saldo;

        public void Sacar(decimal valor){
            if (saldo >= valor){
                saldo -= valor;
                Console.WriteLine("Saldo realizado com sucesso!");
            } else {
                Console.WriteLine("Valor do saque maior que o saldo.");
            }
        }

        public void ExibirSaldo (){
            Console.WriteLine($"Seu saldo disponível é: {saldo}");
        }
    }
}