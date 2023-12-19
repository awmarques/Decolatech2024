// // See https://aka.ms/new-console-template for more information
using ExemploPOO.Models;
// Console.WriteLine("Hello, World!");

// Pessoa p1 = new Pessoa();
// p1.Nome = "joao";
// p1.Idade = 1;
// p1.Apresentar();

ContaCorrente c1 = new ContaCorrente(10,100);
c1.ExibirSaldo();
c1.Sacar(10000);
c1.ExibirSaldo();