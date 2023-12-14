using ExemploExplorando.Models;
using System.Globalization;
// Pessoa pessoa1 = new Pessoa(nome:"pedro",sobrenome:"souza",idade:30);
// // pessoa1.NomePessoa = "pedro";
// // pessoa1.Sobrenome = "teste";
// // pessoa1.IdadePessoa = 20;

// Pessoa pessoa2 = new Pessoa(nome:"joao",sobrenome:"teste2",idade:30);
// // pessoa2.NomePessoa = "joao";
// // pessoa2.Sobrenome = "teste2";
// // pessoa2.IdadePessoa = 10;

// // pessoa.IdadePessoa = 90;
// // pessoa.Apresentar();


// Curso cursoCSharp = new Curso();
// cursoCSharp.NomeCurso = "CSharp for Dumbies";
// cursoCSharp.Alunos = new List<Pessoa>();

// cursoCSharp.Alunos.Add(pessoa1);
// cursoCSharp.Alunos.Add(pessoa2);
// Console.WriteLine($"Alunos do curso: {cursoCSharp.NomeCurso}");
// cursoCSharp.ListarAlunos();

// decimal valorMonetario = 10653.32M;
// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
// Console.WriteLine(valorMonetario);
// Console.WriteLine($"{valorMonetario:C}");
// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
// Console.WriteLine(valorMonetario.ToString("N2"));
// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P1"));
// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));

DateTime data = DateTime.Now;
Console.WriteLine(data);
Console.WriteLine(data.ToString("dd/MM/yy hh:mm"));
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm:ss"));
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());

string dataString = "2022-13-17 18:03";

bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture,DateTimeStyles.None, out DateTime dataa);


if (sucesso){
    Console.WriteLine(dataa);    
} else {
    Console.WriteLine("Data inválida!");
}
