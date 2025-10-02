//declaração de variáveis.

using System.ComponentModel.Design;

Console.WriteLine("digite o ano atual: ");
int anoatual = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("digite seu ano de nascimento: ");
int anonascimento = int.Parse(Console.ReadLine() ?? "0");

int idade = anoatual - anonascimento;

Console.WriteLine($"idade: {idade} anos.");

if (idade > 16)
    Console.WriteLine("você não pode votar esse ano.");
else if (idade == 16 || idade == 17)
    Console.WriteLine("voto facultativo.");
else if (idade >= 18 && idade <= 69)
    Console.WriteLine("voto obrigatório.");