using ExemploExplorando.Models;

//Antes de usar uma classe é preciso estanciar uma variavel referente esta classe
//A classe é só um modelo
//classe| var = nova classe -> isso quer dizer que a variavel pessoa foi criada com base no modelo definido na 
Pessoa pessoa = new Pessoa();
//após instanciar na memória uma variavel referente o modelo estabelecido na classe Pessoa.
//podemos utilizar as propriedades desse modelo, como nome da pessoa e idade por exemplo
pessoa.nomePessoa = "pedro";
pessoa.idadePessoa = 90;
pessoa.Apresentar();