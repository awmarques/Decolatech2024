// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
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


// DateTime dataAtual = DateTime.Now.AddYears(1000);
// Console.WriteLine(dataAtual.ToString("dd/mm/yy hh:mm"));

// Pessoa p = new Pessoa();
// p.nome = "andrew";
//  p.idade = 32;

// int a = 1;
// int b = 2;
// int c = a + b;

// c = c +5;
// c +=5;

// Console.WriteLine(c);

// p.Apresentar();


//conversao variaveis -> Cast
// converte um tipo para outro
//operacao que apresenta um certo risco
//porque se o valor da variavel aser convertido for //invalido
// Convert trata nulo e atribui zero
//Parse não aceita nulo e da erro no programa
// String a = "55555";
// int b = Convert.ToInt32(a);
// Console.WriteLine(b);

// string teste = "132";
// int top = int.Parse(teste);
// Console.WriteLine(top);
// // cast inteiro para string
// int x = 123453;
// String texto = x.ToString();
// Console.WriteLine(texto);
// texto = Convert.ToString(x);
// Console.WriteLine(texto.ToString());
// Console.WriteLine(texto);

//cast implicito
//overflow exception
// long a = long.MaxValue;
// int b  = Convert.ToInt32(a);
// Console.WriteLine("tatata" + b);

// String texto = "123 -a";
// int b=10;
// int.TryParse(texto, out b);
// Console.WriteLine("" + texto);




// int quantidadadeEmEstoque = 10;
// int quantidadeCompra = 0;

// bool possivelVenda = quantidadeCompra > 0 && quantidadadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadadeEmEstoque}");
// Console.WriteLine($"Quantidade compra:{quantidadeCompra}");
// Console.WriteLine($"É possível realizar venda? {possivelVenda}");

// if (quantidadeCompra==0){
//     Console.WriteLine("Quantidade invalida.");

// } else if(possivelVenda){
//     Console.WriteLine("Venda realizada.");
// } else {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada.");
// }



// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u") {
//     Console.WriteLine("Vogal");
// } else {
//     Console.WriteLine("Consoante");
// }

// switch (letra){
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal"); 
//         break;

//     default:
//         Console.WriteLine("Consoante");
//         break;
// }

// bool ehMaiorDeIdade = false;
// bool possuiAutorizacaoResponsavel=false;

// if (ehMaiorDeIdade || possuiAutorizacaoResponsavel){
//     Console.WriteLine("Entrada Liberada");
// }else {
//     Console.WriteLine("Então não autorizada");
// }

// bool choveu = false;

// if (!choveu){
//     Console.WriteLine("Bora pedal");
// }

Calculadora calc = new Calculadora();

calc.Somar(1,3);
calc.Subtrair(10,5);
calc.Multiplicar (10,20);
calc.Dividir(10,2);
calc.Potencia(3,3);
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);
calc.Raiz(49);