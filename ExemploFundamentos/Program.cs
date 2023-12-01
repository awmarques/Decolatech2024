// See https://aka.ms/new-console-template for more information
using ExemploFundamentos.Models;

// string apresentacao = "Olá, seja bem vindo!";
// int quantidade = 1;
// double altura = 1.80;
// decimal preco = 1.80M;
// bool condicao = true;




// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variavel quantidade: " + quantidade);
// Console.WriteLine("Valor da variavel altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variavel preco: " + preco);
// Console.WriteLine("Valor da variavel condicao: " + condicao);


DateTime dataAtual = DateTime.Now.AddYears(1000);
Console.WriteLine(dataAtual.ToString("dd/mm/yy hh:mm"));

Pessoa p = new Pessoa();
p.nome = "andrew";
p.idade = 32;

p.Apresentar();