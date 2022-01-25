using static System.Console;

Pessoa p1 = new Pessoa();

p1.Nome = "Caio";
p1.Idade = 30;
p1.EnderecoPessoa = new Endereco(){
    Logradouro = "Rua Algum Lugar",
    Numero = 360,
    Cidade = "Lugar Nenhum",
    CEP = "31354642"

};